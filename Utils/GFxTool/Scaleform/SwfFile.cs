using RimeLib.IO;
using RimeLib.IO.Conversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

namespace GFxTool.Scaleform
{
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
                s_Magic != "SWC" && //SWC - compressed
                s_Magic != "XFG" && //GFX
                s_Magic != "XFC") //CFX - compressed
                throw new InvalidDataException("Swf file contains invalid header!");

            IsStripped = s_Magic[0] == 'X';
            IsCompressed = s_Magic[2] == 'C';

            Version = p_Reader.ReadUByte();

            var s_FileSize = p_Reader.ReadUInt32();

            // check compressed swf!
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

                //TODO: crashes if compressed
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


        void Serialize(RimeWriter p_Writer)
        {
            // we dont support compressed fileformats, just set it to false
            IsCompressed = false;
            
            using var s_DataStream = new MemoryStream();
            using var s_DataWriter = new RimeWriter(s_DataStream);

            //WriteRect(s_DataWriter);
            s_DataWriter.Write((ushort)(Fps * 256.0));
            s_DataWriter.Write(FrameCount);

            foreach (var s_Tag in Tags)
            {
                //s_Tag.Serialize(s_DataWriter);
            }
            
            
            
            // Header data added at end to get filesize
            if (IsStripped)
                p_Writer.Write(Encoding.ASCII.GetBytes(new string("XFG".Reverse().ToArray())));
            else
                p_Writer.Write(Encoding.ASCII.GetBytes(new string("SWF".Reverse().ToArray())));
            p_Writer.Write(Version);
            
            // 8 = sizeof header
            p_Writer.Write((uint)(s_DataStream.Position + 8));
            
            p_Writer.Write(s_DataStream.ToArray());
        }
    }
}
