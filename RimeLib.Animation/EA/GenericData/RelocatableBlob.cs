using RimeLib.IO;
using System.Collections.Generic;

namespace RimeLib.Animation.EA.GenericData
{
    /// <summary>
    /// A blob whose payload holds pointers: its <see cref="Blob.Data"/> is the payload, padded to
    /// four bytes, then the relocation table, a count and the payload offset of every pointer.
    /// </summary>
    public class RelocatableBlob
        : Blob
    {
        private const uint c_HeaderSize = 0x10;

        /// <summary>Where the relocation table starts, counted from the blob's header.</summary>
        public uint RelocationTableOffset { get; set; } = 0;

        public RelocatableBlob()
        {
        }

        public RelocatableBlob(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }

        /// <summary>A blob of a payload and the offsets of the pointers in it.</summary>
        public RelocatableBlob(GenericDataBlobType p_Type, bool p_BigEndian, byte[] p_Payload, IReadOnlyList<uint> p_Pointers)
        {
            Type = p_Type;
            BigEndian = p_BigEndian;

            using var s_Stream = new System.IO.MemoryStream();
            using var s_Writer = new RimeWriter(s_Stream, BigEndian ? IO.Conversion.Endianness.BigEndian : IO.Conversion.Endianness.LittleEndian);

            s_Writer.Write(p_Payload);
            s_Writer.Align(4);

            RelocationTableOffset = (uint)s_Writer.Position + c_HeaderSize;

            s_Writer.Write((uint)p_Pointers.Count);
            foreach (var s_Pointer in p_Pointers)
                s_Writer.Write(s_Pointer);

            s_Writer.Flush();
            Data = s_Stream.ToArray();
        }

        /// <summary>The payload offsets of the pointers in the payload.</summary>
        public uint[] ReadPointers()
        {
            using var s_Reader = GetReader();
            s_Reader.Seek(RelocationTableOffset - c_HeaderSize, System.IO.SeekOrigin.Begin);

            var s_Pointers = new uint[s_Reader.ReadUInt32()];
            for (var i = 0; i < s_Pointers.Length; i++)
                s_Pointers[i] = s_Reader.ReadUInt32();

            return s_Pointers;
        }

        public override bool Serialize(RimeWriter p_Writer)
        {
            p_Writer.Write(SerializeId());

            var s_LastEndianess = p_Writer.Endianness;
            p_Writer.Endianness = BigEndian ? IO.Conversion.Endianness.BigEndian : IO.Conversion.Endianness.LittleEndian;

            p_Writer.Write((uint)Data.Length + c_HeaderSize);
            p_Writer.Write(RelocationTableOffset);
            p_Writer.Write(Data);

            p_Writer.Endianness = s_LastEndianess;

            return true;
        }

        public override void Deserialize(RimeReader p_Reader)
        {
            ParseId(p_Reader);

            var s_LastEndianess = p_Reader.Endianness;
            p_Reader.Endianness = BigEndian ? IO.Conversion.Endianness.BigEndian : IO.Conversion.Endianness.LittleEndian;

            // The size counts the header: the id, the size and the relocation table offset.
            var s_Size = p_Reader.ReadUInt32() - c_HeaderSize;

            RelocationTableOffset = p_Reader.ReadUInt32();

            DataOffset = p_Reader.Position;
            Data = p_Reader.ReadBytes((int)s_Size);

            p_Reader.Endianness = s_LastEndianess;
        }
    }
}
