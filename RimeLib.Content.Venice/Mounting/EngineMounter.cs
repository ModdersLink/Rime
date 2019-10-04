using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using RimeLib.Content.Frostbite;
using RimeLib.Content.IO;
using RimeLib.Content.Mounting;
using RimeLib.Content.Venice.Frostbite.Bundles;
using RimeLib.Content.Venice.Frostbite.Cas;
using RimeLib.Content.Venice.Frostbite.Chunks;
using RimeLib.Content.Venice.Frostbite.Sb;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.Frostbite.Db;
using RimeLib.IO;
using RimeLib.IO.Conversion;

namespace RimeLib.Content.Venice.Mounting
{
    public class EngineMounter : IEngineMounter
    {
        protected string m_GamePath = "";
        
        protected PackageManifest? m_AuthoritativePackage;
        protected List<PackageManifest> m_Packages = new List<PackageManifest>();
        
        protected List<SuperbundleEntry> m_Superbundles = new List<SuperbundleEntry>();
        protected Catalog? m_Catalog;

        protected ConcurrentDictionary<GUID, ChunkEntry> m_Chunks = new ConcurrentDictionary<GUID, ChunkEntry>();
        protected ConcurrentDictionary<string, BundleManifest> m_Bundles = new ConcurrentDictionary<string, BundleManifest>();
        protected ConcurrentDictionary<string, CasBundleEntry> m_CasBundles = new ConcurrentDictionary<string, CasBundleEntry>();

        private readonly ConcurrentDictionary<string, MountedObject<IResourceVariant>> m_MountedResources = new ConcurrentDictionary<string, MountedObject<IResourceVariant>>();
        private readonly ConcurrentDictionary<GUID, MountedObject<IChunkVariant>> m_MountedChunks = new ConcurrentDictionary<GUID, MountedObject<IChunkVariant>>();
        private readonly ConcurrentDictionary<string, MountedObject> m_MountedPartitions = new ConcurrentDictionary<string, MountedObject>();

        public EngineType GetSupportedEngine()
        {
            return EngineType.Frostbite2_0;
        }

        public async Task Mount(string p_GamePath, bool p_AutoMount)
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
            // Do this only when in "automount" mode.
            if (p_AutoMount)
                ParseSuperbundles();
        }

        public IEnumerable<string> GetAvailableSuperbundles()
        {
            foreach (var s_Superbundle in m_Superbundles)
                yield return s_Superbundle.Name;
        }

        public async Task MountSuperbundle(string p_Superbundle, bool p_AutoMount)
        {
            // TODO: Remove this. It's just here to get rid of compiler errors.
            await Task.Delay(0);

            // Check if we have this superbundle.
            var s_Superbundle = m_Superbundles.FirstOrDefault(p_Sb =>
                p_Sb.Name.Equals(p_Superbundle, StringComparison.InvariantCultureIgnoreCase));

            if (s_Superbundle == null)
                throw new ArgumentException($"Could not find a superbundle to mount with the provided name '{p_Superbundle}'.", nameof(p_Superbundle));

            // Now that we know that we do, let's mount it.
            ParseSuperbundle(s_Superbundle, p_AutoMount);
        }

        public IEnumerable<string> GetAvailableBundles()
        {
            var s_Keys = new HashSet<string>();

            s_Keys.UnionWith(m_CasBundles.Keys);
            s_Keys.UnionWith(m_Bundles.Keys);

            return s_Keys;
        }

        public async Task MountBundle(string p_Bundle)
        {
            // TODO: Remove this. It's just here to get rid of compiler errors.
            await Task.Delay(0);

            // Check to see if this is a CAS bundle or an embedded bundle and mount it accordingly.
            if (m_CasBundles.TryGetValue(p_Bundle.ToLowerInvariant(), out var s_CasBundle))
            {
                MountCasBundle(s_CasBundle);
                return;
            }

            if (m_Bundles.TryGetValue(p_Bundle.ToLowerInvariant(), out var s_EmbeddedBundle))
            {
                MountEmbeddedBundle(s_EmbeddedBundle);
                return;
            }
        }

