using System.Collections.Generic;
using RimeLib.Frostbite;

namespace RimeLib.Serialization.Conversion;

/// <summary>What converting an engine's partitions to another engine takes beyond names that match.</summary>
public sealed class ConversionRules
{
    /// <summary>Enum values the target names differently: by enum type and source value, the target's value.</summary>
    public IReadOnlyDictionary<(string Enum, string Value), string> EnumValues { get; init; } = new Dictionary<(string, string), string>();

    /// <summary>
    /// Structs where the target keeps one of their fields in their place: by struct type, that
    /// field. The other fields are dropped.
    /// </summary>
    public IReadOnlyDictionary<string, string> Unwrap { get; init; } = new Dictionary<string, string>();
}

/// <summary>An engine's rules for converting its partitions to other engines.</summary>
public interface IConversionRules : IEngineInterface
{
    /// <summary>The rules for converting to <paramref name="p_Target"/>, or none.</summary>
    ConversionRules? For(EngineType p_Target);
}
