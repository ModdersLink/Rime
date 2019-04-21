using RimeLib.IO;

namespace RimeLib.Frostbite.Bundles
{
    /// <summary>
    /// Abstract implementation of a bundle manfiest. The way that it gets read is dependent on engine version.
    /// </summary>
    public abstract class BundleManifestBase
    {
        /// <summary>
        /// Parent bundle manifest
        /// </summary>
        public BundleManifest ParentManifest { get; set; }

        /// <summary>
        /// TODO: Documentation
        /// </summary>
        public bool EbxMode { get; set; }

        /// <summary>
        /// The bundle that this manifest is for
        /// </summary>
        public BundleBase Bundle { get; set; }

        /// <summary>
        /// TODO: Documentation
        /// </summary>
        /// <param name="p_ParentManifest"></param>
        /// <param name="p_EbxMode"></param>
        protected BundleManifestBase(BundleManifest p_ParentManifest, bool p_EbxMode)
        {
            ParentManifest = p_ParentManifest;
            EbxMode = p_EbxMode;
            Bundle = null;
        }

        /// <summary>
        /// TODO: Documentation
        /// </summary>
        /// <param name="p_Reader"></param>
        /// <param name="p_Entry"></param>
        /// <returns></returns>
        public abstract bool Parse(RimeReader p_Reader, BundleEntry p_Entry);
    }
}
