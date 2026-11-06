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
    /// Re-encodes every clip in an Ant bank and compares the result against the bytes the game
    /// ships, per clip.
    ///
    /// This exists because "the encoder works" is not something a decoder can be asked. The DCT
    /// codec is lossy at the FLOAT level -- quaternions come out of the decoder normalised, so
    /// their magnitude is gone and no encoder can put it back -- but it is not lossy at the
    /// COEFFICIENT level, and that is where the bit packing lives. So two different things are
    /// measured and reported separately:
    ///
    ///   bitstream  DecodeBlocks -> EncodeBlocks -> compare bytes. Expected BYTE-IDENTICAL. This
    ///              is the proof that the packing, the bit widths, the delta bases and the
    ///              block-0 special case are all understood.
    ///   values     Decode -> Quantize -> EncodeBlocks -> Decode -> compare floats. Expected close
    ///              but NOT identical, and the largest disagreement over the clip is reported so
    ///              the loss is a number rather than an adjective.
    ///
    /// It also round-trips the standalone <see cref="Header"/>/<see cref="DofTable"/> writers,
    /// which had no call site at all, against every clip's own bit-allocation table.
    /// </summary>
    [CommandDescription("Re-encodes every clip in an Ant bank and reports how many re-encode to the shipped bytes.")]
    public class CheckAnimationCodecCommand : Command
    {
        [CommandArgument(Description = "The AntPackageAsset partition, e.g. animations/antanimations/ak74, or * for every one the mount holds")]
        public string? Name { get; set; }

        [CommandArgument(Description = "The output .json report")]
        public FileInfo? Destination { get; set; }

        [CommandArgument(Description = "Also write an edits .json here that nudges one clip, ready for patch_animation_bank.", Optional = true)]
        public FileInfo? EditProbe { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (string.IsNullOrWhiteSpace(Name) || Destination is null)
            {
                p_Writer.WriteLine("Usage: check_animation_codec <antpackage-partition> <report.json>");
                return false;
            }

            var s_Context = (GameContext)p_Context;
            var s_Mounter = s_Context.GetMounter();
            var s_Codec = Require<IAnimationBankCodec>(s_Mounter.GetEngineType(), p_Writer);
            if (s_Codec == null)
                return false;

            // One mount is expensive enough that "does this hold over the whole game" cannot be
            // asked once per bank. `*` sweeps every animation package partition the mount holds
            // and aggregates into one report.
            var s_Names = new List<string>();

            if (Name == "*")
            {
                s_Names.AddRange(s_Context.GetMountedPartitions()
                    .Where(p_P => p_P.StartsWith(s_Codec.PackagePrefix, StringComparison.OrdinalIgnoreCase)));
                s_Names.Sort(StringComparer.Ordinal);
            }
            else
            {
                s_Names.Add(Name!);
            }

            var s_Result = s_Codec.CheckCodecs(s_Mounter, s_Names, Name == "*", EditProbe != null);

            if (s_Result.Report == null)
            {
                p_Writer.WriteLine(s_Result.Message);
                return false;
            }

            if (EditProbe != null && s_Result.EditProbe != null)
            {
                File.WriteAllText(EditProbe.FullName, JsonConvert.SerializeObject(s_Result.EditProbe, Formatting.None));
                p_Writer.WriteLine($"probe: edit file -> {EditProbe.FullName}");
            }

            File.WriteAllText(Destination.FullName, JsonConvert.SerializeObject(s_Result.Report, Formatting.Indented));
            p_Writer.WriteLine(s_Result.Message);

            // A pass has to mean content as well as agreement: a bank with no clips at all would
            // otherwise satisfy every equality the check makes.
            return s_Result.Succeeded;
        }
    }
}
