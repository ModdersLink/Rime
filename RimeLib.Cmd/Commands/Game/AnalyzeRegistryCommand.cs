using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.Mesh;
using RimeLib.Serialization;
using RimeLib.Texture;

namespace RimeLib.Cmd.Commands.Game
{
    /// <summary>
    /// Compares a level partition's registries with the closure of that partition, instance by
    /// instance, to find the rule a registry follows: which types it lists, whether every instance of
    /// such a type in the closure is listed, and what it lists from outside the closure.
    /// </summary>
    [CommandDescription("Compares the registries of a level partition (LevelData or SubWorldData) with its closure, instance by instance, by type.")]
    public class AnalyzeRegistryCommand : Command
    {
        [CommandArgument(Description = "The level partition, e.g. levels/mp_subway/rush.")]
        public string? Partition { get; set; }

        [CommandArgument(Description = "Where to write the JSON report.")]
        public FileInfo? Destination { get; set; }

        [CommandArgument(Description = "Network registry partition to use when the registries are not embedded (BF4), e.g. levels/mp/mp_siege/rushlarge0_networkregistry_win32. Default: <partition>_networkregistry_win32.", Optional = true)]
        public string? RegistryPartition { get; set; }

        private IEngineMounter m_Mounter = null!;
        private AssetReferenceScanner m_Scanner = null!;
        private IPartitionConverter m_Converter = null!;

        // Every instance seen, closure or not: "partitionGuid/instanceId" -> (partition, type).
        private readonly Dictionary<string, (string Partition, DataContainerBase Instance)> m_Instances = new();
        private readonly HashSet<string> m_ParsedPartitions = new(StringComparer.OrdinalIgnoreCase);
        private readonly Dictionary<string, HashSet<string>> m_ReferencedBy = new();

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (string.IsNullOrWhiteSpace(Partition) || Destination == null)
            {
                p_Writer.WriteLine("usage: analyze_registry <partition> <destination.json> [registry_partition]");
                return false;
            }

            m_Mounter = ((GameContext)p_Context).GetMounter();
            var s_Engine = m_Mounter.GetEngineType();
            m_Converter = EngineInterfaceRegistry.Create<IPartitionConverter>(s_Engine);
            var s_Indexes = EngineInterfaceRegistry.Create<ILevelIndexes>(s_Engine);
            m_Scanner = new AssetReferenceScanner(m_Mounter, m_Converter, TryCreate<ITextureConverter>(s_Engine), TryCreate<IMeshConverter>(s_Engine));

            var s_Root = Partition!.ToLowerInvariant();
            if (!m_Mounter.TryGetPartition(s_Root, out _))
            {
                p_Writer.WriteLine($"No partition named '{Partition}'.");
                return false;
            }

            var s_LevelClosure = LevelClosure.Build(m_Mounter, m_Scanner, s_Indexes, Parse, s_Root, RegistryPartition);
            var s_Closure = s_LevelClosure.Partitions.Keys.ToHashSet(StringComparer.OrdinalIgnoreCase);
            var s_Registries = s_LevelClosure.Registries;
            foreach (var (s_Name, s_Parsed) in s_LevelClosure.Partitions)
                AddInstances(s_Name, s_Parsed);

            if (s_Registries.Count == 0)
            {
                p_Writer.WriteLine($"No registry found for {s_Root}.");
                return false;
            }

            var s_ClosureKeys = m_Instances.Where(p_I => s_Closure.Contains(p_I.Value.Partition)).Select(p_I => p_I.Key).ToHashSet();

            // Who references each instance, as "SourceType.Field", over the closure.
            foreach (var s_Key in s_ClosureKeys)
            {
                var s_Source = m_Instances[s_Key].Instance;

                // The registries themselves, and whole-partition indexes, would explain everything.
                if (s_Indexes.GetEmbeddedIndexes(s_Source).Any() ||
                    (s_Source.Partition != null && s_Source.Partition.PrimaryInstance == s_Source && s_Indexes.GetPartitionIndexKind(s_Source) != null))
                    continue;

                foreach (var (s_Field, s_Ref) in References(s_Source, s_Source.GetType().Name, 0))
                {
                    var s_Target = Key(s_Ref.PartitionGuid, s_Ref.InstanceId);
                    if (!m_ReferencedBy.TryGetValue(s_Target, out var s_By))
                        m_ReferencedBy[s_Target] = s_By = new HashSet<string>();
                    s_By.Add(s_Field);
                }
            }
            p_Writer.WriteLine($"{s_Root}: closure of {s_Closure.Count} partitions, {s_ClosureKeys.Count} instances.");

