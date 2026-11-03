using System;
using System.Collections.Generic;
using RimeLib.Frostbite;

namespace RimeLib.Serialization.Conversion;

/// <summary>What converting an engine's partitions to another engine takes beyond names that match.</summary>
public sealed class ConversionRules
{
    /// <summary>Types the target names differently: by source type, the target's.</summary>
    public IReadOnlyDictionary<string, string> Types { get; init; } = new Dictionary<string, string>();

    /// <summary>
    /// Target fields set from another source field than the one of the same name: by the source type
    /// (or a base) and target field, where the value comes from.
    /// </summary>
    public IReadOnlyDictionary<(string Type, string Field), FieldSource> Fields { get; init; } = new Dictionary<(string, string), FieldSource>();

    /// <summary>
    /// Partitions whose primary instance is another one in the target: by the source primary's type,
    /// the path to the reference to it.
    /// </summary>
    public IReadOnlyDictionary<string, string> Primary { get; init; } = new Dictionary<string, string>();

    /// <summary>Enum values the target names differently: by enum type and source value, the target's value.</summary>
    public IReadOnlyDictionary<(string Enum, string Value), string> EnumValues { get; init; } = new Dictionary<(string, string), string>();

    /// <summary>
    /// Structs where the target keeps one of their fields in their place: by struct type, that
    /// field. The other fields are dropped.
    /// </summary>
    public IReadOnlyDictionary<string, string> Unwrap { get; init; } = new Dictionary<string, string>();

    /// <summary>
    /// Resource references, by type and field, that the target has no field for because it finds
    /// the resource by the partition's name, which the source's resource has.
    /// </summary>
    public IReadOnlySet<string> NamedResources { get; init; } = new HashSet<string>();
}

/// <summary>
/// Where a target field's value comes from: a path of source fields separated by dots (empty for the
/// source instance itself), a reference on the way followed to its instance in the partition, and
/// what the value at its end becomes.
/// </summary>
public sealed record FieldSource(string Path, Func<object, object>? Map = null);

/// <summary>An engine's rules for converting its partitions to other engines.</summary>
public interface IConversionRules : IEngineInterface
{
    /// <summary>The rules for converting to <paramref name="p_Target"/>, or none.</summary>
    ConversionRules? For(EngineType p_Target);
}
