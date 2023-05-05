using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RimeLib.Utils
{
    /// <summary>
    /// Cryptography class to handle Frostbite file verification
    /// </summary>
    public class CryptoUtils
    {
        /// <summary>
        /// The BCryptOpenAlgorithmProvider function loads and initializes a CNG provider.
        /// </summary>
        /// <param name="p_PhAlgorithm">A pointer to a BCRYPT_ALG_HANDLE variable that receives the CNG provider handle. When you have finished using this handle, release it by passing it to the BCryptCloseAlgorithmProvider function.</param>
        /// <param name="p_PszAlgId">A pointer to a null-terminated Unicode string that identifies the requested cryptographic algorithm. This can be one of the standard CNG Algorithm Identifiers or the identifier for another registered algorithm.</param>
        /// <param name="p_PszImplementation">A pointer to a null-terminated Unicode string that identifies the specific provider to load. This is the registered alias of the cryptographic primitive provider. This parameter is optional and can be NULL if it is not needed. If this parameter is NULL, the default provider for the specified algorithm will be loaded.</param>
        /// <param name="p_DwFlags">Flags that modify the behavior of the function. </param>
        /// <returns></returns>
        [DllImport("bcrypt.dll")]
        public static extern UInt32 BCryptOpenAlgorithmProvider(ref IntPtr p_PhAlgorithm, [MarshalAs(UnmanagedType.LPWStr)] String p_PszAlgId, [MarshalAs(UnmanagedType.LPWStr)] String p_PszImplementation, UInt32 p_DwFlags);

        /// <summary>
        /// The BCryptImportKeyPair function imports a public/private key pair from a key BLOB. The BCryptImportKey function is used to import a symmetric key pair.
        /// </summary>
        /// <param name="p_PhAlgorithm">The handle of the algorithm provider to import the key. This handle is obtained by calling the BCryptOpenAlgorithmProvider function.</param>
        /// <param name="p_HImportKey">This parameter is not currently used and should be NULL.</param>
        /// <param name="p_PszBlobType">A null-terminated Unicode string that contains an identifier that specifies the type of BLOB that is contained in the pbInput buffer. This can be one of the following values.</param>
        /// <param name="p_PhKey">A pointer to a BCRYPT_KEY_HANDLE that receives the handle of the imported key. This handle is used in subsequent functions that require a key, such as BCryptSignHash. This handle must be released when it is no longer needed by passing it to the BCryptDestroyKey function.</param>
        /// <param name="p_PbInput">The address of a buffer that contains the key BLOB to import. The cbInput parameter contains the size of this buffer. The pszBlobType parameter specifies the type of key BLOB this buffer contains.</param>
        /// <param name="p_CbInput">The size, in bytes, of the pbInput buffer.</param>
        /// <param name="p_DwFlags">A set of flags that modify the behavior of this function.</param>
        /// <returns></returns>
        [DllImport("bcrypt.dll")]
        public static extern UInt32 BCryptImportKeyPair(IntPtr p_PhAlgorithm, IntPtr p_HImportKey, [MarshalAs(UnmanagedType.LPWStr)] String p_PszBlobType, ref IntPtr p_PhKey, Byte[] p_PbInput, UInt32 p_CbInput, UInt32 p_DwFlags);

        /// <summary>
        /// The BCryptSignHash function creates a signature of a hash value.
        /// </summary>
        /// <param name="p_HKey">The handle of the key to use to sign the hash.</param>
        /// <param name="p_PPaddingInfo">A pointer to a structure that contains padding information. The actual type of structure this parameter points to depends on the value of the dwFlags parameter. This parameter is only used with asymmetric keys and must be NULL otherwise.</param>
        /// <param name="p_PbInput">A pointer to a buffer that contains the hash value to sign. The cbInput parameter contains the size of this buffer.</param>
        /// <param name="p_CbInput">The number of bytes in the pbInput buffer to sign.</param>
        /// <param name="p_PbOutput">The address of a buffer to receive the signature produced by this function. The cbOutput parameter contains the size of this buffer.</param>
        /// <param name="p_CbOutput">The size, in bytes, of the pbOutput buffer. </param>
        /// <param name="p_PcbResult">A pointer to a ULONG variable that receives the number of bytes copied to the pbOutput buffer. </param>
        /// <param name="p_DwFlags">A set of flags that modify the behavior of this function.</param>
        /// <returns></returns>
        [DllImport("bcrypt.dll")]
        public static extern UInt32 BCryptSignHash(IntPtr p_HKey, [MarshalAs(UnmanagedType.LPWStr)] ref String p_PPaddingInfo, Byte[] p_PbInput, UInt32 p_CbInput, Byte[] p_PbOutput, UInt32 p_CbOutput, ref UInt32 p_PcbResult, UInt32 p_DwFlags);

        /// <summary>
        /// The BCryptVerifySignature function verifies that the specified signature matches the specified hash.
        /// </summary>
        /// <param name="p_HKey">The handle of the key to use to decrypt the signature.</param>
        /// <param name="p_PPaddingInfo">A pointer to a structure that contains padding information. </param>
        /// <param name="p_PbHash">The address of a buffer that contains the hash of the data. </param>
        /// <param name="p_CbHash">The size, in bytes, of the pbHash buffer.</param>
        /// <param name="p_PbSignature">The address of a buffer that contains the signed hash of the data. </param>
        /// <param name="p_CbSignature">The size, in bytes, of the pbSignature buffer. </param>
        /// <param name="p_DwFlags">A set of flags that modify the behavior of this function. </param>
        /// <returns></returns>
        [DllImport("bcrypt.dll")]
        public static extern UInt32 BCryptVerifySignature(IntPtr p_HKey, [MarshalAs(UnmanagedType.LPWStr)] ref String p_PPaddingInfo, Byte[] p_PbHash, UInt32 p_CbHash, Byte[] p_PbSignature, UInt32 p_CbSignature, UInt32 p_DwFlags);

        /// <summary>
        /// The BCryptDestroyKey function destroys a key.
        /// </summary>
        /// <param name="p_HKey">The handle of the key to destroy.</param>
        /// <returns>Returns a status code that indicates the success or failure of the function.</returns>
        [DllImport("bcrypt.dll")]
        public static extern UInt32 BCryptDestroyKey(IntPtr p_HKey);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_HAlgorithm"></param>
        /// <param name="p_DwFlags"></param>
        /// <returns></returns>
        [DllImport("bcrypt.dll")]
        public static extern UInt32 BCryptCloseAlgorithmProvider(IntPtr p_HAlgorithm, UInt32 p_DwFlags);

        // BCrypt constants
        const string BcryptRsaAlgorithm = "RSA";
        const string BcryptRsapublicBlob = "RSAPUBLICBLOB";
        const string BcryptRsaprivateBlob = "RSAPRIVATEBLOB";
        const string BcryptSha1Algorithm = "SHA1";
        const uint BcryptPadPkcs1 = 0x00000002;

        // NTSTATUS constants
        const uint StatusSuccess = 0;
        const uint StatusInvalidSignature = 0xC000A000;

        /// <summary>
        /// Verifies a RSA HMACSHA1 signature with the data and message
        /// </summary>
        /// <param name="p_Data">Data to check</param>
        /// <param name="p_Signature">Signature to check for the data</param>
        /// <param name="p_PublicKey">Public key to check the data</param>
        /// <param name="p_Message">Message to check the data</param>
        /// <returns>true if successful, false if bad signature</returns>
        public static bool VerifySignature(byte[] p_Data, byte[] p_Signature, byte[] p_PublicKey, byte[] p_Message)
        {
            var s_Key = IntPtr.Zero; // BCRYPT_KEY_HANDLE
            var s_Algorithm = IntPtr.Zero; // BCRYPT_ALG_HANDLE

            // Open up a new algorithm provider
            var s_Ret = BCryptOpenAlgorithmProvider(ref s_Algorithm, BcryptRsaAlgorithm, "", 0);
            if (s_Ret != StatusSuccess)
            {
                // TODO: Error
                return false;
            }

            // Import the RSA public key
            s_Ret = BCryptImportKeyPair(s_Algorithm, IntPtr.Zero, BcryptRsapublicBlob, ref s_Key, p_PublicKey, (uint)p_PublicKey.Length, 0);
            if (s_Ret != StatusSuccess)
            {
                // Cleanup
                BCryptCloseAlgorithmProvider(s_Algorithm, 0);
                s_Algorithm = IntPtr.Zero;

                // TODO: Error
                return false;
            }

            // Create our new HMACSHA generator, using the message as the key
            var s_Hmac = new HMACSHA1(p_Message);

            // Compute the has of the data using the previously set up hmac sha1.
            var s_Hash = s_Hmac.ComputeHash(p_Data);

            // BCrypt stuff
            var s_PaddingInfo = BcryptSha1Algorithm;

            // Verify the signature
            s_Ret = BCryptVerifySignature(s_Key, ref s_PaddingInfo, s_Hash, (uint)s_Hash.Length, p_Signature, (uint)p_Signature.Length, BcryptPadPkcs1);
            if (s_Ret != StatusSuccess)
            {
                BCryptDestroyKey(s_Key);
                BCryptCloseAlgorithmProvider(s_Algorithm, 0);
                s_Key = IntPtr.Zero;
                s_Algorithm = IntPtr.Zero;

                if (s_Ret == StatusInvalidSignature)
                {
                    // TODO: Invalid Signature Message
                }
                // TODO: Error
                return false;
            }

            // Lets clean up everything that we used thus far
            BCryptDestroyKey(s_Key);
            BCryptCloseAlgorithmProvider(s_Algorithm, 0);
            s_Key = IntPtr.Zero;
            s_Algorithm = IntPtr.Zero;
            s_Hmac.Clear();

            // Signatures good ;)
            return true;
        }

        /// <summary>
        /// Creates a RSA HMAC SHA1 signature
        /// </summary>
        /// <param name="p_Data">Data to take the hash of</param>
        /// <param name="p_PrivateKey">Private key data</param>
        /// <param name="p_Message">Message to sign with</param>
        /// <returns></returns>
        public static byte[] CreateSignature(byte[] p_Data, byte[] p_PrivateKey, byte[] p_Message)
        {
            // Variables
            var s_Key = IntPtr.Zero; // BCRYPT_KEY_HANDLE
            var s_Algorithm = IntPtr.Zero; // BCRYPT_ALG_HANDLE

            // Open up a new algorithm provider
            var s_Ret = BCryptOpenAlgorithmProvider(ref s_Algorithm, BcryptRsaAlgorithm, "", 0);
            if (s_Ret != StatusSuccess)
            {
                // TODO: Error
                return null;
            }

            // Import the RSA public key
            s_Ret = BCryptImportKeyPair(s_Algorithm, IntPtr.Zero, BcryptRsaprivateBlob, ref s_Key, p_PrivateKey, (uint)p_PrivateKey.Length, 0);
            if (s_Ret != StatusSuccess)
            {
                // Cleanup
                BCryptCloseAlgorithmProvider(s_Algorithm, 0);
                s_Algorithm = IntPtr.Zero;

                // TODO: Error
                return null;
            }

            // Create our new HMACSHA generator, using the message as the key
            var s_Hmac = new HMACSHA1(p_Message);

            // Compute the has of the data using the previously set up hmac sha1.
            var s_Hash = s_Hmac.ComputeHash(p_Data);

            // BCrypt stuff
            var s_PaddingInfo = BcryptSha1Algorithm;
            uint s_SignatureSize = 0;

            // Call sign hash one time to get the length of the signature
            s_Ret = BCryptSignHash(s_Key, ref s_PaddingInfo, s_Hash, (uint)s_Hash.Length, null, 0, ref s_SignatureSize, BcryptPadPkcs1);
            if (s_Ret != StatusSuccess)
            {
                BCryptDestroyKey(s_Key);
                BCryptCloseAlgorithmProvider(s_Algorithm, 0);

                return null;
            }

            // Create a place to hold the newly generated signature
            var s_Signature = new byte[s_SignatureSize];
            uint s_Size = 0;

            // Call BCryptSignHash again to actually generate the signature
            s_Ret = BCryptSignHash(s_Key, ref s_PaddingInfo, s_Hash, (uint)s_Hash.Length, s_Signature, s_SignatureSize, ref s_Size, BcryptPadPkcs1);
            if (s_Ret != StatusSuccess)
            {
                BCryptDestroyKey(s_Key);
                BCryptCloseAlgorithmProvider(s_Algorithm, 0);

                return null;
            }

            // Cleanup
            BCryptDestroyKey(s_Key);
            BCryptCloseAlgorithmProvider(s_Algorithm, 0);
            s_Key = IntPtr.Zero;
            s_Algorithm = IntPtr.Zero;

            return s_Signature;
        }
    }

}
