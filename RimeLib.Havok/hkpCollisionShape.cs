using System.Numerics;

namespace RimeLib.Havok;

/// <summary>
/// One collision shape read back out of a HavokPhysicsData resource.
///
/// Writing collision was already possible; reading it was not, so the game's own collision could be
/// carried but never EDITED -- you could add a wall, not move one. Both shapes BF3 actually uses are
/// covered: a box, and a convex hull whose vertices are stored four-at-a-time in SIMD order.
/// </summary>
public class hkpCollisionShape
{
    /// <summary>"box" or "convex".</summary>
    public string Kind { get; set; } = string.Empty;

    /// <summary>Where the wrapping hkpConvexTranslateShape puts it, if there is one.</summary>
    public Vector3 Centre { get; set; }

    public float Radius { get; set; }

    /// <summary>Box only: half the extent on each axis.</summary>
    public Vector3 HalfExtents { get; set; }

    /// <summary>Convex only, in the shape's own space.</summary>
    public List<Vector3> Vertices { get; set; } = new();

    /// <summary>
    /// Convex only: the hull's face planes as n.p + w = 0.
    ///
    /// Carried because the game HAS them and reconstructing a hull from bare vertices needs a
    /// convex-hull solver that is not present anywhere in this toolchain. Extracting what is
    /// already stored is exact and free; deriving it would be neither.
    /// </summary>
    public List<Vector4> Planes { get; set; } = new();

    /// <summary>Section-relative offset of the shape itself, for matching against a rebuild.</summary>
    public long Offset { get; set; }
}
