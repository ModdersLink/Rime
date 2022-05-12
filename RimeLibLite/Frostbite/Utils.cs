using System.IO;
using RimeLib.IO;
using RimeLib.IO.Conversion;

namespace RimeLib.Frostbite
{
    /// <summary>
    /// Frostbite specific utilities
    /// </summary>
    public class Utils
    {
        private const uint c_FnvOffsetBasis = 0x1505;
        private const uint c_FnvPrime = 0x21;

        /// <summary>
        /// Implementation of fb::hashQuick
        /// Also known as FNVHash
        /// </summary>
        /// <param name="p_String">Input string</param>
        /// <returns>unsigned int hash of the string</returns>
        public static uint HashQuick(string p_String)
        {
            var s_Hash = c_FnvOffsetBasis;

            for (int i = 0; i < p_String.Length; ++i)
                s_Hash = (s_Hash * c_FnvPrime) ^ p_String[i];

            return s_Hash;
        }

        /// <summary>
        /// Implementation of fb::hashQuickLowerCase
        /// Also known as FNVHash_LowerCase
        /// </summary>
        /// <param name="p_String">Input string</param>
        /// <returns>unsigned integer hash of the string</returns>
        public static uint HashQuickLowerCase(string p_String)
        {
            return HashQuick(p_String.ToLowerInvariant());
        }

        public static uint Fletcher32(byte[] p_Data)
        {
            using var s_Reader = new RimeReader(new MemoryStream(p_Data), Endianness.BigEndian);
            
            uint s_C0 = 0;
            uint s_C1 = 0;

            var s_Len = p_Data.Length / 2;

            while (s_Len > 0)
            {
                var s_BlockLen = System.Math.Min(s_Len, 360);
                s_Len -= s_BlockLen;

                do
                {
                    s_C0 += s_Reader.ReadUInt16();
                    s_C1 += s_C0;
                    --s_BlockLen;
                }
                while (s_BlockLen > 0);

                s_C0 = (s_C0 & 0xFFFF) + (s_C0 >> 16);
                s_C1 = (s_C1 & 0xFFFF) + (s_C1 >> 16);
            }

            if (p_Data.Length % 2 != 0)
            {
                s_C0 += s_Reader.ReadUByte();
                s_C1 += s_C1;
            }
            
            s_C0 = (s_C0 & 0xFFFF) + (s_C0 >> 16);
            s_C1 = (s_C1 & 0xFFFF) + (s_C1 >> 16);

            return s_C0 << 16 | s_C1;
        }
    }
}
