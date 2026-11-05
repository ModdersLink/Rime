using System.Collections.Generic;
using System.Linq;
using fb;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Conversion;

namespace RimeLib.Serialization.Frostbite2_0;

public class DerivedFields : IDerivedFields
{
    private const string c_RuntimeComponentCount = "GameEntityData.RuntimeComponentCount";
    private const string c_IndexInBlueprint = "GameObjectData.IndexInBlueprint";
    private const string c_TemplateName = "EmitterTemplateData.Name";
    private const string c_NameHash = "SoundDataAsset.NameHash";
    private const string c_Normals = "VectorShapeData.Normals";
    private const ushort c_NoIndex = ushort.MaxValue;

    public EngineType[] GetSupportedEngines() => [EngineType.Frostbite2_0];

    public IReadOnlySet<string> Fields { get; } = new HashSet<string> { c_RuntimeComponentCount, c_IndexInBlueprint, c_TemplateName, c_NameHash, c_Normals };

    public void Derive(DatabasePartitionBase p_Partition, ConversionReport p_Report)
    {
        var s_Partition = Scope.Of(p_Partition);
        ListLinkedObjects(p_Partition);
        NumberObjects(p_Partition, s_Partition, 0);
        Name(p_Partition);

        // A redirect takes the materials of its mesh's plain entry in the same database, which the
        // game reads without checking it is there.
        foreach (var s_Database in s_Partition.Instances.Values.OfType<MeshVariationDatabase>())
        {
            var s_Plain = s_Database.Entries.Select(p_E => s_Partition.Find(p_E)).OfType<MeshVariationDatabaseEntry>()
                .Where(p_E => p_E.VariationAssetNameHash == 0).Select(p_E => (p_E.Mesh.PartitionGuid, p_E.Mesh.InstanceId)).ToHashSet();
            s_Database.RedirectEntries.RemoveAll(p_R =>
                s_Partition.Find(p_R) is MeshVariationDatabaseEntry s_Redirect && !s_Plain.Contains((s_Redirect.Mesh.PartitionGuid, s_Redirect.Mesh.InstanceId)));
        }

        // A shape has a normal per point, up for the flat areas a level's shapes are.
        foreach (var s_Shape in s_Partition.Instances.Values.OfType<VectorShapeData>().Where(p_S => p_S.Normals.Count != p_S.Points.Count))
            s_Shape.Normals = s_Shape.Points.Select(_ => new Vec3 { y = 1 }).ToList();

        foreach (var s_Entity in s_Partition.Instances.Values.OfType<GameEntityData>())
        {
            // A component in another partition would have to be counted with its own; the value converted is kept.
            if (ComponentCount(s_Entity.Components, s_Partition) is not { } s_Count)
                ConversionReport.Count(p_Report.Underived, $"{c_RuntimeComponentCount}: a component in another partition");
            else if (s_Count > sbyte.MaxValue)
                ConversionReport.Count(p_Report.Underived, $"{c_RuntimeComponentCount}: more than {sbyte.MaxValue} components");
            else
                s_Entity.RuntimeComponentCount = (sbyte)s_Count;
        }
    }

    /// <summary>
    /// Numbers the objects of each level's or sub-world's layers after its own, layer by layer in the
    /// order it references them.
    /// </summary>
    public void DeriveAcross(IReadOnlyCollection<DatabasePartitionBase> p_Partitions, ConversionReport p_Report)
    {
        var s_Partitions = p_Partitions.ToDictionary(p_P => p_P.PartitionGuid);
        var s_Numbered = new HashSet<GUID>();
        foreach (var s_World in p_Partitions.Where(p_P => p_P.PrimaryInstance is SubWorldData))
        {
            var s_Next = s_World.Instances.OfType<GameObjectData>().Count(p_O => p_O.IndexInBlueprint != c_NoIndex);
            foreach (var s_Layer in s_World.Instances.OfType<WorldPartReferenceObjectData>().OrderBy(p_R => p_R.IndexInBlueprint))
            {
                if (!s_Partitions.TryGetValue(s_Layer.Blueprint.PartitionGuid, out var s_Part) || s_Part.PrimaryInstance is not WorldPartData)
                    continue;

                s_Next += NumberObjects(s_Part, Scope.Of(s_Part), s_Next);
                s_Numbered.Add(s_Part.PartitionGuid);
            }
        }

        foreach (var s_Part in p_Partitions.Where(p_P => p_P.PrimaryInstance is WorldPartData && !s_Numbered.Contains(p_P.PartitionGuid)))
            ConversionReport.Count(p_Report.Underived, $"{c_IndexInBlueprint}: a world part no level converted with it references, numbered from 0");
    }

    private sealed record Scope(GUID Partition, Dictionary<DataContainerId, DataContainerBase> Instances)
    {
        public static Scope Of(DatabasePartitionBase p_Partition) =>
            new(p_Partition.PartitionGuid, p_Partition.Instances.ToDictionary(p_I => p_I.InstanceId));

