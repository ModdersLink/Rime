using System;
using System.IO;
using System.Linq;
using RimeLib.Content.Building;
using RimeLib.Content.Frostbite2013_2.Frostbite.Bundles;
using RimeLib.Content.Frostbite2013_2.Frostbite.Chunks;
using RimeLib.Content.Frostbite2013_2.Mounting;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.Frostbite.Db;

namespace RimeLib.Content.Frostbite2013_2.Building;

/// <summary>
/// The manifest of a bundle in a cas superbundle.
///
/// Content mounted from the game's cas bundles keeps the entry it was mounted from: its sha1,
/// sizes and, for patched content, the patch type and the base and delta it is rebuilt from. The
/// game resolves those through its own catalogs, so they are copied as references. Everything else
/// (generated partitions and resources, content from noncas superbundles) is stored inline as codec
/// blocks, as the game stores EBX and resources (size and originalSize tell them apart); a chunk
/// only when its guid carries the compression flag, raw otherwise.
/// </summary>
public class CasBundleManifestBuilder
{
    private readonly BundleDescriptor m_Descriptor;

    /// <summary>How many entries are references to the game's catalogs, and how many inline.</summary>
    public int References { get; private set; }

    public int Inline { get; private set; }

    public CasBundleManifestBuilder(BundleDescriptor p_Descriptor)
    {
        m_Descriptor = p_Descriptor;
    }

    private static IReadableObject Resolve(IReadableObject p_Object) => p_Object is ObjectVariant s_Variant ? s_Variant.GetReadable() : p_Object;

    /// <summary>The entry a mounted cas object came from, and its inline data if it had any.</summary>
    private static (IPatchableEntry Entry, byte[]? Inline)? Source(IReadableObject p_Object) => Resolve(p_Object) switch
    {
        CatalogReadable { Entry: { } s_Entry } => (s_Entry, null),
        InlineReadable { Entry: { } s_Entry } s_Inline => (s_Entry, s_Inline.GetCompressedData()),
        _ => null,
    };

    private static byte[] ReadAll(IReadableObject p_Object)
    {
        using var s_Reader = p_Object.GetReader();
        var s_Bytes = new MemoryStream();
        s_Reader.CopyTo(s_Bytes);
        return s_Bytes.ToArray();
    }

    public DbObject GetDbObject()
    {
        var s_Bundle = new CasBundle
        {
            Path = m_Descriptor.BundleName,
            EbxEntries = m_Descriptor.Partitions.Select(p_P => Ebx(p_P.Key, p_P.Value)).ToArray(),
            ResourceEntries = m_Descriptor.Resources.Select(p_R => Resource(p_R.Key, p_R.Value)).ToArray(),
            // A bundle without chunks has neither list.
            ChunkEntries = m_Descriptor.Chunks.Count == 0 ? null : m_Descriptor.Chunks.Select(p_C => Chunk(p_C.Key, p_C.Value)).ToArray(),
            ChunkMeta = m_Descriptor.Chunks.Count == 0 ? null : m_Descriptor.Chunks.Select(p_C => ChunkMeta(p_C.Value)).ToArray(),
        };

        // The bytes the bundle reads from cas: dbxTotalSize those of its resources and chunks (a
        // ranged chunk counts its range), totalSize those and its EBX. Measured exact on every
        // bundle of mp_siege.
        s_Bundle.DbxTotalSize = s_Bundle.ResourceEntries.Sum(p_R => p_R.Size)
            + (s_Bundle.ChunkEntries ?? Array.Empty<CasBundle.Chunk>()).Sum(p_C => p_C.RangeStart is { } s_Start && p_C.RangeEnd is { } s_End ? s_End - s_Start : p_C.Size);
        s_Bundle.TotalSize = s_Bundle.EbxEntries.Sum(p_E => p_E.Size) + s_Bundle.DbxTotalSize.Value;
        return DbObjectConverter.ToDbObject(s_Bundle);
    }

