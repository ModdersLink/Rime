using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using RimeLib.Frostbite;

namespace RimeLib.Serialization.Frostbite2013_2;

/// <summary>Frostbite 2013.2 mesh variation databases: entries and redirects are structs inside the database.</summary>
public class MeshVariationRules : IMeshVariationRules
{
    public EngineType[] GetSupportedEngines()
    {
        return new[] { EngineType.Frostbite2013_2 };
    }

    public IEnumerable<(CtrRefBase Mesh, uint VariationHash, object Entry)> ReadEntries(DatabasePartitionBase p_Partition)
    {
        if (p_Partition.PrimaryInstance is not fb.Render.MeshVariationDatabase s_Database)
            yield break;

        foreach (var s_Entry in s_Database.Entries)
        {
            if (s_Entry != null)
                yield return (s_Entry.Mesh, s_Entry.VariationAssetNameHash, s_Entry);
        }
    }

    public IEnumerable<(CtrRefBase Mesh, uint VariationHash)> ReadRedirects(DatabasePartitionBase p_Partition)
    {
        if (p_Partition.PrimaryInstance is not fb.Render.MeshVariationDatabase s_Database)
            yield break;

        foreach (var s_Entry in s_Database.RedirectEntries)
        {
            if (s_Entry != null)
                yield return (s_Entry.Mesh, s_Entry.VariationAssetNameHash);
        }
    }

    public bool PlainEntryWithVariations => true;

    public bool IsMesh(DataContainerBase p_Instance) => p_Instance is fb.Render.MeshAsset;

    // Retail sub-worlds without meshes (gameplay, all_gamemodes_except_dm) have no database.
    public bool OmitsEmptyDatabase => true;

    public void SetEntries(DatabasePartitionBase p_Database, IReadOnlyList<object> p_Entries)
    {
        var s_Database = (fb.Render.MeshVariationDatabase)p_Database.PrimaryInstance;
        s_Database.Entries.Clear();
        s_Database.RedirectEntries.Clear();
        s_Database.Entries.AddRange(p_Entries.Cast<fb.Render.MeshVariationDatabaseEntry>());
    }

    // Static model groups are measured on Frostbite 2 only so far.
    // Unlike Frostbite 2, the databases bind particle emitters' meshes too.
    public bool UsesMeshesUnvaried(DataContainerBase p_Instance) => false;

    public IEnumerable<(CtrRefBase Placed, uint VariationHash)> GetPlacements(DataContainerBase p_Instance, System.Func<CtrRefBase, DataContainerBase?> p_Resolve)
    {
        switch (p_Instance)
        {
            case fb.GameShared.StaticModelGroupEntityData s_Group:
                foreach (var s_Member in s_Group.MemberDatas)
                {
                    var s_Hashes = Enumerable.Range(0, (int)s_Member.InstanceCount)
                        .Select(i => i < s_Member.InstanceObjectVariation.Count ? s_Member.InstanceObjectVariation[i] : 0u).Distinct().ToList();
                    foreach (var s_Placed in new CtrRefBase[] { s_Member.MeshAsset, s_Member.MemberType }.Where(p_R => !p_R.IsNull()))
                    foreach (var s_Hash in s_Hashes)
                        yield return (s_Placed, s_Hash);
                }
                break;

            case fb.Entity.ReferenceObjectData s_Reference when !s_Reference.Blueprint.IsNull():
                yield return (s_Reference.Blueprint, p_Resolve(s_Reference.ObjectVariation) is fb.Entity.ObjectVariation s_Variation ? s_Variation.NameHash : 0u);
                break;
        }
    }

    public uint? GetVariationHash(DataContainerBase p_Instance) => (p_Instance as fb.Entity.ObjectVariation)?.NameHash;

    public string Fingerprint(object p_Entry)
    {
        var s_Entry = (fb.Render.MeshVariationDatabaseEntry)p_Entry;
        return JsonConvert.SerializeObject(s_Entry.Materials.Select(p_M => new
        {
            Material = Ref(p_M.Material),
            Variation = Ref(p_M.MaterialVariation),
            Textures = p_M.TextureParameters.Select(p_T => $"{p_T.ParameterName}={Ref(p_T.Value)}"),
        }));
    }

    public IEnumerable<CtrRefBase> GetDrawnMaterials(object p_Entry) =>
        ((fb.Render.MeshVariationDatabaseEntry)p_Entry).Materials.Select(p_M => p_M.MaterialVariation.IsNull() ? (CtrRefBase)p_M.Material : p_M.MaterialVariation).Where(p_R => !p_R.IsNull());

    private static string Ref(CtrRefBase p_Ref) => p_Ref.IsNull() ? "" : $"{p_Ref.PartitionGuid}/{p_Ref.InstanceId}";
}
