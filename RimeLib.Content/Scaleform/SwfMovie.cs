using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;
using RimeLib.IO;

namespace RimeLib.Content.Scaleform
{
    /// <summary>
    /// A SWF or GFx movie that reads and writes: the signature (FWS, CWS, GFX or CFX; C for a zlib
    /// compressed body), version and file length (of the uncompressed movie), then the body: the
    /// frame rectangle (bit-packed, kept as bytes), frame rate and count, and the tags, each with its
    /// header form (a tag can use the long form for a short length).
    /// </summary>
    public class SwfMovie
    {
        public class Tag
        {
            public ushort Code { get; set; }
            public bool LongHeader { get; set; }
            public byte[] Data { get; set; } = Array.Empty<byte>();
        }

        public string Signature { get; set; } = "GFX";
        public byte Version { get; set; }
        public byte[] FrameRect { get; set; } = Array.Empty<byte>();
        public ushort FrameRate { get; set; }
        public ushort FrameCount { get; set; }
        public List<Tag> Tags { get; set; } = new();

        /// <summary>Whatever follows the end tag.</summary>
        public byte[] Trailing { get; set; } = Array.Empty<byte>();

        public bool Compressed => Signature[0] == 'C';

        // A compressed movie writes back its original stream while its body is unchanged: zlib
        // output depends on the compressor, so recompressing would not give back the shipped bytes.
        private byte[]? m_CompressedBody;
        private byte[]? m_Body;

        public static SwfMovie Read(byte[] p_Data)
        {
            var s_Movie = new SwfMovie
            {
                Signature = Encoding.ASCII.GetString(p_Data, 0, 3),
                Version = p_Data[3],
            };

            if (s_Movie.Signature is not ("FWS" or "CWS" or "GFX" or "CFX"))
                throw new InvalidDataException($"Not a SWF or GFx movie ({s_Movie.Signature}).");

            var s_FileLength = BitConverter.ToUInt32(p_Data, 4);
            byte[] s_Body;
            if (s_Movie.Compressed)
            {
                s_Movie.m_CompressedBody = p_Data[8..];
                using var s_Inflater = new InflaterInputStream(new MemoryStream(s_Movie.m_CompressedBody, false));
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

            s_Movie.m_Body = s_Body;

            // The rectangle: 5 bits of field width, then four fields of that width, padded to a byte.
            var s_Bits = s_Body[0] >> 3;
            var s_RectSize = (5 + 4 * s_Bits + 7) / 8;
            s_Movie.FrameRect = s_Body[..s_RectSize];

            using var s_Reader = new RimeReader(new MemoryStream(s_Body, s_RectSize, s_Body.Length - s_RectSize, false));
            s_Movie.FrameRate = s_Reader.ReadUInt16();
            s_Movie.FrameCount = s_Reader.ReadUInt16();

            while (s_Reader.Position < s_Reader.Length)
            {
                var s_Header = s_Reader.ReadUInt16();
                var s_Tag = new Tag { Code = (ushort)(s_Header >> 6) };
                var s_Length = s_Header & 0x3F;
                if (s_Length == 0x3F)
                {
                    s_Tag.LongHeader = true;
                    s_Length = s_Reader.ReadInt32();
                }

                s_Tag.Data = s_Reader.ReadBytes(s_Length);
                s_Movie.Tags.Add(s_Tag);

                if (s_Tag.Code == (ushort)SwfTag.End)
                    break;
            }

            s_Movie.Trailing = s_Reader.ReadBytes((int)(s_Reader.Length - s_Reader.Position));
            return s_Movie;
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
                {
                    var s_Long = s_Tag.LongHeader || s_Tag.Data.Length >= 0x3F;
                    s_Writer.Write((ushort)((s_Tag.Code << 6) | (s_Long ? 0x3F : s_Tag.Data.Length)));
                    if (s_Long)
                        s_Writer.Write(s_Tag.Data.Length);
                    s_Writer.Write(s_Tag.Data);
                }

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
                s_Writer.Write(Encoding.ASCII.GetBytes(Signature));
                s_Writer.Write(Version);
                s_Writer.Write((uint)(s_Body.Length + 8));

                if (!Compressed)
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
