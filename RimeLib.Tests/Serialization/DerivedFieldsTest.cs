using System;
using System.Linq;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization;
using RimeLib.Serialization.Conversion;
using RimeLib.Serialization.Frostbite2_0;
using Xunit;
using Bf4 = RimeLib.Serialization.Frostbite2013_2.Ebx.DatabasePartition;

namespace RimeLib.Tests.Serialization;

public class DerivedFieldsTest
{
    private static readonly GUID s_Partition = new(Guid.Parse("11111111-2222-3333-4444-555555555555"));
    private static readonly GUID s_Primary = new(Guid.Parse("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeeee"));

    /// <summary>
    /// A BF4 static model with a part that has a part of its own, an aiming component BF3 does
    /// not have and a child static model with one part, which has an aiming component of its own.
    /// </summary>
    private static Bf4 Bf4Model()
    {
        var s_Partition4 = new Bf4 { Name = "objects/crate/crate", PartitionGuid = s_Partition, PrimaryInstanceGuid = s_Primary };
        var s_Model = new fb.GameShared.StaticModelEntityData { InstanceId = new DataContainerId.Guid(s_Primary) };
        var s_Part = new fb.GameShared.PartComponentData { InstanceId = new DataContainerId.Index(1) };
        var s_Inner = new fb.GameShared.PartComponentData { InstanceId = new DataContainerId.Index(2) };
        var s_Aiming = new fb.Venice.AimingComponentData { InstanceId = new DataContainerId.Index(3) };
        var s_Child = new fb.GameShared.StaticModelEntityData { InstanceId = new DataContainerId.Index(4) };
        var s_ChildPart = new fb.GameShared.PartComponentData { InstanceId = new DataContainerId.Index(5) };
        var s_ChildAiming = new fb.Venice.AimingComponentData { InstanceId = new DataContainerId.Index(6) };

        s_Model.Components.AddRef(new CtrRefBase(s_Partition, s_Part.InstanceId));
        s_Model.Components.AddRef(new CtrRefBase(s_Partition, s_Aiming.InstanceId));
        s_Model.Components.AddRef(new CtrRefBase(s_Partition, s_Child.InstanceId));
        s_Part.Components.AddRef(new CtrRefBase(s_Partition, s_Inner.InstanceId));
        s_Child.Components.AddRef(new CtrRefBase(s_Partition, s_ChildPart.InstanceId));
        s_ChildPart.Components.AddRef(new CtrRefBase(s_Partition, s_ChildAiming.InstanceId));

        foreach (var s_Instance in new DataContainerBase[] { s_Model, s_Part, s_Inner, s_Aiming, s_Child, s_ChildPart, s_ChildAiming })
            s_Partition4.InstanceMap.Add(s_Instance.InstanceId, s_Instance);
        return s_Partition4;
    }

    private static PartitionConversion Conversion() => new(new EbxTypeLibrary(), null, new DerivedFields());

    /// <summary>
    /// A component the target has no type for is left a null reference, which counts as one the
    /// build left out, as in Frostbite 2's data; its own components are gone with it.
    /// </summary>
    [Fact]
    public void CountsComponentsThroughComponentsOnlyAndDroppedOnesAsLeftOut()
    {
        var s_Partition = Conversion().Convert(Bf4Model());

        var s_Model = (fb.StaticModelEntityData)s_Partition.PrimaryInstance;
        var s_Child = s_Partition.Instances.OfType<fb.StaticModelEntityData>().Single(p_M => p_M != s_Model);
        Assert.Equal(3, s_Model.RuntimeComponentCount);
        Assert.Equal(2, s_Child.RuntimeComponentCount);
        Assert.True(s_Model.Components[1].IsNull());
    }

    [Fact]
    public void NumbersTheBlueprintsObjectsAndTheirComponents()
    {
        var s_Source = Bf4Model();
        var s_Blueprint = new fb.Entity.ObjectBlueprint { InstanceId = new DataContainerId.Guid(s_Primary) };
        var s_Model = (fb.GameShared.StaticModelEntityData)s_Source.InstanceMap[new DataContainerId.Guid(s_Primary)];
        s_Model.InstanceId = new DataContainerId.Index(7);
        s_Source.InstanceMap.Remove(new DataContainerId.Guid(s_Primary));
        s_Source.InstanceMap.Add(s_Model.InstanceId, s_Model);
        s_Source.InstanceMap.Add(s_Blueprint.InstanceId, s_Blueprint);
        s_Blueprint.Object.SetValue(new CtrRefBase(s_Partition, s_Model.InstanceId));

        var s_Partition3 = Conversion().Convert(s_Source);

        // The model, its part and its child are numbered; the part's part and the child's part are not.
        var s_Root = s_Partition3.Instances.OfType<fb.StaticModelEntityData>().Single(p_M => p_M.Components.Count == 3);
        Assert.Equal(0, s_Root.IndexInBlueprint);
        Assert.Equal(new ushort[] { 0, 1, 2, ushort.MaxValue, ushort.MaxValue },
            s_Partition3.Instances.OfType<fb.GameObjectData>().Select(p_O => p_O.IndexInBlueprint).Order().ToArray());
    }

