using RimeLib.Frostbite;
using RimeLib.Cmd;
using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RimeLib.Animation.Frostbite2_0.EA.Compression.Curve;
using RimeLib.Animation.Frostbite2_0.EA.Compression.DCT;
using RimeLib.Animation.Frostbite2_0.EA.Compression.Vbr;
using Rimelib.Animation.Frostbite2_0.Frostbite;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.IO;

namespace RimeLib.Cmd.Frostbite2_0.Commands.Game
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
    [EngineCommand(typeof(GameContext), EngineType.Frostbite2_0)]
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

            var s_Context = (GameContext)p_Context;
            var s_Mounter = s_Context.GetMounter();

            var s_Data = AntBankFile.Read(s_Mounter, Name!, out var s_Source, out var s_ReadError);

            if (s_Data == null)
            {
                p_Writer.WriteLine(s_ReadError);
                return false;
            }

            if (!Edits.Exists)
            {
                p_Writer.WriteLine($"The edit file '{Edits.FullName}' does not exist.");
                return false;
            }

            var s_Bank = AntBankFile.Load(s_Data);
            var s_Doc = JObject.Parse(File.ReadAllText(Edits.FullName));
            var s_Clips = s_Doc["clips"] as JArray;

            if (s_Clips == null || s_Clips.Count == 0)
            {
                p_Writer.WriteLine("The edit file names no clips. Refusing to write a blob that "
                                   + "changes nothing -- an untouched bank should keep referencing "
                                   + "the game's own resource.");
                return false;
            }

            var s_Result = AntBankPatcher.Patch(s_Data, s_Bank, s_Clips, p_Writer);
            if (s_Result == null)
                return false;

            var s_Patched = s_Result.Patched;
            var s_Verify = s_Result.Verify;
            File.WriteAllBytes(Destination.FullName, s_Patched);

            if (Report)
            {
                File.WriteAllText(Destination.FullName + ".json", JsonConvert.SerializeObject(new
                {
                    partition = Name,
                    source = s_Source,
                    blobLength = s_Patched.Length,
                    sameLength = s_Patched.Length == s_Data.Length,
                    clipsEdited = s_Result.Applied,
                    bytesChanged = s_Result.BytesChanged,
                    reload = s_Verify,
                    clips = s_Result.Rows,
                }, Formatting.Indented));
            }

            p_Writer.WriteLine($"{Name}: patched {s_Result.Applied} clip(s), {s_Result.BytesChanged} byte(s) "
                               + $"changed of {s_Patched.Length}, reloaded "
                               + $"{s_Verify.Objects} object(s), {s_Verify.EditsLanded}/"
                               + $"{s_Verify.EditsChecked} edit(s) landed (max error "
                               + $"{s_Verify.MaxEditError:G6}), {s_Verify.ClipsUnchanged}/"
                               + $"{s_Verify.ClipsCompared} untouched clip(s) byte-identical "
                               + $"-> {Destination.FullName}");

            return s_Result.Applied > 0 && s_Result.BytesChanged > 0 && s_Verify.Ok;
        }
    }
}
