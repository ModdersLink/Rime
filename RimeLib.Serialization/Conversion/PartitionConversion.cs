using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;

namespace RimeLib.Serialization.Conversion;

/// <summary>
/// Converts partitions to another engine's types by name: each instance becomes the target's type
/// of the same name, and each field takes the value of the source field of the same name, enums
/// by value name. A struct whose field the target makes a reference becomes an instance of the
/// partition. <see cref="ConversionRules"/> cover the rest: types and enum values the target names
/// differently, fields it takes from elsewhere, structs it keeps one field of and primary instances
/// it has elsewhere. Fields the target's build derives are set by its <see cref="IDerivedFields"/>.
/// Instances without a GUID that nothing references any more are dropped. What the target cannot
/// hold is dropped and counted in <see cref="Report"/>.
/// </summary>
public sealed class PartitionConversion
{
    private readonly IEbxTypeLibrary m_Target;
    private readonly ConversionRules m_Rules;
    private readonly IDerivedFields? m_Derived;
    private readonly Dictionary<(Type, Type), FieldMap> m_Fields = new();
    private readonly Dictionary<Type, object> m_Defaults = new();

    public ConversionReport Report { get; } = new();

    public PartitionConversion(IEbxTypeLibrary p_Target, ConversionRules? p_Rules = null, IDerivedFields? p_Derived = null)
    {
        m_Target = p_Target;
        m_Rules = p_Rules ?? new ConversionRules();
        m_Derived = p_Derived;
    }

    /// <summary>
    /// A conversion to the target engine's types with the source engine's rules for it and the
    /// target's derived fields, where the engines have them.
    /// </summary>
    public static PartitionConversion Between(EngineType p_Source, EngineType p_Target) => new(
        EngineInterfaceRegistry.Create<IEbxTypeLibrary>(p_Target),
        EngineInterfaceRegistry.IsSupported<IConversionRules>(p_Source)
            ? EngineInterfaceRegistry.Create<IConversionRules>(p_Source).For(p_Target)
            : null,
        EngineInterfaceRegistry.IsSupported<IDerivedFields>(p_Target)
            ? EngineInterfaceRegistry.Create<IDerivedFields>(p_Target)
            : null);

    /// <summary>
    /// The GUID an instance has in the target. One with a GUID keeps it; one with an index gets a
    /// GUID derived from its partition's and the index, so a reference from another partition
    /// resolves to the same.
    /// </summary>
    public static GUID InstanceGuid(GUID p_Partition, DataContainerId p_Id) => p_Id switch
    {
        DataContainerId.Guid s_Guid => s_Guid.Id,
        DataContainerId.Index s_Index => Derived(p_Partition, $"{s_Index.Id}"),
        _ => throw new ArgumentOutOfRangeException(nameof(p_Id)),
    };

    /// <summary>
    /// The partition with each instance whose type the target has. A reference to an instance of
    /// another partition is kept as it is; whether that instance converts is up to that partition.
    /// </summary>
    public DatabasePartitionBase Convert(DatabasePartitionBase p_Source)
    {
        if (ContainerType(p_Source.PrimaryInstance.GetType()) == null)
            throw new InvalidDataException($"the primary instance's type {p_Source.PrimaryInstance.GetType().Name} has no counterpart");

        var s_Converted = new Dictionary<DataContainerBase, DataContainerBase>(ReferenceEqualityComparer.Instance);
        foreach (var s_Instance in p_Source.Instances)
        {
            var s_Type = ContainerType(s_Instance.GetType());
            Report.Instances++;
            if (s_Type == null)
            {
                ConversionReport.Count(Report.DroppedTypes, s_Instance.GetType().Name);
                continue;
            }

            var s_Target = (DataContainerBase)Activator.CreateInstance(s_Type)!;
            s_Target.InstanceId = new DataContainerId.Guid(InstanceGuid(p_Source.PartitionGuid, s_Instance.InstanceId));
            s_Converted.Add(s_Instance, s_Target);
        }

        var s_Partition = new Scope(p_Source.PartitionGuid, p_Source.Instances.ToDictionary(p_I => p_I.InstanceId),
            s_Converted.Keys.Select(p_I => p_I.InstanceId).ToHashSet());
        foreach (var (s_Source, s_Target) in s_Converted)
            CopyFields(s_Source, s_Target, s_Partition);

        var s_Primary = PrimaryGuid(p_Source, s_Partition);
        var s_Kept = Reached(s_Converted, s_Partition, s_Primary);
        Report.ConvertedInstances += s_Converted.Values.Count(s_Kept.Contains);
        var s_Result = m_Target.CreatePartition(p_Source.Name, p_Source.PartitionGuid, s_Primary,
            s_Converted.Values.Concat(s_Partition.Inlined).Where(s_Kept.Contains).ToList());
        m_Derived?.Derive(s_Result, Report);
        return s_Result;
    }

