using RimeLib;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    [CommandDescription("Clones a mounted EBX partition under a new name with FRESH guids: every guid in the partition (its PartitionGuid and each instance guid) is replaced by a new random guid, consistently (so internal references stay valid). Use this to make a fresh WaterAsset (or any partition) that the engine treats as a NEW one instead of falling back to the already-loaded vanilla. Optionally same-length-rewrites an internal string (e.g. WaterAsset.Name -> the raised Havok's fresh name). Prints the fresh primary guid (= for a WaterEntityData.asset redirect). Add it with the printed guid; no Python.")]
    internal class ClonePartitionFreshCommand : Command
    {
        [CommandArgument(Description = "The name of the partition to clone (must exist in a mounted game).")]
        public string? OrigName { get; set; }

        [CommandArgument(Description = "Id returned by mount_game.")]
        public int Id { get; set; }

        [CommandArgument(Description = "The name to add the cloned partition under (the bundle key).")]
        public string? NewName { get; set; }

        [CommandArgument(Description = "Optional: an internal ASCII string to rewrite (e.g. the vanilla WaterAsset.Name).", Optional = true)]
        public string? OldString { get; set; }

        [CommandArgument(Description = "Optional: its replacement (MUST be the same length as OldString).", Optional = true)]
        public string? NewString { get; set; }

        [CommandArgument(Description = "Optional: a float32 value to find in the partition (e.g. the vanilla LakeData Y = 67).", Optional = true)]
        public float OldFloat { get; set; } = float.NaN;

        [CommandArgument(Description = "Optional: its replacement (e.g. raise the LakeData Y to 90 so the fresh WaterAsset's water region is high enough for swim/buoyancy to settle at the Havok height).", Optional = true)]
        public float NewFloat { get; set; } = float.NaN;

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (string.IsNullOrWhiteSpace(OrigName) || string.IsNullOrWhiteSpace(NewName))
            {
                p_Writer.WriteLine("orig_name and new_name are required.");
                return false;
            }

            var s_BundleContext = (BundleBuildingContext)p_Context;
            var s_SbBuildingContext = (SbBuildingContext?)s_BundleContext.Parent;
            var s_BaseContext = s_SbBuildingContext?.Parent as BaseContext;
            if (s_SbBuildingContext == null || s_BaseContext == null)
            {
                p_Writer.WriteLine("Context is invalid.");
                return false;
            }

            if (!s_BaseContext.GetMounters().TryGetValue(Id, out var s_EngineMounter))
            {
                p_Writer.WriteLine($"Id ({Id}) is not valid, ensure you mounted a game first");
                return false;
            }

            if (!s_EngineMounter.TryGetPartition(OrigName!, out var s_Mounted))
            {
                p_Writer.WriteLine($"Could not find partition ({OrigName}).");
                return false;
            }

            // Accept any bundle-contained variant (inline or catalog) so DLC partitions, which are
            // often non-cas-only, work in a cas build too.
            var s_Variant = s_Mounted.Variants.FirstOrDefault(p_V => p_V.GetContainedBundle() != null)
                            ?? s_Mounted.FirstVariant;
            if (s_Variant == null)
            {
                p_Writer.WriteLine($"Could not find a valid variant of ({OrigName}).");
                return false;
            }

            // Parse the partition through the engine interface (no direct EbxReader dependency)
            // to enumerate its guids: the PartitionGuid + every instance guid.
            var s_Converter = EngineInterfaceRegistry.Create<IPartitionConverter>(s_SbBuildingContext.EngineType);
            var s_Db = s_Converter.FromPartitionObject(OrigName!, s_Variant);

            var s_Remaps = new List<(byte[] Old, GUID New)>();
            var s_Seen = new HashSet<string>();
            void AddGuid(GUID p_Guid)
            {
                var s_Key = Convert.ToHexString(p_Guid.Id);
                if (s_Seen.Add(s_Key))
                    s_Remaps.Add((p_Guid.Id, new GUID(Guid.NewGuid())));
            }

            AddGuid(s_Db.PartitionGuid);              // index 0 = the partition (== primary) guid
            foreach (var s_Instance in s_Db.Instances)
                if (s_Instance.InstanceId is DataContainerId.Guid s_Ig)
                    AddGuid(s_Ig.Id);

            var s_NewPrimary = s_Remaps[0].New;

            // Read the raw bytes and apply the guid remaps (16-byte little-endian sequences).
            byte[] s_Bytes;
            using (var s_Reader = s_Variant.GetReader())
                s_Bytes = s_Reader.ReadBytes((int)s_Reader.Length);

            var s_TotalReplaced = 0;
            foreach (var (s_Old, s_New) in s_Remaps)
                s_TotalReplaced += ReplaceAll(s_Bytes, s_Old, s_New.Id);

            // Optional same-length internal string rewrite (e.g. WaterAsset.Name).
            if (!string.IsNullOrEmpty(OldString) || !string.IsNullOrEmpty(NewString))
            {
                if (OldString == null || NewString == null || OldString.Length != NewString.Length)
                {
                    p_Writer.WriteLine("old_string and new_string must both be given and be the SAME length.");
                    return false;
                }
                var s_StrReplaced = ReplaceAll(s_Bytes, Encoding.ASCII.GetBytes(OldString), Encoding.ASCII.GetBytes(NewString));
                if (s_StrReplaced == 0)
                    p_Writer.WriteLine($"WARNING: internal string '{OldString}' not found (nothing rewritten).");
            }

            // Optional float32 value rewrite (e.g. raise the OCEAN LakeData Point Ys). Matched
            // APPROXIMATELY (4-aligned, within an epsilon) so it's robust to float precision and
            // only the ocean level is hit (pools sit at other Ys, far outside the epsilon).
            if (!float.IsNaN(OldFloat) && !float.IsNaN(NewFloat))
            {
                var s_NewBytes = BitConverter.GetBytes(NewFloat);
                var s_FloatReplaced = 0;
                for (var i = 0; i + 4 <= s_Bytes.Length; i += 4)
                {
                    var s_F = BitConverter.ToSingle(s_Bytes, i);
                    if (!float.IsNaN(s_F) && System.Math.Abs(s_F - OldFloat) <= 0.05f)
                    {
                        Array.Copy(s_NewBytes, 0, s_Bytes, i, 4);
                        s_FloatReplaced++;
                    }
                }
                p_Writer.WriteLine($"Replaced {s_FloatReplaced} float(s) ~{OldFloat} -> {NewFloat}.");
            }

            s_BundleContext.AddRawPartitionBytes(NewName!, s_Bytes);

            p_Writer.WriteLine($"Cloned '{OrigName}' -> '{NewName}' with {s_Remaps.Count} fresh guid(s) ({s_TotalReplaced} refs remapped).");
            p_Writer.WriteLine($"Fresh primary/partition guid: {s_NewPrimary}");
            return true;
        }

        private static int ReplaceAll(byte[] p_Data, byte[] p_Find, byte[] p_Repl)
        {
            if (p_Find.Length != p_Repl.Length || p_Find.Length == 0) return 0;
            var s_Count = 0;
            for (var i = 0; i <= p_Data.Length - p_Find.Length; ++i)
            {
                var s_Match = true;
                for (var j = 0; j < p_Find.Length; ++j)
                    if (p_Data[i + j] != p_Find[j]) { s_Match = false; break; }
                if (!s_Match) continue;
                Array.Copy(p_Repl, 0, p_Data, i, p_Repl.Length);
                s_Count++;
                i += p_Find.Length - 1;
            }
            return s_Count;
        }
    }
}
