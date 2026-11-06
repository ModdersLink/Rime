using RimeLib.Animation.EA.Reflection;
using RimeLib.Frostbite;
using RimeLib.IO;
using RimeLib.IO.Conversion;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Text;

namespace RimeLib.Animation.EA.GenericData
{
    /// <summary>
    /// The payload of a data blob: an object at its start and everything it points at. A pointer
    /// is a 64-bit payload offset; a string or an array is a 32-bit capacity, a 32-bit count and a
    /// pointer, a string's count taking its NUL.
    ///
    /// What an object points at follows it in field order, depth first: a field's string, array or
    /// referenced object where the field is reached, an array's elements' own data after the whole
    /// array, element by element. Objects are aligned to eight bytes or their layout's alignment,
    /// arrays to their element's, strings not at all; an array ends with its last element's data,
    /// not its stride. The relocation table lists the pointers as they are written.
    /// </summary>
    public sealed class DataBlob : IFbSerializable
    {
        public Reflection Reflection { get; set; }

        public Instance? Root { get; set; }

        private RimeWriter? m_Writer;
        private List<uint> m_Pointers = new();

        public DataBlob(Reflection p_Reflection)
        {
            Reflection = p_Reflection;
        }

        public DataBlob(Reflection p_Reflection, Instance p_Root)
        {
            Reflection = p_Reflection;
            Root = p_Root;
        }

        /// <summary>The blob holding this payload.</summary>
        public RelocatableBlob ToBlob(bool p_BigEndian)
        {
            var s_Payload = Payload(p_BigEndian ? Endianness.BigEndian : Endianness.LittleEndian, out var s_Pointers);
            return new RelocatableBlob(GenericDataBlobType.Data, p_BigEndian, s_Payload, s_Pointers);
        }

        /// <summary>Writes the payload and its relocation table, as a data blob holds them.</summary>
        public bool Serialize(RimeWriter p_Writer)
        {
            p_Writer.Write(ToBlob(p_Writer.Endianness == Endianness.BigEndian).Data);
            return true;
        }

        public void Deserialize(RimeReader p_Reader)
        {
            Root = ReadObject(p_Reader, 0);
        }

        private static long Align(long p_Value, long p_Alignment) => p_Alignment <= 1 ? p_Value : (p_Value + p_Alignment - 1) & ~(p_Alignment - 1);

        /// <summary>The distance between an array's elements of a field's type.</summary>
        private static long Stride(EntryHeader p_Field) => Align(p_Field.Layout!.DataSize, p_Field.Layout.Alignment);

        /// <summary>The distance between a fixed-size array's elements.</summary>
        private static long FixedStride(EntryHeader p_Field) => Align(p_Field.ElementSize, p_Field.ElementAlign);

        private static bool Skipped(EntryHeader p_Field) => p_Field.Count == 0 || p_Field.Layout == null;

        private Instance ReadObject(RimeReader p_Reader, long p_Offset)
        {
            p_Reader.Seek(p_Offset, SeekOrigin.Begin);
            var s_Header = new Data(p_Reader);

            var s_Layout = Reflection.ByHash(s_Header.LayoutHash)
                ?? throw new InvalidDataException($"No layout for hash {s_Header.LayoutHash:X08}.");

            var s_Instance = new Instance(s_Layout, s_Header);
            ReadFields(p_Reader, s_Instance, p_Offset + s_Header.DataOffset);
            return s_Instance;
        }

