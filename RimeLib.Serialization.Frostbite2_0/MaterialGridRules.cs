using System;
using System.Collections.Generic;
using System.Linq;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;

namespace RimeLib.Serialization.Frostbite2_0;

/// <summary>Material grids as Frostbite2_0 lays them out: rows by global material index, relation data as instances of the grid partition.</summary>
public class MaterialGridRules : IMaterialGridRules
{
    public EngineType[] GetSupportedEngines()
    {
        return new[] { EngineType.Frostbite2_0 };
    }

    public IReadOnlyCollection<uint> GetMaterials(DatabasePartitionBase p_Grid)
    {
        if (p_Grid.PrimaryInstance is not fb.MaterialGridData s_Grid)
            return Array.Empty<uint>();

        return Used(s_Grid).ToList();
    }

    public int Merge(DatabasePartitionBase p_Target, IReadOnlyList<DatabasePartitionBase> p_Sources, ISet<uint>? p_Materials)
    {
        var s_Target = (Ebx.DatabasePartition)p_Target;
        var s_Grid = (fb.MaterialGridData)s_Target.PrimaryInstance;

        // The union of the sources, first source first.
        var s_Properties = new Dictionary<uint, (fb.MaterialRelationPropertyPair Pair, DatabasePartitionBase From)>();
        var s_Relations = new Dictionary<(uint, uint), (fb.MaterialRelationPropertyPair Pair, DatabasePartitionBase From)>();
        var s_Size = s_Grid.MaterialIndexMap.Count;
        foreach (var s_Source in p_Sources)
        {
            if (s_Source.PrimaryInstance is not fb.MaterialGridData s_From)
                continue;

            s_Size = System.Math.Max(s_Size, s_From.MaterialIndexMap.Count);
            var s_Used = Used(s_From).ToList();
            foreach (var i in s_Used)
            {
                var s_Row = (int)s_From.MaterialIndexMap[(int)i];
                s_Properties.TryAdd(i, (s_From.MaterialProperties[s_Row], s_Source));
                foreach (var j in s_Used)
                    s_Relations.TryAdd((i, j), (s_From.InteractionGrid[s_Row].Items[(int)s_From.MaterialIndexMap[(int)j]], s_Source));
            }
        }

        var s_Default = s_Grid.DefaultMaterialIndex;
        var s_Indices = s_Properties.Keys.Where(p_I => p_I == s_Default || p_Materials == null || p_Materials.Contains(p_I))
            .OrderBy(p_I => p_I == s_Default ? 0 : 1).ThenBy(p_I => p_I).ToList();

        foreach (var s_Key in s_Target.InstanceMap.Keys.Where(p_K => !ReferenceEquals(s_Target.InstanceMap[p_K], s_Target.PrimaryInstance)).ToList())
            s_Target.InstanceMap.Remove(s_Key);

        var s_Copies = new Dictionary<(GUID, DataContainerId), DataContainerId>();
        fb.MaterialRelationPropertyPair Copy((fb.MaterialRelationPropertyPair Pair, DatabasePartitionBase From) p_Source)
        {
            return new fb.MaterialRelationPropertyPair
            {
                PhysicsMaterialProperties = CopyRefs(p_Source.Pair.PhysicsMaterialProperties, p_Source.From),
                PhysicsPropertyProperties = CopyRefs(p_Source.Pair.PhysicsPropertyProperties, p_Source.From),
            };
        }

        RefArray<T> CopyRefs<T>(RefArray<T> p_Refs, DatabasePartitionBase p_From) where T : DataContainerBase
        {
            var s_Result = new RefArray<T>();
            foreach (var s_Ref in p_Refs)
            {
                if (s_Ref.IsNull())
                    continue;

                if (!s_Copies.TryGetValue((p_From.PartitionGuid, s_Ref.InstanceId), out var s_Id))
                {
                    var s_Instance = p_From.Instances.First(p_I => p_I != null && p_I.InstanceId.Equals(s_Ref.InstanceId));
                    var s_Guid = new GUID(Guid.NewGuid());
                    s_Id = new DataContainerId.Guid(s_Guid);
                    s_Instance.InstanceId = s_Id;
                    s_Target.InstanceMap[s_Guid] = (fb.DataContainer)s_Instance;
                    s_Copies[(p_From.PartitionGuid, s_Ref.InstanceId)] = s_Id;
                }

                s_Result.Add(new CtrRef<T>(s_Target.PartitionGuid, s_Id));
            }

            return s_Result;
        }

        var s_Rows = s_Indices.Select((p_I, p_Row) => (p_I, p_Row)).ToDictionary(p_P => p_P.p_I, p_P => (uint)p_P.p_Row);
        s_Grid.MaterialIndexMap = Enumerable.Range(0, s_Size).Select(i => s_Rows.GetValueOrDefault((uint)i)).ToList();
        s_Grid.MaterialProperties = s_Indices.Select(i => Copy(s_Properties[i])).ToList();

        var s_Missing = 0;
        s_Grid.InteractionGrid = s_Indices.Select(i => new fb.MaterialInteractionGridRow
        {
            Items = s_Indices.Select(j =>
            {
                if (s_Relations.TryGetValue((i, j), out var s_Relation))
                    return Copy(s_Relation);

                ++s_Missing;
                return Copy(s_Relations.GetValueOrDefault((i, s_Default), s_Relations.GetValueOrDefault((s_Default, j), s_Relations[(s_Default, s_Default)])));
            }).ToList(),
        }).ToList();

        return s_Missing;
    }

