using System.Numerics;

namespace RimeLib.Havok;

/// <summary>
/// Where a shape ends up: a rotation and a translation, composed down the wrapper chain.
///
/// Havok stores an hkTransform as three ROTATION COLUMNS followed by the translation, so this keeps
/// the columns rather than a Matrix4x4 -- System.Numerics is row-vector and silently transposes the
/// convention, which is exactly the kind of error that produces a building that looks plausible and
/// is mirrored.
/// </summary>
public readonly struct hkpPlacement
{
    public Vector3 Column0 { get; }
    public Vector3 Column1 { get; }
    public Vector3 Column2 { get; }
    public Vector3 Translation { get; }

    public static readonly hkpPlacement Identity =
        new(new Vector3(1, 0, 0), new Vector3(0, 1, 0), new Vector3(0, 0, 1), Vector3.Zero);

    public hkpPlacement(Vector3 p_Column0, Vector3 p_Column1, Vector3 p_Column2, Vector3 p_Translation)
    {
        Column0 = p_Column0;
        Column1 = p_Column1;
        Column2 = p_Column2;
        Translation = p_Translation;
    }

    public static hkpPlacement FromTranslation(Vector3 p_Translation)
    {
        return new hkpPlacement(Identity.Column0, Identity.Column1, Identity.Column2, p_Translation);
    }

    public Vector3 Apply(Vector3 p_Local)
    {
        return Column0 * p_Local.X + Column1 * p_Local.Y + Column2 * p_Local.Z + Translation;
    }

    /// <summary>This placement applied on TOP of <paramref name="p_Child"/>: outer(inner(v)).</summary>
    public hkpPlacement Compose(hkpPlacement p_Child)
    {
        return new hkpPlacement(
            Column0 * p_Child.Column0.X + Column1 * p_Child.Column0.Y + Column2 * p_Child.Column0.Z,
            Column0 * p_Child.Column1.X + Column1 * p_Child.Column1.Y + Column2 * p_Child.Column1.Z,
            Column0 * p_Child.Column2.X + Column1 * p_Child.Column2.Y + Column2 * p_Child.Column2.Z,
            Apply(p_Child.Translation));
    }

    /// <summary>
    /// The determinant of the rotation part. A guard, not a feature: a real Havok placement is a
    /// rigid transform, so this is 1 -- anything else means the columns were read at the wrong
    /// offset, which no amount of plausible-looking geometry would reveal.
    /// </summary>
    public float Determinant()
    {
        return Vector3.Dot(Column0, Vector3.Cross(Column1, Column2));
    }
}
