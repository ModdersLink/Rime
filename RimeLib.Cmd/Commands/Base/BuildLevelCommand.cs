using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Frostbite;

namespace RimeLib.Cmd.Commands.Base
{
    /// <summary>
    /// Builds a superbundle from a level recipe: per bundle, the level partition and the other
    /// roots with their closure (minus what the bundles loaded with it carry), the mesh variation
    /// database and the registry derived from that content, and optionally a material grid. Each
    /// step is the bundle-building command of the same name, run in order. A bundle that has a
    /// namesake in the mounted game is compared with it.
    /// </summary>
    [CommandDescription("Builds a superbundle from a level recipe (.json), deriving each bundle's registry and mesh variation database from its content.")]
    public class BuildLevelCommand : Command
    {
        [CommandArgument(Description = "The recipe .json.")]
        public FileInfo? Recipe { get; set; }

        public class LevelRecipe
        {
            /// <summary>The id of the mounted game the content comes from (mount it with automount).</summary>
            public int Game { get; set; } = 1;
            public EngineType Engine { get; set; }
            public string Superbundle { get; set; } = "";
            public string Output { get; set; } = "";
            public bool Cas { get; set; }

            /// <summary>Superbundles whose bundles are loaded with every bundle of the level.</summary>
            public List<string> SharedSuperbundles { get; set; } = new();

            /// <summary>Single bundles loaded with every bundle of the level, from superbundles that are not loaded whole.</summary>
            public List<string> SharedBundles { get; set; } = new();

            /// <summary>
            /// Superbundles whose bundles are loaded with every bundle of the level but are not
            /// self-contained: the level ships what their content references (BF4's soldier and
            /// vehicle bundles leave their effects to the levels).
            /// </summary>
            public List<string> WalkedSuperbundles { get; set; } = new();
            public List<BundleRecipe> Bundles { get; set; } = new();
        }

        public class BundleRecipe
        {
            public string Name { get; set; } = "";

            /// <summary>The bundle's LevelData or SubWorldData partition.</summary>
            public string Level { get; set; } = "";

            /// <summary>More partitions to add with their closure.</summary>
            public List<string> Roots { get; set; } = new();

            /// <summary>Bundles loaded before this one, whose content it does not carry again.</summary>
            public List<string> DependsOn { get; set; } = new();

            /// <summary>
            /// The level's shader database (in the main bundle): the textures its shaders bind ship
            /// with the bundles whose content uses those shaders.
            /// </summary>
            public string? ShaderDatabase { get; set; }

            /// <summary>Content of the sub-worlds that this bundle carries for them.</summary>
            public HoistRecipe? Hoist { get; set; }

            /// <summary>
            /// Build <see cref="ShaderDatabase"/> into this bundle rather than use the game's. It also
            /// holds the shaders of the bundles before it in the recipe, so this bundle goes last.
            /// </summary>
            public bool BuildShaderDatabase { get; set; }

            /// <summary>Give each shader the solutions of every mounted database that has it.</summary>
            public bool AllShaderSolutions { get; set; }

            public bool Registry { get; set; } = true;
            public bool MeshVariationDb { get; set; } = true;
            public MaterialGridRecipe? MaterialGrid { get; set; }
        }

        public class HoistRecipe
        {
            /// <summary>The sub-worlds' partitions.</summary>
            public List<string> From { get; set; } = new();

            /// <summary>Primary instance type names; a trailing * matches a prefix.</summary>
            public List<string> Types { get; set; } = new();
        }

        public class MaterialGridRecipe
        {
            public string Partition { get; set; } = "";

            /// <summary>"all", or comma-separated grids whose materials the grid gets rows for.</summary>
            public string Materials { get; set; } = "all";
        }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (Recipe is not { Exists: true })
            {
                p_Writer.WriteLine("usage: build_level <recipe.json>");
                return false;
            }

            var s_Recipe = JsonConvert.DeserializeObject<LevelRecipe>(File.ReadAllText(Recipe.FullName))!;
            var s_Base = (BaseContext)p_Context;
            if (!s_Base.GetMounters().TryGetValue(s_Recipe.Game, out var s_Mounter))
            {
                p_Writer.WriteLine($"No mounted game with id {s_Recipe.Game}.");
                return false;
            }

            // The bundles of the shared superbundles are loaded with everything.
            var s_Shared = new List<string>(s_Recipe.SharedBundles);
            foreach (var s_Superbundle in s_Recipe.SharedSuperbundles)
                s_Shared.AddRange(s_Mounter.GetBundlesInSuperbundle(s_Superbundle));
            var s_Walked = s_Recipe.WalkedSuperbundles.SelectMany(s_Mounter.GetBundlesInSuperbundle).ToList();

            ExecutionContext s_Context = s_Base;
            // Time per command, summed over the bundles, for the summary at the end.
            var s_Times = new Dictionary<string, TimeSpan>(StringComparer.Ordinal);
            var s_Total = System.Diagnostics.Stopwatch.StartNew();
            bool Run(string p_Command)
            {
                p_Writer.WriteLine($"build_level> {p_Command}");
                var s_Watch = System.Diagnostics.Stopwatch.StartNew();
                var s_Done = s_Context.ProcessCommand(p_Command, p_Writer, out var s_Next) && s_Next != null;
                var s_Verb = p_Command.Split(' ')[0];
                s_Times[s_Verb] = s_Times.GetValueOrDefault(s_Verb) + s_Watch.Elapsed;

                s_Context = s_Done ? s_Next! : s_Next ?? s_Context;
                return s_Done;
            }

