using System;
using RimeLib.Frostbite.Core;
using RimeLib.Frostbite.Db;

namespace RimeLib.Content.Frostbite.Storage.Sb
{
    public class BundleInfo : DbObjectSerializable
    {
        [DbObjectField("id")]
        public GUID Id { get; set; } = Guid.Empty;
    }

    public class ChunkInfo : DbObjectSerializable
    {
        [DbObjectField("id")]
        public GUID Id { get; set; } = Guid.Empty;
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
