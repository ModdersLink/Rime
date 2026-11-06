using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Commands.Game;
using RimeLib.Cmd.Contexts;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization;
using RimeLib.Serialization.Conversion;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    /// <summary>
    /// Points a reference field of a bundle partition's primary instance at another partition's
    /// primary instance, as a converted level gets the target engine's assets its source has none of
    /// (a Frostbite 2 level's emitter system), or at a copy of an instance of it, which a level keeps
    /// inside its own partition (its animated skeleton database). A target from the mounted game, or a
    /// copy's references, are added with their closure.
    /// </summary>
    [CommandDescription("Points a reference field of a bundle partition's primary instance at another partition's primary instance, or at a copy of one of its instances.")]
    public class SetReferenceCommand : Command
    {
        [CommandArgument(Description = "The bundle's partition, e.g. levels/mp_prison/mp_prison.")]
        public string? Partition { get; set; }

        [CommandArgument(Description = "The reference field of its primary instance, e.g. EmitterSystemAsset; a reference array, e.g. AntProjectAssets, drops its null entries and gains the target.")]
        public string? Field { get; set; }

        [CommandArgument(Description = "The partition to point at, in the bundle or the mounted game, e.g. levels/mp_subway/mp_subway/emittersystem_win32.")]
        public string? Target { get; set; }

        [CommandArgument(Description = "The id of the mounted game to find the target in when the bundle does not hold it.", Optional = true)]
        public int Id { get; set; } = 1;

        [CommandArgument(Description = "The GUID of an instance of the target to copy into the partition and point at, instead of the target's primary instance.", Optional = true)]
        public string? Instance { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (string.IsNullOrWhiteSpace(Partition) || string.IsNullOrWhiteSpace(Field) || string.IsNullOrWhiteSpace(Target))
            {
                p_Writer.WriteLine("usage: set_reference <partition> <field> <target> [id] [instance]");
                return false;
            }

            var s_Bundle = (BundleBuildingContext)p_Context;
            var s_Sb = (SbBuildingContext)s_Bundle.Parent!;
            var s_Converter = EngineInterfaceRegistry.Create<IPartitionConverter>(s_Sb.EngineType);
            var s_Variants = BundlePartitionVariant.All(s_Bundle);
            var s_Name = Partition!.ToLowerInvariant();
            if (!s_Variants.TryGetValue(s_Name, out var s_Variant))
            {
                p_Writer.WriteLine($"The bundle has no partition '{Partition}'.");
                return false;
            }

            var s_Partition = s_Converter.FromPartitionObject(s_Name, s_Variant);
            var s_Value = s_Partition.PrimaryInstance.GetType().GetProperty(Field!)?.GetValue(s_Partition.PrimaryInstance);
            // A reference array keeps its non-null references and gains the target.
            var s_Element = s_Value?.GetType().GetInterfaces()
                .FirstOrDefault(p_I => p_I.IsGenericType && p_I.GetGenericTypeDefinition() == typeof(IList<>))?.GetGenericArguments()[0];
            var s_List = s_Value is IList s_L && s_Element != null && typeof(CtrRefBase).IsAssignableFrom(s_Element) ? s_L : null;
            var s_Ref = s_List != null ? (CtrRefBase)Activator.CreateInstance(s_Element!)! : s_Value as CtrRefBase;
            if (s_Ref == null)
            {
                p_Writer.WriteLine($"'{Partition}''s primary instance has no reference field '{Field}'.");
                return false;
            }

            var s_TargetName = Target!.ToLowerInvariant();
            DatabasePartitionBase? s_Target = null;
            if (s_Variants.TryGetValue(s_TargetName, out var s_TargetVariant))
                s_Target = s_Converter.FromPartitionObject(s_TargetName, s_TargetVariant);
            else if (((BaseContext)s_Sb.Parent!).GetMounters().TryGetValue(Id, out var s_Game) && s_Game.GetEngineType() == s_Sb.EngineType
                     && s_Game.TryGetPartition(s_TargetName, out var s_Mounted))
                s_Target = s_Converter.FromPartitionObject(s_TargetName, s_Mounted.FirstVariant);

            if (s_Target == null)
            {
                p_Writer.WriteLine($"Neither the bundle nor game {Id} has a partition '{Target}'.");
                return false;
            }

            DataContainerBase? s_Copy = null;
            if (s_List != null)
            {
                if (!string.IsNullOrWhiteSpace(Instance))
                {
                    p_Writer.WriteLine($"'{Field}' is a reference array; it takes no instance copy.");
                    return false;
                }

                for (var i = s_List.Count - 1; i >= 0; --i)
                    if (s_List[i] is not CtrRefBase { } s_Item || s_Item.IsNull() || s_Item.PartitionGuid == s_Target.PartitionGuid)
                        s_List.RemoveAt(i);
                s_Ref.SetValue(s_Target.PartitionGuid, s_Target.PrimaryInstance.InstanceId);
                s_List.Add(s_Ref);
            }
            else if (string.IsNullOrWhiteSpace(Instance))
                s_Ref.SetValue(s_Target.PartitionGuid, s_Target.PrimaryInstance.InstanceId);
            else
            {
                if (!Guid.TryParse(Instance, out var s_Guid)
                    || s_Target.Instances.FirstOrDefault(p_I => p_I.InstanceId is DataContainerId.Guid s_Id && s_Id.Id == new GUID(s_Guid)) is not { } s_Found)
                {
                    p_Writer.WriteLine($"'{Target}' has no instance {Instance}.");
                    return false;
                }

                s_Copy = s_Found;
                s_Copy.InstanceId = new DataContainerId.Guid(PartitionConversion.Derived(s_Partition.PartitionGuid, Field!));
                s_Ref.SetValue(s_Partition.PartitionGuid, s_Copy.InstanceId);
                s_Partition = EngineInterfaceRegistry.Create<IEbxTypeLibrary>(s_Sb.EngineType).CreatePartition(s_Name, s_Partition.PartitionGuid,
                    PartitionConversion.InstanceGuid(s_Partition.PartitionGuid, s_Partition.PrimaryInstance.InstanceId),
                    s_Partition.Instances.Where(p_I => !Equals(p_I.InstanceId, s_Copy.InstanceId)).Append(s_Copy).ToList());
            }

            var s_Stream = new MemoryStream();
            using (var s_Writer = new RimeWriter(s_Stream))
                EngineInterfaceRegistry.Create<IPartitionGenerator>(s_Sb.EngineType).Generate(s_Partition, s_Writer);
            s_Bundle.RemovePartition(s_Name);
            s_Bundle.AddRawPartitionBytes(s_Name, s_Stream.ToArray());
            // What the bundle now refers to in the mounted game ships with it: the target, or what the copy references.
            var s_Mounter = ((BaseContext)s_Sb.Parent!).GetMounters()[Id];
            var s_Referenced = s_Copy == null
                ? s_Variants.ContainsKey(s_TargetName) ? [] : [s_TargetName]
                : AnalyzeRegistryCommand.References(s_Copy, s_Copy.GetType().Name, 0)
                    .Select(p_R => s_Mounter.TryGetPartitionByGuid(p_R.Ref.PartitionGuid, out var s_N, out _) ? s_N : null)
                    .OfType<string>().Distinct(StringComparer.OrdinalIgnoreCase).ToList();
            if (s_Referenced.Count > 0 && PartitionClosure.Create(s_Bundle, Id, [], TextWriter.Null) is { } s_Closure)
                s_Closure.AddAll(s_Referenced, p_Writer);
            p_Writer.WriteLine(s_Copy == null
                ? $"'{s_Name}' {Field} now points at '{s_TargetName}'."
                : $"'{s_Name}' {Field} now points at a copy of '{s_TargetName}' {Instance}, with the {s_Referenced.Count} partition(s) it references.");
            return true;
        }
    }
}
