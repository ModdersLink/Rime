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

            public bool Registry { get; set; } = true;
            public bool MeshVariationDb { get; set; } = true;
            public MaterialGridRecipe? MaterialGrid { get; set; }
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
            var s_Shared = new List<string>();
            foreach (var s_Superbundle in s_Recipe.SharedSuperbundles)
                s_Shared.AddRange(s_Mounter.GetBundlesInSuperbundle(s_Superbundle));

            ExecutionContext s_Context = s_Base;
            bool Run(string p_Command)
            {
                p_Writer.WriteLine($"build_level> {p_Command}");
                if (s_Context.ProcessCommand(p_Command, p_Writer, out var s_Next) && s_Next != null)
                {
                    s_Context = s_Next;
                    return true;
                }

                s_Context = s_Next ?? s_Context;
                return false;
            }

            if (!Run($"build_sb {Quote(s_Recipe.Superbundle)} {s_Recipe.Engine} {Quote(s_Recipe.Output)} {s_Recipe.Cas}"))
                return false;

            foreach (var s_Bundle in s_Recipe.Bundles)
            {
                var s_Steps = new List<string> { $"build_bundle {Quote(s_Bundle.Name)}" };
                s_Steps.AddRange(s_Shared.Concat(s_Bundle.DependsOn).Distinct(StringComparer.OrdinalIgnoreCase).Select(p_B => $"add_dependency_bundle {Quote(p_B)}"));
                s_Steps.AddRange(new[] { s_Bundle.Level }.Concat(s_Bundle.Roots).Select(p_R => $"reference_existing_partition {Quote(p_R)} {s_Recipe.Game}"));
                if (s_Bundle.MeshVariationDb)
                    s_Steps.Add($"build_mesh_variation_db {Quote(s_Bundle.Level)} {s_Recipe.Game}");
                if (s_Bundle.ShaderDatabase != null)
                    s_Steps.Add($"add_shader_textures {Quote(s_Bundle.ShaderDatabase)} {Quote(s_Bundle.Level)} {s_Recipe.Game}");
                if (s_Bundle.Registry)
                    s_Steps.Add($"derive_registry_container {Quote(s_Bundle.Level)} {s_Recipe.Game}");
                if (s_Bundle.MaterialGrid != null)
                    s_Steps.Add($"build_material_grid {Quote(s_Bundle.MaterialGrid.Partition)} {Quote(s_Bundle.MaterialGrid.Materials)} {s_Recipe.Game}");

                foreach (var s_Step in s_Steps)
                {
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

            return Run("build");
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
