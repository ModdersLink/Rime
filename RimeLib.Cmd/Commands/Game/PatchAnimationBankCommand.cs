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
    /// Writes edited animation clips back into an Ant bank blob.
    ///
    /// Ant banks are relocatable GenericData archives whose every pointer is a file offset, and
    /// Rime has no writer for one; emitting a bank from the object graph would mean re-laying-out
    /// the whole archive, its reflection table included. That is why animation was the last asset
    /// class that could be exported and not returned.
    ///
    /// The way around it is that a clip's payload does not have to change SIZE. A DCT clip
    /// re-encoded against its own bit-allocation table produces exactly as many bytes as it
    /// shipped with, and an uncompressed RawAnimationAsset/FrameAnimationAsset has a fixed float
    /// count by construction. So the payload is overwritten where it already lies -- the bank's
    /// layout, its reflection table, every other clip and every pointer are untouched, byte for
    /// byte -- and the result is a blob the game loads as the bank it already was.
    ///
    /// The output goes into a bundle with the ordinary resource path, e.g.
    /// <c>add_resource animations/antanimations/ak74 AssetBank /tmp/ak74.bin 0</c>.
    ///
    /// Edits are JSON:
    /// <code>
    /// { "clips": [
    ///     { "index": 12, "frames": [ [ [x,y,z,w], ... ], ... ] },   // DCT: per frame, per DOF
    ///     { "index":  3, "data":   [ 1.0, 2.0, ... ] }              // Raw/Frame: the float keys
    /// ] }
    /// </code>
    /// <c>index</c> is the object's position in the bank, which is what
    /// <c>dump_animation_bank</c> reports and what an AntAnimationSetAsset addresses clips by.
    /// </summary>
    [CommandDescription("Writes edited clips back into an Ant bank blob, in place, and verifies the result decodes to what was asked for.")]
    public class PatchAnimationBankCommand : Command
    {
        [CommandArgument(Description = "The AntPackageAsset partition, e.g. animations/antanimations/ak74")]
        public string? Name { get; set; }

        [CommandArgument(Description = "The edits .json")]
        public FileInfo? Edits { get; set; }

        [CommandArgument(Description = "The output bank blob")]
        public FileInfo? Destination { get; set; }

        [CommandArgument(Description = "Also write a .json report next to the blob. Default true.", Optional = true)]
        public bool Report { get; set; } = true;

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (string.IsNullOrWhiteSpace(Name) || Edits is null || Destination is null)
            {
                p_Writer.WriteLine("Usage: patch_animation_bank <antpackage-partition> <edits.json> <out.bin>");
                return false;
            }

            var s_Mounter = ((GameContext)p_Context).GetMounter();
            var s_Codec = Require<IAnimationBankCodec>(s_Mounter.GetEngineType(), p_Writer);
            if (s_Codec == null)
                return false;

            if (!Edits.Exists)
            {
                p_Writer.WriteLine($"The edit file '{Edits.FullName}' does not exist.");
                return false;
            }

            var s_Result = s_Codec.Patch(s_Mounter, Name!, File.ReadAllText(Edits.FullName), p_Writer);

            if (s_Result.Bank == null)
            {
                p_Writer.WriteLine(s_Result.Message);
                return false;
            }

            File.WriteAllBytes(Destination.FullName, s_Result.Bank);

            if (Report && s_Result.Report != null)
                File.WriteAllText(Destination.FullName + ".json", JsonConvert.SerializeObject(s_Result.Report, Formatting.Indented));

            p_Writer.WriteLine($"{s_Result.Message} -> {Destination.FullName}");
            return s_Result.Succeeded;
        }
    }
}
