using System;
using System.Collections.Generic;
using System.Linq;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;

namespace RimeLib.Serialization.Frostbite2013_2;

/// <summary>Material grids as Frostbite2013_2 lays them out: rows by global material index, relation data as instances of the grid partition.</summary>
public class MaterialGridRules : IMaterialGridRules
{
    public EngineType[] GetSupportedEngines()
    {
        return new[] { EngineType.Frostbite2013_2 };
    }

    public IReadOnlyCollection<uint> GetMaterials(DatabasePartitionBase p_Grid)
    {
        if (p_Grid.PrimaryInstance is not fb.Entity.MaterialGridData s_Grid)
            return Array.Empty<uint>();

        return Used(s_Grid).ToList();
    }

    public int Merge(DatabasePartitionBase p_Target, IReadOnlyList<DatabasePartitionBase> p_Sources, ISet<uint>? p_Materials)
    {
        var s_Target = (Ebx.DatabasePartition)p_Target;
        var s_Grid = (fb.Entity.MaterialGridData)s_Target.PrimaryInstance;

        // The union of the sources, first source first.
        var s_Properties = new Dictionary<uint, (fb.Entity.MaterialRelationPropertyPair Pair, DatabasePartitionBase From)>();
        var s_Relations = new Dictionary<(uint, uint), (fb.Entity.MaterialRelationPropertyPair Pair, DatabasePartitionBase From)>();
        var s_Size = s_Grid.MaterialIndexMap.Count;
        foreach (var s_Source in p_Sources)
        {
            if (s_Source.PrimaryInstance is not fb.Entity.MaterialGridData s_From)
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
        fb.Entity.MaterialRelationPropertyPair Copy((fb.Entity.MaterialRelationPropertyPair Pair, DatabasePartitionBase From) p_Source)
        {
            return new fb.Entity.MaterialRelationPropertyPair
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
                    s_Target.InstanceMap[s_Id] = s_Instance;
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
        s_Grid.InteractionGrid = s_Indices.Select(i => new fb.Entity.MaterialInteractionGridRow
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
        if (p_Grid.PrimaryInstance is not fb.Entity.MaterialGridData s_Grid)
            return s_Result;

        var s_Instances = p_Grid.Instances.Where(p_I => p_I != null).GroupBy(p_I => p_I.InstanceId).ToDictionary(p_G => p_G.Key, p_G => p_G.First());
        string Text(fb.Entity.MaterialRelationPropertyPair p_Pair)
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

    public bool TryGetPackedMaterial(object p_Value, Func<CtrRefBase, DataContainerBase?> p_Resolve, out uint p_Packed)
    {
        p_Packed = 0;
        if (p_Value is not fb.Entity.MaterialDecl s_Decl)
            return false;

        p_Packed = s_Decl.Packed;
        return true;
    }

    /// <summary>
    /// The two high bytes are global material indices (a material and a property); the low 16
    /// bits are flags. There is no shared material container.
    /// </summary>
    public IReadOnlyCollection<uint> GetMaterials(uint p_Packed, Func<string, DatabasePartitionBase?> p_Parse)
    {
        var s_Material = p_Packed >> 24;
        var s_Property = (p_Packed >> 16) & 0xFF;
        return s_Material == s_Property ? new[] { s_Material } : new[] { s_Material, s_Property };
    }

    // BF4 ships no material names.
    public string? GetMaterialName(uint p_Material, Func<string, DatabasePartitionBase?> p_Parse) => null;

    private static IEnumerable<uint> Used(fb.Entity.MaterialGridData p_Grid)
    {
        for (var i = 0; i < p_Grid.MaterialIndexMap.Count; ++i)
        {
            if (p_Grid.MaterialIndexMap[i] != 0 || i == p_Grid.DefaultMaterialIndex)
                yield return (uint)i;
        }
    }
}
