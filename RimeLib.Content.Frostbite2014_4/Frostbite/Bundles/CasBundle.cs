using RimeLib.Content.Frostbite2014_4.Frostbite.Chunks;
using RimeLib.Content.Frostbite2014_4.Frostbite.Sb;
using RimeLib.Frostbite.Core;
using RimeLib.Frostbite.Db;

namespace RimeLib.Content.Frostbite2014_4.Frostbite.Bundles;

public class CasBundle : DbObjectSerializable
{
    public class Resource : DbObjectSerializable, IPatchableEntry
    {
        [DbObjectField("name")]
        public string Name { get; set; } = "";
        
        [DbObjectField("sha1")]
        public Sha1 Hash { get; set; } = new();
        
        [DbObjectField("size")]
        public long Size { get; set; }
        
        [DbObjectField("originalSize")]
        public long? OriginalSize { get; set; }
        
        
        [DbObjectField("resType")]
        public int ResourceType { get; set; }
        
        [DbObjectField("resMeta")]
        public byte[] Meta { get; set; } = new byte[0];
        
        // how da fuck is this doable?
        [DbObjectField("resRid")]
        public long ResourceIdInt { get; set; }
        
        [DbObjectField("idata")]
        public byte[] InlineData { get; set; } = new byte[0];
        
        // For cas deltas
        [DbObjectField("casPatchType")]
        public long? CasPatchType { get; set; }
        
        [DbObjectField("baseSha1")]
        public Sha1? BaseHash { get; set; }
        
        // Either DeltaIndex or DeltaHash is valid. used to look up base in cas.
        [DbObjectField("idelta")]
        public long? DeltaIndex { get; set; }
        [DbObjectField("deltaSha1")]
        public Sha1? DeltaHash { get; set; }


        public ResourceRef ResourceId => new ResourceRef((ulong)ResourceIdInt);
    }

    public class Dbx : DbObjectSerializable, IPatchableEntry
    {
        [DbObjectField("name")]
        public string Name { get; set; } = "";
        
        [DbObjectField("sha1")]
        public Sha1 Hash { get; set; } = new();
        
        [DbObjectField("idata")]
        public byte[] InlineData { get; set; } = new byte[0];
        
        [DbObjectField("size")]
        public long Size { get; set; }
        
        [DbObjectField("originalSize")]
        public long? OriginalSize { get; set; }

       
        [DbObjectField("casPatchType")]
        public long? CasPatchType { get; set; }
        
        [DbObjectField("baseSha1")]
        public Sha1? BaseHash { get; set; }
        
        // Either DeltaIndex or DeltaHash is valid. used to look up base in cas.
        [DbObjectField("idelta")]
        public long? DeltaIndex { get; set; }
        [DbObjectField("deltaSha1")]
        public Sha1? DeltaHash { get; set; }
    }

    public class Ebx : DbObjectSerializable, IPatchableEntry
    {
        [DbObjectField("name")]
        public string Name { get; set; } = "";
        
        [DbObjectField("sha1")]
        public Sha1 Hash { get; set; } = new();
        
        [DbObjectField("size")]
        public long Size { get; set; }
        
        [DbObjectField("originalSize")]
        public long? OriginalSize { get; set; }
        
        
        // For cas deltas
        // used in fb::BundleHelper::generateCasPatchBundleData
        // == 0, increases size by Align1000(OriginalSize)      | unchanged
        
        // == 1, sets bit 0x30000000 some id, and increases     | external patch
        //      possibly related to PatchEntryOpType.New?
        //      chunk   = 0x30000000 | Align1000(LogicalSize + (LogicalOffset & 0xFFFF)
        //      ebx,dbx = 0x30000000 | Align1000(OriginalSize) 
        
        // == 2, then it has sha1 or idelta, looks up in base   | 
        //      Look up patch in delta file
        
        [DbObjectField("casPatchType")]
        public long? CasPatchType { get; set; }
        
        [DbObjectField("baseSha1")]
        public Sha1? BaseHash { get; set; }
        
        // Either DeltaIndex or DeltaHash is valid. used to look up base in cas.
        [DbObjectField("idelta")]
        public long? DeltaIndex { get; set; }
        [DbObjectField("deltaSha1")]
        public Sha1? DeltaHash { get; set; }
    }

    public class Chunk : DbObjectSerializable, IPatchableEntry
    {
        [DbObjectField("id")]
        public GUID Id { get; set; } = GUID.Empty;
        
        [DbObjectField("sha1")]
        public Sha1 Hash { get; set; } = new();
        
        [DbObjectField("size")]
        public long Size { get; set; }
        
        [DbObjectField("rangeStart")]
        public long? RangeStart { get; set; }
        [DbObjectField("rangeEnd")]
        public long? RangeEnd { get; set; }
            
        [DbObjectField("logicalOffset")]
        public long LogicalOffset { get; set; }
        [DbObjectField("logicalSize")]
        public long LogicalSize { get; set; }
        
        // For cas deltas
        [DbObjectField("casPatchType")]
        public long? CasPatchType { get; set; }
        
        
        
        // not used in chunks
        [DbObjectField("baseSha1")]
        public Sha1? BaseHash { get; set; }
        
        // Either DeltaIndex or DeltaHash is valid. used to look up base in cas.
        [DbObjectField("idelta")]
        public long? DeltaIndex { get; set; }
        [DbObjectField("deltaSha1")]
        public Sha1? DeltaHash { get; set; }
    }

    [DbObjectField("path")]
    public string Path { get; set; } = "";
    
    [DbObjectField("magicSalt")]
    public int MagicSalt { get; set; }
    

    
    
    [DbObjectField("dbx")]
    public Dbx[] DbxEntries { get; set; } = new Dbx[0];
    
    [DbObjectField("ebx")]
    public Ebx[] EbxEntries { get; set; } = new Ebx[0];
    
    [DbObjectField("res")]
    public Resource[] ResourceEntries { get; set; } = new Resource[0];
    
    [DbObjectField("chunks")]
    public Chunk[] ChunkEntries { get; set; } = new Chunk[0];

    [DbObjectField("chunkMeta")]
    public ChunkEntry.ChunkMetaEntry[] ChunkMeta { get; set; } = new ChunkEntry.ChunkMetaEntry[0];

    [DbObjectField("alignMembers")]
    public bool AlignMembers { get; set; }
    
    [DbObjectField("ridSupport", DefaultValue = false)]
    public bool RidSupport { get; set; }
    
    [DbObjectField("storeCompressedSizes", DefaultValue = false)]
    public bool StoreCompressedSizes { get; set; }
    
    [DbObjectField("totalSize")]
    public long TotalSize { get; set; }
    [DbObjectField("dbxTotalSize")]
    public long? DbxTotalSize { get; set; }
}

public class CasBundleEntry
{
    public CasBundle Bundle { get; }
    
    public CasBundle? DeltaBundle { get; }
    public SuperbundleEntry ContainedSuperbundle { get; }

    public CasBundleEntry(CasBundle p_Bundle, SuperbundleEntry p_Sb)
    {
        Bundle = p_Bundle;
        ContainedSuperbundle = p_Sb;
    }
    
    public CasBundleEntry(CasBundle p_Base, CasBundle p_Delta, SuperbundleEntry p_Sb)
    {
        Bundle = p_Base;
        DeltaBundle = p_Delta;
        ContainedSuperbundle = p_Sb;
    }
}
