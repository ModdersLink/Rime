using System.Collections.Generic;
using System.IO;
using RimeLib.Content.Frostbite2_0.Frostbite.Cas;
using RimeLib.Frostbite.Core;
using RimeLib.Frostbite.Fs;
using RimeLib.IO;
using RimeLib.IO.Conversion;

namespace RimeLib.Content.Frostbite2_0.Building
{
    /// <summary>
    /// Writes a Frostbite content-addressable-storage catalogue (cas.cat) and its data
    /// files (cas_NN.cas). Blobs are content-addressed by the SHA1 of the stored bytes and
    /// de-duplicated. This is what was missing for writing NEW data referenced by a (patch)
    /// bundle's sha1 entries — the read side is RimeLib.Content.Frostbite2_0.Frostbite.Cas.Catalog.
    ///
    /// The caller decides whether a blob is stored compressed (Frostbite zlib-block) or raw;
    /// this just stores the exact bytes and hashes them. The catalogue is written with the
    /// FileObfuscation header (magic 0x01CED100, XOR disabled) that BF3's loader expects.
    /// </summary>
    public class CasCatalogWriter
    {
        // Frostbite caps a single cas file at 1 GiB.
        private const long c_MaxCasSize = 1073741824;

        private readonly uint m_StartIndex;
        private readonly List<MemoryStream> m_CasStreams = new();
        private readonly Dictionary<Sha1, CatalogEntry> m_Entries = new();
        private readonly Catalog m_Catalog = new();

        /// <param name="p_StartIndex">First cas file number (cas_NN.cas). Game uses 01..; a
        /// mod patch should start past the base files (or wherever VU expects).</param>
        public CasCatalogWriter(uint p_StartIndex = 1)
        {
            m_StartIndex = p_StartIndex;
        }

        public IReadOnlyDictionary<Sha1, CatalogEntry> Entries => m_Entries;

        /// <summary>
        /// Stores a blob (exact bytes) and returns its content address (SHA1). De-dups: if the
        /// same bytes were already added, returns the existing hash without storing again.
        /// </summary>
        public Sha1 Add(byte[] p_Data)
        {
            var s_Hash = Sha1.FromData(p_Data);

            if (m_Entries.ContainsKey(s_Hash))
                return s_Hash;

            var s_Stream = FindStreamWithSpace(p_Data.Length, out var s_Index);

            m_Entries[s_Hash] = new CatalogEntry(m_Catalog)
            {
                Hash = s_Hash,
                FileNumber = m_StartIndex + s_Index,
                FileOffset = (uint)s_Stream.Position,
                FileSize = (uint)p_Data.Length,
            };

            s_Stream.Write(p_Data, 0, p_Data.Length);

            return s_Hash;
        }

        /// <summary>
        /// Writes cas_NN.cas files and the obfuscated cas.cat into <paramref name="p_Directory"/>.
        /// </summary>
        public void Write(string p_Directory, string p_CatalogName = "cas.cat")
        {
            Directory.CreateDirectory(p_Directory);

            // Write the data files.
            for (var s_I = 0; s_I < m_CasStreams.Count; ++s_I)
            {
                var s_Path = Path.Combine(p_Directory, $"cas_{m_StartIndex + s_I:D2}.cas");
                using var s_File = new FileStream(s_Path, FileMode.Create, FileAccess.Write);
                m_CasStreams[s_I].WriteTo(s_File);
            }

            // Build the catalogue body: NyanNyan x2 + entries.
            byte[] s_Body;
            using (var s_BodyStream = new MemoryStream())
            {
                using var s_BodyWriter = new RimeWriter(s_BodyStream, Endianness.LittleEndian, false);
                s_BodyWriter.Write(Catalog.c_Nyan);
                s_BodyWriter.Write(Catalog.c_Nyan);

                foreach (var s_Entry in m_Entries.Values)
                    s_Entry.Serialize(s_BodyWriter);

                s_BodyWriter.Flush();
                s_Body = s_BodyStream.ToArray();
            }

            // Wrap with the FileObfuscation header (XOR disabled -> body stored as-is) and write.
            var s_CatalogPath = Path.Combine(p_Directory, p_CatalogName);
            using var s_CatFile = new FileStream(s_CatalogPath, FileMode.Create, FileAccess.Write);
            using var s_CatWriter = new RimeWriter(s_CatFile, Endianness.LittleEndian, false);
            FileObfuscation.Serialize(s_CatWriter, s_Body);
        }

        private MemoryStream FindStreamWithSpace(long p_Length, out uint p_Index)
        {
            for (var s_I = 0u; s_I < m_CasStreams.Count; ++s_I)
            {
                if (m_CasStreams[(int)s_I].Length + p_Length <= c_MaxCasSize)
                {
                    p_Index = s_I;
                    return m_CasStreams[(int)s_I];
                }
            }

            var s_New = new MemoryStream();
            m_CasStreams.Add(s_New);
            p_Index = (uint)(m_CasStreams.Count - 1);
            return s_New;
        }
    }
}
