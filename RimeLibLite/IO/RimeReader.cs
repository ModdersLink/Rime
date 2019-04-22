using System.IO;
using System.Text;
using RimeLib.IO.Conversion;

namespace RimeLib.IO
{
    public class RimeReader : EndianBinaryReader
    {
        public bool Obfuscated { get; internal set; }

        public byte[] XorTable { get; set; } = new byte[260];
		
        protected long m_ObfuscatedDataOffset;

        /// <summary>
        /// IceReader Default Constructor
        /// </summary>
        /// <param name="p_Stream">Opened stream</param>
        /// <param name="p_Endianness">The endianness of the stream, BigEndian or LittleEndian (default LittleEndian)</param>
        public RimeReader(Stream p_Stream, Endianness p_Endianness = Endianness.LittleEndian)
            : base(p_Endianness == Endianness.BigEndian ? (EndianBitConverter)EndianBitConverter.Big : EndianBitConverter.Little, p_Stream)
        {
        }

        /// <summary>
        /// IceReader Custom Encoding Constructor
        /// </summary>
        /// <param name="p_Stream">Opened input stream</param>
        /// <param name="p_Encoding">Type of encoding the stream is suppose to use</param>
        /// <param name="p_Endianness">The endianness of the stream, BigEndian or LittleEndian (default LittleEndian)</param>
        public RimeReader(Stream p_Stream, Encoding p_Encoding, Endianness p_Endianness = Endianness.LittleEndian)
            : base(p_Endianness == Endianness.BigEndian ? (EndianBitConverter)EndianBitConverter.Big : EndianBitConverter.Little, p_Stream, p_Encoding)
        {
        }

        public void SetEndianness(Endianness p_Endianness)
        {
            m_BitConverter = p_Endianness == Endianness.BigEndian ? (EndianBitConverter) EndianBitConverter.Big : EndianBitConverter.Little;
        }

        public Endianness GetEndianness()
        {
            return (m_BitConverter is BigEndianBitConverter) ? Endianness.BigEndian : Endianness.LittleEndian;
        }

        /// <summary>
        /// Enables data de-obfuscation for the currently read stream.
        /// </summary>
        public void EnableDeobfuscation()
        {
            // Skip the signature data.
            Seek(292, SeekOrigin.Current);

            // Read the XOR Table.
            XorTable = ReadBytes(260);

            // Enable de-obfuscation.
            m_ObfuscatedDataOffset = BaseStream.Position;
            Obfuscated = true;
        }

        /// <summary>
        /// Disables data de-obfuscation for the currently read stream.
        /// </summary>
        public void DisableDeobfuscation()
        {
            Obfuscated = false;
            m_ObfuscatedDataOffset = 0;
        }

        /// <summary>
        /// Reads out a null terminated string
        /// </summary>
        /// <returns>String with the data inside</returns>
        public string ReadNullTerminatedString()
        {
            char s_TempChar;
            var s_ReturnString = "";

            while ((s_TempChar = (char)ReadByte()) != '\0')
            {
                if (s_TempChar != '\0')
                    s_ReturnString += s_TempChar;
            }

            return s_ReturnString;
        }

        /// <summary>
        /// Reads out a basic-unicode based string
        /// </summary>
        /// <param name="p_Length">Length of the unicode string</param>
        /// <returns>String in ASCII formatting</returns>
        public string ReadUnicodeString(int p_Length)
        {
            var s_ReturnString = "";

            while (p_Length-- > 0)
            {
                var ch = ReadUInt16();
                s_ReturnString += (char)ch;
            }

            return s_ReturnString.Replace("\0", "");
        }

        public char ReadChar()
        {
            return (char) ReadByte();
        }

        public char[] ReadChars(int p_Length)
        {
            return Encoding.UTF8.GetString(ReadBytes(p_Length)).ToCharArray();
        }

        public int Decode77Number()
        {
            var s_Total = 0;

            while (true)
            {
                var s_Byte = ReadByte();
                s_Total += s_Byte;
                if (s_Byte != 0xFF)
                    return s_Total;
            }
        }

