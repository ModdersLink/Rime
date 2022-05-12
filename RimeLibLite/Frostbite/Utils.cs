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
    }
}
