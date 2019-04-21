using RimeLib.Frostbite.Core;
using RimeLib.Frostbite.Db;
using RimeLib.IO;

namespace RimeLib.Frostbite.Bundles.Venice.Entries
{
    /// <summary>
    /// Resource implementation from a bundle
    /// </summary>
    public class Resource : Bundles.Entries.Resource
    {
        /// <summary>
        /// Resource constructor from DbObject
        /// </summary>
        /// <param name="p_Object">DbObject that contains information about this resource</param>
        /// <param name="p_ContainedBundle">Bundle that this resource is contained in</param>
        public Resource(DbObject p_Object, BundleBase p_ContainedBundle)
        {
            Name = p_Object["name"].Value as string;
            TypeHash = (ResourceType) (uint) (int) p_Object["resType"].Value;
            Meta = (byte[]) p_Object["resMeta"].Value;
            Hash = (Sha1) p_Object["sha1"].Value;

            m_DataSize = (long) p_Object["size"].Value;
            m_Compressed = !p_Object.HasKey("originalSize") || m_DataSize != (long)p_Object["originalSize"].Value;
            
            m_ContainedBundle = p_ContainedBundle;
        }

        /// <summary>
        /// Constructor for manually creating a resource
        /// </summary>
        /// <param name="p_Name">Name of the resource</param>
        /// <param name="p_Hash">Hash of the resource data</param>
        /// <param name="p_TypeHash">Hash of the resource type name, can be generated from RimeHelper.HashLowerCase</param>
        /// <param name="p_Data">Resource data</param>
        /// <param name="p_Meta">Resource metadata</param>
        /// <param name="p_Record">Record from bundle containing information on the resource</param>
        /// <param name="p_ContainedBundle">Bundle that contains this resource</param>
        public Resource(string p_Name, Sha1 p_Hash, uint p_TypeHash, byte[] p_Data, byte[] p_Meta, EntryRecord p_Record, BundleBase p_ContainedBundle)
        {
            Name = p_Name;
            Hash = p_Hash;
            TypeHash = (ResourceType) p_TypeHash;
            Meta = p_Meta;

            m_DataSize = p_Record.PayloadSize;
            m_Compressed = m_DataSize != p_Record.OriginalSize;
            m_Data = p_Data;

            m_ContainedBundle = p_ContainedBundle;
        }

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns>Resource name</returns>
        public override string ToString()
        {
            return Name;
        }

        /// <summary>
        /// Decodes resource data
        /// </summary>
        /// <param name="p_Data">Input data</param>
        /// <returns>Decoded resource data</returns>
        public override byte[] Decode(byte[] p_Data)
        {
            return m_Compressed ? Decoding.DecodeZlibSegmented(p_Data) : p_Data;
        }
    }
}
