using RimeLib.Frostbite.Core;
using RimeLib.Frostbite.Db;

namespace RimeLib.Frostbite.Bundles.Entries
{
    /// <summary>
    /// Abstract class for representing a Chunk object
    /// </summary>
    public abstract class Chunk : EntryBase
    {
        /// <summary>
        /// Metadata about the chunk object
        /// </summary>
        public DbObject Meta { get; set; }

        /// <summary>
        /// Chunk identififer
        /// </summary>
        public GUID ID { get; set; }
    }
}
