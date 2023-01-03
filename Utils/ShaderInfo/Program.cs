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
using RimeLib.Extensions;
using RimeLib.Shader.Frostbite2_0.Frostbite;
using SharpDX.Direct3D11;

namespace ShaderInfo
{
    class Program
    {
        public class Options
        {
            [Option("sb", Required = false, HelpText = "The superbundles to be mounted. When not specified, all available superbundles are mounted.")]
            public IEnumerable<string> MountSuperbundles { get; set; } = new string[0];

            [Option("bundles", Required = false, HelpText = "The bundles to be mounted. When not specified, all available bundles are mounted.")]
            public IEnumerable<string> MountBundles { get; set; } = new string[0];

            [Option('q', "quiet", Required = false, Default = false, HelpText = "Suppress console output.")]
            public bool Quiet { get; set; } = false;



            [Value(0, MetaName = "gamePath", Required = true, HelpText = "The path of the game to be whose content you want to list.")]
            public string GamePath { get; set; } = "";

            [Value(1, MetaName = "engineType", Required = true, HelpText = "The engine type of the game.")]
            public EngineType EngineType
            {
                get; set;
            }

            [Option('s', "resourcePath", Required = false, HelpText = "The path of the shaderdb you want to print.")]
            public string ResourcePath { get; set; } = string.Empty;
        }

        static async Task Main(string[] p_Args)
        {
            var s_ParseResult = Parser.Default.ParseArguments<Options>(p_Args);

            if (s_ParseResult is Parsed<Options> s_Parsed)
            {
                var s_Options = s_Parsed.Value;
                
                LoadContentAssembly(s_Options);
                await PrintShadersInformation(s_Options);
            }
            else if (s_ParseResult is NotParsed<Options> s_NotParsed)
            {
                Environment.Exit(1);
            }
        }

        private static void LoadContentAssembly(Options p_Options)
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
            s_Load("RimeLib.Shader." + p_Options.EngineType);
            s_Load("RimeLib.Serialization." + p_Options.EngineType);
        }

        private static async Task PrintShadersInformation(Options p_Options)
        {
            /*if (p_Options.ResourcePath != string.Empty)
            {
                using var s_Reader = new RimeReader(File.Open(p_Options.ResourcePath, FileMode.Open, FileAccess.Read, FileShare.Read));
                PrintShader(s_Reader);
            }
            else*/
            {
                var s_Mounter = EngineInterfaceRegistry.Create<IEngineMounter>(p_Options.EngineType);

                var s_MountSuperbundles = p_Options.MountSuperbundles.ToList();
                var s_MountBundles = p_Options.MountBundles.ToList();

                // Only auto-mount when a user has not specified any specific superbundles or bundles.
                if (!p_Options.Quiet)
                    Console.WriteLine($"Mounting game with engine '{p_Options.EngineType}' at path '{p_Options.GamePath}'. Please wait, this could take a while.");

                //await s_Mounter.Mount(p_Options.GamePath, s_MountSuperbundles.Count == 0 && s_MountBundles.Count == 0);
                await s_Mounter.Mount(p_Options.GamePath, true, EngineType.Frostbite2_0);

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
                    Console.WriteLine($"Everything is now mounted! Starting content listing.");

                if (!string.IsNullOrWhiteSpace(p_Options.ResourcePath))
                {
                    if (!s_Mounter.TryGetResource(p_Options.ResourcePath, out var s_Resource))
                        throw new Exception("Could not find the specified resource.");
                    
                    using var s_Reader = s_Resource.FirstVariant.GetReader();
                    PrintShader(s_Reader, s_Mounter);
                }
                else
                {
                    Parallel.ForEach(s_Mounter.GetResources(), p_Resource =>
                    {
                        if (p_Resource.Value.FirstVariant.GetResourceType() != ResourceType.DxShaderDatabase &&
                            p_Resource.Value.FirstVariant.GetResourceType() != ResourceType.IShaderDatabase)
                            return;

                        using var s_Reader = p_Resource.Value.FirstVariant.GetReader();
                        PrintShader(s_Reader, s_Mounter);
                    });
                }
                
                Console.WriteLine("Done!");
            }
        }

        private static void PrintShader(RimeReader p_ResourceReader, IEngineMounter p_Mounter)
        {
            // ZLib stream cant seek, doing it this way
            var s_ShaderDbData = p_ResourceReader.ToArray();

            using var s_Reader = new RimeReader(new MemoryStream(s_ShaderDbData));
            var s_Container = new ShaderDatabaseContainer(s_Reader, p_Mounter);

            foreach (var (s_Path, s_Database) in s_Container.Databases)
            {
                foreach (var (s_Name, s_Shader) in s_Database.Shaders)
                {
                    foreach (var s_Solution in s_Shader.Solutions)
                    {
                        if (s_Solution.VertexPermutation != null)
                        {
                            File.WriteAllBytes(
                                "F:\\Rime\\shaders\\" + s_Solution.VertexPermutation.Guid + ".bin",
                                s_Solution.VertexPermutation.ShaderBytecode
                            );
                        }
                        
                        if (s_Solution.PixelPermutation != null)
                        {
                            File.WriteAllBytes(
                                "F:\\Rime\\shaders\\" + s_Solution.PixelPermutation.Guid + ".bin",
                                s_Solution.PixelPermutation.ShaderBytecode
                            );
                        }
                        
                        if (s_Solution.GeometryPermutation != null)
                        {
                            File.WriteAllBytes(
                                "F:\\Rime\\shaders\\" + s_Solution.GeometryPermutation.Guid + ".bin",
                                s_Solution.GeometryPermutation.ShaderBytecode
                            );
                        }
                    }
                }
            }
        }
    }
}
