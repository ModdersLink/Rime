using RimeLib.IO;

namespace RimeLib.Frostbite.Bundles.Venice
{
    /// <summary>
    /// A record for describing the data within a bundle
    /// </summary>
    public class EntryRecord
    {
        /// <summary>
        /// Offset to the name string for this entry
        /// </summary>
        public uint NameOffset { get; set; }

        /// <summary>
        /// Payload size for this entry
        /// </summary>
        public uint PayloadSize { get; set; }

        /// <summary>
        /// Original payload size (usually prior to compression).
        /// If this is not the same as PayloadSize it almost always
        /// means that the payload is compressed.
        /// </summary>
        public uint OriginalSize { get; set; }

        /// <summary>
        /// Reads an EntryRecord from an opened reader
        /// </summary>
        /// <param name="p_Reader">Opened reader, with position at the record</param>
        public EntryRecord(RimeReader p_Reader)
        {
            NameOffset = p_Reader.ReadUInt32();
            PayloadSize = p_Reader.ReadUInt32();
            OriginalSize = p_Reader.ReadUInt32();
        }
    }
}
