using System;
using System.IO;

namespace RimeLib.IO
{
    /// <summary>
    /// The mirror of <see cref="BitReader"/>'s high-bit path: bits are written most-significant
    /// first, packed into bytes in order.
    ///
    /// This did not exist, which is why every bit-packed audio header's Serialize threw
    /// NotImplementedException -- the XAS codec itself can already encode
    /// (<see cref="RimeLib.Audio.EA.Audio.Xas1"/>), so the missing piece was never the codec, only
    /// the container.
    /// </summary>
    public class BitWriter : IDisposable
    {
        private readonly Stream m_Stream;
        private readonly bool m_ShouldDispose;
        private int m_Current;
        private int m_BitsUsed;

        public BitWriter(Stream p_Stream, bool p_ShouldDispose = false)
        {
            m_Stream = p_Stream;
            m_ShouldDispose = p_ShouldDispose;
        }

        public void WriteHighBit(bool p_Value)
        {
            m_Current = (m_Current << 1) | (p_Value ? 1 : 0);
            m_BitsUsed++;

            if (m_BitsUsed != 8)
                return;

            m_Stream.WriteByte((byte)m_Current);
            m_Current = 0;
            m_BitsUsed = 0;
        }

        public void WriteUIntHigh(ulong p_Value, int p_BitCount)
        {
            for (var i = p_BitCount - 1; i >= 0; i--)
                WriteHighBit(((p_Value >> i) & 1) != 0);
        }

        public void WriteIntHigh(long p_Value, int p_BitCount)
        {
            WriteUIntHigh(unchecked((ulong)p_Value), p_BitCount);
        }

        /// <summary>Pads the final partial byte with zero bits, as the reader expects.</summary>
        public void Flush()
        {
            if (m_BitsUsed == 0)
                return;

            m_Stream.WriteByte((byte)(m_Current << (8 - m_BitsUsed)));
            m_Current = 0;
            m_BitsUsed = 0;
        }

        public void Dispose()
        {
            Flush();

            if (m_ShouldDispose)
                m_Stream.Dispose();
        }
    }
}
