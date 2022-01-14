using System;
using System.IO;
using System.Text;
using RimeLib.IO.Conversion;

namespace RimeLib.IO
{
    public class RimeWriter : EndianBinaryWriter
    {
        public bool Obfuscated { get; internal set; }

        public byte[] XorTable { get; set; } = new byte[260];
		
        protected long m_ObfuscatedDataOffset;

        public RimeWriter(Stream p_Stream, Endianness p_Endianness = Endianness.LittleEndian, bool p_ShouldDispose = true)
            : base(p_Endianness == Endianness.BigEndian ? (EndianBitConverter) EndianBitConverter.Big : EndianBitConverter.Little, p_Stream, p_ShouldDispose)
        {
        }

        public void EnableObfuscation(byte[] p_XorTable)
        {
            // Make sure the XOR Table is the right size.
            if (p_XorTable.Length != 260)
                throw new ArgumentException("The obfuscation XOR table must contain exactly 260 bytes.", nameof(p_XorTable));

            // Write the XOR Table.
            XorTable = p_XorTable;
            Write(XorTable);

            // Enable de-obfuscation.
            m_ObfuscatedDataOffset = BaseStream.Position;
            Obfuscated = true;
        }

        public void DisableObfuscation()
        {
            Obfuscated = false;
            m_ObfuscatedDataOffset = 0;
        }

        public void WriteNullTerminatedString(string p_Value)
        {
            var s_Data = Encoding.ASCII.GetBytes(p_Value);
            Write(s_Data);
            Write((byte) 0x00);
        }

        public void WriteUnicodeString(string p_Value)
        {
            var s_Data = Encoding.Unicode.GetBytes(p_Value);
            Write(s_Data);
        }

        public void Encode7Bit(uint p_Value)
        {
            do
	        {
		        var s_Byte = (byte) (p_Value & 0x7F);
		        p_Value >>= 7;

		        if (p_Value != 0)
			        s_Byte |= 0x80;

	            Write(s_Byte);
	        } 
            while (p_Value != 0);
        }

        public void Encode7Bit(ulong p_Value)
        {
            do
            {
                var s_Byte = (byte)(p_Value & 0x7F);
                p_Value >>= 7;

                if (p_Value != 0)
                    s_Byte |= 0x80;

                Write(s_Byte);
            }
            while (p_Value != 0);
        }

        public void EncodeZigZag(int p_Value)
        {
            Encode7Bit((uint) ((p_Value >> 31) ^ (p_Value << 1)));
        }

        public void EncodeZigZag(long p_Value)
        {
            Encode7Bit((ulong) ((p_Value >> 63) ^ (p_Value << 1)));
        }

        public void Align(int p_Alignment, byte p_Padding = 0x00)
        {
            if (Position % p_Alignment == 0)
                return;

            var s_Number = p_Alignment - (Position % p_Alignment);

            for (var i = 0; i < s_Number; ++i)
                WriteByte(p_Padding);
        }

        protected override void WriteInternal(byte[] p_Value, int p_Offset, int p_Count)
        {
            // If we're writing in obfuscated mode we need to do some trickery.
            if (Obfuscated)
            {
                var s_CurrentOffset = BaseStream.Position - m_ObfuscatedDataOffset;

                // Copy the data so we don't modify the original buffer.
                var s_Data = new byte[p_Count];
                Buffer.BlockCopy(p_Value, p_Offset, s_Data, 0, p_Count);

                // XOR the data.
                for (var i = 0; i < s_Data.Length; ++i)
                    s_Data[i] ^= (byte)((XorTable[(s_CurrentOffset + i) % 257]) ^ 123);

                base.WriteInternal(s_Data, p_Offset, p_Count);
                return;
            }

            base.WriteInternal(p_Value, p_Offset, p_Count);
        }

        public void WriteNullBytes(uint p_NumberOfBytes)
        {
            var s_Bytes = new byte[p_NumberOfBytes];
            Write(s_Bytes);
        }
    }
}