            void Summary()
            {
                p_Writer.WriteLine($"build_level: {s_Total.Elapsed:hh\\:mm\\:ss} in all");
                foreach (var (s_Verb, s_Time) in s_Times.OrderByDescending(p_T => p_T.Value))
                    p_Writer.WriteLine($"  {s_Time:hh\\:mm\\:ss}  {s_Verb}");
            }

            if (!Run($"build_sb {Quote(s_Recipe.Superbundle)} {s_Recipe.Engine} {Quote(s_Recipe.Output)} {s_Recipe.Cas}"))
                return false;

            foreach (var s_Bundle in s_Recipe.Bundles)
            {
                var s_Steps = new List<string> { $"build_bundle {Quote(s_Bundle.Name)}" };
                s_Steps.AddRange(s_Shared.Concat(s_Bundle.DependsOn).Distinct(StringComparer.OrdinalIgnoreCase).Select(p_B => $"add_dependency_bundle {Quote(p_B)}"));
                s_Steps.AddRange(s_Walked.Distinct(StringComparer.OrdinalIgnoreCase).Select(p_B => $"add_dependency_bundle {Quote(p_B)} true"));
                s_Steps.AddRange(new[] { s_Bundle.Level }.Concat(s_Bundle.Roots).Select(p_R => $"reference_existing_partition {Quote(p_R)} {s_Recipe.Game}"));
                if (s_Bundle.Hoist != null)
                    s_Steps.AddRange(s_Bundle.Hoist.From.Select(p_F => $"hoist_content {Quote(p_F)} {Quote(string.Join(",", s_Bundle.Hoist.Types))} {s_Recipe.Game}"));
                if (s_Bundle.MeshVariationDb)
                    s_Steps.Add($"build_mesh_variation_db {Quote(s_Bundle.Level)} {s_Recipe.Game}");
                // After the mesh variation database, whose entries say what meshes draw with.
                if (s_Bundle.BuildShaderDatabase && s_Bundle.ShaderDatabase != null)
                    s_Steps.Add($"build_shader_database {Quote(s_Bundle.ShaderDatabase)} {s_Bundle.AllShaderSolutions} {s_Recipe.Game}");
                if (s_Bundle.ShaderDatabase != null)
                    s_Steps.Add($"add_shader_textures {Quote(s_Bundle.ShaderDatabase)} {(s_Bundle.BuildShaderDatabase ? "*" : Quote(s_Bundle.Level))} {s_Recipe.Game}");
                if (s_Recipe.Bundles.Any(p_B => p_B.BuildShaderDatabase) && !s_Bundle.BuildShaderDatabase)
                    s_Steps.Add($"collect_drawn_shaders {s_Recipe.Game}");
                if (s_Bundle.Registry)
                    s_Steps.Add($"derive_registry_container {Quote(s_Bundle.Level)} {s_Recipe.Game}");
                if (s_Bundle.MaterialGrid != null)
                    s_Steps.Add($"build_material_grid {Quote(s_Bundle.MaterialGrid.Partition)} {Quote(s_Bundle.MaterialGrid.Materials)} {s_Recipe.Game}");

                foreach (var s_Step in s_Steps)
                {
                    if (s_Context is BundleBuildingContext s_Building)
                        s_Building.BindMeshVariationTextures = !s_Bundle.MeshVariationDb;

                    if (!Run(s_Step))
                    {
                        p_Writer.WriteLine($"build_level: '{s_Step}' failed; stopping.");
                        Unwind(ref s_Context, s_Base, p_Writer);
                        return false;
                    }
                }

                if (s_Context is BundleBuildingContext s_BundleContext)
                    Compare(s_BundleContext, s_Mounter, s_Bundle.Name, p_Writer);

                if (!Run("build"))
                    return false;
            }

            var s_Built = Run("build");
            Summary();
            return s_Built;
        }

        /// <summary>The built bundle against the game's bundle of that name: which partitions only one has.</summary>
        private static void Compare(BundleBuildingContext p_Bundle, Content.Mounting.IEngineMounter p_Mounter, string p_Name, TextWriter p_Writer)
        {
            var s_Shipped = p_Mounter.GetPartitionsInBundle(p_Name).Select(p_N => p_N.ToLowerInvariant()).ToHashSet();
            if (s_Shipped.Count == 0)
                return;

            var s_Built = p_Bundle.GetPartitions().Keys.Select(p_N => p_N.ToLowerInvariant()).ToHashSet();
            var s_Missing = s_Shipped.Where(p_N => !s_Built.Contains(p_N)).OrderBy(p_N => p_N).ToList();
            var s_Extra = s_Built.Where(p_N => !s_Shipped.Contains(p_N)).OrderBy(p_N => p_N).ToList();

            p_Writer.WriteLine($"build_level: {p_Name}: {s_Built.Count} partitions built, {s_Shipped.Count} shipped, {s_Shipped.Count(s_Built.Contains)} in both.");
            foreach (var s_Name in s_Missing)
                p_Writer.WriteLine($"  MISSING {s_Name}");
            foreach (var s_Name in s_Extra)
                p_Writer.WriteLine($"  EXTRA {s_Name}");
        }

        private static void Unwind(ref ExecutionContext p_Context, BaseContext p_Base, TextWriter p_Writer)
        {
            while (p_Context != p_Base && p_Context.Parent != null)
                p_Context = p_Context.Parent;
        }

        private static string Quote(string p_Value) => p_Value.Contains(' ') ? $"\"{p_Value}\"" : p_Value;
    }
}
