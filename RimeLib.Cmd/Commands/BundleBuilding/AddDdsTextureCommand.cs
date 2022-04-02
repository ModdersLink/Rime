using System.IO;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    [CommandDescription("Generates a new texture resource and chunks from a DDS texture and adds it to this bundle.")]
    public class AddDdsTextureCommand : Command
    {
        [CommandArgument(Description = "The name of the resource asset to create.")]
        public string? AssetName { get; set; }
        
        [CommandArgument(Description = "The path to the DDS texture.")]
        public FileInfo? FilePath { get; set; }

        [CommandArgument(Description = "The name of the texture group this texture belongs in. Defaults to 'Default'.", Optional = true)]
        public string? TextureGroup { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (!FilePath!.Exists)
            {
                p_Writer.WriteLine("The specified file could not be found.");
                return false;
            }

            ((BundleBuildingContext) p_Context).AddDDSTexture(FilePath, AssetName!, TextureGroup ?? "Default");

            return true;
        }
    }
}
