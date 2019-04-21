using System;
using System.Collections.Generic;
using RimeLib.Frostbite.Bundles.Venice;
using RimeLib.IO;

namespace RimeLib.Frostbite.Bundles
{
    /// <summary>
    /// Bundle Manfiests are the "header" of a bundle, ensuring that they have certain information in them.
    /// </summary>
    public class BundleManifest
    {
        /// <summary>
        /// Ebx magic constant
        /// </summary>
        private const uint ManifestEbx = 0xED1CEDB8;

        /// <summary>
        /// Dbx magic constant
        /// </summary>
        private const uint ManifestDbx = 0xFE1FBEEF;

        /// <summary>
        /// Xor keys
        /// </summary>
        private static readonly Dictionary<uint, Type> ManifestXorKeys = new Dictionary<uint, Type>
        {
            { 0x7A11F1AB, typeof(VeniceBundleManifest) },
        }; 

        /// <summary>
        /// Bundle manifest header which contains information about a bundle
        /// </summary>
        public class Header
        {
            //public UInt32 StructSize { get { return 32; } }

            /// <summary>
            /// Manifest header magic
            /// </summary>
            public uint Magic { get; set; }

            /// <summary>
            /// Number of entries in this bundle
            /// </summary>
            public uint EntryCount { get; set; }

            /// <summary>
            /// Number of dbx's in this bundle
            /// </summary>
            public uint DbxCount { get; set; }

            /// <summary>
            /// Number of resources in this bundle
            /// </summary>
            public uint ResourceCount { get; set; }

            /// <summary>
            /// Number of chunks in this bundle
            /// </summary>
            public uint ChunkCount { get; set; }

            /// <summary>
            /// Offset to the string block
            /// </summary>
            public uint StringBlockOffset { get; set; }

            /// <summary>
            /// Offset to metadata about the chunks
            /// </summary>
            public uint ChunkMetaOffset { get; set; }

            /// <summary>
            /// Size of the metadata about the chunks
            /// </summary>
            public uint ChunkMetaSize { get; set; }

            /// <summary>
            /// Constructor
            /// </summary>
            /// <param name="p_Reader">Reader at the position where the header is located</param>
            public Header(RimeReader p_Reader)
            {
                Magic = p_Reader.ReadUInt32();
                EntryCount = p_Reader.ReadUInt32();
                DbxCount = p_Reader.ReadUInt32();
                ResourceCount = p_Reader.ReadUInt32();
                ChunkCount = p_Reader.ReadUInt32();
                StringBlockOffset = p_Reader.ReadUInt32();
                ChunkMetaOffset = p_Reader.ReadUInt32();
                ChunkMetaSize = p_Reader.ReadUInt32();
            }
        }

        /// <summary>
        /// TODO: Documentation
        /// </summary>
        public BundleManifestBase RealManifest { get; set; }

        /// <summary>
        /// Size of the manfiest
        /// </summary>
        public uint ManifestSize { get; set; }

        /// <summary>
        /// Manfiest header
        /// </summary>
        public Header ManifestHeader { get; set; }

        /// <summary>
        /// TODO: Documentation
        /// </summary>
        /// <param name="p_Reader"></param>
        /// <param name="p_Entry"></param>
        public BundleManifest(RimeReader p_Reader, BundleEntry p_Entry)
        {
            RealManifest = null;

            ManifestSize = p_Reader.ReadUInt32();

            ManifestHeader = new Header(p_Reader);

            // Determine what type of BundleManifest this is.
            foreach (var s_KeyPair in ManifestXorKeys)
            {
                if ((s_KeyPair.Key ^ ManifestHeader.Magic) == ManifestEbx)
                {
                    RealManifest = (BundleManifestBase) Activator.CreateInstance(s_KeyPair.Value, this, true);
                    break;
                }

                if ((s_KeyPair.Key ^ ManifestHeader.Magic) == ManifestDbx)
                {
                    RealManifest = (BundleManifestBase) Activator.CreateInstance(s_KeyPair.Value, this, false);
                    break;
                }
            }

            if (RealManifest == null)
                throw new Exception($"Tried to load an unsupported BundleManifest ({ManifestHeader.Magic:X8}).");

            if (!RealManifest.Parse(p_Reader, p_Entry))
                throw new Exception("Failed to parse BundleManifest.");
        }
    }
}
