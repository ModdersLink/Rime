using RimeLib.Frostbite.Core;

namespace RimeLib.Content.Frostbite.Storage
{
    /// <summary>
    /// Content Addressable Storage entry
    /// </summary>
    public class CasEntry
    {
        /// <summary>
        /// Default magic as seen in Battlefield 3
        /// </summary>
        public const uint c_CasMagic = 0xf00fcefa; // FACE0FF0

        /// <summary>
        /// Entry magic
        /// </summary>
        public uint Magic { get; set; }

        /// <summary>
        /// Entry hash
        /// </summary>
        public Sha1 Hash { get; set; }

        /// <summary>
        /// Entry size
        /// uint32_t for Battlefield 3
        /// uint64_t for Battlefield 4
        /// </summary>
        public uint Size { get; set; } // uint64 for BF4
    }
}
