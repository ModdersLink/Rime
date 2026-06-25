using RimeLib.IO;
using RimeLib.IO.Conversion;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

namespace RimeLib.Cmd.Scaleform
{
    // Minimal SWF/GFX reader: parses the header and splits the body into tags
    // (handles CFX/SWC zlib compression). Copied from Utils/GFxTool so the REPL
    // can dump gfx structure. Tag bodies are kept raw (not field-decoded).
    public class SwfFile
    {
        public byte Version { get; set; } = 8;

        public double Fps { get; set; } = 0;
        public ushort FrameCount { get; set; } = 0;

        public bool IsStripped { get; set; } = false;
        public bool IsCompressed { get; set; } = false;

        public Vector4 Rect { get; set; }

        public List<SwfTagSection> Tags { get; set; } = new();

        public SwfFile(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }

        void Deserialize(RimeReader p_Reader)
        {
            var s_TempHeader = Encoding.ASCII.GetString(p_Reader.ReadBytes(3));
            var s_Magic = new string(s_TempHeader.Reverse().ToArray());

            if (s_Magic != "SWF" &&
                s_Magic != "SWC" && // compressed
                s_Magic != "XFG" && // GFX
                s_Magic != "XFC")   // CFX - compressed
                throw new InvalidDataException("Swf file contains invalid header!");

            IsStripped = s_Magic[0] == 'X';
            IsCompressed = s_Magic[2] == 'C';

            Version = p_Reader.ReadUByte();

            var s_FileSize = p_Reader.ReadUInt32();

            Stream s_Stream = p_Reader;
            if (IsCompressed)
                s_Stream = new InflaterInputStream(new LimitedRimeReader(p_Reader, s_FileSize - 0x8, false));

            using var s_Reader = new RimeReader(s_Stream);

            ReadRect(s_Reader);
            Fps = (double)s_Reader.ReadUInt16() / 256.0;
            FrameCount = s_Reader.ReadUInt16();

            while (true)
            {
                var s_Section = new SwfTagSection(s_Reader);

                Tags.Add(s_Section);

                if (s_Section.Tag == SwfTag.End)
                    break;
            }
        }

        void ReadRect(RimeReader p_Reader)
        {
            using var s_BitReader = new BitReader(p_Reader, 8, Endianness.BigEndian, false);

            var s_IntBitCount = s_BitReader.ReadUIntHigh(5);

            var s_Left = s_BitReader.ReadIntHigh((int)s_IntBitCount);
            var s_Right = s_BitReader.ReadIntHigh((int)s_IntBitCount);
            var s_Top = s_BitReader.ReadIntHigh((int)s_IntBitCount);
            var s_Bottom = s_BitReader.ReadIntHigh((int)s_IntBitCount);

            Rect = new Vector4(s_Left, s_Top, s_Right, s_Bottom);
        }
    }
}
