using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.Content.Frostbite2_0.Frostbite.Bundles;
using RimeLib.Content.Frostbite2_0.Frostbite.Cas;
using RimeLib.Content.Frostbite2_0.Frostbite.Chunks;
using RimeLib.Content.Frostbite2_0.Frostbite.Sb;
using RimeLib.Content.Frostbite2_0.IO;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.Frostbite.Db;
using RimeLib.IO;
using RimeLib.IO.Conversion;
using RimeLib.Serialization.Frostbite2_0.Ebx;
using PackageManifest = RimeLib.Content.Frostbite2_0.Frostbite.PackageManifest;

namespace RimeLib.Content.Frostbite2_0.Mounting
{
    public class EngineMounter : IEngineMounter
    {
        protected string m_GamePath = "";
        
        protected PackageManifest? m_AuthoritativePackage;
        protected List<PackageManifest> m_Packages = new List<PackageManifest>();
        
        protected List<SuperbundleEntry> m_Superbundles = new List<SuperbundleEntry>();
        protected Catalog? m_Catalog;

        protected ConcurrentDictionary<GUID, ChunkEntry> m_Chunks = new();
        protected ConcurrentDictionary<string, BundleManifest> m_Bundles = new();
        protected ConcurrentDictionary<string, CasBundleEntry> m_CasBundles = new();

        private readonly ConcurrentDictionary<string, MountedObject<IResourceVariant>> m_MountedResources = new();
        private readonly ConcurrentDictionary<uint, string> m_MountedResourceLowerNameHashes = new();
        
        private readonly ConcurrentDictionary<string, MountedObject> m_MountedPartitions = new();
        private readonly ConcurrentDictionary<uint, string> m_MountedPartitionsLowerNameHashes = new();
        private readonly ConcurrentDictionary<GUID, string> m_MountedPartitionsGuids = new();

        private readonly ConcurrentDictionary<GUID, MountedObject<IChunkVariant>> m_MountedChunks = new();

        private readonly HashSet<string> m_MountedSuperbundles = new HashSet<string>();
        private readonly HashSet<string> m_MountedBundles = new HashSet<string>();

        public async Task Mount(string p_GamePath, bool p_AutoMount, EngineType p_Type)
        {
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

        public string GetGamePath()
        {
            return m_GamePath;
        }

        public EngineType GetEngineType()
        {
            return EngineType.Frostbite2_0;
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

            lock (m_MountedSuperbundles)
                m_MountedSuperbundles.Add(p_Superbundle.ToLowerInvariant());
        }

        public IEnumerable<string> GetMountedSuperbundles()
        {
            return m_MountedSuperbundles;
        }

        // Level-sb override support: enumerate a superbundle's TOC as parsed (Patch layered first).
        // Bundle ids + toc-level chunk refs are what a COMPLETE clone of a level sb must reproduce —
        // a clone missing either hangs the server (terrain streaming chunks live at toc level).
        // TODO: Clean this up, it seems duplicated
        public IEnumerable<string> GetSuperbundleBundleIds(string p_Superbundle)
        {
            var s_Sb = m_Superbundles.FirstOrDefault(p_S =>
                p_S.Name.Equals(p_Superbundle, StringComparison.OrdinalIgnoreCase));
            if (s_Sb == null)
                yield break;
            var s_Seen = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            foreach (var s_Toc in new[] { s_Sb.PatchToc, s_Sb.Toc })
            {
                if (s_Toc?.Layout?.Bundles == null)
                    continue;
                foreach (var s_B in s_Toc.Layout.Bundles)
                    if (!string.IsNullOrEmpty(s_B.Id) && s_Seen.Add(s_B.Id))
                        yield return s_B.Id;
            }
        }

        // TODO: Clean this up, it seems duplicated
        public IEnumerable<(GUID Id, Sha1? Sha1)> GetSuperbundleTocChunks(string p_Superbundle)
        {
            var s_Sb = m_Superbundles.FirstOrDefault(p_S =>
                p_S.Name.Equals(p_Superbundle, StringComparison.OrdinalIgnoreCase));
            if (s_Sb == null)
                yield break;
            var s_Seen = new HashSet<GUID>();
            foreach (var s_Toc in new[] { s_Sb.PatchToc, s_Sb.Toc })
            {
                if (s_Toc?.Layout?.Chunks == null)
                    continue;
                foreach (var s_C in s_Toc.Layout.Chunks)
                    if (s_Seen.Add(s_C.Id))
                        yield return (s_C.Id, s_C.Sha1);
            }
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

                lock (m_MountedBundles)
                    m_MountedBundles.Add(p_Bundle.ToLowerInvariant());

                return;
            }

            if (m_Bundles.TryGetValue(p_Bundle.ToLowerInvariant(), out var s_EmbeddedBundle))
            {
                MountEmbeddedBundle(s_EmbeddedBundle);

                lock (m_MountedBundles)
                    m_MountedBundles.Add(p_Bundle.ToLowerInvariant());

                return;
            }

            throw new ArgumentException($"Could not find a bundle to mount with the provided name '{p_Bundle}'.", nameof(p_Bundle));
        }

        public IEnumerable<string> GetMountedBundles()
        {
            return m_MountedBundles;
        }

        public IEnumerable<(string Name, ResourceType ResourceType)> GetResourcesInBundle(string p_Bundle)
        {
            if (m_CasBundles.TryGetValue(p_Bundle.ToLowerInvariant(), out var s_CasBundle))
            {
                foreach (var s_Resource in s_CasBundle.Bundle.ResourceEntries)
                    yield return (s_Resource.Name, (ResourceType)s_Resource.ResourceType);
            }
            else if (m_Bundles.TryGetValue(p_Bundle.ToLowerInvariant(), out var s_Bundle))
            {
                foreach (var s_Resource in s_Bundle.Resources)
                    yield return (s_Resource.Name, (ResourceType)s_Resource.ResourceType);
            }
        }

        public IEnumerable<GUID> GetChunksInSuperbundle(string p_Superbundle)
        {
            foreach (var s_Superbundle in m_Superbundles)
            {
                if (s_Superbundle.Name == p_Superbundle.ToLowerInvariant())
                {
                    if (s_Superbundle.PatchToc != null)
                    {
                        foreach (var s_ChunkInfo in s_Superbundle.PatchToc.Layout.Chunks)
                            yield return s_ChunkInfo.Id;
                    }
                    if (s_Superbundle.Toc != null)
                    {
                        foreach (var s_ChunkInfo in s_Superbundle.Toc.Layout.Chunks)
                            yield return s_ChunkInfo.Id;
                    }
                }
            }
        }