        private void ReadFields(RimeReader p_Reader, Instance p_Instance, long p_Offset)
        {
            var s_Fields = p_Instance.Layout.Fields;

            for (var i = 0; i < s_Fields.Length; i++)
            {
                var s_Field = s_Fields[i];
                if (Skipped(s_Field))
                    continue;

                var s_Position = p_Offset + s_Field.Offset;

                if (s_Field.IsArray)
                {
                    p_Reader.Seek(s_Position, SeekOrigin.Begin);
                    var s_Capacity = p_Reader.ReadUInt32();
                    var s_Count = p_Reader.ReadUInt32();
                    var s_Pointer = (long)p_Reader.ReadUInt64();

                    if (s_Capacity != s_Count || s_Count > p_Reader.Length || s_Pointer > p_Reader.Length)
                        throw new InvalidDataException($"{p_Instance.Layout.Name}.{s_Field.Name}: array of {s_Count} in {s_Capacity} at 0x{s_Pointer:X}.");

                    var s_List = new List<object?>((int)s_Count);
                    for (var k = 0; k < s_Count; k++)
                        s_List.Add(ReadElement(p_Reader, s_Field, s_Pointer + k * Stride(s_Field)));

                    p_Instance.Values[i] = s_List;
                }
                else if (s_Field.Count > 1)
                {
                    var s_List = new List<object?>(s_Field.Count);
                    for (var k = 0; k < s_Field.Count; k++)
                        s_List.Add(ReadElement(p_Reader, s_Field, s_Position + k * FixedStride(s_Field)));

                    p_Instance.Values[i] = s_List;
                }
                else
                {
                    p_Instance.Values[i] = ReadElement(p_Reader, s_Field, s_Position);
                }
            }
        }

        private object? ReadElement(RimeReader p_Reader, EntryHeader p_Field, long p_Position)
        {
            p_Reader.Seek(p_Position, SeekOrigin.Begin);

            switch ((LayoutType)p_Field.LayoutHash)
            {
                case LayoutType.Bool:
                case LayoutType.UInt8: return p_Reader.ReadUByte();
                case LayoutType.Int8: return p_Reader.ReadSByte();
                case LayoutType.Int16: return p_Reader.ReadInt16();
                case LayoutType.UInt16: return p_Reader.ReadUInt16();
                case LayoutType.Int32: return p_Reader.ReadInt32();
                case LayoutType.UInt32: return p_Reader.ReadUInt32();
                case LayoutType.Int64: return p_Reader.ReadInt64();
                case LayoutType.UInt64: return p_Reader.ReadUInt64();
                case LayoutType.Float: return p_Reader.ReadSingle();
                case LayoutType.Double: return p_Reader.ReadDouble();

                case LayoutType.Guid:
                    return new Guid(p_Reader.ReadInt32(), p_Reader.ReadInt16(), p_Reader.ReadInt16(), p_Reader.ReadBytes(8));

                case LayoutType.String:
                {
                    var s_Capacity = p_Reader.ReadUInt32();
                    var s_Count = p_Reader.ReadUInt32();
                    var s_Pointer = (long)p_Reader.ReadUInt64();

                    if (s_Pointer == 0)
                        return null;

                    if (s_Capacity != s_Count || s_Count == 0 || s_Pointer + s_Count > p_Reader.Length)
                        throw new InvalidDataException($"{p_Field.Name}: string of {s_Count} in {s_Capacity} at 0x{s_Pointer:X}.");

                    p_Reader.Seek(s_Pointer, SeekOrigin.Begin);
                    var s_Bytes = p_Reader.ReadBytes((int)s_Count);
                    return Encoding.Latin1.GetString(s_Bytes, 0, s_Bytes.Length - 1);
                }

                case LayoutType.DataRef:
                {
                    var s_Pointer = (long)p_Reader.ReadUInt64();
                    return s_Pointer == 0 ? null : ReadObject(p_Reader, s_Pointer);
                }
            }

            if (p_Field.Layout!.IsBasicField)
                throw new InvalidDataException($"{p_Field.Name}: basic type {p_Field.LayoutHash} is not read.");

            var s_Struct = new Instance(p_Field.Layout, null);
            ReadFields(p_Reader, s_Struct, p_Position);
            return s_Struct;
        }

        /// <summary>The payload and the offsets of its pointers.</summary>
        public byte[] Payload(Endianness p_Endianness, out List<uint> p_Pointers)
        {
            if (Root == null)
                throw new InvalidOperationException("A data blob without an object.");

            using var s_Stream = new MemoryStream();
            using var s_Writer = new RimeWriter(s_Stream, p_Endianness);

            m_Writer = s_Writer;
            m_Pointers = new List<uint>();

            WriteObject(Root);

            p_Pointers = m_Pointers;
            m_Writer = null;

            s_Writer.Flush();
            return s_Stream.ToArray();
        }

