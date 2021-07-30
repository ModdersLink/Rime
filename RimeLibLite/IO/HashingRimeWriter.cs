using System;
using System.IO;
using System.Security.Cryptography;
using RimeLib.Frostbite.Core;
using RimeLib.IO.Conversion;

namespace RimeLib.IO
{
    public class HashingRimeWriter : RimeWriter
    {
        private readonly SHA1 m_Sha1 = new SHA1CryptoServiceProvider();
        private bool m_Hashed;

        public override bool CanSeek => false;
        public override bool CanRead => false;

        public HashingRimeWriter(Stream p_Stream, Endianness p_Endianness = Endianness.LittleEndian, bool p_ShouldDispose = true) :
            base(p_Stream, p_Endianness, p_ShouldDispose)
        {
        }

        public HashingRimeWriter(RimeWriter p_Writer, bool p_ShouldDispose = true) :
            base(p_Writer, p_Writer.Endianness, p_ShouldDispose)
        {
        }

        protected override void WriteInternal(byte[] p_Value, int p_Offset, int p_Count)
        {
            if (m_Hashed)
                throw new Exception("Cannot write more data to a hash writer that has its hash already calculated.");

            m_Sha1.TransformBlock(p_Value, p_Offset, p_Count, null, 0);
            base.WriteInternal(p_Value, p_Offset, p_Count);
        }

        public Sha1 GetHash()
        {
            if (m_Hashed)
#pragma warning disable CS8604 // Possible null reference argument.
                return new Sha1(m_Sha1.Hash);
#pragma warning restore CS8604 // Possible null reference argument.

            m_Sha1.TransformFinalBlock(new byte[0], 0, 0);
            m_Hashed = true;
            
#pragma warning disable CS8604 // Possible null reference argument.
            return new Sha1(m_Sha1.Hash);
#pragma warning restore CS8604 // Possible null reference argument.
        }
    }
}
