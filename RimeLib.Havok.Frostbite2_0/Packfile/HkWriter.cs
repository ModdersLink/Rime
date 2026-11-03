using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
using RimeLib.IO;

namespace RimeLib.Havok.Frostbite2_0.Packfile;

/// <summary>
/// Writes the objects of a packfile's data section the way Havok 2010's packfile writer lays them
/// out: each object 16-aligned and padded to its own alignment, followed by the data its arrays and
/// strings point at (array data 16-aligned, strings where they fall, padded to 16 after; all of it
/// padded to 16), followed
/// by the objects it points at, depth first. Pointers are written as zero and recorded as fixups.
/// </summary>
public sealed class HkWriter
{
    private readonly MemoryStream m_Stream = new();
    private readonly RimeWriter m_Writer;
    private readonly Dictionary<HkObject, int> m_Offsets = new(ReferenceEqualityComparer.Instance);

    private Queue<Action> m_Blocks = new();
    /// <summary>
    /// The pointers of the object being written, where each is and what it points to, in member
    /// order: an array's elements' are a group in the array's place, filled when its data is
    /// written. Havok lists the global fixups, and writes the objects reached, in this order.
    /// </summary>
    private List<object> m_Children = [];
    private int m_Alignment;

    public int PointerSize { get; }

    /// <summary>Pointers to data in the section: where each pointer is, and where its data is.</summary>
    public List<(int Source, int Target)> LocalFixups { get; } = [];

    /// <summary>Pointers to objects: where each pointer is, and the object.</summary>
    public List<(int Source, HkObject Target)> GlobalFixups { get; } = [];

    /// <summary>The objects in the order written, where each starts.</summary>
    public List<(int Offset, HkObject Object)> Objects { get; } = [];

    public HkWriter(int p_PointerSize)
    {
        PointerSize = p_PointerSize;
        m_Writer = new RimeWriter(m_Stream, p_ShouldDispose: false);
    }

    public int Position => (int)m_Writer.Position;

    public int OffsetOf(HkObject p_Object) => m_Offsets[p_Object];

    public byte[] ToArray() => m_Stream.ToArray();

    /// <summary>Writes the object, its data and every object it reaches that is not written yet.</summary>
    public void WriteTree(HkObject p_Object)
    {
        if (m_Offsets.ContainsKey(p_Object))
            return;

        var (s_Blocks, s_Children, s_Alignment) = (m_Blocks, m_Children, m_Alignment);
        (m_Blocks, m_Children, m_Alignment) = (new Queue<Action>(), [], 1);

        Pad(16);
        m_Offsets[p_Object] = Position;
        Objects.Add((Position, p_Object));

        p_Object.Write(this);
        Pad(m_Alignment);

        // The object's data starts 16-aligned; each block of it is padded to 16 after its own data.
        if (m_Blocks.Count > 0)
            Pad(16);
        DrainBlocks();
        Pad(16);

        var s_Pointers = Flattened(m_Children);
        GlobalFixups.AddRange(s_Pointers);
        (m_Blocks, m_Children, m_Alignment) = (s_Blocks, s_Children, s_Alignment);

        foreach (var (_, s_Child) in s_Pointers)
            WriteTree(s_Child);
    }

    private void DrainBlocks()
    {
        while (m_Blocks.TryDequeue(out var s_Block))
            s_Block();
    }

    private static List<(int Source, HkObject Target)> Flattened(List<object> p_Children)
    {
        var s_Pointers = new List<(int, HkObject)>();
        foreach (var s_Child in p_Children)
        {
            if (s_Child is ValueTuple<int, HkObject> s_Pointer)
                s_Pointers.Add(s_Pointer);
            else
                s_Pointers.AddRange(Flattened((List<object>)s_Child));
        }

        return s_Pointers;
    }

    /// <summary>Aligns the next member to <paramref name="p_Alignment"/> within the object.</summary>
    public void Align(int p_Alignment)
    {
        m_Alignment = System.Math.Max(m_Alignment, p_Alignment);
        Pad(p_Alignment);
    }

