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
            public long UnpackedOffset { get; set; }
            public CodecHeader Header { get; set; }
        }

        public override bool CanSeek => false;

        public override long Position => m_CurrentPosition;
        public override long Length => m_OriginalSize;

        public long CompressedSize => m_CompressedSize;
        
        
        protected long m_OriginalSize;
        protected long m_CompressedSize;
        protected Stream? m_SegmentStream = null;
        protected long m_CurrentPosition;
        protected int m_CurrentSegment;

        protected readonly List<CodecSegment> m_Segments = new List<CodecSegment>();

        public CodecRimeReader(RimeReader p_Reader, long p_OriginalSize = -1, long p_SegmentCount = -1, bool p_ShouldDispose = true) :
            base(p_Reader, p_Reader.Endianness, p_ShouldDispose)
        {
            // If the user has specified there are sizes here, we should parse them.
            LoadSizes(p_SegmentCount, p_OriginalSize);

        }

        public override void Dispose()
        {
            base.Dispose();
            
            if(m_SegmentStream != null)
                m_SegmentStream.Dispose();
        }

        private void InitialzeStream()
        {
            // set stream on demand.
            if (m_SegmentStream != null)
                return;
            // Create the zlib / deflate decompression stream on demand.
            m_SegmentStream = GetStreamForSegment(m_Segments[0]);
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


            var s_Stream = new LimitedRimeReader((RimeReader)BaseStream, p_Segment.Header.PackedSize, false);

            switch (p_Segment.Header.Method)
            {
                case CodecMethod.None:
                    return s_Stream;
                case CodecMethod.Zlib:
                    //this might 
                    return new InflaterInputStream(s_Stream);
                case CodecMethod.LZ4:
                    //LZ4.LZ4Codec.Decode
                    //return new LZ4.LZ4Stream(s_Stream, LZ4StreamMode.Decompress);
                    return new MemoryStream(LZ4.LZ4Codec.Decode(s_Stream.ReadBytes((int)p_Segment.Header.PackedSize),0, (int) p_Segment.Header.PackedSize, (int) p_Segment.Header.UnpackedSize));
            }

            throw new Exception($"Method {p_Segment.Header.Method} not implimented!");
        }

        protected void LoadSizes(long p_ReadSegmentCount = -1, long p_OriginalSize = -1)
        {
            m_CompressedSize = m_OriginalSize = 0;

            // Keep parsing segments until we have filled up our length requirement.
            // if ReadSignle is set, read only 1 block
            if (p_ReadSegmentCount != -1)
            {
                for (var i=0; i < p_ReadSegmentCount; i++)
                    ReadEntry();
            }
            else if (p_OriginalSize != -1)
            {
                while (m_OriginalSize != p_OriginalSize)
                    ReadEntry();
            }
            else
            {
                while (m_CompressedSize != BaseStream.Length)
                    ReadEntry();
            }
        }

        private void ReadEntry()
        {
            var s_Segment = new CodecSegment
            {
                Offset = BaseStream.Position,
                UnpackedOffset = m_OriginalSize,
                Header = new CodecHeader((RimeReader)BaseStream),
            };

            m_CompressedSize += s_Segment.Header.PackedSize + 8;
            m_OriginalSize += s_Segment.Header.UnpackedSize;

            m_Segments.Add(s_Segment);

            // Seek to the beginning of the next segment.
            BaseStream.Seek(s_Segment.Header.PackedSize, SeekOrigin.Current);
        }

        public override long Seek(long p_Offset, SeekOrigin p_Origin)
        {
            InitialzeStream();

            if (p_Origin == SeekOrigin.Current && p_Offset == 0)
                return Position;
            
            if (p_Origin == SeekOrigin.Current && p_Offset > 0)
            {
                ReadBytes((int)p_Offset);
                return Position;
            }

            // just make relative absolute
            if (p_Origin == SeekOrigin.Current)
            {
                p_Offset += m_CurrentPosition;
                p_Origin = SeekOrigin.Begin;
            }

            if (p_Origin == SeekOrigin.Begin)
            {
                if (Position == p_Offset)
                    return Position;
                
                // scan from begin to offset
                for (var i = 0; i < m_Segments.Count; i++)
                {
                    var s_Segment = m_Segments[i];

                    if (p_Offset < s_Segment.UnpackedOffset)
                        throw new Exception("Somehow Skipped data chunk. Should never happen");

                    if (p_Offset >= (s_Segment.UnpackedOffset + s_Segment.Header.UnpackedSize))
                    {
                        continue;
                    }
                    
                    if (i != m_CurrentSegment || m_CurrentSegment == null)
                    {
                        m_SegmentStream?.Dispose();

                        m_CurrentSegment = i;
                        m_SegmentStream = GetStreamForSegment( m_Segments[m_CurrentSegment]);
                    }

                    m_SegmentStream.Seek(p_Offset - s_Segment.UnpackedOffset, SeekOrigin.Begin);
                    
                    m_CurrentPosition = p_Offset;
                    break;
                }

                return Position;
            }
            
            throw new NotSupportedException();
        }

        protected override int ReadInternal(byte[] p_Data, int p_Index, int p_Count)
        {
            InitialzeStream();

            if (m_SegmentStream == null)
                return 0;
            
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

                // Seek to the next segment.
                if (++m_CurrentSegment >= m_Segments.Count)
                    break;
                
                var s_NextSegment = m_Segments[m_CurrentSegment];
                m_SegmentStream.Dispose();
                    

                m_SegmentStream = GetStreamForSegment(s_NextSegment);
            }

            return p_Count - s_Remaining;
        }
    }
}
