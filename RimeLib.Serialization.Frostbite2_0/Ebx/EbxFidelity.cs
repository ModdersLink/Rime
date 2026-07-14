using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace RimeLib.Serialization.Frostbite2_0.Ebx;

/// <summary>
/// Exact per-type / per-field descriptor metadata mined from the game's own EBX files
/// ("fidelity_fb2.json", looked up next to the executable). The C# SDK attributes only carry the
/// 32-bit layout (offset/size/alignment); DICE's descriptors additionally carry SecondaryOffset
/// (a second, 64-bit-ish layout) and per-type flag bits (0x80/0x100 region, Blittable, Homogeneous...)
/// that are not derivable via reflection. The engine memory-maps EBX against its compiled type
/// layouts, so generated partitions must reproduce these bytes exactly to be engine-valid.
/// When the map is missing, the writer falls back to reflection-derived values (legacy behavior).
/// </summary>
public static class EbxFidelity
{
    public class FieldRow
    {
        [JsonProperty("flags")] public ushort Flags { get; set; }
        [JsonProperty("offset")] public int Offset { get; set; }
        [JsonProperty("soff")] public int SecondaryOffset { get; set; }
    }

    public class TypeRow
    {
        [JsonProperty("flags")] public ushort Flags { get; set; }
        [JsonProperty("align")] public byte Alignment { get; set; }
        [JsonProperty("size")] public ushort Size { get; set; }
        [JsonProperty("ssize")] public ushort SecondarySize { get; set; }
        [JsonProperty("fields")] public Dictionary<string, FieldRow> Fields { get; set; } = new();
    }

    private class MapFile
    {
        [JsonProperty("types")] public Dictionary<string, TypeRow> Types { get; set; } = new();
        [JsonProperty("arrayMembers")] public Dictionary<string, ushort> ArrayMembers { get; set; } = new();
        [JsonProperty("primitives")] public Dictionary<string, ushort> Primitives { get; set; } = new();
    }

    private static readonly Lazy<MapFile?> s_Map = new(Load);

    public static bool Loaded => s_Map.Value != null;

    private static MapFile? Load()
    {
        foreach (var s_Dir in new[] { AppContext.BaseDirectory, Environment.CurrentDirectory })
        {
            try
            {
                var s_Path = Path.Combine(s_Dir, "fidelity_fb2.json");

                if (!File.Exists(s_Path))
                    continue;

                var s_Loaded = JsonConvert.DeserializeObject<MapFile>(File.ReadAllText(s_Path));

                if (s_Loaded != null)
                {
                    Console.WriteLine($"EBX fidelity map loaded ({s_Loaded.Types.Count} types) from '{s_Path}'.");
                    return s_Loaded;
                }
            }
            catch (Exception s_Ex)
            {
                Console.WriteLine($"Failed loading EBX fidelity map: {s_Ex.Message}");
            }
        }

        Console.WriteLine("EBX fidelity map (fidelity_fb2.json) not found - generated partitions will use reflection-derived descriptor metadata.");
        return null;
    }

    public static TypeRow? GetType(string p_TypeName)
    {
        if (s_Map.Value == null)
            return null;

        return s_Map.Value.Types.TryGetValue(p_TypeName, out var s_Row) ? s_Row : null;
    }

    public static FieldRow? GetField(string p_TypeName, string p_FieldName)
    {
        var s_Type = GetType(p_TypeName);

        if (s_Type == null)
            return null;

        return s_Type.Fields.TryGetValue(p_FieldName, out var s_Row) ? s_Row : null;
    }

    /// <summary>Member-row flags for an array descriptor, keyed "class" / "struct:Name" / "enum:Name" / "prim:code".</summary>
    public static ushort? GetArrayMemberFlags(string p_Key)
    {
        if (s_Map.Value == null)
            return null;

        return s_Map.Value.ArrayMembers.TryGetValue(p_Key, out var s_Flags) ? s_Flags : null;
    }

    /// <summary>Full flag bits for a primitive field of the given FieldType code.</summary>
    public static ushort? GetPrimitiveFlags(int p_FieldTypeCode)
    {
        if (s_Map.Value == null)
            return null;

        return s_Map.Value.Primitives.TryGetValue(p_FieldTypeCode.ToString(), out var s_Flags) ? s_Flags : null;
    }
}
