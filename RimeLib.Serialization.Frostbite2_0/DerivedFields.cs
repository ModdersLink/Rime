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

    public EngineType[] GetSupportedEngines() => [EngineType.Frostbite2_0];

    public IReadOnlySet<string> Fields { get; } = new HashSet<string> { c_RuntimeComponentCount };

    public void Derive(DatabasePartitionBase p_Partition, ConversionReport p_Report)
    {
        var s_Instances = p_Partition.Instances.ToDictionary(p_I => p_I.InstanceId);
        foreach (var s_Entity in s_Instances.Values.OfType<GameEntityData>())
        {
            // A component in another partition would have to be counted with its own; the value converted is kept.
            if (ComponentCount(s_Entity.Components, p_Partition.PartitionGuid, s_Instances) is not { } s_Count)
                ConversionReport.Count(p_Report.Underived, $"{c_RuntimeComponentCount}: a component in another partition");
            else if (s_Count > sbyte.MaxValue)
                ConversionReport.Count(p_Report.Underived, $"{c_RuntimeComponentCount}: more than {sbyte.MaxValue} components");
            else
                s_Entity.RuntimeComponentCount = (sbyte)s_Count;
        }
    }

    /// <summary>
    /// The components among these objects and, through each, its own (an entity's components are
    /// its own), or none if one is in another partition.
    /// </summary>
    private static int? ComponentCount(RefArray<GameObjectData> p_Objects, GUID p_Partition, Dictionary<DataContainerId, DataContainerBase> p_Instances)
    {
        var s_Count = 0;
        foreach (var s_Ref in p_Objects)
        {
            if (s_Ref.IsNull())
                continue;

            if (s_Ref.PartitionGuid != p_Partition || !p_Instances.TryGetValue(s_Ref.InstanceId, out var s_Object))
                return null;

            if (s_Object is ComponentData s_Component)
            {
                if (ComponentCount(s_Component.Components, p_Partition, p_Instances) is not { } s_Own)
                    return null;
                s_Count += 1 + s_Own;
            }
        }

        return s_Count;
    }
}