        public IEnumerable<string> GetResourcesInBundle(string p_Bundle)
        {
            if (m_CasBundles.TryGetValue(p_Bundle.ToLowerInvariant(), out var s_CasBundle))
            {
                foreach (var s_Resource in s_CasBundle.Bundle.ResourceEntries)
                    yield return s_Resource.Name;
            }
            else if (m_Bundles.TryGetValue(p_Bundle.ToLowerInvariant(), out var s_Bundle))
            {
                foreach (var s_Resource in s_Bundle.Resources)
                    yield return s_Resource.Name;
            }
        }

        public IEnumerable<GUID> GetChunksInBundle(string p_Bundle)
        {
            if (m_CasBundles.TryGetValue(p_Bundle.ToLowerInvariant(), out var s_CasBundle))
            {
                foreach (var s_Chunk in s_CasBundle.Bundle.ChunkEntries)
                    yield return s_Chunk.Id;
            }
            else if (m_Bundles.TryGetValue(p_Bundle.ToLowerInvariant(), out var s_Bundle))
            {
                foreach (var s_Chunk in s_Bundle.Chunks)
                    yield return s_Chunk.Id;
            }
        }

        public IEnumerable<string> GetPartitionsInBundle(string p_Bundle)
        {
            if (m_CasBundles.TryGetValue(p_Bundle.ToLowerInvariant(), out var s_CasBundle))
            {
                foreach (var s_Partition in s_CasBundle.Bundle.EbxEntries)
                    yield return s_Partition.Name;
            }
            else if (m_Bundles.TryGetValue(p_Bundle.ToLowerInvariant(), out var s_Bundle))
            {
                foreach (var s_Partition in s_Bundle.Ebx)
                    yield return s_Partition.Name;
            }
        }

        public bool TryGetResource(string p_Path, out IMountedObject<IResourceVariant>? p_Resource)
        {
            if (m_MountedResources.TryGetValue(p_Path.ToLowerInvariant(), out var s_Resource))
            {
                p_Resource = s_Resource;
                return true;
            }
            
            p_Resource = null;
            return false;
        }

        public bool TryGetChunk(GUID p_GUID, out IMountedObject<IChunkVariant>? p_Chunk)
        {
            if (m_MountedChunks.TryGetValue(p_GUID, out var s_Chunk))
            {
                p_Chunk = s_Chunk;
                return true;
            }
            
            p_Chunk = null;
            return false;
        }

        public bool TryGetPartition(string p_Path, out IMountedObject? p_Partition)
        {
            if (m_MountedPartitions.TryGetValue(p_Path.ToLowerInvariant(), out var s_Partition))
            {
                p_Partition = s_Partition;
                return true;
            }
            
            p_Partition = null;
            return false;
        }

        public Dictionary<string, IMountedObject<IResourceVariant>> GetResources()
        {
            return m_MountedResources.ToDictionary(p_Pair => p_Pair.Key, p_Pair => p_Pair.Value as IMountedObject<IResourceVariant>);
        }

        public Dictionary<GUID, IMountedObject<IChunkVariant>> GetChunks()
        {
            return m_MountedChunks.ToDictionary(p_Pair => p_Pair.Key, p_Pair => p_Pair.Value as IMountedObject<IChunkVariant>);
        }

