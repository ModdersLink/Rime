using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using RimeLib.Frostbite;

namespace RimeLib.Serialization.Frostbite2_0;

/// <summary>Frostbite 2 mesh variation databases: entries and redirects are instances of the database partition.</summary>
public class MeshVariationRules : IMeshVariationRules
{
    public EngineType[] GetSupportedEngines()
    {
        return new[] { EngineType.Frostbite2_0 };
    }

    public IEnumerable<(CtrRefBase Mesh, uint VariationHash, object Entry)> ReadEntries(DatabasePartitionBase p_Partition)
    {
        if (p_Partition.PrimaryInstance is not fb.MeshVariationDatabase s_Database)
            yield break;

        foreach (var s_Entry in Entries(p_Partition, s_Database.Entries))
            yield return (s_Entry.Mesh, s_Entry.VariationAssetNameHash, s_Entry);
    }

    public IEnumerable<(CtrRefBase Mesh, uint VariationHash)> ReadRedirects(DatabasePartitionBase p_Partition)
    {
        if (p_Partition.PrimaryInstance is not fb.MeshVariationDatabase s_Database)
            yield break;

        foreach (var s_Entry in Entries(p_Partition, s_Database.RedirectEntries))
            yield return (s_Entry.Mesh, s_Entry.VariationAssetNameHash);
    }

    public IEnumerable<(CtrRefBase Mesh, uint VariationHash, object Entry)> ReadRedirectEntries(DatabasePartitionBase p_Partition)
    {
        if (p_Partition.PrimaryInstance is not fb.MeshVariationDatabase s_Database)
            yield break;

        foreach (var s_Entry in Entries(p_Partition, s_Database.RedirectEntries))
            yield return (s_Entry.Mesh, s_Entry.VariationAssetNameHash, s_Entry);
    }

    public bool PlainEntryWithVariations => false;

    public bool IsMesh(DataContainerBase p_Instance) => p_Instance is fb.MeshAsset;

    public IEnumerable<CtrRefBase> GetTextures(object p_Entry) =>
        ((fb.MeshVariationDatabaseEntry)p_Entry).Materials.SelectMany(p_M => p_M.TextureParameters)
            .Where(p_P => p_P?.Value != null && !p_P.Value.IsNull()).Select(p_P => (CtrRefBase)p_P.Value);

    public void SetEntries(DatabasePartitionBase p_Database, IReadOnlyList<object> p_Entries)
    {
        var s_Partition = (Ebx.DatabasePartition)p_Database;
        var s_Database = (fb.MeshVariationDatabase)s_Partition.PrimaryInstance;

        foreach (var s_Key in s_Partition.InstanceMap.Keys.Where(p_K => p_K != s_Partition.PrimaryInstanceGuid).ToList())
            s_Partition.InstanceMap.Remove(s_Key);

        s_Database.Entries.Clear();
        s_Database.RedirectEntries.Clear();
        foreach (var s_Entry in p_Entries.Cast<fb.MeshVariationDatabaseEntry>())
        {
            if (s_Entry.InstanceId is not DataContainerId.Guid s_Id || !s_Partition.InstanceMap.TryAdd(s_Id.Id, s_Entry))
                continue;
            s_Database.Entries.AddRef(new CtrRef<fb.MeshVariationDatabaseEntry>(s_Partition.PartitionGuid, s_Entry.InstanceId));
        }
    }

    public void AddEntries(DatabasePartitionBase p_Database, IReadOnlyList<object> p_Entries, IReadOnlyList<object> p_Redirects)
    {
        var s_Partition = (Ebx.DatabasePartition)p_Database;
        var s_Database = (fb.MeshVariationDatabase)s_Partition.PrimaryInstance;
        Add(p_Entries, s_Database.Entries);
        Add(p_Redirects, s_Database.RedirectEntries);

        void Add(IReadOnlyList<object> p_Added, RefArray<fb.MeshVariationDatabaseEntry> p_List)
        {
            foreach (var s_Entry in p_Added.Cast<fb.MeshVariationDatabaseEntry>())
            {
                if (s_Entry.InstanceId is DataContainerId.Guid s_Id && s_Partition.InstanceMap.TryAdd(s_Id.Id, s_Entry))
                    p_List.AddRef(new CtrRef<fb.MeshVariationDatabaseEntry>(s_Partition.PartitionGuid, s_Entry.InstanceId));
            }
        }
    }

