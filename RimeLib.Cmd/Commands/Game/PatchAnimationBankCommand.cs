using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RimeLib.Animation.Frostbite2_0.EA.Compression.Curve;
using RimeLib.Animation.Frostbite2_0.EA.Compression.DCT;
using RimeLib.Animation.Frostbite2_0.EA.Compression.Vbr;
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
            var s_WantedCurve = new Dictionary<int, CurveCodec.Clip>();
            var s_WantedVbr = new Dictionary<int, float[]>();

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

                // Every codec ends up as the same thing: a list of (array field, replacement
                // bytes) writes. Keeping it in that shape is what let CURV and VBR join without
                // a second copy of the anchor-and-write logic -- and CURV has no Data array at
                // all, so the old "find Data or fail" opening could not have covered it.
                var s_Writes = new List<KeyValuePair<string, byte[]>>();

                if (s_Object is ant.DctAnimationAsset s_Dct)
                {
                    if (!s_Bank.ArrayLocations.TryGetValue(s_Object, out var s_DctFields))
                    {
                        p_Writer.WriteLine($"Object {s_Index} has no locatable arrays.");
                        return false;
                    }

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

                    var s_Encoded = s_Compressor.Encode(s_Dct, s_Frames, out var s_Bases,
                                                        out var s_Clamped);

                    if (s_Clamped > 0)
                        p_Writer.WriteLine($"Clip {s_Index}: {s_Clamped} coefficient(s) clamped to "
                                           + "the widths this clip shipped with.");

                    // The delta bases move with the payload -- they ARE the first block's DC
                    // coefficients. Writing Data alone leaves every channel's first eight frames
                    // at the level the clip shipped with, which reads as "the edit did nothing".
                    if (!PatchDeltaBases(s_Patched, s_DctFields, s_Dct, s_Bases, p_Writer, s_Index,
                                         ref s_BytesChanged))
                    {
                        return false;
                    }

                    s_Writes.Add(new KeyValuePair<string, byte[]>("Data", s_Encoded));
                }
                else if (s_Object is ant.CurveAnimationAsset s_Curve)
                {
                    // CURV stores raw float32 keys, so the edit is expressed the way the codec
                    // holds them: per group, per key, per channel. Flattening it here rather than
                    // accepting a flat array is deliberate -- the group/key/channel walk IS the
                    // part of the format that could be wrong, and routing the edit through it
                    // means a patch that lands proves the layout as well as the write.
                    var s_Decoded = CurveCodec.Decode(s_Curve);

                    if (!ApplyCurveEdit(s_Edit, s_Curve, s_Decoded, s_Index, p_Writer))
                        return false;

                    var s_Values = CurveCodec.EncodeValues(s_Curve, s_Decoded);
                    var s_Consts = CurveCodec.EncodeConsts(s_Curve, s_Decoded);

                    s_WantedCurve[s_Index] = s_Decoded;

                    if (s_Values.Length > 0)
                        s_Writes.Add(new KeyValuePair<string, byte[]>("Values",
                            FloatBytes(s_Values, BigEndianOf(s_Bank, s_Object, "Values"))));

                    if (s_Consts.Length > 0)
                        s_Writes.Add(new KeyValuePair<string, byte[]>("Consts",
                            FloatBytes(s_Consts, BigEndianOf(s_Bank, s_Object, "Consts"))));
                }
                else if (s_Object is ant.VbrAnimationAsset s_Vbr)
                {
                    // Only the constant channels. The per-frame blocks are not decoded, so an
                    // edit that named an animated channel would have nowhere to go; saying so is
                    // the point, and EncodeConstants rebuilds the index bytes from the VALUES
                    // rather than copying them.
                    var s_Constants = ReadFloats(s_Edit["constants"] as JArray);
                    var s_Palette = ReadFloats(s_Edit["palette"] as JArray);

                    if (s_Constants == null && s_Palette == null)
                    {
                        p_Writer.WriteLine($"Clip {s_Index} is VBR and needs a 'constants' array "
                                           + "(one float per constant channel component) or a "
                                           + "'palette' array. Its animated channels are not "
                                           + "decodable -- see docs/usd-parity.md.");
                        return false;
                    }

                    if (s_Constants != null)
                    {
                        var s_Data2 = VbrCodec.EncodeConstants(s_Vbr, s_Constants,
                                                               out var s_Approx, out var s_Err);

                        if (s_Approx > 0)
                            p_Writer.WriteLine($"Clip {s_Index}: {s_Approx} constant(s) snapped to "
                                               + $"the nearest palette entry, worst {s_Err:G6}. A "
                                               + "value off the palette needs a 'palette' edit.");

                        s_WantedVbr[s_Index] = s_Constants;
                        s_Writes.Add(new KeyValuePair<string, byte[]>("Data", s_Data2));
                    }

                    if (s_Palette != null)
                    {
                        if (s_Palette.Length != s_Vbr.ConstantPalette.Count)
                        {
                            p_Writer.WriteLine($"Clip {s_Index} holds "
                                               + $"{s_Vbr.ConstantPalette.Count} palette entry(s) "
                                               + $"and the edit supplies {s_Palette.Length}.");
                            return false;
                        }

                        s_Writes.Add(new KeyValuePair<string, byte[]>("ConstantPalette",
                            FloatBytes(s_Palette, BigEndianOf(s_Bank, s_Object, "ConstantPalette"))));
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

                    if (!s_Bank.ArrayLocations.TryGetValue(s_Object, out var s_RawFields)
                        || !s_RawFields.TryGetValue("Data", out var s_RawLocation))
                    {
                        p_Writer.WriteLine($"Object {s_Index} ({s_Object.GetType().Name}) has no "
                                           + "locatable Data array.");
                        return false;
                    }

                    if (s_Floats.Length != s_RawLocation.Count)
                    {
                        p_Writer.WriteLine($"Clip {s_Index} holds {s_RawLocation.Count} float(s) "
                                           + $"and the edit supplies {s_Floats.Length}.");
                        return false;
                    }

                    s_WantedFloats[s_Index] = s_Floats;
                    s_Writes.Add(new KeyValuePair<string, byte[]>("Data",
                        FloatBytes(s_Floats, s_RawLocation.BigEndian)));
                }

                foreach (var s_Write in s_Writes)
                {
                    if (!s_Bank.ArrayLocations.TryGetValue(s_Object, out var s_Fields)
                        || !s_Fields.TryGetValue(s_Write.Key, out var s_Location))
                    {
                        p_Writer.WriteLine($"Object {s_Index} ({s_Object.GetType().Name}) has no "
                                           + $"locatable {s_Write.Key} array.");
                        return false;
                    }

                    var s_Current = CurrentBytes(s_Object, s_Write.Key, s_Location.BigEndian);

                    if (s_Current == null || s_Current.Length != s_Write.Value.Length)
                    {
                        p_Writer.WriteLine($"Clip {s_Index}: {s_Write.Key} re-encoded to "
                                           + $"{s_Write.Value.Length} byte(s) but occupies "
                                           + $"{s_Current?.Length ?? -1}. Refusing to write: an "
                                           + "in-place patch cannot move anything.");
                        return false;
                    }

                    if (s_Location.Offset < 0
                        || s_Location.Offset + s_Current.Length > s_Patched.Length)
                    {
                        p_Writer.WriteLine($"Clip {s_Index}: {s_Write.Key} runs past the end of "
                                           + "the blob.");
                        return false;
                    }

                    // Before writing a single byte: the bytes already there must BE this array's
                    // current contents. An offset that is off by a blob header, or relative to the
                    // wrong base, produces a file of exactly the right length that decodes to
                    // nothing -- which is how this was found, and the only cheap way to catch it.
                    if (!Holds(s_Patched, s_Location.Offset, s_Current))
                    {
                        p_Writer.WriteLine($"Clip {s_Index}: the blob at offset "
                                           + $"{s_Location.Offset} is not this clip's "
                                           + $"{s_Write.Key}. Refusing to write.");
                        return false;
                    }

                    var s_Changed = 0;

                    for (var i = 0; i < s_Current.Length; i++)
                    {
                        if (s_Patched[s_Location.Offset + i] != s_Write.Value[i])
                            s_Changed += 1;

                        s_Patched[s_Location.Offset + i] = s_Write.Value[i];
                    }

                    s_BytesChanged += s_Changed;

                    s_Rows.Add(new
                    {
                        index = s_Index,
                        type = s_Object.GetType().Name,
                        name = s_Object.ObjectName,
                        field = s_Write.Key,
                        offset = s_Location.Offset,
                        bytes = s_Current.Length,
                        bytesChanged = s_Changed,
                    });
                }

                s_Applied += 1;
            }

            File.WriteAllBytes(Destination.FullName, s_Patched);

            // Read the blob back the way the game would and check the edit is IN it. A patch that
            // wrote to the wrong offset would still produce a file of the right length.
            var s_Verify = Verify(s_Patched, s_Data, s_Bank, s_Wanted, s_WantedFloats,
                                  s_WantedCurve, s_WantedVbr, p_Writer);

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


        /// <summary>Whether the blob already holds exactly these bytes at this offset. This is the
        /// anchor for the whole in-place scheme: if it holds, the offset is right and the write is
        /// confined to bytes the array already owns.</summary>
        private static bool Holds(byte[] p_Blob, long p_Offset, byte[] p_Expected)
        {
            if (p_Offset < 0 || p_Offset + p_Expected.Length > p_Blob.Length)
                return false;

            for (var i = 0; i < p_Expected.Length; i++)
            {
                if (p_Blob[p_Offset + i] != p_Expected[i])
                    return false;
            }

            return true;
        }


        /// <summary>
        /// The bytes an object's array field currently holds, in the blob's own byte order.
        ///
        /// Reflected rather than switched on the codec because the four codecs between them write
        /// byte, float and short arrays, and the anchor check has to be able to rebuild any of
        /// them -- a Values array compared as bytes would pass on a clip whose floats were written
        /// the wrong way round.
        /// </summary>
        private static byte[]? CurrentBytes(object p_Object, string p_Field, bool p_BigEndian)
        {
            var s_Value = p_Object.GetType().GetProperty(p_Field)?.GetValue(p_Object);

            if (s_Value is List<byte> s_Bytes)
                return s_Bytes.ToArray();

            if (s_Value is List<float> s_Floats)
                return FloatBytes(s_Floats.ToArray(), p_BigEndian);

            var s_Stream = new MemoryStream();
            var s_Endianness = p_BigEndian ? IO.Conversion.Endianness.BigEndian
                                           : IO.Conversion.Endianness.LittleEndian;

            if (s_Value is List<ushort> s_UShorts)
            {
                using (var s_Writer = new RimeWriter(s_Stream, s_Endianness, false))
                {
                    foreach (var s_Item in s_UShorts)
                        s_Writer.Write(s_Item);
                }

                return s_Stream.ToArray();
            }

            if (s_Value is List<short> s_Shorts)
            {
                using (var s_Writer = new RimeWriter(s_Stream, s_Endianness, false))
                {
                    foreach (var s_Item in s_Shorts)
                        s_Writer.Write(s_Item);
                }

                return s_Stream.ToArray();
            }

            return null;
        }


        /// <summary>Byte order of one array as it was READ, defaulting to the bank's own big-endian
        /// when the array has no recorded location (an empty array is never given one).</summary>
        private static bool BigEndianOf(Rimelib.Animation.Frostbite2_0.Frostbite.AssetBank p_Bank,
                                        RimeLib.Animation.EA.Types.AntObject p_Object,
                                        string p_Field)
            => !p_Bank.ArrayLocations.TryGetValue(p_Object, out var s_Fields)
               || !s_Fields.TryGetValue(p_Field, out var s_Location) || s_Location.BigEndian;


        /// <summary>
        /// Whether two parses of the same clip hold identical array contents, field for field.
        /// Used on the clips an edit did NOT name: a writer that clobbered a neighbour would
        /// produce a bank that loads perfectly and animates wrong, and only this catches it.
        /// </summary>
        private static bool ArraysEqual(RimeLib.Animation.EA.Types.AntObject p_Before,
                                        RimeLib.Animation.EA.Types.AntObject p_After)
        {
            if (p_Before.GetType() != p_After.GetType())
                return false;

            foreach (var s_Property in p_Before.GetType().GetProperties())
            {
                if (s_Property.GetValue(p_Before) is not System.Collections.IList s_A
                    || s_Property.GetValue(p_After) is not System.Collections.IList s_B)
                {
                    continue;
                }

                if (s_A.Count != s_B.Count)
                    return false;

                for (var i = 0; i < s_A.Count; i++)
                {
                    // Value types only; a list of Ant structs compares by reference and would
                    // report every clip changed, so those are skipped rather than mis-answered.
                    if (s_A[i] is not IComparable s_Left || s_B[i] is not IComparable)
                        break;

                    if (s_Left.CompareTo(s_B[i]) != 0)
                        return false;
                }
            }

            return true;
        }


        /// <summary>
        /// Applies a CURV edit onto a decoded clip. The edit names groups, keys and channels the
        /// way the codec holds them, and anything the clip does not have is refused rather than
        /// clipped -- a group count that moved is not an edit this codec can express.
        /// </summary>
        private static bool ApplyCurveEdit(JToken p_Edit, ant.CurveAnimationAsset p_Clip,
                                           CurveCodec.Clip p_Decoded, int p_Index,
                                           TextWriter p_Writer)
        {
            var s_Groups = p_Edit["groups"] as JArray;
            var s_Consts = ReadFloats(p_Edit["consts"] as JArray);

            if (s_Groups == null && s_Consts == null)
            {
                p_Writer.WriteLine($"Clip {p_Index} is CURV and needs a 'groups' array "
                                   + "([group][key][channel] floats) or a 'consts' array.");
                return false;
            }

            if (s_Groups != null)
            {
                if (s_Groups.Count != p_Decoded.Groups.Count)
                {
                    p_Writer.WriteLine($"Clip {p_Index} has {p_Decoded.Groups.Count} channel "
                                       + $"group(s) and the edit supplies {s_Groups.Count}.");
                    return false;
                }

                for (var g = 0; g < s_Groups.Count; g++)
                {
                    if (s_Groups[g] is not JArray s_Keys)
                    {
                        p_Writer.WriteLine($"Clip {p_Index} group {g} is not an array of keys.");
                        return false;
                    }

                    var s_Group = p_Decoded.Groups[g];

                    if (s_Keys.Count != s_Group.Values.Length)
                    {
                        p_Writer.WriteLine($"Clip {p_Index} group {g} has "
                                           + $"{s_Group.Values.Length} key(s) and the edit "
                                           + $"supplies {s_Keys.Count}.");
                        return false;
                    }

                    for (var k = 0; k < s_Keys.Count; k++)
                    {
                        var s_Row = ReadFloats(s_Keys[k] as JArray);

                        if (s_Row == null || s_Row.Length != s_Group.Values[k].Length)
                        {
                            p_Writer.WriteLine($"Clip {p_Index} group {g} key {k} has "
                                               + $"{s_Group.Values[k].Length} channel(s) and the "
                                               + $"edit supplies {s_Row?.Length ?? -1}.");
                            return false;
                        }

                        s_Group.Values[k] = s_Row;
                    }
                }
            }

            if (s_Consts != null)
            {
                if (s_Consts.Length != p_Decoded.Consts.Length)
                {
                    p_Writer.WriteLine($"Clip {p_Index} holds {p_Decoded.Consts.Length} "
                                       + $"constant(s) and the edit supplies {s_Consts.Length}.");
                    return false;
                }

                p_Decoded.Consts = s_Consts;
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
                                           Dictionary<int, CurveCodec.Clip> p_WantedCurve,
                                           Dictionary<int, float[]> p_WantedVbr,
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
                    if (p_Wanted.ContainsKey(i) || p_WantedFloats.ContainsKey(i)
                        || p_WantedCurve.ContainsKey(i) || p_WantedVbr.ContainsKey(i))
                    {
                        continue;
                    }

                    if (s_After.Objects[i] is not ant.AnimationAsset
                        || p_Before.Objects[i] is not ant.AnimationAsset)
                    {
                        continue;
                    }

                    // Every array the clip owns, not only a field called Data -- a CURV clip has
                    // no Data at all, and a writer that clobbered a neighbouring Values array
                    // would otherwise pass this check by having nothing compared against it.
                    s_Compared += 1;

                    if (ArraysEqual(p_Before.Objects[i], s_After.Objects[i]))
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

                // CURV: the decode of the reloaded clip has to hold the edited values EXACTLY.
                // The codec quantises nothing, so a tolerance here would only hide a miss.
                foreach (var s_Pair in p_WantedCurve)
                {
                    if (s_After.Objects[s_Pair.Key] is not ant.CurveAnimationAsset s_Clip)
                        continue;

                    s_Checked += 1;
                    var s_Back = CurveCodec.Decode(s_Clip);
                    var s_Error = 0.0;

                    for (var g = 0; g < s_Pair.Value.Groups.Count && g < s_Back.Groups.Count; g++)
                    {
                        var s_A = s_Pair.Value.Groups[g];
                        var s_B = s_Back.Groups[g];

                        for (var k = 0; k < s_A.Values.Length && k < s_B.Values.Length; k++)
                        {
                            for (var ch = 0; ch < s_A.Values[k].Length
                                             && ch < s_B.Values[k].Length; ch++)
                            {
                                s_Error = System.Math.Max(s_Error,
                                    System.Math.Abs(s_A.Values[k][ch] - s_B.Values[k][ch]));
                            }
                        }
                    }

                    for (var c = 0; c < s_Pair.Value.Consts.Length && c < s_Back.Consts.Length; c++)
                    {
                        s_Error = System.Math.Max(s_Error,
                            System.Math.Abs(s_Pair.Value.Consts[c] - s_Back.Consts[c]));
                    }

                    s_MaxError = System.Math.Max(s_MaxError, s_Error);

                    if (s_Error == 0.0)
                        s_Landed += 1;
                }

                // VBR: the constants come back through the palette, so the value that lands is
                // the nearest palette entry, not necessarily the one asked for. Compared against
                // a re-decode rather than against the request for exactly that reason.
                foreach (var s_Pair in p_WantedVbr)
                {
                    if (s_After.Objects[s_Pair.Key] is not ant.VbrAnimationAsset s_Clip)
                        continue;

                    s_Checked += 1;
                    var s_Back = VbrCodec.DecodeConstants(s_Clip);
                    var s_Error = 0.0;

                    for (var c = 0; c < s_Pair.Value.Length && c < s_Back.Length; c++)
                    {
                        if (float.IsNaN(s_Pair.Value[c]) && float.IsNaN(s_Back[c]))
                            continue;

                        s_Error = System.Math.Max(s_Error,
                            System.Math.Abs(s_Pair.Value[c] - s_Back[c]));
                    }

                    s_MaxError = System.Math.Max(s_MaxError, s_Error);

                    if (s_Error < 1e-3)
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
