using System.Collections.Generic;
using System.IO;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.IO;
using RimeLib.Terrain.Frostbite2_0.Frostbite.VisualTerrain;
using RimeLib.Terrain.Resources;

namespace RimeLib.Terrain.Frostbite2_0;

/// <summary>
/// Reads what a level's ground is painted with: its terrain layers and the shaders that blend them.
/// </summary>
public class VisualTerrainReader : IVisualTerrain
{
    public EngineType[] GetSupportedEngines()
    {
        return [EngineType.Frostbite2_0];
    }

    public bool ReadVisualTerrain(IResourceObject p_Resource, IEngineMounter p_Mounter, out VisualTerrainInfo? p_Info)
    {
        p_Info = null;

        VisualTerrain s_Terrain;

        using (var s_Stream = p_Resource.GetReader())
        using (var s_Reader = new RimeReader(s_Stream))
            s_Terrain = new VisualTerrain(s_Reader);

        var s_Info = new VisualTerrainInfo
        {
            SurfaceShader = s_Terrain.SurfaceShaderName,
            StreamingTree = s_Terrain.StreamingTreeResourceName,
            Decals = s_Terrain.DecalsResourceName,
            LayerCount = s_Terrain.Layers.Length,
            TextureAtlasWidth = s_Terrain.TextureAtlasSampleCountX,
            TextureAtlasHeight = s_Terrain.TextureAtlasSampleCountY,
            TextureSamplesPerMeterMax = s_Terrain.TextureSamplesPerMeterMax
        };

        for (var s_LayerIndex = 0; s_LayerIndex < s_Terrain.Layers.Length; s_LayerIndex++)
        {
            var l_Layer = s_Terrain.Layers[s_LayerIndex];
            s_Info.LayerVirtualTexture.Add(l_Layer.VirtualTextureEnable);

            // Scattering is per LAYER, so the layer index has to travel with it -- the mesh alone
            // does not say where on the ground it grows.
            for (var s_ScatterIndex = 0; s_ScatterIndex < l_Layer.ScatteringTypes.Length; s_ScatterIndex++)
            {
                var l_Scatter = l_Layer.ScatteringTypes[s_ScatterIndex];

                s_Info.Scattering.Add(new VisualTerrainScattering
                {
                    Layer = s_LayerIndex,
                    Index = s_ScatterIndex,
                    MeshName = l_Scatter.MeshName,
                    VariationAssetNameHash = l_Scatter.VariationAssetNameHash,
                    Density = l_Scatter.Density,
                    LockDensity = l_Scatter.LockDensity,
                    RandomPositionOffset = l_Scatter.RandomPositionOffset,
                    MinMask = l_Scatter.MinMask,
                    MaxMask = l_Scatter.MaxMask,
                    MinScaleX = l_Scatter.MinScaleX,
                    MinScaleY = l_Scatter.MinScaleY,
                    MaxScaleX = l_Scatter.MaxScaleX,
                    MaxScaleY = l_Scatter.MaxScaleY,
                    MinMaskScaleFactorX = l_Scatter.MinMaskScaleFactorX,
                    MinMaskScaleFactorY = l_Scatter.MinMaskScaleFactorY,
                    ScaleRandomess = l_Scatter.ScaleRandomess,
                    WindScale = l_Scatter.WindScale,
                    FirstSpawnLevel = l_Scatter.FirstSpawnLevel,
                    SpawnLevelCount = l_Scatter.SpawnLevelCount,
                    RotationMode = l_Scatter.RotationMode,
                    OrientationMode = l_Scatter.OrientationMode,
                    RotateTowardSlopeWeight = l_Scatter.RotateTowardSlopeWeight,
                    CastShadowsEnable = l_Scatter.CastShadowsEnable,
                    ShadowViewDistance = l_Scatter.ShadowViewDistance,
                    BillboardingEnable = l_Scatter.BillboardingEnable,
                    BillboardingGpuAccelleration = l_Scatter.BillboardingGpuAccelleration,
                    InstanceType = l_Scatter.InstanceType,
                    GroundClampBoundingBoxEnable = l_Scatter.GroundClampBoundingBoxEnable
                });
            }
        }

        foreach (var l_Combination in s_Terrain.TerrainLayerCombinationDraws)
        {
            foreach (var l_Draw in l_Combination.Surface2dDrawMethods)
            {
                s_Info.Draws.Add(new VisualTerrainDraw
                {
                    Shader = l_Draw.ShaderName,
                    Layers = new System.Collections.Generic.List<int>(
                        System.Array.ConvertAll(l_Draw.MaskedTerrainLayerIndices, p_Index => (int)p_Index)),
                    Kind = "2d"
                });
            }

            foreach (var l_Draw in l_Combination.Surface3dDrawMethods)
            {
                s_Info.Draws.Add(new VisualTerrainDraw
                {
                    Shader = l_Draw.ShaderName,
                    Layers = new System.Collections.Generic.List<int>(
                        System.Array.ConvertAll(l_Draw.MaskedTerrainLayerIndices, p_Index => (int)p_Index)),
                    Kind = "3d",
                    Level = l_Draw.Level
                });
            }
        }

        p_Info = s_Info;

        return true;
    }