    /// <summary>
    /// Ends a class's members: pads to the largest alignment of the object so far, as a derived
    /// class's members start after its base class's size.
    /// </summary>
    public void EndClass() => Pad(m_Alignment);

    private void Pad(int p_Alignment)
    {
        while (Position % p_Alignment != 0)
            m_Writer.Write((byte)0);
    }

    public void Write(byte p_Value) => m_Writer.Write(p_Value);

    public void Write(bool p_Value) => m_Writer.Write(p_Value ? (byte)1 : (byte)0);

    public void Write(ushort p_Value)
    {
        Align(2);
        m_Writer.Write(p_Value);
    }

    public void Write(uint p_Value)
    {
        Align(4);
        m_Writer.Write(p_Value);
    }

    public void Write(int p_Value)
    {
        Align(4);
        m_Writer.Write(p_Value);
    }

    public void Write(float p_Value)
    {
        Align(4);
        m_Writer.Write(p_Value);
    }

    public void Write(Vector4 p_Value)
    {
        Align(16);
        m_Writer.Write(p_Value);
    }

    /// <summary>A pointer-sized integer, as hkUlong is.</summary>
    public void WriteUlong(ulong p_Value)
    {
        Align(PointerSize);
        if (PointerSize == 8)
            m_Writer.Write(p_Value);
        else
            m_Writer.Write((uint)p_Value);
    }

    /// <summary>A pointer the file holds no target for, such as a virtual table pointer.</summary>
    public void WritePointerSlot() => WriteUlong(0);

    /// <summary>A pointer to an object, which is written after this one's data unless it already is.</summary>
    public void WriteObject(HkObject? p_Object)
    {
        Align(PointerSize);
        if (p_Object != null)
            m_Children.Add((Position, p_Object));

        WritePointerSlot();
    }

    /// <summary>An hkStringPtr: a pointer to the string, written after the object's other data so far.</summary>
    public void WriteString(string? p_Value)
    {
        Align(PointerSize);
        var s_Slot = Position;
        WritePointerSlot();

        if (p_Value == null)
            return;

        m_Blocks.Enqueue(() =>
        {
            LocalFixups.Add((s_Slot, Position));
            m_Writer.WriteNullTerminatedString(p_Value);
            Pad(16);
        });
    }

    /// <summary>
    /// An hkArray: its pointer, size and capacity with the flag that the packfile owns the memory,
    /// and its elements, written after the object's data so far, each padded to
    /// <paramref name="p_ElementAlignment"/>, then what they point to, then padding to 16.
    /// </summary>
    public void WriteArray<T>(IReadOnlyList<T> p_Items, int p_ElementAlignment, Action<HkWriter, T> p_WriteElement)
    {
        Align(PointerSize);
        var s_Slot = Position;
        WritePointerSlot();
        Write(p_Items.Count);
        Write(unchecked((int)0x80000000) | p_Items.Count);

        if (p_Items.Count == 0)
            return;

        var s_Group = new List<object>();
        m_Children.Add(s_Group);
        m_Blocks.Enqueue(() =>
        {
            var (s_OuterChildren, s_OuterBlocks) = (m_Children, m_Blocks);
            (m_Children, m_Blocks) = (s_Group, new Queue<Action>());
            LocalFixups.Add((s_Slot, Position));
            foreach (var s_Item in p_Items)
            {
                p_WriteElement(this, s_Item);
                Pad(p_ElementAlignment);
            }

            // What the elements point to follows them, before the array's padding.
            DrainBlocks();
            Pad(16);
            (m_Children, m_Blocks) = (s_OuterChildren, s_OuterBlocks);
        });
    }

    public void WriteObjects<T>(IReadOnlyList<T> p_Objects) where T : HkObject =>
        WriteArray(p_Objects, PointerSize, (p_Writer, p_Object) => p_Writer.WriteObject(p_Object));
}