    public bool UsesMeshesUnvaried(DataContainerBase p_Instance) => p_Instance is fb.EmitterTemplateData;

    public IEnumerable<(CtrRefBase Placed, uint VariationHash)> GetPlacements(DataContainerBase p_Instance, System.Func<CtrRefBase, DataContainerBase?> p_Resolve)
    {
        switch (p_Instance)
        {
            case fb.StaticModelGroupEntityData s_Group:
                foreach (var s_Member in s_Group.MemberDatas)
                {
                    var s_Hashes = Enumerable.Range(0, (int)s_Member.InstanceCount)
                        .Select(i => i < s_Member.InstanceObjectVariation.Count ? s_Member.InstanceObjectVariation[i] : 0u).Distinct().ToList();
                    foreach (var s_Placed in new CtrRefBase[] { s_Member.MeshEntityType, s_Member.MemberType }.Where(p_R => !p_R.IsNull()))
                    foreach (var s_Hash in s_Hashes)
                        yield return (s_Placed, s_Hash);
                }
                break;

            // A reference object places its blueprint's meshes with its variation, or plainly.
            case fb.ReferenceObjectData s_Reference when !s_Reference.Blueprint.IsNull():
                yield return (s_Reference.Blueprint, p_Resolve(s_Reference.ObjectVariation) is fb.ObjectVariation s_ReferenceVariation ? s_ReferenceVariation.NameHash : 0u);
                break;

            case fb.BlueprintAndVariationPair s_Pair when !s_Pair.BaseAsset.IsNull():
                yield return (s_Pair.BaseAsset, p_Resolve(s_Pair.Variation) is fb.ObjectVariation s_Variation ? s_Variation.NameHash : 0u);
                break;
        }
    }

    public uint? GetVariationHash(DataContainerBase p_Instance) => (p_Instance as fb.ObjectVariation)?.NameHash;

    public string Fingerprint(object p_Entry)
    {
        var s_Entry = (fb.MeshVariationDatabaseEntry)p_Entry;
        return JsonConvert.SerializeObject(s_Entry.Materials.Select(p_M => new
        {
            Material = Ref(p_M.Material),
            Variation = Ref(p_M.MaterialVariation),
            Textures = p_M.TextureParameters.Select(p_T => $"{p_T.ParameterName}={Ref(p_T.Value)}"),
        }));
    }

    public IEnumerable<CtrRefBase> GetDrawnMaterials(object p_Entry) =>
        ((fb.MeshVariationDatabaseEntry)p_Entry).Materials.Select(p_M => p_M.MaterialVariation.IsNull() ? (CtrRefBase)p_M.Material : p_M.MaterialVariation).Where(p_R => !p_R.IsNull());

    private static string Ref(CtrRefBase p_Ref) => p_Ref.IsNull() ? "" : $"{p_Ref.PartitionGuid}/{p_Ref.InstanceId}";

    private static IEnumerable<fb.MeshVariationDatabaseEntry> Entries(DatabasePartitionBase p_Partition, IEnumerable<CtrRefBase> p_Refs)
    {
        var s_Instances = p_Partition.Instances.Where(p_I => p_I != null).GroupBy(p_I => p_I.InstanceId).ToDictionary(p_G => p_G.Key, p_G => p_G.First());
        foreach (var s_Ref in p_Refs)
        {
            if (!s_Ref.IsNull() && s_Instances.TryGetValue(s_Ref.InstanceId, out var s_Instance) && s_Instance is fb.MeshVariationDatabaseEntry s_Entry)
                yield return s_Entry;
        }
    }
}
