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
    /// <summary>"box", "convex", "cylinder", "sphere", "capsule" or "mesh".</summary>
    public string Kind { get; set; } = string.Empty;

    /// <summary>Where the wrapper chain puts this placement of the shape.</summary>
    public Vector3 Centre { get; set; }

    /// <summary>
    /// The rotation the wrapper chain gives this placement, as Havok stores it: three COLUMNS.
    ///
    /// Identity for an unrotated placement. This is not cosmetic -- BF3 places 52,448 of its shapes
    /// through hkpConvexTransformShape, which carries a full rotation, against 102,842 through the
    /// translation-only hkpConvexTranslateShape.
    /// </summary>
    public hkpPlacement Placement { get; set; } = hkpPlacement.Identity;

    public float Radius { get; set; }

    /// <summary>Box only: half the extent on each axis.</summary>
    public Vector3 HalfExtents { get; set; }

    /// <summary>Convex and mesh, in the shape's own space.</summary>
    public List<Vector3> Vertices { get; set; } = new();

    /// <summary>
    /// Mesh only: three corner indices per triangle, into <see cref="Vertices"/>.
    ///
    /// The fourth index Havok stores per triangle is dropped -- the stride is four and only three
    /// are corners.
    /// </summary>
    public List<int> Indices { get; set; } = new();

    /// <summary>
    /// Convex only: the hull's face planes as n.p + w = 0.
    ///
    /// Carried because the game HAS them and reconstructing a hull from bare vertices needs a
    /// convex-hull solver that is not present anywhere in this toolchain. Extracting what is
    /// already stored is exact and free; deriving it would be neither.
    /// </summary>
    public List<Vector4> Planes { get; set; } = new();

    /// <summary>Cylinder and capsule only: the two ends of the axis, in the shape's own space.</summary>
    public Vector3 VertexA { get; set; }

    public Vector3 VertexB { get; set; }

    /// <summary>
    /// Cylinder only: the barrel radius.
    ///
    /// Separate from <see cref="Radius"/>, which is hkpConvexShape's convex radius -- the small
    /// inflation every convex shape carries. Conflating them would make every cylinder the wrong
    /// size by two orders of magnitude.
    /// </summary>
    public float CylinderRadius { get; set; }

    /// <summary>Section-relative offset of the shape itself, for matching against a rebuild.</summary>
    public long Offset { get; set; }

    /// <summary>
    /// Section-relative offset of the wrapper that placed it, or the shape's own offset when it is
    /// placed directly.
    ///
    /// A shape can be INSTANCED -- BigRadioTower has 26 distinct boxes placed 69 times -- so
    /// <see cref="Offset"/> is not unique across a resource's placements and this is what tells two
    /// of them apart.
    /// </summary>
    public long PlacementOffset { get; set; }
}