        /// <summary>The instance a reference points at in the partition, if it points into it.</summary>
        public DataContainerBase? Find(CtrRefBase p_Ref) =>
            p_Ref.PartitionGuid == Partition ? Instances.GetValueOrDefault(p_Ref.InstanceId) : null;
    }

    /// <summary>
    /// Names an emitter's document and template after the partition, where they have no name, and
    /// sets each sound's name hash.
    /// </summary>
    private static void Name(DatabasePartitionBase p_Partition)
    {
        foreach (var s_Instance in p_Partition.Instances)
        {
            switch (s_Instance)
            {
                case EmitterDocument { Name.Length: 0 } s_Document:
                    s_Document.Name = p_Partition.Name;
                    break;
                case EmitterTemplateData { Name.Length: 0 } s_Template:
                    s_Template.Name = p_Partition.Name;
                    break;
            }
        }

        foreach (var s_Sound in p_Partition.Instances.OfType<SoundDataAsset>())
            s_Sound.NameHash = Frostbite.Utils.HashQuick(s_Sound.Name);
    }

    /// <summary>
    /// Lists in a world part the objects nothing in it refers to, which other blueprints link to (a
    /// mode's spawn points and areas): the game creates only listed objects.
    /// </summary>
    private static void ListLinkedObjects(DatabasePartitionBase p_Partition)
    {
        if (p_Partition.PrimaryInstance is not WorldPartData s_Part)
            return;

        var s_Referenced = p_Partition.Instances.Where(p_I => p_I != s_Part)
            .SelectMany(PartitionConversion.References)
            .Concat(s_Part.Objects)
            .Where(p_R => p_R.PartitionGuid == p_Partition.PartitionGuid)
            .Select(p_R => p_R.InstanceId)
            .ToHashSet();
        foreach (var s_Object in p_Partition.Instances.OfType<GameObjectData>().Where(p_O => !s_Referenced.Contains(p_O.InstanceId)))
            s_Part.Objects.Add(new CtrRef<GameObjectData>(p_Partition.PartitionGuid, s_Object.InstanceId));
    }

    /// <summary>
    /// Numbers a blueprint's objects and their components from <paramref name="p_First"/> in the
    /// order a walk through them first reaches them, returning how many; components of components,
    /// an effect's objects and objects the walk does not reach have no index.
    /// </summary>
    private static int NumberObjects(DatabasePartitionBase p_Partition, Scope p_Scope, int p_First)
    {
        foreach (var s_Object in p_Scope.Instances.Values.OfType<GameObjectData>())
            s_Object.IndexInBlueprint = c_NoIndex;

        IEnumerable<CtrRefBase> s_Roots = p_Partition.PrimaryInstance switch
        {
            PrefabBlueprint s_Prefab => s_Prefab.Objects,
            ObjectBlueprint s_Blueprint => [s_Blueprint.Object],
            _ => [],
        };

        var s_Next = p_First;
        var s_Reached = new HashSet<GameObjectData>(ReferenceEqualityComparer.Instance);
        foreach (var s_Root in s_Roots)
            Number(s_Root, null, 0);
        return s_Next - p_First;

        void Number(CtrRefBase p_Ref, GameObjectData? p_Parent, int p_Depth)
        {
            if (p_Scope.Find(p_Ref) is not GameObjectData s_Object || !s_Reached.Add(s_Object))
                return;

            if (p_Depth == 0 || (p_Depth == 1 && p_Parent is not EffectEntityData))
                s_Object.IndexInBlueprint = (ushort)s_Next++;

            foreach (var s_Component in Components(s_Object))
                Number(s_Component, s_Object, p_Depth + 1);
        }
    }

    private static IEnumerable<CtrRefBase> Components(GameObjectData p_Object) => p_Object switch
    {
        GameEntityData s_Entity => s_Entity.Components,
        EffectEntityData s_Effect => s_Effect.Components,
        ComponentData s_Component => s_Component.Components,
        _ => [],
    };

    /// <summary>
    /// The components among these objects and, through each, its own (an entity's components are
    /// its own), or none if one is in another partition. A null reference counts as a component,
    /// as one the build left out.
    /// </summary>
    private static int? ComponentCount(RefArray<GameObjectData> p_Objects, Scope p_Scope)
    {
        var s_Count = 0;
        foreach (var s_Ref in p_Objects)
        {
            if (s_Ref.IsNull())
            {
                s_Count++;
                continue;
            }

            switch (p_Scope.Find(s_Ref))
            {
                case null:
                    return null;
                case ComponentData s_Component:
                    if (ComponentCount(s_Component.Components, p_Scope) is not { } s_Own)
                        return null;
                    s_Count += 1 + s_Own;
                    break;
            }
        }

        return s_Count;
    }
}