    public IReadOnlyDictionary<(uint, uint), string> Describe(DatabasePartitionBase p_Grid)
    {
        var s_Result = new Dictionary<(uint, uint), string>();
        if (p_Grid.PrimaryInstance is not fb.MaterialGridData s_Grid)
            return s_Result;

        var s_Instances = p_Grid.Instances.Where(p_I => p_I != null).GroupBy(p_I => p_I.InstanceId).ToDictionary(p_G => p_G.Key, p_G => p_G.First());
        string Text(fb.MaterialRelationPropertyPair p_Pair)
        {
            string Refs(IEnumerable<CtrRefBase> p_Refs) => string.Join(";", p_Refs.Select(p_R =>
            {
                if (!s_Instances.TryGetValue(p_R.InstanceId, out var s_Instance))
                    return $"ext:{p_R.PartitionGuid}/{p_R.InstanceId}";
                var s_Json = Newtonsoft.Json.Linq.JObject.FromObject(s_Instance);
                s_Json.Remove("InstanceId");
                return s_Instance.GetType().Name + s_Json.ToString(Newtonsoft.Json.Formatting.None);
            }).OrderBy(p_S => p_S));
            return Refs(p_Pair.PhysicsMaterialProperties) + "|" + Refs(p_Pair.PhysicsPropertyProperties);
        }

        var s_Used = Used(s_Grid).ToList();
        foreach (var i in s_Used)
        {
            var s_Row = (int)s_Grid.MaterialIndexMap[(int)i];
            s_Result[(i, uint.MaxValue)] = Text(s_Grid.MaterialProperties[s_Row]);
            foreach (var j in s_Used)
                s_Result[(i, j)] = Text(s_Grid.InteractionGrid[s_Row].Items[(int)s_Grid.MaterialIndexMap[(int)j]]);
        }

        return s_Result;
    }

    private const string c_ContainerPartition = "materials/materialcontainer";

    // The container's pairs by position, as (PhysicsMaterialIndex, PhysicsPropertyIndex), and its material names.
    private List<(uint Material, uint Property)>? m_Pairs;
    private List<string>? m_Names;

    /// <summary>Each pair's packed value and reference, by material and property.</summary>
    private Dictionary<(uint, uint), (uint Packed, CtrRef<fb.MaterialContainerPair> Ref)>? m_PairsByMaterial;