            var s_Report = new List<RegistryReport>();
            foreach (var (s_Kind, s_Entries) in s_Registries)
            {
                var s_Result = new RegistryReport { Registry = s_Kind, Entries = s_Entries.Count };
                var s_Listed = new HashSet<string>();

                foreach (var s_Entry in s_Entries)
                {
                    var s_Key = Key(s_Entry.PartitionGuid, s_Entry.InstanceId);
                    s_Listed.Add(s_Key);

                    if (!m_Instances.ContainsKey(s_Key) && ResolvePartition(s_Entry.PartitionGuid) is { } s_Target)
                    {
                        if (Parse(s_Target) is { } s_Parsed)
                            AddInstances(s_Target, s_Parsed);
                    }

                    var s_Type = m_Instances.TryGetValue(s_Key, out var s_Found) ? s_Found.Instance.GetType().Name : "unresolved";
                    var s_Stats = s_Result.Type(s_Type, m_Instances.TryGetValue(s_Key, out var s_F) ? s_F.Instance.GetType() : null);

                    if (s_ClosureKeys.Contains(s_Key))
                        s_Stats.ListedInClosure++;
                    else
                    {
                        s_Stats.ListedOutsideClosure++;
                        if (s_Stats.OutsideExamples.Count < 10)
                            s_Stats.OutsideExamples.Add(m_Instances.TryGetValue(s_Key, out var s_O) ? s_O.Partition : s_Key);
                    }
                }

                // For every type the registry lists, how much of it in the closure it leaves out, and
                // which property tells the listed instances from the others.
                foreach (var s_Stats in s_Result.Types.Values)
                {
                    var s_In = new List<DataContainerBase>();
                    var s_Out = new List<DataContainerBase>();

                    foreach (var s_Key in s_ClosureKeys)
                    {
                        var (s_Part, s_Instance) = m_Instances[s_Key];
                        if (s_Instance.GetType().Name != s_Stats.TypeName)
                            continue;

                        s_Stats.InClosure++;
                        if (s_Listed.Contains(s_Key))
                        {
                            s_In.Add(s_Instance);
                            continue;
                        }

                        s_Out.Add(s_Instance);
                        s_Stats.NotListedInClosure++;
                        if (s_Stats.NotListedExamples.Count < 10)
                            s_Stats.NotListedExamples.Add(s_Part);
                    }

                    if (s_In.Count > 0 && s_Out.Count > 0)
                    {
                        s_Stats.Separators = FindSeparators(s_In, s_Out);
                        s_Stats.Implications = FindImplications(s_In, s_Out);
                    }
                }

                s_Report.Add(s_Result);
                WriteSummary(p_Writer, s_Result);
            }

            File.WriteAllText(Destination.FullName, JsonConvert.SerializeObject(new { Partition = s_Root, ClosurePartitions = s_Closure.Count, ClosureInstances = s_ClosureKeys.Count, Registries = s_Report }, Formatting.Indented));
            p_Writer.WriteLine($"Report written to {Destination.FullName}.");
            return true;
        }

        /// <summary>
        /// Simple-valued properties (and those of the object each reference field points at) whose
        /// values never overlap between the listed and the unlisted instances, as
        /// "property: listed values | unlisted values".
        /// </summary>
        private List<string> FindSeparators(List<DataContainerBase> p_Listed, List<DataContainerBase> p_NotListed)
        {
            var s_ListedFeatures = p_Listed.Select(Features).ToList();
            var s_NotListedFeatures = p_NotListed.Select(Features).ToList();
            var s_Result = new List<string>();

            foreach (var s_Feature in s_ListedFeatures.SelectMany(p_F => p_F.Keys).Distinct())
            {
                var s_A = s_ListedFeatures.Select(p_F => p_F.GetValueOrDefault(s_Feature, "<none>")).ToHashSet();
                var s_B = s_NotListedFeatures.Select(p_F => p_F.GetValueOrDefault(s_Feature, "<none>")).ToHashSet();
                if (s_A.Overlaps(s_B) || s_A.Count > 3 || s_B.Count > 3)
                    continue;

                s_Result.Add($"{s_Feature}: {string.Join(", ", s_A)} | {string.Join(", ", s_B)}");
            }

            return s_Result.OrderBy(p_S => p_S.Count(p_C => p_C == '.')).ThenBy(p_S => p_S).Take(20).ToList();
        }

