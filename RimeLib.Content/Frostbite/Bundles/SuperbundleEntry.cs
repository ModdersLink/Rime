namespace RimeLib.Content.Frostbite.Bundles
{
    /// <summary>
    /// Entry describing a superbundle, this information is gathered from the Layout manifest
    /// </summary>
    public class SuperbundleEntry
    {
        /// <summary>
        /// Name of the superbundle
        /// </summary>
        public string Name { get; set; } = "";

        /// <summary>
        /// Path of the base superbundle
        /// </summary>
        public string BasePath => GetBasePath();

        /// <summary>
        /// Path of the patched superbundle
        /// </summary>
        public string PatchPath => GetPatchPath();

        /// <summary>
        /// Base package manifest that this entry is a part of
        /// </summary>
        public PackageManifest ContainedPackage { get; set; }

        /// <summary>
        /// Authoritative (patched) package manifest that this entry is a part of
        /// </summary>
        public PackageManifest? AuthoritativePackage { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public SuperbundleEntry(string p_Name, PackageManifest p_ContainedPackage)
        {
            Name = p_Name;
            ContainedPackage = p_ContainedPackage;
        }

        /// <summary>
        /// Gets the base path of this superbundle entry
        /// ex: /game/Data/Win32/Levels/MP_Subway/MP_Subway
        /// </summary>
        /// <returns>Base path of this superbundle entry</returns>
        protected string GetBasePath()
        {
            if (ContainedPackage == null)
                return "/game/Data/" + Name;

            return "/game" + ContainedPackage.Path + "/Data/" + Name;
        }

        /// <summary>
        /// Gets the patched path of this superbundle entry
        /// </summary>
        /// <returns>Patched path of this superbundle entry</returns>
        protected string GetPatchPath()
        {
            if (AuthoritativePackage == null)
                return "";

            return "/game" + AuthoritativePackage.Path + "/Data/" + Name;
        }
    }
}
