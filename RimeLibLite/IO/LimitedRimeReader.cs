/*
using System.IO;
using RimeLib.IO.Conversion;

namespace RimeLib.IO
{
    public class LimitedRimeReader : RimeReader
    {
        protected RimeReader? m_BaseReader;

        protected int m_Limit;

        protected long m_StartOffset;

        public LimitedRimeReader(Stream p_Stream, int p_Limit, Endianness p_Endianness = Endianness.LittleEndian) : 
            base(p_Stream, p_Endianness)
        {
            m_Limit = p_Limit;
            m_StartOffset = p_Stream.Position;
        }
        
        public LimitedRimeReader(RimeReader p_BaseReader, int p_Limit) : 
            base(new MemoryStream(), p_BaseReader.Endianness)
        {
            m_BaseReader = p_BaseReader;
            m_Limit = p_Limit;
        }

        protected override int ReadInternal(byte[] p_Data, int p_Index, int p_Count)
        {
            // Get the number of bytes to read.
            var s_RemainingBytes = m_Limit - m_Read;
            var s_BytesToRead = System.Math.Min(s_RemainingBytes, p_Count);

            // Read the data.
            var s_BytesRead = m_BaseReader?.Read(p_Data, p_Index, s_BytesToRead) 
                              ?? base.Read(p_Data, p_Index, s_BytesToRead);

            // Increment our read bytes.
            m_Read += s_BytesRead;

            return s_BytesRead;
        }
    }
}
*/