        public Dictionary<string, IMountedObject> GetPartitions()
        {
            return m_MountedPartitions.ToDictionary(p_Pair => p_Pair.Key, p_Pair => p_Pair.Value as IMountedObject);
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
                var s_SbEntry = new SuperbundleEntry(s_Sb.Name.ToLowerInvariant(), s_SbPath, s_Toc)
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

        protected void ProcessChunk(ChunkInfo p_Chunk, SuperbundleEntry p_SbEntry, bool p_Patch)
        {
            ChunkEntry s_ChunkEntry;

            if (p_Chunk.Sha1 != null)
            {
                // If there's a SHA1 specified then this is a cas-backed chunk.
                if (m_Catalog == null)
                    throw new Exception("Found a cas chunk entry but the game has no catalog!");

                s_ChunkEntry = new CasChunkEntry(p_Chunk.Id, p_Chunk.Sha1, m_Catalog);
            }
            else
            {
                // Otherwise, it's an sb-backed chunk.
                s_ChunkEntry = new SbChunkEntry(p_Chunk.Id, p_Chunk.Offset!.Value, p_Chunk.Size!.Value, p_SbEntry, p_Patch);
            }

            // Add to list of chunks.
            // TODO: Remove this.
            m_Chunks.AddOrUpdate(s_ChunkEntry.Id, s_ChunkEntry, (p_Key, p_Old) => s_ChunkEntry);

            // Mount.
            var s_Variant = new ChunkVariant(s_ChunkEntry, null, p_SbEntry.Name, null);
            var s_MountedObject = new MountedObject<IChunkVariant>(s_Variant);

            // Here we always replace because patched chunks get registered after and they override old ones.
            m_MountedChunks.AddOrUpdate(s_ChunkEntry.Id, s_MountedObject, (p_GUID, p_MountedObject) => s_MountedObject);
        }

        protected void ParseSuperbundles()
        {
            // TODO: Re-enable parallel processing once we've made sure everything is working as intended.
            Parallel.ForEach(m_Superbundles, p_Superbundle => ParseSuperbundle(p_Superbundle, true));
            //m_Superbundles.ForEach(p_Superbundle => ParseSuperbundle(p_Superbundle, true));
        }

        protected void ParseSuperbundle(SuperbundleEntry p_Superbundle, bool p_AutoMount)
        {
            Debug.WriteLine($"Parsing superbundle {p_Superbundle.Name}");

            // Parse any chunks first.
            foreach (var s_Chunk in p_Superbundle.Toc.Layout.Chunks)
                ProcessChunk(s_Chunk, p_Superbundle, false);
                
            // If we have a patch toc process the chunks for that too.
            if (p_Superbundle.PatchToc != null)
                foreach (var s_Chunk in p_Superbundle.PatchToc.Layout.Chunks)
                    ProcessChunk(s_Chunk, p_Superbundle, true);

            // Now it's time to parse bundles, oh boy!
            ParseBundles(p_Superbundle, p_Superbundle.Toc.Layout, p_Superbundle.PatchToc?.Layout, p_AutoMount);
        }

        protected void ParseCasBundle(RimeReader p_Reader, BundleInfo p_BundleInfo, SuperbundleEntry p_Superbundle, bool p_AutoMount)
        {
            p_Reader.Seek(p_BundleInfo.Offset, SeekOrigin.Begin);

            var (s_Bundle, _) = DbObjectConverter.FromDbObjectReader<CasBundle>(p_Reader, p_BundleInfo.Size);
            var s_BundleEntry = new CasBundleEntry(s_Bundle, p_Superbundle);

            m_CasBundles.AddOrUpdate(p_BundleInfo.Id.ToLowerInvariant(), s_BundleEntry, (p_Key, p_Prev) =>
            {
                // TODO: Exception?
                Debug.WriteLine($"Replacing previous cas bundle {p_BundleInfo.Id}");
                return s_BundleEntry;
            });

            // Don't do if automount isn't on.
            if (p_AutoMount && !MountCasBundle(s_BundleEntry)) 
                throw new Exception($"Failed to mount bundle '{s_Bundle.Path}'.");
        }
        
        protected void ParseBundle(RimeReader p_Reader, BundleInfo p_BundleInfo, SuperbundleEntry p_Superbundle, bool p_AutoMount)
        {
            // TODO: Use a limited reader.
            p_Reader.Seek(p_BundleInfo.Offset, SeekOrigin.Begin);
            var s_Manifest = new BundleManifest(p_Reader, p_Superbundle, p_BundleInfo);

            m_Bundles.AddOrUpdate(p_BundleInfo.Id.ToLowerInvariant(), s_Manifest, (p_Key, p_Prev) =>
            {
                // TODO: Exception?
                Debug.WriteLine($"Replacing previous embedded bundle {p_BundleInfo.Id}");
                return s_Manifest;
            });

            // Don't do if automount isn't on.
            if (p_AutoMount && !MountEmbeddedBundle(s_Manifest)) 
                throw new Exception($"Failed to mount embedded bundle '{p_BundleInfo.Id}'.");
        }

        protected void ParseDeltaBundle(RimeReader p_BaseReader, RimeReader p_PatchReader, 
            BundleInfo p_BaseBundle, BundleInfo p_PatchBundle, SuperbundleEntry p_Superbundle, bool p_AutoMount)
        {
            p_BaseReader.Seek(p_BaseBundle.Offset, SeekOrigin.Begin);
            p_PatchReader.Seek(p_PatchBundle.Offset, SeekOrigin.Begin);

            // Use a multiplexed reader to parse this manifest.
            using var s_MultiplexedReader = new RimeMultiplexedReader(p_PatchReader, p_BaseReader, Endianness.BigEndian);

            var s_Manifest = new BundleManifest(s_MultiplexedReader, p_Superbundle, p_BaseBundle, p_PatchBundle);

            m_Bundles.AddOrUpdate(p_BaseBundle.Id.ToLowerInvariant(), s_Manifest, (p_Key, p_Prev) =>
            {
                // TODO: Exception?
                Debug.WriteLine($"Replacing previous embedded bundle {p_BaseBundle.Id}");
                return s_Manifest;
            });

            // Don't do if automount isn't on.
            if (p_AutoMount && !MountEmbeddedBundle(s_Manifest)) 
                throw new Exception($"Failed to mount embedded delta bundle '{p_BaseBundle.Id}'.");
        }

        protected void ParseBundles(SuperbundleEntry p_Superbundle, SuperbundleLayout p_Toc, SuperbundleLayout? p_PatchToc, bool p_AutoMount)
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

                // If we don't have a patched toc, or
                // if we do but don't have a corresponding bundle entry, or
                // if the base flag is set, then
                // parse straight away!
                if (p_PatchToc == null || !p_PatchToc.TryGetBundle(s_Bundle.Id, out var s_PatchBundle) || (s_PatchBundle!.Base.HasValue && s_PatchBundle.Base.Value))
                {
                    if (p_Toc.Cas)
                    {
                        ParseCasBundle(s_Reader, s_Bundle, p_Superbundle, p_AutoMount);
                        continue;
                    }

                    ParseBundle(s_Reader, s_Bundle, p_Superbundle, p_AutoMount);
                    continue;
                }

                // If we do have a corresponding bundle entry, then figure out what to do with it.
                // If it's a delta entry then we have special handling for it.
                if (s_PatchBundle!.Delta.HasValue && s_PatchBundle!.Delta.Value)
                {
                    ParseDeltaBundle(s_Reader, s_PatchReader!, s_Bundle, s_PatchBundle, p_Superbundle, p_AutoMount);
                    continue;
                }

                // If this wasn't a delta entry then parse as we normally would.
                if (p_Toc.Cas)
                {
                    ParseCasBundle(s_PatchReader!, s_PatchBundle, p_Superbundle, p_AutoMount);
                    continue;
                }

                ParseBundle(s_PatchReader!, s_PatchBundle, p_Superbundle, p_AutoMount);
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
                        ParseCasBundle(s_PatchReader!, s_Bundle, p_Superbundle, p_AutoMount);
                        continue;
                    }

