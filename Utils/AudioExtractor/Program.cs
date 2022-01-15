using CommandLine;
using fb;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.Serialization;
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Frostbite2_0.Ebx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace AudioExtractor
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
                LoadBindingsAssembly(p_Options);
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

        private static void LoadBindingsAssembly(Options p_Options)
        {
            var s_AssemblyName = "RimeLib.Bindings.Venice";

            try
            {
                if (!p_Options.Quiet)
                    Console.WriteLine("Loading engine bindings support assembly.");

                var s_Bindings = Assembly.Load(s_AssemblyName);

                var s_ExportedTypes = s_Bindings.GetExportedTypes();

                foreach (var s_Type in s_ExportedTypes)
                {
                    if (!typeof(FrostbiteContainer).IsAssignableFrom(s_Type) &&
                        !s_Type.IsEnum)
                        continue;

                    ContainerRegistry.RegisterType(s_Type);
                }
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
            var s_Mounter = EngineMounterRegistry.Create(p_Options.EngineType);

            if (!p_Options.Quiet)
                Console.WriteLine($"Mounting game with engine '{p_Options.EngineType}' at path '{p_Options.GamePath}'. Please wait, this could take a while.");

            await s_Mounter.Mount(p_Options.GamePath, false, p_Options.EngineType);
            await s_Mounter.MountSuperbundle("Win32/Chunks0", true);
            await s_Mounter.MountSuperbundle("Win32/Chunks1", true);
            await s_Mounter.MountSuperbundle("Win32/Chunks2", true);
            await s_Mounter.MountSuperbundle("Win32/MpChunks", true);
            await s_Mounter.MountSuperbundle("Win32/Xp2Chunks", true);
            await s_Mounter.MountSuperbundle("Win32/Levels/XP2_Factory/XP2_Factory", true);

            if (!p_Options.Quiet)
                Console.WriteLine($"Everything is now mounted! Starting audio conversion.");

            var s_Partitions = s_Mounter.GetPartitions();

            //var s_Ret = Parallel.ForEach(s_Partitions, p_Pair =>
            //{
            //    var s_PartitionName = p_Pair.Key;

            //    var s_PartitionObject = p_Pair.Value;

            //    using var s_PartitionReader = s_PartitionObject.FirstVariant.GetReader();

            //    var s_Reader = new EbxReader();

            //    var s_Partition = s_Reader.ParsePartition(s_PartitionName, s_PartitionReader);
            //    if (s_Partition != null)
            //        PartitionRegistry.RegisterPartition(s_Partition);
            //});

#if !_SLOW_CODE
            foreach (var s_PartitionPair in s_Partitions)
            {
                var s_PartitionName = s_PartitionPair.Key;

                var s_PartitionObject = s_PartitionPair.Value;

                using var s_PartitionReader = s_PartitionObject.FirstVariant.GetReader();

                var s_Reader = new EbxReader();

                var s_Partition = s_Reader.ParsePartition(s_PartitionName, s_PartitionReader);
                if (s_Partition == null)
                    continue;

                // Register the partition for future usage
                PartitionRegistry.RegisterPartition(s_Partition);

                // Bail if this is not a SoundWaveAsset
                if (s_Partition.PrimaryInstance.ContainerTypeName != "SoundWaveAsset")
                    continue;

                // Read out all of the chunks
                var s_ChunkList = new List<byte[]>();
                var s_Asset = s_Partition.PrimaryInstance as SoundWaveAsset;
                for (var s_ChunkIndex = 0; s_ChunkIndex < s_Asset.Chunks.Count; ++s_ChunkIndex)
                {
                    var s_AssetChunk = s_Asset.Chunks[s_ChunkIndex];

                    if (!s_Mounter.TryGetChunk(s_AssetChunk.ChunkId, out IMountedObject<IChunkVariant> p_Chunk))
                        continue;

                    byte[] s_ChunkData = null;
                    using (var s_ChunkReader = p_Chunk.FirstVariant.GetReader())
                        s_ChunkData = s_ChunkReader.ReadBytes((int)s_AssetChunk.ChunkSize);

                    s_ChunkList.Add(s_ChunkData);
                }

                // Read out all of the variations
                var s_VariationList = new List<SoundWaveVariation>();
                for (var s_VariationIndex = 0; s_VariationIndex < s_Asset.Variations.Count; ++s_VariationIndex)
                {
                    s_VariationList.Add(s_Asset.Variations[s_VariationIndex]);
                }

                // Check our assumptions
                if (s_VariationList.Count != s_ChunkList.Count)
                    throw new Exception("assumption broken");

                // Iterate over each of the variants
                foreach (var s_Variation in s_VariationList)
                {
                    var s_ChunkIndex = s_Variation.ChunkIndex;
                    if (s_ChunkIndex > s_ChunkList.Count)
                        throw new Exception("variation chunk index out of bounds");

                    // Iterate over each of the provided segments
                    for (var s_SegmentIndex = 0; s_SegmentIndex < s_Variation.Segments.Count; ++s_SegmentIndex)
                    {
                        // void __thiscall rw::audio::core::Xas1Dec::DecodeChannel(rw::audio::core::Xas1Dec *this, char *pSrc, float *pDst)
                    }
                }
            }
#endif

            var s_Results = PartitionRegistry.Partitions.Where(p_Partition => p_Partition.PrimaryInstance.ContainerTypeName == "SoundWaveAsset");
        }
    }
}
