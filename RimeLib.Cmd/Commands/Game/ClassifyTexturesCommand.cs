using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content;
using RimeLib.Content.Frostbite;
using RimeLib.Texture;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("TEXTURE-PHASE RE: classifies a LIST of texture resource names against the mounted game for cas-ref delivery. Per name, parses the ORIGINAL 128B DxTexture header (flags/mips/mipBase/format/chunkGuid) and probes every variant of its pixel chunk: full-range catalog ref available? retail h32-ranged variant (cas or stored-frame-in-cat)? noncas full/sliced frames in cat? Writes a TSV for offline bucketing (REF-FULL / REF-RANGED / CAP / MISS). Args: <name_list.txt> <out.tsv>.")]
    public class ClassifyTexturesCommand : Command
    {
        [CommandArgument(Description = "Text file with one texture resource name per line.")]
        public FileInfo? List { get; set; }

        [CommandArgument(Description = "The destination .tsv file.")]
        public FileInfo? Destination { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_Ctx = (GameContext)p_Context;
            var s_Mounter = s_Ctx.GetMounter() as RimeLib.Content.Frostbite2_0.Mounting.EngineMounter;
            if (s_Mounter == null)
            {
                p_Writer.WriteLine("classify_textures: no Frostbite2_0 mounter.");
                return false;
            }

            var s_Converter = EngineInterfaceRegistry.Create<ITextureConverter>(s_Mounter.GetEngineType());
            var s_Names = File.ReadAllLines(List!.FullName)
                .Select(p_L => p_L.Trim())
                .Where(p_L => p_L.Length > 0 && !p_L.StartsWith("#"))
                .ToArray();

            using var s_Out = new StreamWriter(Destination!.FullName, false, System.Text.Encoding.UTF8);
            s_Out.WriteLine("name\tstatus\tw\th\ttype\tfmt\tmips\tbase\tflags\tstreaming\tchain\tchunkGuid\tnVars\tfullCatRef\tretailH32\tfullNoncasInCat\tslicedInCat\tmaxStored\tchunkSbs");

            int s_Found = 0, s_Missing = 0;
            foreach (var s_Name in s_Names)
            {
                if (!s_Mounter.TryGetResource(s_Name, out var s_Res))
                {
                    s_Missing++;
                    s_Out.WriteLine($"{s_Name}\tNOTFOUND");
                    continue;
                }

                byte[] s_Header;
                using (var s_R = s_Res!.FirstVariant.GetReader())
                {
                    if (s_R.Length < 128)
                    {
                        s_Out.WriteLine($"{s_Name}\tSHORTHEADER:{s_R.Length}");
                        continue;
                    }
                    s_Header = s_R.ReadBytes(128);
                }

                // DxTexture header layout (little-endian, per CheckTexturesCommand / DxTexture.Serialize):
                // version u32@0, type u32@4, format u32@8, flags u32@12, w i16@16, h i16@18,
                // depth i16@20, slice i16@22, unused i16@24, mipCount u8@26, mipBase u8@27,
                // chunkGuid[16]@28, mipSizes u32[15]@44, mipChainSize u32@104.
                var s_Type = System.BitConverter.ToUInt32(s_Header, 4);
                var s_Fmt = System.BitConverter.ToUInt32(s_Header, 8);
                var s_Flags = System.BitConverter.ToUInt32(s_Header, 12);
                var s_W = System.BitConverter.ToInt16(s_Header, 16);
                var s_H = System.BitConverter.ToInt16(s_Header, 18);
                int s_Mips = s_Header[26];
                int s_Base = s_Header[27];
                var s_Chain = System.BitConverter.ToUInt32(s_Header, 104);
                var s_Streaming = (s_Flags & 0x1) != 0;

                // Chunk id via the engine converter (correct guid byte order — destream pattern).
                var s_Probe = new BundleBuildingContext.ResourceMemoryReader(s_Header, ResourceType.DxTexture, s_Name);
                var s_ChunkId = s_Converter.GetTextureChunkId(s_Probe);

                var s_NVars = 0;
                var s_FullCatRef = 0;          // full-range catalog-backed variant exists (destream-full path)
                var s_RetailH32 = "none";      // h32-matched retail variant: cas / incat / miss (+ its ranges)
                var s_FullNoncasInCat = 0;     // full-range noncas variant whose stored frame is in cat
                var s_SlicedInCat = 0;         // ranged noncas variant whose stored (slice) frame is in cat
                long s_MaxStored = 0;
                var s_ChunkSbs = new System.Collections.Generic.HashSet<string>();

                if (s_ChunkId != RimeLib.Frostbite.Core.GUID.Empty && s_Mounter.TryGetChunk(s_ChunkId, out var s_Chunk))
                {
                    var s_ExpectedH32 = (int)RimeLib.Frostbite.Utils.HashQuick(s_Name);
                    foreach (var s_V in s_Chunk!.Variants)
                    {
                        s_NVars++;
                        var s_Rs = s_V.GetRangeStart();
                        var s_Lo = s_V.GetLogicalOffset();
                        var s_Full = s_Rs == 0 && s_Lo == 0;
                        var s_H32Match = s_V.GetAssetNameHash() == s_ExpectedH32;
                        s_ChunkSbs.Add($"{s_V.GetContainedSuperbundle()}|{s_V.GetContainedBundle() ?? "-"}");

                        string s_Backing;
                        if (s_V.Cas)
                        {
                            s_Backing = "cas";
                            if (s_Full) s_FullCatRef = 1;
                        }
                        else if (s_Mounter.TryHashVariantStoredFrame(s_V, out _, out var s_Size, out var s_InCat))
                        {
                            s_Backing = s_InCat ? "incat" : "miss";
                            if (s_Size > s_MaxStored) s_MaxStored = s_Size;
                            if (s_InCat && s_Full) s_FullNoncasInCat = 1;
                            if (s_InCat && !s_Full) s_SlicedInCat = 1;
                        }
                        else
                        {
                            s_Backing = "cas";
                        }

                        if (s_H32Match && s_RetailH32 == "none")
                            s_RetailH32 = $"{s_Backing}{(s_Full ? "-full" : "-ranged")}";
                    }
                }

                s_Found++;
                s_Out.WriteLine($"{s_Name}\tOK\t{s_W}\t{s_H}\t{s_Type}\t{s_Fmt}\t{s_Mips}\t{s_Base}\t0x{s_Flags:X}\t{(s_Streaming ? 1 : 0)}\t{s_Chain}\t{(s_ChunkId == RimeLib.Frostbite.Core.GUID.Empty ? "-" : s_ChunkId.ToString())}\t{s_NVars}\t{s_FullCatRef}\t{s_RetailH32}\t{s_FullNoncasInCat}\t{s_SlicedInCat}\t{s_MaxStored}\t{string.Join(",", s_ChunkSbs)}");
            }

            p_Writer.WriteLine($"classify_textures: {s_Found} classified, {s_Missing} not found -> {Destination!.FullName}");
            return true;
        }
    }
}
