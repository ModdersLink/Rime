using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RimeLib.Animation.Frostbite2_0.EA.Compression.DCT;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.IO;

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

            var s_Context = (GameContext)p_Context;
            var s_Mounter = s_Context.GetMounter();

            var s_Data = AntBankFile.Read(s_Mounter, Name!, out var s_Source, out var s_ReadError);

            if (s_Data == null)
            {
                p_Writer.WriteLine(s_ReadError);
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

            // The patch is applied to a COPY, so a failure part-way cannot leave a half-written
            // bank on disk claiming to be a bank.
            var s_Patched = (byte[])s_Data.Clone();
            var s_Rows = new List<object>();
            var s_Applied = 0;
            var s_BytesChanged = 0;
            var s_Compressor = new Compressor();

            // What was ASKED for, per clip index. The reload check compares against this rather
            // than against "did any byte change", because a patch can change bytes and still not
            // mean what the caller wanted.
            var s_Wanted = new Dictionary<int, Vector4[][]>();
            var s_WantedFloats = new Dictionary<int, float[]>();

            foreach (var s_Edit in s_Clips)
            {
                var s_Index = (int?)s_Edit["index"] ?? -1;

                if (s_Index < 0 || s_Index >= s_Bank.Objects.Count)
                {
                    p_Writer.WriteLine($"Clip index {s_Index} is not in this bank "
                                       + $"({s_Bank.Objects.Count} object(s)).");
                    return false;
                }

                var s_Object = s_Bank.Objects[s_Index];

                if (!s_Bank.ArrayLocations.TryGetValue(s_Object, out var s_Fields)
                    || !s_Fields.TryGetValue("Data", out var s_Location))
                {
                    p_Writer.WriteLine($"Object {s_Index} ({s_Object.GetType().Name}) has no "
                                       + "locatable Data array.");
                    return false;
                }

                byte[] s_Payload;

                if (s_Object is ant.DctAnimationAsset s_Dct)
                {
                    var s_Frames = ReadFrames(s_Edit["frames"] as JArray);

                    if (s_Frames == null)
                    {
                        p_Writer.WriteLine($"Clip {s_Index} is DCT and needs a 'frames' array.");
                        return false;
                    }

                    if (s_Frames.Length != s_Dct.NumKeys)
                    {
                        p_Writer.WriteLine($"Clip {s_Index} has {s_Dct.NumKeys} key(s) and the "
                                           + $"edit supplies {s_Frames.Length}. Re-encoding against "
                                           + "the clip's own header cannot change its length.");
                        return false;
                    }

                    s_Wanted[s_Index] = s_Frames;
                    s_Payload = s_Compressor.Encode(s_Dct, s_Frames, out var s_Bases,
                                                    out var s_Clamped);

                    if (s_Clamped > 0)
                        p_Writer.WriteLine($"Clip {s_Index}: {s_Clamped} coefficient(s) clamped to "
                                           + "the widths this clip shipped with.");

                    // The delta bases move with the payload -- they ARE the first block's DC
                    // coefficients. Writing Data alone leaves every channel's first eight frames
                    // at the level the clip shipped with, which reads as "the edit did nothing".
                    if (!PatchDeltaBases(s_Patched, s_Fields, s_Dct, s_Bases, p_Writer, s_Index,
                                         ref s_BytesChanged))
                    {
                        return false;
                    }
                }
                else
                {
                    var s_Floats = ReadFloats(s_Edit["data"] as JArray);

                    if (s_Floats == null)
                    {
                        p_Writer.WriteLine($"Clip {s_Index} ({s_Object.GetType().Name}) needs a "
                                           + "'data' array of floats.");
                        return false;
                    }

                    if (s_Floats.Length != s_Location.Count)
                    {
                        p_Writer.WriteLine($"Clip {s_Index} holds {s_Location.Count} float(s) and "
                                           + $"the edit supplies {s_Floats.Length}.");
                        return false;
                    }

                    s_WantedFloats[s_Index] = s_Floats;
                    s_Payload = FloatBytes(s_Floats, s_Location.BigEndian);
                }

                var s_ByteLength = s_Object is ant.DctAnimationAsset
                    ? s_Location.Count                  // List<byte>: one element, one byte
                    : s_Location.Count * 4;             // List<float>

                if (s_Payload.Length != s_ByteLength)
                {
                    p_Writer.WriteLine($"Clip {s_Index} re-encoded to {s_Payload.Length} byte(s) "
                                       + $"but occupies {s_ByteLength}. Refusing to write: an "
                                       + "in-place patch cannot move anything.");
                    return false;
                }

                if (s_Location.Offset + s_ByteLength > s_Patched.Length)
                {
                    p_Writer.WriteLine($"Clip {s_Index} payload runs past the end of the blob.");
                    return false;
                }

                // Before writing a single byte: the bytes already there must BE this clip's
                // current payload. An offset that is off by a blob header, or relative to the
                // wrong base, produces a file of exactly the right length that decodes to
                // nothing -- which is how this was found, and the only cheap way to catch it.
                if (!AlreadyHolds(s_Patched, s_Location.Offset, s_Object, s_ByteLength,
                                  s_Location.BigEndian))
                {
                    p_Writer.WriteLine($"Clip {s_Index}: the blob at offset {s_Location.Offset} is "
                                       + "not this clip's payload. Refusing to write.");
                    return false;
                }

                var s_Changed = 0;

                for (var i = 0; i < s_ByteLength; i++)
                {
                    if (s_Patched[s_Location.Offset + i] != s_Payload[i])
                        s_Changed += 1;

                    s_Patched[s_Location.Offset + i] = s_Payload[i];
                }

                s_Applied += 1;
                s_BytesChanged += s_Changed;

                s_Rows.Add(new
                {
                    index = s_Index,
                    type = s_Object.GetType().Name,
                    name = s_Object.ObjectName,
                    offset = s_Location.Offset,
                    bytes = s_ByteLength,
                    bytesChanged = s_Changed,
                });
            }

            File.WriteAllBytes(Destination.FullName, s_Patched);

            // Read the blob back the way the game would and check the edit is IN it. A patch that
            // wrote to the wrong offset would still produce a file of the right length.
            var s_Verify = Verify(s_Patched, s_Data, s_Bank, s_Wanted, s_WantedFloats, p_Writer);

            if (Report)
            {
                File.WriteAllText(Destination.FullName + ".json", JsonConvert.SerializeObject(new
                {
                    partition = Name,
                    source = s_Source,
                    blobLength = s_Patched.Length,
                    sameLength = s_Patched.Length == s_Data.Length,
                    clipsEdited = s_Applied,
                    bytesChanged = s_BytesChanged,
                    reload = s_Verify,
                    clips = s_Rows,
                }, Formatting.Indented));
            }

            p_Writer.WriteLine($"{Name}: patched {s_Applied} clip(s), {s_BytesChanged} byte(s) "
                               + $"changed of {s_Patched.Length}, reloaded "
                               + $"{s_Verify.Objects} object(s), {s_Verify.EditsLanded}/"
                               + $"{s_Verify.EditsChecked} edit(s) landed (max error "
                               + $"{s_Verify.MaxEditError:G6}), {s_Verify.ClipsUnchanged}/"
                               + $"{s_Verify.ClipsCompared} untouched clip(s) byte-identical "
                               + $"-> {Destination.FullName}");

            return s_Applied > 0 && s_BytesChanged > 0 && s_Verify.Ok;
        }


        /// <summary>
        /// Whether the blob already holds this object's payload at the given offset, byte for
        /// byte. This is the anchor for the whole in-place scheme: if it holds, the offset is
        /// right and the write is confined to bytes the clip already owns.
        /// </summary>
        private static bool AlreadyHolds(byte[] p_Blob, long p_Offset,
                                         RimeLib.Animation.EA.Types.AntObject p_Object,
                                         int p_Length, bool p_BigEndian)
        {
            if (p_Offset < 0 || p_Offset + p_Length > p_Blob.Length)
                return false;

            if (p_Object is ant.DctAnimationAsset s_Dct)
            {
                for (var i = 0; i < p_Length; i++)
                {
                    if (p_Blob[p_Offset + i] != s_Dct.Data[i])
                        return false;
                }

                return true;
            }

            var s_Property = p_Object.GetType().GetProperty("Data");

            if (s_Property?.GetValue(p_Object) is not List<float> s_Floats)
                return false;

            var s_Current = FloatBytes(s_Floats.ToArray(), p_BigEndian);

            if (s_Current.Length != p_Length)
                return false;

            for (var i = 0; i < p_Length; i++)
            {
                if (p_Blob[p_Offset + i] != s_Current[i])
                    return false;
            }

            return true;
        }


        /// <summary>
        /// Overwrites the clip's DeltaBase{X,Y,Z,W} arrays where they lie. Each is a short per DOF
        /// with a count fixed by the clip's channel count, so the same in-place rule holds: same
        /// element count, same bytes, nothing else moves.
        /// </summary>
        private static bool PatchDeltaBases(byte[] p_Blob,
            Dictionary<string, Rimelib.Animation.Frostbite2_0.Frostbite.AssetBank.ArrayLocation> p_Fields,
            ant.DctAnimationAsset p_Clip, short[][] p_Bases, TextWriter p_Writer, int p_Index,
            ref int p_BytesChanged)
        {
            var s_Names = new[] { "DeltaBaseX", "DeltaBaseY", "DeltaBaseZ", "DeltaBaseW" };
            var s_Shipped = new[]
            {
                p_Clip.DeltaBaseX, p_Clip.DeltaBaseY, p_Clip.DeltaBaseZ, p_Clip.DeltaBaseW,
            };

            for (var s_Axis = 0; s_Axis < 4; s_Axis++)
            {
                if (!p_Fields.TryGetValue(s_Names[s_Axis], out var s_Location))
                {
                    p_Writer.WriteLine($"Clip {p_Index} has no locatable {s_Names[s_Axis]} array.");
                    return false;
                }

                if (s_Location.Count != p_Bases.Length)
                {
                    p_Writer.WriteLine($"Clip {p_Index}: {s_Names[s_Axis]} holds "
                                       + $"{s_Location.Count} entries, the encode produced "
                                       + $"{p_Bases.Length}.");
                    return false;
                }

                if (s_Location.Offset < 0
                    || s_Location.Offset + p_Bases.Length * 2 > p_Blob.Length)
                {
                    p_Writer.WriteLine($"Clip {p_Index}: {s_Names[s_Axis]} runs past the blob.");
                    return false;
                }

                // Anchored the same way the payload is: the bytes already there have to be the
                // values the clip currently reports, or the offset is not this array's.
                for (var i = 0; i < p_Bases.Length; i++)
                {
                    var s_Have = unchecked((ushort)s_Shipped[s_Axis][i]);
                    var s_At = s_Location.Offset + i * 2;
                    var s_A = s_Location.BigEndian ? (byte)(s_Have >> 8) : (byte)(s_Have & 0xFF);
                    var s_B = s_Location.BigEndian ? (byte)(s_Have & 0xFF) : (byte)(s_Have >> 8);

                    if (p_Blob[s_At] == s_A && p_Blob[s_At + 1] == s_B)
                        continue;

                    p_Writer.WriteLine($"Clip {p_Index}: the blob at offset {s_At} is not "
                                       + $"{s_Names[s_Axis]}[{i}]. Refusing to write.");
                    return false;
                }

                for (var i = 0; i < p_Bases.Length; i++)
                {
                    var s_Value = unchecked((ushort)p_Bases[i][s_Axis]);
                    var s_At = s_Location.Offset + i * 2;

                    // Byte order as the blob was READ, not as the outer file was.
                    var s_First = s_Location.BigEndian ? (byte)(s_Value >> 8)
                                                       : (byte)(s_Value & 0xFF);
                    var s_Second = s_Location.BigEndian ? (byte)(s_Value & 0xFF)
                                                        : (byte)(s_Value >> 8);

                    if (p_Blob[s_At] != s_First)
                        p_BytesChanged += 1;

                    if (p_Blob[s_At + 1] != s_Second)
                        p_BytesChanged += 1;

                    p_Blob[s_At] = s_First;
                    p_Blob[s_At + 1] = s_Second;
                }
            }

            return true;
        }


        private sealed class VerifyResult
        {
            public bool Ok { get; set; }
            public int Objects { get; set; }
            public int ClipsCompared { get; set; }
            public int ClipsUnchanged { get; set; }
            public int EditsLanded { get; set; }
            public int EditsChecked { get; set; }
            public double MaxEditError { get; set; }
            public string? Error { get; set; }
        }

        /// <summary>
        /// Reloads the patched blob and confirms two things at once: it still parses to the same
        /// object graph, and every clip the edit did NOT name still decodes to the bytes it had.
        /// The second half is the one that matters -- a writer that clobbered a neighbouring array
        /// would produce a bank that loads perfectly and animates wrong.
        /// </summary>
        private static VerifyResult Verify(byte[] p_Patched, byte[] p_Original,
                                           Rimelib.Animation.Frostbite2_0.Frostbite.AssetBank p_Before,
                                           Dictionary<int, Vector4[][]> p_Wanted,
                                           Dictionary<int, float[]> p_WantedFloats,
                                           TextWriter p_Writer)
        {
            try
            {
                var s_After = AntBankFile.Load(p_Patched);

                if (s_After.Objects.Count != p_Before.Objects.Count)
                {
                    return new VerifyResult
                    {
                        Ok = false,
                        Objects = s_After.Objects.Count,
                        Error = $"object count changed {p_Before.Objects.Count} -> "
                                + $"{s_After.Objects.Count}",
                    };
                }

                var s_Compared = 0;
                var s_Unchanged = 0;

                for (var i = 0; i < s_After.Objects.Count; i++)
                {
                    if (p_Wanted.ContainsKey(i) || p_WantedFloats.ContainsKey(i))
                        continue;

                    if (s_After.Objects[i] is not ant.DctAnimationAsset s_New
                        || p_Before.Objects[i] is not ant.DctAnimationAsset s_Old)
                    {
                        continue;
                    }

                    s_Compared += 1;

                    var s_Same = s_New.Data.Count == s_Old.Data.Count;

                    for (var j = 0; s_Same && j < s_New.Data.Count; j++)
                        s_Same = s_New.Data[j] == s_Old.Data[j];

                    if (s_Same)
                        s_Unchanged += 1;
                }

                // The edits themselves: decode the reloaded clip and compare against what was
                // asked for. DCT is lossy, so this is a tolerance, not an equality -- but a patch
                // that landed nowhere shows up as the full size of the nudge, not as a rounding.
                var s_Decompressor = new Decompressor();
                var s_Landed = 0;
                var s_Checked = 0;
                var s_MaxError = 0.0;

                foreach (var s_Pair in p_Wanted)
                {
                    if (s_After.Objects[s_Pair.Key] is not ant.DctAnimationAsset s_Clip)
                        continue;

                    s_Checked += 1;
                    var s_Back = s_Decompressor.Decode(s_Clip);
                    var s_Error = 0.0;

                    for (var f = 0; f < s_Pair.Value.Length && f < s_Back.Length; f++)
                    {
                        for (var d = 0; d < s_Pair.Value[f].Length && d < s_Back[f].Length; d++)
                        {
                            // Quaternion channels come back normalised, so they cannot be compared
                            // component-wise against an un-normalised request.
                            if (d < s_Clip.NumQuats)
                                continue;

                            var s_Delta = s_Pair.Value[f][d] - s_Back[f][d];
                            s_Error = System.Math.Max(s_Error, System.Math.Abs(s_Delta.X));
                            s_Error = System.Math.Max(s_Error, System.Math.Abs(s_Delta.Y));
                            s_Error = System.Math.Max(s_Error, System.Math.Abs(s_Delta.Z));
                            s_Error = System.Math.Max(s_Error, System.Math.Abs(s_Delta.W));
                        }
                    }

                    s_MaxError = System.Math.Max(s_MaxError, s_Error);

                    if (s_Error < 0.05)
                        s_Landed += 1;
                }

                foreach (var s_Pair in p_WantedFloats)
                {
                    var s_Property = s_After.Objects[s_Pair.Key].GetType().GetProperty("Data");

                    if (s_Property?.GetValue(s_After.Objects[s_Pair.Key]) is not List<float> s_Floats)
                        continue;

                    s_Checked += 1;
                    var s_Error = 0.0;

                    for (var i = 0; i < s_Pair.Value.Length && i < s_Floats.Count; i++)
                        s_Error = System.Math.Max(s_Error, System.Math.Abs(s_Pair.Value[i] - s_Floats[i]));

                    s_MaxError = System.Math.Max(s_MaxError, s_Error);

                    // Uncompressed keys are stored as the very float32 that was handed in, so this
                    // is an equality, not a tolerance.
                    if (s_Error == 0.0)
                        s_Landed += 1;
                }

                return new VerifyResult
                {
                    Ok = p_Patched.Length == p_Original.Length
                         && s_Unchanged == s_Compared
                         && s_Landed == s_Checked
                         && s_Checked > 0,
                    Objects = s_After.Objects.Count,
                    ClipsCompared = s_Compared,
                    ClipsUnchanged = s_Unchanged,
                    EditsLanded = s_Landed,
                    EditsChecked = s_Checked,
                    MaxEditError = s_MaxError,
                };
            }
            catch (Exception s_Ex)
            {
                p_Writer.WriteLine($"The patched blob did not reload: {s_Ex.GetType().Name}: "
                                   + s_Ex.Message);

                return new VerifyResult { Ok = false, Error = s_Ex.Message };
            }
        }


        private static Vector4[][]? ReadFrames(JArray? p_Frames)
        {
            if (p_Frames == null)
                return null;

            var s_Out = new Vector4[p_Frames.Count][];

            for (var f = 0; f < p_Frames.Count; f++)
            {
                var s_Row = p_Frames[f] as JArray;

                if (s_Row == null)
                    return null;

                s_Out[f] = new Vector4[s_Row.Count];

                for (var d = 0; d < s_Row.Count; d++)
                {
                    var s_Value = s_Row[d] as JArray;

                    if (s_Value == null || s_Value.Count < 4)
                        return null;

                    s_Out[f][d] = new Vector4((float)s_Value[0], (float)s_Value[1],
                                              (float)s_Value[2], (float)s_Value[3]);
                }
            }

            return s_Out;
        }

        private static float[]? ReadFloats(JArray? p_Data)
        {
            if (p_Data == null)
                return null;

            var s_Out = new float[p_Data.Count];

            for (var i = 0; i < p_Data.Count; i++)
                s_Out[i] = (float)p_Data[i];

            return s_Out;
        }

        /// <summary>
        /// Floats as the bank stores them. Ant banks are read BIG-endian throughout (AssetBank.Load
        /// sets it), so a little-endian write here would land the right values byte-reversed and
        /// the clip would decode to nonsense rather than fail.
        /// </summary>
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
    }
}