    /// <summary>
    /// The partition being converted, its instances by id, the ids of those that convert and the
    /// instances made of structs.
    /// </summary>
    private sealed record Scope(GUID Partition, Dictionary<DataContainerId, DataContainerBase> Sources, HashSet<DataContainerId> Converted)
    {
        public List<DataContainerBase> Inlined { get; } = new();
    }

    /// <summary>The GUID of the target's primary instance: the source's, or the one a <see cref="ConversionRules.Primary"/> rule leads to.</summary>
    private GUID PrimaryGuid(DatabasePartitionBase p_Source, Scope p_Scope)
    {
        var s_Primary = p_Source.PrimaryInstance;
        if (!m_Rules.Primary.TryGetValue(s_Primary.GetType().Name, out var s_Path))
            return InstanceGuid(p_Scope.Partition, s_Primary.InstanceId);

        if (!Follow(s_Primary, s_Path, p_Scope, out var s_Value) || s_Value is not CtrRefBase s_Ref
            || s_Ref.PartitionGuid != p_Scope.Partition || !p_Scope.Converted.Contains(s_Ref.InstanceId))
            throw new InvalidDataException($"the primary instance's {s_Path} is no instance of the partition that converts");
        return InstanceGuid(p_Scope.Partition, s_Ref.InstanceId);
    }

    /// <summary>
    /// The converted instances that the primary or an instance with a GUID reaches through references
    /// in the partition. Nothing else can reference one that has only an index, so the rest are
    /// dropped and counted.
    /// </summary>
    private HashSet<DataContainerBase> Reached(Dictionary<DataContainerBase, DataContainerBase> p_Converted, Scope p_Scope, GUID p_Primary)
    {
        var s_ByGuid = p_Converted.Values.Concat(p_Scope.Inlined).ToDictionary(p_I => ((DataContainerId.Guid)p_I.InstanceId).Id);
        var s_Pending = new Stack<DataContainerBase>(p_Converted
            .Where(p_C => p_C.Key.InstanceId is DataContainerId.Guid)
            .Select(p_C => p_C.Value)
            .Append(s_ByGuid[p_Primary]));
        var s_Reached = new HashSet<DataContainerBase>(ReferenceEqualityComparer.Instance);
        while (s_Pending.TryPop(out var s_Instance))
        {
            if (!s_Reached.Add(s_Instance))
                continue;

            foreach (var s_Ref in References(s_Instance))
                if (s_Ref.PartitionGuid == p_Scope.Partition && s_Ref.InstanceId is DataContainerId.Guid s_Id && s_ByGuid.TryGetValue(s_Id.Id, out var s_Next))
                    s_Pending.Push(s_Next);
        }

        foreach (var s_Instance in s_ByGuid.Values.Where(p_I => !s_Reached.Contains(p_I)))
            ConversionReport.Count(Report.Unreferenced, s_Instance.GetType().Name);
        return s_Reached;
    }

    /// <summary>The references in an instance's or struct's fields, those of its structs and lists included.</summary>
    private static IEnumerable<CtrRefBase> References(object p_Object) =>
        EbxFields(p_Object.GetType()).SelectMany(p_F => ReferencesIn(p_F.GetValue(p_Object)));

    private static IEnumerable<CtrRefBase> ReferencesIn(object? p_Value) => p_Value switch
    {
        CtrRefBase s_Ref => [s_Ref],
        IList s_List => s_List.Cast<object?>().SelectMany(ReferencesIn),
        EbxSerializable s_Struct => References(s_Struct),
        _ => [],
    };

