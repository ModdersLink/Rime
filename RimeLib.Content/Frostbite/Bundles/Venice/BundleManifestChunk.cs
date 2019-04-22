using RimeLib.Frostbite.Core;
using RimeLib.IO;

namespace RimeLib.Content.Frostbite.Bundles.Venice
{
    /// <summary>
    /// A chunk entry within a bundle manifest
    /// </summary>
    public class BundleManifestChunk
    {
        /// <summary>
        /// Guid Identifier for this chunk
        /// </summary>
        public GUID ID { get; set; }

        /// <summary>
        /// Starting range of the data
        /// </summary>
        public uint RangeStart { get; set; }

        /// <summary>
        /// Ending range of the data
        /// </summary>
        public uint RangeEnd { get; set; }

        /// <summary>
        /// Unknown offset, usually 0
        /// </summary>
        public uint LogicalOffset { get; set; }

        /// <summary>
        /// Constructor taking in a reader placed at this structure within a BundleManifest
        /// </summary>
        /// <param name="p_Reader"></param>
        public BundleManifestChunk(RimeReader p_Reader)
        {
            ID = new GUID(p_Reader);
            RangeStart = p_Reader.ReadUInt32();
            RangeEnd = p_Reader.ReadUInt32();
            LogicalOffset = p_Reader.ReadUInt32();
        }
    }
}
