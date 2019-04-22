using RimeLib.Frostbite.Core;
using RimeLib.Frostbite.Db;
using RimeLib.IO;

namespace RimeLib.Content.Frostbite.Bundles
{
    /// <summary>
    /// Chunk Entry reads information about a chunk out from a DbObject
    /// </summary>
    public class ChunkEntry
    {
        /// <summary>
        /// Chunk identifier
        /// </summary>
        public GUID ID { get; set; }

        /// <summary>
        /// Chunk hash
        /// </summary>
        public Sha1 Hash { get; set; }

        /// <summary>
        /// Chunk offset
        /// </summary>
        public long Offset { get; set; }

        /// <summary>
        /// Chunk data size
        /// </summary>
        public int Size { get; set; }

        /// <summary>
        /// The superbundle that contains this chunk
        /// </summary>
        public SuperbundleLayout BaseSuperbundle { get; set; }

        /// <summary>
        /// Constructor for a chunk entry, reads out id, sha1, offset, size
        /// </summary>
        /// <param name="p_Object">Database object containing the information for the chunk</param>
        /// <param name="p_BaseSuperbundle">Base superbundle that contains this chunk entry</param>
        public ChunkEntry(DbObject p_Object, SuperbundleLayout p_BaseSuperbundle)
        {
            BaseSuperbundle = p_BaseSuperbundle;

            var s_Guid = p_Object["id"];

            if (s_Guid != null)
                ID = (GUID) s_Guid.Value;

            var s_Sha1 = p_Object["sha1"];

            if (s_Sha1 != null)
                Hash = (Sha1) s_Sha1.Value;

            var s_Offset = p_Object["offset"];

            if (s_Offset != null)
                Offset = (long)s_Offset.Value;

            var s_Size = p_Object["size"];

            if (s_Size != null)
                Size = (int)s_Size.Value;
        }

        /// <summary>
        /// Decode chunk data based on compression flag
        /// </summary>
        /// <param name="p_Data">Data to decode</param>
        /// <returns></returns>
        public virtual byte[] Decode(byte[] p_Data)
        {
            return ID.HasCompressionFlag() ? Decoding.DecodeZlibSegmented(p_Data) : p_Data;
        }
    }
}
