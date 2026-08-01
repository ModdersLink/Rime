using fb;
using Newtonsoft.Json;
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

            var s_Registry = s_BundleContext.GetGeneratedRegistry();
            if (s_Registry == null)
            {
                p_Writer.WriteLine("No RegistryContainer generated yet. Run 'generate_registry_container' first.");
                return false;
            }

            // The loader resolves the SubWorld by name, so these guids are internal only, but they still
            // have to be unique across the level's loaded partitions or two sidecars collide.
            var s_PartGuid = new GUID(Guid.NewGuid());
            var s_SubWorldGuid = new GUID(Guid.NewGuid());
            var s_DescriptorGuid = new GUID(Guid.NewGuid());
            var s_RegistryGuid = new GUID(Guid.NewGuid());

            var s_MvdbRefs = s_BundleContext.GetMvdbRegistryRefs();
            var s_MvdbOnly = string.Equals(Mode, "mvdbonly", StringComparison.OrdinalIgnoreCase);
            var s_Empty = new RefArray<DataContainer>();

            var s_Entities = BuildRegistryArray(s_MvdbOnly ? s_Empty : s_Registry.EntityRegistry, null);
            var s_Assets = BuildRegistryArray(s_MvdbOnly ? s_Empty : s_Registry.AssetRegistry, s_MvdbRefs);
            var s_Blueprints = BuildRegistryArray(s_MvdbOnly ? s_Empty : s_Registry.BlueprintRegistry, null);
            var s_RefObjects = BuildRegistryArray(s_MvdbOnly ? s_Empty : s_Registry.ReferenceObjectRegistry, null);

            var s_SubWorld = new Dictionary<string, object?>
            {
                ["$type"] = "SubWorldData",
                ["Name"] = SubWorldName,
                ["PropertyConnections"] = Array.Empty<object>(),
                ["LinkConnections"] = Array.Empty<object>(),
                ["EventConnections"] = Array.Empty<object>(),
                ["Descriptor"] = MakeRef(s_PartGuid, s_DescriptorGuid),
                ["NeedNetworkId"] = false,
                ["InterfaceHasConnections"] = false,
                ["AlwaysCreateEntityBusClient"] = false,
                ["AlwaysCreateEntityBusServer"] = false,
                ["Objects"] = Array.Empty<object>(),
                ["RegistryContainer"] = MakeRef(s_PartGuid, s_RegistryGuid),
                ["IsWin32SubLevel"] = true,
                ["IsXenonSubLevel"] = true,
                ["IsPs3SubLevel"] = true,
                ["RememberStateOnStreamOut"] = false,
            };

            var s_Descriptor = new Dictionary<string, object?>
            {
                ["$type"] = "InterfaceDescriptorData",
                ["Fields"] = Array.Empty<object>(),
                ["InputEvents"] = Array.Empty<object>(),
                ["OutputEvents"] = Array.Empty<object>(),
                ["InputLinks"] = Array.Empty<object>(),
                ["OutputLinks"] = Array.Empty<object>(),
            };

            var s_RegistryContainer = new Dictionary<string, object?>
            {
                ["$type"] = "RegistryContainer",
                ["EntityRegistry"] = s_Entities,
                ["AssetRegistry"] = s_Assets,
                ["BlueprintRegistry"] = s_Blueprints,
                ["ReferenceObjectRegistry"] = s_RefObjects,
            };

            var s_Json = JsonConvert.SerializeObject(new
            {
                PartitionGuid = s_PartGuid.ToString(),
                PrimaryInstanceGuid = s_SubWorldGuid.ToString(),
                Name = PartitionName,
                Instances = new Dictionary<string, object?>
                {
                    [s_SubWorldGuid.ToString()] = s_SubWorld,
                    [s_DescriptorGuid.ToString()] = s_Descriptor,
                    [s_RegistryGuid.ToString()] = s_RegistryContainer,
                },
            }, Formatting.Indented);

            var s_Converter = EngineInterfaceRegistry.Create<IPartitionConverter>(s_SbContext.EngineType);
            var s_Generator = EngineInterfaceRegistry.Create<IPartitionGenerator>(s_SbContext.EngineType);

            try
            {
                using var s_JsonReader = new StringReader(s_Json);
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

            p_Writer.WriteLine($"SUBWORLD-REG: '{PartitionName}' entities={s_Entities.Count} assets={s_Assets.Count} " +
                               $"blueprints={s_Blueprints.Count} refobjs={s_RefObjects.Count} (mvdb={s_MvdbRefs.Count})");
            return true;
        }

        private static object MakeRef(GUID p_Partition, GUID p_Instance) => new
        {
            PartitionGuid = p_Partition.ToString(),
            InstanceGuid = p_Instance.ToString(),
        };

        private static List<object> BuildRegistryArray(RefArray<DataContainer> p_Refs, IReadOnlyList<(GUID Part, GUID Inst)>? p_Extra)
        {
            var s_Entries = new List<object>();
            var s_Seen = new HashSet<string>();

            foreach (var s_Ref in p_Refs)
            {
                if (s_Ref.InstanceId is not DataContainerId.Guid s_G) continue;
                if (!s_Seen.Add($"{s_Ref.PartitionGuid}|{s_G.Id}")) continue;
                s_Entries.Add(MakeRef(s_Ref.PartitionGuid, s_G.Id));
            }

            if (p_Extra != null)
                foreach (var s_X in p_Extra)
                {
                    if (!s_Seen.Add($"{s_X.Part}|{s_X.Inst}")) continue;
                    s_Entries.Add(MakeRef(s_X.Part, s_X.Inst));
                }

            return s_Entries;
        }
    }
}
