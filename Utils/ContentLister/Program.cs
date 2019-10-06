using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using CommandLine;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using Environment = System.Environment;

namespace Rime.Utils.ContentLister
{
    class Program
    {
        public class Options
        {
            [Option("sb", Required = false, HelpText = "The superbundles to be mounted. When not specified, all available superbundles are mounted.")]
            public IEnumerable<string> MountSuperbundles { get; set; } = new string[0];

            [Option("bundles", Required = false, HelpText = "The bundles to be mounted. When not specified, all available bundles are mounted.")]
            public IEnumerable<string> MountBundles { get; set; } = new string[0];

            [Option('v', "verbose", Required = false, Default = false, HelpText = "Enable more verbose console output. Useful for debugging.")]
            public bool Verbose { get; set; } = false;
            
            [Option('s', "sorted", Required = false, Default = false, HelpText = "List all content in a sorted / grouped ordering.")]
            public bool Sort { get; set; } = false;
            
            [Option('u', "unique", Required = false, Default = false, HelpText = "Only list unique resources without superbundle or bundle information.")]
            public bool Unique { get; set; } = false;

            [Value(0, MetaName = "gamePath", Required = true, HelpText = "The path of the game to be whose content you want to list.")]
            public string GamePath { get; set; } = "";

            [Value(1, MetaName = "engineType", Required = true, HelpText = "The engine type of the game.")]
            public EngineType EngineType { get; set; }
        }

        static void Main(string[] p_Args)
        {
            Parser.Default.ParseArguments<Options>(p_Args).WithParsed(p_Options =>
            {
                LoadContentAssembly(p_Options);
                DumpFiles(p_Options);
            }).WithNotParsed(p_Err => { Environment.Exit(1); });
        }

        private static void LoadContentAssembly(Options p_Options)
        {
            var s_AssemblyName = "RimeLib.Content." + p_Options.EngineType;

            try
            {
                if (p_Options.Verbose)
                    Console.WriteLine("Loading engine content support assembly.");

                Assembly.Load(s_AssemblyName);
            }
            catch
            {
                Console.WriteLine($"Failed to load supporting engine assembly ({s_AssemblyName}.dll). This means that the engine is not supported or that you are missing required files.");
                Environment.Exit(1);
            }
        }

        private static async void DumpFiles(Options p_Options)
        {
            var s_Mounter = EngineMounterRegistry.Create(p_Options.EngineType);

            var s_MountSuperbundles = p_Options.MountSuperbundles.ToList();
            var s_MountBundles = p_Options.MountBundles.ToList();

            // Only auto-mount when a user has not specified any specific superbundles or bundles.
            if (p_Options.Verbose)
                Console.WriteLine($"Mounting game with engine '{p_Options.EngineType}' at path '{p_Options.GamePath}'. Please wait, this could take a while.");

            await s_Mounter.Mount(p_Options.GamePath, s_MountSuperbundles.Count == 0 && s_MountBundles.Count == 0);
           
            // Mount the requested superbundles.
            if (s_MountSuperbundles.Count > 0)
            {
                if (p_Options.Verbose)
                    Console.WriteLine($"Mounting requested superbundles. Please wait, this could take a while.");

                var s_AutoMountBundles = s_MountBundles.Count == 0;
                var s_SbTasks = s_MountSuperbundles.Select(p_Sb => s_Mounter.MountSuperbundle(p_Sb, s_AutoMountBundles));
                await Task.WhenAll(s_SbTasks);
            }


            // Mount all the requested bundles.
            if (s_MountBundles.Count > 0)
            {
                if (p_Options.Verbose)
                    Console.WriteLine($"Mounting requested bundles. Please wait, this could take a while.");

                var s_BundleTasks = s_MountBundles.Select(s_Mounter.MountBundle);
                await Task.WhenAll(s_BundleTasks);
            }

            // Dump everything!
            if (p_Options.Verbose)
                Console.WriteLine($"Everything is now mounted! Starting content listing.");

            var s_Resources = new ConcurrentDictionary<string, bool>();

            Parallel.ForEach(s_Mounter.GetChunks(), p_Pair =>
            {
                Print(p_Options, s_Resources, "chunk", "_chunks/" + p_Pair.Key.ToString("D"), p_Pair.Value);
            });

            Parallel.ForEach(s_Mounter.GetResources(), p_Pair =>
            {
                Print(p_Options, s_Resources, "resource", p_Pair.Key, p_Pair.Value);
            });

            Parallel.ForEach(s_Mounter.GetPartitions(), p_Pair =>
            {
                Print(p_Options, s_Resources, "partition", p_Pair.Key, p_Pair.Value);
            });

            // If we're sorting, now it's time to sort and print all the things.
            if (p_Options.Sort)
            {
                var s_SortedPaths = s_Resources.Keys.ToList();
                s_SortedPaths.Sort();

                foreach (var s_Path in s_SortedPaths)
                    Console.WriteLine(s_Path);
            }
        }

        private static void Print<T>(Options p_Options, ConcurrentDictionary<string, bool> p_Files, string p_Type, string p_Path, IMountedObject<T> p_Object) where T : IObjectVariant
        {
            var s_Path = p_Path + "." + p_Type;

            IEnumerable<T> s_Variants = p_Options.Unique 
                ? new[] { p_Object.FirstVariant } // For unique values only keep the first variant.
                : p_Object.Variants; // For all others, enumerate all of them.

            // Process the relevant variants.
            foreach (var s_Variant in s_Variants)
            {
                var s_VariantPath = "/" + s_Path;

                // If we're not listing uniquely add a prefix.
                if (!p_Options.Unique)
                {
                    var s_Prefix = $"[{s_Variant.GetContainedSuperbundle()}";

                    if (s_Variant.GetContainedBundle() != null)
                        s_Prefix += ":" + s_Variant.GetContainedBundle();

                    s_Prefix += "]";

                    s_VariantPath = s_Prefix + s_VariantPath;
                }

                // If we're sorting then add to the dictionary; otherwise print.
                if (p_Options.Sort)
                    p_Files.AddOrUpdate(s_VariantPath, true, (_1, _2) => true);
                else
                    Console.WriteLine(s_VariantPath);
            }
        }
    }
}
