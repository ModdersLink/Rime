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

        [CommandArgument(Description = "Whether the texture is streamable. Defaults to 'true'. Set 'false' for a fully-resident texture delivered self-contained in a mod bundle (else only small mips load -> pale/black).", Optional = true)]
        public bool Streaming { get; set; } = true;

        [CommandArgument(Description = "Whether this is a normal map (uses NormalDXT1/DXN formats). Defaults to 'false'.", Optional = true)]
        public bool NormalMap { get; set; } = false;

        // The engine's texture pools gate on the 16-char group at header offset 112 ("Vehicle",
        // "AtlasTextureGro", ...). A generated texture under a NEW name has no mounted original to
        // copy the group from, and "Default" is not a valid BF3 group -> the pool never uploads it
        // (black vehicles; purple/garbage emitter atlas). This argument sets it explicitly.
        [CommandArgument(Description = "TextureGroup override (16-char engine pool group, e.g. 'AtlasTextureGro'). Defaults to the mounted original's group (same-name lookup) or 'Default'.", Optional = true)]
        public string? TextureGroup { get; set; }

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
                TextureGroup = TextureGroup ?? "Default",
                SrgbGamma = SrgbGamma,
                Streaming = Streaming,
                IsNormalMap = NormalMap,
            };

            ((BundleBuildingContext) p_Context).AddDDSTexture(FilePath, s_Attributes);

            return true;
        }
    }
}