    private void LoadContainer(Func<string, DatabasePartitionBase?> p_Parse)
    {
        if (m_Pairs != null)
            return;

        m_Pairs = new List<(uint, uint)>();
        m_Names = new List<string>();
        m_PairsByMaterial = new Dictionary<(uint, uint), (uint, CtrRef<fb.MaterialContainerPair>)>();
        if (p_Parse(c_ContainerPartition) is not { PrimaryInstance: fb.MaterialContainerAsset s_Container } s_Partition)
            return;

        var s_Instances = s_Partition.Instances.Where(p_I => p_I != null).GroupBy(p_I => p_I.InstanceId).ToDictionary(p_G => p_G.Key, p_G => p_G.First());
        foreach (var s_Ref in s_Container.MaterialPairs)
        {
            if (s_Instances.GetValueOrDefault(s_Ref.InstanceId) is not fb.MaterialContainerPair s_Pair)
            {
                m_Pairs.Add((uint.MaxValue, uint.MaxValue));
                continue;
            }

            var s_Key = ((uint)(byte)s_Pair.PhysicsMaterialIndex, (uint)(byte)s_Pair.PhysicsPropertyIndex);
            m_Pairs.Add(s_Key);
            m_PairsByMaterial.TryAdd(s_Key, (s_Pair.FlagsAndIndex, new CtrRef<fb.MaterialContainerPair>(s_Partition.PartitionGuid, s_Ref.InstanceId)));
        }

        m_Names.AddRange(s_Container.MaterialNames);
    }

    public bool TryGetPackedMaterial(object p_Value, Func<CtrRefBase, DataContainerBase?> p_Resolve, out uint p_Packed)
    {
        p_Packed = 0;
        if (p_Value is not CtrRef<fb.MaterialContainerPair> s_Ref || p_Resolve(s_Ref) is not fb.MaterialContainerPair s_Pair)
            return false;

        p_Packed = s_Pair.FlagsAndIndex;
        return true;
    }

    /// <summary>
    /// The low 16 bits are a pair's position in the shared material container (Materials/MaterialContainer,
    /// 180 x 180 pairs); the pair's physics material and physics property are global material indices.
    /// </summary>
    public IReadOnlyCollection<uint> GetMaterials(uint p_Packed, Func<string, DatabasePartitionBase?> p_Parse)
    {
        LoadContainer(p_Parse);
        var s_Index = (int)(p_Packed & 0xFFFF);
        if (s_Index >= m_Pairs!.Count || m_Pairs[s_Index].Material == uint.MaxValue)
            return Array.Empty<uint>();

        var (s_Material, s_Property) = m_Pairs[s_Index];
        return s_Material == s_Property ? new[] { s_Material } : new[] { s_Material, s_Property };
    }

    public string? GetMaterialName(uint p_Material, Func<string, DatabasePartitionBase?> p_Parse)
    {
        LoadContainer(p_Parse);
        return p_Material < m_Names!.Count ? m_Names[(int)p_Material] : null;
    }

    public bool TryUnpack(uint p_Packed, Func<string, DatabasePartitionBase?> p_Parse, out uint p_Material, out uint p_Property)
    {
        LoadContainer(p_Parse);
        var s_Index = (int)(p_Packed & 0xFFFF);
        (p_Material, p_Property) = s_Index < m_Pairs!.Count ? m_Pairs[s_Index] : (uint.MaxValue, uint.MaxValue);
        return p_Material != uint.MaxValue;
    }

    /// <summary>The shared container's pair of the material and property, its packed value and a reference to it.</summary>
    public bool TryPack(uint p_Material, uint p_Property, Func<string, DatabasePartitionBase?> p_Parse, out uint p_Packed, out object p_Value)
    {
        LoadContainer(p_Parse);
        if (m_PairsByMaterial!.TryGetValue((p_Material, p_Property), out var s_Pair))
        {
            (p_Packed, p_Value) = s_Pair;
            return true;
        }

        (p_Packed, p_Value) = (0, null!);
        return false;
    }

    private static IEnumerable<uint> Used(fb.MaterialGridData p_Grid)
    {
        for (var i = 0; i < p_Grid.MaterialIndexMap.Count; ++i)
        {
            if (p_Grid.MaterialIndexMap[i] != 0 || i == p_Grid.DefaultMaterialIndex)
                yield return (uint)i;
        }
    }
}
