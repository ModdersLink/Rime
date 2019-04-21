using System;
using RimeLib.IO;

namespace RimeLib.Frostbite.Bundles
{
    /// <summary>
    /// Frostbite Delta Bundle Run class for patching
    /// </summary>
    public class DeltaBundleRun
    {
        /// <summary>
        /// Bytes to copy
        /// </summary>
        public int CopyBytes { get; set; }

        /// <summary>
        /// File identifier
        /// </summary>
        public int FileId { get; set; }

        /// <summary>
        /// Offset
        /// </summary>
        public ulong Offset { get; set; }

        /// <summary>
        /// Empty constructor, initializes everything to 0
        /// </summary>
        public DeltaBundleRun()
        {
        }

        /// <summary>
        /// Constructor to read out a delta bundle run from a reader
        /// </summary>
        /// <param name="p_Reader">Reader opened to the position of the delta bundle run</param>
        public DeltaBundleRun(RimeReader p_Reader)
        {
            CopyBytes = p_Reader.ReadInt32();
            FileId = p_Reader.ReadInt32();
            Offset = p_Reader.ReadUInt64();
        }
    }
}
