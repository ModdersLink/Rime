using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
using Newtonsoft.Json;
using RimeLib.Animation.EA.Compression.DCT;
using RimeLib.Animation.Frostbite2_0.EA.Compression.Curve;
using RimeLib.Animation.Frostbite2_0.EA.Compression.DCT;
using RimeLib.Animation.Frostbite2_0.EA.Compression.Vbr;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.IO;

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

            // One mount is expensive enough that "does this hold over the whole game" cannot be
            // asked 322 times. `*` sweeps every AntPackageAsset partition the mount holds and
            // aggregates into one report, which is how the per-codec totals below were measured.
            var s_Names = new List<string>();

            if (Name == "*")
            {
                foreach (var s_Partition in s_Context.GetMountedPartitions())
                {
                    if (s_Partition.StartsWith("animations/antanimations/",
                                               StringComparison.OrdinalIgnoreCase))
                    {
                        s_Names.Add(s_Partition);
                    }
                }

                s_Names.Sort(StringComparer.Ordinal);
            }
            else
            {
                s_Names.Add(Name!);
            }

            var s_Rows = new List<object>();
            var s_Decompressor = new Decompressor();
            var s_Compressor = new Compressor();

            var s_Banks = 0;
            var s_BankErrors = 0;
            var s_Source = "";
            byte[]? s_ProbeData = null;
            Rimelib.Animation.Frostbite2_0.Frostbite.AssetBank? s_ProbeBank = null;
            var s_ProbeName = "";

            var s_Dct = 0;
            var s_BitExact = 0;
            var s_LengthMismatch = 0;
            var s_HeaderOk = 0;
            var s_Patchable = 0;
            var s_Raw = 0;
            var s_RawPatchable = 0;
            var s_Curve = 0;
            var s_CurveExact = 0;
            var s_CurvePatchable = 0;
            var s_CurveKeyTimes = 0;
            var s_Vbr = 0;
            var s_VbrExact = 0;
            var s_VbrPatchable = 0;
            var s_VbrAccounted = 0;
            var s_VbrConstComponents = 0L;
            var s_VbrAnimComponents = 0L;
            var s_VbrUnitQuats = 0;
            var s_VbrQuats = 0;
            var s_VbrApproximated = 0L;
            var s_VbrMaxConstError = 0.0;
            var s_MaxValueError = 0.0;
            var s_TotalBytes = 0L;
            var s_IdenticalBytes = 0L;

            foreach (var s_Name in s_Names)
            {
            var s_Data = AntBankFile.Read(s_Mounter, s_Name, out s_Source, out var s_ReadError);

            if (s_Data == null)
            {
                if (Name != "*")
                {
                    p_Writer.WriteLine(s_ReadError);
                    return false;
                }

                continue;
            }

            Rimelib.Animation.Frostbite2_0.Frostbite.AssetBank s_Bank;

            try
            {
                s_Bank = AntBankFile.Load(s_Data);
            }
            catch (Exception s_Ex)
            {
                if (Name != "*")
                {
                    p_Writer.WriteLine($"'{s_Name}' did not parse: {s_Ex.GetType().Name}: "
                                       + s_Ex.Message);
                    return false;
                }

                s_BankErrors += 1;
                continue;
            }

            s_Banks += 1;

            // In sweep mode the probe should land on a bank that exercises the new
            // codecs; asked for ONE bank, the probe is for that bank whatever it holds.
            if (s_ProbeBank == null && (Name != "*" || HasProbeableClip(s_Bank)))
            {
                s_ProbeBank = s_Bank;
                s_ProbeData = s_Data;
                s_ProbeName = s_Name;
            }

            var s_Index = -1;

            foreach (var s_Object in s_Bank.Objects)
            {
                s_Index += 1;

                if (s_Object is ant.DctAnimationAsset s_Clip)
                {
                    s_Dct += 1;
                    Record(s_Rows, s_Name, Name == "*", CheckDct(s_Clip, s_Index, s_Bank, s_Data, s_Decompressor, s_Compressor,
                                        ref s_BitExact, ref s_LengthMismatch, ref s_HeaderOk,
                                        ref s_Patchable, ref s_MaxValueError,
                                        ref s_TotalBytes, ref s_IdenticalBytes));
                    continue;
                }

                if (s_Object is ant.CurveAnimationAsset s_CurveClip)
                {
                    s_Curve += 1;
                    Record(s_Rows, s_Name, Name == "*", CheckCurve(s_CurveClip, s_Index, s_Bank, s_Data, ref s_CurveExact,
                                          ref s_CurvePatchable, ref s_CurveKeyTimes,
                                          ref s_TotalBytes, ref s_IdenticalBytes));
                    continue;
                }

                if (s_Object is ant.VbrAnimationAsset s_VbrClip)
                {
                    s_Vbr += 1;
                    Record(s_Rows, s_Name, Name == "*", CheckVbr(s_VbrClip, s_Index, s_Bank, s_Data, ref s_VbrExact,
                                        ref s_VbrPatchable, ref s_VbrAccounted,
                                        ref s_VbrConstComponents, ref s_VbrAnimComponents,
                                        ref s_VbrUnitQuats, ref s_VbrQuats,
                                        ref s_VbrApproximated, ref s_VbrMaxConstError,
                                        ref s_TotalBytes, ref s_IdenticalBytes));
                    continue;
                }

                // The uncompressed codecs the game also ships. Nothing to re-encode -- their
                // payload IS float keys -- so the only question is whether the bytes can be
                // reached for a write, which is what the array location answers.
                if (s_Object is ant.RawAnimationAsset || s_Object is ant.FrameAnimationAsset)
                {
                    s_Raw += 1;

                    var s_Located = s_Bank.ArrayLocations.TryGetValue(s_Object, out var s_Fields)
                                    && s_Fields.TryGetValue("Data", out var s_Loc)
                                    && s_Loc.Count > 0
                                    && s_Loc.Offset >= 0
                                    && s_Loc.Offset + s_Loc.Count * 4 <= s_Data.Length
                                    && Holds(s_Data, s_Loc.Offset, FloatBytes(s_Object, s_Loc.BigEndian));

                    if (s_Located)
                        s_RawPatchable += 1;

                    Record(s_Rows, s_Name, Name == "*", new Dictionary<string, object?>
                    {
                        { "index", s_Index },
                        { "type", s_Object.GetType().Name },
                        { "name", s_Object.ObjectName },
                        { "patchable", s_Located },
                        { "dataOffset", s_Located ? s_Fields!["Data"].Offset : -1 },
                        { "dataCount", s_Located ? s_Fields!["Data"].Count : 0 },
                        { "bigEndian", s_Located && s_Fields!["Data"].BigEndian },
                    });
                }
            }
            }

            if (s_Banks == 0)
            {
                p_Writer.WriteLine($"'{Name}' matched no Ant bank.");
                return false;
            }

            if (EditProbe != null && s_ProbeBank != null)
                WriteProbe(s_ProbeBank, s_ProbeName, s_Decompressor, EditProbe, p_Writer);

            File.WriteAllText(Destination.FullName, JsonConvert.SerializeObject(new
            {
                partition = Name,
                source = s_Source,
                banks = s_Banks,
                bankParseErrors = s_BankErrors,
                dctClips = s_Dct,
                dctBitExact = s_BitExact,
                dctLengthMismatch = s_LengthMismatch,
                dctHeaderRoundTrip = s_HeaderOk,
                dctPatchable = s_Patchable,
                payloadBytes = s_TotalBytes,
                payloadBytesIdentical = s_IdenticalBytes,
                maxValueError = s_MaxValueError,
                uncompressedClips = s_Raw,
                uncompressedPatchable = s_RawPatchable,
                curveClips = s_Curve,
                curveByteExact = s_CurveExact,
                curvePatchable = s_CurvePatchable,
                curveKeyTimesAccounted = s_CurveKeyTimes,
                vbrClips = s_Vbr,
                vbrByteExact = s_VbrExact,
                vbrPatchable = s_VbrPatchable,
                vbrSectionsAccounted = s_VbrAccounted,
                vbrConstComponents = s_VbrConstComponents,
                vbrAnimatedComponents = s_VbrAnimComponents,
                vbrConstQuats = s_VbrQuats,
                vbrConstQuatsUnit = s_VbrUnitQuats,
                vbrConstantsApproximated = s_VbrApproximated,
                vbrMaxConstValueError = s_VbrMaxConstError,
                clips = s_Rows,
            }, Formatting.Indented));

            p_Writer.WriteLine($"{Name}: {s_BitExact}/{s_Dct} DCT clip(s) re-encode byte-identical "
                               + $"({s_IdenticalBytes}/{s_TotalBytes} payload byte(s)), "
                               + $"{s_HeaderOk}/{s_Dct} header(s) round-trip, "
                               + $"max value error {s_MaxValueError:G6}, "
                               + $"{s_RawPatchable}/{s_Raw} uncompressed clip(s) patchable, "
                               + $"CURV {s_CurveExact}/{s_Curve} byte-identical "
                               + $"({s_CurvePatchable} patchable), "
                               + $"VBR {s_VbrExact}/{s_Vbr} byte-identical "
                               + $"({s_VbrPatchable} patchable, {s_VbrUnitQuats}/{s_VbrQuats} "
                               + "const quats unit).");

            // A pass has to mean CONTENT as well as agreement: a bank with no clips at all would
            // otherwise satisfy every equality below.
            return s_Dct + s_Raw + s_Curve + s_Vbr > 0
                   && s_BitExact == s_Dct && s_RawPatchable == s_Raw
                   && s_CurveExact == s_Curve && s_CurvePatchable == s_Curve
                   && s_VbrExact == s_Vbr && s_VbrPatchable == s_Vbr
                   && s_VbrAccounted == s_Vbr;
        }


        /// <summary>
        /// Adds a clip row to the report. Over the whole game that is 8,972 rows, most of them
        /// saying "fine", so a sweep keeps only the rows that report a PROBLEM -- the totals carry
        /// the pass counts and a 300 MB report nobody opens carries nothing.
        /// </summary>
        private static void Record(List<object> p_Rows, string p_Partition, bool p_FailuresOnly,
                                   Dictionary<string, object?> p_Row)
        {
            p_Row["partition"] = p_Partition;

            if (!p_FailuresOnly)
            {
                p_Rows.Add(p_Row);
                return;
            }

            var s_Bad = p_Row.ContainsKey("error")
                        || Falsey(p_Row, "bitExact") || Falsey(p_Row, "byteExact")
                        || Falsey(p_Row, "patchable") || Falsey(p_Row, "headerRoundTrip");

            if (s_Bad)
                p_Rows.Add(p_Row);
        }

        private static bool Falsey(Dictionary<string, object?> p_Row, string p_Key)
            => p_Row.TryGetValue(p_Key, out var s_Value) && s_Value is bool s_Bool && !s_Bool;


        /// <summary>Whether a bank holds a clip of BOTH new codecs, so a sweep's probe lands on a
        /// bank that exercises the CURV and VBR write paths rather than the first bank it meets.
        /// 62 of BF3's 322 banks qualify.</summary>
        private static bool HasProbeableClip(
            Rimelib.Animation.Frostbite2_0.Frostbite.AssetBank p_Bank)
        {
            var s_Dct = false;
            var s_Raw = false;
            var s_Curve = false;
            var s_Vbr = false;

            foreach (var s_Object in p_Bank.Objects)
            {
                s_Dct |= s_Object is ant.DctAnimationAsset s_D && s_D.NumKeys > 0;
                s_Raw |= s_Object is ant.RawAnimationAsset s_R && s_R.Data.Count > 0;
                s_Curve |= s_Object is ant.CurveAnimationAsset s_C && s_C.Values.Count > 0;
                s_Vbr |= s_Object is ant.VbrAnimationAsset s_V && s_V.ConstantPalette.Count > 1;
            }

            return s_Curve && s_Vbr && (s_Dct || s_Raw);
        }


        /// <summary>
        /// Writes an edit file that changes ONE value in one DCT clip and one value in one
        /// uncompressed clip, so patch_animation_bank can be run against real data in the same
        /// mount. A hand-written edit file would need every frame of every DOF typed out; deriving
        /// it from the decode is the only way the write path gets exercised on a shipped clip.
        ///
        /// The nudge is deliberately large (+0.25 on one component) so that a patch which wrote
        /// nothing, or wrote to the wrong offset, cannot hide inside quantisation error.
        /// </summary>
        private static void WriteProbe(Rimelib.Animation.Frostbite2_0.Frostbite.AssetBank p_Bank,
                                       string p_Partition, Decompressor p_Decompressor,
                                       FileInfo p_Path, TextWriter p_Writer)
        {
            var s_Clips = new List<object>();

            for (var i = 0; i < p_Bank.Objects.Count && s_Clips.Count < 1; i++)
            {
                if (p_Bank.Objects[i] is not ant.DctAnimationAsset s_Dct || s_Dct.NumKeys == 0)
                    continue;

                var s_Frames = p_Decompressor.Decode(s_Dct);

                if (s_Frames.Length == 0 || s_Frames[0].Length == 0)
                    continue;

                // A translation channel, not a quaternion: the decoder normalises quaternions, so
                // nudging one component of a quat and reading it back would compare against a
                // renormalised value and the number would be meaningless.
                var s_Dof = s_Dct.NumQuats < s_Frames[0].Length ? s_Dct.NumQuats : 0;

                var s_Rows = new List<object>();

                for (var f = 0; f < s_Frames.Length; f++)
                {
                    var s_Row = new List<object>();

                    for (var d = 0; d < s_Frames[f].Length; d++)
                    {
                        var s_Value = s_Frames[f][d];

                        if (d == s_Dof)
                            s_Value.X += 0.25f;

                        s_Row.Add(new[] { s_Value.X, s_Value.Y, s_Value.Z, s_Value.W });
                    }

                    s_Rows.Add(s_Row);
                }

                s_Clips.Add(new { index = i, dof = s_Dof, frames = s_Rows });
            }

            for (var i = 0; i < p_Bank.Objects.Count; i++)
            {
                if (p_Bank.Objects[i] is not ant.RawAnimationAsset s_Raw || s_Raw.Data.Count == 0)
                    continue;

                var s_Data = new List<float>(s_Raw.Data);
                s_Data[0] = s_Data[0] + 0.25f;

                s_Clips.Add(new { index = i, data = s_Data });
                break;
            }

            // CURV: one key of one channel, nudged. The codec stores raw float32, so the value
            // that lands has to be EXACTLY this one -- which makes it the sharpest of the four
            // probes: any rounding at all would mean the layout walk picked the wrong column.
            for (var i = 0; i < p_Bank.Objects.Count; i++)
            {
                if (p_Bank.Objects[i] is not ant.CurveAnimationAsset s_Curve
                    || s_Curve.Values.Count == 0)
                {
                    continue;
                }

                var s_Decoded = CurveCodec.Decode(s_Curve);

                if (s_Decoded.Groups.Count == 0 || s_Decoded.Groups[0].Values.Length == 0)
                    continue;

                var s_Groups = new List<object>();

                for (var g = 0; g < s_Decoded.Groups.Count; g++)
                {
                    var s_Keys = new List<object>();

                    for (var k = 0; k < s_Decoded.Groups[g].Values.Length; k++)
                    {
                        var s_Row = new List<float>(s_Decoded.Groups[g].Values[k]);

                        if (g == 0 && k == 0 && s_Row.Count > 0)
                            s_Row[0] = s_Row[0] + 0.25f;

                        s_Keys.Add(s_Row);
                    }

                    s_Groups.Add(s_Keys);
                }

                s_Clips.Add(new { index = i, groups = s_Groups });
                break;
            }

            // VBR: one CONSTANT channel component, repointed at a different palette entry. The
            // value has to be one the palette already carries, because the encoder writes an
            // index -- asking for anything else would measure the snap, not the write.
            for (var i = 0; i < p_Bank.Objects.Count; i++)
            {
                if (p_Bank.Objects[i] is not ant.VbrAnimationAsset s_Vbr
                    || s_Vbr.ConstantPalette.Count < 2)
                {
                    continue;
                }

                float[] s_Constants;

                try
                {
                    s_Constants = VbrCodec.DecodeConstants(s_Vbr);
                }
                catch (Exception)
                {
                    continue;
                }

                if (s_Constants.Length == 0)
                    continue;

                VbrCodec.RangeOf(s_Vbr, VbrCodec.KindOf(s_Vbr, 0), out var s_Min, out var s_Max);

                var s_Replacement = float.NaN;

                foreach (var s_Entry in s_Vbr.ConstantPalette)
                {
                    if (float.IsNaN(s_Entry))
                        continue;

                    var s_Value = s_Min + s_Entry * (s_Max - s_Min);

                    if (s_Value != s_Constants[0])
                    {
                        s_Replacement = s_Value;
                        break;
                    }
                }

                if (float.IsNaN(s_Replacement))
                    continue;

                var s_Edited = (float[])s_Constants.Clone();
                s_Edited[0] = s_Replacement;

                s_Clips.Add(new { index = i, constants = s_Edited });
                break;
            }

            File.WriteAllText(p_Path.FullName, JsonConvert.SerializeObject(
                new { partition = p_Partition, clips = s_Clips }, Formatting.None));

            p_Writer.WriteLine($"probe: {s_Clips.Count} clip edit(s) in {p_Partition} -> "
                               + p_Path.FullName);
        }


        /// <summary>
        /// A CURV clip decoded into groups/keys/channels and put back, compared against the bytes
        /// the game ships at the arrays' own offsets.
        ///
        /// The codec stores raw float32, so "byte-identical" here proves the LAYOUT -- that the
        /// groups concatenate, that Values is key-major and that Consts pairs with ConstOffsets --
        /// and not that a bit packer was reproduced. A layout read the wrong way round still
        /// produces the right NUMBER of floats, so a length check would pass while the encode
        /// wrote every channel into the wrong column; comparing the bytes at the recorded offset
        /// is what catches that.
        /// </summary>
        private static Dictionary<string, object?> CheckCurve(ant.CurveAnimationAsset p_Clip, int p_Index,
                                         Rimelib.Animation.Frostbite2_0.Frostbite.AssetBank p_Bank,
                                         byte[] p_Blob, ref int p_Exact, ref int p_Patchable,
                                         ref int p_KeyTimes, ref long p_TotalBytes,
                                         ref long p_IdenticalBytes)
        {
            var s_Row = new Dictionary<string, object?>
            {
                { "index", p_Index },
                { "type", "CurveAnimationAsset" },
                { "name", p_Clip.ObjectName },
                { "fps", p_Clip.FPS },
                { "numRotations", p_Clip.NumRotations },
                { "numVectors", p_Clip.NumVectors },
                { "numFloats", p_Clip.NumFloats },
                { "slots", p_Clip.NumRotations * 3 + p_Clip.NumVectors * 3 + p_Clip.NumFloats },
                { "groups", p_Clip.ChannelGroups.Count },
                { "keys", p_Clip.Keys.Count },
                { "values", p_Clip.Values.Count },
                { "consts", p_Clip.Consts.Count },
            };

            try
            {
                var s_Decoded = CurveCodec.Decode(p_Clip);
                var s_Values = CurveCodec.EncodeValues(p_Clip, s_Decoded);
                var s_Consts = CurveCodec.EncodeConsts(p_Clip, s_Decoded);

                s_Row["keyTimesAccounted"] = s_Decoded.KeyTimesAccounted;

                if (s_Decoded.KeyTimesAccounted)
                    p_KeyTimes += 1;

                // Slot coverage, as a content guard: the animated and constant slots together
                // have to add up to the header's channel count, or the decode is describing a
                // clip that is not the one in the file.
                s_Row["slotsCovered"] = s_Decoded.ConstSlots.Length
                                        + p_Clip.ChannelOffsets.Count;

                var s_Same = true;
                var s_Located = true;
                var s_Bytes = 0L;

                foreach (var s_Pair in new[]
                         {
                             ("Values", s_Values), ("Consts", s_Consts),
                         })
                {
                    if (!p_Bank.ArrayLocations.TryGetValue(p_Clip, out var s_Fields)
                        || !s_Fields.TryGetValue(s_Pair.Item1, out var s_Loc))
                    {
                        // An array of zero elements is never given a location by the parser, and
                        // a clip with no constants is a real thing rather than a failure.
                        if (s_Pair.Item2.Length == 0)
                            continue;

                        s_Located = false;
                        s_Same = false;
                        continue;
                    }

                    if (s_Loc.Count != s_Pair.Item2.Length)
                    {
                        s_Located = false;
                        s_Same = false;
                        continue;
                    }

                    var s_Encoded = FloatBytes(s_Pair.Item2, s_Loc.BigEndian);
                    p_TotalBytes += s_Encoded.Length;
                    s_Bytes += s_Encoded.Length;

                    if (s_Loc.Offset < 0 || s_Loc.Offset + s_Encoded.Length > p_Blob.Length)
                    {
                        s_Located = false;
                        s_Same = false;
                        continue;
                    }

                    var s_Match = 0;

                    for (var i = 0; i < s_Encoded.Length; i++)
                    {
                        if (p_Blob[s_Loc.Offset + i] == s_Encoded[i])
                            s_Match += 1;
                    }

                    p_IdenticalBytes += s_Match;
                    s_Row[s_Pair.Item1 + "BytesIdentical"] = s_Match;
                    s_Row[s_Pair.Item1 + "Bytes"] = s_Encoded.Length;

                    if (s_Match != s_Encoded.Length)
                    {
                        s_Same = false;
                        s_Located = false;
                    }
                }

                // A comparison of nothing is not a pass. This is not hypothetical: the first
                // version handed a float[] to a reflecting FloatBytes, compared zero bytes and
                // called all 775 clips byte-identical.
                s_Row["comparedBytes"] = s_Bytes;

                if (s_Bytes == 0 && (p_Clip.Values.Count + p_Clip.Consts.Count) > 0)
                {
                    s_Same = false;
                    s_Located = false;
                }

                s_Row["byteExact"] = s_Same;
                s_Row["patchable"] = s_Located;

                if (s_Same)
                    p_Exact += 1;

                if (s_Located)
                    p_Patchable += 1;
            }
            catch (Exception s_Ex)
            {
                s_Row["error"] = s_Ex.GetType().Name + ": " + s_Ex.Message;
            }

            return s_Row;
        }


        /// <summary>
        /// A VBR clip's SECTIONS and its constant channels, decoded and re-encoded.
        ///
        /// Two separate claims, reported separately because they are worth different things:
        ///   sections   the header's size fields account for Data exactly. This is what makes the
        ///              payload navigable at all.
        ///   constants  palette indices -> values -> palette indices reproduces Data byte for
        ///              byte, INCLUDING the frame blocks, which the encoder copies rather than
        ///              rebuilding. The bytes it actually rewrites are the constant-index ones,
        ///              and the edit probe is what separates that from a copy.
        ///
        /// The unit-quaternion count is the content guard. Constant quaternions have to come out
        /// of the palette as unit quaternions; if the section offsets or the min/max mapping were
        /// wrong the bytes would still round-trip and the values would be nonsense.
        /// </summary>
        private static Dictionary<string, object?> CheckVbr(ant.VbrAnimationAsset p_Clip, int p_Index,
                                       Rimelib.Animation.Frostbite2_0.Frostbite.AssetBank p_Bank,
                                       byte[] p_Blob, ref int p_Exact, ref int p_Patchable,
                                       ref int p_Accounted, ref long p_ConstComponents,
                                       ref long p_AnimComponents, ref int p_UnitQuats,
                                       ref int p_Quats, ref long p_Approximated,
                                       ref double p_MaxConstError, ref long p_TotalBytes,
                                       ref long p_IdenticalBytes)
        {
            var s_Row = new Dictionary<string, object?>
            {
                { "index", p_Index },
                { "type", "VbrAnimationAsset" },
                { "name", p_Clip.ObjectName },
                { "numKeys", p_Clip.NumKeys },
                { "dataBytes", p_Clip.Data.Count },
                { "blocks", p_Clip.FrameBlockSizes.Count },
                { "paletteEntries", p_Clip.ConstantPalette.Count },
            };

            try
            {
                var s_Sections = VbrCodec.Split(p_Clip);
                p_Accounted += 1;

                s_Row["sectionsAccounted"] = s_Sections.Accounted;
                s_Row["constComponents"] = s_Sections.ConstIndexCount;
                s_Row["animatedComponents"] = s_Sections.AnimatedComponents;
                s_Row["blocksAt"] = s_Sections.Blocks;

                p_ConstComponents += s_Sections.ConstIndexCount;
                p_AnimComponents += s_Sections.AnimatedComponents;

                var s_Values = VbrCodec.DecodeConstants(p_Clip);
                var s_Encoded = VbrCodec.EncodeConstants(p_Clip, s_Values, out var s_Approx,
                                                         out var s_Error);

                s_Row["approximated"] = s_Approx;
                s_Row["constValueError"] = s_Error;
                p_Approximated += s_Approx;
                p_MaxConstError = System.Math.Max(p_MaxConstError, s_Error);

                var s_Original = p_Clip.Data.ToArray();
                var s_Same = 0;
                var s_Compare = System.Math.Min(s_Encoded.Length, s_Original.Length);

                for (var i = 0; i < s_Compare; i++)
                {
                    if (s_Encoded[i] == s_Original[i])
                        s_Same += 1;
                }

                p_TotalBytes += s_Original.Length;
                p_IdenticalBytes += s_Same;

                var s_Exact = s_Encoded.Length == s_Original.Length
                              && s_Same == s_Original.Length;

                s_Row["bytesIdentical"] = s_Same;
                s_Row["byteExact"] = s_Exact;

                if (s_Exact)
                    p_Exact += 1;

                // Content: are the constant quaternions actually quaternions?
                var s_Unit = 0;

                for (var q = 0; q < p_Clip.ConstQuaternionCount; q++)
                {
                    var s_Norm = 0.0;
                    var s_Nan = false;

                    for (var k = 0; k < 4; k++)
                    {
                        var s_Value = s_Values[q * 4 + k];

                        if (float.IsNaN(s_Value))
                            s_Nan = true;

                        s_Norm += (double)s_Value * s_Value;
                    }

                    if (s_Nan)
                        continue;

                    p_Quats += 1;

                    if (System.Math.Abs(System.Math.Sqrt(s_Norm) - 1.0) < 1e-2)
                    {
                        s_Unit += 1;
                        p_UnitQuats += 1;
                    }
                }

                s_Row["constQuatsUnit"] = s_Unit;

                var s_Located = p_Bank.ArrayLocations.TryGetValue(p_Clip, out var s_Fields)
                                && s_Fields.TryGetValue("Data", out var s_Loc)
                                && s_Loc.Count == s_Original.Length
                                && s_Loc.Offset >= 0
                                && s_Loc.Offset + s_Original.Length <= p_Blob.Length
                                && Holds(p_Blob, s_Loc.Offset, s_Original);

                s_Row["patchable"] = s_Located;

                if (s_Located)
                {
                    s_Row["dataOffset"] = s_Fields!["Data"].Offset;
                    p_Patchable += 1;
                }
            }
            catch (Exception s_Ex)
            {
                s_Row["error"] = s_Ex.GetType().Name + ": " + s_Ex.Message;
            }

            return s_Row;
        }


        private static Dictionary<string, object?> CheckDct(ant.DctAnimationAsset p_Clip, int p_Index,
                                       Rimelib.Animation.Frostbite2_0.Frostbite.AssetBank p_Bank,
                                       byte[] p_Blob,
                                       Decompressor p_Decompressor, Compressor p_Compressor,
                                       ref int p_BitExact, ref int p_LengthMismatch,
                                       ref int p_HeaderOk, ref int p_Patchable,
                                       ref double p_MaxValueError,
                                       ref long p_TotalBytes, ref long p_IdenticalBytes)
        {
            var s_Original = p_Clip.Data.ToArray();
            var s_Row = new Dictionary<string, object?>
            {
                { "index", p_Index },
                { "type", "DctAnimationAsset" },
                { "name", p_Clip.ObjectName },
                { "numKeys", p_Clip.NumKeys },
                { "dofs", p_Clip.NumQuats + p_Clip.NumVec3 + p_Clip.NumFloatVec },
                // NumFloat is the count of SCALAR dofs, which the decoder does not return -- it
                // walks quats + vec3s + float-vecs only. Reported so the gap is visible rather
                // than assumed to be zero.
                { "numFloat", p_Clip.NumFloat },
                { "maxSubBlocks", MaxSubBlocks(p_Clip) },
                { "dataBytes", s_Original.Length },
            };

            try
            {
                var s_Blocks = p_Decompressor.DecodeBlocks(p_Clip, out var s_DofCount);
                var s_Encoded = p_Compressor.EncodeBlocks(p_Clip, s_Blocks, out var s_Clamped,
                                                          out var s_Natural);

                s_Row["blocks"] = s_Blocks.Count;
                s_Row["encodedBytes"] = s_Encoded.Length;
                // What the bits alone need. The shipped payload is longer -- that slack is
                // read-ahead for the bit reader and is never decoded.
                s_Row["naturalBytes"] = s_Natural;
                s_Row["shippedPadding"] = s_Original.Length - s_Natural;
                s_Row["clamped"] = s_Clamped;

                var s_Same = 0;
                var s_Compare = System.Math.Min(s_Encoded.Length, s_Original.Length);

                for (var i = 0; i < s_Compare; i++)
                {
                    if (s_Encoded[i] == s_Original[i])
                        s_Same += 1;
                }

                p_TotalBytes += s_Original.Length;
                p_IdenticalBytes += s_Same;

                var s_Exact = s_Encoded.Length == s_Original.Length && s_Same == s_Original.Length;
                s_Row["bytesIdentical"] = s_Same;
                s_Row["bitExact"] = s_Exact;

                if (s_Exact)
                    p_BitExact += 1;

                if (s_Encoded.Length != s_Original.Length)
                    p_LengthMismatch += 1;

                // The FLOAT trip, which cannot be bit-exact and is not claimed to be.
                var s_Frames = p_Decompressor.Decode(p_Clip);
                var s_Bytes = p_Compressor.Encode(p_Clip, s_Frames, out var s_Bases, out _);

                var s_Replay = new ant.DctAnimationAsset
                {
                    NumKeys = p_Clip.NumKeys,
                    NumQuats = p_Clip.NumQuats,
                    NumVec3 = p_Clip.NumVec3,
                    NumFloat = p_Clip.NumFloat,
                    NumFloatVec = p_Clip.NumFloatVec,
                    QuantizeMultBlock = p_Clip.QuantizeMultBlock,
                    QuantizeMultSubblock = p_Clip.QuantizeMultSubblock,
                    CatchAllBitCount = p_Clip.CatchAllBitCount,
                    DofTableDescBytes = p_Clip.DofTableDescBytes,
                    BitsPerSubblock = p_Clip.BitsPerSubblock,
                    DataSize = (uint)s_Bytes.Length,
                    Data = new List<byte>(s_Bytes),
                };

                // The re-encode moves the delta bases too, so the replay clip has to carry the
                // ones the encoder derived -- reading it back against the shipped bases would
                // measure a clip nobody would ever ship.
                for (var i = 0; i < s_Bases.Length; i++)
                {
                    s_Replay.DeltaBaseX.Add(s_Bases[i][0]);
                    s_Replay.DeltaBaseY.Add(s_Bases[i][1]);
                    s_Replay.DeltaBaseZ.Add(s_Bases[i][2]);
                    s_Replay.DeltaBaseW.Add(s_Bases[i][3]);
                }

                // How far the derived bases sit from the shipped ones. Decode -> transform is the
                // closed-form inverse, so this should be rounding, not drift -- a big number here
                // would mean the DC term is being misread.
                var s_BaseDrift = 0;

                for (var i = 0; i < s_Bases.Length && i < p_Clip.DeltaBaseX.Count; i++)
                {
                    s_BaseDrift = System.Math.Max(s_BaseDrift,
                        System.Math.Abs(s_Bases[i][0] - p_Clip.DeltaBaseX[i]));
                    s_BaseDrift = System.Math.Max(s_BaseDrift,
                        System.Math.Abs(s_Bases[i][1] - p_Clip.DeltaBaseY[i]));
                    s_BaseDrift = System.Math.Max(s_BaseDrift,
                        System.Math.Abs(s_Bases[i][2] - p_Clip.DeltaBaseZ[i]));
                    s_BaseDrift = System.Math.Max(s_BaseDrift,
                        System.Math.Abs(s_Bases[i][3] - p_Clip.DeltaBaseW[i]));
                }

                s_Row["deltaBaseDrift"] = s_BaseDrift;

                var s_Back = p_Decompressor.Decode(s_Replay);
                var s_Error = 0.0;

                for (var f = 0; f < s_Frames.Length && f < s_Back.Length; f++)
                {
                    for (var d = 0; d < s_Frames[f].Length && d < s_Back[f].Length; d++)
                    {
                        var s_Delta = s_Frames[f][d] - s_Back[f][d];
                        s_Error = System.Math.Max(s_Error, System.Math.Abs(s_Delta.X));
                        s_Error = System.Math.Max(s_Error, System.Math.Abs(s_Delta.Y));
                        s_Error = System.Math.Max(s_Error, System.Math.Abs(s_Delta.Z));
                        s_Error = System.Math.Max(s_Error, System.Math.Abs(s_Delta.W));
                    }
                }

                s_Row["frames"] = s_Frames.Length;
                s_Row["valueError"] = s_Error;
                p_MaxValueError = System.Math.Max(p_MaxValueError, s_Error);

                // The header writers, against this clip's own table.
                s_Row["headerRoundTrip"] = HeaderRoundTrips(p_Clip);

                if ((bool)s_Row["headerRoundTrip"]!)
                    p_HeaderOk += 1;

                // Can the new bytes actually land? Same element count means the array can be
                // overwritten where it lies and nothing else in the bank moves.
                // "Patchable" has to mean the recorded offset REALLY holds this clip's payload,
                // not merely that an offset was recorded. Offsets read out of a blob are
                // blob-relative, and a scheme that trusted them without this check writes a
                // correctly sized file into the middle of the bank's own structure.
                var s_Located = p_Bank.ArrayLocations.TryGetValue(p_Clip, out var s_Fields)
                                && s_Fields.TryGetValue("Data", out var s_Loc)
                                && s_Loc.Count == s_Original.Length
                                && s_Loc.Offset >= 0
                                && s_Loc.Offset + s_Original.Length <= p_Blob.Length
                                && Holds(p_Blob, s_Loc.Offset, s_Original);

                s_Row["patchable"] = s_Located;

                if (s_Located)
                {
                    s_Row["dataOffset"] = s_Fields!["Data"].Offset;
                    p_Patchable += 1;
                }
            }
            catch (Exception s_Ex)
            {
                s_Row["error"] = s_Ex.GetType().Name + ": " + s_Ex.Message;
            }

            return s_Row;
        }


        /// <summary>
        /// The widest per-DOF sub-block count in the clip. The decoder's cosine transform only
        /// looks at the first 8 sub-blocks of a DOF, so anything above 8 is read out of the stream
        /// and then ignored; a float-level re-encode cannot reproduce those coefficients and the
        /// number has to be visible for that limit to be checkable rather than assumed.
        /// </summary>
        /// <summary>Whether the blob already holds exactly these bytes at this offset.</summary>
        private static bool Holds(byte[] p_Blob, long p_Offset, byte[] p_Expected)
        {
            for (var i = 0; i < p_Expected.Length; i++)
            {
                if (p_Blob[p_Offset + i] != p_Expected[i])
                    return false;
            }

            return true;
        }

        /// <summary>An uncompressed clip's float keys, as the bytes the bank stores.</summary>
        private static byte[] FloatBytes(object p_Object, bool p_BigEndian)
        {
            // Reflected, and it returns EMPTY for anything without a Data property. That is the
            // trap this comment exists for: handed a float[] it compared zero bytes and every CURV
            // clip in the game reported byte-identical while nothing had been compared. The
            // float[] overload below is what the codecs use, and CheckCurve now refuses to call a
            // clip byte-exact on an empty comparison.
            if (p_Object.GetType().GetProperty("Data")?.GetValue(p_Object) is not List<float> s_Values)
                return new byte[0];

            var s_Stream = new MemoryStream();
            var s_Endianness = p_BigEndian ? IO.Conversion.Endianness.BigEndian
                                           : IO.Conversion.Endianness.LittleEndian;

            using (var s_Writer = new RimeWriter(s_Stream, s_Endianness, false))
            {
                foreach (var s_Value in s_Values)
                    s_Writer.Write(s_Value);
            }

            return s_Stream.ToArray();
        }


        /// <inheritdoc cref="FloatBytes(object, bool)"/>
        private static byte[] FloatBytes(float[] p_Values, bool p_BigEndian)
        {
            var s_Stream = new MemoryStream();
            var s_Endianness = p_BigEndian ? IO.Conversion.Endianness.BigEndian
                                           : IO.Conversion.Endianness.LittleEndian;

            using (var s_Writer = new RimeWriter(s_Stream, s_Endianness, false))
            {
                foreach (var s_Value in p_Values)
                    s_Writer.Write(s_Value);
            }

            return s_Stream.ToArray();
        }


        private static int MaxSubBlocks(ant.DctAnimationAsset p_Clip)
        {
            var s_Max = 0;

            foreach (var s_Byte in p_Clip.DofTableDescBytes)
                s_Max = System.Math.Max(s_Max, (s_Byte >> 4) & 0xF);

            return s_Max;
        }


        /// <summary>
        /// Builds the standalone Ant DCT header from the clip's splayed Frostbite fields, writes
        /// it, reads it back and compares every field. Frostbite never stores this header as a
        /// blob, so there is no shipped byte string to compare against -- what CAN be proved is
        /// that the writer and the reader agree, over 3,778 real bit-allocation tables rather than
        /// a synthetic one.
        /// </summary>
        private static bool HeaderRoundTrips(ant.DctAnimationAsset p_Clip)
        {
            var s_Table = Decompressor.BuildDofTable(p_Clip);

            var s_Header = new Header
            {
                NumFrames = p_Clip.NumKeys,
                NumQuats = p_Clip.NumQuats,
                NumVec3s = p_Clip.NumVec3,
                NumFloatVecs = p_Clip.NumFloatVec,
                QuantizeMult_Block = p_Clip.QuantizeMultBlock,
                QuantizeMult_SubBlock = p_Clip.QuantizeMultSubblock,
                CatchAllBitCount = p_Clip.CatchAllBitCount,
                Dof = s_Table,
            };

            if (!s_Header.Serialize(out var s_Bytes) || s_Bytes == null)
                return false;

            var s_Read = new Header(new RimeReader(new MemoryStream(s_Bytes)));

            if (s_Read.NumFrames != s_Header.NumFrames || s_Read.NumQuats != s_Header.NumQuats
                || s_Read.NumVec3s != s_Header.NumVec3s
                || s_Read.NumFloatVecs != s_Header.NumFloatVecs
                || s_Read.QuantizeMult_Block != s_Header.QuantizeMult_Block
                || s_Read.QuantizeMult_SubBlock != s_Header.QuantizeMult_SubBlock
                || s_Read.CatchAllBitCount != s_Header.CatchAllBitCount
                || s_Read.Dof.Length != s_Table.Length)
            {
                return false;
            }

            for (var i = 0; i < s_Table.Length; i++)
            {
                if (s_Read.Dof[i].SubBlockCount != s_Table[i].SubBlockCount)
                    return false;

                for (var j = 0; j < 4; j++)
                {
                    if (s_Read.Dof[i].DeltaBase[j] != s_Table[i].DeltaBase[j])
                        return false;
                }

                for (var j = 0; j < s_Table[i].SubBlockCount; j++)
                {
                    if (s_Read.Dof[i].BitsPerSubBlock[j].Value != s_Table[i].BitsPerSubBlock[j].Value)
                        return false;
                }
            }

            return true;
        }
    }
}
