using CommandLine;
using RimeLib.Frostbite;
using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Reflection;
using RimeLib;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.Extensions;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using RimeLib.IO.Conversion;
using RimeLib.Havok.Frostbite2_0;

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
                //LoadTextureAssembly(p_Options);
                DumpFiles(p_Options).Wait();

                //Console.WriteLine("Audio content successfully extracted. Press any key to exit...");
                //Console.ReadKey();
            }).WithNotParsed(p_Error =>
            {
                foreach (var s_Error in p_Error)
                    Console.WriteLine(s_Error.ToString());
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

        internal class ResourceStreamReader : IResourceObject
        {
            private readonly ResourceType m_ResourceType;
            private Stream m_Stream;

            public ResourceStreamReader(Stream p_Stream, ResourceType p_ResourceType)
            {
                m_ResourceType = p_ResourceType;
                m_Stream = p_Stream;
            }

            public ResourceType GetResourceType()
            {
                return m_ResourceType;
            }

            public bool TryGetMeta([NotNullWhen(true)] out byte[]? p_Meta)
            {
                p_Meta = null;
                return false;
            }

            public RimeReader GetReader()
            {
                return new RimeReader(m_Stream, Endianness.LittleEndian, false);
            }

            public long GetSize()
            {
                return m_Stream.Length;
            }

            public ResourceRef GetId(string? p_Name = null)
            {
                if (p_Name == null)
                    throw new InvalidOperationException("Resource name must be provided to get ID for stream reader.");

                return new ResourceRef(p_Name, this);
            }
        }

        private static async Task DumpFiles(Options p_Options)
        {
            var s_Mounter = EngineInterfaceRegistry.Create<IEngineMounter>(p_Options.EngineType);

            if (!p_Options.Quiet)
                Console.WriteLine($"Mounting game with engine '{p_Options.EngineType}' at path '{p_Options.GamePath}'. Please wait, this could take a while.");

            //await s_Mounter.MountStandaloneSuperbundle("Win32/VuTest", @"B:\Games\Battlefield 3\Update\Patch\Data\Win32\VuTest.sb", true);
            //await s_Mounter.MountStandaloneSuperbundle("Win32/Levels/XP5_001/XP5_001", @"B:\Games\Battlefield 3\Update\Xpack5\Data\Win32\Levels\XP5_001\XP5_001.sb", true);
            await s_Mounter.Mount(p_Options.GamePath, false, EngineType.Frostbite2_0);
            await s_Mounter.MountSuperbundle("Win32/Chunks0", true);
            await s_Mounter.MountSuperbundle("Win32/Chunks1", true);
            await s_Mounter.MountSuperbundle("Win32/Chunks2", true);
            await s_Mounter.MountSuperbundle("Win32/MpChunks", true);
            await s_Mounter.MountSuperbundle("Win32/Xp5Chunks", true);
            await s_Mounter.MountSuperbundle("Win32/Levels/XP5_002/XP5_002", true);

            //if (s_Mounter.TryGetChunk(new GUID("313a4d6fe0dc10d7421fea9fdf78de4f"), out var chunk))
            //if (s_Mounter.TryGetChunk(new GUID("84F0888A-35AA-9B68-38E8-9957DD412EA5"), out var chunk))
            ////if (s_Mounter.TryGetChunk(new GUID("478e7037-4abf-451a-928a-d6b5cb684d2b"), out var chunk))
            //{
            //    chunk.FirstVariant.GetSize();

            //    using var s_TempThing2 = File.OpenWrite(@"B:\ebx-test\post-comp-chunk.bin");
            //    using var s_ChunkReaderThing = chunk.FirstVariant.GetReader();
            //    s_ChunkReaderThing.CopyTo(s_TempThing2);
            //}

            if (s_Mounter.TryGetResource("levels/xp5_002/tdm/staticmodelgroup_physics_win32", out var s_ResourceVariant))
            {
                using var s_Reader = s_ResourceVariant.FirstVariant.GetReader();

                File.WriteAllBytes(@"C:\Users\Orfeas\home\scratch\rime-shit\havok.bin", s_Reader.ToArray());

                /*if (!s_ResourceVariant.FirstVariant.TryGetMeta(out var s_CookieData))
                    throw new Exception("Fuc kyou");

                using var s_CookieReader = new RimeReader(new MemoryStream(s_CookieData));

                var s_ResourceHeaderSize = s_CookieReader.ReadInt32();
                var s_HavokDataSize32 = s_CookieReader.ReadInt32();
                var s_HavokDataSize64 = s_CookieReader.ReadInt32();
                var s_FixupTableSize = s_CookieReader.ReadInt32();
                
                var s_Data = s_Reader.ReadBytes((int)s_Reader.Length);
                using var s_ResourceReader = new RimeReader(new MemoryStream(s_Data));

                var s_HavokPhysicsData = new HavokPhysicsData(
                    s_ResourceReader,
                    s_ResourceHeaderSize,
                    s_HavokDataSize32,
                    s_HavokDataSize64,
                    s_FixupTableSize
                );*/
            }


            Console.WriteLine("DId shit");

            /*var s_Partitions = s_Mounter.GetPartitions();
            
            //foreach (var s_PartitionPair in s_Partitions)
            Parallel.ForEach(s_Partitions, (p_Pair) => 
            {
                var s_PartitionName = p_Pair.Key;
                var s_PartitionObject = p_Pair.Value;

                using var s_PartitionReader = s_PartitionObject.FirstVariant.GetReader();
                
                using var s_EbxReader = new EbxReader();
                var s_Partition = s_EbxReader.ParsePartition(s_PartitionName, s_PartitionReader);
                
                var s_TargetPath = Path.Join(@"B:\ebx-dump2", s_PartitionName + ".json");
                var s_TargetDir = Path.GetDirectoryName(s_TargetPath);

                if (!Directory.Exists(s_TargetDir))
                    Directory.CreateDirectory(s_TargetDir);

                s_Partition.ToJsonFile(s_TargetPath, Formatting.Indented);
            });*/
        }
    }
}
