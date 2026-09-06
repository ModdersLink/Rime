using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using RimeLib.Animation.EA.Types;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Mounting;
using RimeLib.IO;
using RimeLib.Serialization;

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

            var s_Context = (GameContext)p_Context;
            var s_Mounter = s_Context.GetMounter();

            if (!s_Mounter.TryGetPartition(Name!, out var s_PartitionObject))
            {
                p_Writer.WriteLine($"Could not find partition '{Name}'.");
                return false;
            }

            var s_Converter = EngineInterfaceRegistry.Create<IPartitionConverter>(s_Mounter.GetEngineType());
            var s_Partition = s_Converter.FromPartitionObject(Name!, s_PartitionObject.FirstVariant);

            dynamic? s_Package = null;

            foreach (var s_Instance in s_Partition.Instances)
            {
                if (s_Instance.GetType().Name == "AntPackageAsset")
                {
                    s_Package = s_Instance;
                    break;
                }
            }

            if (s_Package == null)
            {
                p_Writer.WriteLine($"Partition '{Name}' holds no AntPackageAsset.");
                return false;
            }

            // A package is stored one of two ways and both are in use. PackagingType_Chunk streams
            // a chunk named by StreamingGuid; everything else ships the bank as an AssetBank
            // RESOURCE named by Win32FileName. MEASURED over BF3's 323 antanimation partitions:
            // 88 take the chunk path and 233 leave StreamingGuid all-zero, so a chunk-only reader
            // sees barely a quarter of the game's animation.
            RimeLib.Frostbite.Core.GUID s_Guid = s_Package.StreamingGuid;
            string s_FileName = s_Package.Win32FileName;
            byte[]? s_Data = null;
            var s_Source = "chunk";

            if (s_Mounter.TryGetChunk(s_Guid, out var s_Chunk) && s_Chunk.FirstVariant != null)
            {
                using var s_ChunkReader = s_Chunk.FirstVariant.GetReader();
                s_Data = s_ChunkReader.ReadBytes((int)s_ChunkReader.Length);
            }
            else
            {
                // The AssetBank resource is named after the PARTITION, not after Win32FileName --
                // that field holds the source-tree path the package was built from and no resource
                // answers to it. Measured: 397 AssetBank resources in BF3, all named like
                // "animations/antanimations/<x>", exactly the partition names.
                foreach (var s_Candidate in new[] { Name!.ToLowerInvariant(),
                                                    s_FileName.ToLowerInvariant() })
                {
                    if (string.IsNullOrWhiteSpace(s_Candidate) ||
                        !s_Mounter.TryGetResource(s_Candidate, out var s_Res) ||
                        s_Res.FirstVariant == null)
                    {
                        continue;
                    }

                    using var s_ResReader = s_Res.FirstVariant.GetReader();
                    s_Data = s_ResReader.ReadBytes((int)s_ResReader.Length);
                    s_Source = "resource:" + s_Candidate;
                    break;
                }
            }

            if (s_Data == null)
            {
                p_Writer.WriteLine($"'{Name}' streams neither chunk {s_Guid:D} nor resource "
                                   + $"'{s_FileName}'.");
                return false;
            }

            var s_Bank = new Rimelib.Animation.Frostbite2_0.Frostbite.AssetBank();
            s_Bank.SetLocalResolver(new RimeLib.Animation.Frostbite.Resolver.LocalAssetResolver());

            string? s_LoadError = null;

            try
            {
                using var s_Reader = new RimeReader(new MemoryStream(s_Data));
                s_Bank.Load(s_Reader, s_Bank);
            }
            catch (Exception s_Ex)
            {
                s_LoadError = s_Ex.GetType().Name + ": " + s_Ex.Message;
            }

            var s_Rows = new List<object>();
            var s_ByType = new Dictionary<string, int>();
            var s_Decoded = 0;
            var s_Failed = 0;
            var s_Index = -1;

            foreach (var s_Object in s_Bank.Objects)
            {
                var s_Type = s_Object.GetType().Name;
                s_ByType[s_Type] = s_ByType.TryGetValue(s_Type, out var s_N) ? s_N + 1 : 1;
                s_Index += 1;

                var s_Row = new Dictionary<string, object?>
                {
                    { "type", s_Type },
                    { "name", TryGet(s_Object, "Name") },
                    // Position in Bank.Objects and the object's own AntGuid. Both are needed to walk
                    // the bank as a graph: AntAnimationSetAsset addresses clips by INDEX, while every
                    // IdRef inside the bank addresses by guid.
                    { "index", s_Index },
                    { "id", Id(s_Object.InstanceId) },
                    { "objectName", s_Object.ObjectName },
                };

                // The numbers a UsdSkel exporter needs, where the type carries them. Reported per
                // object rather than summarised, because a bank mixes codecs and the whole point is
                // to see which codec the clips actually use.
                foreach (var s_Field in new[]
                         {
                             "CodecType", "AnimId", "EndFrame", "Additive", "TrimOffset",
                             "NumKeys", "FloatCount", "Vec3Count", "QuatCount", "Cycle",
                             "FPS", "NumRotations", "NumVectors", "NumFloats", "StorageType",
                         })
                {
                    var s_Value = TryGet(s_Object, s_Field);

                    if (s_Value != null)
                        s_Row[char.ToLowerInvariant(s_Field[0]) + s_Field.Substring(1)] = s_Value;
                }

                foreach (var s_Field in new[] { "KeyTimes", "Data", "Values", "Keys", "IndexData" })
                {
                    var s_Value = TryGet(s_Object, s_Field);

                    if (s_Value is System.Collections.ICollection s_Collection)
                        s_Row[char.ToLowerInvariant(s_Field[0]) + s_Field.Substring(1) + "Count"] =
                            s_Collection.Count;
                }

                // Actually DECODE the clip, rather than only reporting its header. A bank that
                // parses is not a bank that yields animation: the DCT codec is a bit-packed
                // cosine transform and whether Rime's decompressor survives shipped data is a
                // separate question from whether the object model reads.
                if (s_Object is ant.DctAnimationAsset s_Dct)
                {
                    try
                    {
                        var s_Frames = new RimeLib.Animation.Frostbite2_0.EA.Compression.DCT
                            .Decompressor().Decode(s_Dct);
                        s_Row["decoded"] = true;
                        s_Row["frames"] = s_Frames.Length;
                        s_Row["dofs"] = s_Frames.Length > 0 ? s_Frames[0].Length : 0;
                        s_Decoded += 1;

                        if (Samples > 0)
                            s_Row["sample"] = Sample(s_Frames, s_Dct.NumQuats, Samples);
                    }
                    catch (Exception s_Ex)
                    {
                        s_Row["decoded"] = false;
                        s_Row["decodeError"] = s_Ex.GetType().Name + ": " + s_Ex.Message;
                        s_Failed += 1;
                    }
                }
                else if (s_Object is ant.FrameAnimationAsset s_Frame)
                {
                    // Uncompressed, one frame. Nothing to decode, so the check that matters is
                    // whether the declared channel counts account for the data the bank handed
                    // back -- and they do only at FOUR floats per Vec3, not three. MEASURED on
                    // weapons/{ak74m,sv98,xp1_l96}: 96 quats + 39 vec3 is 540 floats, and
                    // 96*4 + 39*4 == 540 exactly while 96*4 + 39*3 == 501. Same at 75 quats +
                    // 18 vec3 -> 372. The Vec3 slot is padded to a vec4, as it is in the DCT
                    // codec, which unpacks every DOF as a Vector4 whatever its kind.
                    var s_Expect = (int)(s_Frame.QuatCount * 4 + s_Frame.Vec3Count * 4
                                         + s_Frame.FloatCount);
                    s_Row["decoded"] = s_Frame.Data.Count == s_Expect;
                    s_Row["expectedFloats"] = s_Expect;

                    if (s_Frame.Data.Count == s_Expect)
                        s_Decoded += 1;
                    else
                        s_Failed += 1;

                    if (Samples > 0 && s_Frame.Data.Count >= 4)
                        s_Row["sample"] = s_Frame.Data.GetRange(0, System.Math.Min(16, s_Frame.Data.Count));
                }
                else if (s_Object is ant.CurveAnimationAsset s_Curve)
                {
                    var s_Expect = (int)s_Curve.NumRotations * 4 + s_Curve.NumVectors * 3
                                   + s_Curve.NumFloats;
                    s_Row["decoded"] = true;
                    s_Row["channelsPerKey"] = s_Expect;
                    s_Row["keysBlocks"] = s_Curve.KeysBlocks.Count;
                    s_Row["channelGroups"] = s_Curve.ChannelGroups.Count;
                    s_Row["constsCount"] = s_Curve.Consts.Count;
                    s_Decoded += 1;
                }

                Describe(s_Object, s_Row);
                s_Rows.Add(s_Row);
            }

            File.WriteAllText(Destination.FullName, JsonConvert.SerializeObject(new
            {
                partition = Name,
                chunk = s_Guid.ToString("D"),
                source = s_Source,
                chunkLength = s_Data.Length,
                loadError = s_LoadError,
                objectCount = s_Bank.Objects.Count,
                clipsDecoded = s_Decoded,
                clipsFailed = s_Failed,
                byType = s_ByType,
                animationSets = AnimationSets(s_Partition, s_Mounter),
                objects = s_Rows,
            }, Formatting.Indented));

            p_Writer.WriteLine(s_LoadError == null
                ? $"Loaded {s_Bank.Objects.Count} Ant objects from {Name}, {s_Decoded} clip(s) "
                  + $"decoded, {s_Failed} failed."
                : $"Loaded {s_Bank.Objects.Count} Ant objects from {Name}, then stopped: {s_LoadError}");

            return s_LoadError == null;
        }

        private static object Sample(System.Numerics.Vector4[][] p_Frames, int p_Quats, int p_Count)
        {
            var s_Out = new List<object>();

            for (var i = 0; i < System.Math.Min(p_Count, p_Frames.Length); ++i)
            {
                var s_Row = new List<object>();

                foreach (var s_Value in p_Frames[i])
                    s_Row.Add(new[] { s_Value.X, s_Value.Y, s_Value.Z, s_Value.W });

                s_Out.Add(new { frame = i, quats = p_Quats, values = s_Row });
            }

            return s_Out;
        }

        private static object? TryGet(object p_Object, string p_Property)
        {
            var s_Property = p_Object.GetType().GetProperty(p_Property);
            return s_Property == null ? null : s_Property.GetValue(p_Object);
        }

        /// <summary>An AntGuid as hex. The bank's own resolvers key on a 32-bit slice of it, which
        /// collides across banks; the whole 16 bytes is what actually identifies an object.</summary>
        private static string Id(AntGuid p_Guid) => Convert.ToHexString(p_Guid.Value);

        private static string? Ref(IdRefBase? p_Ref)
            => p_Ref == null || p_Ref.IsNullRef ? null : Id(p_Ref.ReferenceId);

        private static List<string?> Refs<T>(IdRefArray<T> p_Refs) where T : AntObject
        {
            var s_Out = new List<string?>();

            foreach (var s_Ref in p_Refs)
                s_Out.Add(Ref(s_Ref));

            return s_Out;
        }

        /// <summary>
        /// The objects that say what a clip's DOFs MEAN. A clip is a flat array of channels; the
        /// rig's LayoutAssets name each slot and give its type, ant.SkeletonAsset names the joints,
        /// and ClipControllerAsset says which layout a given clip is played against. Without these
        /// an exporter can only number the channels, which is why they are dumped here rather than
        /// left to a second pass -- a full mount is expensive enough that one run has to answer it.
        /// </summary>
        private static void Describe(AntObject p_Object, Dictionary<string, object?> p_Row)
        {
            switch (p_Object)
            {
                case ant.LayoutAsset s_Layout:
                {
                    var s_Slots = new List<object>();

                    foreach (var s_Slot in s_Layout.Slots)
                        s_Slots.Add(new { name = s_Slot.Name, type = s_Slot.Type });

                    p_Row["noReorder"] = s_Layout.NoReorder;
                    p_Row["minAlignment"] = s_Layout.MinAlignment;
                    p_Row["slots"] = s_Slots;
                    break;
                }

                case ant.LayoutHierarchyAsset s_Hierarchy:
                    p_Row["layoutAssets"] = Refs(s_Hierarchy.LayoutAssets);
                    p_Row["children"] = Refs(s_Hierarchy.Children);
                    break;

                case ant.SkeletonAsset s_Skeleton:
                {
                    var s_Joints = new List<object>();

                    foreach (var s_Joint in s_Skeleton.Joints)
                        s_Joints.Add(new
                        {
                            name = s_Joint.JointName,
                            parent = s_Joint.ParentIndex,
                            jointType = s_Joint.JointType,
                        });

                    p_Row["trajJointIndex"] = s_Skeleton.TrajJointIndex;
                    p_Row["joints"] = s_Joints;
                    break;
                }

                case ant.RigAsset s_Rig:
                    p_Row["skeleton"] = Ref(s_Rig.Skeleton);
                    p_Row["dofSetLists"] = Refs(s_Rig.DofSetLists);
                    p_Row["deltaTrajDofSet"] = Ref(s_Rig.DeltaTrajDofSet);
                    break;

                case ant.ClipControllerAsset s_Clip:
                    p_Row["target"] = Ref(s_Clip.Target);
                    p_Row["anim"] = Ref(s_Clip.Anim);
                    p_Row["numTicks"] = s_Clip.NumTicks;
                    p_Row["fps"] = s_Clip.FPS;
                    p_Row["deltaTrajectory"] = s_Clip.DeltaTrajectory;
                    break;

                case ant.ChannelToDofAsset s_Channels:
                    p_Row["storageType"] = s_Channels.StorageType;
                    p_Row["indexData"] = s_Channels.IndexData;
                    break;

                case ant.ActorAsset s_Actor:
                    p_Row["animatableAsset"] = Ref(s_Actor.AnimatableAsset);
                    p_Row["configAsset"] = Ref(s_Actor.ConfigAsset);
                    break;
            }

            // Every AnimationAsset can carry a channel remap; most do not, and a null here is the
            // statement that the clip's channels sit in the layout's own order.
            if (p_Object is ant.AnimationAsset s_Animation)
                p_Row["channelToDof"] = Ref(s_Animation.ChannelToDofAsset);
        }

        /// <summary>
        /// The EBX side of the binding: an AntAnimationSetAsset names the fb::SkeletonAsset the set
        /// is rigged to and lists its clips as INDICES into the bank. Reported with the skeleton's
        /// partition name resolved, because a partition guid is not something a downstream exporter
        /// can look up on its own.
        /// </summary>
        private static List<object> AnimationSets(DatabasePartitionBase p_Partition,
                                                  IEngineMounter p_Mounter)
        {
            var s_Sets = new List<object>();

            foreach (var s_Instance in p_Partition.Instances)
            {
                if (s_Instance is not fb.AntAnimationSetAsset s_Set)
                    continue;

                string? s_Skeleton = null;

                if (!s_Set.SkeletonAsset.IsNull())
                    p_Mounter.TryGetPartitionByGuid(s_Set.SkeletonAsset.PartitionGuid,
                                                    out s_Skeleton, out _);

                s_Sets.Add(new
                {
                    name = s_Set.Name,
                    skeleton = s_Skeleton,
                    skeletonPartitionGuid = s_Set.SkeletonAsset.PartitionGuid.ToString("D"),
                    actorAssetIndex = s_Set.ActorAssetIndex,
                    clipAssetIndices = s_Set.ClipAssetIndices,
                    loopingClipAssetIndices = s_Set.LoopingClipAssetIndices,
                    sceneOpMatrixAssetIndex = s_Set.SceneOpMatrixAssetIndex,
                });
            }

            return s_Sets;
        }
    }
}
