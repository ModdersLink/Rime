using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite.Core;
using RimeLib.Mesh;
using RimeLib.Texture;
using RimeLib.Toolkit;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    /// <summary>
    /// Adds an existing resource AND the chunks its payload streams from.
    ///
    /// `add_existing_resource` adds the resource header only. For a MeshSet or a texture the actual
    /// payload -- vertex/index data, texture mips -- lives in a CHUNK referenced by guid from inside
    /// that header, and the chunk is not carried along. In vanilla that is fine: the chunk is in the
    /// level superbundle the resource shipped in, and the engine finds it there.
    ///
    /// A mod bundle that references game resources from a DIFFERENT level has no such superbundle,
    /// and the failure is brutal to diagnose: the dedicated server never fetches render payloads and
    /// loads happily, while the client hangs forever. BF3's chunk lookup (vu.com+0xC1CAC) is an open
    /// addressed GUID probe whose miss path reads the 0xFFFF "empty" bucket sentinel and indexes the
    /// entry array with it instead of terminating -- so a chunk that is not resident is not an error,
    /// it is an infinite loop, and the player sees a black screen.
    ///
    /// This command closes that gap at build time so the bundle is self-contained.
    /// </summary>
    [CommandDescription("Adds an existing resource and the chunks its payload references to this bundle.")]
    internal class AddExistingResourceWithChunksCommand : Command
    {
        [CommandArgument(Description = "The name of the resource.")]
        public string? Name { get; set; }

        [CommandArgument(Description = "Id returned by mount_game.")]
        public int Id { get; set; }

        [CommandArgument(Optional = true, Description =
            "Directory of dumped <guid>.chunk files, used only when a chunk the payload names has " +
            "no usable variant in the mounted game.")]
        public DirectoryInfo? ChunkDir { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                p_Writer.WriteLine("The specified resource could not be found.");
                return false;
            }

            var s_BundleContext = (BundleBuildingContext)p_Context;
            var s_SbBuildingContext = (SbBuildingContext?)s_BundleContext.Parent;

            if (s_SbBuildingContext == null)
            {
                p_Writer.WriteLine("Parent context is invalid.");
                return false;
            }

            if (s_SbBuildingContext.Parent is not BaseContext s_BaseContext)
            {
                p_Writer.WriteLine("SbBuildingContext parent is invalid.");
                return false;
            }

            var s_Mounters = s_BaseContext.GetMounters();

            if (!s_Mounters.TryGetValue(Id, out var s_EngineMounter))
            {
                p_Writer.WriteLine($"Id ({Id}) is not valid, ensure you mounted a game first");
                return false;
            }

            var s_ContextEngineType = s_SbBuildingContext.EngineType;

            if (s_EngineMounter.GetEngineType() != s_ContextEngineType)
            {
                p_Writer.WriteLine($"Cross-engine support has not been added, ({s_EngineMounter.GetEngineType()} != {s_ContextEngineType})");
                return false;
            }

            if (!s_EngineMounter.TryGetResource(Name!, out var s_Resource))
            {
                p_Writer.WriteLine($"Could not find resource ({Name}).");
                return false;
            }

            IResourceVariant? s_Variant;

            if (s_BundleContext.Cas())
            {
                // Prefer a cas-backed variant, but do NOT require one. BF3 ships plenty of resources
                // only in noncas bundles, and the cas manifest builder already content-addresses a
                // noncas frame -- emitting a bare sha1 ref on a catalog hit and idata otherwise -- so
                // there is nothing a cas variant gives us here that a noncas one does not.
                //
                // Requiring it silently dropped 640 of 1192 resources on a level build, and with them
                // the 621 chunks their payloads name: the superbundle built without error, listed the
                // same partitions as the noncas build, and the level then would not load. Same
                // fallback chain add_existing_chunk and reference_existing_partition already use.
                s_Variant = s_Resource.Variants.FirstOrDefault(p_Resource => p_Resource.Cas && p_Resource.GetContainedBundle() != null)
                    ?? s_Resource.Variants.FirstOrDefault(p_Resource => p_Resource.GetContainedBundle() != null)
                    ?? s_Resource.FirstVariant;
            }
            else
                s_Variant = s_Resource.Variants.FirstOrDefault(p_Resource => p_Resource.GetContainedBundle() != null);

            if (s_Variant == null)
            {
                p_Writer.WriteLine($"Could not find a valid variant of ({Name}).");
                return false;
            }

            s_BundleContext.AddResource(Name!, s_Variant);

            // The resource itself is in. Now carry whatever its payload streams from.
            //
            // A payload that cannot be parsed must NOT abort the build: these are shipped game
            // resources of every vintage, and one malformed or unexpected header killed a whole
            // 145-resource build with an unhandled "offset out of bounds" after four of them. The
            // resource is already added; missing its chunks degrades that one asset, not the level.
            // TRY EVERY VARIANT, not just the first.
            //
            // The add path wants a variant contained in a bundle; the read path wants one whose
            // stream is the whole resource, and they are different objects. Reading the cas variant
            // threw "offset out of bounds" on 25 of 145 meshes and FirstVariant read all of them,
            // so FirstVariant became the read path -- but that is the same mistake one step over.
            // MEASURED on MP_001's full mesh set: FirstVariant alone throws for 348 of 1223
            // resources, every one of which then falls back to searching by name hash.
            //
            // A resource can carry several variants and only some of them are complete; which one
            // that is varies per resource, so ask each in turn and take the first that parses. The
            // fallback stays for a resource where none of them do.
            IEnumerable<GUID> s_ChunkIds = System.Array.Empty<GUID>();
            System.Exception? s_LastError = null;

            foreach (var s_ReadVariant in Enumerable.Repeat(s_Resource.FirstVariant, 1)
                         .Concat(s_Resource.Variants.Where(p_V => p_V != s_Resource.FirstVariant)))
            {
                if (s_ReadVariant == null)
                    continue;

                try
                {
                    var s_Candidate = GetPayloadChunkIds(s_EngineMounter, s_ReadVariant, p_Writer);

                    if (s_Candidate.Any())
                    {
                        s_ChunkIds = s_Candidate;
                        s_LastError = null;
                        break;
                    }
                }
                catch (System.Exception s_Exception)
                {
                    s_LastError = s_Exception;
                }
            }

            if (s_LastError != null)
            {
                // Fall THROUGH to the name-hash fallback below -- a parse failure is exactly the case
                // it exists for. Returning here skipped it for all 26 meshes that need it most.
                p_Writer.WriteLine($"Could not read payload dependencies of ({Name}): {s_LastError.Message}");
            }
            var s_Added = 0;

            foreach (var s_ChunkId in s_ChunkIds)
            {
                if (s_ChunkId == null || s_ChunkId.Equals(GUID.Empty))
                    continue;

                if (AddChunk(s_BundleContext, s_EngineMounter, s_ChunkId, Name!, p_Writer, ChunkDir))
                    s_Added++;
            }

            // Fallback: find the chunk by the resource's NAME HASH instead of by parsing its payload.
            //
            // Every chunk carries the h32 hash of the asset that owns it, and the mounter indexes it
            // (dump_bundle_chunk_meta reports 3705 chunks for mp_001 with none missing). That makes
            // the payload parse optional: 25 of 145 meshes fail MeshSetLayout with "offset out of
            // bounds" -- Rime's own dump_resource_with_chunks fails on them identically, so it is a
            // reader bug, not a data problem -- and every one of them resolves through this path.
            // Verified: architecture/footbridge_01/footbridge_01_stairs_Mesh hashes to the chunk
            // 9fc9aa2a-d58b-e709-eaee-90f5eb1350e1, which is exactly the id a hung client was
            // searching for.
            if (s_Added == 0)
            {
                var s_Hash = unchecked((int)RimeLib.Frostbite.Utils.HashQuickLowerCase(Name!));

                // Search EVERY bundle this resource appears in, not just the cas-selected variant's.
                // A resource is commonly shipped in several bundles and the chunk meta lives with the
                // one that owns the payload: searching only one bundle recovered footbridge's
                // stairs_rails but not its stairs, from the same object, in the same level.
                var s_Bundles = s_Resource.Variants
                    .Select(p_V => p_V.GetContainedBundle())
                    .Where(p_B => !string.IsNullOrEmpty(p_B))
                    .Distinct();

                foreach (var s_Bundle in s_Bundles)
                {
                    foreach (var s_Entry in s_EngineMounter.GetChunksWithHashInBundle(s_Bundle!))
                    {
                        if (s_Entry.AssetNameHash != s_Hash)
                            continue;

                        if (AddChunk(s_BundleContext, s_EngineMounter, s_Entry.Guid, Name!, p_Writer, ChunkDir))
                            s_Added++;
                    }

                    if (s_Added > 0)
                        break;
                }
            }

            if (s_Added > 0)
                p_Writer.WriteLine($"Added resource ({Name}) with {s_Added} chunk(s).");

            return true;
        }

        /// <summary>
        /// The chunk guids a resource's payload names. Resource types with no streamed payload
        /// return nothing, which is not an error -- most resources are self-contained.
        /// </summary>
        private static IEnumerable<GUID> GetPayloadChunkIds(IEngineMounter p_Mounter, IResourceVariant p_Variant,
            TextWriter p_Writer)
        {
            var s_Type = p_Variant.GetResourceType();
            var s_Engine = p_Mounter.GetEngineType();

            switch (s_Type)
            {
                case ResourceType.MeshSet:
                    if (!EngineInterfaceRegistry.IsSupported<IMeshConverter>(s_Engine))
                    {
                        p_Writer.WriteLine($"No mesh converter for engine '{s_Engine}'; chunks not carried.");
                        return System.Array.Empty<GUID>();
                    }

                    // One chunk per LOD. A mesh whose LODs are not all resident renders some
                    // detail levels and hangs on the others, which looks like a distance bug.
                    // Materialised inside the try: a lazy sequence would throw at enumeration
                    // time, outside the guard that is meant to contain it.
                    return EngineInterfaceRegistry.Create<IMeshConverter>(s_Engine)
                        .GetChunkGuids(p_Variant).Values.ToList();

                case ResourceType.DxTexture:
                case ResourceType.Ps3Texture:
                case ResourceType.ITexture:
                    if (!EngineInterfaceRegistry.IsSupported<ITextureConverter>(s_Engine))
                    {
                        p_Writer.WriteLine($"No texture converter for engine '{s_Engine}'; chunks not carried.");
                        return System.Array.Empty<GUID>();
                    }

                    return new[]
                    {
                        EngineInterfaceRegistry.Create<ITextureConverter>(s_Engine).GetTextureChunkId(p_Variant),
                    };

                default:
                    return System.Array.Empty<GUID>();
            }
        }

        /// <summary>Same variant selection as add_existing_chunk, so both routes agree.</summary>
        private static bool AddChunk(BundleBuildingContext p_BundleContext, IEngineMounter p_Mounter, GUID p_Guid,
            string p_AssetName, TextWriter p_Writer, DirectoryInfo? p_ChunkDir = null)
        {
            if (!p_Mounter.TryGetChunk(p_Guid, out var s_Chunk))
            {
                p_Writer.WriteLine($"Could not find chunk ({p_Guid}).");
                return false;
            }

            // Prefer the variant carrying THIS asset's name hash. A chunk can hold several variants
            // that are different slices of the same payload; the one the owning bundle ships is
            // ranged to exactly the slice this resource asks for, and any other reads wrong bytes.
            // Same rule reference_existing_partition already follows.
            var s_NameHash = unchecked((int)RimeLib.Frostbite.Utils.HashQuickLowerCase(p_AssetName));
            IChunkVariant? s_Variant = s_Chunk.Variants.FirstOrDefault(p_V => p_V.GetAssetNameHash() == s_NameHash);

            if (s_Variant != null)
            {
                p_BundleContext.AddChunk(p_Guid, s_Variant);
                return true;
            }

            if (p_BundleContext.Cas())
            {
                s_Variant = s_Chunk.Variants.FirstOrDefault(p_Chunk => p_Chunk.Cas && p_Chunk.GetContainedBundle() != null)
                    ?? s_Chunk.Variants.FirstOrDefault(p_Chunk => p_Chunk.GetContainedBundle() != null)
                    ?? s_Chunk.FirstVariant;
            }
            else
                // Same last-resort fallback the cas branch already has. A chunk that ships ONLY in a
                // chunk superbundle (win32/mpchunks and friends) has no variant contained in a
                // bundle at all, so requiring one dropped it -- while dump_chunk, which takes the
                // first variant with no such requirement, writes those very bytes without complaint.
                // MEASURED on MP_001's team_deathmatch bundle: 25 of 340 resources lost a mesh LOD
                // chunk this way, and the load then hangs rather than reporting anything.
                s_Variant = s_Chunk.Variants.FirstOrDefault(p_Chunk => p_Chunk.GetContainedBundle() != null)
                    ?? s_Chunk.FirstVariant;

            if (s_Variant == null)
            {
                // The chunk is INDEXED but no variant of it is resident in anything we mounted, so
                // there are no bytes to reference. A dump of the same chunk on disk is those bytes,
                // and adding it from the file is exactly what `add_chunk` already does.
                //
                // MEASURED on MP_001's full mesh set: 68 of 1681 chunk attachments land here, all
                // of them LOD or destruction slices, and all 68 are present in the corpus dump. The
                // server never notices a missing chunk; the CLIENT livelocks on one (the black
                // screen this whole command exists to prevent), so leaving them out is not the
                // harmless degradation the message makes it sound.
                var s_File = p_ChunkDir == null
                    ? null
                    : new FileInfo(Path.Combine(p_ChunkDir.FullName, p_Guid + ".chunk"));

                if (s_File is { Exists: true })
                {
                    p_BundleContext.AddChunk(p_Guid, s_File, p_AssetName);
                    return true;
                }

                p_Writer.WriteLine($"Could not find a valid variant of chunk ({p_Guid})."
                    + (p_ChunkDir == null ? "" : $" No {p_Guid}.chunk in {p_ChunkDir.FullName} either."));
                return false;
            }

            p_BundleContext.AddChunk(p_Guid, s_Variant);

            return true;
        }
    }
}
