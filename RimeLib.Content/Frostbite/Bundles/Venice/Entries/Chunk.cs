using RimeLib.Frostbite.Core;
using RimeLib.Frostbite.Db;
using RimeLib.IO;

namespace RimeLib.Content.Frostbite.Bundles.Venice.Entries
{
    /// <summary>
    /// Chunk implementation for a chunk entry within a bundle
    /// </summary>
    public class Chunk : Bundles.Entries.Chunk
    {
        /// <summary>
        /// Constructor for reading chunk information from a DbObject
        /// </summary>
        /// <param name="p_Object">DbObject containing chunk information</param>
        /// <param name="p_ContainedBundle">Bundle that this chunk is contained in</param>
        public Chunk(DbObject p_Object, BundleBase p_ContainedBundle)
        {
            ID = (GUID) p_Object["id"].Value;
            Hash = (Sha1) p_Object["sha1"].Value;

            switch (p_Object["size"].Type)
            {
                case DbObjectType.Integer:
                    m_DataSize = (int) p_Object["size"].Value;
                    break;

                case DbObjectType.Long:
                    m_DataSize = (long) p_Object["size"].Value;
                    break;
            }
            
            m_Compressed = ID.HasCompressionFlag();
            m_ContainedBundle = p_ContainedBundle;
        }

        /// <summary>
        /// Constructor for manually creating a chunk from hash, metadata, bundle manifest, and actual data
        /// </summary>
        /// <param name="p_Hash">Hash of the chunk</param>
        /// <param name="p_Meta">Metadata about the chunk</param>
        /// <param name="p_Info">Chunk information from the bundle manifest</param>
        /// <param name="p_Data">Chunk data</param>
        /// <param name="p_ContainedBundle">Bundle that contains this chunk</param>
        public Chunk(Sha1 p_Hash, DbObject p_Meta, BundleManifestChunk p_Info, byte[] p_Data, BundleBase p_ContainedBundle)
        {
            Hash = p_Hash;
            ID = p_Info.ID;
            Meta = p_Meta;

            m_DataSize = p_Info.RangeEnd - p_Info.RangeStart;
            m_Compressed = ID.HasCompressionFlag();

            m_Data = p_Data;
            m_ContainedBundle = p_ContainedBundle;
        }

        /// <summary>
        /// Decodes chunk data
        /// </summary>
        /// <param name="p_Data">Input data</param>
        /// <returns>Decoded chunk data</returns>
        public override byte[] Decode(byte[] p_Data)
        {
            return Compressed ? Decoding.DecodeZlibSegmented(p_Data) : p_Data;
        }
    }
}
