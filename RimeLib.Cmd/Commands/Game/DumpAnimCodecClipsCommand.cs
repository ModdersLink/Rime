using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using RimeLib.Animation;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.Game
{
    /// <summary>
    /// Dumps every VBR and CURV clip the game ships, header fields and raw payload alike, so the
    /// two codecs that have no decoder can be reverse-engineered OFFLINE.
    ///
    /// It sweeps the mounted partitions rather than taking one name, because a full BF3
    /// mount is expensive enough that the codec work cannot afford to pay for it once per bank --
    /// and because the interesting question ("what do 2,225 VBR clips have in common") is a
    /// corpus question, not a per-bank one.
    ///
    /// The payload comes out base64 and the section-size fields come out beside it, which is the
    /// whole point: <c>VbrAnimationAsset</c> carries KeyTimeSize / ConstChanMapSize /
    /// VectorOffsetSize / FloatOffsetSize and a per-frame-block size table, and whether those
    /// account for <c>Data</c> exactly is a sum that can be checked without the game running.
    /// </summary>
    [CommandDescription("Dumps every VBR and CURV clip in every mounted Ant bank as JSON, payload included.")]
    public class DumpAnimCodecClipsCommand : Command
    {
        [CommandArgument(Description = "Directory to write one <bank>.json per bank into")]
        public DirectoryInfo? Destination { get; set; }

        [CommandArgument(Description = "Partition name prefix. Defaults to where the engine keeps its animation packages.", Optional = true)]
        public string? Prefix { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (Destination is null)
            {
                p_Writer.WriteLine("Usage: dump_anim_codec_clips <outdir> [prefix]");
                return false;
            }

            Destination.Create();

            var s_Context = (GameContext)p_Context;
            var s_Mounter = s_Context.GetMounter();
            var s_Codec = Require<IAnimationBankCodec>(s_Mounter.GetEngineType(), p_Writer);
            if (s_Codec == null)
                return false;

            var s_Names = s_Context.GetMountedPartitions()
                .Where(x => x.StartsWith(Prefix ?? s_Codec.PackagePrefix, StringComparison.OrdinalIgnoreCase))
                .OrderBy(x => x, StringComparer.Ordinal)
                .ToList();

            var s_Result = s_Codec.DumpCodecClips(s_Mounter, s_Names, (p_Name, p_Bank) =>
                File.WriteAllText(Path.Combine(Destination.FullName, p_Name.Replace('/', '_') + ".json"),
                                  JsonConvert.SerializeObject(p_Bank, Formatting.None)));

            p_Writer.WriteLine($"dump_anim_codec_clips: {s_Result.Message} -> {Destination.FullName}");
            return s_Result.Succeeded;
        }
    }
}
