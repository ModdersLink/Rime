using System.IO;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Texture.Generation;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    [CommandDescription("Generates a new texture resource and chunks from a DDS texture and adds it to this bundle.")]
    public class AddDdsTextureCommand : Command
    {
        [CommandArgument(Description = "The name of the resource asset to create.")]
        public string? AssetName { get; set; }
        
        [CommandArgument(Description = "The path to the DDS texture.")]
        public FileInfo? FilePath { get; set; }
        
        [CommandArgument(Description = "Whether this texture should use sRGB gamma. Defaults to 'false'.", Optional = true)]
        public bool SrgbGamma { get; set; } = false;

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (!FilePath!.Exists)
            {
                p_Writer.WriteLine("The specified file could not be found.");
                return false;
            }

            var s_Attributes = new TextureAttributes()
            {
                Name = AssetName!,
                TextureGroup = "Default",
                SrgbGamma = SrgbGamma,
            };

            ((BundleBuildingContext) p_Context).AddDDSTexture(FilePath, s_Attributes);

            return true;
        }
    }
}
