using CommandLine;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.IO;
using RimeLib.Shader.Frostbite2_0.Frostbite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using RimeLib;
using RimeLib.Extensions;

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

        static void Main(string[] p_Args)
        {
            Parser.Default.ParseArguments<Options>(p_Args).WithParsed(p_Options =>
            {
                LoadContentAssembly(p_Options);
                PrintShadersInformation(p_Options);
            }).WithNotParsed(p_Err =>
            {
                Console.ReadKey();
                Environment.Exit(1);
            });
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
        }

        private static async void PrintShadersInformation(Options p_Options)
        {
            if (p_Options.ResourcePath != string.Empty)
            {
                using var s_Reader = new RimeReader(File.Open(p_Options.ResourcePath, FileMode.Open, FileAccess.Read, FileShare.Read));
                PrintShader(s_Reader);
            }
            else
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

                foreach (var s_Resource in s_Mounter.GetResources())
                {
                    if (s_Resource.Value.FirstVariant.GetResourceType() != ResourceType.DxShaderDatabase &&
                        s_Resource.Value.FirstVariant.GetResourceType() != ResourceType.IShaderDatabase)
                        continue;

                    using var s_Reader = s_Resource.Value.FirstVariant.GetReader();
                    PrintShader(s_Reader);
                }
            }
        }

        private static void PrintShader(RimeReader p_ResourceReader)
        {
            // ZLib stream cant seek, doing it this way
            var s_ShaderDbData = p_ResourceReader.ToArray();

            var s_ShaderWrapper = new ShaderDBWrapper(new RimeReader(new MemoryStream(s_ShaderDbData)));


            foreach (var s_ShaderDb in s_ShaderWrapper.Shaders)
            {
                Console.WriteLine($"ShaderDB - {s_ShaderDb.Key.ToString()}:");

                foreach (var s_ShaderInfo in s_ShaderDb.Value.IdMap)
                {
                    Console.WriteLine($"\tShader hash - 0x{s_ShaderInfo.Key:X}:");

                    Console.WriteLine($"\t\tType: {s_ShaderInfo.Value.SurfaceShaderType}");

                    Console.WriteLine("\t\tTextures: ");
                    foreach (var s_Texture in s_ShaderInfo.Value.StreamableTextures)
                        Console.WriteLine($"\t\t\t[{s_Texture.VertexUsage}] = {s_Texture.Name}");

                    Console.WriteLine("\t\tExternalTextures: ");
                    foreach (var s_Texture in s_ShaderInfo.Value.StreamableExternalTextures)
                        Console.WriteLine($"\t\t\t[{s_Texture.VertexUsage}] | {s_Texture.ParameterId} = {s_Texture.ParameterName}");


                    Console.WriteLine("\t\tSolution: ");

                    foreach (var s_SolutionIndex in s_ShaderInfo.Value.SolutionIndices)
                    {
                        if (s_SolutionIndex >= s_ShaderDb.Value.Solutions.Length)
                        {
                            Console.WriteLine("\t\t\tInvalid shader!");
                            continue;
                        }



                        var s_Solution = s_ShaderDb.Value.Solutions[s_SolutionIndex];

                        Console.WriteLine($"\t\t\tSolution - {s_SolutionIndex}:");

                        Console.WriteLine($"\t\t\t\tSurfaceType: {s_Solution.SurfaceType}");

                        Console.WriteLine("\t\t\t\tVertexConstants:");
                        {
                            if (s_Solution.VertexConstantsIndex >= s_ShaderDb.Value.Constants.Length)
                            {
                                Console.WriteLine("\t\t\t\t\tInvalid constants!");
                                continue;
                            }

                            var s_Constants = s_ShaderDb.Value.Constants[s_Solution.VertexConstantsIndex];

                            Console.WriteLine("\t\t\t\t\tTextures:");
                            foreach (var s_Texture in s_Constants.Textures)
                                Console.WriteLine($"\t\t\t\t\t\t[{s_Texture.Index}] = {s_Texture.Name} (type {s_Texture.TextureType})");

                            Console.WriteLine("\t\t\t\t\tExternalTextures:");
                            foreach (var s_Texture in s_Constants.ExternalTextures)
                                Console.WriteLine($"\t\t\t\t\t\t[{s_Texture.Index}] {s_Texture.Required.ToString()} = {s_Texture.Name} (type {s_Texture.TextureType})");


                            Console.WriteLine("\t\t\t\t\tExternalValues:");
                            foreach (var s_Value in s_Constants.ExternalValues)
                                Console.WriteLine($"\t\t\t\t\t\t[{s_Value.Index}] {s_Value.Required.ToString()} = {s_Value.Name} = ({s_Value.DefaultValue.x}, {s_Value.DefaultValue.y}, {s_Value.DefaultValue.z}, {s_Value.DefaultValue.w})");

                        }


                        Console.WriteLine("\t\t\t\tPixelConstants:");
                        {
                            if (s_Solution.PixelConstantsIndex >= s_ShaderDb.Value.Constants.Length)
                            {
                                Console.WriteLine("\t\t\t\t\tInvalid constants!");
                                continue;
                            }

                            var s_Constants = s_ShaderDb.Value.Constants[s_Solution.PixelConstantsIndex];

                            Console.WriteLine("\t\t\t\t\tTextures:");
                            foreach (var s_Texture in s_Constants.Textures)
                                Console.WriteLine($"\t\t\t\t\t\t[{s_Texture.Index}] = {s_Texture.Name} (type {s_Texture.TextureType})");

                            Console.WriteLine("\t\t\t\t\tExternalTextures:");
                            foreach (var s_Texture in s_Constants.ExternalTextures)
                                Console.WriteLine($"\t\t\t\t\t\t[{s_Texture.Index}] {s_Texture.Required.ToString()} = {s_Texture.Name} (type {s_Texture.TextureType})");


                            Console.WriteLine("\t\t\t\t\tExternalValues:");
                            foreach (var s_Value in s_Constants.ExternalValues)
                                Console.WriteLine($"\t\t\t\t\t\t[{s_Value.Index}] {s_Value.Required.ToString()} = {s_Value.Name} = ({s_Value.DefaultValue.x}, {s_Value.DefaultValue.y}, {s_Value.DefaultValue.z}, {s_Value.DefaultValue.w})");

                        }
                    }

                    //Console.ReadKey();
                }

                foreach (var s_VertexShader in s_ShaderDb.Value.VertexShaderPermutations)
                {
                    File.WriteAllBytes(Path.Join("B:\\RimePlayground\\shaders\\hlsl\\", s_ShaderDb.Key + "_" + s_VertexShader.Guid + ".vs.bin"), s_VertexShader.ShaderBytecode);
                    File.WriteAllBytes(Path.Join("B:\\RimePlayground\\shaders\\hlsl\\", s_ShaderDb.Key + "_" + s_VertexShader.Guid + "_bytecode.vs.bin"), s_VertexShader.InputSignatureBytecode);
                }

                foreach (var s_PixelShader in s_ShaderDb.Value.PixelShaderPermutations)
                {
                    File.WriteAllBytes(Path.Join("B:\\RimePlayground\\shaders\\hlsl\\", s_ShaderDb.Key + "_" + s_PixelShader.Guid + ".ps.bin"), s_PixelShader.ShaderData);
                }

                foreach (var s_GeoShader in s_ShaderDb.Value.GeometryShaderPermutations)
                {
                    File.WriteAllBytes(Path.Join("B:\\RimePlayground\\shaders\\hlsl\\", s_ShaderDb.Key + "_" + s_GeoShader.Guid + ".gs.bin"), s_GeoShader.ShaderData);
                }
            }

        }
    }
}
