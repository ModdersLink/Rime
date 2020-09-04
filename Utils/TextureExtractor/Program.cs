using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using CommandLine;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.Serialization.Containers;
using RimeLib.Texture.Frostbite.Fb2;

namespace TextureExtractor
{
    class Program
    {
        internal class Options
        {
            [Option('q', "quiet", Required = false, Default = false, HelpText = "Suppress console output.")]
            public bool Quiet { get; set; } = true;

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
                // Load Frostbite2_0 assemblies
                LoadContentAssembly(p_Options);

                // Load the Venice bindings
                LoadBindingsAssembly(p_Options);

                // Mount the entire game
                Mount(p_Options, out IEngineMounter s_Mounter);

                // Textures
                DumpTextures(p_Options, s_Mounter);

                Console.WriteLine("Content successfully extracted. Press any key to exit...");
                Console.ReadKey();
            }).WithNotParsed(p_Err => { System.Environment.Exit(1); });
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

        private static void Mount(Options p_Options, out IEngineMounter p_Mounter)
        {
            p_Mounter = EngineMounterRegistry.Create(p_Options.EngineType);

            if (!p_Options.Quiet)
                Console.WriteLine($"Mounting game with engine '{p_Options.EngineType}' at path '{p_Options.GamePath}'. Please wait, this could take a while.");

            /*
             * s_Context!.ProcessCommand("mount_sb win32/xp1chunks true", s_Out, out s_Context);
            s_Context!.ProcessCommand("mount_sb win32/xp4chunks true", s_Out, out s_Context);
            s_Context!.ProcessCommand("mount_sb win32/mpchunks true", s_Out, out s_Context);
            s_Context!.ProcessCommand("mount_sb win32/levels/xp1_002/xp1_002 false", s_Out, out s_Context);
            s_Context!.ProcessCommand("mount_sb win32/levels/xp4_quake/xp4_quake false", s_Out, out s_Context);
            s_Context!.ProcessCommand("mount_sb win32/levels/sp_bank/sp_bank false", s_Out, out s_Context);
            s_Context!.ProcessCommand("mount_bundle win32/levels/xp1_002/xp1_002", s_Out, out s_Context);
            s_Context!.ProcessCommand("mount_bundle win32/levels/xp1_002/CQ_S", s_Out, out s_Context);
            s_Context!.ProcessCommand("mount_bundle win32/levels/XP4_Quake/XP4_Quake", s_Out, out s_Context);
            s_Context!.ProcessCommand("mount_bundle win32/levels/XP4_Quake/DeathMatch", s_Out, out s_Context);
            s_Context!.ProcessCommand("mount_bundle win32/levels/XP4_Quake/TeamDeathMatch", s_Out, out s_Context);
            s_Context!.ProcessCommand("mount_bundle win32/levels/SP_Bank/SP_Bank", s_Out, out s_Context);
            s_Context!.ProcessCommand("mount_bundle win32/levels/SP_Bank/Passage_CUTSCENE", s_Out, out s_Context);*/

            p_Mounter.Mount(p_Options.GamePath, false, EngineType.Frostbite2_0).Wait();
            p_Mounter.MountSuperbundle("Win32/Chunks0", true).Wait();
            p_Mounter.MountSuperbundle("Win32/Chunks1", true).Wait();
            p_Mounter.MountSuperbundle("Win32/Chunks2", true).Wait();
            p_Mounter.MountSuperbundle("Win32/MpChunks", true).Wait();
            p_Mounter.MountSuperbundle("Win32/Xp2Chunks", true).Wait();
            //p_Mounter.MountSuperbundle("Win32/Levels/XP2_Factory/XP2_Factory", true).Wait();
            p_Mounter.MountSuperbundle("Win32/Levels/XP1_002/XP1_002", true).Wait();
            p_Mounter.MountSuperbundle("Win32/Levels/XP4_Quake/XP4_Quake", true).Wait();
            p_Mounter.MountSuperbundle("Win32/Levels/SP_Bank/SP_Bank", true).Wait();

            if (!p_Options.Quiet)
                Console.WriteLine($"Everythingis now mounted! Starting model conversion.");
        }

        private static async void DumpTextures(Options p_Options, IEngineMounter p_Mounter)
        {
            // Iterate through all textures
            var s_Resources = p_Mounter.GetResources();
            foreach (var s_Resource in s_Resources)
            {
                var s_Name = s_Resource.Key;
                var s_Object = s_Resource.Value;

                var s_Variant = s_Object.FirstVariant;

                // Skip anything that is not a FB2 DxTexture or ITexture
                switch (s_Variant.GetResourceType())
                {
                    case RimeLib.Content.Frostbite.ResourceType.ITexture:
                        ParseITexture(p_Options, p_Mounter, s_Name, s_Variant);
                        break;
                    case RimeLib.Content.Frostbite.ResourceType.DxTexture:
                        ParseDxTexture(p_Options, p_Mounter, s_Name, s_Variant);
                        break;
                    default:
                        continue;
                }
            }

            var s_Duplicates = m_SeenGuids.GroupBy(x => x).Where(g => g.Count() > 1).Select(y => y.Key).ToList();
        }


        private static List<string> m_SeenGuids = new List<string>();

        private static void ParseDxTexture(Options p_Options, IEngineMounter p_Mounter, string p_Name, IResourceVariant p_Object)
        {
            // Open a reader to the data
            using var s_VariantData = p_Object.GetReader();

            // Load the texture header
            var s_TextureHeader = new TextureHeader(s_VariantData);

            // Print out debugging information
            if (!p_Options.Quiet)
                Console.WriteLine($"{p_Name} ({s_TextureHeader.ResourceNamehash.ToString("X")}): {s_TextureHeader.Width}x{s_TextureHeader.Height} - {s_TextureHeader.StreamingChunkId}");

            if (m_SeenGuids.Contains(s_TextureHeader.StreamingChunkId.ToString()))
                throw new Exception("duplicate entry found.");

            // Add this to our list
            m_SeenGuids.Add(s_TextureHeader.StreamingChunkId.ToString());
        }

        private static void ParseITexture(Options p_Options, IEngineMounter p_Mounter, string p_Name, IResourceVariant p_Variant)
        {
        }
    }
}
