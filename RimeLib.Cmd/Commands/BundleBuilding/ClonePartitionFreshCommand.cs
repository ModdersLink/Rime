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
    [CommandDescription("Clones a mounted EBX partition under a new name with fresh guids, remapped consistently so its internal refs stay valid, and prints the new primary guid.")]
    internal class ClonePartitionFreshCommand : Command
    {
        // Fresh guids are what make the engine treat the clone as a new partition rather than falling
        // back to the vanilla one it has already loaded. Feed the printed primary guid to whatever
        // needs to reference the clone.
        [CommandArgument(Description = "The name of the partition to clone (must exist in a mounted game).")]
        public string? OrigName { get; set; }

        [CommandArgument(Description = "Id returned by mount_game.")]
        public int Id { get; set; }

        [CommandArgument(Description = "The name to add the cloned partition under (the bundle key).")]
        public string? NewName { get; set; }

        [CommandArgument(Description = "An internal ASCII string to rewrite, e.g. the vanilla WaterAsset.Name.", Optional = true)]
        public string? OldString { get; set; }

        [CommandArgument(Description = "Its replacement, which must be the same length as OldString.", Optional = true)]
        public string? NewString { get; set; }

        [CommandArgument(Description = "A float32 value to find in the partition, e.g. the vanilla LakeData Y.", Optional = true)]
        public float OldFloat { get; set; } = float.NaN;

        [CommandArgument(Description = "Its replacement.", Optional = true)]
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

            // Accept any bundle-contained variant, inline or catalog, so the often non-cas-only DLC
            // partitions work in a cas build too.
            var s_Variant = s_Mounted.Variants.FirstOrDefault(p_V => p_V.GetContainedBundle() != null)
                            ?? s_Mounted.FirstVariant;
            if (s_Variant == null)
            {
                p_Writer.WriteLine($"Could not find a valid variant of ({OrigName}).");
                return false;
            }

            // Parse through the engine interface to enumerate the partition's guids.
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

            AddGuid(s_Db.PartitionGuid);
            var s_NewPrimary = s_Remaps[0].New;

            foreach (var s_Instance in s_Db.Instances)
                if (s_Instance.InstanceId is DataContainerId.Guid s_Ig)
                    AddGuid(s_Ig.Id);

            // Read the raw bytes and apply the guid remaps (16-byte little-endian sequences).
            byte[] s_Bytes;
            using (var s_Reader = s_Variant.GetReader())
                s_Bytes = s_Reader.ReadBytes((int)s_Reader.Length);

            var s_TotalReplaced = 0;
            foreach (var (s_Old, s_New) in s_Remaps)
                s_TotalReplaced += ReplaceAll(s_Bytes, s_Old, s_New.Id);

            if (!string.IsNullOrEmpty(OldString) || !string.IsNullOrEmpty(NewString))
            {
                if (OldString == null || NewString == null || OldString.Length != NewString.Length)
                {
                    p_Writer.WriteLine("old_string and new_string must both be given and be the same length.");
                    return false;
                }

                var s_StringsReplaced = ReplaceAll(s_Bytes, Encoding.ASCII.GetBytes(OldString), Encoding.ASCII.GetBytes(NewString));
                if (s_StringsReplaced == 0)
                    p_Writer.WriteLine($"WARNING: internal string '{OldString}' not found, nothing rewritten.");
            }

            // Matched within an epsilon on 4-byte alignment, so float precision doesn't matter and
            // values that are merely close to the target are left alone.
            if (!float.IsNaN(OldFloat) && !float.IsNaN(NewFloat))
            {
                var s_NewBytes = BitConverter.GetBytes(NewFloat);
                var s_FloatsReplaced = 0;
                for (var i = 0; i + 4 <= s_Bytes.Length; i += 4)
                {
                    var s_Value = BitConverter.ToSingle(s_Bytes, i);
                    if (!float.IsNaN(s_Value) && System.Math.Abs(s_Value - OldFloat) <= 0.05f)
                    {
                        Array.Copy(s_NewBytes, 0, s_Bytes, i, 4);
                        s_FloatsReplaced++;
                    }
                }

                p_Writer.WriteLine($"Replaced {s_FloatsReplaced} float(s) near {OldFloat} with {NewFloat}.");
            }

            s_BundleContext.AddRawPartitionBytes(NewName!, s_Bytes);

            p_Writer.WriteLine($"Cloned '{OrigName}' as '{NewName}' with {s_Remaps.Count} fresh guid(s) ({s_TotalReplaced} refs remapped).");
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
