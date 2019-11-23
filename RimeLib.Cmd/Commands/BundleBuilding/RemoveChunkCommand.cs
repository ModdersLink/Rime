using System.IO;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Frostbite.Core;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    [CommandDescription("Removes the specified chunk from the bundle.")]
    public class RemoveChunkCommand : Command
    {
        [CommandArgument(Description = "The GUID of the chunk.")]
        public GUID? Guid { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            ((BundleBuildingContext) p_Context).RemoveChunk(Guid!);
            return true;
        }
    }
}
