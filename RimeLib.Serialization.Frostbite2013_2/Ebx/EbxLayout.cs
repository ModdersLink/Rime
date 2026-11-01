using System.Collections.Concurrent;
using System.Collections.Generic;
using RimeLib.Frostbite.Core;

namespace RimeLib.Serialization.Frostbite2013_2.Ebx;

/// <summary>
/// A type's layout as a partition's descriptors give it: what the writer needs to write instances
/// of that type the way the game wrote them. Types refer to each other by key.
/// </summary>
public class EbxTypeLayout
{
    /// <summary>
    /// The type's name, or for an array type <c>array&lt;member flags:member type&gt;</c>, since every
    /// array descriptor is named "array".
    /// </summary>
    public string Key { get; init; } = "";
    public string Name { get; init; } = "";
    public uint NameHash { get; init; }
    public byte Alignment { get; init; }
    public ushort Flags { get; init; }
    public ushort Size { get; init; }
    public ushort SecondarySize { get; init; }
    public List<EbxFieldLayout> Fields { get; } = new();

    public FieldType Code => (FieldType)((Flags >> 4) & 0x1F);
}

public class EbxFieldLayout
{
    public string Name { get; init; } = "";
    public uint NameHash { get; init; }
    public ushort Flags { get; init; }
    public int Offset { get; init; }
    public int SecondaryOffset { get; init; }

    /// <summary>The key of the type the descriptor points at, or null where it stores index 0 (primitives, references).</summary>
    public string? TypeKey { get; init; }

    public FieldType Code => (FieldType)((Flags >> 4) & 0x1F);
}

/// <summary>
/// Every type layout seen in a parsed partition. The writer takes the layouts of the types it
/// writes from here, so a partition can be written once a partition with the same types was read.
/// </summary>
public static class EbxLayoutLibrary
{
    private static readonly ConcurrentDictionary<string, EbxTypeLayout> m_Layouts = new();

    public static bool TryGet(string p_Key, out EbxTypeLayout p_Layout) => m_Layouts.TryGetValue(p_Key, out p_Layout!);

    /// <summary>Records the layouts of a partition's descriptors (the first layout seen for a key wins).</summary>
    internal static void Register(IReadOnlyList<TypeDescriptor> p_Types, IReadOnlyList<FieldDescriptor> p_Fields)
    {
        var s_Keys = new string?[p_Types.Count];

        // The field that uses each array type first, as "Owner.Field": enum arrays don't name their
        // enum (member type 0), and the game keeps one such array type per enum.
        var s_Users = new Dictionary<int, string>();
        foreach (var s_Owner in p_Types)
        {
            for (var f = s_Owner.LayoutDescriptor; f < s_Owner.LayoutDescriptor + s_Owner.FieldCount && f < p_Fields.Count; ++f)
            {
                var s_Field = p_Fields[(int)f];
                if ((FieldType)((s_Field.RawFlags >> 4) & 0x1F) == FieldType.Array)
                    s_Users.TryAdd(s_Field.FieldType, $"{s_Owner.Name}.{s_Field.Name}");
            }
        }

        string Key(int p_Index)
        {
            if (s_Keys[p_Index] is { } s_Known)
                return s_Known;

            var s_Type = p_Types[p_Index];
            if (s_Type.Name != "array")
                return s_Keys[p_Index] = s_Type.Name;

            // Guard against a self-referencing array while its member is resolved.
            s_Keys[p_Index] = "array<?>";
            var s_Member = p_Fields[(int)s_Type.LayoutDescriptor];
            var s_MemberKey = MemberKey(s_Member);
            if (s_MemberKey == null && (FieldType)((s_Member.RawFlags >> 4) & 0x1F) == FieldType.Enum && s_Users.TryGetValue(p_Index, out var s_User))
                s_MemberKey = "@" + s_User;
            return s_Keys[p_Index] = $"array<{s_Member.RawFlags:x4}:{s_MemberKey}>";
        }

        // The type a field's descriptor points at: always for bases, structs, arrays and enums;
        // for others only when it isn't index 0 (references to a specific type).
        string? MemberKey(FieldDescriptor p_Field)
        {
            var s_Code = (FieldType)((p_Field.RawFlags >> 4) & 0x1F);
            if (p_Field.FieldType >= p_Types.Count)
                return null;
            return s_Code is FieldType.Void or FieldType.ValueType or FieldType.Array or FieldType.Enum || p_Field.FieldType != 0
                ? Key(p_Field.FieldType)
                : null;
        }

        for (var i = 0; i < p_Types.Count; ++i)
        {
            var s_Key = Key(i);
            if (m_Layouts.ContainsKey(s_Key))
                continue;

            var s_Type = p_Types[i];
            var s_Layout = new EbxTypeLayout
            {
                Key = s_Key,
                Name = s_Type.Name,
                NameHash = s_Type.NameHash,
                Alignment = s_Type.Alignment,
                Flags = s_Type.RawFlags,
                Size = s_Type.Size,
                SecondarySize = s_Type.SecondarySize,
            };

            for (var f = s_Type.LayoutDescriptor; f < s_Type.LayoutDescriptor + s_Type.FieldCount && f < p_Fields.Count; ++f)
            {
                var s_Field = p_Fields[(int)f];
                s_Layout.Fields.Add(new EbxFieldLayout
                {
                    Name = s_Field.Name,
                    NameHash = s_Field.NameHash,
                    Flags = s_Field.RawFlags,
                    Offset = s_Field.Offset,
                    SecondaryOffset = s_Field.SecondaryOffset,
                    TypeKey = MemberKey(s_Field),
                });
            }

            m_Layouts.TryAdd(s_Key, s_Layout);
        }
    }
}
