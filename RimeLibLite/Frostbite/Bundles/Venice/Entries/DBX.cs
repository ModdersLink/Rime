using RimeLib.Frostbite.Core;
using RimeLib.Frostbite.Db;

namespace RimeLib.Frostbite.Bundles.Venice.Entries
{
    /// <summary>
    /// Implementation for dbx objects
    /// </summary>
    public class Dbx : Bundles.Entries.Dbx
    {
        /// <summary>
        /// Constructor for creating a dbx object from DbObject information
        /// </summary>
        /// <param name="p_Object">DbObject that contains dbx information</param>
        /// <param name="p_ContainedBundle">Bundle that contains this dbx</param>
        public Dbx(DbObject p_Object, BundleBase p_ContainedBundle)
        {
            Name = p_Object["name"].Value as string;
            Hash = (Sha1) p_Object["sha1"].Value;

            if (p_Object.HasKey("idata"))
                m_Data = (byte[]) p_Object["idata"].Value;

            m_ContainedBundle = p_ContainedBundle;
        }

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns>Name of the dbx</returns>
        public override string ToString()
        {
            return Name;
        }
    }
}
