using System.Collections.Generic;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;

namespace RimeLib.Terrain.Resources;

/// <summary>
/// One combination of terrain layers, and the shader that draws it.
/// </summary>
/// <remarks>
/// The shader's name encodes the combination it serves -- MP_017 has one called
/// "..._Terrain__0MD_1MD_2MD_3MD_4MD_5MD__3d__0", meaning layers 0 to 5, each masked and with a
/// diffuse. Its textures are the level's terrain layer textures.
/// </remarks>
public class VisualTerrainDraw
{
    public string Shader { get; set; } = string.Empty;
    /// <summary>Which layers this draw blends, in order.</summary>
    public List<int> Layers { get; set; } = new();
    /// <summary>2d draws paint the ground; 3d draws are the ones with world-space projection.</summary>
    public string Kind { get; set; } = string.Empty;
    public int Level { get; set; }
}

/// <summary>
/// One mesh scattering type on a terrain layer: what the ground grows, and how thickly.
///
/// This is what puts grass, bushes and rubble on a level without placing a single object by hand.
/// Nothing in EBX carries it -- `TerrainMeshScatteringType` there is a bare DataContainer with no
/// fields at all -- so a level exported without this loses its ground cover entirely while
/// appearing to round trip.
/// </summary>
public class VisualTerrainScattering
{
    /// <summary>Which terrain layer grows this.</summary>
    public int Layer { get; set; }
    public string MeshName { get; set; } = string.Empty;
    public uint VariationAssetNameHash { get; set; }
    public float Density { get; set; }
    public bool LockDensity { get; set; }
    public float RandomPositionOffset { get; set; }
    public float MinMask { get; set; }
    public float MaxMask { get; set; }
    public float MinScaleX { get; set; }
    public float MinScaleY { get; set; }
    public float MaxScaleX { get; set; }
    public float MaxScaleY { get; set; }
    public float MinMaskScaleFactorX { get; set; }
    public float MinMaskScaleFactorY { get; set; }
    public float ScaleRandomess { get; set; }
    public float WindScale { get; set; }
    public sbyte FirstSpawnLevel { get; set; }
    public sbyte SpawnLevelCount { get; set; }
    public sbyte RotationMode { get; set; }
    public sbyte OrientationMode { get; set; }
    public float RotateTowardSlopeWeight { get; set; }
    public bool CastShadowsEnable { get; set; }
    public float ShadowViewDistance { get; set; }
    public bool BillboardingEnable { get; set; }
    public bool BillboardingGpuAccelleration { get; set; }
    public sbyte InstanceType { get; set; }
    public bool GroundClampBoundingBoxEnable { get; set; }
}

/// <summary>What a level's terrain is painted with.</summary>
public class VisualTerrainInfo
{
    public string SurfaceShader { get; set; } = string.Empty;
    public string StreamingTree { get; set; } = string.Empty;
    public string Decals { get; set; } = string.Empty;
    public int LayerCount { get; set; }
    /// <summary>Whether each layer draws through a virtual texture.</summary>
    public List<bool> LayerVirtualTexture { get; set; } = new();
    public List<VisualTerrainDraw> Draws { get; set; } = new();
    public uint TextureAtlasWidth { get; set; }
    public uint TextureAtlasHeight { get; set; }
    public float TextureSamplesPerMeterMax { get; set; }
    /// <summary>Every layer's mesh scattering types, flattened, each naming its own layer.</summary>
    public List<VisualTerrainScattering> Scattering { get; set; } = new();
}

/// <summary>
/// Reads a level's VisualTerrain resource: the layers its ground is painted with, and the shaders
/// that blend them. Nothing in EBX carries this.
/// </summary>
public interface IVisualTerrain : IEngineInterface
{
    bool ReadVisualTerrain(IResourceObject p_Resource, IEngineMounter p_Mounter, out VisualTerrainInfo? p_Info);
}
