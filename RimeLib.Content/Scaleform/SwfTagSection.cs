using System.IO;
using RimeLib.IO;

namespace RimeLib.Content.Scaleform
{
    // A single SWF/GFX tag: its type and raw (undecoded) body bytes.
    // Copied from Utils/GFxTool, with Data exposed for dumping.
    public class SwfTagSection
    {
        public long? Offset { get; set; } = null;

        public SwfTag Tag { get; set; } = SwfTag.End;

        public byte[] Data { get; private set; } = new byte[0];

        public override string ToString() => $"{Tag} - length 0x{Data.Length:X}";

        public RimeReader GetReader()
        {
            return new RimeReader(new MemoryStream(Data));
        }

        public SwfTagSection(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }

        void Deserialize(RimeReader p_Reader)
        {
            Offset = p_Reader.Position;

            var s_TempByte = p_Reader.ReadUInt16();

            Tag = (SwfTag)(s_TempByte >> 6);

            int s_DataSize = s_TempByte & 0x3F;

            if (s_DataSize == 0x3F)
                s_DataSize = p_Reader.ReadInt32();

            if (s_DataSize != 0)
                Data = p_Reader.ReadBytes(s_DataSize);
        }
    }
}