    /// <summary>
    /// The value at a path of fields, following each reference on the way to its instance in the
    /// partition; none where such a reference is null, and false where one leads out of the partition.
    /// The empty path is the object itself.
    /// </summary>
    private static bool Follow(object p_Object, string p_Path, Scope p_Scope, out object? p_Value)
    {
        p_Value = p_Object;
        foreach (var s_Name in p_Path.Length == 0 ? [] : p_Path.Split('.'))
        {
            if (p_Value is CtrRefBase s_Ref)
            {
                if (s_Ref.IsNull())
                {
                    p_Value = null;
                    return true;
                }

                if (s_Ref.PartitionGuid != p_Scope.Partition || !p_Scope.Sources.TryGetValue(s_Ref.InstanceId, out var s_Instance))
                    return false;
                p_Value = s_Instance;
            }

            var s_Field = p_Value!.GetType().GetProperty(s_Name)
                ?? throw new InvalidDataException($"{p_Value.GetType().Name} has no field {s_Name} on the path {p_Path}");
            p_Value = s_Field.GetValue(p_Value);
        }

        return true;
    }

    private Type? ContainerType(Type p_Source)
    {
        var s_Type = m_Target.FindType(m_Rules.Types.GetValueOrDefault(p_Source.Name, p_Source.Name));
        return s_Type != null && !s_Type.IsAbstract && typeof(DataContainerBase).IsAssignableFrom(s_Type) ? s_Type : null;
    }

    private void CopyFields(object p_Source, object p_Target, Scope p_Scope)
    {
        var s_SourceType = p_Source.GetType();
        var s_Map = Fields(s_SourceType, p_Target.GetType());
        foreach (var s_Missing in s_Map.Missing)
            ConversionReport.Count(Report.MissingFields, s_Missing);

        foreach (var (s_From, s_To) in s_Map.Pairs)
        {
            var s_Value = s_From.GetValue(p_Source);
            var s_Field = $"{s_SourceType.Name}.{s_From.Name}";
            if (s_To == null)
            {
                if (IsDefault(s_Value, s_From.GetValue(Default(s_SourceType))))
                    continue;
                ConversionReport.Count(m_Rules.NamedResources.Contains(s_Field) ? Report.NamedResources : Report.DroppedFields, s_Field);
                continue;
            }

            Set(p_Target, s_To, s_Value, p_Scope, s_Field);
        }

        foreach (var (s_From, s_To) in s_Map.Sourced)
        {
            var s_Field = $"{s_SourceType.Name}.{s_From.Path}";
            if (!Follow(p_Source, s_From.Path, p_Scope, out var s_Value))
                ConversionReport.Count(Report.UnconvertedValues, $"{s_Field}: a reference on the way out of the partition");
            else if (s_Value != null)
                Set(p_Target, s_To, s_From.Map == null ? s_Value : s_From.Map(s_Value), p_Scope, s_Field);
        }
    }

    private void Set(object p_Target, PropertyInfo p_Field, object? p_Value, Scope p_Scope, string p_Name)
    {
        if (TryConvert(p_Value, p_Field.PropertyType, p_Scope, p_Name, out var s_Converted, out var s_Reason))
            p_Field.SetValue(p_Target, s_Converted);
        else
            ConversionReport.Count(Report.UnconvertedValues, $"{p_Name}: {s_Reason}");
    }

