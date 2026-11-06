using RimeLib.Frostbite;
using RimeLib.IO;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;

namespace RimeLib.Animation.EA.Reflection
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




        /// <summary>The bytes <see cref="Serialize(RimeWriter)"/> writes: the header, the fields and the string table.</summary>
        public uint SerializedSize => c_HeaderSize + c_FieldSize * (uint)Fields.Length + (uint)StringTable(out _).Length;

        private const uint c_HeaderSize = 0x20;
        private const uint c_FieldSize = 0x20;

        /// <summary>
        /// The layout's name and its fields' names, each NUL-terminated after a leading NUL that
        /// unnamed fields point at. Names keep the order of the offsets they were read at; a field
        /// without one follows in slot order.
        /// </summary>
        private byte[] StringTable(out uint[] p_NameOffsets)
        {
            using var s_Stream = new MemoryStream();
            using var s_Writer = new RimeWriter(s_Stream);

            s_Writer.Write((byte)0x00);
            s_Writer.WriteNullTerminatedString(Name);

            p_NameOffsets = new uint[Fields.Length];
            var s_Order = Fields.Select((p_Field, p_Index) => (p_Field, p_Index))
                .OrderBy(p_Pair => p_Pair.p_Field.NameOffset == 0 ? uint.MaxValue : p_Pair.p_Field.NameOffset);

            foreach (var (s_Field, s_Index) in s_Order)
            {
                if (s_Field.Name.Length == 0)
                    continue;

                p_NameOffsets[s_Index] = (uint)s_Writer.Position;
                s_Writer.WriteNullTerminatedString(s_Field.Name);
            }

            s_Writer.Flush();
            return s_Stream.ToArray();
        }

        public bool Serialize(RimeWriter p_Writer)
        {
            var s_StringTable = StringTable(out var s_NameOffsets);

            for (var i = 0; i < Fields.Length; i++)
                Fields[i].NameOffset = s_NameOffsets[i];

            StringTableOffset = c_HeaderSize + c_FieldSize * (uint)Fields.Length;
            StringTableSize = (uint)s_StringTable.Length;

            p_Writer.Write(MinSlot);
            p_Writer.Write(MaxSlot);
            p_Writer.Write(DataSize);
            p_Writer.Write(Alignment);
            p_Writer.Write(StringTableOffset);
            p_Writer.Write(StringTableSize);
            p_Writer.Write(Recorded);
            p_Writer.Write(Native);
            p_Writer.Write((ushort)0);
            p_Writer.Write(Hash);

            foreach (var s_Field in Fields)
                s_Field.Serialize(p_Writer);

            p_Writer.Write(s_StringTable);

            return true;
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