        public uint Decode7Bit(out int p_BytesRead)
        {
            p_BytesRead = 1;
            var s_Slice = (uint) ReadByte();

            var s_Result = s_Slice & 0x7F;

            if ((s_Slice & 0x80) == 0)
                return s_Result;

            ++p_BytesRead;
            s_Slice = ReadByte();
            s_Result |= (s_Slice & 0x7F) << 7;

            if ((s_Slice & 0x80) == 0) 
                return s_Result;

            ++p_BytesRead;
            s_Slice = ReadByte();
            s_Result |= (s_Slice & 0x7F) << 14;

            var s_Shift = 21;

            while ((s_Slice & 0x80) != 0)
            {
                ++p_BytesRead;
                s_Slice = ReadByte();
                s_Result |= (s_Slice & 0x7F) << s_Shift;
                s_Shift += 7;
            }

            return s_Result;
        }

        public ulong Decode7Bit64(out int p_BytesRead)
        {
            p_BytesRead = 1;
            var s_Slice = (uint) ReadByte();

            ulong s_Result = s_Slice & 0x7F;

            if ((s_Slice & 0x80) == 0)
                return s_Result;

            ++p_BytesRead;
            s_Slice = ReadByte();
            s_Result |= (ulong) (s_Slice & 0x7F) << 7;

            if ((s_Slice & 0x80) == 0) 
                return s_Result;

            ++p_BytesRead;
            s_Slice = ReadByte();
            s_Result |= (ulong) (s_Slice & 0x7F) << 14;

            var s_Shift = 21;

            while ((s_Slice & 0x80) != 0)
            {
                ++p_BytesRead;
                s_Slice = ReadByte();
                s_Result |= (ulong) (s_Slice & 0x7F) << s_Shift;
                s_Shift += 7;
            }

            return s_Result;
        }

        public uint Read7Bit()
        {
            return Decode7Bit(out _);
        }

        public int DecodeZigZag(out int p_BytesRead)
        {
            var v1 = Decode7Bit(out p_BytesRead);
            var v2 = v1 >> 1;
            var v3 = (int) (v1 << 31);
            return (int) (v2 ^ (v3 >> 31));
        }

        public long DecodeZigZag64(out int p_BytesRead)
        {
            var v1 = Decode7Bit64(out p_BytesRead);
            var v2 = (long) (v1 >> 1);
            var v3 = v2 ^ (long) (v1 << 63 >> 63);
            return v3;
        }

        public int ReadZigZag()
        {
            return DecodeZigZag(out _);
        }

        public int Free7Bit()
        {
            int s_Gap = 0;

            while (ReadByte() != 0)
                ++s_Gap;

            return s_Gap;
        }

        public override int Read(byte[] p_Data, int p_Index, int p_Count)
        {
            var s_CurrentOffset = BaseStream.Position + p_Index - m_ObfuscatedDataOffset;
            var s_ReadBytes = base.Read(p_Data, p_Index, p_Count);

            if (!Obfuscated)
                return s_ReadBytes;

            for (var i = 0; i < s_ReadBytes; ++i)
                p_Data[i] ^= (byte)((XorTable[(s_CurrentOffset + i) % 257]) ^ 123);

            return s_ReadBytes;
        }

        public override byte[] ReadBytes(int p_Count)
        {
            var s_CurrentOffset = BaseStream.Position - m_ObfuscatedDataOffset;
            var s_ReadBytes = base.ReadBytes(p_Count);

            if (!Obfuscated)
                return s_ReadBytes;

            for (var i = 0; i < s_ReadBytes.Length; ++i)
                s_ReadBytes[i] ^= (byte)((XorTable[(s_CurrentOffset + i) % 257]) ^ 123);

            return s_ReadBytes;
        }

        protected override void ReadInternal(byte[] p_Data, int p_Size)
        {
            var s_CurrentOffset = BaseStream.Position - m_ObfuscatedDataOffset;
            base.ReadInternal(p_Data, p_Size);

            if (!Obfuscated)
                return;

            for (var i = 0; i < p_Data.Length; ++i)
                p_Data[i] ^= (byte)((XorTable[(s_CurrentOffset + i) % 257]) ^ 123);
        }

        protected override int TryReadInternal(byte[] p_Data, int p_Size)
        {
            var s_CurrentOffset = BaseStream.Position - m_ObfuscatedDataOffset;
            var s_ReadBytes = base.TryReadInternal(p_Data, p_Size);

            if (!Obfuscated)
                return s_ReadBytes;

            for (var i = 0; i < s_ReadBytes; ++i)
                p_Data[i] ^= (byte)((XorTable[(s_CurrentOffset + i) % 257]) ^ 123);

            return s_ReadBytes;
        }
    }
}
