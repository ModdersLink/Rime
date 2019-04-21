using System;
using System.Collections.Generic;
using System.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Frostbite.Db;
using RimeLib.IO;

namespace RimeLib.Frostbite.Bundles.Venice
{
    /// <summary>
    /// A bundle manifest for Venice (Battlefield 3)
    /// </summary>
    public class VeniceBundleManifest : BundleManifestBase
    {
        /// <summary>
        /// Hashes that are included in this bundle manifest
        /// </summary>
        public List<Sha1> HashBase { get; set; }

        /// <summary>
        /// All records for entries (dbx, ebx, resource, chunk) within a manifest
        /// </summary>
        public List<EntryRecord> Records { get; set; }

        /// <summary>
        /// Resource type hashes, these are created by RimeHelper.HashLowerCase
        /// </summary>
        public List<uint> ResourceTypeHash { get; set; }

        /// <summary>
        /// Resource metadata
        /// </summary>
        public List<byte[]> ResourceMeta { get; set; }

        /// <summary>
        /// Entries in the bundle manifest describing chunks
        /// </summary>
        public List<BundleManifestChunk> Chunks { get; set; }

        /// <summary>
        /// Chunk metadata
        /// </summary>
        public DbObject ChunkMeta { get; set; }

        /// <summary>
        /// Extra text block
        /// </summary>
        public byte[] TextBlock { get; set; }

        /// <summary>
        /// Constructor for creating a venice bundle manifest
        /// </summary>
        /// <param name="p_ParentManifest">Parent manifest</param>
        /// <param name="p_EbxMode">Ebx Mode</param>
        public VeniceBundleManifest(BundleManifest p_ParentManifest, bool p_EbxMode)
            : base(p_ParentManifest, p_EbxMode)
        {
            HashBase = new List<Sha1>();
            Records = new List<EntryRecord>();
            ResourceTypeHash = new List<uint>();
            ResourceMeta = new List<byte[]>();
            Chunks = new List<BundleManifestChunk>();
        }

        /// <summary>
        /// Parses a Venice Bundle Manifest
        /// </summary>
        /// <param name="p_Reader">Opened reader to the start of the manifest</param>
        /// <param name="p_Entry">Entry information about the bundle</param>
        /// <returns></returns>
        public override bool Parse(RimeReader p_Reader, BundleEntry p_Entry)
        {
            if (!EbxMode)
                throw new NotImplementedException("We currently don't support non-EBX Bundles.");

            var s_TopPosition = p_Reader.Position - 32;

            // Read the contained entry SHA1s
            for (var i = 0; i < ParentManifest.ManifestHeader.EntryCount; ++i)
                HashBase.Add(new Sha1(p_Reader));

            // Read all the entry records
            for (var i = 0; i < ParentManifest.ManifestHeader.DbxCount + ParentManifest.ManifestHeader.ResourceCount; ++i)
                Records.Add(new EntryRecord(p_Reader));

            // Read all the resource type hashes
            for (var i = 0; i < ParentManifest.ManifestHeader.ResourceCount; ++i)
                ResourceTypeHash.Add(p_Reader.ReadUInt32());

            // Read all the resource metas
            for (var i = 0; i < ParentManifest.ManifestHeader.ResourceCount; ++i)
                ResourceMeta.Add(p_Reader.ReadBytes(16));

            // Read all the chunk info
            for (var i = 0; i < ParentManifest.ManifestHeader.ChunkCount; ++i)
                Chunks.Add(new BundleManifestChunk(p_Reader));

            // Read the chunk meta
            if (ParentManifest.ManifestHeader.ChunkMetaSize > 0)
            {
                // We should already be here.
                //p_Reader.Seek(p_Entry.Offset + ParentManifest.ManifestHeader.ChunkMetaOffset + 4, SeekOrigin.Begin); // The +4 is accounting for the BundleManifest length.

                var s_Stream = new MemoryStream();
                s_Stream.Write(p_Reader.ReadBytes((int) ParentManifest.ManifestHeader.ChunkMetaSize), 0,
                    (int) ParentManifest.ManifestHeader.ChunkMetaSize);
                s_Stream.Position = 0;

                // Create a new reader and get a DbObject from it
                var s_ObjectReader = new RimeReader(s_Stream);
                ChunkMeta = new DbObject(s_ObjectReader);
                s_ObjectReader.Dispose();
            }
            else
            {
                ChunkMeta = null;
            }

            // Read the text block (can be used later to associate EntryRecords).
            //p_Reader.Seek(p_Entry.Offset + ParentManifest.ManifestHeader.StringBlockOffset + 4, SeekOrigin.Begin);
            TextBlock = p_Reader.ReadBytes((int) (ParentManifest.ManifestSize - p_Reader.Position + s_TopPosition));

            // Parse the actual Bundle
            Bundle = new Bundle(ParentManifest, p_Reader, p_Entry);

            return true;
        }
    }
}
