using fb;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using RimeLib.Serialization;
using System;
using System.IO;
using System.Text;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    [CommandDescription("Emits a NEW SubWorldData partition whose registryContainer = the registry produced by " +
        "the preceding generate_registry_container (all networked entities, projectiles, blueprints, reference " +
        "objects, assets AND the MeshVariationDatabase). This is the AllModes AddRegistry sidecar built in-process: " +
        "the mod loader SearchForDataContainer(<subWorldName>) -> SubWorldData.registryContainer -> AddRegistry at " +
        "Level:RegisterEntityResources feeds the WHOLE closure into the load-time index, so a runtime-injected " +
        "foreign vehicle realizes its interior UI / projectiles / camo exactly like a native asset (a bare MVDB-only " +
        "registry only binds meshes). Replaces the hand-built _vehmenu_sw/<vk>_sw.json. Run AFTER " +
        "generate_registry_container, in the SAME bundle.")]
    public class EmitSubworldRegistryCommand : Command
    {
        [CommandArgument(Description = "Partition name to create, e.g. levels/vehmenu/m1abrams (what the loader SearchForDataContainer's).")]
        public string? PartitionName { get; set; }

        [CommandArgument(Description = "SubWorldData.Name, e.g. Levels/VehMenu/m1abrams (cosmetic; the loader keys off PartitionName).")]
        public string? SubWorldName { get; set; }

        [CommandArgument(Description = "'mvdbonly' = emit ONLY the MVDB in assetRegistry (empty entity/blueprint/refobj registries). Use when the SubWorld is SWROD-REALIZED (a realize instantiates the entity/blueprint registries → the vehicle closure realizing at load null-derefs; only the MVDB is needed to feed the load-time mesh-variation index). Omit/'-' = full closure (for AddRegistry).")]
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

            var s_Registry = s_BundleContext.GetGeneratedRegistry();
            if (s_Registry == null)
            {
                p_Writer.WriteLine("No RegistryContainer generated yet. Run 'generate_registry_container' first.");
                return false;
            }

            // fresh, unique guids: the loader resolves the SubWorld by NAME, so these are internal-only, but
            // they MUST be unique across the level's loaded partitions (a fixed guid would collide when several
            // vehicle sidecars load at once).
            var s_PartGuid = new GUID(Guid.NewGuid());
            var s_SubWorldGuid = new GUID(Guid.NewGuid());
            var s_DescriptorGuid = new GUID(Guid.NewGuid());
            var s_RegistryGuid = new GUID(Guid.NewGuid());

            var s_Sb = new StringBuilder();
            s_Sb.Append("{\n");
            s_Sb.Append($"  \"PartitionGuid\": \"{s_PartGuid}\",\n");
            s_Sb.Append($"  \"PrimaryInstanceGuid\": \"{s_SubWorldGuid}\",\n");
            s_Sb.Append($"  \"Name\": \"{PartitionName}\",\n");
            s_Sb.Append("  \"Instances\": {\n");

            // SubWorldData (primary instance)
            s_Sb.Append($"    \"{s_SubWorldGuid}\": {{\n");
            s_Sb.Append("      \"$type\": \"SubWorldData\",\n");
            s_Sb.Append($"      \"Name\": \"{SubWorldName}\",\n");
            s_Sb.Append("      \"PropertyConnections\": [],\n");
            s_Sb.Append("      \"LinkConnections\": [],\n");
            s_Sb.Append("      \"EventConnections\": [],\n");
            s_Sb.Append("      \"Descriptor\": {\n");
            s_Sb.Append($"        \"PartitionGuid\": \"{s_PartGuid}\",\n");
            s_Sb.Append($"        \"InstanceGuid\": \"{s_DescriptorGuid}\"\n");
            s_Sb.Append("      },\n");
            s_Sb.Append("      \"NeedNetworkId\": false,\n");
            s_Sb.Append("      \"InterfaceHasConnections\": false,\n");
            s_Sb.Append("      \"AlwaysCreateEntityBusClient\": false,\n");
            s_Sb.Append("      \"AlwaysCreateEntityBusServer\": false,\n");
            s_Sb.Append("      \"Objects\": [],\n");
            s_Sb.Append("      \"RegistryContainer\": {\n");
            s_Sb.Append($"        \"PartitionGuid\": \"{s_PartGuid}\",\n");
            s_Sb.Append($"        \"InstanceGuid\": \"{s_RegistryGuid}\"\n");
            s_Sb.Append("      },\n");
            s_Sb.Append("      \"IsWin32SubLevel\": true,\n");
            s_Sb.Append("      \"IsXenonSubLevel\": true,\n");
            s_Sb.Append("      \"IsPs3SubLevel\": true,\n");
            s_Sb.Append("      \"RememberStateOnStreamOut\": false\n");
            s_Sb.Append("    },\n");

            // InterfaceDescriptorData
            s_Sb.Append($"    \"{s_DescriptorGuid}\": {{\n");
            s_Sb.Append("      \"$type\": \"InterfaceDescriptorData\",\n");
            s_Sb.Append("      \"Fields\": [],\n");
            s_Sb.Append("      \"InputEvents\": [],\n");
            s_Sb.Append("      \"OutputEvents\": [],\n");
            s_Sb.Append("      \"InputLinks\": [],\n");
            s_Sb.Append("      \"OutputLinks\": []\n");
            s_Sb.Append("    },\n");

            // MVDB refs from mvdb_add_all (raw-added partition generate_registry_container can't parse) get
            // merged into the AssetRegistry — the load-time mesh-variation index feed / camo binding.
            var s_MvdbRefs = s_BundleContext.GetMvdbRegistryRefs();
            bool s_MvdbOnly = string.Equals(Mode, "mvdbonly", StringComparison.OrdinalIgnoreCase);

            // RegistryContainer. mvdbonly (for a SWROD-REALIZED SubWorld) = ONLY the MVDB in assetRegistry;
            // the entity/blueprint/refobj registries are EMPTY so the realize doesn't try to instantiate the
            // vehicle closure at load (that null-derefs, vu+0xda117a). Full (for AddRegistry) = the whole closure.
            var s_Empty = new RefArray<DataContainer>();
            s_Sb.Append($"    \"{s_RegistryGuid}\": {{\n");
            s_Sb.Append("      \"$type\": \"RegistryContainer\",\n");
            int s_E = AppendRegistryArray(s_Sb, "EntityRegistry", s_MvdbOnly ? s_Empty : s_Registry.EntityRegistry, null, true);
            int s_A = AppendRegistryArray(s_Sb, "AssetRegistry", s_MvdbOnly ? s_Empty : s_Registry.AssetRegistry, s_MvdbRefs, true);
            int s_B = AppendRegistryArray(s_Sb, "BlueprintRegistry", s_MvdbOnly ? s_Empty : s_Registry.BlueprintRegistry, null, true);
            int s_R = AppendRegistryArray(s_Sb, "ReferenceObjectRegistry", s_MvdbOnly ? s_Empty : s_Registry.ReferenceObjectRegistry, null, false);
            s_Sb.Append("    }\n");

            s_Sb.Append("  }\n");
            s_Sb.Append("}\n");

            var s_Converter = EngineInterfaceRegistry.Create<IPartitionConverter>(s_SbContext.EngineType);
            var s_Generator = EngineInterfaceRegistry.Create<IPartitionGenerator>(s_SbContext.EngineType);

            try
            {
                using var s_JsonReader = new StringReader(s_Sb.ToString());
                var s_Partition = s_Converter.FromJsonStream(s_JsonReader);

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

            p_Writer.WriteLine($"SUBWORLD-REG: '{PartitionName}' entities={s_E} assets={s_A} blueprints={s_B} refobjs={s_R} (mvdb={s_MvdbRefs.Count})");
            return true;
        }

        private static int AppendRegistryArray(StringBuilder p_Sb, string p_Field, RefArray<DataContainer> p_Arr,
            System.Collections.Generic.IReadOnlyList<(GUID Part, GUID Inst)>? p_Extra, bool p_TrailingComma)
        {
            p_Sb.Append($"      \"{p_Field}\": [");
            int s_Count = 0;
            var s_Seen = new System.Collections.Generic.HashSet<string>();
            foreach (var s_Ref in p_Arr)
            {
                if (s_Ref.InstanceId is not DataContainerId.Guid s_G) continue;
                if (!s_Seen.Add($"{s_Ref.PartitionGuid}|{s_G.Id}")) continue;
                p_Sb.Append(s_Count == 0 ? "\n" : ",\n");
                p_Sb.Append($"        {{ \"PartitionGuid\": \"{s_Ref.PartitionGuid}\", \"InstanceGuid\": \"{s_G.Id}\" }}");
                s_Count++;
            }
            if (p_Extra != null)
                foreach (var s_X in p_Extra)
                {
                    if (!s_Seen.Add($"{s_X.Part}|{s_X.Inst}")) continue;
                    p_Sb.Append(s_Count == 0 ? "\n" : ",\n");
                    p_Sb.Append($"        {{ \"PartitionGuid\": \"{s_X.Part}\", \"InstanceGuid\": \"{s_X.Inst}\" }}");
                    s_Count++;
                }
            p_Sb.Append(s_Count == 0 ? "]" : "\n      ]");
            p_Sb.Append(p_TrailingComma ? ",\n" : "\n");
            return s_Count;
        }
    }
}
