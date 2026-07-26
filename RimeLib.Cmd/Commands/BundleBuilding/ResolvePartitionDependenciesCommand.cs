using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization;
using RimeLib.Serialization.Attributes;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    [CommandDescription("Adds all referenced partitions that are not in the current bundle.")]
    internal class ResolvePartitionDependenciesCommand : Command
    {
        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_BundleContext = (BundleBuildingContext)p_Context;
            var s_SbBuildingContext = (SbBuildingContext)s_BundleContext.Parent!;
            var s_BaseContext = (BaseContext)s_SbBuildingContext.Parent!;

            var s_Mounters = s_BaseContext.GetMounters();
            if (s_Mounters.Count == 0)
            {
                p_Writer.WriteLine("No game mounted. Please mount a game first.");
                return false;
            }

            // For now use the first mounter. 
            var s_Mounter = s_Mounters.Values.First();
            var s_Converter = EngineInterfaceRegistry.Create<IPartitionConverter>(s_Mounter.GetEngineType());

            p_Writer.WriteLine("Resolving partition dependencies...");

            // Ensure PartitionRegistry is populated to resolve GUIDs to names
            if (!PartitionRegistry.Partitions.Any())
            {
                p_Writer.WriteLine("Partition registry is empty. Populating it now (this will take some time)...");
                PartitionRegistry.ParseAndRegisterAllPartitions(s_Mounter);
            }

            var s_AddedCount = 0;
            var s_ProcessedPartitions = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            bool s_FoundNew;
            do
            {
                s_FoundNew = false;
                var s_CurrentPartitions = s_BundleContext.GetPartitions();
                var s_PartitionNames = s_CurrentPartitions.Keys.ToList();

                foreach (var s_Name in s_PartitionNames)
                {
                    if (s_ProcessedPartitions.Contains(s_Name))
                        continue;

                    var s_PartitionObj = s_CurrentPartitions[s_Name];

                    try
                    {
                        var s_ReferencedGuids = new HashSet<GUID>();

                        if (s_PartitionObj is IObjectVariant s_Variant)
                        {
                            var s_Partition = s_Converter.FromPartitionObject(s_Name, s_Variant);

                            foreach (var s_Instance in s_Partition.Instances)
                            {
                                CollectReferences(s_Instance, s_ReferencedGuids);
                            }
                        }
                        else
                        {
                            // Generated/raw partitions (add_json_partition / add_raw_partition are
                            // memory/file readers, not mounted variants) used to be skipped entirely
                            // ("0 new partitions"). Their authoritative dependency list is the EBX
                            // IMPORT TABLE - parse it straight from the bytes. Shipping them without
                            // their closure left dangling imports, which the native NONCAS loader
                            // resolves eagerly -> the "creating level" hang.
                            CollectImportPartitionGuids(s_PartitionObj, s_ReferencedGuids);
                        }

                        foreach (var s_Guid in s_ReferencedGuids)
                        {
                            if (PartitionRegistry.TryGetPartition(s_Guid, out var s_ResolvedPart))
                            {
                                if (!s_CurrentPartitions.ContainsKey(s_ResolvedPart.Name))
                                {
                                    if (s_Mounter.TryGetPartition(s_ResolvedPart.Name, out var s_MountedPart))
                                    {
                                        IObjectVariant? s_NewVariant = null;
                                        if (s_BundleContext.Cas())
                                        {
                                            // Prefer catalog-backed; fall back to the noncas
                                            // variant — the cas builder content-addresses its
                                            // stored frame (ref when catalog-hit, else idata),
                                            // so DLC closures no longer leave silent holes.
                                            s_NewVariant = s_MountedPart.Variants.FirstOrDefault(v => v.Cas)
                                                ?? s_MountedPart.FirstVariant;
                                        }
                                        else
                                        {
                                            s_NewVariant = s_MountedPart.FirstVariant;
                                        }

                                        s_BundleContext.AddPartition(s_ResolvedPart.Name, s_NewVariant);
                                        p_Writer.WriteLine($"Added: {s_ResolvedPart.Name}");
                                        s_AddedCount++;
                                        s_FoundNew = true;

                                        // Update our local view of what's in the bundle
                                        s_CurrentPartitions = s_BundleContext.GetPartitions();
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception s_Ex)
                    {
                        p_Writer.WriteLine($"Warning: Failed to parse partition '{s_Name}': {s_Ex.Message}");
                    }

                    s_ProcessedPartitions.Add(s_Name);
                }
            } while (s_FoundNew);

            p_Writer.WriteLine($"Successfully added {s_AddedCount} new partitions.");
            return true;
        }

        // Reads the partition guids out of a raw EBX blob's import table (StreamingPartitionHeader:
        // dword[3] = import count; imports start at 0x50, 32 bytes each = partition + instance guid).
        private static void CollectImportPartitionGuids(IReadableObject p_Object, HashSet<GUID> p_Guids)
        {
            using var s_Reader = p_Object.GetReader();

            if (s_Reader.Length < 80)
                return;

            var s_Magic = s_Reader.ReadUInt32();

            if (s_Magic != 0x0FB2D1CE)
                return;   // not a little-endian Frostbite2_0 EBX partition

            s_Reader.Seek(12, SeekOrigin.Begin);
            var s_ImportCount = s_Reader.ReadUInt32();

            s_Reader.Seek(80, SeekOrigin.Begin);

            for (var i = 0; i < s_ImportCount; ++i)
            {
                p_Guids.Add(new GUID(s_Reader));            // partition guid
                s_Reader.Seek(16, SeekOrigin.Current);      // skip the instance guid
            }
        }

        private void CollectReferences(object? p_Object, HashSet<GUID> p_Guids)
        {
            if (p_Object == null) return;
            var s_Type = p_Object.GetType();

            // We only care about properties with ContainerFieldAttribute
            var s_Props = s_Type.GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .Where(p => p.GetCustomAttribute<ContainerFieldAttribute>() != null);

            foreach (var s_Prop in s_Props)
            {
                object? s_Val;
                try
                {
                    s_Val = s_Prop.GetValue(p_Object);
                }
                catch
                {
                    continue;
                }

                if (s_Val == null) continue;

                if (s_Val is CtrRefBase s_Ref)
                {
                    if (!s_Ref.IsNull())
                    {
                        p_Guids.Add(s_Ref.PartitionGuid);
                    }
                }
                else if (s_Val is EbxSerializable s_Serializable)
                {
                    CollectReferences(s_Serializable, p_Guids);
                }
                else if (s_Val is IEnumerable s_Enumerable && s_Val is not string)
                {
                    foreach (var s_Item in s_Enumerable)
                    {
                        if (s_Item is CtrRefBase s_ItemRef)
                        {
                            if (!s_ItemRef.IsNull()) p_Guids.Add(s_ItemRef.PartitionGuid);
                        }
                        else if (s_Item is EbxSerializable s_ItemSerializable)
                        {
                            CollectReferences(s_ItemSerializable, p_Guids);
                        }
                    }
                }
            }
        }
    }
}
