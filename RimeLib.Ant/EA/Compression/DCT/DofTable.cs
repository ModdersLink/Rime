using RimeLib.Frostbite;
using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimeLib.Ant.EA.Compression.DCT
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
        }



        public ushort SubBlockCount { get; set; } = 0;

        public ushort[] DeltaBase = new ushort[4];

        public BitsPerComponent[] BitsPerSubBlock = new BitsPerComponent[0];


        public DofTable(RimeReader p_Reader, ushort p_SubBlockCount)
        {
            SubBlockCount = p_SubBlockCount;
            Deserialize(p_Reader);
        }




        public bool Serialize(RimeWriter p_Writer)
        {
            throw new NotImplementedException();
        }

        public void Deserialize(RimeReader p_Reader)
        {
            DeltaBase = new ushort[4]
            {
                p_Reader.ReadUInt16(),
                p_Reader.ReadUInt16(),
                p_Reader.ReadUInt16(),
                p_Reader.ReadUInt16(),
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
