using RimeLib.IO.Conversion;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimeLib.IO
{
    public class XorRimeWriter : RimeWriter
    {
        //public override bool CanRead => false;


        public bool XorEnabled { get; internal set; } = true;

        protected byte[] XorKey { get; set; } = new byte[0];

        protected long m_XorDataOffset;

        public XorRimeWriter(Stream p_Stream, byte[] p_XorKey, Endianness p_Endianness = Endianness.LittleEndian, bool p_ShouldDispose = true) :
            base(p_Stream, p_Endianness, p_ShouldDispose)
        {
            XorKey = p_XorKey;
            EnableObfuscation();
        }

        public XorRimeWriter(RimeWriter p_Writer, byte[] p_XorKey, bool p_ShouldDispose = true) :
            base(p_Writer, p_Writer.Endianness, p_ShouldDispose)
        {
            XorKey = p_XorKey;
            EnableObfuscation();
        }


        public void EnableObfuscation()
        {
            // Enable de-obfuscation.
            m_XorDataOffset = BaseStream.Position;
            XorEnabled = true;
        }

        public void DisableObfuscation()
        {
            XorEnabled = false;
            m_XorDataOffset = 0;
        }

        protected override void WriteInternal(byte[] p_Value, int p_Offset, int p_Count)
        {
            // If we're writing in obfuscated mode we need to do some trickery.
            if (XorEnabled)
            {
                var s_CurrentOffset = BaseStream.Position - m_XorDataOffset;

                // Copy the data so we don't modify the original buffer.
                var s_Data = new byte[p_Count];
                Buffer.BlockCopy(p_Value, p_Offset, s_Data, 0, p_Count);

                // XOR the data.
                for (var i = 0; i < s_Data.Length; ++i)
                    s_Data[i] ^= XorKey[(s_CurrentOffset + i) % XorKey.LongLength];

                base.WriteInternal(s_Data, p_Offset, p_Count);
                return;
            }

            base.WriteInternal(p_Value, p_Offset, p_Count);
        }

    }
 
}
