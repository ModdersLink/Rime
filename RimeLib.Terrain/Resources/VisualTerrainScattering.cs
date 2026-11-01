using System.Collections.Generic;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;

namespace RimeLib.Terrain.Resources;

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

    /// <summary>
    /// Position of this type WITHIN its layer, counting from 0.
    ///
    /// This exists so a writeback can find the record an edit belongs to. The obvious alternative,
    /// matching on MeshName, is ambiguous by construction: a layer is allowed to grow the same mesh
    /// twice at different densities, and MP_007 does. It is also fragile the moment the mesh itself
    /// is what was edited. (Layer, Index) is the record's address and survives both.
    /// </summary>
    public int Index { get; set; }

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
