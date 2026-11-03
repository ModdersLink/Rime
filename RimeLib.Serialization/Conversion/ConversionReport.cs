using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace RimeLib.Serialization.Conversion;

/// <summary>What converting partitions to another engine lost, counted by what it was.</summary>
public sealed class ConversionReport
{
    /// <summary>Instances of a type the target does not have, by type.</summary>
    public SortedDictionary<string, int> DroppedTypes { get; } = new();

    /// <summary>Values other than the default in a field the target type does not have, by type and field.</summary>
    public SortedDictionary<string, int> DroppedFields { get; } = new();

    /// <summary>Fields of the target type the source type does not have, left at their default, by declaring type and field.</summary>
    public SortedDictionary<string, int> MissingFields { get; } = new();

    /// <summary>Resource references the target makes by the partition's name instead, by type and field.</summary>
    public SortedDictionary<string, int> NamedResources { get; } = new();

    /// <summary>Values the target field cannot hold, by type, field and why.</summary>
    public SortedDictionary<string, int> UnconvertedValues { get; } = new();

    /// <summary>Structs whose field the target makes a reference, made instances, by type and field.</summary>
    public SortedDictionary<string, int> StructsMadeInstances { get; } = new();

    /// <summary>Structs of which the target keeps one field, by type, field and the field kept.</summary>
    public SortedDictionary<string, int> Unwrapped { get; } = new();

    /// <summary>Fields the target's build derives that could not be derived as it does, by type, field and why.</summary>
    public SortedDictionary<string, int> Underived { get; } = new();

    /// <summary>References to a dropped instance, by type and field.</summary>
    public SortedDictionary<string, int> DroppedReferences { get; } = new();

    public int Instances { get; set; }
    public int ConvertedInstances { get; set; }

    /// <summary>Counts one more of <paramref name="p_Key"/> in a category.</summary>
    public static void Count(IDictionary<string, int> p_Counts, string p_Key) =>
        p_Counts[p_Key] = p_Counts.TryGetValue(p_Key, out var s_Count) ? s_Count + 1 : 1;

    /// <summary>Writes each category, most frequent first, up to <paramref name="p_Top"/> entries each.</summary>
    public void WriteTo(TextWriter p_Writer, int p_Top)
    {
        p_Writer.WriteLine($"{ConvertedInstances}/{Instances} instance(s) converted.");
        Write(p_Writer, "Types the target does not have", DroppedTypes, p_Top);
        Write(p_Writer, "Fields the target does not have, with a value set", DroppedFields, p_Top);
        Write(p_Writer, "Fields the source does not have, left at the target's default", MissingFields, p_Top);
        Write(p_Writer, "Resources the target finds by the partition's name instead", NamedResources, p_Top);
        Write(p_Writer, "Values the target field cannot hold", UnconvertedValues, p_Top);
        Write(p_Writer, "Fields the target derives that could not be derived", Underived, p_Top);
        Write(p_Writer, "References to a dropped instance", DroppedReferences, p_Top);
        Write(p_Writer, "Structs made instances, as the target references them", StructsMadeInstances, p_Top);
        Write(p_Writer, "Structs the target keeps one field of", Unwrapped, p_Top);
    }

    private static void Write(TextWriter p_Writer, string p_Title, IReadOnlyDictionary<string, int> p_Counts, int p_Top)
    {
        if (p_Counts.Count == 0)
            return;

        p_Writer.WriteLine($"{p_Title}: {p_Counts.Count} kind(s), {p_Counts.Values.Sum()} in all");
        foreach (var (s_Key, s_Count) in p_Counts.OrderByDescending(p_C => p_C.Value).ThenBy(p_C => p_C.Key).Take(p_Top))
            p_Writer.WriteLine($"  {s_Count,8}  {s_Key}");
    }
}
