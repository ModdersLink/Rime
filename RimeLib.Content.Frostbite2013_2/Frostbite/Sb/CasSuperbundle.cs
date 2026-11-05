using RimeLib.Content.Frostbite2013_2.Frostbite.Bundles;
using RimeLib.Frostbite.Db;

namespace RimeLib.Content.Frostbite2013_2.Frostbite.Sb;

/// <summary>The sb of a cas superbundle: the manifests of its bundles, which the toc points into.</summary>
public class CasSuperbundle : DbObjectSerializable
{
    [DbObjectField("bundles")]
    public CasBundle[] Bundles { get; set; } = [];
}
