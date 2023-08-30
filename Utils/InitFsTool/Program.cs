using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Threading.Tasks;
using CommandLine;
using Newtonsoft.Json;
using RimeLib;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Db;
using RimeLib.Frostbite.Fs;
using RimeLib.IO;
using RimeLib.Utils;
using Environment = System.Environment;

namespace Rime.Utils.InitFsTool
{
    class Program
    {
        [Verb("verify", HelpText = "Verify FileObfuscationHeader to a key file")]
        class VerifyOptions
        {
            [Value(0, Required = true, MetaName = "input", HelpText = "Input file with FileObfuscationHeader")]
            public string InitFs { get; set; } = string.Empty;
            
            [Value(1, Required = true, MetaName =  "key", HelpText = "Keyfile input as a bcrypt rsablob")]
            public string Key { get; set; } = string.Empty;
        }
        
        [Verb("dump", HelpText = "Verify FileObfuscationHeader to a key file")]
        class DumpOptions
        {
            [Value(0, Required = true, MetaName = "input", HelpText = "Input file with FileObfuscationHeader")]
            public string InitFs { get; set; } = string.Empty;
            
            [Value(1, Required = false,  MetaName = "output", HelpText = "Output folder. If not avalible, it will print filenames.")]
            public string Output { get; set; } = string.Empty;
            
            [Option("key", Required = false, HelpText = "Keyfile input as a bcrypt rsablob. This will verify before extraction.")]
            public string Key { get; set; } = string.Empty;
            
            [Option("aeskey", Required = false, HelpText = "Hex aes key for FileContainer (newer encrypted wrapper)")]
            public string AesKey { get; set; } = string.Empty;
        }
        
        [Verb("rebuild", HelpText = "Verify FileObfuscationHeader to a key file")]
        class RebuildOptions
        {
            [Value(0, Required = true, MetaName = "input", HelpText = "Input folder")]
            public string InputFolder { get; set; } = string.Empty;
            
            [Value(1, Required = true, MetaName = "output", HelpText = "Output file")]
            public string OutputFile { get; set; } = string.Empty;
            
            [Option("key", Required = false, HelpText = "Keyfile input as a bcrypt rsablob. This will sign before extraction.")]
            public string Key { get; set; } = string.Empty;

            
            [Option("aeskey", Required = false, HelpText = "Hex aes key for FileContainer (newer encrypted wrapper)")]
            public string AesKey { get; set; } = string.Empty;
        }
        
        
        [Verb("validate", HelpText = "Validate both private and public key of keyset. Result can be parsed from exit code")]
        class ValidateOptions
        {
            [Value(0, Required = true, MetaName = "input", HelpText = "Input file with FileObfuscationHeader")]
            public string InitFs { get; set; } = string.Empty;
            
            [Value(1, Required = true, MetaName =  "key", HelpText = "Keyfile input as a bcrypt rsablob")]
            public string Key { get; set; } = string.Empty;
        }

        static void Main(string[] p_Args)
        {

            // this function sucks, i cant have a void return value...
            var s_Result = Parser.Default.ParseArguments<VerifyOptions, DumpOptions, RebuildOptions, ValidateOptions>(p_Args).MapResult(
                        (VerifyOptions p_Opts) => Verify(p_Opts.InitFs, p_Opts.Key),
                        (DumpOptions p_Opts) => Dump(p_Opts.InitFs, p_Opts.Output, p_Opts.Key, p_Opts.AesKey),
                        (RebuildOptions p_Opts) => Rebuild(p_Opts.InputFolder, p_Opts.OutputFile, p_Opts.Key, p_Opts.AesKey),
                        (ValidateOptions p_Opts) => ValidateKeyset(p_Opts.InitFs, p_Opts.Key),
                        _ => 1);


            Environment.Exit(s_Result);
        }

     