    private bool TryConvert(object? p_Value, Type p_Type, Scope p_Scope, string p_Field, out object? p_Result, out string p_Reason)
    {
        p_Reason = "";
        p_Result = null;
        switch (p_Value)
        {
            case null:
                return true;

            case CtrRefBase s_Ref when typeof(CtrRefBase).IsAssignableFrom(p_Type):
                var s_Target = (CtrRefBase)Activator.CreateInstance(p_Type)!;
                if (Resolve(s_Ref, p_Scope, p_Field) is var (s_Partition, s_Instance))
                    s_Target.SetValue(s_Partition, new DataContainerId.Guid(s_Instance));
                p_Result = s_Target;
                return true;

            case IList s_List when ElementType(p_Type) is { } s_ElementType:
                var s_Items = (IList)Activator.CreateInstance(p_Type)!;
                foreach (var s_Item in s_List)
                {
                    if (!TryConvert(s_Item, s_ElementType, p_Scope, p_Field, out var s_Converted, out p_Reason))
                        return false;
                    s_Items.Add(s_Converted);
                }

                p_Result = s_Items;
                return true;

            case Enum s_Enum when p_Type.IsEnum:
                var s_Name = m_Rules.EnumValues.GetValueOrDefault((s_Enum.GetType().Name, s_Enum.ToString()), s_Enum.ToString());
                if (Enum.TryParse(p_Type, s_Name, out p_Result) && Enum.IsDefined(p_Type, p_Result!))
                    return true;
                p_Reason = $"no {p_Type.Name} {s_Enum}";
                return false;

            case EbxSerializable when !typeof(DataContainerBase).IsAssignableFrom(p_Type) && typeof(EbxSerializable).IsAssignableFrom(p_Type) && !p_Type.IsAbstract:
                p_Result = Activator.CreateInstance(p_Type)!;
                CopyFields(p_Value, p_Result, p_Scope);
                return true;

            case EbxSerializable when m_Rules.Unwrap.TryGetValue(p_Value.GetType().Name, out var s_Kept):
                ConversionReport.Count(Report.Unwrapped, $"{p_Field}: {p_Value.GetType().Name}.{s_Kept}");
                var s_Field = p_Value.GetType().GetProperty(s_Kept)
                    ?? throw new InvalidDataException($"{p_Value.GetType().Name} has no field {s_Kept} to keep");
                return TryConvert(s_Field.GetValue(p_Value), p_Type, p_Scope, p_Field, out p_Result, out p_Reason);

            case EbxSerializable when typeof(CtrRefBase).IsAssignableFrom(p_Type) && InstanceType(p_Value.GetType(), p_Type) is { } s_InstanceType:
                var s_Made = (DataContainerBase)Activator.CreateInstance(s_InstanceType)!;
                var s_Guid = Derived(p_Scope.Partition, $"struct/{p_Scope.Inlined.Count}");
                s_Made.InstanceId = new DataContainerId.Guid(s_Guid);
                p_Scope.Inlined.Add(s_Made);
                CopyFields(p_Value, s_Made, p_Scope);
                ConversionReport.Count(Report.StructsMadeInstances, p_Field);

                var s_MadeRef = (CtrRefBase)Activator.CreateInstance(p_Type)!;
                s_MadeRef.SetValue(p_Scope.Partition, s_Made.InstanceId);
                p_Result = s_MadeRef;
                return true;

            case EbxSerializable:
                p_Reason = $"{TypeName(p_Value.GetType())} to {TypeName(p_Type)}";
                return false;

            case IConvertible when p_Type.IsInstanceOfType(p_Value):
            case GUID when p_Type == typeof(GUID):
                p_Result = p_Value;
                return true;

            case IConvertible s_Number when p_Type.IsPrimitive && p_Value.GetType().IsPrimitive:
                try
                {
                    p_Result = System.Convert.ChangeType(s_Number, p_Type);
                    if (Equals(System.Convert.ChangeType(p_Result, p_Value.GetType()), p_Value))
                        return true;
                }
                catch (OverflowException)
                {
                }

                p_Reason = $"{p_Value} out of {p_Type.Name}'s range";
                return false;

            default:
                p_Reason = $"{TypeName(p_Value.GetType())} to {TypeName(p_Type)}";
                return false;
        }
    }

    /// <summary>
    /// The instance type a struct becomes behind a reference of <paramref name="p_Ref"/>'s type: the
    /// target's container type of the struct's name, if the reference can point at it.
    /// </summary>
    private Type? InstanceType(Type p_Struct, Type p_Ref)
    {
        var s_Type = ContainerType(p_Struct);
        var s_Referenced = p_Ref.IsGenericType ? p_Ref.GetGenericArguments()[0] : typeof(DataContainerBase);
        return s_Type != null && s_Referenced.IsAssignableFrom(s_Type) ? s_Type : null;
    }

    /// <summary>Where a reference points in the target: none when it is null or its instance is dropped.</summary>
    private (GUID Partition, GUID Instance)? Resolve(CtrRefBase p_Ref, Scope p_Scope, string p_Field)
    {
        if (p_Ref.IsNull())
            return null;

        if (p_Ref.PartitionGuid == p_Scope.Partition && !p_Scope.Converted.Contains(p_Ref.InstanceId))
        {
            ConversionReport.Count(Report.DroppedReferences, p_Field);
            return null;
        }

        return (p_Ref.PartitionGuid, InstanceGuid(p_Ref.PartitionGuid, p_Ref.InstanceId));
    }

    private static string TypeName(Type p_Type) => p_Type.IsGenericType
        ? $"{p_Type.Name[..p_Type.Name.IndexOf('`')]}<{string.Join(", ", p_Type.GetGenericArguments().Select(TypeName))}>"
        : p_Type.Name;

    /// <summary>The element type of a list field (a struct array, or a reference array, which lists references).</summary>
    private static Type? ElementType(Type p_Type) =>
        p_Type.GetInterfaces().FirstOrDefault(p_I => p_I.IsGenericType && p_I.GetGenericTypeDefinition() == typeof(IList<>))?.GetGenericArguments()[0];

