using System;
using System.IO;
using ICSharpCode.SharpZipLib.Zip.Compression;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;
using RimeLib.Frostbite.Codec;
using RimeLib.IO.Conversion;

namespace RimeLib.IO
{
    /// <summary>
    /// Writes the codec block format <see cref="CodecRimeReader"/> reads: blocks of at most
    /// <see cref="CodecSettings.BlockSize"/> bytes, each a codec header and the packed bytes, or the
    /// raw bytes when packing does not shrink the block. A block is written once it fills, and on
    /// <see cref="Flush"/>, which also writes the one empty block of a writer nothing was written to.
    /// Position and Length count the bytes before packing.
    /// </summary>
    public class CodecRimeWriter : RimeWriter
    {
        private readonly CodecSettings m_Settings;
        private readonly byte[] m_Block;
        private int m_Pending;
        private long m_Position;
        private bool m_WroteBlock;

        public override long Position
        {
            get => m_Position;
            set => throw new NotSupportedException();
        }

        public override long Length => m_Position;
        public override bool CanSeek => false;
        public override bool CanRead => false;

        public CodecRimeWriter(Stream p_Stream, CodecSettings p_Settings, Endianness p_Endianness = Endianness.LittleEndian, bool p_ShouldDispose = true)
            : base(p_Stream, p_Endianness, p_ShouldDispose)
        {
            if (p_Settings.Method is not (CodecMethod.Zlib or CodecMethod.None))
                throw new ArgumentException($"The codec writer packs Zlib or None blocks, not {p_Settings.Method}.", nameof(p_Settings));

            if (p_Settings.BlockSize is <= 0 or > CodecSettings.MaxBlockSize)
                throw new ArgumentException($"A codec block holds 1 to {CodecSettings.MaxBlockSize} bytes, not {p_Settings.BlockSize}.", nameof(p_Settings));

            m_Settings = p_Settings;
            m_Block = new byte[p_Settings.BlockSize];
        }

        protected override void WriteInternal(byte[] p_Bytes, int p_Offset, int p_Length)
        {
            CheckDisposed();

            while (p_Length > 0)
            {
                var s_Count = System.Math.Min(p_Length, m_Block.Length - m_Pending);
                Buffer.BlockCopy(p_Bytes, p_Offset, m_Block, m_Pending, s_Count);
                m_Pending += s_Count;
                m_Position += s_Count;
                p_Offset += s_Count;
                p_Length -= s_Count;

                if (m_Pending == m_Block.Length)
                    WriteBlock();
            }
        }

        /// <summary>Writes the pending bytes as a block, then flushes the stream below.</summary>
        public override void Flush()
        {
            CheckDisposed();

            if (m_Pending > 0 || !m_WroteBlock)
                WriteBlock();

            BaseStream.Flush();
        }

        private void WriteBlock()
        {
            var s_Packed = m_Settings.Method == CodecMethod.Zlib ? Deflate() : null;

            // A block that does not shrink is stored, with the packed size equal to the unpacked one.
            var s_Header = new CodecHeader((uint)(s_Packed?.Length ?? m_Pending), (uint)m_Pending, m_Settings.Method);
            s_Header.Serialize(out var s_HeaderBytes);
            BaseStream.Write(s_HeaderBytes!);

            if (s_Packed != null && s_Packed.Length < m_Pending)
                BaseStream.Write(s_Packed);
            else
                BaseStream.Write(m_Block, 0, m_Pending);

            m_Pending = 0;
            m_WroteBlock = true;
        }

        private byte[] Deflate()
        {
            var s_Output = new MemoryStream();
            using (var s_Deflate = new DeflaterOutputStream(s_Output, new Deflater(m_Settings.Level), 4096) { IsStreamOwner = false })
            {
                s_Deflate.Write(m_Block, 0, m_Pending);
                s_Deflate.Finish();
            }

            return s_Output.ToArray();
        }
    }
}
