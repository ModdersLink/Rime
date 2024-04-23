using RimeLib.Frostbite.Core;
using RimeLib.Frostbite.Db;

namespace RimeLib.Content.Frostbite2014_4.Frostbite.Sb;

/// <summary>
/// Bundle information object.
/// </summary>
public class BundleBlock_NFSEdge : DbObjectSerializable
{
    [DbObjectField("names")]
    public string[] Names { get; set; } = new string[0];
    [DbObjectField("offsets")]
    public long[] Offsets { get; set; } = new long[0];
    [DbObjectField("sizes")]
    public long[] Sizes { get; set; } = new long[0];

    
}

public class SuperbundleLayout_NFSEdge : DbObjectSerializable
{
    [DbObjectField("tag")]
    public GUID? Tag { get; set; }

    [DbObjectField("bundles")]
    public BundleBlock_NFSEdge? Bundles { get; set; } = null;

    [DbObjectField("chunks")]
    public ChunkInfo[] Chunks { get; set; } = new ChunkInfo[0];

    [DbObjectField("name")]
    public string? Name { get; set; }

    [DbObjectField("cas", DefaultValue = false)]
    public bool? Cas { get; set; }
    [DbObjectField("das", DefaultValue = false)]
    public bool? Das { get; set; }
    
    [DbObjectField("totalSize")]
    public long? TotalSize { get; set; }

    [DbObjectField("alwaysEmitSuperbundle")]
    public bool? AlwaysEmitSuperbundle { get; set; }


    public IEnumerable<BundleInfo> GetBundleInfos()
    {
        if (Bundles != null)
        {
            foreach (var s_BundleIndex in Enumerable.Range(0, Bundles.Names.Length))
            {
                yield return new BundleInfo
                {
                    Id = Bundles.Names[s_BundleIndex],
                    Offset = Bundles.Offsets[s_BundleIndex],
                    Size = Bundles.Sizes[s_BundleIndex]
                };
            }
        }
    }
    
    
    public bool TryGetBundle(string p_Id, out BundleInfo? p_Bundle)
    {
        p_Bundle = null;

        if (Bundles == null)
            return false;

        foreach (var s_BundleIndex in Enumerable.Range(0, Bundles.Names.Length))
        {
            if (!Bundles.Names[s_BundleIndex].Equals(p_Id, StringComparison.OrdinalIgnoreCase)) 
                continue;
            
            p_Bundle = new BundleInfo
            {
                Id = Bundles.Names[s_BundleIndex],
                Offset = Bundles.Offsets[s_BundleIndex],
                Size = Bundles.Sizes[s_BundleIndex]
            };
            return true;
        }

        return false;
    }
}