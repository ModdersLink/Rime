using RimeLib.Content.Venice.Frostbite.Chunks;
using RimeLib.Frostbite.Core;
using RimeLib.Frostbite.Db;

namespace RimeLib.Content.Venice.Frostbite.Bundles
{
    public class CasBundle : DbObjectSerializable
    {
        public class Resource : DbObjectSerializable
        {
            [DbObjectField("name")]
            public string Name { get; set; } = "";
            
            [DbObjectField("resType")]
            public int ResourceType { get; set; }
            
            [DbObjectField("resMeta")]
            public byte[] Meta { get; set; } = new byte[0];
            
            [DbObjectField("sha1")]
            public Sha1 Hash { get; set; } = new Sha1();
            
            [DbObjectField("size")]
            public long Size { get; set; }
            
            [DbObjectField("originalSize")]
            public long? OriginalSize { get; set; }
        }

        public class Dbx : DbObjectSerializable
        {
            [DbObjectField("name")]
            public string Name { get; set; } = "";
            
            [DbObjectField("sha1")]
            public Sha1 Hash { get; set; } = new Sha1();
            
            [DbObjectField("idata")]
            public byte[] InlineData { get; set; } = new byte[0];
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
        }

        public class Chunk : DbObjectSerializable
        {
            [DbObjectField("id")]
            public GUID Id { get; set; } = new GUID();
            
            [DbObjectField("sha1")]
            public Sha1 Hash { get; set; } = new Sha1();
            
            [DbObjectField("size")]
            public long Size { get; set; }
        }

        [DbObjectField("path")]
        public string Path { get; set; } = "";
        
        [DbObjectField("magicSalt")]
        public int MagicSalt { get; set; }
        
        [DbObjectField("alignMembers")]
        public bool AlignMembers { get; set; }
        
        [DbObjectField("totalSize")]
        public long TotalSize { get; set; }
        
        [DbObjectField("res")]
        public Resource[] ResourceEntries { get; set; } = new Resource[0];
        
        [DbObjectField("dbx")]
        public Dbx[] DbxEntries { get; set; } = new Dbx[0];
        
        [DbObjectField("ebx")]
        public Ebx[] EbxEntries { get; set; } = new Ebx[0];
        
        [DbObjectField("chunks")]
        public Chunk[] ChunkEntries { get; set; } = new Chunk[0];

        [DbObjectField("chunkMeta")]
        public ChunkEntry.ChunkMeta[] ChunkMeta { get; set; } = new ChunkEntry.ChunkMeta[0];
    }
}
