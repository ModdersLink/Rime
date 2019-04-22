using System;
using System.Collections.Concurrent;
using System.IO;
using RimeLib.Frostbite.Core;
using RimeLib.IO;

namespace RimeLib.Content.Frostbite.Storage
{
    /// <summary>
    /// Structure for content addressable storage catalogs
    /// </summary>
    public class Catalog
    {
        /// <summary>
        /// The type of storage
        /// </summary>
        public enum StorageType
        {
            /// <summary>
            /// Plain storage, no signature nor obfuscation
            /// </summary>
            Bare,

            /// <summary>
            /// Obfuscated storage
            /// </summary>
            Obfuscated,

            /// <summary>
            /// RSA signature over the storage to prevent modifications
            /// </summary>
            Signed01
        }

        /// <summary>
        /// Type of storage that this catalog holds
        /// </summary>
        public StorageType Storage { get; set; }

        /// <summary>
        /// The authoritative package for this storage
        /// </summary>
        public PackageManifest AuthoritativePackage { get; set; }

        /// <summary>
        /// Name of this storage catalog
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Base path location for this catalog
        /// </summary>
        public string BasePath => GetBasePath();

        /// <summary>
        /// Patched path location for this catalog
        /// </summary>
        public string PatchPath => GetPatchPath();

        /// <summary>
        /// Entries by hash within this catalog
        /// </summary>
        public ConcurrentDictionary<Sha1, CatalogEntry> Entries { get; private set; }

        /// <summary>
        /// Constructor that parses a catalog from an opened reader
        /// </summary>
        /// <param name="p_Reader">Reader opened to the position of the catalog</param>
        public Catalog(RimeReader p_Reader)
        {
            ParseHeader(p_Reader);
        }

        /// <summary>
        /// Constructor that parses a catalog from data
        /// </summary>
        /// <param name="p_Data"></param>
        public Catalog(byte[] p_Data)
        {
            using (var s_Reader = new RimeReader(new MemoryStream(p_Data)))
                ParseHeader(s_Reader);
        }

        /// <summary>
        /// Parses the catalog header information
        /// </summary>
        /// <param name="p_Reader">Reader opened to the position of the catalog header</param>
        protected void ParseHeader(RimeReader p_Reader)
        {
            var s_Magic = p_Reader.ReadUInt32();

            switch (s_Magic)
            {
                case 0x01CED100:
                    Storage = StorageType.Signed01;
                    p_Reader.EnableDeobfuscation();
                    break;

                case 0x00CED100:
                    Storage = StorageType.Obfuscated;
                    p_Reader.EnableDeobfuscation();
                    break;

                default:
                    p_Reader.Seek(-4, SeekOrigin.Current);
                    Storage = StorageType.Bare;
                    break;
            }

            var s_NyanNyan01 = p_Reader.ReadUInt64();
            var s_NyanNyan02 = p_Reader.ReadUInt64();

            // NyanNyanNyanNyan
            if (s_NyanNyan01 != 0x6E61794E6E61794E ||
                s_NyanNyan02 != 0x6E61794E6E61794E)
                throw new Exception("The provided file is not a valid catalog file.");

            ParseEntries(p_Reader);
        }

        /// <summary>
        /// Parses the catalog entries
        /// </summary>
        /// <param name="p_Reader">Reader opened to the position of the catalog entries</param>
        protected void ParseEntries(RimeReader p_Reader)
        {
            Entries = new ConcurrentDictionary<Sha1, CatalogEntry>();

            while (p_Reader.BaseStream.Length - p_Reader.BaseStream.Position > 0)
            {
                var s_Entry = new CatalogEntry(p_Reader) { ContainedCatalog = this };
                Entries.TryAdd(s_Entry.Hash, s_Entry);
            }
        }

        /// <summary>
        /// Does this catalog contain a certain hash
        /// </summary>
        /// <param name="p_Hash">Hash to check for</param>
        /// <returns>True if this catalog contains the specified hash, false otherwise</returns>
        public bool ContainsEntry(Sha1 p_Hash)
        {
            return Entries.ContainsKey(p_Hash);
        }

        /// <summary>
        /// Indexer via hash
        /// </summary>
        /// <param name="p_Hash">Hash</param>
        /// <returns>CatalogEntry if hash is found, null otherwise</returns>
        public CatalogEntry this[Sha1 p_Hash]
        {
            get => !Entries.TryGetValue(p_Hash, out var s_Entry) ? null : s_Entry;
            set
            {
                value.ContainedCatalog = this;
                Entries.AddOrUpdate(p_Hash, value, (p_K, p_V) => value);
            }
        }

        /// <summary>
        /// Gets the base vfs path for this catalog
        /// </summary>
        /// <returns>Base path of catalog</returns>
        protected string GetBasePath()
        {
            return "/game/Data/" + (string.IsNullOrWhiteSpace(Name) ? "cas" : Name) + ".cat";
        }

        /// <summary>
        /// Gets the patched vfs path for this catalog
        /// </summary>
        /// <returns>Patched path of catalog</returns>
        protected string GetPatchPath()
        {
            if (AuthoritativePackage == null)
                return null;

            return "/game" + AuthoritativePackage.Path + "/Data/" + (string.IsNullOrWhiteSpace(Name) ? "cas" : Name) + ".cat";
        }
    }
}
