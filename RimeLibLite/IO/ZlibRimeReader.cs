using System;
using System.Diagnostics;
using System.IO;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

namespace RimeLib.IO
{
    public class ZlibRimeReader : RimeReader
    {
        public override bool CanSeek => false;

        public long? OriginalSize => m_OriginalSize;

        protected long? m_OriginalSize;
        protected long? m_CompressedSize;
        protected InflaterInputStream m_DeflateStream;
        protected long m_StartPosition;

        public ZlibRimeReader(RimeReader p_Reader, bool p_HasSizes, bool p_ShouldDispose = true) : 
            base(p_Reader, p_Reader.Endianness, p_ShouldDispose)
        {
            // If the user has specified there are sizes here, we should parse them.
            if (p_HasSizes)
                LoadSizes();

            // TODO: If we have sizes then create a limited reader to pass to the inflater stream.

            // Create the zlib / deflate decompression stream.
            m_DeflateStream = new InflaterInputStream(BaseStream);

            // Mark our starting position.
            m_StartPosition = BaseStream.Position;
        }

        public override void Dispose()
        {
            base.Dispose();
            m_DeflateStream.Dispose();
        }

        protected void LoadSizes()
        {
            m_OriginalSize = ((RimeReader) BaseStream).ReadUInt32();
            m_CompressedSize = ((RimeReader) BaseStream).ReadUInt32();
        }

        public override long Seek(long p_Offset, SeekOrigin p_Origin)
        {
            throw new NotSupportedException();
        }

        protected override int ReadInternal(byte[] p_Data, int p_Index, int p_Count)
        {
            Debug.WriteLine($"Zlib reader with a compressed size of {m_CompressedSize} reading {p_Count} bytes.");
            return m_DeflateStream.Read(p_Data, p_Index, p_Count);
        }
    }
}
