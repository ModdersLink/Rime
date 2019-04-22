using System;
using RimeLib.Frostbite.Core;
using RimeLib.Frostbite.Db;

namespace RimeLib.Content.Frostbite.Bundles
{
    /// <summary>
    /// An entry within a frostbite bundle
    /// </summary>
    public class BundleEntry
    {
        /// <summary>
        /// The id of the bundle entry, this will normally get filled after loading
        /// </summary>
        public string Id { get; set; }

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
        public BundleEntry? DeltaEntry { get; set; }

        /// <summary>
        /// Bundle entry constructor
        /// </summary>
        /// <param name="p_Object">The DbObject representing a frostbite bundle</param>
        /// <param name="p_BaseSuperbundle">The superbundle that this bundle entry is a part of</param>
        public BundleEntry(DbObject p_Object, SuperbundleLayout p_BaseSuperbundle)
        {
            BaseSuperbundle = p_BaseSuperbundle;

            if (!p_Object["id"].TryGetSpecialization<string>(out var s_Id))
                throw new Exception("BundleEntry DbObject had no id field.");

            Id = s_Id;

            if (!p_Object["offset"].TryGetSpecialization<long>(out var s_Offset))
                throw new Exception("BundleEntry DbObject had no offset field.");

            Offset = s_Offset;

            if (!p_Object["checksum"].TryGetSpecialization<Sha1>(out var s_Checksum))
                throw new Exception("BundleEntry DbObject had no checksum field.");

            Hash = s_Checksum;

            // Patch formats tend to use integer instead of long? Why dice why?
            if (!p_Object.HasKey("size"))
                throw new Exception("BundleEntry DbObject had no size field.");

            var s_Size = p_Object["size"];

            switch (s_Size.Type)
            {
                case DbObjectType.Integer:
                    Size = (int) s_Size.Value;
                    break;

                case DbObjectType.Long:
                    Size = (long) s_Size.Value;
                    break;

                default:
                    throw new Exception("BundleEntry DbObject had no size field of supported type.");
            }

            if (p_Object["delta"].TryGetSpecialization<bool>(out var s_Delta))
                Delta = s_Delta;

            if (p_Object["base"].TryGetSpecialization<bool>(out var s_Base))
                Base = s_Base;
        }
    }
}