        private Dictionary<string, string> Features(DataContainerBase p_Instance)
        {
            var s_Features = new Dictionary<string, string>();
            AddFeatures(s_Features, "", p_Instance, 0);

            if (p_Instance.Partition != null && m_ReferencedBy.TryGetValue(Key(p_Instance.Partition.PartitionGuid, p_Instance.InstanceId), out var s_By))
            {
                foreach (var s_Field in s_By)
                    s_Features["referenced by " + s_Field] = "True";
            }

            return s_Features;
        }

        /// <summary>
        /// One-way rules: feature values whose instances are all listed, or all left out, ranked by how
        /// many instances they decide.
        /// </summary>
        private List<string> FindImplications(List<DataContainerBase> p_Listed, List<DataContainerBase> p_NotListed)
        {
            var s_Counts = new Dictionary<(string Feature, string Value), (int Listed, int NotListed)>();

            void Count(List<DataContainerBase> p_Instances, bool p_IsListed)
            {
                foreach (var s_Features in p_Instances.Select(Features))
                foreach (var s_Pair in s_Features)
                {
                    var s_C = s_Counts.GetValueOrDefault((s_Pair.Key, s_Pair.Value));
                    s_Counts[(s_Pair.Key, s_Pair.Value)] = p_IsListed ? (s_C.Listed + 1, s_C.NotListed) : (s_C.Listed, s_C.NotListed + 1);
                }
            }

            Count(p_Listed, true);
            Count(p_NotListed, false);

            return s_Counts
                .Where(p_C => (p_C.Value.Listed == 0) != (p_C.Value.NotListed == 0) && System.Math.Max(p_C.Value.Listed, p_C.Value.NotListed) >= 2)
                .OrderByDescending(p_C => p_C.Value.Listed > 0 ? p_C.Value.Listed * 1000.0 / p_Listed.Count : p_C.Value.NotListed * 1000.0 / p_NotListed.Count)
                .Select(p_C => p_C.Value.Listed > 0
                    ? $"all {p_C.Value.Listed} with {p_C.Key.Feature} = {p_C.Key.Value} are listed ({p_C.Value.Listed} of {p_Listed.Count} listed)"
                    : $"all {p_C.Value.NotListed} with {p_C.Key.Feature} = {p_C.Key.Value} are left out ({p_C.Value.NotListed} of {p_NotListed.Count} left out)")
                .Take(12).ToList();
        }

        /// <summary>Every reference an object holds, through structs and lists, as ("Type.Field", reference).</summary>
        internal static IEnumerable<(string Field, CtrRefBase Ref)> References(object p_Object, string p_Path, int p_Depth)
        {
            if (p_Depth > 4)
                yield break;

            foreach (var s_Property in p_Object.GetType().GetProperties())
            {
                if (s_Property.GetIndexParameters().Length > 0 || s_Property.Name is "Partition" or "InstanceId")
                    continue;

                object? s_Value;
                try { s_Value = s_Property.GetValue(p_Object); }
                catch (Exception) { continue; }

                var s_Path = $"{p_Path}.{s_Property.Name}";
                switch (s_Value)
                {
                    case CtrRefBase s_Ref:
                        if (!s_Ref.IsNull())
                            yield return (s_Path, s_Ref);
                        break;
                    case string:
                        break;
                    case System.Collections.IEnumerable s_List:
                        foreach (var s_Item in s_List)
                        {
                            if (s_Item is CtrRefBase s_ItemRef)
                            {
                                if (!s_ItemRef.IsNull())
                                    yield return (s_Path, s_ItemRef);
                            }
                            else if (s_Item is EbxSerializable and not DataContainerBase)
                            {
                                foreach (var s_Inner in References(s_Item, s_Path, p_Depth + 1))
                                    yield return s_Inner;
                            }
                        }
                        break;
                    case EbxSerializable s_Struct and not DataContainerBase:
                        foreach (var s_Inner in References(s_Struct, s_Path, p_Depth + 1))
                            yield return s_Inner;
                        break;
                }
            }
        }

