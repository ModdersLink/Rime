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
    /// not have and a child static model with one part.
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

        s_Model.Components.AddRef(new CtrRefBase(s_Partition, s_Part.InstanceId));
        s_Model.Components.AddRef(new CtrRefBase(s_Partition, s_Aiming.InstanceId));
        s_Model.Components.AddRef(new CtrRefBase(s_Partition, s_Child.InstanceId));
        s_Part.Components.AddRef(new CtrRefBase(s_Partition, s_Inner.InstanceId));
        s_Child.Components.AddRef(new CtrRefBase(s_Partition, s_ChildPart.InstanceId));

        foreach (var s_Instance in new DataContainerBase[] { s_Model, s_Part, s_Inner, s_Aiming, s_Child, s_ChildPart })
            s_Partition4.InstanceMap.Add(s_Instance.InstanceId, s_Instance);
        return s_Partition4;
    }

    private static PartitionConversion Conversion() => new(new EbxTypeLibrary(), null, new DerivedFields());

    [Fact]
    public void CountsTheComponentsTheTargetKeepsThroughComponentsOnly()
    {
        var s_Partition = Conversion().Convert(Bf4Model());

        var s_Model = (fb.StaticModelEntityData)s_Partition.PrimaryInstance;
        var s_Child = s_Partition.Instances.OfType<fb.StaticModelEntityData>().Single(p_M => p_M != s_Model);
        Assert.Equal(2, s_Model.RuntimeComponentCount);
        Assert.Equal(1, s_Child.RuntimeComponentCount);
    }

    [Fact]
    public void LeavesTheDerivedFieldOutOfTheMissingFields()
    {
        var s_Conversion = Conversion();
        s_Conversion.Convert(Bf4Model());

        Assert.DoesNotContain("GameEntityData.RuntimeComponentCount", s_Conversion.Report.MissingFields.Keys);
        Assert.Contains("GameObjectData.IndexInBlueprint", s_Conversion.Report.MissingFields.Keys);
    }

    [Fact]
    public void KeepsTheValueConvertedWhenAComponentIsInAnotherPartition()
    {
        var s_Source = Bf4Model();
        ((fb.GameShared.StaticModelEntityData)s_Source.PrimaryInstance).Components
            .AddRef(new CtrRefBase(new GUID(Guid.NewGuid()), new DataContainerId.Guid(new GUID(Guid.NewGuid()))));
        var s_Conversion = Conversion();

        var s_Model = (fb.StaticModelEntityData)s_Conversion.Convert(s_Source).PrimaryInstance;

        Assert.Equal(0, s_Model.RuntimeComponentCount);
        Assert.Equal(1, s_Conversion.Report.Underived["GameEntityData.RuntimeComponentCount: a component in another partition"]);
    }

    [Fact]
    public void IsTheTargetsInterface() =>
        Assert.IsType<DerivedFields>(EngineInterfaceRegistry.Create<IDerivedFields>(EngineType.Frostbite2_0));
}
