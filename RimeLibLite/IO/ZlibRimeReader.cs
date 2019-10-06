using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;
using RimeLib.IO.Conversion;

namespace RimeLib.IO
{
    public class ZlibRimeReader : RimeReader
    {
        protected struct ZlibSegment
        {
            public long Offset { get; set; }
            public long OriginalSize { get; set; }
            public long CompressedSize { get; set; }
            public long LeftData { get; set; }
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

        protected readonly List<ZlibSegment> m_Segments = new List<ZlibSegment>();

        public ZlibRimeReader(RimeReader p_Reader, bool p_ShouldDispose = true) : 
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

        protected Stream GetStreamForSegment(ZlibSegment p_Segment)
        {
            // Seek to where we need to be.
            BaseStream.Seek(p_Segment.Offset + 8, SeekOrigin.Begin);

            Stream s_Stream = new LimitedRimeReader((RimeReader) BaseStream, p_Segment.CompressedSize, false);
                
            // If the original size is not equal to the compressed size then we need to wrap in an inflater stream.
            // Otherwise, we just return as-is.
            if (p_Segment.CompressedSize != p_Segment.OriginalSize)
                s_Stream = new InflaterInputStream(s_Stream);

            return s_Stream;
        }

        protected void LoadSizes()
        {
            m_StartPosition = BaseStream.Position;
            m_CompressedSize = m_OriginalSize = 0;

            // Keep parsing segments until we have filled up our length requirement.
            while (m_CompressedSize != BaseStream.Length)
            {
                // Zlib segment sizes are always encoded in big-endian.
                var s_Segment = new ZlibSegment
                {
                    Offset = BaseStream.Position,
                    OriginalSize = EndianBitConverter.Big.ToInt32(((RimeReader) BaseStream).ReadBytes(4), 0),
                    CompressedSize = EndianBitConverter.Big.ToInt32(((RimeReader) BaseStream).ReadBytes(4), 0),
                };

                s_Segment.LeftData = s_Segment.CompressedSize;

                m_CompressedSize += s_Segment.CompressedSize + 8;
                m_OriginalSize += s_Segment.OriginalSize;

                m_Segments.Add(s_Segment);

                // Seek to the beginning of the next segment.
                BaseStream.Seek(s_Segment.CompressedSize, SeekOrigin.Current);
            }
        }

        public override long Seek(long p_Offset, SeekOrigin p_Origin)
        {
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
