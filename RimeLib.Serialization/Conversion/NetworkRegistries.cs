using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using RimeLib.Frostbite.Core;

namespace RimeLib.Serialization.Conversion;

/// <summary>
/// The RegistryContainer an engine that keeps one in each sub-world needs, from the
/// NetworkRegistryAsset an engine that keeps them apart has for the same sub-world: what the
/// sub-world gives network ids, split into the container's lists by what each object is.
/// </summary>
public static class NetworkRegistries
{
    private const string c_ContainerType = "RegistryContainer";
    private const string c_ContainerField = "RegistryContainer";
    private const string c_ObjectsField = "Objects";

    /// <summary>Each list's objects derive from its type; what derives from none of them is an entity.</summary>
    private static readonly (string Base, string List)[] s_Lists =
    [
        ("Blueprint", "BlueprintRegistry"),
        ("ReferenceObjectData", "ReferenceObjectRegistry"),
        ("Asset", "AssetRegistry"),
    ];

    private const string c_EntityList = "EntityRegistry";

    /// <summary>Whether the partition's primary instance has a registry field it leaves empty.</summary>
    public static bool Lacks(DatabasePartitionBase p_Partition) =>
        p_Partition.PrimaryInstance.GetType().GetProperty(c_ContainerField)?.GetValue(p_Partition.PrimaryInstance) is CtrRefBase s_Ref && s_Ref.IsNull();

    /// <summary>
    /// The sub-world with a RegistryContainer of the registry's objects and its primary instance
    /// referring to it. An object is left out where <paramref name="p_Kept"/> says the target does
    /// not have it; <paramref name="p_SourceType"/> gives an object's type in the source. How many
    /// objects it registers comes out as <paramref name="p_Registered"/>.
    /// </summary>
    public static DatabasePartitionBase WithRegistry(IEbxTypeLibrary p_Target, DatabasePartitionBase p_SubWorld, DatabasePartitionBase p_Registry,
        Func<CtrRefBase, Type?> p_SourceType, Func<CtrRefBase, bool> p_Kept, ConversionReport p_Report, out int p_Registered)
    {
        p_Registered = 0;
        var s_Type = p_Target.FindType(c_ContainerType) ?? throw new InvalidOperationException($"the target has no {c_ContainerType}");
        var s_Container = (DataContainerBase)Activator.CreateInstance(s_Type)!;
        var s_Guid = PartitionConversion.Derived(p_SubWorld.PartitionGuid, c_ContainerType);
        s_Container.InstanceId = new DataContainerId.Guid(s_Guid);

        var s_Objects = p_Registry.PrimaryInstance.GetType().GetProperty(c_ObjectsField)?.GetValue(p_Registry.PrimaryInstance) as IEnumerable
            ?? throw new InvalidOperationException($"{p_Registry.Name}'s primary instance has no {c_ObjectsField}");

        foreach (var s_Object in s_Objects.OfType<CtrRefBase>())
        {
            if (s_Object.IsNull() || p_SourceType(s_Object) is not { } s_SourceType || !p_Kept(s_Object))
            {
                ConversionReport.Count(p_Report.Unreferenced, $"{c_ContainerType}: an object the target does not have");
                continue;
            }

            var s_List = (IList)s_Type.GetProperty(ListOf(s_SourceType))!.GetValue(s_Container)!;
            var s_Element = s_List.GetType().GetInterfaces().First(p_I => p_I.IsGenericType && p_I.GetGenericTypeDefinition() == typeof(IList<>)).GetGenericArguments()[0];
            var s_Ref = (CtrRefBase)Activator.CreateInstance(s_Element)!;
            s_Ref.SetValue(s_Object.PartitionGuid, new DataContainerId.Guid(PartitionConversion.InstanceGuid(s_Object.PartitionGuid, s_Object.InstanceId)));
            s_List.Add(s_Ref);
            ++p_Registered;
        }

        var s_Primary = p_SubWorld.PrimaryInstance;
        ((CtrRefBase)s_Primary.GetType().GetProperty(c_ContainerField)!.GetValue(s_Primary)!).SetValue(p_SubWorld.PartitionGuid, s_Container.InstanceId);
        return p_Target.CreatePartition(p_SubWorld.Name, p_SubWorld.PartitionGuid, PartitionConversion.InstanceGuid(p_SubWorld.PartitionGuid, s_Primary.InstanceId),
            p_SubWorld.Instances.Append(s_Container).ToList());
    }

    private static string ListOf(Type p_Type)
    {
        for (var s_Type = p_Type; s_Type != null; s_Type = s_Type.BaseType)
            foreach (var (s_Base, s_List) in s_Lists)
                if (s_Type.Name == s_Base)
                    return s_List;
        return c_EntityList;
    }
}
