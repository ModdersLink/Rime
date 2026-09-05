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
            foreach (var l_Scatter in l_Layer.ScatteringTypes)
            {
                s_Info.Scattering.Add(new VisualTerrainScattering
                {
                    Layer = s_LayerIndex,
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
}
