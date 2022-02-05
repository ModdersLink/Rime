using CommandLine;
using RimeLib.Frostbite;
using RimeLib.Serialization.Frostbite2_0.Ebx;
using System;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RimeLib.Content.Building;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Frostbite2_0.Frostbite.Chunks;
using RimeLib.Content.Frostbite2_0.Frostbite.Sb;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite.Core;
using RimeLib.Frostbite.Db;
using RimeLib.IO;
using RimeLib.IO.Conversion;
using RimeLib.Texture;
using RimeLib.Texture.Frostbite2_0;

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
        internal class FileReader : IReadableObject
        {
            private readonly string m_Path;

            public FileReader(string p_Path)
            {
                m_Path = p_Path;
            }

            public RimeReader GetReader()
            {
                var s_FileStream = File.Open(m_Path, FileMode.Open, FileAccess.Read);
                return new RimeReader(s_FileStream);
            }

            public long GetSize()
            {
                return new FileInfo(m_Path).Length;
            }
        }

        internal class ChunkStreamReader : IChunkObject
        {
            private readonly Stream m_Stream;
            private readonly int m_AssetNameHash;
            private readonly int? m_FirstMip;

            public ChunkStreamReader(Stream p_Stream, uint p_AssetNameHash, int? p_FirstMip)
            {
                m_Stream = p_Stream;
                m_AssetNameHash = (int) p_AssetNameHash;
                m_FirstMip = p_FirstMip;
            }

            public bool TryGetMeta(out DbObject? p_Meta)
            {
                var s_Meta = new ChunkEntry.ChunkMetaEntry()
                {
                    AssetNameHash = m_AssetNameHash,
                    Payload = new ChunkEntry.ChunkMetaPayload()
                    {
                        FirstMip = m_FirstMip,
                    },
                };

                p_Meta = DbObjectConverter.ToDbObject(s_Meta);

                return true;
            }

            public uint GetRangeStart()
            {
                return 0;
            }

            public uint GetLogicalOffset()
            {
                return 0;
            }

            public RimeReader GetReader()
            {
                return new RimeReader(m_Stream, Endianness.LittleEndian, false);
            }

            public long GetSize()
            {
                return m_Stream.Length;
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

            public bool TryGetMeta(out byte[]? p_Meta)
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
        }

        private static async void DumpFiles(Options p_Options)
        {
            var s_Partition = DatabasePartition.FromJsonFile(@"B:\ebx-test\vu_test.json");
            var s_EbxWriter = new EbxWriter();

            using (var s_Writer = new RimeWriter(File.OpenWrite(@"B:\ebx-test\vu_test.ebx")))
                s_EbxWriter.Serialize(s_Writer, s_Partition);

            var s_SbBuilder = SuperbundleBuilder.Create(p_Options.EngineType, "VuTest");
            //var s_SbChunksBuilder = SuperbundleBuilder.Create(p_Options.EngineType, "VuTestChunks");
            var s_BundleBuilder = BundleBuilder.Create("Win32/VuTest/Main");

            s_BundleBuilder.WithPartition("weapons/xp2_knife_razorblade/knife_razorblade_d2", new FileReader(@"B:\ebx-test\vu_test.ebx"));

            using (var s_DdsReader = new RimeReader(File.OpenRead(@"B:\dds-dump\weapons\xp2_knife_razorblade\knife_razorblade_d2.dds")))
            {
                FB2DDSImporter.LoadDDS(s_DdsReader, out var s_Header, out var s_ChunkStream);

                s_Header.StreamingChunkId = new GUID(Guid.NewGuid());

                s_ChunkStream.Seek(0, SeekOrigin.Begin);

                // Write out the texture data
                s_ChunkStream.Seek(0, SeekOrigin.Begin);
                s_BundleBuilder.WithChunk(s_Header.StreamingChunkId, new ChunkStreamReader(s_ChunkStream, Utils.HashQuickLowerCase("weapons/xp2_knife_razorblade/knife_razorblade_d2"), null));

                using (var s_ChunkWriter = new RimeWriter(File.OpenWrite(@"B:\ebx-test\chunk.bin")))
                {
                    s_ChunkStream.Seek(0, SeekOrigin.Begin);
                    s_ChunkStream.CopyTo(s_ChunkWriter);
                    s_ChunkStream.Seek(0, SeekOrigin.Begin);
                };

                //var s_ResourceReader = File.OpenRead(@"I:\Research\BF3\Dump\Files\bundles\res\weapons\xp2_knife_razorblade\knife_razorblade_d2.DxTexture");
                //var s_ChunkReader = File.OpenRead(@"I:\Research\BF3\Dump\Files\chunks - Copy\8a88f084aa35689b38e89957dd412ea5.chunk");

                //s_SbChunksBuilder.WithChunk(new GUID("4525e261-bfc8-4906-8459-52b76bbabbee"), new ChunkStreamReader(s_ChunkStream));
                //s_BundleBuilder.WithChunk(new GUID("4525e261-bfc8-4906-8459-52b76bbabbee"), new ChunkStreamReader(s_ChunkReader, Utils.HashQuickLowerCase("weapons/xp2_knife_razorblade/knife_razorblade_d2"), null));

                var s_HeaderStream = new MemoryStream();

                using (var s_HeaderWriter = new RimeWriter(s_HeaderStream, Endianness.LittleEndian, false))
                    s_Header.Serialize(s_HeaderWriter);

                s_HeaderStream.Seek(0, SeekOrigin.Begin);

                s_BundleBuilder.WithResource("weapons/xp2_knife_razorblade/knife_razorblade_d2", new ResourceStreamReader(s_HeaderStream, ResourceType.DxTexture));
                //s_BundleBuilder.WithResource("weapons/xp2_knife_razorblade/knife_razorblade_d2", new ResourceStreamReader(s_ResourceReader, ResourceType.DxTexture));

                using (var s_ResWriter = new RimeWriter(File.OpenWrite(@"B:\ebx-test\resource.bin")))
                {
                    s_HeaderStream.Seek(0, SeekOrigin.Begin);
                    s_HeaderStream.CopyTo(s_ResWriter);
                    s_HeaderStream.Seek(0, SeekOrigin.Begin);
                };
            }

            s_SbBuilder.WithBundle(s_BundleBuilder.Build());

            var s_SbStream = File.Open(@"B:\Games\Battlefield 3\vu\Data\VuTest.sb", FileMode.Create, FileAccess.ReadWrite);
            //var s_SbChunksStream = File.Open(@"B:\Games\Battlefield 3\vu\Data\VuTestChunks.sb", FileMode.Create, FileAccess.ReadWrite);
            var s_TocStream = File.Open(@"B:\Games\Battlefield 3\vu\Data\VuTest.toc", FileMode.Create, FileAccess.ReadWrite);
            //var s_TocChunksStream = File.Open(@"B:\Games\Battlefield 3\vu\Data\VuTestChunks.toc", FileMode.Create, FileAccess.ReadWrite);

            s_SbBuilder.Build(s_SbStream, s_TocStream);
            //s_SbChunksBuilder.Build(s_SbChunksStream, s_TocChunksStream);

            s_SbStream.Dispose();
            s_TocStream.Dispose();

            //using var s_ContentManifestReader = new RimeReader(File.Open(@"B:\Games\Battlefield 3\vu\Data\VuTest.toc", FileMode.Open, FileAccess.Read, FileShare.Read));
            using var s_ContentManifestReader = new RimeReader(File.Open(@"B:\Games\Battlefield 3\Update\Xpack5\Data\Win32\Levels\XP5_001\XP5_001.toc", FileMode.Open, FileAccess.Read, FileShare.Read));
            var s_ManifestToc = new TableOfContents<SuperbundleLayout>(s_ContentManifestReader);

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

            await s_Mounter.MountStandaloneSuperbundle("VuTest", @"B:\Games\Battlefield 3\vu\Data\VuTest.sb", true);
            //await s_Mounter.MountStandaloneSuperbundle("Win32/Levels/XP5_001/XP5_001", @"B:\Games\Battlefield 3\Update\Xpack5\Data\Win32\Levels\XP5_001\XP5_001.sb", true);
            //await s_Mounter.Mount(p_Options.GamePath, true, EngineType.Frostbite2_0);
            //await s_Mounter.MountSuperbundle("Win32/Chunks0", true);
            //await s_Mounter.MountSuperbundle("Win32/Chunks1", true);
            //await s_Mounter.MountSuperbundle("Win32/Chunks2", true);
            //await s_Mounter.MountSuperbundle("Win32/MpChunks", true);
            //await s_Mounter.MountSuperbundle("Win32/Xp2Chunks", true);
            //await s_Mounter.MountSuperbundle("Win32/Levels/XP2_Factory/XP2_Factory", true);

            if (!p_Options.Quiet)
                Console.WriteLine($"Everything is now mounted! Starting audio conversion.");

            var s_Resources = s_Mounter.GetResources();
            Parallel.ForEach(s_Resources, (p_Pair) =>
            //foreach (var p_Pair in s_Resources)
            {
                var s_Name = p_Pair.Key;
                var s_Resource = p_Pair.Value;

                if (s_Resource.FirstVariant.GetResourceType() != ResourceType.DxTexture)
                    return;
                
                TextureBase s_Texture = null;

                if (!TextureHelper.LoadTexture(s_Mounter, s_Resource.FirstVariant, out s_Texture))
                {
                    if (!p_Options.Quiet)
                        Console.WriteLine($"Error loading texture!");
                    return;
                }

                var s_SavePath = $"B:/dds-dump2/{s_Name}.dds";

                var s_DirectoryPath = Path.GetDirectoryName(s_SavePath)!;
                if (!Directory.Exists(s_DirectoryPath))
                    Directory.CreateDirectory(s_DirectoryPath);

                var s_SaveHandler = TextureFileHandlerRegistry.FindHandler("dds");

                using var s_FileStream = new FileStream(s_SavePath, FileMode.OpenOrCreate);
                using var s_RimeWriter = new RimeWriter(s_FileStream);

                s_SaveHandler?.Save(s_Texture, s_RimeWriter);
            });
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
