using System;
using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    [CommandDescription("Converts a partition of a game of another engine and its closure to this bundle's engine and adds them, leaving references to what the closure skips null.")]
    internal class ReferenceConvertedPartitionCommand : Command
    {
        [CommandArgument(Description = "The partition to convert, or comma-separated partitions, e.g. a level and its mesh variation database.")]
        public string? Name { get; set; }

        [CommandArgument(Description = "Id returned by mount_game, of the game to convert from.")]
        public int Id { get; set; }

        [CommandArgument(Description = "Comma-separated partition name prefixes to leave out of the closure, e.g. 'characters/,ui/'; one marked '+' ships the target game's partitions of the same name and GUID instead.", Optional = true)]
        public string? SkipPrefixes { get; set; }

        [CommandArgument(Description = "Names to move, as 'from=to': each partition name, and string naming one, starting with from is put under to, e.g. 'levels/mp/mp_prison/=Levels/MP_Prison/'.", Optional = true)]
        public string? MoveNames { get; set; }

        [CommandArgument(Description = "How many entries to list per kind of loss.", Optional = true)]
        public int Top { get; set; } = 10;

        [CommandArgument(Description = "A directory to write each converted partition to as JSON, by its name.", Optional = true)]
        public DirectoryInfo? Dump { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_Prefixes = string.IsNullOrWhiteSpace(SkipPrefixes)
                ? Array.Empty<string>()
                : SkipPrefixes!.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

            (string, string)? s_Move = null;
            if (!string.IsNullOrWhiteSpace(MoveNames))
            {
                var s_Parts = MoveNames!.Split('=', 2);
                if (s_Parts.Length != 2 || s_Parts[0].Length == 0)
                {
                    p_Writer.WriteLine($"'{MoveNames}' is not 'from=to'.");
                    return false;
                }

                s_Move = (s_Parts[0], s_Parts[1]);
            }

            if (ConvertedClosure.Create((BundleBuildingContext)p_Context, Id, s_Prefixes, s_Move, p_Writer) is not { } s_Closure)
                return false;

            s_Closure.Dump = Dump;
            var s_Result = s_Closure.Add(Name!.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries), p_Writer);
            s_Closure.Report.WriteTo(p_Writer, Top);

            p_Writer.WriteLine($"Converted closure of '{Name}': {s_Result.Partitions} partition(s), {s_Result.Skipped} skipped by prefix, {s_Result.ConvertedResources} of {s_Result.Resources} resource(s) converted, {s_Result.Chunks} chunk(s) the partitions name not converted yet.");
            foreach (var s_Line in s_Result.Unresolved)
                p_Writer.WriteLine($"  {s_Line}");

            if (((SbBuildingContext)p_Context.Parent!).ConvertedMaterials is { } s_Materials)
            {
                p_Writer.WriteLine($"Materials so far: {s_Materials.Materials.Count} mapped, {s_Materials.Unnamed.Count} unnamed (to the default)");
                foreach (var (s_From, s_To) in s_Materials.Materials.OrderBy(p_M => p_M.Key))
                    p_Writer.WriteLine($"  MAT {s_From} -> {s_To}{(s_Materials.Unnamed.Contains(s_From) ? " (unnamed)" : "")}");
            }

            return true;
        }
    }
}
