using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using RimeLib.Serialization;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    /// <summary>
    /// Builds the bundle's mesh variation database from what its level partition reaches (see
    /// derive_mesh_variation_db): the keys come from the content, the entries from the databases of
    /// the mounted game. Replaces the bundle's database partition if it has one.
    /// </summary>
    [CommandDescription("Builds the bundle's mesh variation database from its level partition's content and the mounted game's databases.")]
    public class BuildMeshVariationDbCommand : Command
    {
        [CommandArgument(Description = "The level partition (LevelData or SubWorldData). Default: the bundle name without its platform prefix.", Optional = true)]
        public string? Partition { get; set; }

        [CommandArgument(Description = "The id of the mounted game to resolve everything outside the bundle with.", Optional = true)]
        public int Id { get; set; } = 1;

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_BundleContext = (BundleBuildingContext)p_Context;
            var s_SbContext = (SbBuildingContext)s_BundleContext.Parent!;
            var s_BaseContext = (BaseContext)s_SbContext.Parent!;

            if (!s_BaseContext.GetMounters().TryGetValue(Id, out var s_Mounter))
            {
                p_Writer.WriteLine($"Id ({Id}) is not valid, ensure you mounted a game first.");
                return false;
            }

            if (s_Mounter.GetEngineType() != s_SbContext.EngineType)
            {
                p_Writer.WriteLine($"Cross-engine support has not been added, ({s_Mounter.GetEngineType()} != {s_SbContext.EngineType})");
                return false;
            }

            var s_BundleName = s_BundleContext.BundleName.ToLowerInvariant();
            var s_Root = (Partition ?? (s_BundleName.StartsWith("win32/") ? s_BundleName["win32/".Length..] : s_BundleName)).ToLowerInvariant();
            var s_Name = $"{s_Root}/meshvariationdb_win32";

            var s_Partitions = BundlePartitionVariant.All(s_BundleContext);
            var s_Deriver = new RegistryDeriver(s_Mounter, p_N => s_Partitions.GetValueOrDefault(p_N), s_Partitions.Keys);
            if (s_Deriver.GetVariant(s_Root) == null)
            {
                p_Writer.WriteLine($"No partition named '{s_Root}' in the bundle or the mounted game.");
                return false;
            }

            var s_MeshDeriver = new MeshVariationDeriver(s_Deriver);
            var s_Result = s_MeshDeriver.Derive(s_Root, s_Partitions.Keys.Where(p_N => p_N != s_Name), p_Writer, s_SbContext.DerivedMeshes.GetValueOrDefault);
            s_SbContext.DerivedMeshes[s_Root] = s_Result.Keys.Select(p_K => p_K.Mesh).ToHashSet();
            var s_Entries = s_MeshDeriver.EntriesFor(s_Result.Keys);
            if (s_Entries.Count == 0 && s_MeshDeriver.Rules.OmitsEmptyDatabase)
            {
                s_BundleContext.RemovePartition(s_Name);
                p_Writer.WriteLine($"No entries; '{s_Name}' is left out, as the engine ships no empty database.");
                return true;
            }

            // The bundle's own database, or the game's of that name, keeps its guids; any other one
            // serves as a template under a new partition guid.
            var s_Template = s_Deriver.ParseCopy(s_Name);
            if (s_Template == null)
            {
                var s_Any = s_MeshDeriver.Pool.Values.First()[0].Database;
                s_Template = s_Deriver.ParseCopy(s_Any)!;
                s_Template.PartitionGuid = new GUID(Guid.NewGuid());
            }

            s_Template.Name = s_Name;
            s_MeshDeriver.Rules.SetEntries(s_Template, s_Entries);

            var s_Generator = EngineInterfaceRegistry.Create<IPartitionGenerator>(s_SbContext.EngineType);
            var s_Stream = new MemoryStream();
            using (var s_Writer = new RimeWriter(s_Stream))
                s_Generator.Generate(s_Template, s_Writer);

            var s_Bytes = s_Stream.ToArray();

            // Read it back, so a database that doesn't parse never reaches the bundle.
            var s_Converter = EngineInterfaceRegistry.Create<IPartitionConverter>(s_SbContext.EngineType);
            var s_Reread = s_Converter.FromPartitionObject(s_Name, new BundlePartitionVariant(new SbBuildingContext.MemoryReader(s_Bytes), s_BundleName));
            var s_RereadCount = s_MeshDeriver.Rules.ReadEntries(s_Reread).Count();
            if (s_RereadCount != s_Entries.Count)
            {
                p_Writer.WriteLine($"The built database reads back with {s_RereadCount} entries instead of {s_Entries.Count}; not added.");
                return false;
            }

            s_BundleContext.RemovePartition(s_Name);
            s_BundleContext.AddRawPartitionBytes(s_Name, s_Bytes);
            if (s_Template.PrimaryInstance.InstanceId is DataContainerId.Guid s_Primary)
                s_BundleContext.AddMeshVariationDbRegistryRef(s_Template.PartitionGuid, s_Primary.Id);

            // What the entries bind (textures above all) has to ship too, with its own closure;
            // whatever the bundle or its dependencies already carry is skipped there.
            var s_Needed = s_Entries
                .SelectMany(p_E => Game.AnalyzeRegistryCommand.References(p_E, p_E.GetType().Name, 0))
                .Select(p_R => p_R.Ref.PartitionGuid).Distinct()
                .Select(p_G => s_Mounter.TryGetPartitionByGuid(p_G, out var s_N, out _) ? s_N.ToLowerInvariant() : null)
                .Where(p_N => p_N != null && !s_BundleContext.GetPartitions().ContainsKey(p_N!))
                .OrderBy(p_N => p_N, StringComparer.Ordinal).ToList();
            if (PartitionClosure.Create((BundleBuildingContext)p_Context, Id, [], TextWriter.Null) is not { } s_Adder)
            {
                p_Writer.WriteLine($"No game {Id} of this bundle's engine is mounted to add their closure from.");
                return false;
            }

            s_Adder.AddAll(s_Needed, p_Writer);
            if (s_Needed.Count > 0)
                p_Writer.WriteLine($"Added {s_Needed.Count} partition(s) the entries bind, with their closure.");

            p_Writer.WriteLine($"Built '{s_Name}' with {s_Entries.Count} entries ({s_Bytes.Length} bytes).");

            // Against the game's database of that name, when there is one.
            if (s_Mounter.TryGetPartition(s_Name, out var s_Retail))
            {
                var s_Shipped = s_Converter.FromPartitionObject(s_Name, s_Retail.FirstVariant);
                var s_ShippedKeys = s_MeshDeriver.Rules.ReadEntries(s_Shipped).Select(p_E => (s_Deriver.Key(p_E.Mesh.PartitionGuid, p_E.Mesh.InstanceId), p_E.VariationHash)).ToHashSet();
                p_Writer.WriteLine($"The game's '{s_Name}': {s_ShippedKeys.Count} entries, {s_ShippedKeys.Count(s_Result.Keys.Contains)} of them built, {s_Result.Keys.Count(p_K => !s_ShippedKeys.Contains(p_K))} built that it lacks.");
                foreach (var (s_Key, s_Hash) in s_ShippedKeys.Where(p_K => !s_Result.Keys.Contains(p_K)))
                    p_Writer.WriteLine($"  MISSING {s_Deriver.PartitionName(s_Key) ?? s_Key} variation {s_Hash}");
            }
            return true;
        }
    }
}
