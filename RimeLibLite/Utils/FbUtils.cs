namespace RimeLib.Utils
{
    /// <summary>
    /// Frostbite specific utilities
    /// </summary>
    public class FbUtils
    {
        private const uint FNV_OFFSET_BASIS = 0x1505;
        private const uint FNV_PRIME = 0x21;

        /// <summary>
        /// Implementation of fb::hashQuick
        /// Also known as FNVHash
        /// </summary>
        /// <param name="p_String">Input string</param>
        /// <returns>unsigned int hash of the string</returns>
        public static uint HashQuick(string p_String)
        {
            var s_Hash = FNV_OFFSET_BASIS;

            for (int i = 0; i < p_String.Length; ++i)
                s_Hash = (s_Hash * FNV_PRIME) ^ p_String[i];

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
            var s_Hash = FNV_OFFSET_BASIS;

            for (int i = 0; i < p_String.Length; ++i)
            {
                uint s_Current = p_String[i];
                var s_ConvertLower = ((p_String[i] - 'A') <= ('Z' - 'A'));

                s_Current = s_Current + 32 * (s_ConvertLower ? 1 : (uint)0);
                s_Hash = (s_Hash * FNV_PRIME) ^ s_Current;
            }

            return s_Hash;
        }
    }
}
