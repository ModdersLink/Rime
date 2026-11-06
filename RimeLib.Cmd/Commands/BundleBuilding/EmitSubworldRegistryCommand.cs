using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using RimeLib.Serialization;
using System;
using System.Collections.Generic;
using System.IO;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    [CommandDescription("Emits a SubWorldData partition whose registryContainer holds the registry from generate_registry_container plus any mvdb_add_all refs. Run it after those, in the same bundle.")]
    public class EmitSubworldRegistryCommand : Command
    {
        // The mod loader finds the partition by name and hands its registryContainer to AddRegistry at
        // Level:RegisterEntityResources, which feeds the whole closure into the load-time index. That
        // is what lets a runtime-injected foreign vehicle realize its interior UI, projectiles and camo
        // the way a native asset does; a registry carrying only the MVDB binds meshes and nothing else.
        [CommandArgument(Description = "Partition name to create, e.g. levels/vehmenu/m1abrams. This is what the loader looks up.")]
        public string? PartitionName { get; set; }

        [CommandArgument(Description = "SubWorldData.Name, e.g. Levels/VehMenu/m1abrams (cosmetic; the loader keys off PartitionName).")]
        public string? SubWorldName { get; set; }

        [CommandArgument(Description = "'mvdbonly' emits only the MVDB and leaves the other registries empty, for a SubWorld realized through SWROD. Omit or '-' for the full closure.")]
        public string? Mode { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (string.IsNullOrWhiteSpace(PartitionName) || string.IsNullOrWhiteSpace(SubWorldName))
            {
                p_Writer.WriteLine("partition_name and sub_world_name are required.");
                return false;
            }

            var s_BundleContext = (BundleBuildingContext)p_Context;
            var s_SbContext = (SbBuildingContext)s_BundleContext.Parent!;

            var s_Builder = Require<IRegistryContainerBuilder>(s_SbContext.EngineType, p_Writer);
            if (s_Builder == null)
                return false;

            var s_Generated = s_BundleContext.GetGeneratedRegistry();
            var s_Registry = s_Generated == null ? null : s_Builder.Read(s_Generated);
            if (s_Registry == null)
            {
                p_Writer.WriteLine("No RegistryContainer generated yet. Run 'generate_registry_container' first.");
                return false;
            }

            var s_MvdbRefs = s_BundleContext.GetMvdbRegistryRefs();
            var s_MvdbOnly = string.Equals(Mode, "mvdbonly", StringComparison.OrdinalIgnoreCase);
            var s_Empty = new List<CtrRefBase>();

            var s_Emitted = new RegistryContainerModel();
            s_Emitted.Entities.AddRange(Distinct(s_MvdbOnly ? s_Empty : s_Registry.Entities, null));
            s_Emitted.Assets.AddRange(Distinct(s_MvdbOnly ? s_Empty : s_Registry.Assets, s_MvdbRefs));
            s_Emitted.Blueprints.AddRange(Distinct(s_MvdbOnly ? s_Empty : s_Registry.Blueprints, null));
            s_Emitted.ReferenceObjects.AddRange(Distinct(s_MvdbOnly ? s_Empty : s_Registry.ReferenceObjects, null));

            var s_Generator = EngineInterfaceRegistry.Create<IPartitionGenerator>(s_SbContext.EngineType);

            try
            {
                var s_Partition = s_Builder.CreateSubWorld(PartitionName!, SubWorldName!, s_Emitted);

                var s_Stream = new MemoryStream();
                using var s_Writer = new RimeWriter(s_Stream);
                s_Generator.Generate(s_Partition, s_Writer);
                s_BundleContext.AddRawPartitionBytes(PartitionName!, s_Stream.ToArray());
            }
            catch (Exception s_Ex)
            {
                p_Writer.WriteLine($"emit_subworld_registry: failed to build partition '{PartitionName}': {s_Ex.Message}");
                return false;
            }

            p_Writer.WriteLine($"SUBWORLD-REG: '{PartitionName}' entities={s_Emitted.Entities.Count} assets={s_Emitted.Assets.Count} " +
                               $"blueprints={s_Emitted.Blueprints.Count} refobjs={s_Emitted.ReferenceObjects.Count} (mvdb={s_MvdbRefs.Count})");
            return true;
        }

        /// <summary>The guid-addressed references, each once, then the extra ones not listed yet.</summary>
        private static IEnumerable<CtrRefBase> Distinct(IEnumerable<CtrRefBase> p_Refs, IReadOnlyList<(GUID Part, GUID Inst)>? p_Extra)
        {
            var s_Seen = new HashSet<string>();

            foreach (var s_Ref in p_Refs)
            {
                if (s_Ref.InstanceId is not DataContainerId.Guid s_G) continue;
                if (!s_Seen.Add($"{s_Ref.PartitionGuid}|{s_G.Id}")) continue;
                yield return s_Ref;
            }

            if (p_Extra != null)
                foreach (var s_X in p_Extra)
                {
                    if (!s_Seen.Add($"{s_X.Part}|{s_X.Inst}")) continue;
                    yield return new CtrRef<DataContainerBase>(s_X.Part, s_X.Inst);
                }
        }
    }
}
