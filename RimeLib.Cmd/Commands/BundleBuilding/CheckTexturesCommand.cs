using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Frostbite;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    [CommandDescription("Build-time validator: scans every DxTexture resource currently in this bundle and reports the ones that will FAIL the client's CreateTexture2D (E_INVALIDARG) when delivered standalone. A texture flagged Streaming (or MipmapBaseIndex>0) keeps its big mips in the game's streaming POOL, which a self-contained mod bundle does NOT populate -> the GPU gets fewer subresources than MipmapCount -> crash. Run AFTER resolve to find exactly which foreign-vehicle texture (screen/FX/etc.) is the culprit, without opening the game. No args.")]
    internal class CheckTexturesCommand : Command
    {
        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_Ctx = p_Context as BundleBuildingContext;
            if (s_Ctx == null)
            {
                p_Writer.WriteLine("check_textures must run inside a bundle-building context.");
                return false;
            }

            var s_Resources = s_Ctx.GetResources();
            int s_Total = 0, s_Bad = 0;

            foreach (var s_Kv in s_Resources)
            {
                var s_Name = s_Kv.Key;
                var s_Res = s_Kv.Value;
                if (s_Res.GetResourceType() != ResourceType.DxTexture)
                    continue;
                s_Total++;

                // Parse the DxTexture header (little-endian) per DxTexture.Serialize layout:
                // version u32, type u32, format u32, flags u32, w i16, h i16, depth i16, slice i16,
                // unused0 i16, mipCount u8, mipBase u8, chunkGuid[16], mipSizes[15] u32, mipChainSize u32 ...
                uint s_Flags; short s_W, s_H; int s_MipCount, s_MipBase; uint s_MipChain;
                try
                {
                    using var s_R = s_Res.GetReader();
                    s_R.Endianness = RimeLib.IO.Conversion.Endianness.LittleEndian;   // DxTexture is little-endian
                    s_R.ReadUInt32();                 // version
                    s_R.ReadUInt32();                 // type
                    s_R.ReadUInt32();                 // format
                    s_Flags = s_R.ReadUInt32();       // flags
                    s_W = s_R.ReadInt16();
                    s_H = s_R.ReadInt16();
                    s_R.ReadInt16();                  // depth
                    s_R.ReadInt16();                  // sliceCount
                    s_R.ReadInt16();                  // unused0
                    s_MipCount = s_R.ReadByte();
                    s_MipBase = s_R.ReadByte();
                    s_R.ReadBytes(16);                // streamingChunkId
                    for (int i = 0; i < 15; i++) s_R.ReadUInt32();
                    s_MipChain = s_R.ReadUInt32();
                }
                catch (System.Exception e)
                {
                    p_Writer.WriteLine($"TEX-PARSE-ERR {s_Name}: {e.Message}");
                    s_Bad++;
                    continue;
                }

                bool s_Streaming = (s_Flags & 0x1) != 0;   // TextureFlags.Streaming
                bool s_HasBase = s_MipBase != 0;
                bool s_Bad2 = s_Streaming || s_HasBase;
                if (s_Bad2)
                {
                    s_Bad++;
                    p_Writer.WriteLine(
                        $"TEX-BAD  {s_Name}  {s_W}x{s_H} mips={s_MipCount} base={s_MipBase} " +
                        $"flags=0x{s_Flags:X}{(s_Streaming ? " STREAMING" : "")}{(s_HasBase ? " MIPBASE>0" : "")} chain={s_MipChain}");
                }
            }

            p_Writer.WriteLine($"check_textures: {s_Total} DxTexture resource(s), {s_Bad} will FAIL standalone CreateTexture2D (streaming/mipbase). Fix = make these fully resident (regen via add_dds from a full dump, or clear streaming + full mip chain).");
            return true;
        }
    }
}
