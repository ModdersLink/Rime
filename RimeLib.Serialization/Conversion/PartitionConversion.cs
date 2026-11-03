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
/// partition. <see cref="ConversionRules"/> cover the rest: enum values the target names
/// differently and structs it keeps one field of. What the target cannot hold is dropped and
/// counted in <see cref="Report"/>.
/// </summary>
public sealed class PartitionConversion
{
    private readonly IEbxTypeLibrary m_Target;
    private readonly ConversionRules m_Rules;
    private readonly Dictionary<(Type, Type), (PropertyInfo Source, PropertyInfo? Target)[]> m_Fields = new();
    private readonly Dictionary<Type, object> m_Defaults = new();

    public ConversionReport Report { get; } = new();

    public PartitionConversion(IEbxTypeLibrary p_Target, ConversionRules? p_Rules = null)
    {
        m_Target = p_Target;
        m_Rules = p_Rules ?? new ConversionRules();
    }

    /// <summary>A conversion to the target engine's types with the source engine's rules for it, if it has any.</summary>
    public static PartitionConversion Between(EngineType p_Source, EngineType p_Target) => new(
        EngineInterfaceRegistry.Create<IEbxTypeLibrary>(p_Target),
        EngineInterfaceRegistry.IsSupported<IConversionRules>(p_Source)
            ? EngineInterfaceRegistry.Create<IConversionRules>(p_Source).For(p_Target)
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
        var s_Types = p_Source.Instances.ToDictionary(p_I => p_I, p_I => ContainerType(p_I.GetType()), ReferenceEqualityComparer.Instance);
        if (s_Types[p_Source.PrimaryInstance] == null)
            throw new InvalidDataException($"the primary instance's type {p_Source.PrimaryInstance.GetType().Name} has no counterpart");

        var s_Converted = new Dictionary<object, DataContainerBase>(ReferenceEqualityComparer.Instance);
        foreach (var (s_Instance, s_Type) in s_Types)
        {
            Report.Instances++;
            if (s_Type == null)
            {
                ConversionReport.Count(Report.DroppedTypes, s_Instance.GetType().Name);
                continue;
            }

            var s_Target = (DataContainerBase)Activator.CreateInstance(s_Type)!;
            s_Target.InstanceId = new DataContainerId.Guid(InstanceGuid(p_Source.PartitionGuid, ((DataContainerBase)s_Instance).InstanceId));
            s_Converted.Add(s_Instance, s_Target);
        }

        var s_Partition = new Scope(p_Source.PartitionGuid, s_Converted.Keys.Select(p_I => ((DataContainerBase)p_I).InstanceId).ToHashSet());
        foreach (var (s_Source, s_Target) in s_Converted)
            CopyFields(s_Source, s_Target, s_Partition);

        Report.ConvertedInstances += s_Converted.Count;
        return m_Target.CreatePartition(p_Source.Name, p_Source.PartitionGuid,
            InstanceGuid(p_Source.PartitionGuid, p_Source.PrimaryInstance.InstanceId), s_Converted.Values.Concat(s_Partition.Inlined).ToList());
    }

    /// <summary>The partition being converted, the ids of its instances that convert and the instances made of structs.</summary>
    private sealed record Scope(GUID Partition, HashSet<DataContainerId> Converted)
    {
        public List<DataContainerBase> Inlined { get; } = new();
    }

    private Type? ContainerType(Type p_Source)
    {
        var s_Type = m_Target.FindType(p_Source.Name);
        return s_Type != null && !s_Type.IsAbstract && typeof(DataContainerBase).IsAssignableFrom(s_Type) ? s_Type : null;
    }

    private void CopyFields(object p_Source, object p_Target, Scope p_Scope)
    {
        var s_SourceType = p_Source.GetType();
        foreach (var (s_From, s_To) in Fields(s_SourceType, p_Target.GetType()))
        {
            var s_Value = s_From.GetValue(p_Source);
            var s_Field = $"{s_SourceType.Name}.{s_From.Name}";
            if (s_To == null)
            {
                if (!IsDefault(s_Value, s_From.GetValue(Default(s_SourceType))))
                    ConversionReport.Count(Report.DroppedFields, s_Field);
                continue;
            }

            if (TryConvert(s_Value, s_To.PropertyType, p_Scope, s_Field, out var s_Converted, out var s_Reason))
                s_To.SetValue(p_Target, s_Converted);
            else
                ConversionReport.Count(Report.UnconvertedValues, $"{s_Field}: {s_Reason}");
        }
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

    /// <summary>Each EBX field of the source type with the target's field of the same name, if it has one.</summary>
    private (PropertyInfo Source, PropertyInfo? Target)[] Fields(Type p_Source, Type p_Target)
    {
        if (!m_Fields.TryGetValue((p_Source, p_Target), out var s_Fields))
        {
            var s_TargetFields = EbxFields(p_Target).ToDictionary(p_F => p_F.Name, StringComparer.Ordinal);
            m_Fields[(p_Source, p_Target)] = s_Fields = EbxFields(p_Source)
                .Select(p_F => (p_F, s_TargetFields.GetValueOrDefault(p_F.Name)))
                .ToArray();
        }

        return s_Fields;
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
