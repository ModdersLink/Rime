using RimeLib.Content.Frostbite2_0.Frostbite.Chunks;
using RimeLib.Content.Frostbite2_0.Frostbite.Sb;
using RimeLib.Frostbite.Core;
using RimeLib.Frostbite.Db;
using System;

namespace RimeLib.Content.Frostbite2_0.Frostbite.Bundles
{
    public class CasBundle : DbObjectSerializable
    {
        public class Resource : DbObjectSerializable
        {
            [DbObjectField("name")]
            public string Name { get; set; } = "";
            
            [DbObjectField("sha1")]
            public Sha1 Hash { get; set; } = new Sha1();

            [DbObjectField("size")]
            public long Size { get; set; }

            [DbObjectField("originalSize")]
            public long? OriginalSize { get; set; }
            
            [DbObjectField("resType")]
            public int ResourceType { get; set; }
            
            [DbObjectField("resMeta")]
            public byte[] Meta { get; set; } = Array.Empty<byte>();
            
            [DbObjectField("idata")]
            public byte[]? InlineData { get; set; } = null;
        }

        public class Dbx : DbObjectSerializable
        {
            [DbObjectField("name")]
            public string Name { get; set; } = "";
            
            [DbObjectField("sha1")]
            public Sha1 Hash { get; set; } = new Sha1();
            
            [DbObjectField("size")]
            public long Size { get; set; }
            
            [DbObjectField("originalSize")]
            public long? OriginalSize { get; set; }
            
            [DbObjectField("idata")]
            public byte[]? InlineData { get; set; } = null;
        }

        public class Ebx : DbObjectSerializable
        {
            [DbObjectField("name")]
            public string Name { get; set; } = "";
            
            [DbObjectField("sha1")]
            public Sha1 Hash { get; set; } = new Sha1();
            
            [DbObjectField("size")]
            public long Size { get; set; }
            
            [DbObjectField("originalSize")]
            public long? OriginalSize { get; set; }
            
            [DbObjectField("idata")]
            public byte[]? InlineData { get; set; } = null;
        }

        public class Chunk : DbObjectSerializable
        {
            [DbObjectField("id")]
            public GUID Id { get; set; } = GUID.Empty;
            
            [DbObjectField("sha1")]
            public Sha1 Hash { get; set; } = new Sha1();
            
            [DbObjectField("size")]
            public long Size { get; set; }
            
            [DbObjectField("idata")]
            public byte[]? InlineData { get; set; } = null;
        }

        [DbObjectField("path")]
        public string Path { get; set; } = "";
        
        [DbObjectField("magicSalt")]
        public int MagicSalt { get; set; }

        [DbObjectField("ebx")]
        public Ebx[] EbxEntries { get; set; } = Array.Empty<Ebx>();

        [DbObjectField("dbx")]
        public Dbx[] DbxEntries { get; set; } = Array.Empty<Dbx>();

        [DbObjectField("res")]
        public Resource[] ResourceEntries { get; set; } = Array.Empty<Resource>();

        [DbObjectField("chunks")]
        public Chunk[]? ChunkEntries { get; set; } = null;

        [DbObjectField("chunkMeta")]
        public ChunkEntry.ChunkMetaEntry[]? ChunkMeta { get; set; } = null;

        [DbObjectField("alignMembers", DefaultValue = true)]
        public bool AlignMembers { get; set; } = true;
        
        [DbObjectField("totalSize")]
        public long TotalSize { get; set; }
    }

    public class CasBundleEntry
    {
        public CasBundle Bundle { get; }
        public SuperbundleEntry ContainedSuperbundle { get; }

        public CasBundleEntry(CasBundle p_Bundle, SuperbundleEntry p_Sb)
        {
            Bundle = p_Bundle;
            ContainedSuperbundle = p_Sb;
        }
    }
}
