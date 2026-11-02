using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Serialization;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("Derives the global material indices a level uses (its EBX, Havok physics data and terrain, sub-worlds included) and compares them with the materials its grid has rows for.")]
    public class DeriveMaterialsCommand : Command
    {
        [CommandArgument(Description = "The level partition, e.g. levels/mp_subway/mp_subway.")]
        public string? Partition { get; set; }

        [CommandArgument(Description = "The grid to compare with, e.g. levels/mp_subway/mp_subway/materialgrid_win32/grid (BF3) or levels/mp/mp_siege/mp_siege/materialgrid_win32 (BF4).", Optional = true)]
        public string? Grid { get; set; }

        [CommandArgument(Description = "Where to write the JSON report: every material and where it was found.", Optional = true)]
        public FileInfo? Destination { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (string.IsNullOrWhiteSpace(Partition))
            {
                p_Writer.WriteLine("usage: derive_materials <level partition> [grid partition] [destination.json]");
                return false;
            }

            var s_Mounter = ((GameContext)p_Context).GetMounter();
            var s_Collector = new MaterialCollector(s_Mounter);
            var s_Result = s_Collector.Collect(Partition);

            p_Writer.WriteLine($"{s_Result.Roots.Count} level partition(s): {string.Join(", ", s_Result.Roots)}");
            p_Writer.WriteLine($"{s_Result.Bundles.Count} bundle(s) the content names, taken whole");
            if (!s_Collector.ReadsHavok)
                p_Writer.WriteLine("Havok physics data is not read for this engine; its materials are missing.");
            if (!s_Collector.ReadsTerrain)
                p_Writer.WriteLine("Terrain is not read for this engine; its materials are missing.");
            foreach (var s_Problem in s_Result.Problems)
                p_Writer.WriteLine($"  problem: {s_Problem}");

            foreach (var s_Kind in new[] { "ebx", "havok", "terrain" })
                p_Writer.WriteLine($"  {s_Kind,-8} {s_Result.Materials.Count(p_M => p_M.Value.Any(p_S => p_S.StartsWith(s_Kind + ":"))),4} material(s)");
            p_Writer.WriteLine($"derived: {s_Result.Materials.Count} material(s)");

            string Label(uint p_Material) => s_Collector.MaterialName(p_Material) is { } s_Name ? $"{p_Material} {s_Name}" : p_Material.ToString();

            int? s_Missing = null;
            if (!string.IsNullOrWhiteSpace(Grid))
            {
                var s_Grid = s_Collector.Parse(Grid.ToLowerInvariant());
                if (s_Grid == null)
                {
                    p_Writer.WriteLine($"No grid partition named '{Grid}'.");
                    return false;
                }

                var s_Rules = EngineInterfaceRegistry.Create<IMaterialGridRules>(s_Mounter.GetEngineType());
                var s_Rows = s_Rules.GetMaterials(s_Grid).ToHashSet();
                var s_Missed = s_Rows.Where(p_M => !s_Result.Materials.ContainsKey(p_M)).OrderBy(p_M => p_M).ToList();
                var s_Extra = s_Result.Materials.Keys.Where(p_M => !s_Rows.Contains(p_M)).ToList();
                s_Missing = s_Missed.Count;

                p_Writer.WriteLine($"grid: {s_Rows.Count} material(s) with rows; derived {s_Rows.Count - s_Missed.Count} of them, {s_Missed.Count} missing, {s_Extra.Count} extra");
                foreach (var s_Material in s_Missed)
                    p_Writer.WriteLine($"  MISSING {Label(s_Material)}");
                foreach (var s_Material in s_Extra)
                    p_Writer.WriteLine($"  EXTRA {Label(s_Material)} ({string.Join(", ", s_Result.Materials[s_Material].Take(3))})");
            }

            if (Destination != null)
            {
                File.WriteAllText(Destination.FullName, JsonConvert.SerializeObject(new
                {
                    roots = s_Result.Roots,
                    problems = s_Result.Problems,
                    materials = s_Result.Materials.Select(p_M => new { index = p_M.Key, name = s_Collector.MaterialName(p_M.Key), sources = p_M.Value }),
                }, Formatting.Indented));
                p_Writer.WriteLine($"Report written to {Destination.FullName}.");
            }

            return s_Missing is null or 0;
        }
    }
}
