using CommandLine;
using fb;
using RimeLib.Content.Building;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.Frostbite.Db;
using RimeLib.IO;
using RimeLib.Serialization.Frostbite2_0.Ebx;
using RimeLib.Texture.Frostbite;
using RimeLib.Texture.Frostbite2_0;
using RimeLib.Utils;
using System;
using System.Reflection;

namespace TextureExtractor // Note: actual namespace depends on the project name.
{
    internal class Program
    {
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

        internal class StreamReader : IReadableObject
        {
            private readonly Stream m_Path;

            public StreamReader(Stream p_Path)
            {
                m_Path = p_Path;
            }

            public RimeReader GetReader()
            {
                return new RimeReader(m_Path);
            }

            public long GetSize()
            {
                return m_Path.Length;
            }
        }

        internal class ChunkStreamReader : StreamReader, IChunkObject
        {
            public ChunkStreamReader(Stream p_Path) :
                base(p_Path)
            {
            }

            public bool TryGetMeta(out DbObject? p_Meta)
            {
                p_Meta = null;
                return false;
            }

            public uint GetRangeStart()
            {
                return 0;
            }

            public uint GetLogicalOffset()
            {
                return 0;
            }
        }

        internal class ChunkFileReader : FileReader, IChunkObject
        {
            public ChunkFileReader(string p_Path) :
                base(p_Path)
            {
            }

            public bool TryGetMeta(out DbObject? p_Meta)
            {
                p_Meta = null;
                return false;
            }

            public uint GetRangeStart()
            {
                return 0;
            }

            public uint GetLogicalOffset()
            {
                return 0;
            }
        }

        public class Options
        {
            [Option('q', "quiet", Required = false, Default = false, HelpText = "Suppress console output.")]
            public bool Quiet { get; set; } = false;

            [Value(0, MetaName = "gamePath", Required = true, HelpText = "")]
            public string GamePath { get; set; } = string.Empty;

            [Value(1, MetaName = "engineType", Required = true, HelpText = "The engine type of the game.")]
            public EngineType EngineType { get; set; }

            [Value(2, MetaName = "inputImage", Required = true, HelpText = "Input *.dds image format.")]
            public string InputImage { get; set; } = string.Empty;

            [Value(3, MetaName = "gameImagePath", Required = true, HelpText = "Path to place image (ex: Textures/Advertisement/Advertisement_1024x512_01).")]
            public string GameImagePath { get; set; } = string.Empty;
        }

        private static void LoadEngineAssemblies(Options p_Options)
        {
            Func<string, bool> s_Load = (p_Assembly) =>
            {
                try
                {
                    Assembly.Load(p_Assembly);
                    return true;
                }
                catch
                {
                    if (!p_Options.Quiet)
                        Console.WriteLine($"Failed to load supporting engine assembly ({p_Assembly}.dll). This means that the engine is not supported or that you are missing required files.");

                    Environment.Exit(1);
                }
                return false;
            };


            if (!p_Options.Quiet)
                Console.WriteLine("Loading engine support assemblies.");

            s_Load("RimeLib.Content." + p_Options.EngineType);
            s_Load("RimeLib.Texture." + p_Options.EngineType);
        }

        static void Main(string[] p_Args)
        {
            Parser.Default.ParseArguments<Options>(p_Args).WithParsed(p_Options =>
            {
                LoadEngineAssemblies(p_Options);
                BuildImageSuperbundle(p_Options);

                Console.WriteLine("Textures successfully extracted. Press any key to exit...");
                Console.ReadKey();
            }).WithNotParsed(p_Err => { Environment.Exit(1); });
        }

        static async void BuildImageSuperbundle(Options p_Options)
        {
            if (!File.Exists(p_Options.InputImage))
            {
                Console.WriteLine($"ERR: Input image {p_Options.InputImage} not found.");
                return;
            }

            using (var s_Reader = new RimeReader(new FileStream(p_Options.InputImage, FileMode.Open, FileAccess.Read)))
            {
                FB2DDSImporter.LoadDDS(s_Reader, out var s_Header, out var s_Stream);

                s_Header.TextureGroup = "Default";

                // Write out the texture data
                using (var s_OutData = new FileStream($"{p_Options.InputImage}.texturedata", FileMode.Create, FileAccess.ReadWrite))
                    s_OutData.Write(new RimeReader(s_Stream).ReadBytes((int)s_Stream.Length));

                // Write out the header with the placeholder information
                using (var s_HeaderStream = new RimeWriter(new FileStream($"{p_Options.InputImage}.headerdata", FileMode.Create, FileAccess.ReadWrite)))
                    s_Header.Serialize(s_HeaderStream);
                


                // Update the header with the game image path (ex: Textures/Advertisement/Advertisement_1024x512_01)
                //s_Header.ResourceNamehash = FbUtils.HashQuick(p_Options.GameImagePath);

                /*#region Ebx
                // First we need to create a new partition
                DatabasePartition s_ImagePartition = new DatabasePartition
                {
                    Name = p_Options.GameImagePath, // Textures/Advertisement/Advertisement_1024x512_01
                    PartitionGuid = Guid.NewGuid(),
                };

                // Create a new TextureAsset
                var s_TextureAssetId = Guid.NewGuid();
                s_ImagePartition.Instances.Add(s_TextureAssetId, new TextureAsset
                {
                    Name = p_Options.GameImagePath // Textures/Advertisement/Advertisement_1024x512_01
                });

                // Assign the primary instance id
                s_ImagePartition.PrimaryInstanceGuid = s_TextureAssetId;
                #endregion*/

                /*#region Texture data chunk
                var s_TextureDataChunkId = new GUID(Guid.NewGuid());
                var s_TextureDataChunk = new ChunkStreamReader(s_Stream);

                // Assign the StreamingChunkId to the texture data
                s_Header.StreamingChunkId = s_TextureDataChunkId;
                #endregion

                #region Texture Header
                if (!s_Header.Serialize(out byte[] s_TextureHeaderData))
                {
                    Console.WriteLine("could not serialize texture header.");
                    return;
                }

                // TODO: Create a new resource

                #endregion

                // Create a new superbundle
                var s_SbBuilder = SuperbundleBuilder.Create(p_Options.EngineType, "");

                // Create a new bundle to hold our texture information/data
                var s_Bundle = BundleBuilder.Create("");


                // Add the chunk to the bundle
                //s_Bundle.WithChunk(s_NewGuid, new ChunkStreamReader(s_Stream));

                // We also need to create a TextureData chunk
                /*FB2Texture s_Texture = new FB2Texture(s_Header.Type, s_Header.Format, (uint)s_Header.Width, (uint)s_Header.Height, s_Header.MipmapCount, s_Header.Flags);

                using (var s_TextureHeaderStream = new MemoryStream())
                {
                    if (!s_Texture.SerializeHeaderData(s_TextureHeaderStream))
                    {
                        Console.WriteLine($"there was an error serializing {p_Options.InputImage}.");
                        return;
                    }

                    var s_TextureHeaderData = s_TextureHeaderStream.ToArray();

                    var s_TextureHeaderDataChunkId = new GUID(Guid.NewGuid());
                    s_NewGuid.SetCompressionFlag(false);


                    s_TextureHeaderStream.Seek(0, SeekOrigin.Begin);

                    s_Bundle.WithChunk(s_TextureHeaderDataChunkId, new ChunkStreamReader(s_TextureHeaderStream));
                }*/
                //s_SbBuilder.WithBundle()
            }
            
        }
    }
}