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
    /// Loads an Ant animation package (an <c>AntPackageAsset</c> EBX partition plus the chunk it
    /// streams) and writes what the bank holds as JSON: every object, its Ant type, and for the
    /// animation types the numbers a keyframe exporter needs -- key count, channel counts, frame
    /// rate.
    ///
    /// This is the reconnaissance step for animation export. Rime already has the whole Ant object
    /// model (RimeLib.Animation.Frostbite2_0/ant, 258 generated types) and an AssetBank reader, but
    /// nothing in the command layer ever called them, so it was unknown whether they run on shipped
    /// BF3 data at all. The JSON reports <c>parsed</c> and <c>failed</c> counts rather than
    /// throwing, because "how much of this game's animation can Rime actually read" is the
    /// question, and an exception on object 40 of 4000 would otherwise hide the answer.
    ///
    /// It also dumps the bank's STRUCTURE, not only its clips: the rig, its DOF-set layouts and the
    /// ant::SkeletonAsset joints, plus the EBX AntAnimationSetAsset rows that bind a set to an
    /// fb::SkeletonAsset. That is what turns a channel from "DOF 37" into a named joint, and it
    /// rides along here because a full game mount is too expensive to pay for twice.
    /// </summary>
    [CommandDescription("Loads an Ant animation package (AntPackageAsset partition + its streamed chunk) and dumps the bank's objects as JSON.")]
    public class DumpAnimationBankCommand : Command
    {
        [CommandArgument(Description = "The AntPackageAsset partition, e.g. animations/antanimations/xp1_l96")]
        public string? Name { get; set; }

        [CommandArgument(Description = "The output .json file")]
        public FileInfo? Destination { get; set; }

        [CommandArgument(Description = "How many decoded frames to include per clip, for eyeballing the values. Default 0.", Optional = true)]
        public int Samples { get; set; } = 0;

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (string.IsNullOrWhiteSpace(Name) || Destination is null)
            {
                p_Writer.WriteLine("Usage: dump_animation_bank <antpackage-partition> <destination.json>");
                return false;
            }

            var s_Mounter = ((GameContext)p_Context).GetMounter();
            var s_Codec = Require<IAnimationBankCodec>(s_Mounter.GetEngineType(), p_Writer);
            if (s_Codec == null)
                return false;

            var s_Result = s_Codec.DumpBank(s_Mounter, Name!, Samples);

            if (s_Result.Report != null)
                File.WriteAllText(Destination.FullName, JsonConvert.SerializeObject(s_Result.Report, Formatting.Indented));

            p_Writer.WriteLine(s_Result.Message);
            return s_Result.Succeeded;
        }
    }
}
