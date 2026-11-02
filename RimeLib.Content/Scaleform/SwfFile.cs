using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;
using RimeLib.IO;
using RimeLib.IO.Conversion;

namespace RimeLib.Content.Scaleform
{
    /// <summary>
    /// A SWF or GFx movie that reads and writes (FWS, CWS, GFX or CFX; C for a zlib compressed
    /// body). The frame rectangle is kept as its bit-packed bytes and tag bodies are not decoded.
    /// </summary>
    public class SwfFile
    {
        public string Signature { get; set; } = "GFX";
        public byte Version { get; set; } = 8;

        public bool IsCompressed => Signature[0] == 'C';

        /// <summary>GFx (GFX, CFX) rather than SWF.</summary>
        public bool IsStripped => Signature[2] == 'X';

        public byte[] FrameRect { get; set; } = Array.Empty<byte>();

        /// <summary>8.8 fixed point.</summary>
        public ushort FrameRate { get; set; }

        public double Fps => FrameRate / 256.0;
        public ushort FrameCount { get; set; }
        public List<SwfTagSection> Tags { get; set; } = new();

        /// <summary>Whatever follows the end tag.</summary>
        public byte[] Trailing { get; set; } = Array.Empty<byte>();

        // A compressed movie writes back its original stream while its body is unchanged: zlib
        // output depends on the compressor, so recompressing would not give back the shipped bytes.
        private byte[]? m_CompressedBody;
        private byte[]? m_Body;

        public SwfFile()
        {
        }

        public SwfFile(RimeReader p_Reader)
        {
            var s_Data = new MemoryStream();
            p_Reader.CopyTo(s_Data);
            Load(s_Data.ToArray());
        }

        public static SwfFile Read(byte[] p_Data)
        {
            var s_File = new SwfFile();
            s_File.Load(p_Data);
            return s_File;
        }

        /// <summary>The frame rectangle decoded: left, top, right, bottom in twips.</summary>
        public Vector4 Rect
        {
            get
            {
                using var s_Reader = new RimeReader(new MemoryStream(FrameRect, false));
                using var s_BitReader = new BitReader(s_Reader, 8, Endianness.BigEndian, false);
                var s_Bits = (int)s_BitReader.ReadUIntHigh(5);
                var s_Left = s_BitReader.ReadIntHigh(s_Bits);
                var s_Right = s_BitReader.ReadIntHigh(s_Bits);
                var s_Top = s_BitReader.ReadIntHigh(s_Bits);
                var s_Bottom = s_BitReader.ReadIntHigh(s_Bits);
                return new Vector4(s_Left, s_Top, s_Right, s_Bottom);
            }
        }

        private void Load(byte[] p_Data)
        {
            using var s_MovieHeader = new RimeReader(new MemoryStream(p_Data, false));
            Signature = s_MovieHeader.ReadFixedLengthString(3);
            Version = s_MovieHeader.ReadUByte();

            if (Signature is not ("FWS" or "CWS" or "GFX" or "CFX"))
                throw new InvalidDataException($"Not a SWF or GFx movie ({Signature}).");

            var s_FileLength = s_MovieHeader.ReadUInt32();
            byte[] s_Body;
            if (IsCompressed)
            {
                m_CompressedBody = p_Data[8..];
                using var s_Inflater = new InflaterInputStream(new MemoryStream(m_CompressedBody, false));
                using var s_Out = new MemoryStream();
                s_Inflater.CopyTo(s_Out);
                s_Body = s_Out.ToArray();
            }
            else
            {
                s_Body = p_Data[8..];
            }

            if (s_Body.Length + 8 != s_FileLength)
                throw new InvalidDataException($"A movie of {s_FileLength} bytes with a {s_Body.Length} byte body.");

            m_Body = s_Body;

            // The rectangle: 5 bits of field width, then four fields of that width, padded to a byte.
            var s_Bits = s_Body[0] >> 3;
            var s_RectSize = (5 + 4 * s_Bits + 7) / 8;
            FrameRect = s_Body[..s_RectSize];

            using var s_Reader = new RimeReader(new MemoryStream(s_Body, s_RectSize, s_Body.Length - s_RectSize, false));
            FrameRate = s_Reader.ReadUInt16();
            FrameCount = s_Reader.ReadUInt16();

            Tags.Clear();
            while (s_Reader.Position < s_Reader.Length)
            {
                var s_Tag = new SwfTagSection(s_Reader);
                s_Tag.Offset += 8 + s_RectSize;
                Tags.Add(s_Tag);

                if (s_Tag.Tag == SwfTag.End)
                    break;
            }

            Trailing = s_Reader.ReadBytes((int)(s_Reader.Length - s_Reader.Position));
        }

        private byte[] Body()
        {
            var s_Stream = new MemoryStream();
            using (var s_Writer = new RimeWriter(s_Stream))
            {
                s_Writer.Write(FrameRect);
                s_Writer.Write(FrameRate);
                s_Writer.Write(FrameCount);
                foreach (var s_Tag in Tags)
                    s_Tag.Serialize(s_Writer);

                s_Writer.Write(Trailing);
            }

            return s_Stream.ToArray();
        }

        public byte[] Write()
        {
            var s_Body = Body();
            var s_Stream = new MemoryStream();
            using (var s_Writer = new RimeWriter(s_Stream))
            {
                s_Writer.WriteFixedLengthString(Signature, 3);
                s_Writer.Write(Version);
                s_Writer.Write((uint)(s_Body.Length + 8));

                if (!IsCompressed)
                    s_Writer.Write(s_Body);
                else if (m_CompressedBody != null && m_Body != null && m_Body.AsSpan().SequenceEqual(s_Body))
                    s_Writer.Write(m_CompressedBody);
                else
                {
                    var s_Compressed = new MemoryStream();
                    using (var s_Deflater = new DeflaterOutputStream(s_Compressed) { IsStreamOwner = false })
                        s_Deflater.Write(s_Body);
                    s_Writer.Write(s_Compressed.ToArray());
                }
            }

            return s_Stream.ToArray();
        }
    }
}
