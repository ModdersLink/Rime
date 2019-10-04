using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Frostbite.Content;
using RimeLib.Content.Frostbite.Storage.Bundles;
using RimeLib.Content.Frostbite.Storage.Cas;
using RimeLib.Content.Frostbite.Storage.Chunks;
using RimeLib.Content.Frostbite.Storage.Sb;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.Frostbite.Db;
using RimeLib.IO;
using RimeLib.IO.Conversion;

namespace RimeLib.Content.Mounting
{
    public class ContentMounter
    {
        protected string m_GamePath = "";
        protected PackageManifest? m_AuthoritativePackage;
        protected List<PackageManifest> m_Packages = new List<PackageManifest>();
        protected List<SuperbundleEntry> m_Superbundles = new List<SuperbundleEntry>();
        protected Catalog? m_Catalog;
        protected ConcurrentDictionary<GUID, ChunkEntry> m_Chunks = new ConcurrentDictionary<GUID, ChunkEntry>();
        protected ConcurrentDictionary<string, BundleManifest> m_Bundles = new ConcurrentDictionary<string, BundleManifest>();
        protected ConcurrentDictionary<string, CasBundle> m_CasBundles = new ConcurrentDictionary<string, CasBundle>();

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

            // Parse catalogs.
            ParseCatalogs();

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

        protected void ParseCatalogs()
        {
            // Parse the main catalog.
            var s_MainCatalogPath = Path.Join(GetMainPackagePath(), "cas.cat");

            if (!File.Exists(s_MainCatalogPath))
                return;

            m_Catalog = new Catalog(s_MainCatalogPath);

            // If we have an authoritative package then parse that too.
            if (m_AuthoritativePackage == null) 
                return;

            var s_PatchCatalogPath = Path.Join(GetPackagePath(m_AuthoritativePackage), "cas.cat");

            if (File.Exists(s_PatchCatalogPath))
                m_Catalog.AuthoritativeCatalog = new Catalog(s_PatchCatalogPath);
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
            var s_ManifestToc = new TableOfContents<ContentManifest>(s_ContentManifestReader);
            var s_ContentManifest = s_ManifestToc.Layout;

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

                TableOfContents<SuperbundleLayout> s_Toc;
                
                // Parse the superbundle layout.
                using (var s_Reader = new RimeReader(File.Open(s_SbPath + ".toc", FileMode.Open, FileAccess.Read, FileShare.Read)))
                    s_Toc = new TableOfContents<SuperbundleLayout>(s_Reader);

                // Create a superbundle entry for this superbundle.
                var s_SbEntry = new SuperbundleEntry(s_Sb.Name, s_SbPath, s_Toc)
                {
                    ContainedPackage = s_ContainedPackage,
                };

                // If we have an authoritative package then check if there's a patched sb.
                if (m_AuthoritativePackage != null && File.Exists(Path.Join(GetPackagePath(m_AuthoritativePackage), s_Sb.Name + ".toc")))
                {
                    s_SbEntry.PatchPath = Path.Join(GetPackagePath(m_AuthoritativePackage), s_Sb.Name);

                    // Parse the patched superbundle layout.
                    using var s_Reader = new RimeReader(File.Open(s_SbEntry.PatchPath + ".toc", FileMode.Open, FileAccess.Read, FileShare.Read));
                    s_SbEntry.PatchToc = new TableOfContents<SuperbundleLayout>(s_Reader);
                }

                // Add to the list of discovered superbundles.
                m_Superbundles.Add(s_SbEntry);
            }
        }

        protected void ProcessChunk(ChunkInfo p_Chunk, SuperbundleEntry p_SbEntry)
        {
            // If there's a SHA1 specified then this is a cas-backed chunk.
            if (p_Chunk.Sha1 != null)
            {
                if (m_Catalog == null)
                    throw new Exception("Found a cas chunk entry but the game has no catalog!");

                var s_ChunkEntry = new CasChunkEntry(p_Chunk.Id, p_Chunk.Sha1, m_Catalog);
                m_Chunks.AddOrUpdate(s_ChunkEntry.Id, s_ChunkEntry, (p_Key, p_Old) => s_ChunkEntry);
                return;
            }

            // Otherwise, it's an sb-backed chunk.
            var s_SbChunkEntry = new SbChunkEntry(p_Chunk.Id, p_Chunk.Offset!.Value, p_Chunk.Size!.Value, p_SbEntry);
            m_Chunks.AddOrUpdate(s_SbChunkEntry.Id, s_SbChunkEntry, (p_Key, p_Old) => s_SbChunkEntry);
        }

        protected void ParseSuperbundles()
        {
            // TODO: Re-enable parallel processing once we've made sure everything is working as intended.
            //Parallel.ForEach(m_Superbundles, p_Superbundle =>
            m_Superbundles.ForEach(p_Superbundle =>
            {
                Debug.WriteLine($"Parsing superbundle {p_Superbundle.Name}");

                // Parse any chunks first.
                foreach (var s_Chunk in p_Superbundle.Toc.Layout.Chunks)
                    ProcessChunk(s_Chunk, p_Superbundle);
                
                // If we have a patch toc process the chunks for that too.
                if (p_Superbundle.PatchToc != null)
                    foreach (var s_Chunk in p_Superbundle.PatchToc.Layout.Chunks)
                        ProcessChunk(s_Chunk, p_Superbundle);

                // Now it's time to parse bundles, oh boy!
                ParseBundles(p_Superbundle, p_Superbundle.Toc.Layout, p_Superbundle.PatchToc?.Layout);
            });
        }

