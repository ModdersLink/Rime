using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Frostbite;
using RimeLib.Shader;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    /// <summary>
    /// Builds a level's shader database from the mounted ones. It holds the shaders the bundle's
    /// content draws with and those of the bundles built before it (see collect_drawn_shaders), the
    /// engine's own, and the shaders named after one of the bundle's partitions (the terrain's
    /// permutations and default surface shader). Each shader is copied with its solutions, and the
    /// ones this bundle is first to need are added to it as partitions.
    /// </summary>
    [CommandDescription("Builds the bundle's shader database from the mounted ones, for the shaders its content uses plus the engine's and terrain's.")]
    public class BuildShaderDatabaseCommand : Command
    {
        [CommandArgument(Description = "The shader database resource, e.g. levels/mp_subway/mp_subway/shaderdb.")]
        public string? Name { get; set; }

        [CommandArgument(Description = "Give each shader the solutions of every database that has it, not just the first; covers more vertex layouts.", Optional = true)]
        public bool AllSolutions { get; set; }

        [CommandArgument(Description = "The id of the mounted game.", Optional = true)]
        public int Id { get; set; } = 1;

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_BundleContext = (BundleBuildingContext)p_Context;
            var s_SbContext = (SbBuildingContext)s_BundleContext.Parent!;
            var s_BaseContext = (BaseContext)s_SbContext.Parent!;
            if (!s_BaseContext.GetMounters().TryGetValue(Id, out var s_Mounter) || s_Mounter.GetEngineType() != s_SbContext.EngineType)
            {
                p_Writer.WriteLine($"Id ({Id}) is not a mounted game of this engine.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(Name))
            {
                p_Writer.WriteLine("usage: build_shader_database <name> [all_solutions] [id]");
                return false;
            }

            var s_Name = Name.ToLowerInvariant();
            var s_Index = ShaderDatabaseIndex.Get(s_Mounter);
            var s_Builder = s_Index.Builder;
            if (s_Index.Databases.Count == 0)
            {
                p_Writer.WriteLine("No shader databases are mounted.");
                return false;
            }

            // The database of the same name first, so a rebuilt retail level gets its own solutions.
            var s_Sources = s_Index.Databases.OrderBy(p_D => p_D.Name == s_Name ? 0 : 1).ToList();
            var s_KeySets = s_Sources.Select(p_S => p_S.Keys).ToList();

            var s_Partitions = s_BundleContext.GetPartitions().Keys.Select(p_N => p_N.ToLowerInvariant()).ToHashSet();
            var s_Used = DrawnShaders.Of(s_BundleContext, s_Mounter, s_Index.IsShader);
            var s_Others = s_SbContext.DrawnShaders.Where(p_N => !s_Used.Contains(p_N)).ToHashSet();
            s_Used.UnionWith(s_Others);

            // Generated shaders: the terrain's permutations and default surface shader, named after it.
            var s_Generated = s_Index.Names.Values.Where(p_N => !s_Used.Contains(p_N) && NamedAfter(p_N, s_Partitions)).ToHashSet();

            // The engine's own shaders: what nearly every database holds (for a level with terrain,
            // nearly every database with terrain shaders) and no partition imports.
            var s_Defaults = Names(Common(s_KeySets, s_Index.AllKeys)).Where(p_N => !s_Index.Imported.Contains(p_N)).ToHashSet();
            if (s_Generated.Any(p_N => p_N.Contains("__")))
            {
                // The terrain system's own: what no database without terrain shaders holds. Terrain decals
                // import some of them, so here an import doesn't make a shader content's.
                var s_WithTerrain = s_KeySets.Where(p_S => p_S.Any(p_K => s_Index.Names.TryGetValue(p_K, out var s_N) && s_N.Contains("__"))).ToList();
                var s_NoTerrain = s_KeySets.Except(s_WithTerrain).ToList();
                s_Defaults.UnionWith(Names(Common(s_WithTerrain, s_Index.AllKeys).Where(p_K => !s_NoTerrain.Any(p_S => p_S.Contains(p_K)))));
            }

            IEnumerable<string> Names(IEnumerable<uint> p_Keys) => p_Keys.Where(s_Index.Names.ContainsKey).Select(p_K => s_Index.Names[p_K]);
            var s_DefaultNames = s_Defaults.Where(p_N => !s_Used.Contains(p_N) && !s_Generated.Contains(p_N)).ToHashSet();

            var s_Shaders = s_Used.Concat(s_DefaultNames).Concat(s_Generated).OrderBy(p_N => p_N, StringComparer.Ordinal).ToList();
            p_Writer.WriteLine($"{s_Shaders.Count} shader(s): {s_Used.Count - s_Others.Count} the bundle's content draws with, {s_Others.Count} other bundles' content draws with, " +
                $"{s_DefaultNames.Count} the engine's, {s_Generated.Count} named after a bundle partition.");

            var s_Data = s_Builder.Build(s_Sources.Select(p_S => p_S.Load), s_Shaders, AllSolutions, p_Writer, out var s_Missing);
            foreach (var s_Shader in s_Missing)
                p_Writer.WriteLine($"  NO SOURCE {s_Shader}");

            // The resource meta of a mounted shader database, the same name's preferred.
            byte[]? s_Meta = null;
            foreach (var s_Source in s_Sources)
            {
                if (s_Mounter.TryGetResource(s_Source.Name, out var s_Resource) && s_Resource.FirstVariant.TryGetMeta(out s_Meta))
                    break;
            }

            s_BundleContext.RemoveResource(s_Name);
            s_BundleContext.AddGeneratedResource(s_Name, s_Data, ResourceType.IShaderDatabase, s_Meta);

            // The database names its shaders, so they ship with it; other bundles' shaders ship with
            // those, unless the engine keeps every shader with the database.
            var s_ToAdd = s_Shaders.Except(s_Missing).Except(s_Builder.ShipsEveryShader ? Enumerable.Empty<string>() : s_Others)
                .Where(p_N => !s_Partitions.Contains(p_N)).ToList();
            if (PartitionClosure.Create((BundleBuildingContext)p_Context, Id, [], TextWriter.Null) is not { } s_Adder)
            {
                p_Writer.WriteLine($"No game {Id} of this bundle's engine is mounted to add their closure from.");
                return false;
            }

            s_Adder.AddAll(s_ToAdd, p_Writer);

            p_Writer.WriteLine($"Built '{s_Name}' ({s_Data.Length} bytes); added {s_ToAdd.Count} shader partition(s) it names, with their closure.");

            if (s_Sources[0].Name == s_Name)
            {
                p_Writer.WriteLine($"Against the game's '{s_Name}':");
                s_Builder.Compare(s_Data, s_Sources[0].Load(), s_Index.Names, p_Writer);
            }

            return true;
        }

        /// <summary>The keys nearly all of the databases hold (one in twenty may lack them).</summary>
        private static HashSet<uint> Common(List<ISet<uint>> p_Databases, IEnumerable<uint> p_Keys) =>
            p_Keys.Where(p_K => p_Databases.Count(p_D => p_D.Contains(p_K)) * 20 >= p_Databases.Count * 19).ToHashSet();

        /// <summary>Whether a name extends a partition's name, as generated shaders' names do.</summary>
        private static bool NamedAfter(string p_Name, HashSet<string> p_Partitions)
        {
            for (var i = p_Name.IndexOf('/'); i > 0; i = p_Name.IndexOf('/', i + 1))
            {
                if (p_Partitions.Contains(p_Name[..i]))
                    return true;
            }

            for (var i = p_Name.IndexOf("__", StringComparison.Ordinal); i > 0; i = p_Name.IndexOf("__", i + 2, StringComparison.Ordinal))
            {
                if (p_Partitions.Contains(p_Name[..i]))
                    return true;
            }

            return false;
        }
    }
}
