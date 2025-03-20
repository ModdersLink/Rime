using CommandLine;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using RimeLib;
using GFxTool.Scaleform;
using GFxTool.Scaleform.TagTypes;

namespace GFxTool
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

        }


        static void Main(string[] p_Args)
        {

            //ParseSwf(@"F:\bf3\e3clicktostartscreen.swf");
            //ParseSwf(@"F:\bf3\swf\ui\assets\invitefriendscreen");
            ParseSwf(@"F:\xampp\htdocs\IT2\Tentamen\Oppgave2\Wheel.swf");

            /*
            Parser.Default.ParseArguments<Options>(p_Args).WithParsed(p_Options =>
            {
                LoadEngineAssemblies(p_Options);
                ExportSwfs(p_Options);

                Console.WriteLine("Textures successfully extracted. Press any key to exit...");
                Console.ReadKey();
            }).WithNotParsed(p_Err => { Environment.Exit(1); });
            */
        }

        private static void ParseSwf(string p_Path)
        {

            using var s_Stream = new RimeReader(new FileStream(p_Path, FileMode.Open, FileAccess.Read));
        
            
            var s_SwfFile = new SwfFile(s_Stream);
            
            
            // damageindicator_i1 = UI/Assets/DamageIndicator/damageindicator_i1
            // should subimages just be defined as a seperate image???
            
            foreach (var s_ExternalImageTag in s_SwfFile.Tags.Where(x => x.Tag == SwfTag.GFX_DefineExternalImage2))
            {
                var s_ExternalImage = new TagExternalImage2(s_ExternalImageTag.GetReader());
                
                
            }
        }


        private static void BuildGfx(string p_SwfPath)
        {
            using var s_Stream = new RimeReader(new FileStream(p_SwfPath, FileMode.Open, FileAccess.Read));
        
            
            var s_SwfFile = new SwfFile(s_Stream);
            
            
            
        }


        private static void LoadEngineAssemblies(Options p_Options)
        {
            void Load(string p_Assembly)
            {
                try
                {
                    Assembly.Load(p_Assembly);
                }
                catch
                {
                    if (!p_Options.Quiet)
                        Console.WriteLine($"Failed to load supporting engine assembly ({p_Assembly}.dll). This means that the engine is not supported or that you are missing required files.");

                    Environment.Exit(1);
                }
            }


            if (!p_Options.Quiet)
                Console.WriteLine("Loading engine support assemblies.");

            Load("RimeLib.Content." + p_Options.EngineType);
        }

        private static async void ExportSwfs(Options p_Options)
        {
            var s_Mounter = EngineInterfaceRegistry.Create<IEngineMounter>(p_Options.EngineType);

            var s_MountSuperbundles = p_Options.MountSuperbundles.ToList();
            var s_MountBundles = p_Options.MountBundles.ToList();

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
                var s_SbTasks = s_MountSuperbundles.Select(p_Sb => s_Mounter.MountSuperbundle(p_Sb, s_AutoMountBundles));
                await Task.WhenAll(s_SbTasks);
            }

            // Mount all the requested bundles.
            if (s_MountBundles.Count > 0)
            {
                if (!p_Options.Quiet)
                    Console.WriteLine($"Mounting requested bundles. Please wait, this could take a while.");

                var s_BundleTasks = s_MountBundles.Select(s_Mounter.MountBundle);
                await Task.WhenAll(s_BundleTasks);
            }

            // Dump everything!
            if (!p_Options.Quiet)
                Console.WriteLine($"Everything is now mounted! Starting content extraction.");


            var s_Resources = s_Mounter.GetResources();
            Parallel.ForEach(s_Resources, (p_Pair) =>
            {
                var s_Name = p_Pair.Key;
                var s_Resource = p_Pair.Value;

                if (s_Resource.FirstVariant.GetResourceType() != ResourceType.SwfMovie)
                    return;

                var s_RawReader = s_Resource.FirstVariant.GetReader();

                var s_Data = s_RawReader.ReadBytes((int)s_RawReader.Length);

                if (true)
                {
                    var s_SavePath = Path.Combine(@"F:\bf3\swf\", s_Name);

                    var s_DirectoryPath = Path.GetDirectoryName(s_SavePath)!;

                    if (!Directory.Exists(s_DirectoryPath))
                        Directory.CreateDirectory(s_DirectoryPath!);

                    File.WriteAllBytes(s_SavePath, s_Data);
                }
            });
        }

    }
}
