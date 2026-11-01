using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Frostbite.Core;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("Prints the name of the mounted partition with the given partition GUID, and the bundles holding it.")]
    public class FindPartitionByGuidCommand : Command
    {
        [CommandArgument(Description = "The partition GUID.")]
        public string? Guid { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (!System.Guid.TryParse(Guid, out _))
            {
                p_Writer.WriteLine($"'{Guid}' is not a GUID.");
                return false;
            }

            var s_Mounter = ((GameContext)p_Context).GetMounter();
            if (!s_Mounter.TryGetPartitionByGuid(new GUID(Guid!), out var s_Name, out var s_Partition))
            {
                p_Writer.WriteLine($"No mounted partition has the GUID {Guid}.");
                return false;
            }

            p_Writer.WriteLine(s_Name);
            foreach (var s_Variant in s_Partition.Variants)
                p_Writer.WriteLine($"  {s_Variant.GetContainedSuperbundle()} / {s_Variant.GetContainedBundle()}");

            return true;
        }
    }
}
