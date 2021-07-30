using System;
using RimeLib.Frostbite.Core;
using RimeLib.Frostbite.Db;

namespace RimeLib.Content.Frostbite2_0.Frostbite.Sb
{
    /// <summary>
    /// Bundle information object.
    /// There are currently 3 different layouts for Venice:
    /// 1. { id, offset, size, checksum }
    /// 2. { id, offset, size, base, checksum }
    /// 3. { id, offset, size, delta, checksum }
    /// </summary>
    public class BundleInfo : DbObjectSerializable
    {
        [DbObjectField("id")]
        public string Id { get; set; } = "";

        [DbObjectField("offset")]
        public long Offset { get; set; }

        [DbObjectField("size")]
        public long Size { get; set; }

        [DbObjectField("checksum")]
        public Sha1? Checksum { get; set; } = null;
        
        [DbObjectField("base")]
        public bool? Base { get; set; }
        
        [DbObjectField("delta")]
        public bool? Delta { get; set; }
    }

    /// <summary>
    /// Chunk information object.
    /// There are currently 2 different layouts for Venice:
    /// 1. { id, sha1 }
    /// 2. { id, offset, size }
    /// </summary>
    public class ChunkInfo : DbObjectSerializable
    {
        [DbObjectField("id")]
        public GUID Id { get; set; } = Guid.Empty;

        [DbObjectField("sha1")]
        public Sha1? Sha1 { get; set; }

        [DbObjectField("offset")]
        public long? Offset { get; set; }

        [DbObjectField("size")]
        public long? Size { get; set; }
    }

    public class SuperbundleLayout : DbObjectSerializable
    {
        [DbObjectField("tag")]
        public GUID? Tag { get; set; }

        [DbObjectField("name")]
        public string? Name { get; set; }

        [DbObjectField("cas", DefaultValue = false)]
        public bool Cas { get; set; }

        [DbObjectField("alwaysEmitSuperbundle")]
        public bool? AlwaysEmitSuperbundle { get; set; }

        [DbObjectField("bundles")]
        public BundleInfo[] Bundles { get; set; } = new BundleInfo[0];

        [DbObjectField("chunks")]
        public ChunkInfo[] Chunks { get; set; } = new ChunkInfo[0];

        public bool TryGetBundle(string p_Id, out BundleInfo? p_Bundle)
        {
            p_Bundle = null;

            foreach (var s_Bundle in Bundles)
            {
                if (!s_Bundle.Id.Equals(p_Id, StringComparison.OrdinalIgnoreCase)) 
                    continue;
                
                p_Bundle = s_Bundle;
                return true;
            }

            return false;
        }
    }
}
