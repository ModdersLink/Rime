using System;
using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Frostbite;
using RimeLib.Texture.Images;

namespace RimeLib.Cmd.Commands.Game
{
    /// <summary>Names the mounted textures whose header streams from a chunk, with their description.</summary>
    [CommandDescription("Lists the mounted textures streaming from the given chunks, with their size, format and mip levels.")]
    public class FindTextureChunkCommand : Command
    {
        [CommandArgument(Description = "Comma-separated chunk GUIDs.")]
        public string Chunks { get; set; } = "";

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_Mounter = ((GameContext)p_Context).GetMounter();
            var s_Codec = EngineInterfaceRegistry.Create<ITextureCodec>(s_Mounter.GetEngineType());
            var s_Wanted = Chunks.Split(',', StringSplitOptions.RemoveEmptyEntries).Select(p_C => Guid.Parse(p_C.Trim())).ToHashSet();
            var s_Found = 0;
            foreach (var (s_Name, s_Resource) in MountedTextures.All(s_Mounter))
            {
                TextureImage s_Image;
                try
                {
                    s_Image = s_Codec.Decode(s_Name, MountedTextures.Read(s_Resource.FirstVariant), []);
                }
                catch (Exception s_Ex) when (s_Ex is InvalidDataException or NotSupportedException or ArgumentException)
                {
                    continue;
                }

                if (!s_Wanted.Contains(Guid.Parse(s_Image.ChunkId.ToString())))
                    continue;

                ++s_Found;
                p_Writer.WriteLine($"{s_Name}: {s_Image.Kind} {s_Image.Format} {s_Image.Width}x{s_Image.Height}x{s_Image.Depth}, {s_Image.MipCount} mip(s) from {s_Image.MipBaseIndex}, chunk {s_Image.ChunkId}");
            }

            p_Writer.WriteLine($"{s_Found} texture(s).");
            return true;
        }
    }
}
