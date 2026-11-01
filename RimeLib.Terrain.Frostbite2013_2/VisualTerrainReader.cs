using System.Collections.Generic;
using System.IO;
using System.Linq;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.Terrain.Frostbite2013_2.Frostbite;
using RimeLib.Terrain.Resources;

namespace RimeLib.Terrain.Frostbite2013_2;

/// <summary>
/// Reads and writes BF4's VisualTerrain (layers and their scattering) and TerrainLayerCombinations
/// (the shaders that draw the layers).
/// </summary>
public class VisualTerrainReader : IVisualTerrain, ITerrainLayerCombinations
{
    public EngineType[] GetSupportedEngines() => [EngineType.Frostbite2013_2];

    private static byte[] ReadAll(IResourceObject p_Resource)
    {
        using var s_Stream = p_Resource.GetReader();
        using var s_Buffer = new MemoryStream();
        s_Stream.CopyTo(s_Buffer);
        return s_Buffer.ToArray();
    }

    public bool ReadVisualTerrain(IResourceObject p_Resource, IEngineMounter p_Mounter, out VisualTerrainInfo? p_Info)
    {
        var s_Terrain = VisualTerrain.Read(ReadAll(p_Resource));

        // No surface shader, streaming tree, decals or draws: BF4 keeps them elsewhere (see
        // ITerrainLayerCombinations), and no per-layer virtual texture flag.
        p_Info = new VisualTerrainInfo
        {
            LayerCount = s_Terrain.Layers.Length,
            TextureAtlasWidth = s_Terrain.TextureAtlasSampleCountX,
            TextureAtlasHeight = s_Terrain.TextureAtlasSampleCountY,
            TextureSamplesPerMeterMax = s_Terrain.TextureSamplesPerMeterMax,
        };

        for (var s_LayerIndex = 0; s_LayerIndex < s_Terrain.Layers.Length; s_LayerIndex++)
        {
            var s_Types = s_Terrain.Layers[s_LayerIndex].ScatteringTypes;
            for (var s_Index = 0; s_Index < s_Types.Length; s_Index++)
                p_Info.Scattering.Add(ToInfo(s_Types[s_Index], s_LayerIndex, s_Index));
        }

        return true;
    }

    // The fields BF4's record shares with Frostbite 2's. Density is the ultra quality level's.
    private static VisualTerrainScattering ToInfo(MeshScatteringType p_Type, int p_Layer, int p_Index) => new()
    {
        Layer = p_Layer,
        Index = p_Index,
        MeshName = p_Type.MeshName,
        VariationAssetNameHash = p_Type.VariationAssetNameHash,
        Density = p_Type.Density[3],
        RandomPositionOffset = p_Type.RandomPositionOffset,
        MinMask = p_Type.MinMask,
        MaxMask = p_Type.MaxMask,
        MinScaleX = p_Type.MinScaleX,
        MinScaleY = p_Type.MinScaleY,
        MaxScaleX = p_Type.MaxScaleX,
        MaxScaleY = p_Type.MaxScaleY,
        MinMaskScaleFactorX = p_Type.MinMaskScaleFactorX,
        MinMaskScaleFactorY = p_Type.MinMaskScaleFactorY,
        ScaleRandomess = p_Type.ScaleRandomness,
        WindScale = p_Type.WindScale,
        InstanceType = (sbyte)p_Type.InstanceType,
    };

    public bool RoundTripVisualTerrain(IResourceObject p_Resource, out byte[]? p_Original, out byte[]? p_Rebuilt)
    {
        p_Original = ReadAll(p_Resource);
        return VisualTerrain.Read(p_Original).Serialize(out p_Rebuilt);
    }