        /// <summary>Appends zeros up to an alignment and then a block of a size; where the block starts.</summary>
        private long Reserve(long p_Alignment, long p_Size)
        {
            var s_Writer = m_Writer!;
            s_Writer.Seek(0, SeekOrigin.End);

            var s_Start = Align(s_Writer.Position, p_Alignment);
            s_Writer.WriteNullBytes((uint)(s_Start - s_Writer.Position + p_Size));
            return s_Start;
        }

        private long WriteObject(Instance p_Instance)
        {
            var s_Layout = p_Instance.Layout;
            var s_Header = p_Instance.Header ?? new Data();
            s_Header.LayoutHash = s_Layout.Hash;
            s_Header.DataOffset = (uint)Align(Data.c_Size, System.Math.Max(1, s_Layout.Alignment));

            var s_Start = Reserve(System.Math.Max(8, s_Layout.Alignment), s_Header.DataOffset + s_Layout.DataSize);

            m_Writer!.Seek(s_Start, SeekOrigin.Begin);
            s_Header.Serialize(m_Writer);

            WriteInline(p_Instance, s_Start + s_Header.DataOffset);
            WriteDeferred(p_Instance, s_Start + s_Header.DataOffset);
            return s_Start;
        }

        /// <summary>The values that sit in the instance itself.</summary>
        private void WriteInline(Instance p_Instance, long p_Offset)
        {
            var s_Fields = p_Instance.Layout.Fields;

            for (var i = 0; i < s_Fields.Length; i++)
            {
                var s_Field = s_Fields[i];
                if (Skipped(s_Field) || s_Field.IsArray)
                    continue;

                var s_Position = p_Offset + s_Field.Offset;

                if (s_Field.Count > 1)
                {
                    var s_List = (List<object?>)p_Instance.Values[i]!;
                    if (s_List.Count != s_Field.Count)
                        throw new InvalidDataException($"{p_Instance.Layout.Name}.{s_Field.Name}: {s_List.Count} values for {s_Field.Count}.");

                    for (var k = 0; k < s_List.Count; k++)
                        WriteElement(s_Field, s_Position + k * FixedStride(s_Field), s_List[k]);
                }
                else
                {
                    WriteElement(s_Field, s_Position, p_Instance.Values[i]);
                }
            }
        }

        private void WriteElement(EntryHeader p_Field, long p_Position, object? p_Value)
        {
            var s_Writer = m_Writer!;
            s_Writer.Seek(p_Position, SeekOrigin.Begin);

            switch ((LayoutType)p_Field.LayoutHash)
            {
                case LayoutType.Bool:
                case LayoutType.UInt8: s_Writer.Write(Convert.ToByte(p_Value)); return;
                case LayoutType.Int8: s_Writer.Write(Convert.ToSByte(p_Value)); return;
                case LayoutType.Int16: s_Writer.Write(Convert.ToInt16(p_Value)); return;
                case LayoutType.UInt16: s_Writer.Write(Convert.ToUInt16(p_Value)); return;
                case LayoutType.Int32: s_Writer.Write(Convert.ToInt32(p_Value)); return;
                case LayoutType.UInt32: s_Writer.Write(Convert.ToUInt32(p_Value)); return;
                case LayoutType.Int64: s_Writer.Write(Convert.ToInt64(p_Value)); return;
                case LayoutType.UInt64: s_Writer.Write(Convert.ToUInt64(p_Value)); return;
                case LayoutType.Float: s_Writer.Write(Convert.ToSingle(p_Value)); return;
                case LayoutType.Double: s_Writer.Write(Convert.ToDouble(p_Value)); return;

                case LayoutType.Guid:
                {
                    var s_Bytes = ((Guid)p_Value!).ToByteArray();
                    s_Writer.Write(EndianBitConverter.Little.ToInt32(s_Bytes, 0));
                    s_Writer.Write(EndianBitConverter.Little.ToInt16(s_Bytes, 4));
                    s_Writer.Write(EndianBitConverter.Little.ToInt16(s_Bytes, 6));
                    s_Writer.Write(s_Bytes[8..]);
                    return;
                }

                case LayoutType.String:
                case LayoutType.DataRef:
                    return;
            }

            if (p_Field.Layout!.IsBasicField)
                throw new InvalidDataException($"{p_Field.Name}: basic type {p_Field.LayoutHash} is not written.");

            WriteInline((Instance)p_Value!, p_Position);
        }

