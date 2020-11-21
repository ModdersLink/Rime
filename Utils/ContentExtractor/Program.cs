using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using CommandLine;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using Environment = System.Environment;

namespace Rime.Utils.ContentLister
{
    class Program
    {
        public class Options
        {
            [Option("sb", Required = false, HelpText = "The superbundles to be mounted. When not specified, all available superbundles are mounted.")]
            public IEnumerable<string> MountSuperbundles { get; set; } = new string[0];

            [Option("bundles", Required = false, HelpText = "The bundles to be mounted. When not specified, all available bundles are mounted.")]
            public IEnumerable<string> MountBundles { get; set; } = new string[0];

            [Option('q', "quiet", Required = false, Default = false, HelpText = "Suppress console output.")]
            public bool Quiet { get; set; } = false;

            /*[Option("verify", Required = false, Default = false, HelpText = "Verify hashes of content while extracting, where available.")]
            public bool Verify { get; set; } = false;*/

            [Value(0, MetaName = "gamePath", Required = true, HelpText = "The path of the game to be whose content you want to extract.")]
            public string GamePath { get; set; } = "";

            [Value(1, MetaName = "engineType", Required = true, HelpText = "The engine type of the game.")]
            public EngineType EngineType { get; set; }

            [Value(2, MetaName = "outPath", Required = true, HelpText = "The output directory where the extracted files will be put into.")]
            public string OutputPath { get; set; } = "";
        }

        static void Main(string[] p_Args)
        {
            Parser.Default.ParseArguments<Options>(p_Args).WithParsed(p_Options =>
            {
                LoadContentAssembly(p_Options);
                DumpFiles(p_Options);

                Console.WriteLine("Content successfully extracted. Press any key to exit...");
                Console.ReadKey();
            }).WithNotParsed(p_Err => { Environment.Exit(1); });
        }

        private static void LoadContentAssembly(Options p_Options)
        {
            var s_AssemblyName = "RimeLib.Content." + p_Options.EngineType;

            try
            {
                if (!p_Options.Quiet)
                    Console.WriteLine("Loading engine content support assembly.");

                Assembly.Load(s_AssemblyName);
            }
            catch
            {
                if (!p_Options.Quiet)
                    Console.WriteLine($"Failed to load supporting engine assembly ({s_AssemblyName}.dll). This means that the engine is not supported or that you are missing required files.");

                Environment.Exit(1);
            }
        }

        private static async void DumpFiles(Options p_Options)
        {
            var s_Mounter = EngineMounterRegistry.Create(p_Options.EngineType);

            var s_MountSuperbundles = p_Options.MountSuperbundles.ToList();
            var s_MountBundles = p_Options.MountBundles.ToList();

            // Only auto-mount when a user has not specified any specific superbundles or bundles.
            if (!p_Options.Quiet)
                Console.WriteLine($"Mounting game with engine '{p_Options.EngineType}' at path '{p_Options.GamePath}'. Please wait, this could take a while.");

            await s_Mounter.Mount(p_Options.GamePath, s_MountSuperbundles.Count == 0 && s_MountBundles.Count == 0, p_Options.EngineType);
           
            // Mount the requested superbundles.
            if (s_MountSuperbundles.Count > 0)
            {
                if (!p_Options.Quiet)
                    Console.WriteLine($"Mounting requested superbundles. Please wait, this could take a while.");

                var s_AutoMountBundles = s_MountBundles.Count == 0;
                var s_SbTasks = s_MountSuperbundles.Select(p_Sb => s_Mounter.MountSuperbundle(p_Sb, s_AutoMountBundles));
                await Task.WhenAll(s_SbTasks);
            }


            // Mount all the requested bundles.
            if (s_MountBundles.Count > 0)
            {
                if (!p_Options.Quiet)
                    Console.WriteLine($"Mounting requested bundles. Please wait, this could take a while.");

                var s_BundleTasks = s_MountBundles.Select(s_Mounter.MountBundle);
                await Task.WhenAll(s_BundleTasks);
            }

            // Dump everything!
            if (!p_Options.Quiet)
                Console.WriteLine($"Everything is now mounted! Starting content extraction.");

            Parallel.ForEach(s_Mounter.GetChunks(), p_Pair =>
            {
                Dump(p_Options, "chunk", "_chunks/" + p_Pair.Key.ToString("D"), p_Pair.Value);
            });

            Parallel.ForEach(s_Mounter.GetResources(), p_Pair =>
            {
                Dump(p_Options, "resource", p_Pair.Key, p_Pair.Value);
            });

            Parallel.ForEach(s_Mounter.GetPartitions(), p_Pair =>
            {
                Dump(p_Options, "partition", p_Pair.Key, p_Pair.Value);
            });
        }

        private static void Dump<T>(Options p_Options, string p_Type, string p_FilePath, IMountedObject<T> p_Object) where T : IObjectVariant
        {
            // Construct a full path to this object and make sure its directory exists.
            var s_Path = Path.Join(p_Options.OutputPath, p_FilePath + "." + p_Type).Normalize();
         
            var s_Directory = Path.GetDirectoryName(s_Path);
#pragma warning disable CS8604 // Possible null reference argument.
            Directory.CreateDirectory(s_Directory);
#pragma warning restore CS8604 // Possible null reference argument.
            
            if (!p_Options.Quiet)
                Console.WriteLine("/" + p_FilePath + "." + p_Type);

            // Get a reader to the object.
            var s_Variant = p_Object.FirstVariant;
            using var s_Reader = s_Variant.GetReader();

            // TODO: Re-add support for hash verification. This is currently disabled because it's very inefficient.
            // Ideally we want to be calculating the hash on the fly by piping the data to both the output file and a hasher.

            /*// Get the data buffer.
            var s_Data = s_Reader.ReadBytes((int) s_Variant.GetSize());

            // If we have a hash then verify this data.
            var s_Hash = s_Variant.GetSha1();

            if (s_Hash != null)
            {
                SHA1 s_Hasher = new SHA1CryptoServiceProvider(); 
                var s_ComputedHash = new Sha1(s_Hasher.ComputeHash(s_Data));

                if (!s_Hash.Equals(s_ComputedHash))
                    throw new Exception($"Checksum validation failed for file {p_FilePath} of type {p_Type}.");
            }

            File.WriteAllBytes(s_Path, s_Data);*/

            // Pipe the data to an on-disk file.
            using var s_FileStream = File.Create(s_Path);
            s_Reader.CopyTo(s_FileStream);
        }

        private static void Print<T>(string p_Type, string p_Path, IMountedObject<T> p_Object) where T : IObjectVariant
        {
            var s_Variant = p_Object.FirstVariant;

            var s_Path = $"[{s_Variant.GetContainedSuperbundle()}";

            if (s_Variant.GetContainedBundle() != null)
                s_Path += ":" + s_Variant.GetContainedBundle();

            s_Path += "]/";
            s_Path += p_Path;
            s_Path += "." + p_Type;

            Console.WriteLine(s_Path);
        }
    }
}