    /// <summary>
    /// Applies the scattering edits onto the shipped resource. Only the fields <see cref="ToInfo"/>
    /// gives are taken from an edit; the rest of each record stays as shipped. A density edit sets
    /// every quality level. Layer flags and draws are refused: BF4's VisualTerrain has neither.
    /// </summary>
    public bool WriteVisualTerrain(IResourceObject p_Resource, VisualTerrainInfo p_Edits, out byte[]? p_Data, out string? p_Error)
    {
        p_Data = null;
        p_Error = null;

        if (p_Edits.LayerVirtualTexture.Count > 0 || p_Edits.Draws.Count > 0)
        {
            p_Error = "BF4's VisualTerrain has no layer virtual texture flags or draws; the draws are in TerrainLayerCombinations.";
            return false;
        }

        var s_Terrain = VisualTerrain.Read(ReadAll(p_Resource));
        var s_Applied = new HashSet<(int, int)>();

        foreach (var s_Edit in p_Edits.Scattering)
        {
            if (s_Edit.Layer < 0 || s_Edit.Layer >= s_Terrain.Layers.Length)
            {
                p_Error = $"Scattering edit names layer {s_Edit.Layer}, which the resource does not have ({s_Terrain.Layers.Length} layers).";
                return false;
            }

            var s_Types = s_Terrain.Layers[s_Edit.Layer].ScatteringTypes;
            if (s_Edit.Index < 0 || s_Edit.Index >= s_Types.Length)
            {
                p_Error = $"Scattering edit names index {s_Edit.Index} on layer {s_Edit.Layer}, which has {s_Types.Length} scattering type(s).";
                return false;
            }

            if (!s_Applied.Add((s_Edit.Layer, s_Edit.Index)))
            {
                p_Error = $"Two scattering edits address layer {s_Edit.Layer} index {s_Edit.Index}.";
                return false;
            }

            var s_Type = s_Types[s_Edit.Index];
            if (s_Edit.InstanceType != (sbyte)s_Type.InstanceType)
            {
                p_Error = $"Layer {s_Edit.Layer} index {s_Edit.Index}: changing the instance type changes the record's layout, which is not supported.";
                return false;
            }

            s_Type.MeshName = s_Edit.MeshName;
            s_Type.VariationAssetNameHash = s_Edit.VariationAssetNameHash;
            if (s_Edit.Density != s_Type.Density[3])
                s_Type.Density = Enumerable.Repeat(s_Edit.Density, 4).ToArray();
            s_Type.RandomPositionOffset = s_Edit.RandomPositionOffset;
            s_Type.MinMask = s_Edit.MinMask;
            s_Type.MaxMask = s_Edit.MaxMask;
            s_Type.MinScaleX = s_Edit.MinScaleX;
            s_Type.MinScaleY = s_Edit.MinScaleY;
            s_Type.MaxScaleX = s_Edit.MaxScaleX;
            s_Type.MaxScaleY = s_Edit.MaxScaleY;
            s_Type.MinMaskScaleFactorX = s_Edit.MinMaskScaleFactorX;
            s_Type.MinMaskScaleFactorY = s_Edit.MinMaskScaleFactorY;
            s_Type.ScaleRandomness = s_Edit.ScaleRandomess;
            s_Type.WindScale = s_Edit.WindScale;
        }

        return s_Terrain.Serialize(out p_Data);
    }

    public bool ReadLayerCombinations(IResourceObject p_Resource, out VisualTerrainInfo? p_Info)
    {
        var s_Combinations = TerrainLayerCombinations.Read(ReadAll(p_Resource));
        p_Info = new VisualTerrainInfo { SurfaceShader = s_Combinations.DefaultSurfaceShaderName };

        foreach (var s_Draw in s_Combinations.Draws)
        {
            foreach (var s_Method in s_Draw.MaskScaleDrawMethods)
                p_Info.Draws.Add(new VisualTerrainDraw { Shader = s_Method.ShaderName, Layers = s_Method.MaskedTerrainLayerIndices.Select(p_I => (int)p_I).ToList(), Kind = "maskscale", Level = s_Method.Level });
            foreach (var s_Method in s_Draw.Surface2dDrawMethods)
                p_Info.Draws.Add(new VisualTerrainDraw { Shader = s_Method.ShaderName, Layers = s_Method.MaskedTerrainLayerIndices.Select(p_I => (int)p_I).ToList(), Kind = "2d" });
            foreach (var s_Method in s_Draw.Surface3dDrawMethods)
                p_Info.Draws.Add(new VisualTerrainDraw { Shader = s_Method.ShaderName, Layers = s_Method.MaskedTerrainLayerIndices.Select(p_I => (int)p_I).ToList(), Kind = "3d", Level = s_Method.Level });
        }

        return true;
    }

    public bool RoundTripLayerCombinations(IResourceObject p_Resource, out byte[]? p_Original, out byte[]? p_Rebuilt)
    {
        p_Original = ReadAll(p_Resource);
        return TerrainLayerCombinations.Read(p_Original).Serialize(out p_Rebuilt);
    }
}