        public static int Verify(string p_Input, string p_Key)
        {
            if (p_Input == string.Empty)
                throw new InvalidDataException("Input empty");
            if (p_Key == string.Empty)
                throw new InvalidDataException("Key empty");

            using var s_KeyFile = new RimeReader(new FileStream(p_Key, FileMode.Open, FileAccess.Read));

            var s_RsaParams = CryptUtils.ToRsaParams(new RimeReader(s_KeyFile));
        
        
            using var s_VerificationFile = new RimeReader(new FileStream(p_Input, FileMode.Open, FileAccess.Read));
                
            FileObfuscation.Deserialize(s_VerificationFile,
                out var s_DataReader, out var s_InitFs);

            var s_DataBytes = s_DataReader.ReadBytes((int)(s_DataReader.BaseStream.Length - s_DataReader.Position));


            if (!s_InitFs.ValidateData(s_DataBytes, s_RsaParams))
            {
                Console.WriteLine("---- InitFs Unverified! ----");
                return 2;
            }
            
            
            Console.WriteLine("---- InitFs Verified! ------");
            return 0;
        }
        
        
        public class InitFsFile
            : DbObjectSerializable
        {
            [DbObjectField("name")]
            public string Name { get; set; } = string.Empty;
            
            [DbObjectField("payload")]
            public byte[] Payload { get; set; } = new byte[0];


            public string SystemPath => Name.Replace('/', Path.DirectorySeparatorChar);
        }
        
        public class InitFsFileWrapper
            : DbObjectSerializable
        {
            [DbObjectField("$file")]
            public InitFsFile File { get; set; } = new ();
            
        }
        
        public static int Dump(string p_Path, string p_OutPath, string p_RsaKeyFile, string p_AesKeyHex )
        {
            if (p_RsaKeyFile != string.Empty)
            {
                // exit if isnt verified
                var s_VerifyResult = Verify(p_Path, p_RsaKeyFile);

                if (s_VerifyResult != 0)
                    return s_VerifyResult;
            }

            using var s_VerificationFile = new RimeReader(new FileStream(p_Path, FileMode.Open, FileAccess.Read));
                
            FileObfuscation.Deserialize(s_VerificationFile,
                out var s_DataReader, out _);
            
            var s_DbObject = new DbObject(s_DataReader);

            if (s_DbObject[0].Type == DbObjectType.Object && p_AesKeyHex == string.Empty)
                throw new InvalidDataException("This initfs is wrapped in FileContainer, but aes key is not provided");
            
            
            if (s_DbObject[0].Type == DbObjectType.Object )
            {
                
                
                // some hex string to bytes stolen from somewhere
                var s_AesKeyBytes = Enumerable.Range(0, p_AesKeyHex.Length / 2).Select(x => Convert.ToByte(p_AesKeyHex.Substring(x * 2, 2), 16)).ToArray();
                //Console.WriteLine(string.Join("", s_AesKeyBytes.Select(x => string.Format("{0:x2}", x))));
                
                
                var s_FileContainer = new FileContainer(s_DbObject[0].Value as DbObject, s_AesKeyBytes);

                s_DbObject = new DbObject(new RimeReader(new MemoryStream(s_FileContainer.Data)));
                
                    
                //throw new NotSupportedException("This initfs is wrapped in FileContainer");
            }


            var s_ArrayElement = s_DbObject[0];
            
            if (s_ArrayElement.Type != DbObjectType.Array)
                throw new InvalidDataException("this is not a right dbobject file for initfs. Aes key change?");
            

            var s_DbArray = s_ArrayElement.Value as DbObject;

            foreach (var s_Element in s_DbArray!)
            {
                var s_FileEntry = DbObjectConverter.FromDbObject<InitFsFileWrapper>(s_Element.Value as DbObject);
                
                Console.WriteLine($"{s_FileEntry.File.Name} - 0x{s_FileEntry.File.Payload.Length:x4}");

                //Console.WriteLine($"\t{s_FileEntry.File.SystemPath}");

                if (p_OutPath == string.Empty)
                    continue;
                
                var s_OutPath = Path.Join(p_OutPath, s_FileEntry.File.SystemPath);
                //Console.WriteLine($"\t{s_OutPath}");
                
                
                Directory.CreateDirectory(Path.GetDirectoryName(s_OutPath));

                using var s_OutFileStream = new FileStream(s_OutPath, FileMode.OpenOrCreate, FileAccess.Write);
                using var s_Writer = new RimeWriter(s_OutFileStream);
                
                s_Writer.Write(s_FileEntry.File.Payload);
            }



            return 0;
        }

