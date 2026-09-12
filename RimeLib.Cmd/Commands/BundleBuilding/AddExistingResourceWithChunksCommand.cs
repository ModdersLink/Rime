using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite.Core;
using RimeLib.Mesh;
using RimeLib.Texture;
using RimeLib.Toolkit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    /// <summary>
    /// Adds an existing resource and the chunks its payload streams from.
    ///
    /// add_existing_resource adds the resource header only. A MeshSet's or a texture's payload --
    /// vertex/index data, mips -- lives in a chunk named by guid from inside that header, and in
    /// vanilla the engine finds it in the level superbundle the resource shipped in. A mod bundle
    /// referencing a DIFFERENT level's resources has no such superbundle, so the chunk has to be
    /// carried along or the bundle is not self-contained.
    ///
    /// The failure that causes is brutal to diagnose: a dedicated server never fetches render
    /// payloads and loads happily, while the client hangs forever. BF3's chunk lookup
    /// (vu.com+0xC1CAC) is an open-addressed GUID probe whose miss path reads the 0xFFFF "empty"
    /// bucket sentinel and indexes the entry array with it instead of terminating, so a chunk that
    /// is not resident is an infinite loop rather than an error, and the player sees a black screen.
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

            // Same variant selection as add_existing_resource, which records why a cas build must
            // not require a cas variant.
            IResourceVariant? s_Variant;
            if (s_BundleContext.Cas())
            {
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

            // The resource is in. Now carry whatever its payload streams from.
            //
            // The variant that ADDS a resource is not the one that READS it: the add path wants a
            // variant contained in a bundle, the read path one whose stream is the whole resource.
            // Neither FirstVariant nor the cas-selected variant is reliably the latter -- MEASURED
            // on MP_001's full mesh set, FirstVariant alone throws for 348 of 1223 resources -- so
            // ask each variant in turn and take the first that parses.
            //
            // A payload that cannot be parsed must not abort the build: these are shipped game
            // resources of every vintage, and one unexpected header killed a whole 145-resource
            // build with an unhandled "offset out of bounds" after four of them.
            IEnumerable<GUID> s_ChunkIds = Array.Empty<GUID>();
            Exception? s_LastError = null;

            foreach (var s_ReadVariant in new[] { s_Resource.FirstVariant }
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
                catch (Exception s_Exception)
                {
                    s_LastError = s_Exception;
                }
            }

            // Report but fall through: a parse failure is exactly what the name-hash fallback below
            // exists for, and returning here skipped it for the 26 meshes that need it most.
            if (s_LastError != null)
                p_Writer.WriteLine($"Could not read payload dependencies of ({Name}): {s_LastError.Message}");

            var s_Added = 0;

            foreach (var s_ChunkId in s_ChunkIds)
            {
                if (s_ChunkId == null || s_ChunkId.Equals(GUID.Empty))
                    continue;

                if (AddChunk(s_BundleContext, s_EngineMounter, s_ChunkId, Name!, p_Writer, ChunkDir))
                    s_Added++;
            }

            // Fallback: find the chunk by the resource's name hash instead of by parsing its payload.
            // Every chunk carries the h32 hash of the asset that owns it and the mounter indexes it
            // (dump_bundle_chunk_meta reports 3705 chunks for mp_001, none missing), which makes the
            // payload parse optional. 25 of 145 meshes fail MeshSetLayout with "offset out of
            // bounds" -- dump_resource_with_chunks fails on them identically, so it is a reader bug,
            // not bad data -- and every one of them resolves through here. Verified:
            // architecture/footbridge_01/footbridge_01_stairs_Mesh hashes to chunk
            // 9fc9aa2a-d58b-e709-eaee-90f5eb1350e1, exactly the id a hung client was searching for.
            if (s_Added == 0)
            {
                var s_Hash = unchecked((int)RimeLib.Frostbite.Utils.HashQuickLowerCase(Name!));

                // Search EVERY bundle this resource appears in, not just the added variant's. A
                // resource is commonly shipped in several and the chunk meta lives with the one that
                // owns the payload: searching a single bundle recovered footbridge's stairs_rails
                // but not its stairs, from the same object, in the same level.
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
                        return Array.Empty<GUID>();
                    }

                    // One chunk per LOD. A mesh whose LODs are not all resident renders some detail
                    // levels and hangs on the others, which looks like a distance bug. Materialised
                    // here because a lazy sequence would throw at enumeration time, outside the
                    // caller's guard.
                    return EngineInterfaceRegistry.Create<IMeshConverter>(s_Engine)
                        .GetChunkGuids(p_Variant).Values.ToList();

                case ResourceType.DxTexture:
                case ResourceType.Ps3Texture:
                case ResourceType.ITexture:
                    if (!EngineInterfaceRegistry.IsSupported<ITextureConverter>(s_Engine))
                    {
                        p_Writer.WriteLine($"No texture converter for engine '{s_Engine}'; chunks not carried.");
                        return Array.Empty<GUID>();
                    }

                    return new[]
                    {
                        EngineInterfaceRegistry.Create<ITextureConverter>(s_Engine).GetTextureChunkId(p_Variant),
                    };

                default:
                    return Array.Empty<GUID>();
            }
        }

        /// <summary>Adds one chunk, picking the variant the bundle that owns the payload ships.</summary>
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

            // Both branches end in FirstVariant. A chunk that ships ONLY in a chunk superbundle
            // (win32/mpchunks and friends) has no variant contained in a bundle at all, so requiring
            // one dropped it -- while dump_chunk, which takes the first variant with no such
            // requirement, writes those very bytes without complaint. MEASURED on MP_001's
            // team_deathmatch bundle: 25 of 340 resources lost a mesh LOD chunk that way, and the
            // load then hangs rather than reporting anything.
            if (p_BundleContext.Cas())
            {
                s_Variant = s_Chunk.Variants.FirstOrDefault(p_Chunk => p_Chunk.Cas && p_Chunk.GetContainedBundle() != null)
                    ?? s_Chunk.Variants.FirstOrDefault(p_Chunk => p_Chunk.GetContainedBundle() != null)
                    ?? s_Chunk.FirstVariant;
            }
            else
                s_Variant = s_Chunk.Variants.FirstOrDefault(p_Chunk => p_Chunk.GetContainedBundle() != null)
                    ?? s_Chunk.FirstVariant;

            if (s_Variant == null)
            {
                // The chunk is indexed but no variant of it is resident in anything mounted, so there
                // are no bytes to reference. A dump of it on disk is those bytes, and adding one
                // from a file is what add_chunk already does. MEASURED on MP_001's full mesh set:
                // 68 of 1681 chunk attachments land here, all LOD or destruction slices, all 68
                // present in the corpus dump. Dropping them is not the harmless degradation the
                // message sounds like -- the server never notices, the client livelocks.
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
