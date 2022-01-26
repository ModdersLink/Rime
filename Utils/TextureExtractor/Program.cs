using CommandLine;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.IO;
using RimeLib.Texture;
using System;
using System.Collections.Generic;
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

            [Option('t', "textures", Separator = ',', Required = true, HelpText = "The game texture paths you want to dump. or (*) for all, !!This is required!!")]
            public IEnumerable<string> TexturePaths { get; set; } = new string[0];


            [Value(2, MetaName = "outPath", Required = false, HelpText = "The output directory where the extracted files will be put into. When not specified, files are dumped into current directory")]
            public string OutputPath { get; set; } = ".";
        }


        static void Main(string[] p_Args)
        {
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
            // Multi-texture export
            if (p_Options.TexturePaths.FirstOrDefault() == "*")
            {
                // Get all of the resources
                var s_Resources = s_Mounter.GetResources();
                Parallel.ForEach(s_Resources, (p_Pair) =>
                {
                    var s_Name = p_Pair.Key;
                    var s_Resource = p_Pair.Value;

                    if (!s_Name.Contains("bigradiotower_sp_jet"))
                        return;

                    switch (s_Resource.FirstVariant.GetResourceType())
                    {
                        case ResourceType.DxTexture:
                            DumpTexture(s_Mounter, s_Name, p_Options);
                            break;
                        case ResourceType.ITexture:
                        case ResourceType.AtlasTexture:
                        case ResourceType.Dx11Texture:
                        case ResourceType.Dx12Texture:
                        case ResourceType.MovieTexture:
                        case ResourceType.Ps3Texture:
                        case ResourceType.RenderTexture:
                        case ResourceType.XenonTexture:
                            throw new NotImplementedException($"Unknown Texture Type {s_Resource.FirstVariant.GetResourceType()}");
                        //DumpTexture(s_Mounter, s_Name, p_Options);
                        //break;
                        
                        default:
                            break;
                    }
                });

            }
            else 
            {
                // Single texture export
                Parallel.ForEach(p_Options.TexturePaths, p_Path =>
                {
                    DumpTexture(s_Mounter, p_Path, p_Options);
                });
            }
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


            var s_Loader = TextureLoaderRegistry.FindLoader( p_Mounter.GetEngineType( ) );


            if (s_Loader == null)
            {
                if (!p_Options.Quiet)
                    Console.WriteLine($"Error find texture loader for engine {p_Mounter.GetEngineType()}!");
                return;
            }


            if (!s_Loader.Load(p_Mounter, s_TextureObject.FirstVariant, out var s_Texture))
            {
                if (!p_Options.Quiet)
                    Console.WriteLine($"Error loading texture {p_Path}!");
                return;
            }

            var s_DDSHandler = TextureFileHandlerRegistry.FindHandler("dds");

            if (s_DDSHandler is null)
            {
                if (!p_Options.Quiet)
                    Console.WriteLine($"Dds not supported?!");
                return;
            }

            using (var s_MemoryStream = new MemoryStream())
            {
                using var s_RimeWriter = new RimeWriter(s_MemoryStream);

                s_DDSHandler!.Save(s_Texture, s_RimeWriter);
                //DDSExporter.WriteTextureToStream(s_RimeWriter, s_Texture);

                s_MemoryStream.Seek(0, SeekOrigin.Begin);

                using var s_Reader = new RimeReader(s_MemoryStream);


                if (!s_DDSHandler!.Load(s_Loader, s_Reader, out var s_NewTexture))
                {
                    Console.WriteLine("Failed to load texture again!");
                    return;
                }
            }

        }


        private static void DumpTexture(IEngineMounter p_Mounter, string p_Path, Options p_Options, string p_Extension = "dds")
        {

            IMountedObject<IResourceVariant> s_TextureObject = null;

            if (!p_Mounter.TryGetResource(p_Path, out s_TextureObject))
            {
                if (!p_Options.Quiet)
                    Console.WriteLine($"Error finding texture resoruce {p_Path}!");
                return;
            }

            if (!TextureHelper.LoadTexture(p_Mounter, s_TextureObject.FirstVariant, out TextureBase s_Texture))
            {
                if (!p_Options.Quiet)
                    Console.WriteLine($"Error loading texture {p_Path}!");
                return;
            }

            var s_SavePath = $"{p_Options.OutputPath}/{p_Path}.{p_Extension}";

            var s_DirectoryPath = Path.GetDirectoryName(s_SavePath)!;
            if (!Directory.Exists(s_DirectoryPath))
                Directory.CreateDirectory(s_DirectoryPath);


            if (!p_Options.Quiet)
                Console.WriteLine($"Dumping texture {p_Path} to {s_SavePath}");

            var s_SaveHandler = TextureFileHandlerRegistry.FindHandler(p_Extension);

            using var s_FileStream = new FileStream(s_SavePath, FileMode.OpenOrCreate);
            using var s_RimeWriter = new RimeWriter(s_FileStream);

            s_SaveHandler?.Save(s_Texture, s_RimeWriter);

        }
    }
}
