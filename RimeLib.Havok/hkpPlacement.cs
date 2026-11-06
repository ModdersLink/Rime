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

    /// <summary>
    /// Set for a placement that is an hkQsTransform (a rotation and a per-axis scale, Havok 2012):
    /// two of those compose as Havok composes them, rotations multiplied and scales multiplied per
    /// axis, which a product of matrices does not reproduce once a scale is not uniform.
    /// </summary>
    public Quaternion? Rotation { get; }
    public Vector3 Scale { get; }

    public static readonly hkpPlacement Identity = FromQsTransform(Vector3.Zero, Quaternion.Identity, Vector3.One);

    public hkpPlacement(Vector3 p_Column0, Vector3 p_Column1, Vector3 p_Column2, Vector3 p_Translation)
    {
        Column0 = p_Column0;
        Column1 = p_Column1;
        Column2 = p_Column2;
        Translation = p_Translation;
        Rotation = null;
        Scale = Vector3.One;
    }

    private hkpPlacement(Vector3 p_Translation, Quaternion p_Rotation, Vector3 p_Scale)
    {
        Column0 = Vector3.Transform(Vector3.UnitX, p_Rotation) * p_Scale.X;
        Column1 = Vector3.Transform(Vector3.UnitY, p_Rotation) * p_Scale.Y;
        Column2 = Vector3.Transform(Vector3.UnitZ, p_Rotation) * p_Scale.Z;
        Translation = p_Translation;
        Rotation = p_Rotation;
        Scale = p_Scale;
    }

    /// <summary>An hkQsTransform: scale, then rotate, then translate.</summary>
    public static hkpPlacement FromQsTransform(Vector3 p_Translation, Quaternion p_Rotation, Vector3 p_Scale)
    {
        return new hkpPlacement(p_Translation, p_Rotation, p_Scale);
    }

    public static hkpPlacement FromTranslation(Vector3 p_Translation)
    {
        return FromQsTransform(p_Translation, Quaternion.Identity, Vector3.One);
    }

    public Vector3 Apply(Vector3 p_Local)
    {
        return Column0 * p_Local.X + Column1 * p_Local.Y + Column2 * p_Local.Z + Translation;
    }

    /// <summary>This placement applied on TOP of <paramref name="p_Child"/>: outer(inner(v)).</summary>
    public hkpPlacement Compose(hkpPlacement p_Child)
    {
        // hkQsTransform::setMul: the child's translation scaled and rotated by this one, rotations
        // and scales multiplied.
        if (Rotation is { } s_Rotation && p_Child.Rotation is { } s_ChildRotation)
            return FromQsTransform(Translation + Vector3.Transform(Scale * p_Child.Translation, s_Rotation),
                                   s_Rotation * s_ChildRotation, Scale * p_Child.Scale);

        return new hkpPlacement(
            Column0 * p_Child.Column0.X + Column1 * p_Child.Column0.Y + Column2 * p_Child.Column0.Z,
            Column0 * p_Child.Column1.X + Column1 * p_Child.Column1.Y + Column2 * p_Child.Column1.Z,
            Column0 * p_Child.Column2.X + Column1 * p_Child.Column2.Y + Column2 * p_Child.Column2.Z,
            Apply(p_Child.Translation));
    }

    /// <summary>
    /// The determinant of the rotation part. A guard, not a feature: a Havok 2010 placement is a
    /// rigid transform, so this is 1, and a Havok 2012 one the product of its scale; anything else
    /// means the columns were read at the wrong offset.
    /// </summary>
    public float Determinant()
    {
        return Vector3.Dot(Column0, Vector3.Cross(Column1, Column2));
    }
}
