using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content;
using RimeLib.Content.Frostbite;
using RimeLib.Texture;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    [CommandDescription("Delivers a STREAMING game texture fully-resident with its ORIGINAL bytes: takes the mounted 128-byte DxTexture header, clears TextureFlags.Streaming and MipmapBaseIndex (all mips resident), keeps format/group/nameHash intact, and adds the texture's COMPLETE cas chunk as a FULL-RANGE catalog SHA1 reference (0 shipped bytes, byte-exact DICE data). Replaces any resolve-pulled partial resource/ranged chunk of the same name. This supersedes add_dds regeneration for MVDB-bound textures (regen rendered vehicles BLACK). Only works for catalog-backed (base-game cas) textures.")]
    internal class DestreamTextureCommand : Command
    {
        [CommandArgument(Description = "The exact resource/asset name, e.g. vehicles/m1a2/m1a2_d.")]
        public string? Name { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_Ctx = p_Context as BundleBuildingContext;
            if (s_Ctx == null || string.IsNullOrWhiteSpace(Name))
            {
                p_Writer.WriteLine("usage (bundle ctx): destream_texture <name>");
                return false;
            }

            var s_SbCtx = (SbBuildingContext)s_Ctx.Parent!;
            var s_BaseCtx = (BaseContext)s_SbCtx.Parent!;
            var s_Mounter = s_BaseCtx.GetMounters().Values.FirstOrDefault() as RimeLib.Content.Frostbite2_0.Mounting.EngineMounter;
            if (s_Mounter == null)
            {
                p_Writer.WriteLine("destream_texture: no Frostbite2_0 mounter.");
                return false;
            }

            if (!s_Mounter.TryGetResource(Name!, out var s_Res))
            {
                p_Writer.WriteLine($"destream_texture: resource not found: {Name}");
                return false;
            }

            byte[] s_Header;
            using (var s_R = s_Res.FirstVariant.GetReader())
            {
                if (s_R.Length < 128)
                {
                    p_Writer.WriteLine($"destream_texture: {Name} is not a 128-byte DxTexture header ({s_R.Length}).");
                    return false;
                }
                s_Header = s_R.ReadBytes(128);
            }

            // patch: flags u32 @12 &= ~Streaming(0x1); mipBase byte @27 = 0. Everything else original.
            var s_Flags = System.BitConverter.ToUInt32(s_Header, 12);
            var s_NewFlags = s_Flags & ~0x1u;
            System.BitConverter.GetBytes(s_NewFlags).CopyTo(s_Header, 12);
            var s_MipBase = s_Header[27];
            s_Header[27] = 0;

            // resolve the chunk id via the engine converter (correct guid byte order)
            var s_Converter = EngineInterfaceRegistry.Create<ITextureConverter>(s_SbCtx.EngineType);
            var s_Probe = new BundleBuildingContext.ResourceMemoryReader(s_Header, ResourceType.DxTexture, Name!);
            var s_ChunkId = s_Converter.GetTextureChunkId(s_Probe);
            if (s_ChunkId == RimeLib.Frostbite.Core.GUID.Empty)
            {
                p_Writer.WriteLine($"destream_texture: {Name} has no streaming chunk id.");
                return false;
            }

            if (!s_Mounter.TryGetFullRangeCasChunkVariant(s_ChunkId, out var s_Full))
            {
                p_Writer.WriteLine($"destream_texture: {Name} chunk {s_ChunkId} has NO catalog-backed variant (DLC/noncas?) — fall back to add_dds for this one.");
                return false;
            }

            // replace whatever resolve pulled (partial ranged chunk / streaming resource)
            try { s_Ctx.RemoveResource(Name!); } catch { }
            try { s_Ctx.RemoveChunk(s_ChunkId); } catch { }

            s_Ctx.AddGeneratedResource(Name!, s_Header, ResourceType.DxTexture, new byte[16]);
            s_Ctx.AddChunk(s_ChunkId, s_Full);

            p_Writer.WriteLine($"destreamed {Name}: flags 0x{s_Flags:X}->0x{s_NewFlags:X}, mipBase {s_MipBase}->0, chunk {s_ChunkId} full-range catalog ref.");
            return true;
        }
    }
}
