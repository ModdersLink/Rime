using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimeLib.Animation.EA.GenericData
{
    public class RelocatableBlob : Blob
    {
        public uint RelocationTableOffset { get; set; } = 0;
       
        public RelocatableBlob(RimeReader p_Reader)
        {
            Deserialize(p_Reader);  
        }

        public new bool Serialize(RimeWriter p_Writer)
        {
            throw new NotImplementedException();
        }

        public new void Deserialize(RimeReader p_Reader)
        {
            ParseId(p_Reader);

            var s_LastEndianess = p_Reader.Endianness;
            p_Reader.Endianness = BigEndian ? IO.Conversion.Endianness.BigEndian : IO.Conversion.Endianness.LittleEndian;


            // 0xC is sizeof(EA::GD::Serialization::Header) which is "GenericDataBlob" in this case.
            // add 0x4 for relocationtable
            var s_Size = p_Reader.ReadUInt32() - 0x10;

            RelocationTableOffset = p_Reader.ReadUInt32();

            Data = p_Reader.ReadBytes((int)s_Size);

            p_Reader.Endianness = s_LastEndianess;
        }
    }
}
