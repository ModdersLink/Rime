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
    [CommandDescription("Copies one mesh's MeshVariationDatabase entry from a source mvdb into a new minimal mvdb partition. Its mesh, material and texture partitions have to be in the same bundle.")]
    internal class MeshVariationDbAddEntryCommand : Command
    {
        // Mounting the whole source MVDB instead would pull in every other mesh's textures. The copied
        // entry keeps its refs to the mesh, its materials and their texture parameters, so those
        // partitions have to go in the same bundle or the entry's imports dangle. They are reported as
        // MVDB-TEX and MVDB-VAR.
        //
        // An appearance or camo realizes with a hash of fnv(variation name), and an entry missing for
        // that hash leaves the mesh invisible, so use 'all' when the object has variations.
        [CommandArgument(Description = "Source MVDB partition name that holds the entry, e.g. levels/mp_017/mp_017/meshvariationdb_win32.")]
        public string? SourceName { get; set; }

        [CommandArgument(Description = "Name of the MVDB partition to create in this bundle.")]
        public string? TargetName { get; set; }

        [CommandArgument(Description = "Id returned by mount_game.")]
        public int Id { get; set; }

        [CommandArgument(Description = "Mesh asset name of the entry to copy, e.g. levels/mp_017/terrain/mp_017_waves_01_mesh.")]
        public string? MeshName { get; set; }

        [CommandArgument(Description = "'all' copies every entry for the mesh, variations included. Defaults to the first entry only.", Optional = true)]
        public string? Mode { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (string.IsNullOrWhiteSpace(SourceName) || string.IsNullOrWhiteSpace(TargetName) || string.IsNullOrWhiteSpace(MeshName))
            {
                p_Writer.WriteLine("source_name, target_name and mesh_name are required.");
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

            if (!s_EngineMounter.TryGetPartition(SourceName!, out var s_SrcMounted))
            {
                p_Writer.WriteLine($"Could not find source partition ({SourceName}).");
                return false;
            }

            var s_SrcVariant = s_SrcMounted.Variants.FirstOrDefault(p_V => p_V.GetContainedBundle() != null) ?? s_SrcMounted.FirstVariant;
            var s_SrcDb = s_Converter.FromPartitionObject(SourceName!, s_SrcVariant!);

            // Match entries by resolving their mesh ref's partition guid through the mounter. Calling
            // .Get() would need the PartitionRegistry, and re-parsing the mesh partition closes the
            // shared stream out from under us.
            var s_All = string.Equals(Mode, "all", StringComparison.OrdinalIgnoreCase);
            var s_Matches = new List<fb.MeshVariationDatabaseEntry>();
            var s_EntryCount = 0;
            foreach (var s_Inst in s_SrcDb.Instances)
            {
                if (s_Inst is not fb.MeshVariationDatabaseEntry s_E) continue;
                s_EntryCount++;
                if (s_EngineMounter.TryGetPartitionByGuid(s_E.Mesh.PartitionGuid, out var s_MName, out _)
                    && string.Equals(s_MName, MeshName, StringComparison.OrdinalIgnoreCase))
                {
                    s_Matches.Add(s_E);
                    if (!s_All)
                        break;
                }
            }

            if (s_Matches.Count == 0)
            {
                p_Writer.WriteLine($"No MVDB entry found for mesh '{MeshName}' in '{SourceName}'. ({s_EntryCount} entry instance(s) scanned).");
                return false;
            }

            // Report the partitions the copied entries import beyond the mesh itself: the textures bound
            // by their materials, and the ObjectVariation partitions carrying MeshMaterialVariation. The
            // caller has to add these to the bundle or the entries' imports dangle.
            var s_TexNames = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            var s_VarNames = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            foreach (var s_M in s_Matches)
                foreach (var s_Mat in s_M.Materials)
                {
                    foreach (var s_Tp in s_Mat.TextureParameters)
                    {
                        if (s_Tp?.Value == null) continue;
                        if (s_EngineMounter.TryGetPartitionByGuid(s_Tp.Value.PartitionGuid, out var s_TexName, out _)
                            && !string.IsNullOrWhiteSpace(s_TexName))
                            s_TexNames.Add(s_TexName);
                    }

                    if (s_Mat.MaterialVariation?.PartitionGuid is { } s_MvG && s_MvG != GUID.Empty
                        && s_EngineMounter.TryGetPartitionByGuid(s_MvG, out var s_MvName, out _)
                        && !string.IsNullOrWhiteSpace(s_MvName)
                        && !string.Equals(s_MvName, MeshName, StringComparison.OrdinalIgnoreCase))
                        s_VarNames.Add(s_MvName);
                }

            foreach (var s_T in s_TexNames)
                p_Writer.WriteLine($"MVDB-TEX: {s_T}");
            foreach (var s_V in s_VarNames)
                p_Writer.WriteLine($"MVDB-VAR: {s_V}");

            var s_KeepIds = new List<(fb.MeshVariationDatabaseEntry Entry, GUID Id)>();
            foreach (var s_M in s_Matches)
            {
                if (s_M.InstanceId is not DataContainerId.Guid s_IdG)
                {
                    p_Writer.WriteLine($"Entry (hash={s_M.VariationAssetNameHash}) has a non-guid instance id, skipped.");
                    continue;
                }

                s_KeepIds.Add((s_M, s_IdG.Id));
            }

            if (s_KeepIds.Count == 0)
            {
                p_Writer.WriteLine("Entry has a non-guid instance id.");
                return false;
            }

            // Strip the source MVDB down to its primary instance plus the matched entries and add that as
            // a separate partition. The target level's own MVDB is left alone: regenerating a full-size
            // MVDB is not byte-faithful, but a handful of entries is, and the game consults both.
            var s_SrcConcrete = (RimeLib.Serialization.Frostbite2_0.Ebx.DatabasePartition)s_SrcDb;
            var s_SrcMvdb = (fb.MeshVariationDatabase)s_SrcConcrete.PrimaryInstance;

            var s_PrimG = s_SrcConcrete.PrimaryInstanceGuid;
            var s_ToRemove = s_SrcConcrete.InstanceMap.Keys
                .Where(p_K => p_K.CompareTo(s_PrimG) != 0 && !s_KeepIds.Any(p_E => p_K.CompareTo(p_E.Id) == 0))
                .ToList();
            foreach (var s_K in s_ToRemove)
                s_SrcConcrete.InstanceMap.Remove(s_K);

            s_SrcMvdb.Entries.Clear();
            foreach (var s_E in s_KeepIds)
                s_SrcMvdb.Entries.AddRef(new CtrRef<fb.MeshVariationDatabaseEntry>(s_SrcConcrete.PartitionGuid, s_E.Entry.InstanceId));
            s_SrcMvdb.RedirectEntries.Clear();

            var s_Stream = new MemoryStream();
            using var s_ResWriter = new RimeWriter(s_Stream);
            s_Generator.Generate(s_SrcDb, s_ResWriter);
            var s_Bytes = s_Stream.ToArray();

            s_BundleContext.AddRawPartitionBytes(TargetName!, s_Bytes);

            var s_Hashes = string.Join(",", s_KeepIds.Select(p_E => p_E.Entry.VariationAssetNameHash));
            p_Writer.WriteLine($"Built minimal MVDB '{TargetName}' with {s_KeepIds.Count} '{MeshName}' entr(ies) (variationAssetNameHash={s_Hashes}, {s_Bytes.Length} bytes).");
            return true;
        }
    }
}
