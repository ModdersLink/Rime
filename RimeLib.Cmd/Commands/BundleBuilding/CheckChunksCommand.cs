using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using RimeLib.Mesh.Frostbite;
using RimeLib.Texture;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    [CommandDescription("Build-time validator: verifies every DxTexture/MeshSet resource in this bundle has its data CHUNK present AND complete. A texture whose chunk is MISSING or SHORT (delivered bytes < the header's mip-chain size, e.g. a RANGED/partial streaming variant copied whole) makes the client WAIT for data that never arrives = load HANG (no dump), as opposed to the E_INVALIDARG that check_textures catches. Run AFTER resolve/add_dds. No args.")]
    internal class CheckChunksCommand : Command
    {
        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_Ctx = p_Context as BundleBuildingContext;
            if (s_Ctx == null)
            {
                p_Writer.WriteLine("check_chunks must run inside a bundle-building context.");
                return false;
            }

            var s_SbCtx = (SbBuildingContext)s_Ctx.Parent!;
            var s_Chunks = s_Ctx.GetChunks();
            int s_Tex = 0, s_Mesh = 0, s_Bad = 0;

            string ChunkInfo(GUID p_Id, long p_Expected)
            {
                if (!s_Chunks.TryGetValue(p_Id, out var s_Chunk))
                {
                    s_Bad++;
                    return $"CHUNK-MISSING {p_Id}";
                }
                long s_Len = -1, s_Logical = -1; uint s_RangeStart = 0, s_RangeEnd = 0;
                try { using var s_R = s_Chunk.GetReader(); s_Len = s_R.Length; } catch { }
                try { s_Logical = s_Chunk.GetLogicalSize(); } catch { }
                try { s_RangeStart = s_Chunk.GetRangeStart(); s_RangeEnd = s_Chunk.GetRangeEnd(); } catch { }
                bool s_Ranged = s_RangeEnd != 0 && (s_RangeEnd - s_RangeStart) < s_Logical;
                bool s_Short = p_Expected > 0 && s_Len >= 0 && s_Len < p_Expected;
                if (s_Ranged || s_Short) s_Bad++;
                return $"chunk={p_Id} len={s_Len} logical={s_Logical} range={s_RangeStart}..{s_RangeEnd} expected={p_Expected}" +
                       $"{(s_Short ? " ** SHORT (hang candidate) **" : "")}{(s_Ranged ? " ** RANGED/PARTIAL (hang candidate) **" : "")}";
            }

            foreach (var s_Kv in s_Ctx.GetResources())
            {
                var s_Name = s_Kv.Key;
                var s_Res = s_Kv.Value;
                var s_Type = s_Res.GetResourceType();

                if (s_Type == ResourceType.DxTexture)
                {
                    s_Tex++;
                    try
                    {
                        // DxTexture header (little-endian): version, type, format, flags, w, h, depth, slice,
                        // unused, mipCount u8, mipBase u8, chunkGuid[16], mipSizes[15] u32, mipChainSize u32.
                        using var s_R = s_Res.GetReader();
                        s_R.Endianness = RimeLib.IO.Conversion.Endianness.LittleEndian;
                        s_R.ReadUInt32(); s_R.ReadUInt32(); s_R.ReadUInt32();
                        uint s_Flags = s_R.ReadUInt32();
                        s_R.ReadInt16(); s_R.ReadInt16(); s_R.ReadInt16(); s_R.ReadInt16(); s_R.ReadInt16();
                        int s_MipCount = s_R.ReadByte();
                        int s_MipBase = s_R.ReadByte();
                        s_R.ReadBytes(16);
                        long s_Resident = 0;
                        for (int i = 0; i < 15; i++)
                        {
                            uint s_Sz = s_R.ReadUInt32();
                            if (i >= s_MipBase && i < s_MipCount) s_Resident += s_Sz;
                        }
                        uint s_MipChain = s_R.ReadUInt32();

                        var s_Converter = EngineInterfaceRegistry.Create<ITextureConverter>(s_SbCtx.EngineType);
                        var s_ChunkId = s_Converter.GetTextureChunkId(s_Res);
                        if (s_ChunkId == GUID.Empty)
                        {
                            // no chunk = fully header-resident or engine-created (render target) -> nothing to verify
                            p_Writer.WriteLine($"CHK-TEX  {s_Name}  no-chunk (resident/engine-created) mips={s_MipCount} flags=0x{s_Flags:X}");
                            continue;
                        }
                        // for a resident (non-streaming) texture the delivered chunk must cover the FULL chain;
                        // expected = mipChainSize (falls back to the summed resident mips when chain==0).
                        long s_Expected = s_MipChain != 0 ? s_MipChain : s_Resident;
                        p_Writer.WriteLine($"CHK-TEX  {s_Name}  mips={s_MipCount} base={s_MipBase} flags=0x{s_Flags:X}  {ChunkInfo(s_ChunkId, s_Expected)}");
                    }
                    catch (System.Exception e)
                    {
                        s_Bad++;
                        p_Writer.WriteLine($"CHK-TEX-ERR {s_Name}: {e.Message}");
                    }
                }
                else if (s_Type == ResourceType.MeshSet)
                {
                    s_Mesh++;
                    try
                    {
                        using var s_Reader1 = s_Res.GetReader();
                        var s_Data = s_Reader1.ReadBytes((int)s_Reader1.Length);
                        using var s_Reader = new RimeReader(new MemoryStream(s_Data));
                        var s_Layout = new MeshSetLayout(s_Reader);
                        for (var i = 0; i < s_Layout.LodCount; i++)
                        {
                            var s_Lod = s_Layout.Lods[i].Object;
                            if (s_Lod == null || s_Lod.DataChunkId == GUID.Empty)
                                continue;
                            bool s_Base = (s_Lod.Flags & MeshLayout.MeshLayoutFlags.IsBaseLod) != 0;
                            // non-base lods live inline in the resource; only base-lod data comes from the chunk
                            if (!s_Base)
                                continue;
                            p_Writer.WriteLine($"CHK-MESH {s_Name} lod{i} {ChunkInfo(s_Lod.DataChunkId, 0)}");
                        }
                    }
                    catch (System.Exception e)
                    {
                        s_Bad++;
                        p_Writer.WriteLine($"CHK-MESH-ERR {s_Name}: {e.Message}");
                    }
                }
            }

            // generic pass: ANY bundle chunk that is a partial RANGE of its logical chunk (rangeStart != 0)
            // is a slice of a bigger payload (streaming resident portion) delivered standalone — suspicious
            // for sound/fx/etc. chunks the typed checks above don't cover.
            int s_Ranged = 0;
            foreach (var s_Kv in s_Chunks)
            {
                uint s_Start = 0;
                try { s_Start = s_Kv.Value.GetRangeStart(); } catch { }
                if (s_Start != 0)
                {
                    s_Ranged++;
                    if (s_Ranged <= 10)
                        p_Writer.WriteLine($"CHK-RANGED chunk {s_Kv.Key} rangeStart={s_Start} (partial slice delivered standalone)");
                }
            }

            p_Writer.WriteLine($"check_chunks: {s_Tex} DxTexture + {s_Mesh} MeshSet resource(s) checked, {s_Bad} chunk problem(s); {s_Ranged} ranged/partial chunk(s) bundle-wide (missing/short/ranged = client load-hang candidates).");
            return true;
        }
    }
}
