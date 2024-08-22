using RimeLib.Frostbite;
using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimeLib.Animation.EA.Reflection
{
    public class EntryHeader : IFbSerializable
    {
        [Flags]
        public enum FieldFlags
        {
            None = 0,
            Array = 1,
            ForceAlign4 = 2,
            ForceAlign8 = 4,
            ForceAlign16 = 8,
        }


        public int Id { get; set; } = 0;

        public uint LayoutHash { get; set; } = 0;
        public uint ElementSize { get; set; } = 0;
        public uint Offset { get; set; } = 0;
        public uint NameOffset { get; set; } = 0;
        public ushort Count { get; set; } = 0;
        public FieldFlags Flags { get; set; } = 0;
        public ushort ElementAlign { get; set; } = 0;
        public short RLE { get; set; } = 0;
        public ulong LayoutOffset { get; set; } = 0;
        public LayoutHeader? Layout { get; set; } = null;
        public string Name { get; set; } = string.Empty;



       
        public bool IsArray => Flags.HasFlag(FieldFlags.Array);
        public LayoutType Type => (LayoutHash < (uint)LayoutType.LayoutTypeCount_FB2) ? (LayoutType)LayoutHash : LayoutType.Invalid;


        public uint AlignOffset(uint p_Align) => AlignIndexOffset(0, p_Align);
        public uint AlignedOffset => AlignOffset(ElementAlign);

        public uint AlignIndexOffset(int p_Index, uint p_Align) => ((uint)(Offset + ElementSize*p_Index) + (p_Align - 1)) & ~(p_Align - 1);
        public uint AlignIndexOffset(int p_Index) => AlignIndexOffset(p_Index, ElementAlign);


        public override string ToString() => $"{Name} - {Layout?.Name} | 0x{Offset:X04} - 0x{(Offset + ElementSize):X04}";


        public EntryHeader(RimeReader p_Reader, int p_Id)
        {
            Id = p_Id;
            Deserialize(p_Reader);
        }

     


        public bool Serialize(RimeWriter p_Writer)
        {
            p_Writer.Write(LayoutHash);
            p_Writer.Write(ElementSize);
            p_Writer.Write(Offset);
            p_Writer.Write(NameOffset);

            p_Writer.Write(Count);
            p_Writer.Write((short)Flags);
            p_Writer.Write(ElementAlign);
            p_Writer.Write(RLE);

            p_Writer.Write(LayoutOffset);;

            throw new NotImplementedException();
        }

        public void Deserialize(RimeReader p_Reader)
        {
            LayoutHash = p_Reader.ReadUInt32();
            ElementSize = p_Reader.ReadUInt32();
            Offset = p_Reader.ReadUInt32();
            NameOffset = p_Reader.ReadUInt32();

            Count = p_Reader.ReadUInt16();
            Flags = (FieldFlags) p_Reader.ReadUInt16();
            ElementAlign = p_Reader.ReadUInt16();
            RLE = p_Reader.ReadInt16();

            LayoutOffset = p_Reader.ReadUInt64();
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
