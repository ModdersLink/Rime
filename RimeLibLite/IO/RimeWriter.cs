using System;
using System.IO;
using System.Text;
using RimeLib.IO.Conversion;

namespace RimeLib.IO
{
    public class RimeWriter : EndianBinaryWriter
    {
        public RimeWriter(Stream p_Stream, Endianness p_Endianness = Endianness.LittleEndian)
            : base(p_Endianness == Endianness.BigEndian ? (EndianBitConverter) EndianBitConverter.Big : EndianBitConverter.Little, p_Stream)
        {
        }

        public RimeWriter(Stream p_Stream, Encoding p_Encoding, Endianness p_Endianness = Endianness.LittleEndian)
            : base(p_Endianness == Endianness.BigEndian ? (EndianBitConverter)EndianBitConverter.Big : EndianBitConverter.Little, p_Stream, p_Encoding)
        {
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

        public void Encode7Bit(UInt32 p_Value)
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

        public void Encode7Bit(UInt64 p_Value)
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

        public void EncodeZigZag(Int32 p_Value)
        {
            Encode7Bit((UInt32)((p_Value >> 31) ^ (p_Value << 1)));
        }

        public void EncodeZigZag(Int64 p_Value)
        {
            Encode7Bit((UInt64)((p_Value >> 63) ^ (p_Value << 1)));
        }
    }
}
