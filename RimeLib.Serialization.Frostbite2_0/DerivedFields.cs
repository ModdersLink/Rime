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
    private const ushort c_NoIndex = ushort.MaxValue;

    public EngineType[] GetSupportedEngines() => [EngineType.Frostbite2_0];

    public IReadOnlySet<string> Fields { get; } = new HashSet<string> { c_RuntimeComponentCount, c_IndexInBlueprint };

    public void Derive(DatabasePartitionBase p_Partition, ConversionReport p_Report)
    {
        var s_Partition = new Scope(p_Partition.PartitionGuid, p_Partition.Instances.ToDictionary(p_I => p_I.InstanceId));
        NumberObjects(p_Partition, s_Partition, p_Report);

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

    private sealed record Scope(GUID Partition, Dictionary<DataContainerId, DataContainerBase> Instances)
    {
        /// <summary>The instance a reference points at in the partition, if it points into it.</summary>
        public DataContainerBase? Find(CtrRefBase p_Ref) =>
            p_Ref.PartitionGuid == Partition ? Instances.GetValueOrDefault(p_Ref.InstanceId) : null;
    }

    /// <summary>
    /// Numbers a blueprint's objects and their components in the order a walk through them first
    /// reaches them; components of components, an effect's objects and objects the walk does not
    /// reach have no index. A world part's numbers follow those of its level's other parts, so its
    /// values converted are kept.
    /// </summary>
    private static void NumberObjects(DatabasePartitionBase p_Partition, Scope p_Scope, ConversionReport p_Report)
    {
        if (p_Partition.PrimaryInstance is WorldPartData)
        {
            ConversionReport.Count(p_Report.Underived, $"{c_IndexInBlueprint}: a world part's objects, numbered after its level's");
            return;
        }

        foreach (var s_Object in p_Scope.Instances.Values.OfType<GameObjectData>())
            s_Object.IndexInBlueprint = c_NoIndex;

        IEnumerable<CtrRefBase> s_Roots = p_Partition.PrimaryInstance switch
        {
            PrefabBlueprint s_Prefab => s_Prefab.Objects,
            ObjectBlueprint s_Blueprint => [s_Blueprint.Object],
            _ => [],
        };

        var s_Next = 0;
        var s_Reached = new HashSet<GameObjectData>(ReferenceEqualityComparer.Instance);
        foreach (var s_Root in s_Roots)
            Number(s_Root, null, 0);

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
