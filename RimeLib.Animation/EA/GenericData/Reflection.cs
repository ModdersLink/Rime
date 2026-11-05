using RimeLib.Animation.EA.Reflection;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using RimeLib.IO.Conversion;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;

namespace RimeLib.Animation.EA.GenericData
{
    public class Reflection : IFbSerializable
    {

        public LayoutHeader[] Layouts { get; set; } = new LayoutHeader[0];


        public Reflection()
        {
        }

        public Reflection(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }

        /// <summary>The layout of a hash; null where the reflection has none.</summary>
        public LayoutHeader? ByHash(uint p_Hash) => Layouts.FirstOrDefault(p_Layout => p_Layout.Hash == p_Hash);

        /// <summary>
        /// The payload of a reflection blob and the offsets of its pointers: the layout count, a
        /// pointer to each layout in hash order, then the layouts, each at eight bytes, their fields
        /// pointing at the layouts of their types.
        /// </summary>
        public byte[] Payload(Endianness p_Endianness, out List<uint> p_Pointers)
        {
            Array.Sort(Layouts, (p_X, p_Y) => p_X.Hash.CompareTo(p_Y.Hash));

            var s_Position = 8L + 8L * Layouts.Length;
            foreach (var s_Layout in Layouts)
            {
                s_Layout.Position = s_Position;
                s_Position = (s_Position + s_Layout.SerializedSize + 7) & ~7L;
            }

            p_Pointers = new List<uint>();

            using var s_Stream = new MemoryStream();
            using var s_Writer = new RimeWriter(s_Stream, p_Endianness);

            s_Writer.Write((ulong)Layouts.Length);
            for (var i = 0; i < Layouts.Length; i++)
            {
                p_Pointers.Add((uint)s_Writer.Position);
                s_Writer.Write((ulong)Layouts[i].Position);
            }

            foreach (var s_Layout in Layouts)
            {
                s_Writer.Align(8);
                s_Layout.Serialize(s_Writer);
            }

            foreach (var s_Layout in Layouts)
            {
                for (var i = 0; i < s_Layout.Fields.Length; i++)
                {
                    if (s_Layout.Fields[i].Layout != null)
                        p_Pointers.Add((uint)(s_Layout.Position + 0x20 + 0x20 * i + 0x18));
                }
            }

            s_Writer.Flush();
            return s_Stream.ToArray();
        }

        /// <summary>Writes the payload and its relocation table, as a reflection blob holds them.</summary>
        public bool Serialize(RimeWriter p_Writer)
        {
            var s_Blob = new RelocatableBlob(GenericDataBlobType.Reflection, p_Writer.Endianness == Endianness.BigEndian,
                Payload(p_Writer.Endianness, out var s_Pointers), s_Pointers);

            p_Writer.Write(s_Blob.Data);
            return true;
        }

        public void Deserialize(RimeReader p_Reader)
        {
            var s_Count = p_Reader.ReadUInt64();

            Layouts = new LayoutHeader[s_Count];
            for (var i = 0; i < Layouts.Length; i++)
            {
                var s_Reloc = new RelocPtr<LayoutHeader>(p_Reader);

                Layouts[i] = s_Reloc.Object;
            }

            Array.Sort(Layouts, (p_X, p_Y) => p_X.Hash.CompareTo(p_Y.Hash));

            foreach (var s_Layout in Layouts)
            {
                foreach (var s_Field in s_Layout.Fields)
                {
                    if (s_Field.LayoutOffset == 0)
                        continue;

                    s_Field.Layout = Layouts.First(x => x.Position == (long)s_Field.LayoutOffset);
                }
            }
        }

        /// <summary>A reflection of the layouts objects of these need: theirs and those of their fields, through all levels.</summary>
        public static Reflection Gather(IEnumerable<LayoutHeader> p_Layouts)
        {
            var s_Gathered = new HashSet<LayoutHeader>();
            var s_Pending = new Stack<LayoutHeader>(p_Layouts);

            while (s_Pending.Count > 0)
            {
                var s_Layout = s_Pending.Pop();
                if (!s_Gathered.Add(s_Layout))
                    continue;

                foreach (var s_Field in s_Layout.Fields)
                {
                    if (s_Field.Layout != null)
                        s_Pending.Push(s_Field.Layout);
                }
            }

            return new Reflection { Layouts = s_Gathered.ToArray() };
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
