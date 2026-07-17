using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content;
using RimeLib.Content.Frostbite;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    [CommandDescription("MIP-CAPS a catalog-backed texture for a dead-payload clone delivery: ships the " +
        "retail 128-byte DxTexture header with TextureFlags.Streaming SET and MipmapBaseIndex raised to " +
        "<mip>, so only mips >= <mip> are resident. Pair with an add_cas_chunk TAIL-RANGE of the SAME " +
        "chunk computed at the matching zlib-segment boundary (rangeStart/logicalOffset at mip's offset, " +
        "chunkMeta.firstMip == <mip> — the verified retail invariant header.mipBase == firstMip). RAM " +
        "cost drops from the full/ranged resident payload to the tiny mip tail; the capped mips would " +
        "stream on demand but never do for content that is never drawn (dead foreign map art). The " +
        "generated header is cas-bundle idata (MVDB texture-bind BLACK-body law) — acceptable ONLY for " +
        "content that never renders.")]
    internal class CapTextureCommand : Command
    {
        [CommandArgument(Description = "The exact resource/asset name, e.g. levels/mp_007/textures/mp_007_asphalt01_d.")]
        public string? Name { get; set; }

        [CommandArgument(Description = "The new MipmapBaseIndex (first RESIDENT mip; must match the paired chunk's firstMip/logicalOffset).")]
        public string? Mip { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_Ctx = p_Context as BundleBuildingContext;
            if (s_Ctx == null || string.IsNullOrWhiteSpace(Name) || !int.TryParse(Mip, out var s_Mip) || s_Mip < 1 || s_Mip > 14)
            {
                p_Writer.WriteLine("usage (bundle ctx): cap_texture <name> <mip 1-14>");
                return false;
            }

            var s_SbCtx = (SbBuildingContext)s_Ctx.Parent!;
            var s_BaseCtx = (BaseContext)s_SbCtx.Parent!;
            var s_Mounter = s_BaseCtx.GetMounters().Values.FirstOrDefault() as RimeLib.Content.Frostbite2_0.Mounting.EngineMounter;
            if (s_Mounter == null)
            {
                p_Writer.WriteLine("cap_texture: no Frostbite2_0 mounter.");
                return false;
            }

            if (!s_Mounter.TryGetResource(Name!, out var s_Res))
            {
                p_Writer.WriteLine($"cap_texture: resource not found: {Name}");
                return false;
            }

            byte[] s_Header;
            using (var s_R = s_Res.FirstVariant.GetReader())
            {
                if (s_R.Length < 128)
                {
                    p_Writer.WriteLine($"cap_texture: {Name} is not a 128-byte DxTexture header ({s_R.Length}).");
                    return false;
                }
                s_Header = s_R.ReadBytes(128);
            }

            var s_MipCount = s_Header[26];
            if (s_Mip >= s_MipCount)
            {
                p_Writer.WriteLine($"cap_texture: {Name} has {s_MipCount} mips, cannot cap at {s_Mip}.");
                return false;
            }

            // flags u32 @12 |= Streaming(0x1); mipBase byte @27 = target (retail streaming shape).
            var s_Flags = System.BitConverter.ToUInt32(s_Header, 12);
            var s_NewFlags = s_Flags | 0x1u;
            System.BitConverter.GetBytes(s_NewFlags).CopyTo(s_Header, 12);
            var s_OldBase = s_Header[27];
            s_Header[27] = (byte)s_Mip;

            try { s_Ctx.RemoveResource(Name!); } catch { }
            s_Ctx.AddGeneratedResource(Name!, s_Header, ResourceType.DxTexture, new byte[16]);
            p_Writer.WriteLine($"cap_texture {Name}: flags 0x{s_Flags:X}->0x{s_NewFlags:X}, mipBase {s_OldBase}->{s_Mip} (of {s_MipCount}).");
            return true;
        }
    }
}
