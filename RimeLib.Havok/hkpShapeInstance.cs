namespace RimeLib.Havok;

/// <summary>
/// A placement of shapes that numbers parts of its own, as a static model group's member is: the
/// shapes under it are shared with the other members of the same model.
/// </summary>
public class hkpShapeInstance
{
    /// <summary>The instance's position among those of its root.</summary>
    public int Index { get; set; }

    /// <summary>Where the instance is in the resource.</summary>
    public hkpPlacement Placement { get; set; } = hkpPlacement.Identity;

    /// <summary>The resource part of the instance's first part; the shapes under it number theirs from it.</summary>
    public int FirstPart { get; set; }

    public int PartCount { get; set; }
}
