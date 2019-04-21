using RimeLib.Frostbite.Core;
using RimeLib.Frostbite.Db;

namespace RimeLib.Frostbite.Bundles
{
    /// <summary>
    /// An entry within a frostbite bundle
    /// </summary>
    public class BundleEntry
    {
        /// <summary>
        /// The id of the bundle entry, this will normally get filled after loading
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// Offset of the entries data
        /// </summary>
        public long Offset { get; set; }

        /// <summary>
        /// Size of the entries data
        /// </summary>
        public long Size { get; set; }

        /// <summary>
        /// Is this a delta patch or not
        /// </summary>
        public bool Delta { get; set; }

        /// <summary>
        /// Is this the base or not
        /// </summary>
        public bool Base { get; set; }

        /// <summary>
        /// Hash of the data
        /// </summary>
        public Sha1 Hash { get; set; }

        /// <summary>
        /// The superbundle that this bundle entry is apart of
        /// </summary>
        public SuperbundleLayout BaseSuperbundle { get; set; }

        /// <summary>
        /// The delta entry for patching
        /// </summary>
        public BundleEntry DeltaEntry { get; set; }

        /// <summary>
        /// Bundle entry constructor
        /// </summary>
        /// <param name="p_Object">The DbObject representing a frostbite bundle</param>
        /// <param name="p_BaseSuperbundle">The superbundle that this bundle entry is a part of</param>
        public BundleEntry(DbObject p_Object, SuperbundleLayout p_BaseSuperbundle)
        {
            BaseSuperbundle = p_BaseSuperbundle;

            var s_Id = p_Object["id"];

            if (s_Id != null)
                ID = (string) s_Id.Value;

            var s_Offset = p_Object["offset"];

            if (s_Offset != null)
                Offset = (long) s_Offset.Value;

            var s_Delta = p_Object["delta"];

            if (s_Delta != null)
                Delta = (bool) s_Delta.Value;

            var s_Base = p_Object["base"];

            if (s_Base != null)
                Base = (bool) s_Base.Value;

            // Patch formats tend to use integer instead of long? Why dice why?
            var s_Size = p_Object["size"];

            if (s_Size != null)
            {
                switch (s_Size.Type)
                {
                    case DbObjectType.Integer:
                        Size = (int) s_Size.Value;
                        break;

                    case DbObjectType.Long:
                        Size = (long) s_Size.Value;
                        break;
                }
            }

            var s_Checksum = p_Object["checksum"];

            if (s_Checksum != null)
                Hash = (Sha1) s_Checksum.Value;
        }
    }
}
