using System;
using System.IO;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("Lists the mounted partitions whose primary instance has one of the given types, optionally only those in given superbundles or under given name prefixes: the query behind a level template.")]
    public class FindPartitionsCommand : Command
    {
        [CommandArgument(Description = "Comma-separated primary instance type names; a trailing * matches a prefix, e.g. SoldierWeaponUnlockAsset.")]
        public string? Types { get; set; }

        [CommandArgument(Description = "Comma-separated superbundles that carry them, e.g. win32/xp4weapons, or - for any.", Optional = true)]
        public string? Superbundles { get; set; }

        [CommandArgument(Description = "Comma-separated name prefixes, e.g. persistence/unlocks/, or - for any.", Optional = true)]
        public string? Prefixes { get; set; }

        [CommandArgument(Description = "A file to write the names to, one per line.", Optional = true)]
        public FileInfo? Destination { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (string.IsNullOrWhiteSpace(Types))
            {
                p_Writer.WriteLine("usage: find_partitions <types> [superbundles|-] [prefixes|-] [destination]");
                return false;
            }

            static string[] List(string? p_Value) => p_Value is null or "-"
                ? Array.Empty<string>()
                : p_Value.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

            var s_Found = PartitionQuery.Find(((GameContext)p_Context).GetMounter(), List(Types), List(Superbundles), List(Prefixes));
            foreach (var s_Name in s_Found)
                p_Writer.WriteLine(s_Name);
            p_Writer.WriteLine($"{s_Found.Count} partition(s).");

            if (Destination != null)
                File.WriteAllLines(Destination.FullName, s_Found);
            return true;
        }
    }
}
