using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
using RimeLib.IO;

namespace RimeLib.Havok.Frostbite2_0.Packfile;

/// <summary>
/// Reads the objects of a packfile's data section through its fixups: the mirror of
/// <see cref="HkWriter"/>, member for member. Each object is read once, wherever it is pointed at
/// from.
/// </summary>
public sealed class HkReader
{
    private readonly RimeReader m_Reader;
    private readonly IReadOnlyDictionary<int, int> m_LocalFixups;
    private readonly IReadOnlyDictionary<int, int> m_GlobalFixups;
    private readonly IReadOnlyDictionary<int, string> m_Classes;
    private readonly Dictionary<int, HkObject> m_Objects = new();
    private int m_Alignment = 1;

    public int PointerSize { get; }

    /// <param name="p_Data">The data section's objects.</param>
    /// <param name="p_LocalFixups">Where each pointer to data in the section is, and where its data is.</param>
    /// <param name="p_GlobalFixups">Where each pointer to an object is, and where the object is.</param>
    /// <param name="p_Classes">Where each object starts, and its class.</param>
    /// <param name="p_Create">The object of a class, given its offset: Havok 2010's classes unless another version's.</param>
    public HkReader(byte[] p_Data, int p_PointerSize, IReadOnlyDictionary<int, int> p_LocalFixups,
        IReadOnlyDictionary<int, int> p_GlobalFixups, IReadOnlyDictionary<int, string> p_Classes,
        Func<string, int, HkObject>? p_Create = null)
    {
        m_Reader = new RimeReader(new MemoryStream(p_Data));
        PointerSize = p_PointerSize;
        m_LocalFixups = p_LocalFixups;
        m_GlobalFixups = p_GlobalFixups;
        m_Classes = p_Classes;
        m_Create = p_Create ?? ((p_Class, _) => HkClasses.Create(p_Class));
    }

    private readonly Func<string, int, HkObject> m_Create;

    private int Position => (int)m_Reader.Position;

    /// <summary>The object at an offset of the section, read on first use.</summary>
    public HkObject ObjectAt(int p_Offset)
    {
        if (m_Objects.TryGetValue(p_Offset, out var s_Object))
            return s_Object;

        if (!m_Classes.TryGetValue(p_Offset, out var s_Class))
            throw new InvalidDataException($"No object starts at 0x{p_Offset:X} of the data section.");

        s_Object = m_Create(s_Class, p_Offset);
        m_Objects[p_Offset] = s_Object;

        var (s_Resume, s_Alignment) = (m_Reader.Position, m_Alignment);
        m_Reader.Seek(p_Offset, SeekOrigin.Begin);
        m_Alignment = 1;
        s_Object.Read(this);
        m_Reader.Seek(s_Resume, SeekOrigin.Begin);
        m_Alignment = s_Alignment;
        return s_Object;
    }

    public void Align(int p_Alignment)
    {
        m_Alignment = System.Math.Max(m_Alignment, p_Alignment);
        m_Reader.Align(p_Alignment);
    }

    /// <summary>Aligns the next member, for reading it in the same expression.</summary>
    public HkReader AlignedTo(int p_Alignment)
    {
        Align(p_Alignment);
        return this;
    }

    /// <summary>The mirror of <see cref="HkWriter.EndClass"/>.</summary>
    public void EndClass() => m_Reader.Align(m_Alignment);

    public byte ReadByte() => m_Reader.ReadUByte();

    public bool ReadBool() => m_Reader.ReadUByte() switch
    {
        0 => false,
        1 => true,
        var s_Value => throw new InvalidDataException($"A bool of {s_Value} at 0x{Position - 1:X}."),
    };

    public ushort ReadUInt16()
    {
        Align(2);
        return m_Reader.ReadUInt16();
    }

    public uint ReadUInt32()
    {
        Align(4);
        return m_Reader.ReadUInt32();
    }

    public int ReadInt32()
    {
        Align(4);
        return m_Reader.ReadInt32();
    }

    public float ReadSingle()
    {
        Align(4);
        return m_Reader.ReadSingle();
    }

    public Vector4 ReadVector4()
    {
        Align(16);
        return m_Reader.ReadVector4();
    }

    public ulong ReadUlong()
    {
        Align(PointerSize);
        return PointerSize == 8 ? m_Reader.ReadUInt64() : m_Reader.ReadUInt32();
    }

    /// <summary>A pointer the file holds no target for; it has to be zero to be written back as it is.</summary>
    public void SkipPointerSlot()
    {
        var s_At = Position;
        if (ReadUlong() != 0)
            throw new InvalidDataException($"A pointer at 0x{s_At:X} holds a value rather than a fixup.");
    }

    public HkObject? ReadObject()
    {
        Align(PointerSize);
        var s_Slot = Position;
        SkipPointerSlot();
        return m_GlobalFixups.TryGetValue(s_Slot, out var s_Target) ? ObjectAt(s_Target) : null;
    }

    public T? ReadObject<T>() where T : HkObject => ReadObject() switch
    {
        null => null,
        T s_Object => s_Object,
        var s_Other => throw new InvalidDataException($"A {s_Other.ClassName} where a {typeof(T).Name} belongs."),
    };

    public string? ReadString()
    {
        Align(PointerSize);
        var s_Slot = Position;
        SkipPointerSlot();
        if (!m_LocalFixups.TryGetValue(s_Slot, out var s_Target))
            return null;

        var s_Resume = m_Reader.Position;
        m_Reader.Seek(s_Target, SeekOrigin.Begin);
        var s_Value = m_Reader.ReadNullTerminatedString();
        m_Reader.Seek(s_Resume, SeekOrigin.Begin);
        return s_Value;
    }

    /// <summary>The mirror of <see cref="HkWriter.WriteArray{T}"/>; any other capacity than the packfile's own is refused.</summary>
    public List<T> ReadArray<T>(int p_ElementAlignment, Func<HkReader, T> p_ReadElement)
    {
        Align(PointerSize);
        var s_Slot = Position;
        SkipPointerSlot();
        var s_Count = ReadInt32();
        var s_Capacity = ReadInt32();
        if (s_Capacity != (unchecked((int)0x80000000) | s_Count))
            throw new InvalidDataException($"An array at 0x{s_Slot:X} of {s_Count} with capacity 0x{s_Capacity:X8}.");

        var s_Items = new List<T>(s_Count);
        if (s_Count == 0)
            return s_Items;

        if (!m_LocalFixups.TryGetValue(s_Slot, out var s_Target))
            throw new InvalidDataException($"An array at 0x{s_Slot:X} of {s_Count} with no data.");

        var s_Resume = m_Reader.Position;
        m_Reader.Seek(s_Target, SeekOrigin.Begin);
        for (var i = 0; i < s_Count; ++i)
        {
            s_Items.Add(p_ReadElement(this));
            Align(p_ElementAlignment);
        }

        m_Reader.Seek(s_Resume, SeekOrigin.Begin);
        return s_Items;
    }

    public List<T> ReadObjects<T>() where T : HkObject =>
        ReadArray(PointerSize, p_Reader => p_Reader.ReadObject<T>() ?? throw new InvalidDataException("A null pointer in an object array."));
}
