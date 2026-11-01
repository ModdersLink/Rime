using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Serialization;

namespace RimeLib.Cmd.Commands.Game
{
    /// <summary>
    /// Derives a level partition's registries with the engine's registry rules and compares them with
    /// the shipped ones, entry by entry.
    /// </summary>
    [CommandDescription("Derives the registries of a level partition (LevelData or SubWorldData) and compares them with the shipped registries.")]
    public class DeriveRegistryCommand : Command
    {
        [CommandArgument(Description = "The level partition, e.g. levels/mp_subway/rush.")]
        public string? Partition { get; set; }

        [CommandArgument(Description = "Where to write the JSON report of every missing and extra entry.", Optional = true)]
        public FileInfo? Destination { get; set; }

        [CommandArgument(Description = "Network registry partition to compare with when the registries are not embedded (BF4). Default: <partition>_networkregistry_win32.", Optional = true)]
        public string? RegistryPartition { get; set; }

        private RegistryDeriver m_Deriver = null!;

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (string.IsNullOrWhiteSpace(Partition))
            {
                p_Writer.WriteLine("usage: derive_registry <partition> [destination.json] [registry_partition]");
                return false;
            }

            var s_Mounter = ((GameContext)p_Context).GetMounter();
            var s_Root = Partition!.ToLowerInvariant();
            if (!s_Mounter.TryGetPartition(s_Root, out _))
            {
                p_Writer.WriteLine($"No partition named '{Partition}'.");
                return false;
            }

            m_Deriver = new RegistryDeriver(s_Mounter);
            var s_Result = m_Deriver.Derive(s_Root, RegistryPartition, p_Writer);
            var s_Closure = s_Result.Closure;
            if (s_Closure.Registries.Count == 0)
            {
                p_Writer.WriteLine($"No registry found for {s_Root}.");
                return false;
            }

            var s_Report = new List<object>();
            foreach (var (s_Kind, s_Entries) in s_Closure.Registries)
            {
                var s_Shipped = s_Entries.Select(p_E => m_Deriver.Key(p_E.PartitionGuid, p_E.InstanceId)).ToList();
                var s_Ours = s_Result.Entries.GetValueOrDefault(s_Kind) ?? new List<string>();
                var s_ShippedSet = s_Shipped.ToHashSet();
                var s_OursSet = s_Ours.ToHashSet();

                var s_Missing = s_Shipped.Where(p_K => !s_OursSet.Contains(p_K)).Distinct().Select(Describe).ToList();
                var s_Extra = s_Ours.Where(p_K => !s_ShippedSet.Contains(p_K)).Select(Describe).ToList();

                p_Writer.WriteLine();
                p_Writer.WriteLine($"--- {s_Kind}: shipped {s_Shipped.Count} ({s_ShippedSet.Count} distinct), derived {s_Ours.Count}, matching {s_ShippedSet.Count(s_OursSet.Contains)}");
                WriteGroups(p_Writer, "missing", s_Missing);
                WriteGroups(p_Writer, "extra", s_Extra);

                // How far the order agrees: entries of both lists, in shipped order versus ours.
                var s_Common = s_Shipped.Where(s_OursSet.Contains).Distinct().ToList();
                var s_OurOrder = s_Ours.Where(s_ShippedSet.Contains).ToList();
                p_Writer.WriteLine($"    order: {(s_Common.SequenceEqual(s_OurOrder) ? "same" : $"differs ({s_Common.Zip(s_OurOrder).Count(p_P => p_P.First != p_P.Second)} positions)")}");

                s_Report.Add(new { Registry = s_Kind, Shipped = s_Shipped.Count, Derived = s_Ours.Count, Missing = s_Missing.Select(Detail).ToList(), Extra = s_Extra.Select(Detail).ToList() });
            }

