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
                
            }
            
        }
    }
}