    private CasBundle.Ebx Ebx(string p_Name, IReadableObject p_Object)
    {
        if (Source(p_Object) is ({ } s_Entry, var s_Inline) && s_Entry is CasBundle.Ebx s_Ebx)
        {
            Count(s_Inline);
            return new CasBundle.Ebx
            {
                Name = p_Name,
                Hash = s_Ebx.Hash,
                Size = s_Ebx.Size,
                OriginalSize = s_Ebx.OriginalSize,
                InlineData = s_Inline,
                CasPatchType = s_Ebx.CasPatchType,
                BaseHash = s_Ebx.BaseHash,
                DeltaIndex = s_Ebx.DeltaIndex,
                DeltaHash = s_Ebx.DeltaHash,
            };
        }

        var s_Raw = ReadAll(p_Object);
        var s_Stored = CodecEncoder.Encode(s_Raw);
        Count(s_Stored);
        return new CasBundle.Ebx { Name = p_Name, Hash = Sha1.FromData(s_Stored), Size = s_Stored.Length, OriginalSize = s_Raw.Length, InlineData = s_Stored };
    }

    private CasBundle.Resource Resource(string p_Name, IResourceObject p_Object)
    {
        if (Source(p_Object) is ({ } s_Entry, var s_Inline) && s_Entry is CasBundle.Resource s_Resource)
        {
            Count(s_Inline);
            return new CasBundle.Resource
            {
                Name = p_Name,
                Hash = s_Resource.Hash,
                Size = s_Resource.Size,
                OriginalSize = s_Resource.OriginalSize,
                ResourceType = s_Resource.ResourceType,
                Meta = s_Resource.Meta,
                ResourceIdInt = s_Resource.ResourceIdInt,
                InlineData = s_Inline,
                CasPatchType = s_Resource.CasPatchType,
                BaseHash = s_Resource.BaseHash,
                DeltaIndex = s_Resource.DeltaIndex,
                DeltaHash = s_Resource.DeltaHash,
            };
        }

        var s_Raw = ReadAll(p_Object);
        var s_Stored = CodecEncoder.Encode(s_Raw);
        Count(s_Stored);
        return new CasBundle.Resource
        {
            Name = p_Name,
            Hash = Sha1.FromData(s_Stored),
            Size = s_Stored.Length,
            OriginalSize = s_Raw.Length,
            ResourceType = (int)p_Object.GetResourceType(),
            Meta = p_Object.TryGetMeta(out var s_Meta) ? s_Meta : Array.Empty<byte>(),
            ResourceIdInt = (long)p_Object.GetId(p_Name).Id,
            InlineData = s_Stored,
        };
    }

    private CasBundle.Chunk Chunk(GUID p_Id, IChunkObject p_Object)
    {
        if (Source(p_Object) is ({ } s_Entry, var s_Inline) && s_Entry is CasBundle.Chunk s_Chunk)
        {
            Count(s_Inline);
            return new CasBundle.Chunk
            {
                Id = p_Id,
                Hash = s_Chunk.Hash,
                Size = s_Chunk.Size,
                RangeStart = s_Chunk.RangeStart,
                RangeEnd = s_Chunk.RangeEnd,
                LogicalOffset = s_Chunk.LogicalOffset,
                LogicalSize = s_Chunk.LogicalSize,
                InlineData = s_Inline,
                CasPatchType = s_Chunk.CasPatchType,
                BaseHash = s_Chunk.BaseHash,
                DeltaIndex = s_Chunk.DeltaIndex,
                DeltaHash = s_Chunk.DeltaHash,
            };
        }

        // A chunk says it is compressed only through the flag in its guid.
        var s_Raw = ReadAll(p_Object);
        var s_Stored = p_Id.HasCompressionFlag() ? CodecEncoder.Encode(s_Raw) : s_Raw;
        Count(s_Stored);
        return new CasBundle.Chunk
        {
            Id = p_Id,
            Hash = Sha1.FromData(s_Stored),
            Size = s_Stored.Length,
            LogicalOffset = 0,
            LogicalSize = (uint)s_Raw.Length,
            InlineData = s_Stored,
        };
    }

    private static ChunkEntry.ChunkMetaEntry ChunkMeta(IChunkObject p_Object)
    {
        if (p_Object.TryGetMeta(out var s_Meta))
            return DbObjectConverter.FromDbObject<ChunkEntry.ChunkMetaEntry>(s_Meta);

        // A texture's chunk is found by the asset name hash; without it the texture never streams in.
        return new ChunkEntry.ChunkMetaEntry { AssetNameHash = p_Object.GetAssetNameHash() ?? 0 };
    }

    private void Count(byte[]? p_Inline)
    {
        if (p_Inline == null)
            References++;
        else
            Inline++;
    }
}