            if (Destination != null)
            {
                File.WriteAllText(Destination.FullName, JsonConvert.SerializeObject(new
                {
                    Partition = s_Root,
                    Registries = s_Report,
                    Shipped = s_Closure.Registries.ToDictionary(p_R => p_R.Kind, p_R => p_R.Entries.Select(p_E => m_Deriver.Key(p_E.PartitionGuid, p_E.InstanceId)).ToList()),
                    s_Result.Own,
                    s_Result.SubWorlds,
                    Names = m_Deriver.Keys.ToList().ToDictionary(p_K => p_K, p_K =>
                    {
                        var (s_Type, s_Name, _) = Describe(p_K);
                        var s_Bundles = s_Mounter.TryGetPartition(s_Name, out var s_P) ? s_P.Variants.Select(p_V => p_V.GetContainedBundle()?.ToString()).ToList() : new List<string?>();
                        return new { Type = s_Type, Partition = s_Name, Bundles = s_Bundles };
                    }),
                }, Formatting.Indented));
                p_Writer.WriteLine($"Report written to {Destination.FullName}.");
            }

            return true;
        }

        /// <summary>Type and partition of an entry, parsing the partition when it is outside every closure seen.</summary>
        private (string Type, string Partition, string Key) Describe(string p_Key)
        {
            if (!m_Deriver.Instances.TryGetValue(p_Key, out var s_Found))
            {
                var s_Name = m_Deriver.PartitionName(p_Key);
                if (s_Name != null && m_Deriver.Parse(s_Name) is { } s_Parsed)
                {
                    foreach (var s_Instance in s_Parsed.Instances)
                    {
                        if (s_Instance != null)
                            m_Deriver.Instances.TryAdd(m_Deriver.Key(s_Parsed.PartitionGuid, s_Instance.InstanceId), (s_Name, s_Instance));
                    }
                }

                if (!m_Deriver.Instances.TryGetValue(p_Key, out s_Found))
                    return ("unresolved", s_Name ?? p_Key, p_Key);
            }

            return (s_Found.Instance.GetType().Name, s_Found.Partition, p_Key);
        }

        private List<string> Chain(string p_Partition)
        {
            var s_Chain = new List<string>();
            for (var s_At = p_Partition; m_Deriver.ReachedFrom.TryGetValue(s_At, out var s_From) && s_Chain.Count < 12; s_At = s_From)
                s_Chain.Add(s_From);
            return s_Chain;
        }

        private object Detail((string Type, string Partition, string Key) p_Entry)
        {
            var s_Instance = m_Deriver.Instances.TryGetValue(p_Entry.Key, out var s_Found) ? s_Found.Instance : null;
            var s_Flags = s_Instance?.GetType().GetProperties().Where(p_P => p_P.PropertyType == typeof(bool))
                .Select(p_P => $"{p_P.Name}={p_P.GetValue(s_Instance)}");
            return new
            {
                p_Entry.Type,
                p_Entry.Partition,
                p_Entry.Key,
                Flags = s_Flags == null ? null : string.Join(" ", s_Flags),
                ReferencedBy = m_Deriver.ReferencedBy.GetValueOrDefault(p_Entry.Key)?.Take(10).ToList(),
                ReachedFrom = Chain(p_Entry.Partition),
            };
        }

        private static void WriteGroups(TextWriter p_Writer, string p_Label, List<(string Type, string Partition, string Key)> p_Entries)
        {
            if (p_Entries.Count == 0)
                return;

            p_Writer.WriteLine($"    {p_Label}: {p_Entries.Count}");
            foreach (var s_Group in p_Entries.GroupBy(p_E => p_E.Type).OrderByDescending(p_G => p_G.Count()))
            {
                var s_Examples = s_Group.Select(p_E => p_E.Partition).Distinct().Take(4);
                p_Writer.WriteLine($"      {s_Group.Key,-40} {s_Group.Count(),5}  e.g. {string.Join(", ", s_Examples)}");
            }
        }
    }
}
