using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
using Newtonsoft.Json;
using RimeLib.Animation.EA.Compression.DCT;
using RimeLib.Animation.Frostbite2_0.EA.Compression.DCT;
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
        [CommandArgument(Description = "The AntPackageAsset partition, e.g. animations/antanimations/ak74")]
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

            var s_Data = AntBankFile.Read(s_Mounter, Name!, out var s_Source, out var s_ReadError);

            if (s_Data == null)
            {
                p_Writer.WriteLine(s_ReadError);
                return false;
            }

            Rimelib.Animation.Frostbite2_0.Frostbite.AssetBank s_Bank;

            try
            {
                s_Bank = AntBankFile.Load(s_Data);
            }
            catch (Exception s_Ex)
            {
                p_Writer.WriteLine($"'{Name}' did not parse: {s_Ex.GetType().Name}: {s_Ex.Message}");
                return false;
            }

            var s_Rows = new List<object>();
            var s_Decompressor = new Decompressor();
            var s_Compressor = new Compressor();

            var s_Dct = 0;
            var s_BitExact = 0;
            var s_LengthMismatch = 0;
            var s_HeaderOk = 0;
            var s_Patchable = 0;
            var s_Raw = 0;
            var s_RawPatchable = 0;
            var s_MaxValueError = 0.0;
            var s_TotalBytes = 0L;
            var s_IdenticalBytes = 0L;
            var s_Index = -1;

            foreach (var s_Object in s_Bank.Objects)
            {
                s_Index += 1;

                if (s_Object is ant.DctAnimationAsset s_Clip)
                {
                    s_Dct += 1;
                    s_Rows.Add(CheckDct(s_Clip, s_Index, s_Bank, s_Data, s_Decompressor, s_Compressor,
                                        ref s_BitExact, ref s_LengthMismatch, ref s_HeaderOk,
                                        ref s_Patchable, ref s_MaxValueError,
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

                    s_Rows.Add(new
                    {
                        index = s_Index,
                        type = s_Object.GetType().Name,
                        name = s_Object.ObjectName,
                        patchable = s_Located,
                        dataOffset = s_Located ? s_Fields![ "Data" ].Offset : -1,
                        dataCount = s_Located ? s_Fields!["Data"].Count : 0,
                        bigEndian = s_Located && s_Fields!["Data"].BigEndian,
                    });
                }
            }

            if (EditProbe != null)
                WriteProbe(s_Bank, s_Decompressor, EditProbe, p_Writer);

            File.WriteAllText(Destination.FullName, JsonConvert.SerializeObject(new
            {
                partition = Name,
                source = s_Source,
                blobLength = s_Data.Length,
                objectCount = s_Bank.Objects.Count,
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
                clips = s_Rows,
            }, Formatting.Indented));

            p_Writer.WriteLine($"{Name}: {s_BitExact}/{s_Dct} DCT clip(s) re-encode byte-identical "
                               + $"({s_IdenticalBytes}/{s_TotalBytes} payload byte(s)), "
                               + $"{s_HeaderOk}/{s_Dct} header(s) round-trip, "
                               + $"max value error {s_MaxValueError:G6}, "
                               + $"{s_RawPatchable}/{s_Raw} uncompressed clip(s) patchable.");

            return s_Dct + s_Raw > 0 && s_BitExact == s_Dct && s_RawPatchable == s_Raw;
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
                                       Decompressor p_Decompressor, FileInfo p_Path,
                                       TextWriter p_Writer)
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

            File.WriteAllText(p_Path.FullName,
                              JsonConvert.SerializeObject(new { clips = s_Clips }, Formatting.None));

            p_Writer.WriteLine($"probe: {s_Clips.Count} clip edit(s) -> {p_Path.FullName}");
        }


        private static object CheckDct(ant.DctAnimationAsset p_Clip, int p_Index,
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

        /// <summary>An uncompressed clip's float keys, as the big-endian bytes the bank stores.</summary>
        private static byte[] FloatBytes(object p_Object, bool p_BigEndian)
        {
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