        public static int Rebuild(string p_FolderPath, string p_OutFilePath, string p_RsaKeyFile, string p_AesKeyHex)
        {

            var s_Files = Directory.GetFiles(p_FolderPath, "*", new EnumerationOptions()
            {
                IgnoreInaccessible = true,
                RecurseSubdirectories = true,
            });

            var s_DbArray = new DbObject();
            
            // sorting is not needed, but would match the game initfs
            foreach(var s_File in s_Files.OrderBy(f => f))
            {
                var s_RelativePathName = s_File.Substring(p_FolderPath.Length);

                if (s_RelativePathName.Length > 0 && s_RelativePathName[0] == Path.DirectorySeparatorChar)
                    s_RelativePathName = s_RelativePathName.Substring(1);
                
                Console.WriteLine(s_RelativePathName);

                s_DbArray.AddElement(new DbObjectElement(string.Empty, DbObjectConverter.ToDbObject(new InitFsFileWrapper()
                {
                    File = new InitFsFile
                    {
                        Name = s_RelativePathName,
                        Payload = File.ReadAllBytes(s_File)
                    }
                })));
            }


            var s_RootObj = new DbObject();
            s_RootObj.AddElement(new DbObjectElement(string.Empty, s_DbArray, true));

            s_RootObj.Serialize(out var s_DbData);


            //File.WriteAllBytes(p_OutFilePath+"raw_fs.dbobj", s_DbData);


            if (p_AesKeyHex != String.Empty)
            {
                var s_AesKeyBytes = Enumerable.Range(0, p_AesKeyHex.Length / 2).Select(x => Convert.ToByte(p_AesKeyHex.Substring(x * 2, 2), 16)).ToArray();

                
                var s_FileContainer = new FileContainer(s_DbData, s_AesKeyBytes);
                // get encrypted data
                s_FileContainer.EncryptContainer(out var s_Container);
                
                var s_ContainerObj = DbObjectConverter.ToDbObject(s_Container);
                
                s_RootObj = new DbObject();
                s_RootObj.AddElement(new DbObjectElement(string.Empty, s_ContainerObj));
                s_RootObj.Serialize(out s_DbData);
                
                //File.WriteAllBytes(p_OutFilePath+"enc_fs.dbobj", s_DbData);
            }
            
            RSAParameters? s_RsaParams = null;
            if (p_RsaKeyFile != string.Empty)
            {
                using var s_KeyFile = new RimeReader(new FileStream(p_RsaKeyFile, FileMode.Open, FileAccess.Read));
                s_RsaParams = CryptUtils.ToRsaParams(new RimeReader(s_KeyFile));
            }
            
            using var s_OutFileStream = new FileStream(p_OutFilePath, FileMode.OpenOrCreate, FileAccess.Write);
            using var s_Writer = new RimeWriter(s_OutFileStream);

            if (!FileObfuscation.Serialize(s_Writer, s_DbData, s_RsaParams))
                return 1;
            
            
                
            return 0;
        }

        public static int ValidateKeyset(string p_Path, string p_Key)
        {
            int s_ResultFlags = 0;
            
            using var s_KeyFile = new RimeReader(new FileStream(p_Key, FileMode.Open, FileAccess.Read));
            var s_RsaParams = CryptUtils.ToRsaParams(new RimeReader(s_KeyFile));

            using var s_InputFile = new RimeReader(new FileStream(p_Path, FileMode.Open, FileAccess.Read));
            FileObfuscation.Deserialize(s_InputFile, out var s_DataReader, out var s_InitFs);

            var s_DataBytes = s_DataReader.ReadBytes((int)(s_DataReader.BaseStream.Length - s_DataReader.Position));

            if (!s_InitFs.ValidateData(s_DataBytes, s_RsaParams))
            {
                //throw new Exception("Public key not for this piece of data!");
                Console.WriteLine("Public key does not match data provided");
                s_ResultFlags |= 2;
            }

            var s_TestObfu = new FileObfuscation();
            s_TestObfu.SignData(s_DataBytes, s_RsaParams);

            if (!s_InitFs.Signature.SequenceEqual(s_TestObfu.Signature))
            {
                //throw new Exception("Somethings wrong with signature!");
                Console.WriteLine("Private key does not match data provided");
                s_ResultFlags |= 4;
            }
            
            if(s_ResultFlags == 0)
                Console.WriteLine("Keyset valid!");
            
            return s_ResultFlags;
        }
    }
}
