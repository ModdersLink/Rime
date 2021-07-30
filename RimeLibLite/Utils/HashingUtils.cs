using System.IO;
using System.Security.Cryptography;
using RimeLib.Frostbite.Core;

namespace RimeLib.Utils
{
    public static class HashingUtils
    {
        public static Sha1 HashFromStream(Stream p_Stream, long? p_Length = null)
        {
            var s_Sha1 = new SHA1CryptoServiceProvider();

            var s_TransferBuffer = new byte[32 * 1024];
            var s_LeftBytes = p_Length ?? 0;

            do
            {
                var s_BytesToRead = s_TransferBuffer.Length;
                
                if (p_Length.HasValue)
                    s_BytesToRead = (int) System.Math.Min(s_LeftBytes, s_TransferBuffer.Length);

                var s_ReadBytes = p_Stream.Read(s_TransferBuffer, 0, s_BytesToRead);

                if (s_ReadBytes == 0)
                    break;

                // Feed into the hasher.
                s_Sha1.TransformBlock(s_TransferBuffer, 0, s_ReadBytes, null, 0);

                if (p_Length.HasValue)
                    s_BytesToRead -= s_ReadBytes;

                if (s_BytesToRead <= 0)
                    break;
            } 
            while (true);

            s_Sha1.TransformFinalBlock(new byte[0], 0, 0);
#pragma warning disable CS8604 // Possible null reference argument.
            return new Sha1(s_Sha1.Hash);
#pragma warning restore CS8604 // Possible null reference argument.
        }
    }
}
