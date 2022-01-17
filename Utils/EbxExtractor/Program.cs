using CommandLine;
using RimeLib.Frostbite;
using RimeLib.Serialization.Frostbite2_0.Ebx;
using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RimeLib.Content.Mounting;
using RimeLib.IO;
using RimeLib.Texture;

namespace EbxExtractor
{
    class Program
    {
        internal class Options
        {
            [Option('q', "quiet", Required = false, Default = false, HelpText = "Suppress console output.")]
            public bool Quiet { get; set; } = false;

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
                LoadTextureAssembly(p_Options);
                DumpFiles(p_Options);

                Console.WriteLine("Audio content successfully extracted. Press any key to exit...");
                Console.ReadKey();
            }).WithNotParsed(p_Error =>
            {
                System.Environment.Exit(1);
            });
            Console.WriteLine("Hello World!");
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

                System.Environment.Exit(1);
            }
        }

        private static void LoadTextureAssembly(Options p_Options)
        {
            var s_AssemblyName = "RimeLib.Texture." + p_Options.EngineType;

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

                System.Environment.Exit(1);
            }
        }

        private static async void DumpFiles(Options p_Options)
        {
            /*using (var s_Reader = new RimeReader(File.OpenRead(@"I:\Research\BF3\Dump\Files\bundles\ebx\levels\xp2_factory\xp2_factory.ebx")))
            {
                var s_EbxReader = new EbxReader();
                s_EbxReader.ParsePartition("Test", s_Reader).ToJsonFile(@"B:\ebx-test\xp2_factory.json", Formatting.Indented);
            }*/

            /*var s_Partition = DatabasePartition.FromJsonFile(@"B:\ebx-test\xp2_factory.json");
            var s_EbxWriter = new EbxWriter();

            using (var s_Writer = new RimeWriter(File.OpenWrite(@"B:\ebx-test\xp2_factory.ebx")))
                s_EbxWriter.Serialize(s_Writer, s_Partition);

            using (var s_Reader = new RimeReader(File.OpenRead(@"B:\ebx-test\xp2_factory.ebx")))
            {
                var s_EbxReader = new EbxReader();
                s_EbxReader.ParsePartition("Test", s_Reader).ToJsonFile(@"B:\ebx-test\xp2_factory2.json", Formatting.Indented);
            }*/

            var s_Mounter = EngineMounterRegistry.Create(p_Options.EngineType);

            if (!p_Options.Quiet)
                Console.WriteLine($"Mounting game with engine '{p_Options.EngineType}' at path '{p_Options.GamePath}'. Please wait, this could take a while.");

            await s_Mounter.Mount(p_Options.GamePath, true, EngineType.Frostbite2_0);
            //await s_Mounter.MountSuperbundle("Win32/Chunks0", true);
            //await s_Mounter.MountSuperbundle("Win32/Chunks1", true);
            //await s_Mounter.MountSuperbundle("Win32/Chunks2", true);
            //await s_Mounter.MountSuperbundle("Win32/MpChunks", true);
            //await s_Mounter.MountSuperbundle("Win32/Xp2Chunks", true);
            //await s_Mounter.MountSuperbundle("Win32/Levels/XP2_Factory/XP2_Factory", true);

            if (!p_Options.Quiet)
                Console.WriteLine($"Everything is now mounted! Starting audio conversion.");

            var s_Resources = s_Mounter.GetResources();
            //Parallel.ForEach(s_Resources, (p_Pair) =>
            foreach (var p_Pair in s_Resources)
            {
                var s_Name = p_Pair.Key;
                var s_Resource = p_Pair.Value;

                if (!s_Name.EndsWith("signbackside_n"))
                    continue;

                if (s_Resource.FirstVariant.GetResourceType() == RimeLib.Content.Frostbite.ResourceType.DxTexture)
                {

                    var s_TargetPath = $@"D:\Rime\Textures\{s_Name}.dds";

                    if (!Directory.Exists(Path.GetDirectoryName(s_TargetPath)))
                        Directory.CreateDirectory(Path.GetDirectoryName(s_TargetPath));

                    if (!TextureHelper.LoadTexture(s_Mounter, s_Resource!.FirstVariant, out var s_Texture))
                        throw new Exception($"Could not load resource with name '{s_Name}'.");

                    using var s_FileStream = File.Create(s_TargetPath);

                    var s_TextureFileHandler = TextureFileHandlerRegistry.FindHandler("dds");

                    s_TextureFileHandler?.Save(s_Texture!, new RimeWriter(s_FileStream));

                }
            }/*)*/;
            var s_Partitions = s_Mounter.GetPartitions();
            
            //foreach (var s_PartitionPair in s_Partitions)
            Parallel.ForEach(s_Partitions, (p_Pair) => 
            {
                var s_PartitionName = p_Pair.Key;
                var s_PartitionObject = p_Pair.Value;

                using var s_PartitionReader = s_PartitionObject.FirstVariant.GetReader();
                
                using var s_EbxReader = new EbxReader();
                var s_Partition = s_EbxReader.ParsePartition(s_PartitionName, s_PartitionReader);
                
                var s_TargetPath = Path.Join(@"B:\ebx-dump", s_PartitionName + ".json");
                var s_TargetDir = Path.GetDirectoryName(s_TargetPath);

                if (!Directory.Exists(s_TargetDir))
                    Directory.CreateDirectory(s_TargetDir);

                s_Partition.ToJsonFile(s_TargetPath, Formatting.Indented);
            });
        }
    }
}