    /// <summary>
    /// Each EBX field of a source type with the target type's field of the same name, unless a rule
    /// sets that one or the field only leads a rule's path; the target's fields rules set, with where
    /// from; and the target's fields set neither way nor derived, by declaring type and field.
    /// </summary>
    private sealed record FieldMap((PropertyInfo Source, PropertyInfo? Target)[] Pairs, (FieldSource Source, PropertyInfo Target)[] Sourced, string[] Missing);

    private FieldMap Fields(Type p_Source, Type p_Target)
    {
        if (m_Fields.TryGetValue((p_Source, p_Target), out var s_Map))
            return s_Map;

        var s_TargetFields = EbxFields(p_Target).ToArray();
        var s_SourceFields = EbxFields(p_Source).ToArray();
        var s_Sourced = s_TargetFields
            .Select(p_F => (Source: FieldRule(p_Source, p_F.Name), Target: p_F))
            .Where(p_F => p_F.Source != null)
            .Select(p_F => (p_F.Source!, p_F.Target))
            .ToArray();
        var s_Set = s_Sourced.Select(p_F => p_F.Target.Name).ToHashSet(StringComparer.Ordinal);
        var s_Heads = s_Sourced.Where(p_F => p_F.Item1.Path.Length > 0).Select(p_F => p_F.Item1.Path.Split('.')[0]).ToHashSet(StringComparer.Ordinal);
        var s_ByName = s_TargetFields.Where(p_F => !s_Set.Contains(p_F.Name)).ToDictionary(p_F => p_F.Name, StringComparer.Ordinal);
        var s_Names = s_SourceFields.Select(p_F => p_F.Name).ToHashSet(StringComparer.Ordinal);

        foreach (var s_Head in s_Heads.Where(p_H => !s_Names.Contains(p_H)))
            throw new InvalidDataException($"{p_Source.Name} has no field {s_Head} that a rule reads");

        m_Fields[(p_Source, p_Target)] = s_Map = new FieldMap(
            s_SourceFields
                .Select(p_F => (p_F, s_ByName.GetValueOrDefault(p_F.Name)))
                .Where(p_F => p_F.Item2 != null || !s_Heads.Contains(p_F.p_F.Name))
                .ToArray(),
            s_Sourced,
            s_ByName.Values.Where(p_F => !s_Names.Contains(p_F.Name))
                .Select(p_F => $"{p_F.DeclaringType!.Name}.{p_F.Name}")
                .Where(p_F => m_Derived == null || !m_Derived.Fields.Contains(p_F))
                .ToArray());
        return s_Map;
    }

    /// <summary>Where a rule sets a target field from on a source type or the nearest of its bases, if one does.</summary>
    private FieldSource? FieldRule(Type p_Source, string p_Field)
    {
        for (var s_Type = p_Source; s_Type != null; s_Type = s_Type.BaseType)
            if (m_Rules.Fields.TryGetValue((s_Type.Name, p_Field), out var s_Rule))
                return s_Rule;
        return null;
    }

    private static IEnumerable<PropertyInfo> EbxFields(Type p_Type) =>
        p_Type.GetProperties(BindingFlags.Public | BindingFlags.Instance)
            .Where(p_P => p_P.CanRead && p_P.CanWrite && p_P.GetCustomAttribute<ContainerFieldAttribute>() != null);

    private object Default(Type p_Type)
    {
        if (!m_Defaults.TryGetValue(p_Type, out var s_Default))
            m_Defaults[p_Type] = s_Default = Activator.CreateInstance(p_Type)!;
        return s_Default;
    }

    private bool IsDefault(object? p_Value, object? p_Default) => p_Value switch
    {
        null => true,
        CtrRefBase s_Ref => s_Ref.IsNull(),
        IList s_List => s_List.Count == 0,
        EbxSerializable when p_Value.GetType() is var s_Type && !typeof(DataContainerBase).IsAssignableFrom(s_Type) =>
            EbxFields(s_Type).All(p_F => IsDefault(p_F.GetValue(p_Value), p_F.GetValue(Default(s_Type)))),
        _ => Equals(p_Value, p_Default),
    };

    private static GUID Derived(GUID p_Partition, string p_Key) =>
        new(new Guid(MD5.HashData(Encoding.UTF8.GetBytes($"{p_Partition}/{p_Key}"))));
}
