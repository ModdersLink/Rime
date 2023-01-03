using RimeLib.Frostbite;
using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimeLib.Ant.EA.Reflection
{
    public class LayoutHeader : IFbSerializable
    {
        public long Position { get; set; } = -1;

        public int MinSlot { get; set; } = 0;
        public int MaxSlot { get; set; } = -1;

        public uint DataSize { get; set; } = 0;
        public uint Alignment { get; set; } = 0;

        public uint StringTableOffset { get; set; } = 0;
        public uint StringTableSize { get; set; } = 0;

        public bool Recorded { get; set; } = false;
        public bool Native { get; set; } = false;

        public uint Hash { get; set; } = 0;

        public string Name { get; set; } = string.Empty;

        public EntryHeader[] Fields = new EntryHeader[0];


        public LayoutType Type => (LayoutType)Hash;

        public int FieldCount => (MaxSlot - MinSlot) + 1;

        public bool IsBasicField => MinSlot > MaxSlot;



        public EntryHeader? FieldById(int p_Id) => (p_Id < MinSlot || p_Id > MaxSlot) ? null : Fields.Where(x => x.Id == p_Id).First();

        public LayoutHeader()
        {
        }
        public LayoutHeader(string p_Name, uint p_Size, uint p_Alignment, LayoutType p_Type )
        {
            Name = p_Name;

            DataSize = p_Size;
            Alignment = p_Alignment;


            Hash = (uint) p_Type;

        }

        public LayoutHeader(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }




        public bool Serialize(RimeWriter p_Writer)
        {
            throw new NotImplementedException();
        }

        public void Deserialize(RimeReader p_Reader)
        {
            Position = p_Reader.Position;

            MinSlot = p_Reader.ReadInt32();
            MaxSlot = p_Reader.ReadInt32();

            DataSize = p_Reader.ReadUInt32();
            Alignment = p_Reader.ReadUInt32();

            StringTableOffset = p_Reader.ReadUInt32();
            StringTableSize = p_Reader.ReadUInt32();

            Recorded = p_Reader.ReadBool();
            Native = p_Reader.ReadBool();

            //0x001A
            p_Reader.Seek(0x2, SeekOrigin.Current);

            Hash = p_Reader.ReadUInt32();


            Fields = new EntryHeader[FieldCount];
            for (var i=0; i < FieldCount; i++)
            {
                var s_Field = new EntryHeader(p_Reader, MinSlot + i);

                Fields[i] = s_Field;
            }

            //Array.Sort(Fields, (x, y) => (int)(x.Offset - y.Offset));

            var s_StringTablePos = Position + StringTableOffset;
            p_Reader.Seek(s_StringTablePos, SeekOrigin.Begin);

            var s_StringData = p_Reader.ReadBytes((int) StringTableSize);
            
            using var s_StringStream = new RimeReader(new MemoryStream(s_StringData));

            s_StringStream.Seek(1, SeekOrigin.Begin);
            Name = s_StringStream.ReadNullTerminatedString();

            for (var i = 0; i < Fields.Length; i++)
            {
                var s_Field = Fields[i];

                s_StringStream.Seek(s_Field.NameOffset, SeekOrigin.Begin);

                s_Field.Name = s_StringStream.ReadNullTerminatedString();
            }

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
