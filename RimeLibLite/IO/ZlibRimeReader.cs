using System;
using System.Collections.Generic;
using System.IO;
using ICSharpCode.SharpZipLib.Zip.Compression;
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

            Stream s_Stream = new LimitedRimeReader((RimeReader)BaseStream, p_Segment.CompressedSize, false);

            // If the original size is not equal to the compressed size then we need to wrap in an inflater stream.
            // Otherwise, we just return as-is.
            if (p_Segment.CompressedSize != p_Segment.OriginalSize)
                s_Stream = new InflaterInputStream(s_Stream, new Inflater(), (int)p_Segment.OriginalSize);

            return s_Stream;
        }

        public byte[] GetRawBytes()
        {
            BaseStream.Seek(m_StartPosition, SeekOrigin.Begin);
            var s_ByteBuffer = new byte[BaseStream.Length];
            BaseStream.Read(s_ByteBuffer);
            return s_ByteBuffer;
        }

        protected void LoadSizes()
        {
            m_StartPosition = BaseStream.Position;

            // A retail payload is a chain of segments, each a big-endian original size, a big-endian
            // compressed size and the data. The pre-release builds put the total uncompressed size in
            // front of the same chain, and some of their payloads have no container at all. Try each
            // layout in turn, retail first so retail data keeps behaving exactly as it did.
            if (TryWalkSegments(0))
                return;

            if (TryWalkSegments(4))
                return;

            // No container: expose the payload as one stored segment. The offset goes back 8 bytes
            // because GetStreamForSegment always seeks past a segment header.
            m_Segments.Clear();
            m_CompressedSize = m_OriginalSize = BaseStream.Length;
            m_Segments.Add(new ZlibSegment
            {
                Offset = m_StartPosition - 8,
                OriginalSize = BaseStream.Length,
                CompressedSize = BaseStream.Length,
                LeftData = BaseStream.Length,
            });
        }

        /// <summary>
        /// Walks the segment chain assuming <paramref name="p_PrefixSize"/> bytes of payload prefix,
        /// where 0 is the retail layout and 4 the pre-release total-size prefix. The parsed segments
        /// only count when the chain lands exactly on the end of the stream, and, with a prefix, when
        /// the original sizes add up to the declared total.
        /// </summary>
        protected bool TryWalkSegments(int p_PrefixSize)
        {
            m_Segments.Clear();
            m_CompressedSize = m_OriginalSize = 0;
            BaseStream.Seek(m_StartPosition, SeekOrigin.Begin);

            long s_DeclaredTotal = -1;

            if (p_PrefixSize == 4)
            {
                if (BaseStream.Length < 12)
                    return false;

                s_DeclaredTotal = EndianBitConverter.Big.ToUInt32(((RimeReader)BaseStream).ReadBytes(4), 0);
                m_CompressedSize = 4;
            }

            while (m_CompressedSize != BaseStream.Length)
            {
                // A segment header no longer fits, so this is not the layout.
                if (BaseStream.Length - m_CompressedSize < 8)
                    return false;

                // Zlib segment sizes are always encoded in big-endian.
                var s_Segment = new ZlibSegment
                {
                    Offset = BaseStream.Position,
                    OriginalSize = EndianBitConverter.Big.ToInt32(((RimeReader)BaseStream).ReadBytes(4), 0),
                    CompressedSize = EndianBitConverter.Big.ToInt32(((RimeReader)BaseStream).ReadBytes(4), 0),
                };

                // The sizes have to be non-negative and the data has to fit in what is left.
                if (s_Segment.OriginalSize < 0 || s_Segment.CompressedSize < 0 ||
                    s_Segment.CompressedSize > BaseStream.Length - m_CompressedSize - 8)
                    return false;

                s_Segment.LeftData = s_Segment.CompressedSize;

                m_CompressedSize += s_Segment.CompressedSize + 8;
                m_OriginalSize += s_Segment.OriginalSize;

                m_Segments.Add(s_Segment);

                // Seek to the beginning of the next segment.
                BaseStream.Seek(s_Segment.CompressedSize, SeekOrigin.Current);
            }

            if (m_Segments.Count == 0)
                return false;

            // The alpha prefix must match the accumulated uncompressed size.
            if (s_DeclaredTotal >= 0 && m_OriginalSize != s_DeclaredTotal)
                return false;

            return true;
        }

        public override long Seek(long p_Offset, SeekOrigin p_Origin)
        {
            if (p_Origin == SeekOrigin.Current && p_Offset > 0)
            {
                ReadBytes((int)p_Offset);
                return Position;
            }

            long s_AbsoluteOffset = p_Origin switch
            {
                SeekOrigin.Begin => p_Offset,
                SeekOrigin.Current => Position + p_Offset,
                SeekOrigin.End => m_OriginalSize - p_Offset, // TODO: is this minus or plus
            };

            if (s_AbsoluteOffset == Position)
                return Position;

            if (s_AbsoluteOffset > m_OriginalSize)
                throw new InvalidDataException();

            // if (s_AbsoluteOffset > Position)
            // {
            //     // TODO: THis is worse for files with multiple segments.
            //     ReadBytes((int) (s_AbsoluteOffset - Position));
            //     return Position;
            // }

            (int, ZlibSegment)? s_TargetSegment = null;

            long s_SegmentDecompresedOffset = 0;
            for (var s_I = 0; s_I < m_Segments.Count; s_I++)
            {
                var s_Segment = m_Segments[s_I];

                if (s_AbsoluteOffset >= s_SegmentDecompresedOffset &&
                    s_AbsoluteOffset < s_SegmentDecompresedOffset + s_Segment.OriginalSize)
                {
                    s_TargetSegment = (s_I, s_Segment);
                    break;
                }

                s_SegmentDecompresedOffset += s_Segment.OriginalSize;
            }

            if (s_TargetSegment == null && s_AbsoluteOffset == s_SegmentDecompresedOffset)
                s_TargetSegment = (m_Segments.Count - 1, m_Segments[^1]);

            // Should we crash here? if we set position to end of buffer this will trigger.
            if (s_TargetSegment == null)
                throw new Exception();


            var s_OffsetInStream = s_AbsoluteOffset - s_SegmentDecompresedOffset;
            if (s_OffsetInStream < 0)
                throw new NotImplementedException();

            // NOTE: zlib streame or whatever doesnt support seeks. 
            // if (s_TargetSegment.Value.Item1 == m_CurrentSegment)

            if (s_TargetSegment.Value.Item1 == m_CurrentSegment && s_AbsoluteOffset > m_CurrentPosition)
            {
                var s_SizeToRead = s_AbsoluteOffset - m_CurrentPosition;

                var s_JunkData = new byte[s_SizeToRead];
                m_SegmentStream.Read(s_JunkData, 0, (int)s_SizeToRead);
            }
            else
            {
                // Seek to the next segment.
                m_CurrentSegment = s_TargetSegment.Value.Item1;
                m_SegmentStream.Dispose();
                m_SegmentStream = GetStreamForSegment(m_Segments[m_CurrentSegment]);


                var s_JunkData = new byte[s_OffsetInStream];
                m_SegmentStream.Read(s_JunkData, 0, (int)s_OffsetInStream);
            }
            m_CurrentPosition = s_AbsoluteOffset;

            return Position;
        }

        protected override int ReadInternal(byte[] p_Data, int p_Index, int p_Count)
        {
            var s_Remaining = p_Count;

            while (s_Remaining > 0)
            {
                var s_ReadData = m_SegmentStream.Read(p_Data, p_Index + (p_Count - s_Remaining), System.Math.Min(s_Remaining, (int)m_Segments[m_CurrentSegment].OriginalSize));

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