        public IEnumerable<GUID> GetChunksInBundle(string p_Bundle)
        {
            if (m_CasBundles.TryGetValue(p_Bundle.ToLowerInvariant(), out var s_CasBundle))
            {
                if (s_CasBundle.Bundle.ChunkEntries is not null)
                {
                    foreach (var s_Chunk in s_CasBundle.Bundle.ChunkEntries)
                        yield return s_Chunk.Id;
                }
            }
            else if (m_Bundles.TryGetValue(p_Bundle.ToLowerInvariant(), out var s_Bundle))
            {
                foreach (var s_Chunk in s_Bundle.Chunks)
                    yield return s_Chunk.Id;
            }
        }

        public IEnumerable<(GUID Guid, int AssetNameHash)> GetChunksWithHashInBundle(string p_Bundle)
        {
            if (m_CasBundles.TryGetValue(p_Bundle.ToLowerInvariant(), out var s_CasBundle))
            {
                if (s_CasBundle.Bundle.ChunkEntries is not null)
                {
                    if (s_CasBundle.Bundle.ChunkMeta is not null)
                    {
                        for (int i = 0; i < s_CasBundle.Bundle.ChunkEntries.Length; i++)
                            yield return (s_CasBundle.Bundle.ChunkEntries[i].Id, s_CasBundle.Bundle.ChunkMeta[i].AssetNameHash);
                    }
                }
            }
            else if (m_Bundles.TryGetValue(p_Bundle.ToLowerInvariant(), out var s_Bundle))
            {
                foreach (var s_Chunk in s_Bundle.Chunks)
                { 
                    if (s_Chunk.Meta != null)
                        yield return (s_Chunk.Id, s_Chunk.Meta.AssetNameHash);
                }
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

        public bool TryGetResource(string p_Path, [NotNullWhen(true)] out IMountedObject<IResourceVariant>? p_Resource)
        {
            if (m_MountedResources.TryGetValue(p_Path.ToLowerInvariant(), out var s_Resource))
            {
                p_Resource = s_Resource;
                return true;
            }
            
            p_Resource = null;
            return false;
        }
        
        public bool TryGetResource(ResourceRef p_Ref, [NotNullWhen(true)] out IMountedObject<IResourceVariant>? p_Resource)
        {
            throw new NotImplementedException("ResourceRef not supported on fb2");
        }


        public bool TryGetResourceByHashLower(uint p_Hash, [NotNullWhen(true)] out IMountedObject<IResourceVariant>? p_Resource)
        {
            if (m_MountedResourceLowerNameHashes.TryGetValue(p_Hash, out var s_Name))
                return TryGetResource(s_Name, out p_Resource);

            p_Resource = null;
            return false;
        }

        public bool TryGetChunk(GUID p_GUID, [NotNullWhen(true)] out IMountedObject<IChunkVariant>? p_Chunk)
        {
            if (m_MountedChunks.TryGetValue(p_GUID, out var s_Chunk))
            {
                p_Chunk = s_Chunk;
                return true;
            }
            
            p_Chunk = null;
            return false;
        }

        public bool TryGetPartition(string p_Path, [NotNullWhen(true)] out IMountedObject? p_Partition)
        {
            if (m_MountedPartitions.TryGetValue(p_Path.ToLowerInvariant(), out var s_Partition))
            {
                p_Partition = s_Partition;
                return true;
            }
            
            p_Partition = null;
            return false;
        }

        public bool TryGetPartitionByHashLower(uint p_Hash, [NotNullWhen(true)] out IMountedObject? p_Partition)
        {
            if (m_MountedPartitionsLowerNameHashes.TryGetValue(p_Hash, out var s_Name))
                return TryGetPartition(s_Name, out p_Partition);

            p_Partition = null;
            return false;
        }

        public bool TryGetPartitionByGuid(GUID p_GUID, [NotNullWhen(true)] out string? p_Name, [NotNullWhen(true)] out IMountedObject? p_Partition)
        {
            if (m_MountedPartitionsGuids.TryGetValue(p_GUID, out p_Name))
                return TryGetPartition(p_Name, out p_Partition);

            p_Partition = null;
            return false;
        }

        public IReadOnlyDictionary<string, IMountedObject<IResourceVariant>> GetResources()
        {
            return m_MountedResources.ToDictionary(p_Pair => p_Pair.Key, p_Pair => p_Pair.Value as IMountedObject<IResourceVariant>);
        }

        public IReadOnlyDictionary<GUID, IMountedObject<IChunkVariant>> GetChunks()
        {
            return m_MountedChunks.ToDictionary(p_Pair => p_Pair.Key, p_Pair => p_Pair.Value as IMountedObject<IChunkVariant>);
        }

        public IReadOnlyDictionary<string, IMountedObject> GetPartitions()
        {
            return m_MountedPartitions.ToDictionary(p_Pair => p_Pair.Key, p_Pair => p_Pair.Value as IMountedObject);
        }
        
        public IReadOnlyDictionary<string, IMountedObject>  GetDbxPartitions()
        {
            return new Dictionary<string, IMountedObject>();
        }


        public IEnumerable<string> GetBundlesInSuperbundle(string p_Superbundle)
        {
            // Check if we have this superbundle.
            var s_Superbundle = m_Superbundles.FirstOrDefault(p_Sb =>
                p_Sb.Name.Equals(p_Superbundle, StringComparison.InvariantCultureIgnoreCase));

            if (s_Superbundle == null)
                throw new ArgumentException($"Could not find a superbundle with the provided name '{p_Superbundle}'.", nameof(p_Superbundle));

            var s_Bundles = new HashSet<string>();

            foreach (var s_Bundle in s_Superbundle.Toc.Layout.Bundles)
                s_Bundles.Add(s_Bundle.Id.ToLowerInvariant());

            if (s_Superbundle.PatchToc != null)
            {
                foreach (var s_Bundle in s_Superbundle.PatchToc.Layout.Bundles)
                    s_Bundles.Add(s_Bundle.Id.ToLowerInvariant());
            }

            return s_Bundles;
        }

        public async Task MountStandaloneSuperbundle(string p_Name, string p_Path, bool p_AutoMount)
        {
            if (string.IsNullOrWhiteSpace(p_Name))
                throw new ArgumentException("Superbundle name cannot be empty.", nameof(p_Name));

            if (!p_Path.EndsWith(".sb"))
                throw new ArgumentException("Superbundle file must have a '.sb' extension.", nameof(p_Path));

            if (!File.Exists(p_Path))
                throw new ArgumentException("The specified superbundle file does not exist.", nameof(p_Path));

            var s_TocPath = p_Path.Replace(".sb", ".toc");

            if (!File.Exists(s_TocPath))
                throw new Exception("Could not find corresponding toc file for superbundle.");

            TableOfContents<SuperbundleLayout> s_Toc;

            // Parse the superbundle layout.
            using (var s_Reader = new RimeReader(File.Open(s_TocPath, FileMode.Open, FileAccess.Read, FileShare.Read)))
                s_Toc = new TableOfContents<SuperbundleLayout>(s_Reader);

            // Create a superbundle entry for this superbundle.
            var s_SbEntry = new SuperbundleEntry(p_Name.ToLowerInvariant(), p_Path.Replace(".sb", ""), s_Toc);

            // Add to the list of discovered superbundles.
            m_Superbundles.Add(s_SbEntry);

            await MountSuperbundle(p_Name, p_AutoMount);
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

        /// <summary>
        /// Whether the game's cas catalog(s) contain a payload with this hash — i.e. whether a
        /// bundle entry could be delivered as a pure SHA1 reference (InlineData = null) instead
        /// of embedding its bytes. Checks the authoritative (patch) catalog first, then the base.
        /// </summary>
        // Build-time-only external membership probe (set by mount_external_cat). NOT in the read
        // chain: casref-ify only asks CatalogContainsEntry to decide ref-vs-embed; it never reads
        // the external cat's bytes at build (it emits refs). At runtime the engine reads them from
        // the staged package. Kept out of m_Catalog.AuthoritativeCatalog so the base->patch READ
        // chain (used by resolve_partition_dependencies to parse partitions) stays intact.
        private Catalog? m_ExternalProbeCatalog;

        public bool CatalogContainsEntry(RimeLib.Frostbite.Core.Sha1 p_Hash)
        {
            if (m_ExternalProbeCatalog != null && m_ExternalProbeCatalog.ContainsEntry(p_Hash))
                return true;
            if (m_Catalog == null)
                return false;
            if (m_Catalog.AuthoritativeCatalog != null && m_Catalog.AuthoritativeCatalog.ContainsEntry(p_Hash))
                return true;
            return m_Catalog.ContainsEntry(p_Hash);
        }

        /// <summary>
        /// DICE-parity resource variant: prefers the variant whose payload is INLINE (idata).
        /// Retail texture headers ship as idata in EVERY cas bundle (74k+ DxTexture idata variants);
        /// re-emitting FirstVariant when it is catalog/noncas-backed writes a bare SHA1 ref that may
        /// not be catalog-backed at all (headers never get cataloged) — the engine then has no
        /// payload for the header (the invisible/black/E_INVALIDARG family).
        /// </summary>
        public bool TryGetInlineResourceVariant(string p_Name, [NotNullWhen(true)] out IResourceVariant? p_Variant)
        {
            p_Variant = null;
            if (!TryGetResource(p_Name, out var s_Res))
                return false;
            foreach (var s_V in s_Res.Variants)
            {
                if (s_V is ResourceVariant s_RV && s_RV.GetReadable() is InlineReadable)
                {
                    p_Variant = s_V;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// DICE-parity texture chunk variant: the pixel chunk EXACTLY as a retail bundle carries it
        /// (possibly TAIL-RANGED with logicalOffset + chunkMeta { h32, firstMip } — the retail mip
        /// streaming formula: small mips persistent in-bundle, top mips streamed from the catalog).
        /// Matched by h32 == fb::hashQuick(resource name), the association retail bundles use.
        /// </summary>
        public bool TryGetTextureChunkRetailVariant(RimeLib.Frostbite.Core.GUID p_Id, string p_ResName, [NotNullWhen(true)] out IChunkVariant? p_Variant)
        {
            p_Variant = null;
            if (!TryGetChunk(p_Id, out var s_Obj))
                return false;
            var s_Hash = (int)RimeLib.Frostbite.Utils.HashQuick(p_ResName);
            foreach (var s_V in s_Obj.Variants)
            {
                if (s_V.GetAssetNameHash() == s_Hash)
                {
                    p_Variant = s_V;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Builds a FULL-RANGE, catalog-backed variant of a mounted cas chunk (rangeStart 0).
        /// Used to deliver a streaming texture's COMPLETE payload as a pure SHA1 reference: the game's
        /// bundle entries for streaming textures are RANGED slices; copying them into a standalone mod
        /// bundle ships partial data (CreateTexture2D E_INVALIDARG / black). The catalog holds the whole
        /// payload, so a 0..size entry with the same hash delivers every mip, byte-exact, for free.
        /// When <paramref name="p_AssetName"/> is given, the variant carries a DICE-style chunkMeta
        /// { h32: fnv(assetName), meta: {} } — without the h32 the manifest writes an EMPTY chunkMeta
        /// entry and the engine cannot associate the chunk with its texture resource at bundle load.
        /// </summary>
        public bool TryGetFullRangeCasChunkVariant(RimeLib.Frostbite.Core.GUID p_Id, [NotNullWhen(true)] out IChunkVariant? p_Variant, string? p_AssetName = null)
        {
            p_Variant = null;
            if (!TryGetChunk(p_Id, out var s_Obj))
                return false;
            foreach (var s_V in s_Obj.Variants)
            {
                if (s_V is not ChunkVariant s_CV)
                    continue;
                if (s_CV.GetReadable() is not CatalogReadable s_Cat)
                    continue;
                DbObject? s_Meta = null;
                if (!string.IsNullOrEmpty(p_AssetName))
                {
                    s_Meta = new DbObject();
                    s_Meta.AddElement(new DbObjectElement("h32", (int)RimeLib.Frostbite.Utils.HashQuick(p_AssetName)));
                    s_Meta.AddElement(new DbObjectElement("meta", new DbObject(), false));
                }
                p_Variant = new ChunkVariant(s_Cat, 0, (uint)s_Cat.GetCompressedSize(), 0, s_Meta,
                    s_CV.GetContainedSuperbundle(), s_CV.GetContainedBundle());
                return true;
            }
            return false;
        }

        /// <summary>
        /// Builds a catalog-backed chunk variant DIRECTLY from an {id, sha1} pair copied from another
        /// bundle's MANIFEST — no mounted-chunk index lookup. The mounter's chunk index only covers
        /// TOC-LISTED chunks, so bundle-manifest chunks (level sound/ambient/gamemode stream payloads)
        /// are invisible to add_existing_chunk ("Could not find chunk"); this delivers them as pure
        /// cas refs anyway (the add_cas_chunk command — the exact-manifest bundle-clone missing piece).
        /// </summary>
        public bool TryMakeCasChunkVariant(RimeLib.Frostbite.Core.GUID p_Id, string p_Sha1Hex,
            [NotNullWhen(true)] out IChunkVariant? p_Variant, int? p_H32 = null, int? p_FirstMip = null,
            uint? p_RangeStart = null, uint? p_RangeEnd = null, uint? p_LogicalOffset = null)
        {
            p_Variant = null;
            if (m_Catalog == null)
                return false;
            Sha1 s_Hash;
            try { s_Hash = new Sha1(p_Sha1Hex); }
            catch { return false; }
            var s_Contained = (m_Catalog.AuthoritativeCatalog != null && m_Catalog.AuthoritativeCatalog.ContainsEntry(s_Hash))
                              || m_Catalog.ContainsEntry(s_Hash);
            if (!s_Contained)
                return false;
            var s_Entry = new CasChunkEntry(p_Id, s_Hash, m_Catalog);
            DbObject? s_Meta = null;
            if (p_H32.HasValue)
            {
                s_Meta = new DbObject();
                s_Meta.AddElement(new DbObjectElement("h32", p_H32.Value));
                var s_M = new DbObject();
                if (p_FirstMip.HasValue)
                    s_M.AddElement(new DbObjectElement("firstMip", p_FirstMip.Value));
                s_Meta.AddElement(new DbObjectElement("meta", s_M, false));
            }
            // RANGED pass-through: a DICE manifest entry that is a SLICE (streaming texture persistent
            // mips etc.) must stay a slice — full-ranging it breaks header↔chunk coherence and the
            // texture CREATE at bundle load dies with CreateTexture2D E_INVALIDARG (proven in-game).
            var s_Start = p_RangeStart ?? 0;
            var s_End = p_RangeEnd ?? (uint)s_Entry.GetSize();
            var s_LogOff = p_LogicalOffset ?? 0;
            p_Variant = new ChunkVariant(s_Entry, s_Start, s_End, s_LogOff, s_Meta, "manifest", null);
            return true;
        }

        /// <summary>
        /// CENSUS: does retail BF3 EVER deliver RESOURCE payloads as cas-bundle InlineData (idata)?
        /// Generated (file-backed) resources in our mod bundles ship as idata and render BLACK on the
        /// MVDB path — if retail never uses resource-idata, the engine likely fetches resource payloads
        /// by SHA1 from cas.cat only, and mods must deliver generated textures another way (noncas annex).
        /// </summary>
        public string ResourceIdataCensus(int p_MaxSamples = 25)
        {
            int s_TotalVariants = 0, s_Idata = 0, s_IdataTex = 0, s_Catalog = 0, s_NonCas = 0, s_IdataRaw = 0, s_IdataCompressed = 0;
            var s_Samples = new System.Collections.Generic.List<string>();
            foreach (var s_Kv in m_MountedResources)
            {
                foreach (var s_V in s_Kv.Value.Variants)
                {
                    s_TotalVariants++;
                    if (s_V is not ResourceVariant s_RV)
                        continue;
                    var s_R = s_RV.GetReadable();
                    if (s_R is InlineReadable s_IR)
                    {
                        s_Idata++;
                        if (s_IR.Compressed) s_IdataCompressed++; else s_IdataRaw++;
                        if (s_RV.GetResourceType() == RimeLib.Content.Frostbite.ResourceType.DxTexture)
                            s_IdataTex++;
                        if (s_Samples.Count < p_MaxSamples)
                            s_Samples.Add($"{s_Kv.Key} [{s_RV.GetResourceType()}] bundle={s_RV.GetContainedBundle() ?? "-"} sb={s_RV.GetContainedSuperbundle()}");
                    }
                    else if (s_R is CatalogReadable) s_Catalog++;
                    else s_NonCas++;
                }
            }
            var s_Sb = new System.Text.StringBuilder();
            s_Sb.AppendLine($"resource variants total={s_TotalVariants}  CAS-IDATA={s_Idata} (DxTexture={s_IdataTex}, RAW={s_IdataRaw}, COMPRESSED={s_IdataCompressed})  catalog-ref={s_Catalog}  noncas-bundle={s_NonCas}");
            foreach (var s_S in s_Samples) s_Sb.AppendLine("  IDATA-RES " + s_S);
            return s_Sb.ToString();
        }

        /// <summary>Full manifest-field dump of every variant of a resource (black-hunt: diff a
        /// RETAIL idata texture entry vs OUR generated one — the differing field is the bug).</summary>
        public string DumpResourceEntry(string p_Name)
        {
            var s_Sb = new System.Text.StringBuilder();
            if (!TryGetResource(p_Name, out var s_Res))
                return $"resource not found: {p_Name}";
            int s_I = 0;
            foreach (var s_V in s_Res.Variants)
            {
                if (s_V is not ResourceVariant s_RV) continue;
                var s_R = s_RV.GetReadable();
                long s_CompSize = -1, s_OrigSize = -1;
                string s_Kind = s_R.GetType().Name, s_Hash = "?", s_Idata = "-";
                try { s_OrigSize = s_R.GetSize(); } catch { }
                byte[]? s_Meta = null; s_RV.TryGetMeta(out s_Meta);
                if (s_R is InlineReadable s_IR)
                {
                    s_CompSize = s_IR.GetCompressedSize();
                    s_Hash = s_IR.GetCompressedHash()?.ToString() ?? "?";
                    var s_D = s_IR.GetCompressedData();
                    s_Idata = $"len={s_D.Length} head={System.BitConverter.ToString(s_D, 0, System.Math.Min(24, s_D.Length))}";
                }
                else if (s_R is CatalogReadable s_CR)
                {
                    s_CompSize = s_CR.GetCompressedSize();
                    s_Hash = s_CR.GetCompressedHash()?.ToString() ?? "?";
                }
                s_Sb.AppendLine($"v[{s_I++}] kind={s_Kind} type={s_RV.GetResourceType()} size={s_CompSize} origSize={s_OrigSize} hash={s_Hash}");
                s_Sb.AppendLine($"      meta={(s_Meta == null ? "null" : System.BitConverter.ToString(s_Meta))} idata: {s_Idata}");
                s_Sb.AppendLine($"      sb={s_RV.GetContainedSuperbundle()} bundle={s_RV.GetContainedBundle() ?? "-"}");
            }
            return s_Sb.ToString();
        }

        /// <summary>
        /// CAS-REF RE: writes one TSV row per mounted variant whose containing superbundle name
        /// starts with p_SbPrefix (case-insensitive), with the SHA1 of the variant's STORED payload
        /// bytes — the exact bytes a cas-ification would content-address (the original zlib-block
        /// frame for compressed payloads, the raw window otherwise; same accessors the bundle
        /// writers use, so identity matches what a user-side DLC catalog would contain).
        /// Columns: kind, name, sb, bundle, storedSize, sha1, manifestSha1, inGameCatalog.
        /// Catalog-backed variants emit sha1 "-" (they already ship as ~0-byte refs).
        /// </summary>
        public string HashMountedPayloads(string p_SbPrefix, string p_OutTsvPath, bool p_Logical = false)
        {
            long s_Rows = 0, s_Bytes = 0, s_CasRefs = 0, s_Errors = 0;
            var s_Watch = System.Diagnostics.Stopwatch.StartNew();
            using var s_Out = new StreamWriter(p_OutTsvPath, false, System.Text.Encoding.UTF8, 1 << 20);
            s_Out.WriteLine("kind\tname\tsb\tbundle\tstored\tsha1\tmsha1\tincat");

            void Walk(string p_Kind, string p_Name, IObjectVariant p_Variant)
            {
                var s_SbName = p_Variant.GetContainedSuperbundle();
                if (!s_SbName.StartsWith(p_SbPrefix, StringComparison.OrdinalIgnoreCase))
                    return;

                var s_Bundle = p_Variant.GetContainedBundle() ?? "-";
                try
                {
                    if (p_Logical)
                    {
                        // LOGICAL mode: hash the DECOMPRESSED bytes exactly as a consumer sees
                        // them — for EVERY variant, including catalog refs (the read goes through
                        // Catalog.ReadEntry + the zlib path). Lets two deliveries of the same
                        // content (inline vs cas-ref) be diffed for engine-visible identity.
                        using var s_LogicalReader = p_Variant.GetReader();
                        var s_LogicalLength = (int)(s_LogicalReader.Length - s_LogicalReader.Position);
                        var s_LogicalBytes = s_LogicalLength > 0 ? s_LogicalReader.ReadBytes(s_LogicalLength) : Array.Empty<byte>();
                        var s_LogicalHash = RimeLib.Frostbite.Core.Sha1.FromData(s_LogicalBytes);
                        s_Rows++;
                        s_Bytes += s_LogicalBytes.Length;
                        s_Out.WriteLine($"{p_Kind}\t{p_Name}\t{s_SbName}\t{s_Bundle}\t{s_LogicalBytes.Length}\t{s_LogicalHash}\t-\t{(p_Variant.Cas ? 1 : 0)}");
                        return;
                    }
                    object s_Readable = p_Variant is ObjectVariant s_OV ? s_OV.GetReadable() : p_Variant;
                    if (s_Readable is CatalogReadable || s_Readable is CasChunkEntry)
                    {
                        s_CasRefs++;
                        s_Rows++;
                        s_Out.WriteLine($"{p_Kind}\t{p_Name}\t{s_SbName}\t{s_Bundle}\t0\t-\t{p_Variant.GetSha1()?.ToString() ?? "-"}\t1");
                        return;
                    }

                    var s_Stored = GetReadableStoredBytes(s_Readable);

                    var s_Hash = RimeLib.Frostbite.Core.Sha1.FromData(s_Stored);
                    var s_InCat = CatalogContainsEntry(s_Hash) ? 1 : 0;
                    Sha1? s_ManifestHash = null;
                    try { s_ManifestHash = p_Variant.GetSha1(); } catch { }
                    s_Rows++;
                    s_Bytes += s_Stored.Length;
                    s_Out.WriteLine($"{p_Kind}\t{p_Name}\t{s_SbName}\t{s_Bundle}\t{s_Stored.Length}\t{s_Hash}\t{s_ManifestHash?.ToString() ?? "-"}\t{s_InCat}");
                }
                catch (Exception s_Ex)
                {
                    s_Errors++;
                    s_Out.WriteLine($"{p_Kind}\t{p_Name}\t{s_SbName}\t{s_Bundle}\t-1\tERROR:{s_Ex.GetType().Name}\t-\t0");
                }
            }

            foreach (var s_Kv in m_MountedPartitions)
                foreach (var s_V in s_Kv.Value.Variants)
                    Walk("ebx", s_Kv.Key, s_V);

            foreach (var s_Kv in m_MountedResources)
                foreach (var s_V in s_Kv.Value.Variants)
                    Walk("res", s_Kv.Key, s_V);

            foreach (var s_Kv in m_MountedChunks)
                foreach (var s_V in s_Kv.Value.Variants)
                    Walk("chunk", s_Kv.Key.ToString(), s_V);

            return $"hash_mounted_payloads: prefix={p_SbPrefix} rows={s_Rows} hashedMB={s_Bytes / 1024 / 1024} casrefRows={s_CasRefs} errors={s_Errors} elapsed={s_Watch.Elapsed.TotalSeconds:F0}s -> {p_OutTsvPath}";
        }

        /// <summary>
        /// STORED frame of a readable, exactly as a cas-ification would content-address it:
        /// verbatim idata, original zlib-block frame (GetRawBytes) or the raw window. Shared by
        /// HashMountedPayloads and TryHashVariantStoredFrame.
        /// </summary>
        private static byte[] GetReadableStoredBytes(object p_Readable)
        {
            if (p_Readable is InlineReadable s_Inline)
                return s_Inline.GetCompressedData();

            using var s_Reader = ((IReadableObject)p_Readable).GetReader();
            if (s_Reader is ZlibRimeReader s_SelfZlib)
                return s_SelfZlib.GetRawBytes();
            if (s_Reader.BaseStream is ZlibRimeReader s_Zlib)
                return s_Zlib.GetRawBytes();

            var s_Len = (int)(s_Reader.Length - s_Reader.Position);
            return s_Len > 0 ? s_Reader.ReadBytes(s_Len) : Array.Empty<byte>();
        }

        /// <summary>
        /// Public stored-frame identity probe for a single mounted variant: computes the sha1 of
        /// the STORED bytes and whether that exact frame exists in the player's catalogs.
        /// Returns false for catalog-backed variants (they are already pure refs).
        /// </summary>
        public bool TryHashVariantStoredFrame(IObjectVariant p_Variant, out string p_Sha1Hex, out long p_Size, out bool p_InCat)
        {
            p_Sha1Hex = "";
            p_Size = 0;
            p_InCat = false;

            object s_Readable = p_Variant is ObjectVariant s_OV ? s_OV.GetReadable() : p_Variant;
            if (s_Readable is CatalogReadable || s_Readable is CasChunkEntry)
                return false;

            var s_Stored = GetReadableStoredBytes(s_Readable);
            var s_Hash = RimeLib.Frostbite.Core.Sha1.FromData(s_Stored);
            p_Sha1Hex = s_Hash.ToString();
            p_Size = s_Stored.Length;
            p_InCat = CatalogContainsEntry(s_Hash);
            return true;
        }

        /// <summary>
        /// TEXTURE/DLC-catalog RE: builds a cas.cat + cas_NN.cas from the STORED frames of the
        /// named mounted objects that are NOT already in the base/patch catalog. This is the
        /// "user-side DLC cas-ify" tool — the mod's cas-refs (sha1 of the stored frame) resolve
        /// against this generated catalog. Skips objects already cas-backed (pure refs) or
        /// already present in the base cat (DICE already ships them as cas). Resolves each name
        /// as a resource, then a partition, then (if it parses as a GUID) a chunk.
        /// </summary>
        public string BuildCasCatalog(System.Collections.Generic.IEnumerable<string> p_Names, string p_OutDir, uint p_StartIndex = 1, System.Collections.Generic.IEnumerable<GUID>? p_ChunkGuids = null)
        {
            var s_Writer = new RimeLib.Content.Frostbite2_0.Building.CasCatalogWriter(p_StartIndex);
            long s_Bytes = 0;
            int s_Names = 0, s_NotFound = 0, s_SkipBase = 0, s_SkipRef = 0, s_Errors = 0, s_Chunks = 0;

            void AddVariant(IObjectVariant p_Variant)
            {
                object s_Readable = p_Variant is ObjectVariant s_OV ? s_OV.GetReadable() : p_Variant;
                if (s_Readable is CatalogReadable || s_Readable is CasChunkEntry) { s_SkipRef++; return; }
                try
                {
                    var s_Stored = GetReadableStoredBytes(s_Readable);
                    var s_Hash = RimeLib.Frostbite.Core.Sha1.FromData(s_Stored);
                    if (CatalogContainsEntry(s_Hash)) { s_SkipBase++; return; }
                    if (!s_Writer.Entries.ContainsKey(s_Hash)) s_Bytes += s_Stored.Length;
                    s_Writer.Add(s_Stored);
                }
                catch { s_Errors++; }
            }

            foreach (var s_Name in p_Names)
            {
                s_Names++;
                var s_Lower = s_Name.ToLowerInvariant();
                if (TryGetResource(s_Lower, out var s_Res))
                    foreach (var s_V in s_Res!.Variants) AddVariant(s_V);
                else if (TryGetPartition(s_Lower, out var s_Part))
                    foreach (var s_V in s_Part!.Variants) AddVariant(s_V);
                else
                    s_NotFound++;
            }

            if (p_ChunkGuids != null)
                foreach (var s_Guid in p_ChunkGuids)
                    if (TryGetChunk(s_Guid, out var s_Chunk))
                    {
                        s_Chunks++;
                        foreach (var s_V in s_Chunk!.Variants) AddVariant(s_V);
                    }

            s_Writer.Write(p_OutDir);
            return $"build_cas_catalog: names={s_Names} chunks={s_Chunks} notFound={s_NotFound} blobs={s_Writer.Entries.Count} MB={s_Bytes / 1024 / 1024} skippedInBaseCat={s_SkipBase} alreadyRef={s_SkipRef} errors={s_Errors} -> {p_OutDir}";
        }

        /// <summary>
        /// Loads a generated cas.cat and reports how many of the named objects' stored-frame
        /// sha1s it now contains (the offline resolution oracle for build_cas_catalog). With
        /// p_SetAuthoritative it chains the catalog onto the mounted base as AuthoritativeCatalog
        /// and reads one entry back, proving a mod cas-ref would resolve at bundle mount.
        /// </summary>
        /// <summary>
        /// Chains an external cas.cat onto the mounted base as its AuthoritativeCatalog so that
        /// CatalogContainsEntry (and thus the casref-ify build path + destream_texture's
        /// TryGetFullRangeCasChunkVariant) sees the external catalog's sha1s as "in catalog".
        /// Used at BUILD time to deliver DLC content as cas-refs against a generated DLC catalog
        /// (the vmdlc catalog) instead of embedding/regenerating it.
        /// </summary>
        public string MountExternalCatalog(string p_CatPath)
        {
            var s_Cat = new Catalog(p_CatPath);
            // Membership-only: casref-ify emits a ref when CatalogContainsEntry is true; it never
            // reads these bytes at build time. Keeping it OUT of the base->patch read chain avoids
            // breaking partition parsing (which reads base/patch blobs during resolve).
            m_ExternalProbeCatalog = s_Cat;
            return $"mount_external_cat: probe catalog {p_CatPath} ({s_Cat.Entries.Count} entries) — casref-ify will emit refs to these sha1s.";
        }

        public string ProbeCatalog(string p_CatPath, System.Collections.Generic.IEnumerable<string> p_Names, bool p_SetAuthoritative = false)
        {
            var s_Cat = new Catalog(p_CatPath);
            if (p_SetAuthoritative && m_Catalog != null)
                m_Catalog.AuthoritativeCatalog = s_Cat;

            int s_Hit = 0, s_Miss = 0, s_NotFound = 0, s_ReadOk = 0, s_Pure = 0;
            var s_MissSamples = new System.Collections.Generic.List<string>();

            void ProbeVariant(string p_Name, IObjectVariant p_Variant)
            {
                if (!TryHashVariantStoredFrame(p_Variant, out var s_Hex, out _, out _)) { s_Pure++; return; }
                var s_Sha1 = new RimeLib.Frostbite.Core.Sha1(s_Hex);
                if (s_Cat.ContainsEntry(s_Sha1))
                {
                    s_Hit++;
                    try { using var s_R = s_Cat.ReadEntry(s_Sha1); s_ReadOk++; } catch { }
                }
                else
                {
                    s_Miss++;
                    if (s_MissSamples.Count < 8) s_MissSamples.Add($"{p_Name} {s_Hex}");
                }
            }

            foreach (var s_Name in p_Names)
            {
                var s_Lower = s_Name.ToLowerInvariant();
                if (TryGetResource(s_Lower, out var s_Res))
                    foreach (var s_V in s_Res!.Variants) ProbeVariant(s_Name, s_V);
                else if (TryGetPartition(s_Lower, out var s_Part))
                    foreach (var s_V in s_Part!.Variants) ProbeVariant(s_Name, s_V);
                else
                    s_NotFound++;
            }

            var s_Sb = new System.Text.StringBuilder();
            s_Sb.AppendLine($"probe_catalog: {p_CatPath} authoritative={p_SetAuthoritative} HIT={s_Hit} (readable={s_ReadOk}) MISS={s_Miss} notFound={s_NotFound} pureRef={s_Pure}");
            foreach (var s_S in s_MissSamples) s_Sb.AppendLine($"  MISS {s_S}");
            return s_Sb.ToString();
        }

        /// <summary>
        /// Assumption probe for the user-side DLC catalog RE: is a RETAIL cas.cat key equal to
        /// SHA1(stored blob bytes)? Samples entries from the base and patch catalogs, reads each
        /// blob straight from its own cas_NN.cas (bypassing patch-first chaining) and re-hashes.
        /// A match means CasCatalogWriter's Add() convention (hash of the stored bytes) is the
        /// same convention DICE's own catalogs follow.
        /// </summary>
        public string VerifyCatalogHashes(int p_MaxSamples = 300)
        {
            if (m_Catalog == null)
                return "verify_catalog_hashes: no catalog mounted.";

            var s_Report = new System.Text.StringBuilder();

            void Probe(Catalog p_Cat, string p_Label)
            {
                var s_Entries = p_Cat.Entries.Values.ToArray();
                var s_Step = System.Math.Max(1, s_Entries.Length / System.Math.Max(1, p_MaxSamples));
                int s_Ok = 0, s_Bad = 0, s_Err = 0;
                var s_BadSamples = new List<string>();
                var s_Dir = Path.GetDirectoryName(p_Cat.Path);

                for (var s_I = 0; s_I < s_Entries.Length && (s_Ok + s_Bad) < p_MaxSamples; s_I += s_Step)
                {
                    var s_Entry = s_Entries[s_I];
                    try
                    {
                        var s_CasPath = Path.Join(s_Dir, $"cas_{s_Entry.FileNumber:D2}.cas");
                        using var s_File = File.Open(s_CasPath, FileMode.Open, FileAccess.Read, FileShare.Read);
                        s_File.Seek(s_Entry.FileOffset, SeekOrigin.Begin);
                        var s_Buffer = new byte[s_Entry.FileSize];
                        s_File.ReadExactly(s_Buffer);
                        var s_Hash = RimeLib.Frostbite.Core.Sha1.FromData(s_Buffer);
                        if (s_Hash.Equals(s_Entry.Hash))
                            s_Ok++;
                        else
                        {
                            s_Bad++;
                            if (s_BadSamples.Count < 8)
                                s_BadSamples.Add($"{s_Entry.Hash} != {s_Hash} size={s_Entry.FileSize} cas={s_Entry.FileNumber}@{s_Entry.FileOffset}");
                        }
                    }
                    catch (Exception)
                    {
                        s_Err++;
                    }
                }

                s_Report.AppendLine($"{p_Label}: entries={s_Entries.Length} sampled={s_Ok + s_Bad} MATCH={s_Ok} MISMATCH={s_Bad} errors={s_Err}");
                foreach (var s_Sample in s_BadSamples)
                    s_Report.AppendLine($"  BAD {s_Sample}");
            }

            Probe(m_Catalog, "base " + m_Catalog.Path);
            if (m_Catalog.AuthoritativeCatalog != null)
                Probe(m_Catalog.AuthoritativeCatalog, "patch " + m_Catalog.AuthoritativeCatalog.Path);

            return s_Report.ToString();
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
            var s_Variant = new ChunkVariant(s_ChunkEntry, 0, (uint)s_ChunkEntry.GetSize(), 0, null, p_SbEntry.Name, null);
            var s_MountedObject = new MountedObject<IChunkVariant>(s_Variant, s_ChunkEntry.Id.ToString());

            m_MountedChunks.AddOrUpdate(s_ChunkEntry.Id, s_MountedObject, (p_GUID, p_MountedObject) =>
            {
                p_MountedObject.AddOrUpdateVariant(v => v.GetContainedSuperbundle() == p_SbEntry.Name && v.GetContainedBundle() == null, s_Variant);
                return p_MountedObject;
            });
        }

        protected void ParseSuperbundles()
        {
            Parallel.ForEach(m_Superbundles, p_Superbundle => ParseSuperbundle(p_Superbundle, true));
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
            // TODO: Use a limited reader.
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
        
        protected void ParseBundle(RimeReader p_Reader, BundleInfo p_BundleInfo, SuperbundleEntry p_Superbundle, bool p_InUpdate, bool p_AutoMount)
        {
            // TODO: Use a limited reader.
            p_Reader.Seek(p_BundleInfo.Offset, SeekOrigin.Begin);
            var s_Manifest = new BundleManifest(p_Reader, p_Superbundle, p_BundleInfo, p_InUpdate);

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
            using var s_MultiplexedReader = new RimeMultiplexedReader(p_PatchReader, p_BaseReader, Endianness.BigEndian, false);

            var s_Manifest = new BundleManifest(s_MultiplexedReader, p_Superbundle, p_BaseBundle, false, p_PatchBundle);

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
            var s_Cas = (p_Toc.Cas.HasValue && p_Toc.Cas.Value);
            var s_Endianness = s_Cas ? Endianness.LittleEndian : Endianness.BigEndian;

            if (!File.Exists(p_Superbundle.Path + ".sb"))
                return;

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
                    if (s_Cas)
                    {
                        ParseCasBundle(s_Reader, s_Bundle, p_Superbundle, p_AutoMount);
                        continue;
                    }

                    ParseBundle(s_Reader, s_Bundle, p_Superbundle, false, p_AutoMount);
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
                if (s_Cas)
                {
                    ParseCasBundle(s_PatchReader!, s_PatchBundle, p_Superbundle, p_AutoMount);
                    continue;
                }

                ParseBundle(s_PatchReader!, s_PatchBundle, p_Superbundle, true, p_AutoMount);
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
                    
                    if (p_PatchToc.Cas.HasValue && p_PatchToc.Cas.Value)
                    {
                        ParseCasBundle(s_PatchReader!, s_Bundle, p_Superbundle, p_AutoMount);
                        continue;
                    }

                    // If all is good, parse as we normally would.
                    ParseBundle(s_PatchReader!, s_Bundle, p_Superbundle, p_AutoMount, true);
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
                // Create variant. Prefer catalog instead of inline. ContainsEntry seems expensive
                IReadableObjectWithHash? s_Readable = null;
                if (s_Resource.InlineData != null)
                    s_Readable = new InlineReadable(s_Resource.InlineData, s_Resource.Hash, s_Resource.OriginalSize != s_Resource.Size);
                else
                    s_Readable = new CatalogReadable(m_Catalog!, s_Resource.Hash, s_Resource.OriginalSize != s_Resource.Size);
                
                var s_Variant = new ResourceVariant(s_Readable, (ResourceType) s_Resource.ResourceType, s_Resource.Meta,
                    p_Bundle.ContainedSuperbundle.Name, p_Bundle.Bundle.Path);

                // Mount.
                var s_MountedObject = new MountedObject<IResourceVariant>(s_Variant, s_Resource.Name);

                m_MountedResources.AddOrUpdate(s_Resource.Name.ToLowerInvariant(), s_MountedObject, (p_GUID, p_MountedObject) =>
                {
                    // If this was already mounted, just add the variant.
                    p_MountedObject.AddVariant(s_Variant);
                    return p_MountedObject;
                });

                m_MountedResourceLowerNameHashes.AddOrUpdate(
                    RimeLib.Frostbite.Utils.HashQuickLowerCase(s_Resource.Name),
                    s_Resource.Name.ToLowerInvariant(),
                    (_, _) => s_Resource.Name.ToLowerInvariant()
                );
            }

            // Mount all chunks.
            if (p_Bundle.Bundle.ChunkEntries is not null) {
                for (var i = 0; i < p_Bundle.Bundle.ChunkEntries.Length; i++)
                {
                    var s_Chunk = p_Bundle.Bundle.ChunkEntries[i];
                    DbObject? s_Meta = null;

                    // If we have any meta, set it.
                    if (p_Bundle.Bundle.ChunkMeta is not null && p_Bundle.Bundle.ChunkMeta.Length > i)
                        s_Meta = DbObjectConverter.ToDbObject(p_Bundle.Bundle.ChunkMeta[i]);

                    // Create variant. Prefer catalog instead of inline. ContainsEntry seems expensive
                    IReadableObjectWithHash? s_Readable = null;
                    if (s_Chunk.InlineData != null)
                        s_Readable = new InlineReadable(s_Chunk.InlineData, s_Chunk.Hash, s_Chunk.Id.HasCompressionFlag());
                    else 
                        s_Readable = new CatalogReadable(m_Catalog!, s_Chunk.Hash, s_Chunk.Id.HasCompressionFlag());

                    var s_RangeStart = s_Chunk.RangeStart is not null ? (uint)s_Chunk.RangeStart : 0;
                    var s_RangeEnd = s_Chunk.RangeEnd is not null ? (uint)s_Chunk.RangeEnd : (uint)s_Chunk.Size;
                    var s_LogicalOffset = s_Chunk.LogicalOffset is not null ? (uint)s_Chunk.LogicalOffset : 0;
                    var s_Variant = new ChunkVariant(s_Readable, s_RangeStart, s_RangeEnd, s_LogicalOffset, s_Meta, p_Bundle.ContainedSuperbundle.Name,
                        p_Bundle.Bundle.Path);

                    // Mount.
                    var s_MountedObject = new MountedObject<IChunkVariant>(s_Variant, s_Chunk.Id.ToString());

                    m_MountedChunks.AddOrUpdate(s_Chunk.Id, s_MountedObject, (p_GUID, p_MountedObject) =>
                    {
                        // If this was already mounted, just add the variant.
                        p_MountedObject.AddVariant(s_Variant);
                        return p_MountedObject;
                    });
                }
            }

            // Mount all partitions.
            foreach (var s_Partition in p_Bundle.Bundle.EbxEntries)
            {
                // Create variant. Prefer catalog instead of inline. ContainsEntry seems expensive
                IReadableObjectWithHash? s_Readable = null;
                if (s_Partition.InlineData != null)
                    s_Readable = new InlineReadable(s_Partition.InlineData, s_Partition.Hash, s_Partition.OriginalSize != s_Partition.Size);
                else 
                    s_Readable = new CatalogReadable(m_Catalog!, s_Partition.Hash, s_Partition.OriginalSize != s_Partition.Size);
                
                var s_Variant = new ObjectVariant(s_Readable, p_Bundle.ContainedSuperbundle.Name, p_Bundle.Bundle.Path);

                // Mount.
                var s_MountedObject = new MountedObject(s_Variant, s_Partition.Name);

                m_MountedPartitions.AddOrUpdate(s_Partition.Name.ToLowerInvariant(), s_MountedObject, (p_GUID, p_MountedObject) =>
                {
                    // If this was already mounted, just add the variant.
                    p_MountedObject.AddVariant(s_Variant);
                    return p_MountedObject;
                });

                m_MountedPartitionsLowerNameHashes.AddOrUpdate(
                    RimeLib.Frostbite.Utils.HashQuickLowerCase(s_Partition.Name),
                    s_Partition.Name.ToLowerInvariant(),
                    (_, _) => s_Partition.Name.ToLowerInvariant()
                );

                m_MountedPartitionsGuids.AddOrUpdate(
                    EbxReader.GetPartitionGuid(s_Variant),
                    s_Partition.Name.ToLowerInvariant(),
                    (_, _) => s_Partition.Name.ToLowerInvariant()
                );
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
                var s_MountedObject = new MountedObject<IResourceVariant>(s_Variant, s_Resource.Name);

                m_MountedResources.AddOrUpdate(s_Resource.Name.ToLowerInvariant(), s_MountedObject, (p_GUID, p_MountedObject) =>
                {
                    // If this was already mounted, just add the variant.
                    p_MountedObject.AddVariant(s_Variant);
                    return p_MountedObject;
                });

                m_MountedResourceLowerNameHashes.AddOrUpdate(
                    RimeLib.Frostbite.Utils.HashQuickLowerCase(s_Resource.Name),
                    s_Resource.Name.ToLowerInvariant(),
                    (_, _) => s_Resource.Name.ToLowerInvariant()
                );
            }

            // Mount all chunks.
            foreach (var s_Chunk in p_Bundle.Chunks)
            {
                // Create variant.
                var s_Variant = new ChunkVariant(s_Chunk, s_Chunk.RangeStart, s_Chunk.RangeEnd, s_Chunk.LogicalOffset, s_Chunk.Meta != null ? DbObjectConverter.ToDbObject(s_Chunk.Meta) : null,
                    p_Bundle.ContainedSuperbundle.Name, p_Bundle.ContainedBundle.Id);

                // Mount.
                var s_MountedObject = new MountedObject<IChunkVariant>(s_Variant, s_Chunk.Id.ToString());

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
                var s_MountedObject = new MountedObject(s_Variant, s_Partition.Name);

                m_MountedPartitions.AddOrUpdate(s_Partition.Name.ToLowerInvariant(), s_MountedObject, (p_GUID, p_MountedObject) =>
                {
                    // If this was already mounted, just add the variant.
                    p_MountedObject.AddVariant(s_Variant);
                    return p_MountedObject;
                });

                m_MountedPartitionsLowerNameHashes.AddOrUpdate(
                    RimeLib.Frostbite.Utils.HashQuickLowerCase(s_Partition.Name),
                    s_Partition.Name.ToLowerInvariant(),
                    (_, _) => s_Partition.Name.ToLowerInvariant()
                );

                m_MountedPartitionsGuids.AddOrUpdate(
                    EbxReader.GetPartitionGuid(s_Variant),
                    s_Partition.Name.ToLowerInvariant(),
                    (_, _) => s_Partition.Name.ToLowerInvariant()
                );
            }

            return true;
        }

        public EngineType[] GetSupportedEngines()
        {
            return new[] { EngineType.Frostbite2_0 };
        }
    }
}
