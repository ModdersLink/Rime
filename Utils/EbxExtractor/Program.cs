using CommandLine;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.Serialization.Frostbite2_0.Ebx;
using System;
using System.IO;
using System.Reflection;
using RimeLib.IO;

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

        private static async void DumpFiles(Options p_Options)
        {
            var s_Reader = new Fb2EbxReader();
            //using (var s_FileReader = new RimeReader(File.OpenRead("I:\\Research\\BF3\\Dump\\Files\\bundles\\ebx\\levels\\xp1_004\\xp1_004.ebx")))
            using (var s_FileReader = new RimeReader(File.OpenRead("I:\\Research\\BF3\\Dump\\Files\\bundles\\ebx\\levels\\xp2_factory\\xp2_factory.ebx")))
                s_Reader.ParsePartition("Test", s_FileReader);
            /*var s_Mounter = EngineMounterRegistry.Create(p_Options.EngineType);

            if (!p_Options.Quiet)
                Console.WriteLine($"Mounting game with engine '{p_Options.EngineType}' at path '{p_Options.GamePath}'. Please wait, this could take a while.");

            await s_Mounter.Mount(p_Options.GamePath, false, EngineType.Frostbite2_0);
            await s_Mounter.MountSuperbundle("Win32/Chunks0", true);
            await s_Mounter.MountSuperbundle("Win32/Chunks1", true);
            await s_Mounter.MountSuperbundle("Win32/Chunks2", true);
            await s_Mounter.MountSuperbundle("Win32/MpChunks", true);
            await s_Mounter.MountSuperbundle("Win32/Xp2Chunks", true);
            await s_Mounter.MountSuperbundle("Win32/Levels/XP2_Factory/XP2_Factory", true);

            if (!p_Options.Quiet)
                Console.WriteLine($"Everything is now mounted! Starting audio conversion.");

            var s_Partitions = s_Mounter.GetPartitions();

#if !_SLOW_CODE
            foreach (var s_PartitionPair in s_Partitions)
            {
                var s_PartitionName = s_PartitionPair.Key;
                if (s_PartitionName != "Levels/XP2_Factory/XP2_Factory".ToLower())
                    continue;

                var s_PartitionObject = s_PartitionPair.Value;

                using var s_PartitionReader = s_PartitionObject.FirstVariant.GetReader();

                var s_Reader = new Fb2EbxReader();

                s_Reader.ParsePartition(s_PartitionName, s_PartitionReader);
            }
#else
            var s_Ret = Parallel.ForEach(s_Partitions, p_Pair =>
            {
                var s_PartitionName = p_Pair.Key;

                var s_PartitionObject = p_Pair.Value;

                using var s_PartitionReader = s_PartitionObject.FirstVariant.GetReader();

                var s_Reader = new Fb2EbxReader();

                var s_Partition = s_Reader.ParsePartition(s_PartitionName, s_PartitionReader);
                if (s_Partition != null)
                    PartitionRegistry.RegisterPartition(s_Partition);
            });
#endif*/

            //var s_Results = PartitionRegistry.Partitions.Where(p_Partition => p_Partition.PrimaryInstance.ContainerTypeName == "SoundWaveAsset");
        }
    }
}
