using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Frostbite.Content;
using RimeLib.Content.Frostbite.Storage.Sb;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.IO;

namespace RimeLib.Content.Mounting
{
    public class ContentMounter
    {
        protected string m_GamePath = "";
        protected PackageManifest? m_AuthoritativePackage = null;
        protected List<PackageManifest> m_Packages = new List<PackageManifest>();
        protected List<SuperbundleEntry> m_Superbundles = new List<SuperbundleEntry>();

        public ContentMounter(EngineType p_Engine)
        {
        }

        public async Task<bool> Mount(string p_GamePath)
        {
            // TODO: Remove this. It's just here to get rid of compiler errors.
            await Task.Delay(0);

            m_GamePath = p_GamePath;

            // Discover game packages.
            DiscoverPackages();

            // Discover superbundles.
            DiscoverSuperbundles();

            // Parse superbundles.
            ParseSuperbundles();

            return true;
        }

        public async Task<bool> MountBundle(string p_Bundle)
        {
            // TODO: Remove this. It's just here to get rid of compiler errors.
            await Task.Delay(0);

            return false;
        }

        public IEnumerable<string> GetAvailableBundles()
        {
            throw new NotImplementedException();
        }

        public RimeReader GetChunk(GUID p_GUID)
        {
            throw new NotImplementedException();
        }

        public FrostbiteResource GetResource(string p_Path)
        {
            throw new NotImplementedException();
        }

        public RimeReader GetPartition(string p_Path)
        {
            throw new NotImplementedException();
        }

        protected string GetMainPackagePath()
        {
            return Path.Join(m_GamePath, "Data");
        }

        protected string GetPackagePath(PackageManifest p_Manifest)
        {
            return Path.Join(Path.GetDirectoryName(p_Manifest.Path), "Data");
        }

        protected void DiscoverPackages()
        {
            var s_UpdateDir = Path.Join(m_GamePath, "Update");

            // Check if we have an Update folder.
            if (!Directory.Exists(s_UpdateDir))
                return;

            foreach (var s_Directory in Directory.EnumerateDirectories(s_UpdateDir))
            {
                // Look for a package manifest in this directory.
                var s_ManifestPath = Path.Join(s_Directory, "package.mft");

                if (!File.Exists(s_ManifestPath))
                    continue;

                // Parse the manifest!
                var s_Manifest = new PackageManifest(s_ManifestPath);

                // Store the authoritative package separately.
                if (s_Manifest.Authoritative)
                {
                    if (m_AuthoritativePackage != null)
                        throw new Exception("Found more than one authoritative packages for game. This is unsupported.");

                    m_AuthoritativePackage = s_Manifest;
                    continue;
                }

                // Add the package to the list.
                m_Packages.Add(s_Manifest);
            }

            // Sort the manifests based on mount order.
            m_Packages.Sort((p_Left, p_Right) => p_Left.MountOrder.CompareTo(p_Right.MountOrder));
            
            // Make sure version requirements are satisfied.
            foreach (var s_Manifest in m_Packages)
            {
                if (s_Manifest.RequireVersion <= 0) 
                    continue;

                if (m_AuthoritativePackage == null)
                    throw new Exception($"Package '{s_Manifest.Name}' requires an authoritative package, but one is not found.");

                if (m_AuthoritativePackage.Version < s_Manifest.RequireVersion)
                    throw new Exception($"Package '{s_Manifest.Name}' requires authoritative package with version {s_Manifest.RequireVersion} but we have version {m_AuthoritativePackage.Version}.");
            }
        }

        protected void DiscoverSuperbundles()
        {
            // Parse the content manifest.
            var s_ContentManifestPath = m_AuthoritativePackage != null
                ? Path.Join(GetPackagePath(m_AuthoritativePackage), "layout.toc")
                : Path.Join(GetMainPackagePath(), "layout.toc");

            if (!File.Exists(s_ContentManifestPath))
                throw new Exception("Could not find content manifest (layout.toc).");

            using var s_ContentManifestReader = new RimeReader(File.Open(s_ContentManifestPath, FileMode.Open, FileAccess.Read, FileShare.Read));
            var s_Toc = new TableOfContents<ContentManifest>(s_ContentManifestReader);
            var s_ContentManifest = s_Toc.Layout;

            foreach (var s_Sb in s_ContentManifest.Superbundles)
            {
                var s_SbPath = "";
                PackageManifest? s_ContainedPackage = null;

                // First check if this exists in the main package.
                if (File.Exists(Path.Join(GetMainPackagePath(), s_Sb.Name + ".toc")))
                {
                    s_SbPath = Path.Join(GetMainPackagePath(), s_Sb.Name);
                }
                else
                {
                    // Check all the packages if it doesn't.
                    foreach (var s_Package in m_Packages)
                    {
                        if (!File.Exists(Path.Join(GetPackagePath(s_Package), s_Sb.Name + ".toc")))
                            continue;

                        // Found it!
                        s_SbPath = Path.Join(GetPackagePath(s_Package), s_Sb.Name);
                        s_ContainedPackage = s_Package;
                        break;
                    }
                }

                // Skip if we didn't find this superbundle.
                if (string.IsNullOrWhiteSpace(s_SbPath))
                {
                    Debug.WriteLine($"Superbundle '{s_Sb.Name}' was listed in content manifest but could not be found.");
                    continue;
                }

                // Create a superbundle entry for this superbundle.
                var s_SbEntry = new SuperbundleEntry(s_Sb.Name, s_SbPath)
                {
                    ContainedPackage = s_ContainedPackage,
                };

                // If we have an authoritative package then check if there's a patched sb.
                if (m_AuthoritativePackage != null && File.Exists(Path.Join(GetPackagePath(m_AuthoritativePackage), s_Sb.Name + ".toc")))
                    s_SbEntry.PatchPath = Path.Join(GetPackagePath(m_AuthoritativePackage), s_Sb.Name);

                // Add to the list of discovered superbundles.
                m_Superbundles.Add(s_SbEntry);
            }
        }

        protected void ParseSuperbundles()
        {

        }
    }
}
