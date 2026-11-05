using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json.Linq;
using RimeLib.Animation;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.IO;

namespace Rimelib.Animation.Frostbite2_0.Frostbite
{
    /// <summary>Frostbite 2 Ant banks: the AssetBank an AntPackageAsset partition streams.</summary>
    public class AnimationBankCodec : IAnimationBankCodec
    {
        public EngineType[] GetSupportedEngines() => new[] { EngineType.Frostbite2_0 };

        public string PackagePrefix => "animations/antanimations/";

        public AnimationBankReport DumpBank(IEngineMounter p_Mounter, string p_Partition, int p_Samples) =>
            AntBankDump.Dump(p_Mounter, p_Partition, p_Samples);

        public AnimationBankReport CheckCodecs(IEngineMounter p_Mounter, IReadOnlyList<string> p_Partitions, bool p_Sweep, bool p_WithEditProbe) =>
            AntCodecCheck.Check(p_Mounter, p_Partitions, p_Sweep, p_WithEditProbe);

        public AnimationBankReport DumpCodecClips(IEngineMounter p_Mounter, IReadOnlyList<string> p_Partitions, Action<string, object> p_Bank) =>
            AntCodecClips.Dump(p_Mounter, p_Partitions, p_Bank);

        public AnimationBankReport Patch(IEngineMounter p_Mounter, string p_Partition, string p_EditsJson, TextWriter p_Log)
        {
            var s_Data = AntBankFile.Read(p_Mounter, p_Partition, out var s_Source, out var s_ReadError);

            if (s_Data == null)
                return new AnimationBankReport { Message = s_ReadError ?? $"No bank for {p_Partition}." };

            var s_Bank = AntBankFile.Load(s_Data);
            var s_Clips = JObject.Parse(p_EditsJson)["clips"] as JArray;

            if (s_Clips == null || s_Clips.Count == 0)
            {
                return new AnimationBankReport
                {
                    Message = "The edit file names no clips. Refusing to write a blob that changes nothing -- "
                              + "an untouched bank should keep referencing the game's own resource.",
                };
            }

            var s_Result = AntBankPatcher.Patch(s_Data, s_Bank, s_Clips, p_Log);
            if (s_Result == null)
                return new AnimationBankReport { Message = $"{p_Partition}: no edit applied." };

            var s_Patched = s_Result.Patched;
            var s_Verify = s_Result.Verify;

            return new AnimationBankReport
            {
                Bank = s_Patched,
                Succeeded = s_Result.Applied > 0 && s_Result.BytesChanged > 0 && s_Verify.Ok,
                Report = new
                {
                    partition = p_Partition,
                    source = s_Source,
                    blobLength = s_Patched.Length,
                    sameLength = s_Patched.Length == s_Data.Length,
                    clipsEdited = s_Result.Applied,
                    bytesChanged = s_Result.BytesChanged,
                    reload = s_Verify,
                    clips = s_Result.Rows,
                },
                Message = $"{p_Partition}: patched {s_Result.Applied} clip(s), {s_Result.BytesChanged} byte(s) "
                          + $"changed of {s_Patched.Length}, reloaded "
                          + $"{s_Verify.Objects} object(s), {s_Verify.EditsLanded}/"
                          + $"{s_Verify.EditsChecked} edit(s) landed (max error "
                          + $"{s_Verify.MaxEditError:G6}), {s_Verify.ClipsUnchanged}/"
                          + $"{s_Verify.ClipsCompared} untouched clip(s) byte-identical",
            };
        }

        public IReadOnlyCollection<string>? ReadNames(IEngineMounter p_Mounter, string p_Partition, out long p_Objects, out string? p_Error)
        {
            p_Objects = 0;
            var s_Blob = AntBankFile.Read(p_Mounter, p_Partition, out _, out p_Error);

            if (s_Blob == null)
            {
                p_Error ??= "no bank blob";
                return null;
            }

            var s_Bank = new AssetBank();
            s_Bank.SetLocalResolver(new RimeLib.Animation.Frostbite.Resolver.LocalAssetResolver());

            using (var s_BankReader = new RimeReader(new MemoryStream(s_Blob)))
                s_Bank.Load(s_BankReader, s_Bank);

            var s_Names = new HashSet<string>(StringComparer.Ordinal);

            foreach (var s_Object in s_Bank.Objects)
            {
                p_Objects++;

                Add(s_Names, s_Object.ObjectName);
                Add(s_Names, s_Object.GetType().GetProperty("Name")?.GetValue(s_Object) as string);

                if (s_Object is ant.LayoutAsset s_Layout)
                {
                    foreach (var s_Slot in s_Layout.Slots)
                        Add(s_Names, s_Slot.Name);
                }
                else if (s_Object is ant.SkeletonAsset s_Skeleton)
                {
                    foreach (var s_Joint in s_Skeleton.Joints)
                        Add(s_Names, s_Joint.JointName);
                }
            }

            return s_Names;
        }

        private static void Add(HashSet<string> p_Set, string? p_Value)
        {
            if (!string.IsNullOrEmpty(p_Value))
                p_Set.Add(p_Value);
        }
    }
}
