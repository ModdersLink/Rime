using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using fb;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    [CommandDescription("Compares the generated RegistryContainer (from context) to an existing one in a partition.")]
    public class CompareRegistryContainersCommand : Command
    {
        [CommandArgument(Description = "The name of the existing RegistryContainer partition to compare against.")]
        public string? PartitionName { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (string.IsNullOrEmpty(PartitionName))
            {
                p_Writer.WriteLine("Error: PartitionName is required.");
                return false;
            }

            var s_BundleContext = (BundleBuildingContext)p_Context;
            var s_SbContext = (SbBuildingContext)s_BundleContext.Parent!;
            var s_Partitions = s_BundleContext.GetPartitions();

            var s_GeneratedRegistry = s_BundleContext.GetGeneratedRegistry();
            if (s_GeneratedRegistry == null)
            {
                p_Writer.WriteLine("Error: No RegistryContainer has been generated yet. Run 'build GenerateRegistryContainer' first.");
                return false;
            }

            if (!s_Partitions.TryGetValue(PartitionName, out var s_ExistingObject))
            {
                p_Writer.WriteLine($"Error: Partition '{PartitionName}' not found in bundle.");
                return false;
            }

            var s_Converter = EngineInterfaceRegistry.Create<IPartitionConverter>(s_SbContext.EngineType);

            try
            {
                var s_ExistingPartition = s_Converter.FromPartitionObject(PartitionName, (IObjectVariant)s_ExistingObject);
                var s_ExistingRegistry = s_ExistingPartition.Instances.OfType<RegistryContainer>().FirstOrDefault();

                if (s_ExistingRegistry == null)
                {
                    p_Writer.WriteLine($"Error: No RegistryContainer found in partition '{PartitionName}'.");
                    return false;
                }

                CompareRegistries(p_Writer, "EntityRegistry", s_GeneratedRegistry.EntityRegistry, s_ExistingRegistry.EntityRegistry, "Generated", PartitionName);
                CompareRegistries(p_Writer, "AssetRegistry", s_GeneratedRegistry.AssetRegistry, s_ExistingRegistry.AssetRegistry, "Generated", PartitionName);
                CompareRegistries(p_Writer, "BlueprintRegistry", s_GeneratedRegistry.BlueprintRegistry, s_ExistingRegistry.BlueprintRegistry, "Generated", PartitionName);
                CompareRegistries(p_Writer, "ReferenceObjectRegistry", s_GeneratedRegistry.ReferenceObjectRegistry, s_ExistingRegistry.ReferenceObjectRegistry, "Generated", PartitionName);

                return true;
            }
            catch (Exception s_Exception)
            {
                p_Writer.WriteLine($"Error: Failed to compare registry containers: {s_Exception.Message}");
                return false;
            }
        }

        private void CompareRegistries(TextWriter p_Writer, string p_RegistryName, IEnumerable<CtrRefBase> p_First, IEnumerable<CtrRefBase> p_Second, string p_FirstName, string p_SecondName)
        {
            var s_FirstGuids = new HashSet<GUID>(p_First.Select(x => ((DataContainerId.Guid)x.InstanceId).Id));
            var s_SecondGuids = new HashSet<GUID>(p_Second.Select(x => ((DataContainerId.Guid)x.InstanceId).Id));

            var s_OnlyInFirst = s_FirstGuids.Except(s_SecondGuids).ToList();
            var s_OnlyInSecond = s_SecondGuids.Except(s_FirstGuids).ToList();

            if (s_OnlyInFirst.Count == 0 && s_OnlyInSecond.Count == 0)
            {
                p_Writer.WriteLine($"{p_RegistryName}: Identical (Count: {s_FirstGuids.Count})");
            }
            else
            {
                p_Writer.WriteLine($"{p_RegistryName}: Mismatch");
                p_Writer.WriteLine($"- Only in {p_FirstName}: {s_OnlyInFirst.Count}");
                foreach (var s_Guid in s_OnlyInFirst)
                    p_Writer.WriteLine($"  - {s_Guid}");

                p_Writer.WriteLine($"- Only in {p_SecondName}: {s_OnlyInSecond.Count}");
                foreach (var s_Guid in s_OnlyInSecond)
                    p_Writer.WriteLine($"  - {s_Guid}");
            }
            p_Writer.WriteLine();
        }
    }
}