        private void AddFeatures(Dictionary<string, string> p_Features, string p_Prefix, object p_Object, int p_Depth)
        {
            foreach (var s_Property in p_Object.GetType().GetProperties())
            {
                if (s_Property.GetIndexParameters().Length > 0 || s_Property.Name is "InstanceId" or "Partition" or "Name")
                    continue;

                object? s_Value;
                try { s_Value = s_Property.GetValue(p_Object); }
                catch (Exception) { continue; }

                var s_Name = p_Prefix + s_Property.Name;
                switch (s_Value)
                {
                    case bool or Enum or int or uint or byte or sbyte or short or ushort:
                        p_Features[s_Name] = s_Value.ToString()!;
                        break;
                    case CtrRefBase s_Ref when p_Depth == 0:
                        p_Features[s_Name + "?"] = s_Ref.IsNull() ? "null" : "set";
                        if (!s_Ref.IsNull() && m_Instances.TryGetValue(Key(s_Ref.PartitionGuid, s_Ref.InstanceId), out var s_Target))
                        {
                            p_Features[s_Name + ".$type"] = s_Target.Instance.GetType().Name;
                            AddFeatures(p_Features, s_Name + ".", s_Target.Instance, p_Depth + 1);
                        }
                        break;
                    case System.Collections.ICollection s_List when p_Depth == 0:
                        p_Features[s_Name + ".Count>0"] = (s_List.Count > 0).ToString();
                        break;
                }
            }
        }

        private void AddInstances(string p_Name, DatabasePartitionBase p_Partition)
        {
            if (!m_ParsedPartitions.Add(p_Name))
                return;

            foreach (var s_Instance in p_Partition.Instances)
            {
                if (s_Instance != null)
                    m_Instances[Key(p_Partition.PartitionGuid, s_Instance.InstanceId)] = (p_Name, s_Instance);
            }
        }

        private DatabasePartitionBase? Parse(string p_Name)
        {
            if (!m_Mounter.TryGetPartition(p_Name, out var s_Mounted))
                return null;

            try
            {
                return m_Converter.FromPartitionObject(p_Name, s_Mounted.FirstVariant);
            }
            catch (Exception)
            {
                return null;
            }
        }

        private string? ResolvePartition(GUID p_Guid)
        {
            return m_Mounter.TryGetPartitionByGuid(p_Guid, out var s_Name, out _) ? s_Name.ToLowerInvariant() : null;
        }

        private static string Key(GUID p_Partition, DataContainerId p_Instance) => $"{p_Partition}/{p_Instance}".ToLowerInvariant();

        private static void WriteSummary(TextWriter p_Writer, RegistryReport p_Report)
        {
            p_Writer.WriteLine();
            p_Writer.WriteLine($"--- {p_Report.Registry}: {p_Report.Entries} entries");
            p_Writer.WriteLine($"    {"type",-44} {"listed in closure",17} {"listed outside",14} {"in closure",10} {"not listed",10}");
            foreach (var s_Stats in p_Report.Types.Values.OrderByDescending(p_S => p_S.ListedInClosure + p_S.ListedOutsideClosure))
            {
                p_Writer.WriteLine($"    {s_Stats.TypeName,-44} {s_Stats.ListedInClosure,17} {s_Stats.ListedOutsideClosure,14} {s_Stats.InClosure,10} {s_Stats.NotListedInClosure,10}");
                foreach (var s_Separator in s_Stats.Separators.Take(5))
                    p_Writer.WriteLine($"        separates: {s_Separator}");
                if (s_Stats.Separators.Count == 0)
                    foreach (var s_Implication in s_Stats.Implications.Take(6))
                        p_Writer.WriteLine($"        {s_Implication}");
            }
        }

        private static T? TryCreate<T>(EngineType p_Engine) where T : class, IEngineInterface
        {
            try
            {
                return EngineInterfaceRegistry.Create<T>(p_Engine);
            }
            catch (Exception)
            {
                return null;
            }
        }

        private class RegistryReport
        {
            public string Registry { get; set; } = "";
            public int Entries { get; set; }
            public Dictionary<string, TypeStats> Types { get; set; } = new();

            public TypeStats Type(string p_Name, Type? p_Type)
            {
                if (!Types.TryGetValue(p_Name, out var s_Stats))
                {
                    Types[p_Name] = s_Stats = new TypeStats { TypeName = p_Name };
                    for (var s_Base = p_Type?.BaseType; s_Base != null && s_Base != typeof(object); s_Base = s_Base.BaseType)
                        s_Stats.BaseTypes.Add(s_Base.Name);
                }

                return s_Stats;
            }
        }

        private class TypeStats
        {
            public string TypeName { get; set; } = "";
            public List<string> BaseTypes { get; set; } = new();
            public int ListedInClosure { get; set; }
            public int ListedOutsideClosure { get; set; }
            public int InClosure { get; set; }
            public int NotListedInClosure { get; set; }
            public List<string> OutsideExamples { get; set; } = new();
            public List<string> NotListedExamples { get; set; } = new();
            public List<string> Separators { get; set; } = new();
            public List<string> Implications { get; set; } = new();
        }
    }
}
