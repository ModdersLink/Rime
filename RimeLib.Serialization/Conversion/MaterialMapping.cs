using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using RimeLib.Frostbite.Core;

namespace RimeLib.Serialization.Conversion;

/// <summary>
/// One engine's global materials as another's, by name. Where the source ships no names, a
/// material is named by the assets its grid row references, its impact effects, sounds and decals
/// (fx_impact_s_concrete), whose keywords pick the target material of that name; a material none
/// of them names becomes the target's default.
/// </summary>
public sealed class MaterialMapping
{
    /// <summary>Asset names that say nothing of the surface: what every material shares.</summary>
    private static readonly string[] s_Generic = ["tomahawk", "railgun"];

    private readonly IMaterialGridRules m_Source;
    private readonly Func<string, DatabasePartitionBase?> m_SourceParse;
    private readonly IMaterialGridRules m_Target;
    private readonly Func<string, DatabasePartitionBase?> m_TargetParse;
    private readonly IReadOnlyList<(string Keyword, string Material)> m_Keywords;
    private readonly Dictionary<uint, List<string>> m_RowAssets;
    private readonly Dictionary<string, uint> m_TargetByName = new(StringComparer.OrdinalIgnoreCase);
    private readonly Dictionary<uint, uint> m_Materials = new();

    /// <summary>Each source material mapped so far, and the target material it became.</summary>
    public IReadOnlyDictionary<uint, uint> Materials => m_Materials;

    /// <summary>Source materials no keyword named, which became the target's default.</summary>
    public HashSet<uint> Unnamed { get; } = new();

    /// <summary>The target material every unnamed source material becomes.</summary>
    public uint DefaultMaterial { get; }

    public MaterialMapping(IMaterialGridRules p_Source, Func<string, DatabasePartitionBase?> p_SourceParse, DatabasePartitionBase p_SourceGrid,
        Func<GUID, string?> p_SourceName, IMaterialGridRules p_Target, Func<string, DatabasePartitionBase?> p_TargetParse,
        IReadOnlyList<(string Keyword, string Material)> p_Keywords)
    {
        (m_Source, m_SourceParse, m_Target, m_TargetParse, m_Keywords) = (p_Source, p_SourceParse, p_Target, p_TargetParse, p_Keywords);
        m_RowAssets = RowAssets(p_SourceGrid, p_SourceName);

        for (uint i = 0; m_Target.GetMaterialName(i, m_TargetParse) is { } s_Name; ++i)
            m_TargetByName.TryAdd(s_Name, i);
        DefaultMaterial = m_TargetByName.GetValueOrDefault("Default");
    }

    /// <summary>The target's default material with itself, packed, for a value that maps to nothing.</summary>
    public uint DefaultPacked => m_Target.TryPack(DefaultMaterial, DefaultMaterial, m_TargetParse, out var s_Packed, out _) ? s_Packed : 0;

    /// <summary>The target material a source material becomes.</summary>
    public uint Material(uint p_Source)
    {
        if (m_Materials.TryGetValue(p_Source, out var s_Known))
            return s_Known;

        // A source that names its materials maps by name; one that does not, by its row's assets.
        uint? s_Target = m_Source.GetMaterialName(p_Source, m_SourceParse) is { } s_Name && m_TargetByName.TryGetValue(s_Name, out var s_Named)
            ? s_Named
            : Keyword(p_Source) is { } s_Material && m_TargetByName.TryGetValue(s_Material, out var s_ByKeyword) ? s_ByKeyword : null;
        if (s_Target == null)
            Unnamed.Add(p_Source);

        return m_Materials[p_Source] = s_Target ?? DefaultMaterial;
    }

    /// <summary>
    /// A source packed material value as the target's: its material and property each mapped, as
    /// the pair the target has, or the material with itself where it has not that pair.
    /// </summary>
    public bool TryMap(uint p_Packed, out uint p_TargetPacked, out object p_TargetValue)
    {
        (p_TargetPacked, p_TargetValue) = (0, null!);
        if (!m_Source.TryUnpack(p_Packed, m_SourceParse, out var s_Material, out var s_Property))
            return false;

        var (s_TargetMaterial, s_TargetProperty) = (Material(s_Material), Material(s_Property));
        return m_Target.TryPack(s_TargetMaterial, s_TargetProperty, m_TargetParse, out p_TargetPacked, out p_TargetValue)
            || m_Target.TryPack(s_TargetMaterial, s_TargetMaterial, m_TargetParse, out p_TargetPacked, out p_TargetValue);
    }

    /// <summary>The target material named by the keyword the material's row assets name most, earlier keywords first among equals.</summary>
    private string? Keyword(uint p_Material)
    {
        if (!m_RowAssets.TryGetValue(p_Material, out var s_Assets))
            return null;

        var s_Best = m_Keywords
            .Select((p_K, p_Order) => (p_K.Material, p_Order, Count: s_Assets.Count(p_A => Names(p_A, p_K.Keyword))))
            .Where(p_K => p_K.Count > 0)
            .OrderByDescending(p_K => p_K.Count).ThenBy(p_K => p_K.p_Order)
            .FirstOrDefault();
        return s_Best.Count > 0 ? s_Best.Material : null;
    }