        protected void ParseCasBundle(RimeReader p_Reader, BundleInfo p_BundleInfo, SuperbundleEntry p_Superbundle)
        {
            p_Reader.Seek(p_BundleInfo.Offset, SeekOrigin.Begin);

            var (s_Bundle, _) = DbObjectConverter.FromDbObjectReader<CasBundle>(p_Reader, p_BundleInfo.Size);
            m_CasBundles.AddOrUpdate(p_BundleInfo.Id.ToLowerInvariant(), s_Bundle, (p_Key, p_Prev) => s_Bundle);
        }
        
        protected void ParseBundle(RimeReader p_Reader, BundleInfo p_BundleInfo, SuperbundleEntry p_Superbundle)
        {
            // TODO: Use a limited reader.
            p_Reader.Seek(p_BundleInfo.Offset, SeekOrigin.Begin);
            var s_Manifest = new BundleManifest(p_Reader, p_Superbundle, p_BundleInfo);

            m_Bundles.AddOrUpdate(p_BundleInfo.Id.ToLowerInvariant(), s_Manifest, (p_Key, p_Prev) => s_Manifest);
        }

        protected void ParseDeltaBundle(RimeReader p_BaseReader, RimeReader p_PatchReader, 
            BundleInfo p_BaseBundle, BundleInfo p_PatchBundle, SuperbundleEntry p_Superbundle)
        {
            // TODO: Use multiplexed reader.
            p_BaseReader.Seek(p_BaseBundle.Offset, SeekOrigin.Begin);
            var s_Manifest = new BundleManifest(p_BaseReader, p_Superbundle, p_BaseBundle);

            m_Bundles.AddOrUpdate(p_BaseBundle.Id.ToLowerInvariant(), s_Manifest, (p_Key, p_Prev) => s_Manifest);
        }

        protected void ParseBundles(SuperbundleEntry p_Superbundle, SuperbundleLayout p_Toc, SuperbundleLayout? p_PatchToc)
        {
            // Figure out which endianness our readers should have.
            var s_Endianness = p_Toc.Cas ? Endianness.LittleEndian : Endianness.BigEndian;

            // Open up our superbundle readers.
            using var s_Reader = new RimeReader(File.Open(p_Superbundle.Path + ".sb", FileMode.Open, FileAccess.Read, FileShare.Read), s_Endianness);
            RimeReader? s_PatchReader = null;

            if (p_Superbundle.PatchPath != null)
                s_PatchReader = new RimeReader(File.Open(p_Superbundle.PatchPath + ".sb", FileMode.Open, FileAccess.Read, FileShare.Read), s_Endianness);

            var s_ParsedBundles = new HashSet<string>();

            // Go through the base bundles first.
            foreach (var s_Bundle in p_Toc.Bundles)
            {
                s_ParsedBundles.Add(s_Bundle.Id.ToLowerInvariant());

                // If we don't have a patched toc or if we do but don't have
                // a corresponding bundle entry, or if the base flag is set
                // then parse straight away!
                if (p_PatchToc == null || !p_PatchToc.TryGetBundle(s_Bundle.Id, out var s_PatchBundle) || (s_PatchBundle!.Base.HasValue && s_PatchBundle.Base.Value))
                {
                    if (p_Toc.Cas)
                    {
                        ParseCasBundle(s_Reader, s_Bundle, p_Superbundle);
                        continue;
                    }

                    ParseBundle(s_Reader, s_Bundle, p_Superbundle);
                    continue;
                }

                // If we do have a corresponding bundle entry, then figure out what to do with it.
                // If it's a delta entry then we have special handling for it.
                if (s_PatchBundle!.Delta.HasValue && s_PatchBundle!.Delta.Value)
                {
                    ParseDeltaBundle(s_Reader, s_PatchReader!, s_Bundle, s_PatchBundle, p_Superbundle);
                    continue;
                }

                // If this wasn't a delta entry then parse as we normally would.
                if (p_Toc.Cas)
                {
                    ParseCasBundle(s_PatchReader!, s_PatchBundle, p_Superbundle);
                    continue;
                }

                ParseBundle(s_PatchReader!, s_PatchBundle, p_Superbundle);
            }
            
            // Now that we're done with the base bundles it's time to go over the patched ones.
            if (p_PatchToc != null)
            {
                foreach (var s_Bundle in p_PatchToc.Bundles)
                {
                    // We only care about bundles we haven't seen before.
                    if (s_ParsedBundles.Contains(s_Bundle.Id.ToLowerInvariant()))
                        continue;

                    // If this is a delta entry for a bundle we've never seen before
                    // there's something wrong (usually missing content).
                    // TODO: We might not want to throw an error here.
                    if (s_Bundle.Delta.HasValue && s_Bundle.Delta.Value)
                        throw new Exception($"Found a delta bundle ({s_Bundle.Id}) without a base bundle entry. This probably means you're missing some content.");
                    
                    if (p_PatchToc.Cas)
                    {
                        ParseCasBundle(s_PatchReader!, s_Bundle, p_Superbundle);
                        continue;
                    }

                    // If all is good, parse as we normally would.
                    ParseBundle(s_PatchReader!, s_Bundle, p_Superbundle);
                }
            }

            // Dispose of the patch reader.
            s_PatchReader?.Dispose();
        }
    }
}