                    // If all is good, parse as we normally would.
                    ParseBundle(s_PatchReader!, s_Bundle, p_Superbundle, p_AutoMount);
                }
            }

            // Dispose of the patch reader.
            s_PatchReader?.Dispose();
        }

        protected bool MountCasBundle(CasBundleEntry p_Bundle)
        {
            // Mount all resources.
            foreach (var s_Resource in p_Bundle.Bundle.ResourceEntries)
            {
                // Create variant.
                var s_Readable = new CatalogReadable(m_Catalog!, s_Resource.Hash);
                var s_Variant = new ResourceVariant(s_Readable, (ResourceType) s_Resource.ResourceType, s_Resource.Meta,
                    p_Bundle.ContainedSuperbundle.Name, p_Bundle.Bundle.Path);

                // Mount.
                var s_MountedObject = new MountedObject<IResourceVariant>(s_Variant);

                m_MountedResources.AddOrUpdate(s_Resource.Name.ToLowerInvariant(), s_MountedObject, (p_GUID, p_MountedObject) =>
                {
                    // If this was already mounted, just add the variant.
                    p_MountedObject.AddVariant(s_Variant);
                    return p_MountedObject;
                });
            }

            // Mount all chunks.
            for (var i = 0; i < p_Bundle.Bundle.ChunkEntries.Length; i++)
            {
                var s_Chunk = p_Bundle.Bundle.ChunkEntries[i];
                DbObject? s_Meta = null;

                // If we have any meta, set it.
                if (p_Bundle.Bundle.ChunkMeta.Length > i)
                    s_Meta = DbObjectConverter.ToDbObject(p_Bundle.Bundle.ChunkMeta[i]);

                // Create variant.
                var s_Readable = new CatalogReadable(m_Catalog!, s_Chunk.Hash);
                var s_Variant = new ChunkVariant(s_Readable, s_Meta, p_Bundle.ContainedSuperbundle.Name,
                    p_Bundle.Bundle.Path);

                // Mount.
                var s_MountedObject = new MountedObject<IChunkVariant>(s_Variant);

                m_MountedChunks.AddOrUpdate(s_Chunk.Id, s_MountedObject, (p_GUID, p_MountedObject) =>
                {
                    // If this was already mounted, just add the variant.
                    p_MountedObject.AddVariant(s_Variant);
                    return p_MountedObject;
                });
            }

            // Mount all partitions.
            foreach (var s_Partition in p_Bundle.Bundle.EbxEntries)
            {
                // Create variant.
                var s_Readable = new CatalogReadable(m_Catalog!, s_Partition.Hash);
                var s_Variant = new ObjectVariant(s_Readable, p_Bundle.ContainedSuperbundle.Name, p_Bundle.Bundle.Path);

                // Mount.
                var s_MountedObject = new MountedObject(s_Variant);

                m_MountedPartitions.AddOrUpdate(s_Partition.Name.ToLowerInvariant(), s_MountedObject, (p_GUID, p_MountedObject) =>
                {
                    // If this was already mounted, just add the variant.
                    p_MountedObject.AddVariant(s_Variant);
                    return p_MountedObject;
                });
            }

            return true;
        }

        protected bool MountEmbeddedBundle(BundleManifest p_Bundle)
        {
            // Mount all resources.
            foreach (var s_Resource in p_Bundle.Resources)
            {
                // Create variant.
                var s_Variant = new ResourceVariant(s_Resource, (ResourceType) s_Resource.ResourceType, s_Resource.ResourceMeta,
                    p_Bundle.ContainedSuperbundle.Name, p_Bundle.ContainedBundle.Id);

                // Mount.
                var s_MountedObject = new MountedObject<IResourceVariant>(s_Variant);

                m_MountedResources.AddOrUpdate(s_Resource.Name.ToLowerInvariant(), s_MountedObject, (p_GUID, p_MountedObject) =>
                {
                    // If this was already mounted, just add the variant.
                    p_MountedObject.AddVariant(s_Variant);
                    return p_MountedObject;
                });
            }

            // Mount all chunks.
            foreach (var s_Chunk in p_Bundle.Chunks)
            {
                // Create variant.
                var s_Variant = new ChunkVariant(s_Chunk, DbObjectConverter.ToDbObject(s_Chunk.Meta),
                    p_Bundle.ContainedSuperbundle.Name, p_Bundle.ContainedBundle.Id);

                // Mount.
                var s_MountedObject = new MountedObject<IChunkVariant>(s_Variant);

                m_MountedChunks.AddOrUpdate(s_Chunk.Id, s_MountedObject, (p_GUID, p_MountedObject) =>
                {
                    // If this was already mounted, just add the variant.
                    p_MountedObject.AddVariant(s_Variant);
                    return p_MountedObject;
                });
            }

            // Mount all partitions.
            foreach (var s_Partition in p_Bundle.Ebx)
            {
                // Create variant.
                var s_Variant = new ObjectVariant(s_Partition, p_Bundle.ContainedSuperbundle.Name, p_Bundle.ContainedBundle.Id);

                // Mount.
                var s_MountedObject = new MountedObject(s_Variant);

                m_MountedPartitions.AddOrUpdate(s_Partition.Name.ToLowerInvariant(), s_MountedObject, (p_GUID, p_MountedObject) =>
                {
                    // If this was already mounted, just add the variant.
                    p_MountedObject.AddVariant(s_Variant);
                    return p_MountedObject;
                });
            }

            return true;
        }
    }
}