    [Fact]
    public void LeavesTheDerivedFieldOutOfTheMissingFields()
    {
        var s_Conversion = Conversion();
        s_Conversion.Convert(Bf4Model());

        Assert.DoesNotContain("GameEntityData.RuntimeComponentCount", s_Conversion.Report.MissingFields.Keys);
        Assert.Contains("GameObjectData.IsEventConnectionTarget", s_Conversion.Report.MissingFields.Keys);
    }

    [Fact]
    public void KeepsTheCountConvertedWhenAComponentIsInAnotherPartition()
    {
        var s_Source = Bf4Model();
        ((fb.GameShared.StaticModelEntityData)s_Source.PrimaryInstance).Components
            .AddRef(new CtrRefBase(new GUID(Guid.NewGuid()), new DataContainerId.Guid(new GUID(Guid.NewGuid()))));
        var s_Conversion = Conversion();

        var s_Model = (fb.StaticModelEntityData)s_Conversion.Convert(s_Source).PrimaryInstance;

        Assert.Equal(0, s_Model.RuntimeComponentCount);
        Assert.Equal(1, s_Conversion.Report.Underived["GameEntityData.RuntimeComponentCount: a component in another partition"]);
    }

    /// <summary>A partition of a prefab blueprint of these objects, BF4's way: the blueprint has the GUID.</summary>
    private static Bf4 Prefab(GUID p_Guid, fb.Entity.PrefabBlueprint p_Blueprint, params fb.Entity.GameObjectData[] p_Objects)
    {
        var s_Partition4 = new Bf4 { Name = $"levels/test/{p_Guid}", PartitionGuid = p_Guid, PrimaryInstanceGuid = p_Guid };
        p_Blueprint.InstanceId = new DataContainerId.Guid(p_Guid);
        s_Partition4.InstanceMap.Add(p_Blueprint.InstanceId, p_Blueprint);
        for (var i = 0; i < p_Objects.Length; i++)
        {
            p_Objects[i].InstanceId = new DataContainerId.Index(i + 1);
            s_Partition4.InstanceMap.Add(p_Objects[i].InstanceId, p_Objects[i]);
            p_Blueprint.Objects.AddRef(new CtrRefBase(p_Guid, p_Objects[i].InstanceId));
        }

        return s_Partition4;
    }

    [Fact]
    public void NumbersALevelsLayersAfterItsObjectsInTheOrderItReferencesThem()
    {
        var s_First = new GUID(Guid.Parse("00000000-0000-0000-0000-000000001000"));
        var s_Second = new GUID(Guid.Parse("00000000-0000-0000-0000-000000002000"));
        var s_Level = new GUID(Guid.Parse("00000000-0000-0000-0000-000000003000"));
        // The level references the second layer before the first.
        var s_ToSecond = new fb.Entity.WorldPartReferenceObjectData();
        s_ToSecond.Blueprint.SetValue(s_Second, new DataContainerId.Guid(s_Second));
        var s_ToFirst = new fb.Entity.WorldPartReferenceObjectData();
        s_ToFirst.Blueprint.SetValue(s_First, new DataContainerId.Guid(s_First));
        var s_Conversion = Conversion();

        var s_Partitions = new[]
        {
            s_Conversion.Convert(Prefab(s_Level, new fb.Entity.SubWorldData(), s_ToSecond, s_ToFirst)),
            s_Conversion.Convert(Prefab(s_First, new fb.Entity.WorldPartData(), new fb.GameShared.StaticModelEntityData())),
            s_Conversion.Convert(Prefab(s_Second, new fb.Entity.WorldPartData(), new fb.GameShared.StaticModelEntityData(), new fb.GameShared.StaticModelEntityData())),
        };
        s_Conversion.DeriveAcross(s_Partitions);

        ushort[] Indices(int p_Partition) => s_Partitions[p_Partition].Instances.OfType<fb.GameObjectData>().Select(p_O => p_O.IndexInBlueprint).Order().ToArray();
        Assert.Equal(new ushort[] { 0, 1 }, Indices(0));
        Assert.Equal(new ushort[] { 4 }, Indices(1));
        Assert.Equal(new ushort[] { 2, 3 }, Indices(2));
        Assert.Empty(s_Conversion.Report.Underived);
    }

    [Fact]
    public void CountsALayerNoLevelReferences()
    {
        var s_Layer = new GUID(Guid.Parse("00000000-0000-0000-0000-000000001000"));
        var s_Conversion = Conversion();

        var s_Partition3 = s_Conversion.Convert(Prefab(s_Layer, new fb.Entity.WorldPartData(), new fb.GameShared.StaticModelEntityData()));
        s_Conversion.DeriveAcross([s_Partition3]);

        Assert.Equal(0, s_Partition3.Instances.OfType<fb.GameObjectData>().Single().IndexInBlueprint);
        Assert.Equal(1, s_Conversion.Report.Underived["GameObjectData.IndexInBlueprint: a world part no level converted with it references, numbered from 0"]);
    }

    [Fact]
    public void IsTheTargetsInterface() =>
        Assert.IsType<DerivedFields>(EngineInterfaceRegistry.Create<IDerivedFields>(EngineType.Frostbite2_0));
}
