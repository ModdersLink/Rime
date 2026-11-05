using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Numerics;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;
using RimeLib.Frostbite;
using RimeLib.IO;
using RimeLib.IO.Conversion;

namespace RimeLib.Content.Scaleform
{
    /// <summary>
    /// A SWF or GFx movie that reads and writes (FWS, CWS, GFX or CFX; C for a zlib compressed
    /// body). Tag bodies are not decoded.
    /// </summary>
    public class SwfFile : IFbSerializable
    {
        /// <summary>Signature, version and file length.</summary>
        private const int c_HeaderSize = 8;

        public string Signature { get; set; } = "GFX";
        public byte Version { get; set; } = 8;

        public bool IsCompressed => Signature[0] == 'C';

        /// <summary>GFx (GFX, CFX) rather than SWF.</summary>
        public bool IsStripped => Signature[2] == 'X';

        /// <summary>The width of each frame rectangle field, which need not be the fewest bits that fit.</summary>
        public int RectBits { get; set; }

        /// <summary>The frame rectangle in twips.</summary>
        public int Left { get; set; }
        public int Right { get; set; }
        public int Top { get; set; }
        public int Bottom { get; set; }

        /// <summary>The frame rectangle: left, top, right, bottom.</summary>
        public Vector4 Rect => new(Left, Top, Right, Bottom);

        /// <summary>8.8 fixed point.</summary>
        public ushort FrameRate { get; set; }

        public double Fps => FrameRate / 256.0;
        public ushort FrameCount { get; set; }
        public List<SwfTagSection> Tags { get; set; } = new();

        // A compressed movie writes back its original stream while its body is unchanged: zlib
        // output depends on the compressor, so recompressing would not give back the shipped bytes.
        private byte[]? m_CompressedBody;
        private byte[]? m_Body;

        public SwfFile()
        {
        }

        public SwfFile(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }

        /// <summary>Reads the movie from the reader's position; a compressed one runs to the reader's end.</summary>
        public void Deserialize(RimeReader p_Reader)
        {
            var s_Start = p_Reader.Position;
            Signature = p_Reader.ReadFixedLengthString(3);
            Version = p_Reader.ReadUByte();

            if (Signature is not ("FWS" or "CWS" or "GFX" or "CFX"))
                throw new InvalidDataException($"Not a SWF or GFx movie ({Signature}).");

            var s_FileLength = p_Reader.ReadUInt32();
            var s_BodySize = (int)(s_FileLength - (p_Reader.Position - s_Start));

            m_CompressedBody = null;
            m_Body = null;
            RimeReader s_Body;
            if (IsCompressed)
            {
                m_CompressedBody = p_Reader.ReadBytes((int)(p_Reader.Length - p_Reader.Position));
                m_Body = Inflate(m_CompressedBody, s_BodySize);
                s_Body = new RimeReader(new MemoryStream(m_Body, false));
            }
            else
            {
                if (p_Reader.Length - p_Reader.Position < s_BodySize)
                    throw new InvalidDataException($"A movie of {s_FileLength} bytes that ends early.");

                s_Body = new LimitedRimeReader(p_Reader, s_BodySize, false);
            }

            using (s_Body)
                DeserializeBody(s_Body);
        }

        /// <summary>The header gives the inflated size; the stream must inflate to exactly that.</summary>
        private static byte[] Inflate(byte[] p_Compressed, int p_Size)
        {
            var s_Body = new byte[p_Size];
            using var s_Inflater = new InflaterInputStream(new MemoryStream(p_Compressed, false));
            try
            {
                s_Inflater.ReadExactly(s_Body);
            }
            catch (EndOfStreamException)
            {
                throw new InvalidDataException($"A compressed movie that inflates to less than its {p_Size} byte body.");
            }

            if (s_Inflater.ReadByte() != -1)
                throw new InvalidDataException($"A compressed movie that inflates to more than its {p_Size} byte body.");

            return s_Body;
        }

        private void DeserializeBody(RimeReader p_Reader)
        {
            // Five bits of field width, then the four fields, padded to a byte.
            using (var s_Bits = new BitReader(p_Reader, 8, Endianness.BigEndian, false))
            {
                RectBits = (int)s_Bits.ReadUIntHigh(5);
                Left = (int)s_Bits.ReadIntHigh(RectBits);
                Right = (int)s_Bits.ReadIntHigh(RectBits);
                Top = (int)s_Bits.ReadIntHigh(RectBits);
                Bottom = (int)s_Bits.ReadIntHigh(RectBits);
            }

            FrameRate = p_Reader.ReadUInt16();
            FrameCount = p_Reader.ReadUInt16();

            Tags.Clear();
            while (p_Reader.Position < p_Reader.Length)
            {
                var s_Tag = new SwfTagSection(p_Reader);
                s_Tag.Offset += c_HeaderSize;
                Tags.Add(s_Tag);

                if (s_Tag.Tag == SwfTag.End)
                    break;
            }

            if (p_Reader.Position != p_Reader.Length)
                throw new InvalidDataException($"A movie with {p_Reader.Length - p_Reader.Position} bytes after its end tag.");
        }

        public void Deserialize(byte[] p_Data)
        {
            using var s_Reader = new RimeReader(new MemoryStream(p_Data, false));
            Deserialize(s_Reader);
        }

        private void SerializeBody(RimeWriter p_Writer)
        {
            var s_RectBits = RectBits;
            foreach (var s_Field in new[] { Left, Right, Top, Bottom })
                s_RectBits = System.Math.Max(s_RectBits, FieldBits(s_Field));

            using (var s_Bits = new BitWriter(p_Writer))
            {
                s_Bits.WriteUIntHigh((ulong)s_RectBits, 5);
                s_Bits.WriteIntHigh(Left, s_RectBits);
                s_Bits.WriteIntHigh(Right, s_RectBits);
                s_Bits.WriteIntHigh(Top, s_RectBits);
                s_Bits.WriteIntHigh(Bottom, s_RectBits);
            }

            p_Writer.Write(FrameRate);
            p_Writer.Write(FrameCount);
            foreach (var s_Tag in Tags)
                s_Tag.Serialize(p_Writer);
        }

        /// <summary>The bits a signed rectangle field needs; none for zero.</summary>
        private static int FieldBits(int p_Value) =>
            p_Value == 0 ? 0 : 33 - BitOperations.LeadingZeroCount((uint)(p_Value < 0 ? ~p_Value : p_Value));

        public bool Serialize(RimeWriter p_Writer)
        {
            var s_Stream = new MemoryStream();
            using (var s_Writer = new RimeWriter(s_Stream))
                SerializeBody(s_Writer);
            var s_Body = s_Stream.ToArray();

            p_Writer.WriteFixedLengthString(Signature, 3);
            p_Writer.Write(Version);
            p_Writer.Write((uint)(s_Body.Length + c_HeaderSize));

            if (!IsCompressed)
            {
                p_Writer.Write(s_Body);
            }
            else if (m_CompressedBody != null && m_Body != null && m_Body.AsSpan().SequenceEqual(s_Body))
            {
                p_Writer.Write(m_CompressedBody);
            }
            else
            {
                var s_Compressed = new MemoryStream();
                using (var s_Deflater = new DeflaterOutputStream(s_Compressed) { IsStreamOwner = false })
                    s_Deflater.Write(s_Body);
                p_Writer.Write(s_Compressed.ToArray());
            }

            return true;
        }

        public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
        {
            var s_Stream = new MemoryStream();
            using (var s_Writer = new RimeWriter(s_Stream))
                Serialize(s_Writer);

            p_Data = s_Stream.ToArray();
            return true;
        }
    }
}
