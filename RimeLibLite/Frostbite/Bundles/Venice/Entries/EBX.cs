using System;
using RimeLib.Frostbite.Core;
using RimeLib.Frostbite.Db;

namespace RimeLib.Frostbite.Bundles.Venice.Entries
{
    /// <summary>
    /// Ebx implementation from a bundle
    /// </summary>
    public class EBX : Bundles.Entries.EBX
    {
        /// <summary>
        /// Ebx constructor to create an object from DbObject
        /// </summary>
        /// <param name="p_Object">DbObject containing ebx information from the bundle</param>
        /// <param name="p_ContainedBundle">Bundle that this ebx is from</param>
        public EBX(DbObject p_Object, BundleBase p_ContainedBundle)
        {
            Name = p_Object["name"].Value as string;
            Hash = (Sha1) p_Object["sha1"].Value;

            m_DataSize = (long) p_Object["size"].Value;

            m_Compressed = !p_Object.HasKey("originalSize") || m_DataSize != (long) p_Object["originalSize"].Value;
            m_ContainedBundle = p_ContainedBundle;
        }

        /// <summary>
        /// Ebx constructor for manually adding a ebx entry
        /// </summary>
        /// <param name="p_Name">Name of the ebx</param>
        /// <param name="p_Hash">Hash of the ebx</param>
        /// <param name="p_Record">Record containing information about the ebx from bundle</param>
        /// <param name="p_Data">Ebx data</param>
        /// <param name="p_ContainedBundle">The bundle that contains this ebx file</param>
        public EBX(string p_Name, Sha1 p_Hash, EntryRecord p_Record, byte[] p_Data, BundleBase p_ContainedBundle)
        {
            Name = p_Name;
            Hash = p_Hash;
            m_Data = p_Data;
            m_DataSize = p_Record.PayloadSize;
            m_Compressed = m_DataSize != p_Record.OriginalSize;
            m_ContainedBundle = p_ContainedBundle;
        }

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns>Name of ebx</returns>
        public override string ToString()
        {
            return Name;
        }

        /// <summary>
        /// Unused function
        /// </summary>
        /// <param name="p_Data">Input data</param>
        /// <returns>Input data, or throws exception if compressed ebx (not supported)</returns>
        public override byte[] Decode(byte[] p_Data)
        {
            // TODO: Figure out what compression method this uses.
            if (m_Compressed)
                throw new NotImplementedException();
            
            return p_Data;
        }
    }
}
