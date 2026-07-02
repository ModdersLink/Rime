using RimeLib;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using RimeLib.Serialization;
using System;
using System.IO;
using System.Linq;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    [CommandDescription("Copies ONE MeshVariationDatabase entry (the one for <mesh_name>) from a SOURCE mvdb partition into a TARGET mvdb partition, and adds the patched target partition to this bundle (override). Lets a standalone IMPORTED mesh render on another level WITHOUT mounting the whole source MVDB (which drags in every other mesh's textures -> CreateTexture2D crash). The entry keeps its CtrRefs (mesh / materials / TextureParameters) — bring those partitions into the same bundle so the imports resolve.")]
    internal class MvdbAddEntryCommand : Command
    {
        [CommandArgument(Description = "Source MVDB partition name (has the entry), e.g. levels/mp_017/mp_017/meshvariationdb_win32.")]
        public string? SourceName { get; set; }

        [CommandArgument(Description = "Target MVDB partition name to patch (the current level's mvdb).")]
        public string? TargetName { get; set; }

        [CommandArgument(Description = "Id returned by mount_game.")]
        public int Id { get; set; }

        [CommandArgument(Description = "Mesh asset name of the entry to copy, e.g. levels/mp_017/terrain/mp_017_waves_01_mesh.")]
        public string? MeshName { get; set; }

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

            // --- parse the SOURCE mvdb and find the entry for <mesh_name> -------------------------
            if (!s_EngineMounter.TryGetPartition(SourceName!, out var s_SrcMounted))
            {
                p_Writer.WriteLine($"Could not find source partition ({SourceName}).");
                return false;
            }
            var s_SrcVariant = s_SrcMounted.Variants.FirstOrDefault(p_V => p_V.GetContainedBundle() != null) ?? s_SrcMounted.FirstVariant;
            var s_SrcDb = s_Converter.FromPartitionObject(SourceName!, s_SrcVariant!);

            // Find the entry among the SOURCE partition's instances (they ARE DataContainers). Match by
            // resolving the entry's Mesh CtrRef PARTITION GUID back to a name via the mounter — this
            // avoids .Get() (needs the PartitionRegistry) and avoids re-parsing the mesh partition
            // (a 2nd/3rd FromPartitionObject closes a shared stream -> ObjectDisposedException).
            fb.MeshVariationDatabaseEntry? s_Entry = null;
            int s_EntryCount = 0;
            foreach (var s_Inst in s_SrcDb.Instances)
            {
                if (s_Inst is not fb.MeshVariationDatabaseEntry s_E) continue;
                s_EntryCount++;
                if (s_EngineMounter.TryGetPartitionByGuid(s_E.Mesh.PartitionGuid, out var s_MName, out _)
                    && string.Equals(s_MName, MeshName, StringComparison.OrdinalIgnoreCase))
                {
                    s_Entry = s_E;
                    break;
                }
            }
            if (s_Entry == null)
            {
                p_Writer.WriteLine($"No MVDB entry found for mesh '{MeshName}' in '{SourceName}'. ({s_EntryCount} entry instance(s) scanned).");
                return false;
            }

            // REPORT the textures this entry binds (materials' TextureParameters). The mesh's own material
            // params are often empty — the texture->slot binding lives here — so the caller must bring these
            // texture partitions into the bundle or the entry's imports dangle. Just reads guids (no Get()).
            var s_TexNames = new System.Collections.Generic.HashSet<string>(StringComparer.OrdinalIgnoreCase);
            foreach (var s_Mat in s_Entry.Materials)
                foreach (var s_Tp in s_Mat.TextureParameters)
                {
                    if (s_Tp?.Value == null) continue;
                    if (s_EngineMounter.TryGetPartitionByGuid(s_Tp.Value.PartitionGuid, out var s_TexName, out _)
                        && !string.IsNullOrWhiteSpace(s_TexName))
                        s_TexNames.Add(s_TexName);
                }
            foreach (var s_T in s_TexNames)
                p_Writer.WriteLine($"MVDB-TEX: {s_T}");

            // --- build a MINIMAL standalone MVDB = the source STRIPPED to only this one entry ------
            // Regenerating the target level's huge (595-entry) MVDB isn't byte-faithful -> it crashed
            // XP1_002 at load. Instead we strip the SOURCE MVDB down to just the wave-mesh entry and
            // add it as a NEW partition (TargetName): the level's own MVDB stays UNTOUCHED, and the
            // game consults this extra MVDB for the mesh's variation entry. The tiny regen is faithful.
            if (s_Entry.InstanceId is not DataContainerId.Guid s_EntryIdGuid)
            {
                p_Writer.WriteLine("Entry has a non-guid instance id.");
                return false;
            }
            var s_SrcConcrete = (RimeLib.Serialization.Frostbite2_0.Ebx.DatabasePartition)s_SrcDb;
            var s_SrcMvdb = (fb.MeshVariationDatabase)s_SrcConcrete.PrimaryInstance;

            // keep ONLY the primary MVDB instance + the one entry; drop every other instance
            var s_PrimG = s_SrcConcrete.PrimaryInstanceGuid;
            var s_EntryG = s_EntryIdGuid.Id;
            var s_ToRemove = s_SrcConcrete.InstanceMap.Keys
                .Where(p_K => p_K.CompareTo(s_PrimG) != 0 && p_K.CompareTo(s_EntryG) != 0)
                .ToList();
            foreach (var s_K in s_ToRemove)
                s_SrcConcrete.InstanceMap.Remove(s_K);

            // the MVDB now lists only our entry
            s_SrcMvdb.Entries.Clear();
            s_SrcMvdb.Entries.AddRef(new CtrRef<fb.MeshVariationDatabaseEntry>(s_SrcConcrete.PartitionGuid, s_Entry.InstanceId));
            s_SrcMvdb.RedirectEntries.Clear();

            var s_Stream = new MemoryStream();
            using var s_ResWriter = new RimeWriter(s_Stream);   // function-scoped: keep stream alive
            s_Generator.Generate(s_SrcDb, s_ResWriter);
            var s_Bytes = s_Stream.ToArray();

            s_BundleContext.AddRawPartitionBytes(TargetName!, s_Bytes);

            p_Writer.WriteLine($"Built minimal MVDB '{TargetName}' with the '{MeshName}' entry (variationAssetNameHash={s_Entry.VariationAssetNameHash}, {s_Entry.Materials.Count} material(s), {s_Bytes.Length} bytes).");
            return true;
        }
    }
}
