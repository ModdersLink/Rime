using System.IO;
using ICSharpCode.SharpZipLib;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

namespace RimeLib.IO
{
    public class ZlibRimeReader : RimeReader
    {
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

        protected override int ReadInternal(byte[] p_Data, int p_Index, int p_Count)
        {
            return m_DeflateStream.Read(p_Data, p_Index, p_Count);
            /*// User has requested p_Count bytes. Read as much from the base reader.
            var s_ReadBytes = 0;

            while (s_ReadBytes < p_Count)
            {
                // Now, the problem is that in cases where we don't know the size of the compressed stream.
                // In these cases we want to be a bit conservative and feed data into the deflate stream one
                // byte at time. This will be slow, obviously, but it's the only safe way.
                long s_BytesToRead = 1;
                var s_BytesLeft = p_Count - s_ReadBytes;

                if (m_CompressedSize != null)
                {
                    // Check if we have enough data to read.
                    var s_CurrentPosition = BaseStream.Position - m_StartPosition;

                    if (s_CurrentPosition >= m_CompressedSize)
                        throw new EndOfStreamException("End of stream reached with " + s_BytesLeft + " bytes left to read.");
                
                    var s_RemainingBytes = m_CompressedSize.Value - s_CurrentPosition;
                    s_BytesToRead = System.Math.Min(s_RemainingBytes, p_Count);
                }

                // Feed some data to the deflate stream.
                m_MemoryStream.Write(m_BaseReader.ReadBytes((int) s_BytesToRead));
                m_MemoryStream.Flush();
                m_MemoryStream.Seek(-s_BytesToRead, SeekOrigin.Current);

                // Read as many data as we have left.
                try
                {
                    s_ReadBytes += m_DeflateStream.Read(p_Data, p_Index + s_ReadBytes, s_BytesLeft);
                }
                catch (SharpZipBaseException s_Exception)
                {
                    // If we've hit an EOF just continue feeding data to the deflate stream.
                    if (s_Exception.Message == "Unexpected EOF")
                    {
                        
                        continue;
                    }

                    throw;
                }
            }

            return p_Count;*/
        }
    }
}