        /// <summary>What the instance points at: strings, arrays and referenced objects.</summary>
        private void WriteDeferred(Instance p_Instance, long p_Offset)
        {
            var s_Fields = p_Instance.Layout.Fields;

            for (var i = 0; i < s_Fields.Length; i++)
            {
                var s_Field = s_Fields[i];
                if (Skipped(s_Field))
                    continue;

                var s_Position = p_Offset + s_Field.Offset;

                if (s_Field.IsArray)
                {
                    var s_List = (List<object?>)p_Instance.Values[i]!;
                    if (s_List.Count == 0)
                        continue;

                    var s_Stride = Stride(s_Field);
                    var s_Start = Reserve(s_Field.Layout!.Alignment, (s_List.Count - 1) * s_Stride + s_Field.Layout.DataSize);

                    m_Writer!.Seek(s_Position, SeekOrigin.Begin);
                    m_Writer.Write((uint)s_List.Count);
                    m_Writer.Write((uint)s_List.Count);
                    m_Writer.Write((ulong)s_Start);
                    m_Pointers.Add((uint)(s_Position + 8));

                    for (var k = 0; k < s_List.Count; k++)
                        WriteElement(s_Field, s_Start + k * s_Stride, s_List[k]);

                    for (var k = 0; k < s_List.Count; k++)
                        WriteDeferredElement(s_Field, s_Start + k * s_Stride, s_List[k]);
                }
                else if (s_Field.Count > 1)
                {
                    var s_List = (List<object?>)p_Instance.Values[i]!;
                    for (var k = 0; k < s_List.Count; k++)
                        WriteDeferredElement(s_Field, s_Position + k * FixedStride(s_Field), s_List[k]);
                }
                else
                {
                    WriteDeferredElement(s_Field, s_Position, p_Instance.Values[i]);
                }
            }
        }

        private void WriteDeferredElement(EntryHeader p_Field, long p_Position, object? p_Value)
        {
            if (p_Value == null)
                return;

            switch ((LayoutType)p_Field.LayoutHash)
            {
                case LayoutType.String:
                {
                    var s_Bytes = Encoding.Latin1.GetBytes((string)p_Value);
                    var s_Start = Reserve(1, s_Bytes.Length + 1);

                    m_Writer!.Seek(s_Start, SeekOrigin.Begin);
                    m_Writer.Write(s_Bytes);

                    m_Writer.Seek(p_Position, SeekOrigin.Begin);
                    m_Writer.Write((uint)s_Bytes.Length + 1);
                    m_Writer.Write((uint)s_Bytes.Length + 1);
                    m_Writer.Write((ulong)s_Start);
                    m_Pointers.Add((uint)(p_Position + 8));
                    return;
                }

                case LayoutType.DataRef:
                {
                    m_Pointers.Add((uint)p_Position);
                    var s_Start = WriteObject((Instance)p_Value);

                    m_Writer!.Seek(p_Position, SeekOrigin.Begin);
                    m_Writer.Write((ulong)s_Start);
                    return;
                }
            }

            if (p_Value is Instance s_Struct)
                WriteDeferred(s_Struct, p_Position);
        }

        public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
        {
            var s_Stream = new MemoryStream();
            using var s_Writer = new RimeWriter(s_Stream);

            if (Serialize(s_Writer))
            {
                p_Data = s_Stream.ToArray();
                return true;
            }

            p_Data = null;
            return false;
        }

        public void Deserialize(byte[] p_Data)
        {
            using var s_Reader = new RimeReader(new MemoryStream(p_Data));
            Deserialize(s_Reader);
        }
    }
}
