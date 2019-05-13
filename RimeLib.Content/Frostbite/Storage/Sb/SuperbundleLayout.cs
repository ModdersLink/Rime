using System;
using RimeLib.Frostbite.Core;
using RimeLib.Frostbite.Db;

namespace RimeLib.Content.Frostbite.Storage.Sb
{
    // TODO: Separate these into a Venice-specific module.

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
        public GUID Id { get; set; } = Guid.Empty;

        [DbObjectField("offset")]
        public int Offset { get; set; }

        [DbObjectField("size")]
        public int Size { get; set; }

        [DbObjectField("checksum")]
        public Sha1 Checksum { get; set; } = new Sha1();
        
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
        public int? Offset { get; set; }

        [DbObjectField("size")]
        public int? Size { get; set; }
    }

    public class SuperbundleLayout<TBundleInfo, TChunkInfo> : DbObjectSerializable
        where TBundleInfo : BundleInfo
        where TChunkInfo : ChunkInfo
    {
        [DbObjectField("tag")]
        public GUID? Tag { get; set; }

        [DbObjectField("name")]
        public string Name { get; set; } = "";

        [DbObjectField("cas", DefaultValue = false)]
        public bool Cas { get; set; }

        [DbObjectField("alwaysEmitSuperbundle")]
        public bool AlwaysEmitSuperbundle { get; set; }

        [DbObjectField("bundles")]
        public TBundleInfo[] Bundles { get; set; } = new TBundleInfo[0];

        [DbObjectField("chunks")]
        public TChunkInfo[] Chunks { get; set; } = new TChunkInfo[0];
    }

    /// <summary>
    /// Generic superbundle layout specialization.
    /// </summary>
    public class SuperbundleLayout : SuperbundleLayout<BundleInfo, ChunkInfo> {}
}
