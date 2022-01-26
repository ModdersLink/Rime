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
            [Option('q', "quiet", Required = false, Default = false, HelpText = "Suppress console output")]
            public bool Quiet { get; set; } = false;

            [Option("sliceCount", Default = (short)1, Required = false, HelpText = "For Cube/2DArray textures set the slice count")]
            public short SliceCount { get; set; } = (short)1;

            [Option("textureName", Default = "", Required = false, HelpText = "Texture name (resource hash lookup)")]
            public string TextureName { get; set; } = string.Empty;

            [Option("textureGroup", Default = "Default", Required = false, HelpText = "Texture group name")]
            public string TextureGroup { get; set; } = "Default";

            [Option("mipMapBaseIndex", Default = (byte)1, Required = false, HelpText = "A mip map base index (Default: 0, Max: 14)")]
            public byte MipMapBaseIndex { get; set; } = 1;

            [Value(0, MetaName = "gamePath", Required = true, HelpText = "Path to game files")]
            public string GamePath { get; set; } = string.Empty;

            [Value(1, MetaName = "engineType", Required = true, HelpText = "The engine type of the game")]
            public EngineType EngineType { get; set; }

            [Value(2, MetaName = "inputImage", Required = true, HelpText = "Input *.dds image format")]
            public string InputImage { get; set; } = string.Empty;
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
                FB2DDSImporter.LoadDDS(s_Reader, out var s_Header, out var s_Stream, p_Options.TextureName, p_Options.TextureGroup, p_Options.MipMapBaseIndex, p_Options.SliceCount);

                // Write out the texture data
                using (var s_OutData = new FileStream($"{p_Options.InputImage}.texturedata", FileMode.Create, FileAccess.ReadWrite))
                    s_OutData.Write(new RimeReader(s_Stream).ReadBytes((int)s_Stream.Length));

                // Write out the header with the placeholder information
                using (var s_HeaderStream = new RimeWriter(new FileStream($"{p_Options.InputImage}.headerdata", FileMode.Create, FileAccess.ReadWrite)))
                    s_Header.Serialize(s_HeaderStream);
                
            }
            
        }
    }
}