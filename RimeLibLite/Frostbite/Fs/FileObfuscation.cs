using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RimeLib.Frostbite.Fs
{
    public class FileObfuscation
    {
        static readonly byte[] c_CoreSeedPart = Encoding.ASCII.GetBytes(@"2e33ae4783feead2");

        static readonly byte[] c_HMacKey = Encoding.ASCII.GetBytes(@"Powered by Frostbite \o/ EA Digital Illusions CE AB");

        const int c_KeySize = 0x100;

        public FileObfuscation()
        {
        }
        public FileObfuscation(RimeReader p_Reader, out RimeReader p_OutReader)
        {
            Parse(p_Reader, out p_OutReader);
        }

        protected bool m_HasHeader = false;

        protected byte[] m_Signature = new byte[c_KeySize];


        public bool HasHeader => m_HasHeader;


        private bool ValidateData(byte[] p_Data, RSAParameters? p_Key = null)
        {
            if (p_Key == null)
                return false;

            var s_Mac = new HMACSHA1(c_HMacKey);

            var s_Hash = s_Mac.ComputeHash(p_Data);

            using var s_Rsa = new RSACryptoServiceProvider();
            s_Rsa.ImportParameters((RSAParameters)p_Key);

            var s_Formatter = new RSAPKCS1SignatureDeformatter(s_Rsa);

            return s_Formatter.VerifySignature(s_Hash, m_Signature);
        }

        private void SignData(byte[] p_Data, RSAParameters p_Key)
        {
            var s_Mac = new HMACSHA1(c_HMacKey);

            var s_Hash = s_Mac.ComputeHash(p_Data);

            using var s_Rsa = new RSACryptoServiceProvider();
            s_Rsa.ImportParameters(p_Key);

            var s_Formatter = new RSAPKCS1SignatureFormatter(s_Rsa);

            m_Signature = s_Formatter.CreateSignature(s_Hash);
        }


        protected bool Parse(RimeReader p_Reader, out RimeReader p_OutReader)
        {
            p_OutReader = p_Reader;

            var s_Magic = p_Reader.ReadUInt32();

            // in bf3 0x01CED100 is also xored, while later games its not.
            // Trick might be to check if part of xorkey is coreseed
            //
            // 0x00CED100 = not signed, but is xored
            // 0x01CED100 = signed, and xored **if older**
            // 0x03CED100 = no xor and no sign
            //
            if (s_Magic == 0x00CED100 || 
                s_Magic == 0x01CED100)
            {
                // Reserved
                p_Reader.Seek(0x4, SeekOrigin.Current);


                // Read the signature
                // old games has a bug where signature is 0x120, but in reality its only 0x100
                m_Signature = p_Reader.ReadBytes(c_KeySize);

                // unused data
                // in bf3 its *mostly* null, in later games it is start of coreseed, but is also corrupted?
                p_Reader.Seek(0x20, SeekOrigin.Current);

                // read xor key
                var s_XorKey = p_Reader.ReadBytes(0x101);

                // align 4
                p_Reader.Seek(0x3, SeekOrigin.Current);

                // fix for newer forstbite versions!
                if (!s_XorKey.Skip(0x10).Take(0x10).SequenceEqual(c_CoreSeedPart))
                    p_OutReader = new XorRimeReader(p_Reader, s_XorKey.Select(x => (byte)(x ^ 0x7B)).ToArray());

                m_HasHeader = true;
                return true;
            }
            else if (s_Magic == 0x03CED100) // Signed
            {
                // Read the signature and skip the empty XOR table.
                //m_Signature = p_Reader.ReadBytes(0x124);
                // skip seed
                //p_Reader.Seek(0x104, SeekOrigin.Current);

                // 0x4+0x100+0x20+0x101+0x3 = 0x228
                p_Reader.Seek(0x228, SeekOrigin.Current);


                m_HasHeader = true;
                return true;
            }
            p_Reader.Seek(-4, SeekOrigin.Current);

            m_HasHeader = false;
            return false;
        }
    
        public void Serialize(RimeWriter p_Writer, byte[] p_Data, RSAParameters? p_Key = null)
        {
            p_Writer.Write((uint)0x01CED100);
            p_Writer.Write((uint)0x0); // reserved

            if (p_Key != null)
                SignData(p_Data, (RSAParameters)p_Key);

            p_Writer.Write(m_Signature);

            if (m_Signature.Length < c_KeySize)
                p_Writer.Write(new byte[(c_KeySize - m_Signature.Length)]);
      
            
            // unusued data from old bug
           // p_Writer.Seek(0x20, SeekOrigin.Current);
            p_Writer.Write(new byte[0x20]);


            // We fill this with 123 because that results in the obfuscation
            // not taking place, leaving the data in the file as-is. This is
            // primarily for readability purposes, so it's easier to look at
            // the file in a hex editor or otherwise. It also has the added
            // benefit of making files reproducible.

            // write 0x7B to disable xor key as (0x7B ^ 0x7B) = 0x00.
            // unused in newer buils so shouldnt do anything there as well
            for (var i=0; i < 0x101; i++)
                p_Writer.Write((byte)0x7B);

            //p_Writer.Seek(0x3, SeekOrigin.Current);
            p_Writer.Write(new byte[0x3]);
            
            p_Writer.Write(p_Data);
        }
    
    }
}
