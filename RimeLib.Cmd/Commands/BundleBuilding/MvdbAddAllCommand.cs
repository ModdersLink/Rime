using RimeLib;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using RimeLib.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    [CommandDescription("Builds ONE MeshVariationDatabase containing the entries for EVERY mesh currently in this bundle (whose entry exists in the SOURCE mvdb), and adds it as a new partition. This is the 'complete official-like bundle' MVDB step: after resolve_partition_dependencies pulls a blueprint's whole mesh closure (exterior, interior/screens, weapons, tracks, LODs), this gives each mesh its variation/material binding so the object renders + is enterable exactly like a native DICE asset — WITHOUT mounting the source level's whole MVDB (which drags in unrelated textures -> CreateTexture2D crash). Bring the entries' texture partitions too (reported as MVDB-TEX).")]
    internal class MvdbAddAllCommand : Command
    {
        [CommandArgument(Description = "Source MVDB partition name that holds the entries, e.g. levels/xp1_002/cq_l/meshvariationdb_win32.")]
        public string? SourceName { get; set; }

        [CommandArgument(Description = "New MVDB partition name to create in the bundle, e.g. levels/mp_subway/objpack/meshvariationdb_win32.")]
        public string? TargetName { get; set; }

        [CommandArgument(Description = "Id returned by mount_game.")]
        public int Id { get; set; }

        [CommandArgument(Description = "true = ALSO add entries for destruction meshes (cluster/wreck/debris). Only safe when the object's FULL destruction chain is in the bundle; else their realize null-vtables.")]
        public string? IncludeDestruction { get; set; }

        [CommandArgument(Description = "Comma-separated TARGET bundle names (base + played gamemode), or '-'. Entries whose mesh is CONTAINED in these bundles are skipped: the level loads its own copy + its own MVDB entry, and a SECOND registration for the same mesh freezes the client (the m1a2_screen_mesh hang).")]
        public string? ExcludeBundles { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (string.IsNullOrWhiteSpace(SourceName) || string.IsNullOrWhiteSpace(TargetName))
            {
                p_Writer.WriteLine("source_name and target_name are required.");
                return false;
            }

            var s_BundleContext = (BundleBuildingContext)p_Context;
            var s_SbBuildingContext = (SbBuildingContext?)s_BundleContext.Parent;
            var s_BaseContext = s_SbBuildingContext?.Parent as BaseContext;
            if (s_SbBuildingContext == null || s_BaseContext == null)
            {
                p_Writer.WriteLine("Context is invalid.");
                return false;
            }
            if (!s_BaseContext.GetMounters().TryGetValue(Id, out var s_EngineMounter))
            {
                p_Writer.WriteLine($"Id ({Id}) is not valid, ensure you mounted a game first");
                return false;
            }

            var s_Converter = EngineInterfaceRegistry.Create<IPartitionConverter>(s_SbBuildingContext.EngineType);
            var s_Generator = EngineInterfaceRegistry.Create<IPartitionGenerator>(s_SbBuildingContext.EngineType);

            // set of partition names already in this bundle (meshes pulled by resolve_partition_dependencies)
            var s_InBundle = new HashSet<string>(
                s_BundleContext.GetPartitions().Select(p_P => p_P.Key), StringComparer.OrdinalIgnoreCase);

            // parse the SOURCE mvdb
            if (!s_EngineMounter.TryGetPartition(SourceName!, out var s_SrcMounted))
            {
                p_Writer.WriteLine($"Could not find source partition ({SourceName}).");
                return false;
            }
            var s_SrcVariant = s_SrcMounted.Variants.FirstOrDefault(p_V => p_V.GetContainedBundle() != null) ?? s_SrcMounted.FirstVariant;
            var s_SrcDb = s_Converter.FromPartitionObject(SourceName!, s_SrcVariant!);

            bool s_WithDestruction = string.Equals(IncludeDestruction, "true", StringComparison.OrdinalIgnoreCase);
            // "keepbase" DISABLES the hardcoded base-universal mesh skip below (diagnostic 2026-07-05:
            // that skip fixed the vanilla double-register but may have greyed the foreign vehicle's camo).
            // ExcludeBundles is a comma list: a "keepbase" token DISABLES the hardcoded base-universal mesh
            // skip; every OTHER token is a TARGET bundle whose meshes are excluded (dedup). COMPOSABLE
            // (2026-07-05): "keepbase,<bundle1>,<bundle2>" = ship base-universal meshes the map LACKS while
            // still deduping the ones it provides. Fixes the turret-view crash on infantry maps: a base-
            // universal cockpit mesh (e.g. vehicles/common/cockpits/tankhudholder_mesh) the map does NOT
            // have was base-universal-skipped → no MVDB entry → null-variation crash entering the gunner seat.
            bool s_KeepBase = false;
            var s_Excluded = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            if (!string.IsNullOrWhiteSpace(ExcludeBundles) && ExcludeBundles != "-")
            {
                foreach (var s_B in ExcludeBundles.Split(','))
                {
                    var s_Bt = s_B.Trim();
                    if (s_Bt.Length == 0) continue;
                    if (string.Equals(s_Bt, "keepbase", StringComparison.OrdinalIgnoreCase))
                    {
                        s_KeepBase = true;
                        continue;
                    }
                    try
                    {
                        foreach (var s_N in s_EngineMounter.GetPartitionsInBundle(s_Bt))
                            s_Excluded.Add(s_N);
                    }
                    catch
                    {
                        p_Writer.WriteLine($"WARN: could not enumerate exclude bundle '{s_Bt}'");
                    }
                }
            }

            // keep every entry whose MESH partition is present in this bundle
            var s_Keep = new List<fb.MeshVariationDatabaseEntry>();
            var s_KeptMeshes = new List<string>();
            var s_TexNames = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            foreach (var s_Inst in s_SrcDb.Instances)
            {
                if (s_Inst is not fb.MeshVariationDatabaseEntry s_E) continue;
                if (!s_EngineMounter.TryGetPartitionByGuid(s_E.Mesh.PartitionGuid, out var s_MName, out _) || s_MName == null)
                    continue;
                if (!s_InBundle.Contains(s_MName)) continue;
                // NEVER double-register a mesh the target level itself loads: it has its own copy + its
                // own MVDB entry; a second variation registration for the same mesh FREEZES the client.
                if (s_Excluded.Contains(s_MName))
                {
                    p_Writer.WriteLine($"MVDB-SKIP (target-provided): {s_MName}");
                    continue;
                }
                // Destruction meshes (cluster / wreck / debris): their MVDB entry triggers the destruction
                // setup (DebrisClusterData chain) — only add them when the object's full destruction chain
                // ships in the bundle (include_destruction=true), else their realize null-vtables.
                var s_MLower = s_MName.ToLowerInvariant();
                if (!s_WithDestruction && (s_MLower.Contains("cluster") || s_MLower.Contains("wreck") || s_MLower.Contains("debris")))
                {
                    p_Writer.WriteLine($"MVDB-SKIP (destruction): {s_MName}");
                    continue;
                }
                // BASE-UNIVERSAL meshes (2026-07-04): a vehicle's resolved closure pulls SHARED meshes —
                // pilots/arms (characters/), HUD, projectiles (weapons/, objects/projectiles), particles
                // (fx/), and vehicles/common/*. EVERY map already ships these + their own MVDB entry, so
                // registering OUR variation for them is a DOUBLE registration that corrupts the map's
                // native binding (white pilot, low-res vanilla). Skip them — the map binds them; our
                // mini-MVDB carries ONLY the vehicle's UNIQUE meshes (body/interior).
                if (!s_KeepBase && (s_MLower.StartsWith("characters/") || s_MLower.StartsWith("weapons/")
                    || s_MLower.StartsWith("fx/") || s_MLower.StartsWith("objects/projectiles")
                    || s_MLower.Contains("/common/")))
                {
                    p_Writer.WriteLine($"MVDB-SKIP (base-universal): {s_MName}");
                    continue;
                }
                s_Keep.Add(s_E);
                s_KeptMeshes.Add(s_MName);
                foreach (var s_Mat in s_E.Materials)
                    foreach (var s_Tp in s_Mat.TextureParameters)
                    {
                        if (s_Tp?.Value == null) continue;
                        if (s_EngineMounter.TryGetPartitionByGuid(s_Tp.Value.PartitionGuid, out var s_TexName, out _)
                            && !string.IsNullOrWhiteSpace(s_TexName))
                            s_TexNames.Add(s_TexName);
                    }
            }

            if (s_Keep.Count == 0)
            {
                p_Writer.WriteLine($"No MVDB entries in '{SourceName}' matched a mesh present in this bundle. (Is the closure resolved? Is this the right source MVDB?)");
                return false;
            }

            // strip the source MVDB down to: the primary instance + the kept entries; drop everything else
            var s_SrcConcrete = (RimeLib.Serialization.Frostbite2_0.Ebx.DatabasePartition)s_SrcDb;
            var s_SrcMvdb = (fb.MeshVariationDatabase)s_SrcConcrete.PrimaryInstance;
            var s_PrimG = s_SrcConcrete.PrimaryInstanceGuid;

            var s_KeepGuids = new HashSet<GUID>();
            s_KeepGuids.Add(s_PrimG);
            foreach (var s_E in s_Keep)
                if (s_E.InstanceId is DataContainerId.Guid s_G) s_KeepGuids.Add(s_G.Id);

            var s_ToRemove = s_SrcConcrete.InstanceMap.Keys.Where(p_K => !s_KeepGuids.Contains(p_K)).ToList();
            foreach (var s_K in s_ToRemove)
                s_SrcConcrete.InstanceMap.Remove(s_K);

            s_SrcMvdb.Entries.Clear();
            foreach (var s_E in s_Keep)
                s_SrcMvdb.Entries.AddRef(new CtrRef<fb.MeshVariationDatabaseEntry>(s_SrcConcrete.PartitionGuid, s_E.InstanceId));
            s_SrcMvdb.RedirectEntries.Clear();

            var s_Stream = new MemoryStream();
            using var s_ResWriter = new RimeWriter(s_Stream);
            s_Generator.Generate(s_SrcDb, s_ResWriter);
            var s_Bytes = s_Stream.ToArray();

            s_BundleContext.AddRawPartitionBytes(TargetName!, s_Bytes);

            foreach (var s_T in s_TexNames)
                p_Writer.WriteLine($"MVDB-TEX: {s_T}");
            // The generated MVDB keeps the SOURCE partition's guids (it is a sliced clone) — expose them so
            // the caller can reference the MVDB in a SubWorldData.registryContainer.AssetRegistry (the
            // AllModes AddRegistry index-feed): MVDB-GUID <partitionGuid> <primaryInstanceGuid>.
            p_Writer.WriteLine($"MVDB-GUID: {s_SrcConcrete.PartitionGuid} {s_PrimG}");
            // Stash for emit_subworld_registry: the raw-added MVDB partition can't be parsed by
            // generate_registry_container, so hand it the ref directly (goes into SubWorld AssetRegistry).
            s_BundleContext.AddMvdbRegistryRef(s_SrcConcrete.PartitionGuid, s_PrimG);
            p_Writer.WriteLine($"Built MVDB '{TargetName}' with {s_Keep.Count} entr(ies) for bundle meshes ({s_Bytes.Length} bytes):");
            foreach (var s_M in s_KeptMeshes.Distinct())
                p_Writer.WriteLine($"  MVDB-MESH: {s_M}");
            return true;
        }
    }
}
