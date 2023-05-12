using ICSharpCode.SharpZipLib.Zip.Compression.Streams;
using RimeLib.Frostbite.Codec;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimeLib.IO
{
    public class CodecRimeReader : RimeReader
    {
        protected struct CodecSegment
        {
            public long Offset { get; set; }
            public CodecHeader Header { get; set; }
        }

        public override bool CanSeek => false;

        public override long Position => m_CurrentPosition;

        public override long Length => m_OriginalSize;

        protected long m_OriginalSize;
        protected long m_CompressedSize;
        protected Stream m_SegmentStream;
        protected long m_StartPosition;
        protected long m_CurrentPosition;
        protected int m_CurrentSegment;

        protected readonly List<CodecSegment> m_Segments = new List<CodecSegment>();

        public CodecRimeReader(RimeReader p_Reader, bool p_ShouldDispose = true) :
            base(p_Reader, p_Reader.Endianness, p_ShouldDispose)
        {
            // If the user has specified there are sizes here, we should parse them.
            LoadSizes();

            // Create the zlib / deflate decompression stream.
            m_SegmentStream = GetStreamForSegment(m_Segments[0]);
        }

        public override void Dispose()
        {
            base.Dispose();
            m_SegmentStream.Dispose();
        }

        protected Stream GetStreamForSegment(CodecSegment p_Segment)
        {
            // Seek to where we need to be.
            // + 8 is sizeof(CodecHeader)
            BaseStream.Seek(p_Segment.Offset + 8, SeekOrigin.Begin);

            // guard bits is for Frostbite 2 and earlier compatbility
            if (!p_Segment.Header.ValidGuardBits)
            {
                Stream s_CompatibilityStream = new LimitedRimeReader((RimeReader)BaseStream, p_Segment.Header.PackedSizeMethod, false);

                // If the original size is not equal to the compressed size then we need to wrap in an inflater stream.
                // Otherwise, we just return as-is.
                if (p_Segment.Header.PackedSizeMethod != p_Segment.Header.UnpackedSize)
                    s_CompatibilityStream = new InflaterInputStream(s_CompatibilityStream);

                return s_CompatibilityStream;
            }


            Stream s_Stream = new LimitedRimeReader((RimeReader)BaseStream, p_Segment.Header.PackedSize, false);

            switch (p_Segment.Header.Method)
            {
                case CodecMethod.None:
                    return s_Stream;
                case CodecMethod.Zlib:
                    return new InflaterInputStream(s_Stream);
            }

            throw new Exception($"Method {p_Segment.Header.Method} not implimented!");
        }

        protected void LoadSizes()
        {
            m_StartPosition = BaseStream.Position;
            m_CompressedSize = m_OriginalSize = 0;

            // Keep parsing segments until we have filled up our length requirement.
            while (m_CompressedSize != BaseStream.Length)
            {
                // Zlib segment sizes are always encoded in big-endian.
                var s_Segment = new CodecSegment
                {
                    Offset = BaseStream.Position,
                    Header = new CodecHeader((RimeReader)BaseStream),
                };

                m_CompressedSize += s_Segment.Header.PackedSize + 8;
                m_OriginalSize += s_Segment.Header.UnpackedSize;

                m_Segments.Add(s_Segment);

                // Seek to the beginning of the next segment.
                BaseStream.Seek(s_Segment.Header.PackedSize, SeekOrigin.Current);
            }
        }

        public override long Seek(long p_Offset, SeekOrigin p_Origin)
        {
            if (p_Origin == SeekOrigin.Current && p_Offset > 0)
            {
                ReadBytes((int)p_Offset);
                return Position;
            }

            throw new NotSupportedException();
        }

        protected override int ReadInternal(byte[] p_Data, int p_Index, int p_Count)
        {
            var s_Remaining = p_Count;

            while (s_Remaining > 0)
            {
                var s_ReadData = m_SegmentStream.Read(p_Data, p_Index + (p_Count - s_Remaining), s_Remaining);

                m_CurrentPosition += s_ReadData;
                s_Remaining -= s_ReadData;

                // If we didn't read enough data we need to move to the next segment.
                if (s_Remaining == 0)
                    continue;

                if (s_Remaining < 0)
                    throw new Exception("Read more data than we should have. Something has definitely gone wrong.");

                m_SegmentStream.Dispose();

                // Seek to the next segment.
                var s_NextSegment = m_Segments[++m_CurrentSegment];

                m_SegmentStream = GetStreamForSegment(s_NextSegment);
            }

            return p_Count;
        }
    }
}
