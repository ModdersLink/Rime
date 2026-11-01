using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Commands.Game;
using RimeLib.Cmd.Contexts;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using RimeLib.Serialization;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    /// <summary>
    /// Builds a level's material grid from the game's grids: rows for the materials of the given
    /// grids (or of every grid), relations from every grid in the game. Every retail grid is a
    /// consistent piece of one global grid, so the rows and relations copied are the ones the game
    /// uses everywhere. Lists the partitions the relations reference, which have to ship too.
    /// </summary>
    [CommandDescription("Builds a material grid partition from the mounted game's grids, for the materials of the given grids or of all of them.")]
    public class BuildMaterialGridCommand : Command
    {
        [CommandArgument(Description = "The grid partition to build, e.g. levels/mp_subway/mp_subway/materialgrid_win32/grid (BF3) or levels/mp/mp_siege/mp_siege/materialgrid_win32 (BF4).")]
        public string? Partition { get; set; }

        [CommandArgument(Description = "Whose materials the grid gets rows for: 'all', or comma-separated grid partition names.")]
        public string? Materials { get; set; }

        [CommandArgument(Description = "The id of the mounted game.", Optional = true)]
        public int Id { get; set; } = 1;

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (string.IsNullOrWhiteSpace(Partition) || string.IsNullOrWhiteSpace(Materials))
            {
                p_Writer.WriteLine("usage: build_material_grid <name> <all|grid,grid,...> [id]");
                return false;
            }

            var s_BundleContext = (BundleBuildingContext)p_Context;
            var s_SbContext = (SbBuildingContext)s_BundleContext.Parent!;
            var s_BaseContext = (BaseContext)s_SbContext.Parent!;
            if (!s_BaseContext.GetMounters().TryGetValue(Id, out var s_Mounter) || s_Mounter.GetEngineType() != s_SbContext.EngineType)
            {
                p_Writer.WriteLine($"Id ({Id}) is not a mounted game of this engine.");
                return false;
            }

            var s_Name = Partition!.ToLowerInvariant();
            var s_Rules = EngineInterfaceRegistry.Create<IMaterialGridRules>(s_SbContext.EngineType);
            var s_Converter = EngineInterfaceRegistry.Create<IPartitionConverter>(s_SbContext.EngineType);
            var s_Partitions = BundlePartitionVariant.All(s_BundleContext);

            DatabasePartitionBase? Parse(string p_Name)
            {
                try
                {
                    if (s_Partitions.TryGetValue(p_Name, out var s_Own))
                        return s_Converter.FromPartitionObject(p_Name, s_Own);
                    return s_Mounter.TryGetPartition(p_Name, out var s_Mounted) ? s_Converter.FromPartitionObject(p_Name, s_Mounted.FirstVariant) : null;
                }
                catch (Exception)
                {
                    return null;
                }
            }

            // Every grid in the game.
            var s_Grids = s_Mounter.GetPartitions().Keys.Select(p_N => p_N.ToLowerInvariant())
                .Where(p_N => p_N.Contains("materialgrid")).Distinct()
                .Select(p_N => (Name: p_N, Grid: Parse(p_N))).Where(p_G => p_G.Grid != null && s_Rules.GetMaterials(p_G.Grid!).Count > 0).ToList();
            if (s_Grids.Count == 0)
            {
                p_Writer.WriteLine("No material grids in the mounted game.");
                return false;
            }

            ISet<uint>? s_Materials = null;
            if (!string.Equals(Materials, "all", StringComparison.OrdinalIgnoreCase))
            {
                s_Materials = new HashSet<uint>();
                foreach (var s_Source in Materials!.Split(',').Select(p_S => p_S.Trim().ToLowerInvariant()))
                {
                    if (Parse(s_Source) is not { } s_Grid)
                    {
                        p_Writer.WriteLine($"No grid named '{s_Source}'.");
                        return false;
                    }
                    s_Materials.UnionWith(s_Rules.GetMaterials(s_Grid));
                }
            }

            // The bundle's own grid, or the game's of that name, keeps its guids; otherwise another
            // grid serves as template under a new partition guid.
            var s_Target = Parse(s_Name);
            if (s_Target == null)
            {
                s_Target = Parse(s_Grids[0].Name)!;
                s_Target.PartitionGuid = new GUID(Guid.NewGuid());
            }
            s_Target.Name = s_Name;

            var s_Unrelated = s_Rules.Merge(s_Target, s_Grids.Select(p_G => p_G.Grid!).ToList(), s_Materials);
            var s_Rows = s_Rules.GetMaterials(s_Target).Count;

            var s_Generator = EngineInterfaceRegistry.Create<IPartitionGenerator>(s_SbContext.EngineType);
            var s_Stream = new MemoryStream();
            using (var s_Writer = new RimeWriter(s_Stream))
                s_Generator.Generate(s_Target, s_Writer);
            var s_Bytes = s_Stream.ToArray();

            var s_Reread = s_Converter.FromPartitionObject(s_Name, new BundlePartitionVariant(new SbBuildingContext.MemoryReader(s_Bytes), s_BundleContext.BundleName));
            if (s_Rules.GetMaterials(s_Reread).Count != s_Rows)
            {
                p_Writer.WriteLine($"The built grid reads back with {s_Rules.GetMaterials(s_Reread).Count} materials instead of {s_Rows}; not added.");
                return false;
            }

            s_BundleContext.RemovePartition(s_Name);
            s_BundleContext.AddRawPartitionBytes(s_Name, s_Bytes);

            // What the relations reference outside the grid (effects, sounds, decals) has to ship.
            var s_External = s_Reread.Instances.Where(p_I => p_I != null)
                .SelectMany(p_I => AnalyzeRegistryCommand.References(p_I, p_I.GetType().Name, 0))
                .Select(p_R => p_R.Ref.PartitionGuid).Where(p_G => p_G != s_Reread.PartitionGuid).Distinct()
                .Select(p_G => s_Mounter.TryGetPartitionByGuid(p_G, out var s_N, out _) ? s_N.ToLowerInvariant() : p_G.ToString()).OrderBy(p_N => p_N).ToList();
            foreach (var s_Reference in s_External)
                p_Writer.WriteLine($"GRID-REF: {s_Reference}");

            // Against the game's grid of that name, when there is one.
            if (s_Mounter.TryGetPartition(s_Name, out var s_Retail))
            {
                var s_Shipped = s_Rules.Describe(s_Converter.FromPartitionObject(s_Name, s_Retail.FirstVariant));
                var s_Built = s_Rules.Describe(s_Reread);
                var s_Same = s_Shipped.Count(p_P => s_Built.TryGetValue(p_P.Key, out var s_Text) && s_Text == p_P.Value);
                p_Writer.WriteLine($"The game's '{s_Name}': {s_Shipped.Count} relations and properties, {s_Same} the same in the built grid, {s_Built.Count - s_Built.Keys.Count(s_Shipped.ContainsKey)} only in the built one.");
            }

            p_Writer.WriteLine($"Built '{s_Name}' from {s_Grids.Count} grids: {s_Rows} materials, {s_Unrelated} material pairs no grid relates (given the default material's relation), {s_External.Count} partitions referenced, {s_Bytes.Length} bytes.");
            return true;
        }
    }
}