    public bool RoundTripVisualTerrain(IResourceObject p_Resource, out byte[]? p_Original, out byte[]? p_Rebuilt)
    {
        p_Original = null;
        p_Rebuilt = null;

        // The shipped bytes are kept whole rather than measured as they are read: the comparison is
        // only worth anything against the file the game actually ships.
        using (var s_Stream = p_Resource.GetReader())
        using (var s_Buffer = new MemoryStream())
        {
            s_Stream.CopyTo(s_Buffer);
            p_Original = s_Buffer.ToArray();
        }

        VisualTerrain s_Terrain;

        using (var s_Reader = new RimeReader(new MemoryStream(p_Original, false)))
            s_Terrain = new VisualTerrain(s_Reader);

        return s_Terrain.Serialize(out p_Rebuilt);
    }

    public bool WriteVisualTerrain(IResourceObject p_Resource, VisualTerrainInfo p_Edits, out byte[]? p_Data,
        out string? p_Error)
    {
        p_Data = null;
        p_Error = null;

        VisualTerrain s_Terrain;

        using (var s_Stream = p_Resource.GetReader())
        using (var s_Reader = new RimeReader(s_Stream))
            s_Terrain = new VisualTerrain(s_Reader);

        // Layer flags are optional: a caller editing only scattering should not have to restate
        // them. When they ARE given the count has to agree, because a short list would otherwise
        // silently leave the tail of the layers untouched.
        if (p_Edits.LayerVirtualTexture.Count > 0)
        {
            if (p_Edits.LayerVirtualTexture.Count != s_Terrain.Layers.Length)
            {
                p_Error = $"LayerVirtualTexture has {p_Edits.LayerVirtualTexture.Count} entries but the " +
                          $"resource has {s_Terrain.Layers.Length} layers.";
                return false;
            }

            for (var s_Index = 0; s_Index < s_Terrain.Layers.Length; s_Index++)
                s_Terrain.Layers[s_Index].VirtualTextureEnable = p_Edits.LayerVirtualTexture[s_Index];
        }

        // (Layer, Index) is the address of a scattering record. Two edits landing on the same one
        // means the caller lost track of which record is which -- the second would overwrite the
        // first and the loss would not show up anywhere, so it is an error instead.
        var s_Applied = new HashSet<(int, int)>();

        foreach (var l_Edit in p_Edits.Scattering)
        {
            if (l_Edit.Layer < 0 || l_Edit.Layer >= s_Terrain.Layers.Length)
            {
                p_Error = $"Scattering edit names layer {l_Edit.Layer}, which the resource does not have " +
                          $"({s_Terrain.Layers.Length} layers).";
                return false;
            }

            var s_Layer = s_Terrain.Layers[l_Edit.Layer];

            if (l_Edit.Index < 0 || l_Edit.Index >= s_Layer.ScatteringTypes.Length)
            {
                p_Error = $"Scattering edit names index {l_Edit.Index} on layer {l_Edit.Layer}, which has " +
                          $"{s_Layer.ScatteringTypes.Length} scattering type(s).";
                return false;
            }

            if (!s_Applied.Add((l_Edit.Layer, l_Edit.Index)))
            {
                p_Error = $"Two scattering edits address layer {l_Edit.Layer} index {l_Edit.Index}.";
                return false;
            }

            var s_Type = s_Layer.ScatteringTypes[l_Edit.Index];

            s_Type.MeshName = l_Edit.MeshName;
            s_Type.VariationAssetNameHash = l_Edit.VariationAssetNameHash;
            s_Type.Density = l_Edit.Density;
            s_Type.LockDensity = l_Edit.LockDensity;
            s_Type.RandomPositionOffset = l_Edit.RandomPositionOffset;
            s_Type.MinMask = l_Edit.MinMask;
            s_Type.MaxMask = l_Edit.MaxMask;
            s_Type.MinScaleX = l_Edit.MinScaleX;
            s_Type.MinScaleY = l_Edit.MinScaleY;
            s_Type.MaxScaleX = l_Edit.MaxScaleX;
            s_Type.MaxScaleY = l_Edit.MaxScaleY;
            s_Type.MinMaskScaleFactorX = l_Edit.MinMaskScaleFactorX;
            s_Type.MinMaskScaleFactorY = l_Edit.MinMaskScaleFactorY;
            s_Type.ScaleRandomess = l_Edit.ScaleRandomess;
            s_Type.WindScale = l_Edit.WindScale;
            s_Type.FirstSpawnLevel = l_Edit.FirstSpawnLevel;
            s_Type.SpawnLevelCount = l_Edit.SpawnLevelCount;
            s_Type.RotationMode = l_Edit.RotationMode;
            s_Type.OrientationMode = l_Edit.OrientationMode;
            s_Type.RotateTowardSlopeWeight = l_Edit.RotateTowardSlopeWeight;
            s_Type.CastShadowsEnable = l_Edit.CastShadowsEnable;
            s_Type.ShadowViewDistance = l_Edit.ShadowViewDistance;
            s_Type.BillboardingEnable = l_Edit.BillboardingEnable;
            s_Type.BillboardingGpuAccelleration = l_Edit.BillboardingGpuAccelleration;
            s_Type.InstanceType = l_Edit.InstanceType;
            s_Type.GroundClampBoundingBoxEnable = l_Edit.GroundClampBoundingBoxEnable;
        }

        // The draw shaders come back too, addressed by their position in the flattened 2d-then-3d
        // order the reader emits. Their layer index lists are NOT taken from the edit: those are
        // what the shader was compiled against, and a list that no longer matches the shader name
        // is a level that draws the wrong ground.
        if (p_Edits.Draws.Count > 0)
        {
            var s_DrawIndex = 0;

            foreach (var l_Combination in s_Terrain.TerrainLayerCombinationDraws)
                s_DrawIndex += l_Combination.Surface2dDrawMethods.Length + l_Combination.Surface3dDrawMethods.Length;

            if (p_Edits.Draws.Count != s_DrawIndex)
            {
                p_Error = $"Draws has {p_Edits.Draws.Count} entries but the resource has {s_DrawIndex}.";
                return false;
            }

            s_DrawIndex = 0;

            foreach (var l_Combination in s_Terrain.TerrainLayerCombinationDraws)
            {
                foreach (var l_Draw in l_Combination.Surface2dDrawMethods)
                    l_Draw.ShaderName = p_Edits.Draws[s_DrawIndex++].Shader;

                foreach (var l_Draw in l_Combination.Surface3dDrawMethods)
                    l_Draw.ShaderName = p_Edits.Draws[s_DrawIndex++].Shader;
            }
        }

        if (!s_Terrain.Serialize(out p_Data))
        {
            p_Error = "The VisualTerrain writer refused to serialize.";
            return false;
        }

        return true;
    }
}
