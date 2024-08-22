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
    public class DofTable : IFbSerializable
    {
        public class BitsPerComponent
        {
            public BitsPerComponent(ushort p_Value)
            {
                Value = p_Value;
            }

            public ushort Value { get; set; }


            public ushort BitsW => (ushort)((Value >> (4 * 0)) & 0xF);
            public ushort BitsZ => (ushort)((Value >> (4 * 1)) & 0xF);
            public ushort BitsY => (ushort)((Value >> (4 * 2)) & 0xF);
            public ushort BitsX => (ushort)((Value >> (4 * 3)) & 0xF);

            public ushort SafeBitsW(ushort p_CatchAllBitCount) => (BitsW == 0xF) ? p_CatchAllBitCount : BitsW;
            public ushort SafeBitsZ(ushort p_CatchAllBitCount) => (BitsZ == 0xF) ? p_CatchAllBitCount : BitsZ;
            public ushort SafeBitsY(ushort p_CatchAllBitCount) => (BitsY == 0xF) ? p_CatchAllBitCount : BitsY;
            public ushort SafeBitsX(ushort p_CatchAllBitCount) => (BitsX == 0xF) ? p_CatchAllBitCount : BitsX;


            public int BitSum => BitsX + BitsY + BitsZ + BitsW;

            public int SafeSum(ushort p_CatchAllBitCount) => SafeBitsX(p_CatchAllBitCount) + SafeBitsY(p_CatchAllBitCount) + SafeBitsZ(p_CatchAllBitCount) + SafeBitsW(p_CatchAllBitCount);
        }



        public ushort SubBlockCount { get; set; } = 0;

        public short[] DeltaBase = new short[4];

        public BitsPerComponent[] BitsPerSubBlock = new BitsPerComponent[0];


        public DofTable( ushort p_SubBlockCount)
        {
            SubBlockCount = p_SubBlockCount;
        }

        public DofTable(RimeReader p_Reader, ushort p_SubBlockCount)
            : this(p_SubBlockCount)
        {
            Deserialize(p_Reader);
        }




        public bool Serialize(RimeWriter p_Writer)
        {
            throw new NotImplementedException();
        }

        public void Deserialize(RimeReader p_Reader)
        {
            DeltaBase = new short[4]
            {
                p_Reader.ReadInt16(),
                p_Reader.ReadInt16(),
                p_Reader.ReadInt16(),
                p_Reader.ReadInt16(),
            };

            BitsPerSubBlock = new BitsPerComponent[SubBlockCount];

            for (var i = 0; i < SubBlockCount; i++)
                BitsPerSubBlock[i] = new BitsPerComponent(p_Reader.ReadUInt16());
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
