using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.Game
{
    /// <summary>
    /// Dumps every VBR and CURV clip the game ships, header fields and raw payload alike, so the
    /// two codecs that have no decoder can be reverse-engineered OFFLINE.
    ///
    /// It sweeps the mounted partitions itself rather than taking one name, because a full BF3
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

        [CommandArgument(Description = "Partition name prefix. Default animations/antanimations/", Optional = true)]
        public string Prefix { get; set; } = "animations/antanimations/";

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

            var s_Names = s_Context.GetMountedPartitions()
                .Where(x => x.StartsWith(Prefix, StringComparison.OrdinalIgnoreCase))
                .OrderBy(x => x, StringComparer.Ordinal)
                .ToList();

            var s_Banks = 0;
            var s_Vbr = 0;
            var s_Curve = 0;
            var s_Failed = 0;

            foreach (var s_Name in s_Names)
            {
                var s_Data = AntBankFile.Read(s_Mounter, s_Name, out var s_Source, out _);

                if (s_Data == null)
                    continue;

                Rimelib.Animation.Frostbite2_0.Frostbite.AssetBank s_Bank;

                try
                {
                    s_Bank = AntBankFile.Load(s_Data);
                }
                catch (Exception)
                {
                    s_Failed += 1;
                    continue;
                }

                var s_Clips = new List<object>();
                var s_Index = -1;

                foreach (var s_Object in s_Bank.Objects)
                {
                    s_Index += 1;

                    if (s_Object is ant.VbrAnimationAsset s_VbrClip)
                    {
                        s_Vbr += 1;
                        s_Clips.Add(Vbr(s_VbrClip, s_Index, s_Bank));
                    }
                    else if (s_Object is ant.CurveAnimationAsset s_CurveClip)
                    {
                        s_Curve += 1;
                        s_Clips.Add(Curve(s_CurveClip, s_Index, s_Bank));
                    }
                }

                if (s_Clips.Count == 0)
                    continue;

                s_Banks += 1;

                var s_File = Path.Combine(Destination.FullName,
                                          s_Name.Replace('/', '_') + ".json");

                File.WriteAllText(s_File, JsonConvert.SerializeObject(new
                {
                    partition = s_Name,
                    source = s_Source,
                    blobLength = s_Data.Length,
                    objectCount = s_Bank.Objects.Count,
                    clips = s_Clips,
                }, Formatting.None));
            }

            p_Writer.WriteLine($"dump_anim_codec_clips: {s_Banks} bank(s) with clips, {s_Vbr} VBR, "
                               + $"{s_Curve} CURV, {s_Failed} bank(s) failed to parse, over "
                               + $"{s_Names.Count} partition(s) -> {Destination.FullName}");

            return s_Vbr + s_Curve > 0;
        }


        private static Dictionary<string, object?> Common(
            ant.AnimationAsset p_Clip, int p_Index,
            Rimelib.Animation.Frostbite2_0.Frostbite.AssetBank p_Bank)
        {
            var s_Row = new Dictionary<string, object?>
            {
                { "index", p_Index },
                { "type", p_Clip.GetType().Name },
                { "name", p_Clip.ObjectName },
                { "codecType", p_Clip.CodecType },
                { "animId", p_Clip.AnimId },
                { "endFrame", p_Clip.EndFrame },
                { "additive", p_Clip.Additive },
                { "trimOffset", p_Clip.TrimOffset },
            };

            // Where each array actually sits in the blob. An in-place write needs this, and so
            // does any claim that the payload was FOUND rather than merely parsed.
            if (p_Bank.ArrayLocations.TryGetValue(p_Clip, out var s_Fields))
            {
                var s_Locations = new Dictionary<string, object>();

                foreach (var s_Pair in s_Fields)
                {
                    s_Locations[s_Pair.Key] = new
                    {
                        offset = s_Pair.Value.Offset,
                        count = s_Pair.Value.Count,
                        bigEndian = s_Pair.Value.BigEndian,
                    };
                }

                s_Row["arrays"] = s_Locations;
            }

            return s_Row;
        }


        private static object Vbr(ant.VbrAnimationAsset p_Clip, int p_Index,
                                  Rimelib.Animation.Frostbite2_0.Frostbite.AssetBank p_Bank)
        {
            var s_Row = Common(p_Clip, p_Index, p_Bank);

            s_Row["quatMin"] = p_Clip.QuatMin;
            s_Row["quatMax"] = p_Clip.QuatMax;
            s_Row["trajMin"] = p_Clip.TrajMin;
            s_Row["trajMax"] = p_Clip.TrajMax;
            s_Row["vec3Min"] = p_Clip.Vec3Min;
            s_Row["vec3Max"] = p_Clip.Vec3Max;
            s_Row["floatMin"] = p_Clip.FloatMin;
            s_Row["floatMax"] = p_Clip.FloatMax;
            s_Row["vectorOffsetScale"] = p_Clip.VectorOffsetScale;
            s_Row["floatOffsetScale"] = p_Clip.FloatOffsetScale;
            s_Row["dct"] = p_Clip.Dct;
            s_Row["quaternionCount"] = p_Clip.QuaternionCount;
            s_Row["vector3Count"] = p_Clip.Vector3Count;
            s_Row["floatCount"] = p_Clip.FloatCount;
            s_Row["constQuaternionCount"] = p_Clip.ConstQuaternionCount;
            s_Row["constVector3Count"] = p_Clip.ConstVector3Count;
            s_Row["constFloatCount"] = p_Clip.ConstFloatCount;
            s_Row["keyTimeSize"] = p_Clip.KeyTimeSize;
            s_Row["numKeys"] = p_Clip.NumKeys;
            s_Row["constChanMapSize"] = p_Clip.ConstChanMapSize;
            s_Row["constPaletteSize"] = p_Clip.ConstPaletteSize;
            s_Row["vectorOffsetSize"] = p_Clip.VectorOffsetSize;
            s_Row["floatOffsetSize"] = p_Clip.FloatOffsetSize;
            s_Row["flags"] = p_Clip.Flags;
            s_Row["constantPalette"] = p_Clip.ConstantPalette;
            s_Row["frameBlockSizes"] = p_Clip.FrameBlockSizes;
            s_Row["dataLength"] = p_Clip.Data.Count;
            s_Row["data"] = Convert.ToBase64String(p_Clip.Data.ToArray());

            return s_Row;
        }


        private static object Curve(ant.CurveAnimationAsset p_Clip, int p_Index,
                                    Rimelib.Animation.Frostbite2_0.Frostbite.AssetBank p_Bank)
        {
            var s_Row = Common(p_Clip, p_Index, p_Bank);

            s_Row["fps"] = p_Clip.FPS;
            s_Row["numRotations"] = p_Clip.NumRotations;
            s_Row["numVectors"] = p_Clip.NumVectors;
            s_Row["numFloats"] = p_Clip.NumFloats;
            s_Row["values"] = p_Clip.Values;
            s_Row["keys"] = p_Clip.Keys;
            s_Row["consts"] = p_Clip.Consts;
            s_Row["constOffsets"] = p_Clip.ConstOffsets;
            s_Row["channelOffsets"] = p_Clip.ChannelOffsets;
            s_Row["keysBlocks"] = p_Clip.KeysBlocks
                .Select(x => new { numChannelGroups = x.NumChannelGroups, keysCount = x.KeysCount })
                .ToList();
            s_Row["channelGroups"] = p_Clip.ChannelGroups
                .Select(x => new { numKeys = x.NumKeys, numChannels = x.NumChannels })
                .ToList();

            return s_Row;
        }
    }
}
