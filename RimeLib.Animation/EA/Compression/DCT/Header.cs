using RimeLib.Frostbite;
using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimeLib.Animation.EA.Compression.DCT
{
    public class Header : IFbSerializable
    {

        public ushort NumFrames { get; set; } = 0;
        public ushort NumQuats { get; set; } = 0;
        public ushort NumVec3s { get; set; } = 0;
        public ushort NumFloatVecs { get; set; } = 0;

        public ushort QuantizeMult_Block { get; set; } = 0;
        public byte QuantizeMult_SubBlock { get; set; } = 0;

        public byte CatchAllBitCount { get; set; } = 0;

        public DofTable[] Dof = new DofTable[0];


        public int ColumnBitLength => (CatchAllBitCount > 0xF) ? -1 : Dof.Sum(x => x.BitsPerSubBlock.Sum(x => x.BitsX + x.BitsY + x.BitsZ + x.BitsW));
        //public int BitLength_SubBlock0 => (CatchAllBitCount > 0xF) ? -1 : Dof.Sum(x => (x.SubBlockCount != 0) ? x.BitsPerSubBlock[0] => x.BitsX + x.BitsY + x.BitsZ + x.BitsW) : 0);

        //public int GetBlockOffset(int p_Index) => (ColnumBitLength / 8) * p_Index;


        public Header(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }


        public bool Serialize(RimeWriter p_Writer)
        {
            throw new NotImplementedException();
        }

        public void Deserialize(RimeReader p_Reader)
        {
            var s_LastEndianess = p_Reader.Endianness;
            p_Reader.Endianness = IO.Conversion.Endianness.LittleEndian;

            NumFrames = p_Reader.ReadUInt16();
            NumQuats = p_Reader.ReadUInt16();
            NumVec3s = p_Reader.ReadUInt16();
            NumFloatVecs = p_Reader.ReadUInt16();

            QuantizeMult_Block = p_Reader.ReadUInt16();
            QuantizeMult_SubBlock = p_Reader.ReadUByte();
            
            CatchAllBitCount = p_Reader.ReadUByte();


            var s_DofCount = (uint)NumQuats + NumVec3s + NumFloatVecs;

            byte[] s_DofSubBlocks = new byte[s_DofCount];
            for (var i = 0; i < s_DofCount; i++)
            {
                // 4 bits is unused.
                s_DofSubBlocks[i] = (byte)((p_Reader.ReadByte() >> 4) & 0xF);
            }

            Dof = new DofTable[s_DofCount];
            for (var i = 0; i < s_DofCount; i++)
                Dof[i] = new DofTable(p_Reader, s_DofSubBlocks[i]);


            p_Reader.Endianness = s_LastEndianess;
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
