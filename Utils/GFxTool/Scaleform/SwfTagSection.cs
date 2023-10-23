using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFxTool.Scaleform
{
    public class SwfTagSection
    {
        public SwfTag Tag { get; set; } = SwfTag.End;

        private byte[] Data { get; set; } = new byte[0];


        public override string ToString() => $"{Tag} - length 0x{Data.Length:X}";

        public RimeReader GetReader()
        {
            return new RimeReader(new MemoryStream(Data));
        }

        public SwfTagSection( RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }


        void Deserialize(RimeReader p_Reader)
        {
            var s_TempByte = p_Reader.ReadUInt16();

            Tag = (SwfTag)(s_TempByte >> 6);

            int s_DataSize = s_TempByte & 0x3F;

            if (s_DataSize == 0x3F)
                s_DataSize = p_Reader.ReadInt32();

            Data = p_Reader.ReadBytes(s_DataSize);
        }
    }
}
