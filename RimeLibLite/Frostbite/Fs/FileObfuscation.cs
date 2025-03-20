using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        private const int c_KeySize = 0x100;
        private const byte c_XorBaseKey = 0x7B;

        public FileObfuscation()
        {
        }
        public FileObfuscation(RimeReader p_Reader)
        {
            ReadData(p_Reader);
        }

        //public bool HasXor { get; set; }


        public byte[]? XorKey { get; set; } = null;
        public byte[] Signature { get; set; } = new byte[c_KeySize];

        public bool ValidateData(byte[] p_Data, RSAParameters? p_Key)
        {
            if (p_Key == null)
                return false;

            var s_Mac = new HMACSHA1(c_HMacKey);

            var s_Hash = s_Mac.ComputeHash(p_Data);

            using var s_Rsa = new RSACryptoServiceProvider();
            s_Rsa.ImportParameters((RSAParameters)p_Key);

            var s_Formatter = new RSAPKCS1SignatureDeformatter(s_Rsa);
            s_Formatter.SetHashAlgorithm("SHA1");

            return s_Formatter.VerifySignature(s_Hash, Signature);
        }

        public void SignData(byte[] p_Data, RSAParameters p_Key)
        {
            var s_Mac = new HMACSHA1(c_HMacKey);

            var s_Hash = s_Mac.ComputeHash(p_Data);

            using var s_Rsa = new RSACryptoServiceProvider();
            s_Rsa.ImportParameters(p_Key);

            var s_Formatter = new RSAPKCS1SignatureFormatter(s_Rsa);
            s_Formatter.SetHashAlgorithm("SHA1");

            Signature = s_Formatter.CreateSignature(s_Hash);
        }


        public bool ReadData(RimeReader p_Reader)
        {

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
                // old games has a bug where signature size in structure is 0x120, but in reality its only 0x100
                Signature = p_Reader.ReadBytes(c_KeySize);

                // unused data
                // in bf3 its *mostly* null, in later games it is start of coreseed, but is also corrupted?
                p_Reader.Seek(0x20, SeekOrigin.Current);

                // read xor key
                var s_XorKey = p_Reader.ReadBytes(0x101);

                // align 4
                p_Reader.Seek(0x3, SeekOrigin.Current);

                // fix for newer forstbite versions!
                // newer versions dont use xor key, but theres a constant value here that can be checked.
                // the value is never used, and can be changed
                if (!s_XorKey.Skip(0x10).Take(0x10).SequenceEqual(c_CoreSeedPart))
                {
                    XorKey = s_XorKey.Select(x => (byte)(x ^ c_XorBaseKey)).ToArray();
                    
                    // if xorkey is a list if null bytes, then just set it to null.
                    if (XorKey.SequenceEqual(new byte[0x101]))
                        XorKey = null;
                }

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


                return true;
            }
            p_Reader.Seek(-4, SeekOrigin.Current);

            return false;
        }
    
        public void WriteData(RimeWriter p_Writer, byte[] p_Data)
        {
            p_Writer.Write((uint)0x01CED100);
            p_Writer.Write((uint)0x0); // reserved

   

            p_Writer.Write(Signature);

            if (Signature.Length < c_KeySize)
                p_Writer.Write(new byte[(c_KeySize - Signature.Length)]);
      
            
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

            
            var s_XorKey = new byte[0x101];
            if (XorKey != null)
                Array.Copy(XorKey, s_XorKey, System.Math.Min(0x101, XorKey.Length));
                
            // write processed xor key
            p_Writer.Write(s_XorKey.Select(x => (byte)(x ^ c_XorBaseKey)).ToArray());
 

            
            //p_Writer.Seek(0x3, SeekOrigin.Current);
            p_Writer.Write(new byte[0x3]);

            using var s_XorWriter = new XorRimeWriter(p_Writer, s_XorKey);
            s_XorWriter.Write(p_Data);

            //p_Writer.Write(p_Data);
        }


        public static bool Deserialize(RimeReader p_Reader, out RimeReader p_OutReader, out FileObfuscation p_OutInfo, bool p_AllowNoHeader = false)
        {
            
            p_OutInfo = new FileObfuscation();

            // how is the best way to handle if its headerless? (bf3 alpha. and cas(?))
            // if we didnt read valid header, and we are allowed to bypass it
            if (!p_OutInfo.ReadData(p_Reader) && !p_AllowNoHeader)
                throw new InvalidDataException(
                    "Data passed to FileObfuscation does not have header. Might be a DbObject file without obfuscation, and is not handled.");
            
            // reader should be seeked right at this point.
            if (p_OutInfo.XorKey != null)
                // p_OutReader = new LimitedRimeReader(new XorRimeRecder(p_Reader, p_OutInfo.XorKey), p_Reader.Position - p_Reader.BaseStream.Length);
                p_OutReader = new XorRimeReader(p_Reader, p_OutInfo.XorKey);
            else
                p_OutReader = p_Reader; //new LimitedRimeReader(p_Reader, p_Reader.Position - p_Reader.BaseStream.Length);
                // p_OutReader = new LimitedRimeReader(p_Reader, p_Reader.Position - p_Reader.BaseStream.Length);
            
            return true;
        }

        public static bool Serialize(RimeWriter p_Writer, byte[] p_Data, RSAParameters? p_Key = null)
        {
            
            var s_Obfuscation = new FileObfuscation();
            
            // set xor key to 0, 0x7B will be applied later
            s_Obfuscation.XorKey = new byte[0x101];

            if (p_Key != null)
            {
                try
                {
                    s_Obfuscation.SignData(p_Data, (RSAParameters)p_Key);
                }
                catch (Exception e)
                {
                    throw new InvalidDataException("Failed to sign data. Somethings wrong", e);
                }
            }
            s_Obfuscation.WriteData(p_Writer, p_Data);
            
            return true;
        }
    }
}
