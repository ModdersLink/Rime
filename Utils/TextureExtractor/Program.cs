using CommandLine;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.IO;
using RimeLib.Texture;
using RimeLib.Texture.Frostbite;
using RimeLib.Texture.Frostbite.DDS;
using RimeLib.Texture.Frostbite2_0;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace TextureExtractor
{
    class Program
    {
        public class Options
        {
            [Option("sb", Required = false, Separator = ',', HelpText = "The superbundles to be mounted. When not specified, all available superbundles are mounted.")]
            public IEnumerable<string> MountSuperbundles { get; set; } = new string[0];

            [Option("bundles", Required = false, Separator = ',', HelpText = "The bundles to be mounted. When not specified, all available bundles are mounted.")]
            public IEnumerable<string> MountBundles { get; set; } = new string[0];

            [Option('q', "quiet", Required = false, Default = false, HelpText = "Suppress console output.")]
            public bool Quiet { get; set; } = false;

            [Value(0, MetaName = "gamePath", Required = true, HelpText = "The path of the game to be whose content you want to extract.")]
            public string GamePath { get; set; } = "";

            [Value(1, MetaName = "engineType", Required = true, HelpText = "The engine type of the game.")]
            public EngineType EngineType
            {
                get; set;
            }

            [Option('t', "textures", Separator = ',', Required = true, HelpText = "The game texture paths you want to dump. !!This is required!!")]
            public IEnumerable<string> TexturePaths { get; set; } = new string[0];


            [Value(2, MetaName = "outPath", Required = false, HelpText = "The output directory where the extracted files will be put into. When not specified, files are dumped into current directory")]
            public string OutputPath { get; set; } = ".";
        }


        static void Main(string[] p_Args)
        {
            /*
            {
                using var s_Reader = new RimeReader(new FileStream(@"F:\Program Files (x86)\Ubisoft\Tom Clancy's The Division Beta\rogue\sdfout\rogue\baked\art\[cinematic]\[_dev]\textures\burnt_wood_n.dds",FileMode.Open, FileAccess.Read, FileShare.Read));

                FB2DDSImporter.LoadDDS(s_Reader, out var s_Header, out var s_Stream);
            }
            */

            Parser.Default.ParseArguments<Options>(p_Args).WithParsed(p_Options =>
            {
                LoadEngineAssemblies(p_Options);
                ExportTextures(p_Options);

                Console.WriteLine("Textures successfully extracted. Press any key to exit...");
                Console.ReadKey();
            }).WithNotParsed(p_Err => { Environment.Exit(1); });
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


        private static async void ExportTextures(Options p_Options)
        {
            var s_Mounter = EngineMounterRegistry.Create( p_Options.EngineType );

            var s_MountSuperbundles = p_Options.MountSuperbundles.ToList( );
            var s_MountBundles = p_Options.MountBundles.ToList( );

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
                var s_SbTasks = s_MountSuperbundles.Select( p_Sb => s_Mounter.MountSuperbundle( p_Sb, s_AutoMountBundles ) );
                await Task.WhenAll(s_SbTasks);
            }


            // Mount all the requested bundles.
            if (s_MountBundles.Count > 0)
            {
                if (!p_Options.Quiet)
                    Console.WriteLine($"Mounting requested bundles. Please wait, this could take a while.");

                var s_BundleTasks = s_MountBundles.Select( s_Mounter.MountBundle );
                await Task.WhenAll(s_BundleTasks);
            }

            // Dump everything!
            if (!p_Options.Quiet)
                Console.WriteLine($"Everything is now mounted! Starting content extraction.");

            /*
              Parallel.ForEach(p_Options.TexturePaths, p_Path =>
            {
                TestImportTexture(s_Mounter, p_Path, p_Options);
            });
             */
            Parallel.ForEach(p_Options.TexturePaths, p_Path =>
            {
                DumpTexture(s_Mounter, p_Path, p_Options);
            });
        }


        private static void TestImportTexture(IEngineMounter p_Mounter, string p_Path, Options p_Options)
        {

            IMountedObject<IResourceVariant> s_TextureObject = null;

            if (!p_Mounter.TryGetResource(p_Path, out s_TextureObject))
            {
                if (!p_Options.Quiet)
                    Console.WriteLine($"Error finding texture resoruce {p_Path}!");
                return;
            }


            TextureBase s_Texture = null;

            if (!TextureHelper.LoadTexture(p_Mounter, s_TextureObject.FirstVariant, out s_Texture))
            {
                if (!p_Options.Quiet)
                    Console.WriteLine($"Error loading texture {p_Path}!");
                return;
            }

            using (var s_MemoryStream = new MemoryStream())
            {
                using var s_RimeWriter = new RimeWriter(s_MemoryStream);

                //DDSExporter.WriteTextureToStream(s_RimeWriter, s_Texture);

                s_MemoryStream.Seek(0, SeekOrigin.Begin);

                using var s_Reader = new RimeReader(s_MemoryStream);

                FB2DDSImporter.LoadDDS(s_Reader, out var s_Header, out var s_Stream);
            }

        }


        private static void DumpTexture(IEngineMounter p_Mounter, string p_Path, Options p_Options)
        {

            IMountedObject<IResourceVariant> s_TextureObject = null;

            if (!p_Mounter.TryGetResource(p_Path, out s_TextureObject))
            {
                if (!p_Options.Quiet)
                    Console.WriteLine($"Error finding texture resoruce {p_Path}!");
                return;
            }


            TextureBase s_Texture = null;

            if (!TextureHelper.LoadTexture(p_Mounter, s_TextureObject.FirstVariant, out s_Texture))
            {
                if (!p_Options.Quiet)
                    Console.WriteLine($"Error loading texture {p_Path}!");
                return;
            }

            var s_SavePath = $"{p_Options.OutputPath}/{Path.GetFileName( p_Path )}.dds";

            if (!p_Options.Quiet)
                Console.WriteLine($"Dumping texture {p_Path} to {s_SavePath}");


            /*
            using (var s_FileStream = new FileStream(s_SavePath, FileMode.OpenOrCreate))
            using (var s_RimeWriter = new RimeWriter(s_FileStream))
                DDSExporter.WriteTextureToStream(s_RimeWriter, s_Texture);
            */
        }




    }
}
