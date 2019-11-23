using System.IO;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Frostbite.Core;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    [CommandDescription("Adds a new chunk to this bundle or replaces an existing one.")]
    public class AddChunkCommand : Command
    {
        [CommandArgument(Description = "The GUID of the chunk.")]
        public GUID? Guid { get; set; }

        [CommandArgument(Description = "The path to the file containing the chunk data.")]
        public FileInfo? FilePath { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (!FilePath!.Exists)
            {
                p_Writer.WriteLine("The specified file could not be found.");
                return false;
            }

            ((BundleBuildingContext) p_Context).AddChunk(Guid!, FilePath);

            return true;
        }
    }
}
