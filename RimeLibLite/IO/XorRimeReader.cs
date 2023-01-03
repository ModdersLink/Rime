using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RimeLib.IO
{
    public class XorRimeReader : RimeReader
    {
        public bool XorEnabled { get; internal set; } = true;

        protected byte[] XorKey { get; set; } = new byte[260];
        protected long m_XorDataOffset = 0;

        public XorRimeReader(RimeReader p_Stream, byte[] p_XorKey, bool p_ShouldDispose = true) :
            base(p_Stream, p_Stream.Endianness, p_ShouldDispose)
        {

            // In FileObfuscationHeader its 260, but only 257 is used..
            XorKey = p_XorKey;
            EnableXor();
        }

        /// <summary>
        /// Enables data de-obfuscation for the currently read stream.
        /// </summary>
        public void EnableXor()
        {
            XorEnabled = true;
            m_XorDataOffset = BaseStream.Position;
        }

        /// <summary>
        /// Disables data de-obfuscation for the currently read stream.
        /// </summary>
        public void DisableXor()
        {
            XorEnabled = false;
            m_XorDataOffset = 0;
        }

        protected override int ReadInternal(byte[] p_Data, int p_Index, int p_Count)
        {
            CheckDisposed();

            var s_CurrentOffset = BaseStream.Position + p_Index - m_XorDataOffset;
            var s_ReadBytes = base.ReadInternal(p_Data, p_Index, p_Count);
           
            // if its under start, return null? should probably exception
            if (s_CurrentOffset < 0)
                throw new IndexOutOfRangeException("Trying to read xordata beneeth the xor section!");
                //return s_ReadBytes;

            for (var i = 0; i < s_ReadBytes; ++i)
                p_Data[i] ^= XorKey[(s_CurrentOffset + i) % XorKey.LongLength];

            return s_ReadBytes;
        }
    }
}
