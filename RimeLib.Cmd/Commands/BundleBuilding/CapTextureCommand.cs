using System;
using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content;
using RimeLib.Content.Frostbite;
using RimeLib.Texture;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    [CommandDescription("Mip-caps a catalog-backed texture: ships its retail header with Streaming set and MipmapBaseIndex raised to <mip>. Needs a matching tail-range chunk, and only suits art that never renders.")]
    internal class CapTextureCommand : Command
    {
        // Pair this with an add_cas_chunk tail-range of the same chunk, cut at the zlib segment
        // boundary for <mip>: rangeStart and logicalOffset at that mip's offset, and chunkMeta.firstMip
        // equal to <mip>, since retail always keeps header.mipBase == firstMip. Resident memory then
        // drops from the whole payload to the mip tail, and the capped mips only stream on demand,
        // which never happens for art that is never drawn.
        //
        // The generated header ships as cas bundle idata, which the MVDB texture bind rejects, so a
        // capped texture must not be one anything actually renders.

        [CommandArgument(Description = "The exact resource/asset name, e.g. levels/mp_007/textures/mp_007_asphalt01_d.")]
        public string? Name { get; set; }

        [CommandArgument(Description = "The first resident mip. Must match the paired chunk's firstMip and logicalOffset.")]
        public string? Mip { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_BundleContext = p_Context as BundleBuildingContext;
            if (s_BundleContext == null || string.IsNullOrWhiteSpace(Name) || !int.TryParse(Mip, out var s_Mip) || s_Mip < 1 || s_Mip > 14)
            {
                p_Writer.WriteLine("usage (bundle ctx): cap_texture <name> <mip 1-14>");
                return false;
            }

            var s_SbBuildingContext = (SbBuildingContext)s_BundleContext.Parent!;
            var s_BaseContext = (BaseContext)s_SbBuildingContext.Parent!;
            var s_Mounter = s_BaseContext.GetMounters().Values.FirstOrDefault();
            if (s_Mounter == null)
            {
                p_Writer.WriteLine("cap_texture: no game mounted.");
                return false;
            }

            var s_Cap = Require<ITextureMipCap>(s_Mounter.GetEngineType(), p_Writer);
            if (s_Cap == null)
                return false;

            if (!s_Mounter.TryGetResource(Name!, out var s_Resource))
            {
                p_Writer.WriteLine($"cap_texture: resource not found: {Name}");
                return false;
            }

            byte[] s_Header;
            using (var s_Reader = s_Resource.FirstVariant.GetReader())
            {
                if (s_Reader.Length < s_Cap.HeaderSize)
                {
                    p_Writer.WriteLine($"cap_texture: {Name} is shorter than a texture header ({s_Reader.Length} bytes).");
                    return false;
                }

                s_Header = s_Reader.ReadBytes(s_Cap.HeaderSize);
            }

            string s_Change;
            try
            {
                s_Header = s_Cap.CapResidentMips(s_Header, s_Mip, out s_Change);
            }
            catch (Exception s_Ex)
            {
                p_Writer.WriteLine($"cap_texture: {Name}: {s_Ex.Message}");
                return false;
            }

            try { s_BundleContext.RemoveResource(Name!); } catch { }
            s_BundleContext.AddGeneratedResource(Name!, s_Header, s_Resource.FirstVariant.GetResourceType(), new byte[16]);
            p_Writer.WriteLine($"cap_texture {Name}: {s_Change}.");
            return true;
        }
    }
}