    /// <summary>
    /// Whether an asset name names the keyword: a word of it (fx_impact_s_concrete) starts with it,
    /// or holds it where the keyword is long enough not to be part of another word (metalsteampipe).
    /// </summary>
    private static bool Names(string p_Asset, string p_Keyword) =>
        p_Asset.Split('_', '-', '.', ' ').Any(p_Word => p_Word.StartsWith(p_Keyword, StringComparison.OrdinalIgnoreCase)
            || p_Keyword.Length >= 6 && p_Word.Contains(p_Keyword, StringComparison.OrdinalIgnoreCase));

    /// <summary>
    /// By global material, the names of the partitions its grid row's relations and properties
    /// reference: InteractionGrid and MaterialProperties at the row MaterialIndexMap gives it.
    /// </summary>
    private static Dictionary<uint, List<string>> RowAssets(DatabasePartitionBase p_Grid, Func<GUID, string?> p_Name)
    {
        var s_Instances = p_Grid.Instances.GroupBy(p_I => p_I.InstanceId).ToDictionary(p_G => p_G.Key, p_G => p_G.First());
        var s_Primary = p_Grid.PrimaryInstance;
        object? Field(object p_Object, string p_Name) => p_Object.GetType().GetProperty(p_Name)?.GetValue(p_Object);

        var s_Map = (Field(s_Primary, "MaterialIndexMap") as IEnumerable)?.Cast<object>().Select(Convert.ToInt64).ToList() ?? [];
        var s_Grid = (Field(s_Primary, "InteractionGrid") as IEnumerable)?.Cast<object>().ToList() ?? [];
        var s_Properties = (Field(s_Primary, "MaterialProperties") as IEnumerable)?.Cast<object>().ToList() ?? [];

        // Every relation and property entry holds two lists of references into the grid's partition.
        IEnumerable<CtrRefBase> Relations(object? p_Entry) => p_Entry == null
            ? []
            : new[] { "PhysicsMaterialProperties", "PhysicsPropertyProperties" }
                .SelectMany(p_F => (Field(p_Entry, p_F) as IEnumerable)?.OfType<CtrRefBase>() ?? []);

        var s_Rows = new Dictionary<uint, List<string>>();
        for (var s_Material = 0; s_Material < s_Map.Count; ++s_Material)
        {
            var s_Row = (int)s_Map[s_Material];
            if (s_Row >= s_Grid.Count)
                continue;

            var s_Entries = ((Field(s_Grid[s_Row], "Items") as IEnumerable)?.Cast<object>() ?? []).Append(s_Row < s_Properties.Count ? s_Properties[s_Row] : null);
            var s_Names = new List<string>();
            foreach (var s_Ref in s_Entries.SelectMany(Relations))
            {
                if (s_Ref.PartitionGuid != p_Grid.PartitionGuid || !s_Instances.TryGetValue(s_Ref.InstanceId, out var s_Relation))
                    continue;
                foreach (var s_Other in References(s_Relation).Where(p_R => p_R.PartitionGuid != p_Grid.PartitionGuid))
                {
                    if (p_Name(s_Other.PartitionGuid) is { } s_Name && !s_Generic.Any(p_G => s_Name.Contains(p_G, StringComparison.OrdinalIgnoreCase)))
                        s_Names.Add(s_Name[(s_Name.LastIndexOf('/') + 1)..]);
                }
            }

            s_Rows[(uint)s_Material] = s_Names;
        }

        return s_Rows;
    }

    /// <summary>Every reference an instance holds, in its fields, lists and structs.</summary>
    private static IEnumerable<CtrRefBase> References(object p_Value, int p_Depth = 0)
    {
        if (p_Depth > 4)
            yield break;

        foreach (var s_Property in p_Value.GetType().GetProperties().Where(p_P => p_P.GetIndexParameters().Length == 0 && p_P.DeclaringType != typeof(DataContainerBase)))
        {
            var s_Field = s_Property.GetValue(p_Value);
            switch (s_Field)
            {
                case CtrRefBase s_Ref when !s_Ref.IsNull():
                    yield return s_Ref;
                    break;
                case IEnumerable s_List and not string:
                    foreach (var s_Item in s_List)
                    {
                        if (s_Item is CtrRefBase s_ItemRef && !s_ItemRef.IsNull())
                            yield return s_ItemRef;
                        else if (s_Item is EbxSerializable s_Struct)
                            foreach (var s_Inner in References(s_Struct, p_Depth + 1))
                                yield return s_Inner;
                    }
                    break;
                case EbxSerializable s_Struct and not DataContainerBase:
                    foreach (var s_Inner in References(s_Struct, p_Depth + 1))
                        yield return s_Inner;
                    break;
            }
        }
    }
}
