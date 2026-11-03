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

/// <summary>Frostbite 2013.2's rules for converting to Frostbite 2, and the conversion's rule kinds through them.</summary>
public class ConversionRulesTest
{
    private static readonly GUID s_PartitionGuid = new(Guid.Parse("11111111-2222-3333-4444-555555555555"));
    private static readonly GUID s_Primary = new(Guid.Parse("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeeee"));

    private static PartitionConversion Conversion() => PartitionConversion.Between(EngineType.Frostbite2013_2, EngineType.Frostbite2_0);

    private static Bf4 Partition(params DataContainerBase[] p_Instances)
    {
        var s_Partition = new Bf4 { Name = "fx/test", PartitionGuid = s_PartitionGuid, PrimaryInstanceGuid = s_Primary };
        foreach (var s_Instance in p_Instances)
            s_Partition.InstanceMap.Add(s_Instance.InstanceId, s_Instance);
        return s_Partition;
    }

    private static CtrRefBase Ref(DataContainerBase p_Instance) => new(s_PartitionGuid, p_Instance.InstanceId);

    /// <summary>An emitter with a template for low and medium, one for high and ultra, and a processor each.</summary>
    private static Bf4 Emitter()
    {
        var s_Document = new fb.Emitter.ScalableEmitterDocument { InstanceId = new DataContainerId.Guid(s_Primary) };
        var s_Low = new fb.Emitter.EmitterTemplateData { InstanceId = new DataContainerId.Index(1), MaxCount = 10 };
        var s_High = new fb.Emitter.EmitterTemplateData
        {
            InstanceId = new DataContainerId.Index(2),
            MaxCount = 40,
            EmittableType = fb.Emitter.EmittableType.EmittableType_Quad,
            EmittableAlignment = fb.Emitter.EmittableAlignment.EmittableAlignment_Direction,
        };
        var s_LowSize = new fb.Emitter.SpawnSizeData { InstanceId = new DataContainerId.Index(3), Size = 1 };
        var s_HighSize = new fb.Emitter.SpawnSizeData { InstanceId = new DataContainerId.Index(4), Size = 2 };

        s_Document.TemplateDataLow.SetValue(Ref(s_Low));
        s_Document.TemplateDataMedium.SetValue(Ref(s_Low));
        s_Document.TemplateDataHigh.SetValue(Ref(s_High));
        s_Document.TemplateDataUltra.SetValue(Ref(s_High));
        s_Low.RootProcessor.SetValue(Ref(s_LowSize));
        s_High.RootProcessor.SetValue(Ref(s_HighSize));
        return Partition(s_Document, s_Low, s_High, s_LowSize, s_HighSize);
    }

    [Fact]
    public void MakesTheHighTemplateTheEmitterAndItsDocument()
    {
        var s_Partition = Conversion().Convert(Emitter());

        var s_Template = Assert.IsType<fb.EmitterTemplateData>(s_Partition.PrimaryInstance);
        var s_Document = s_Partition.Instances.OfType<fb.EmitterDocument>().Single();
        Assert.Equal(40u, s_Template.MaxCount);
        Assert.Equal(s_Template.InstanceId, s_Document.TemplateData.InstanceId);
        Assert.Equal(s_Template.RootProcessor.InstanceId, s_Document.RootProcessor.InstanceId);
        Assert.Equal(2, Assert.IsType<fb.SpawnSizeData>(s_Partition.Instances.Single(p_I => p_I.InstanceId == s_Template.RootProcessor.InstanceId)).Size);
        Assert.Equal("fx/test", s_Template.Name);
        Assert.Equal("fx/test", s_Document.Name);
    }

    [Fact]
    public void DropsTheTemplatesNothingReferencesAnyMore()
    {
        var s_Conversion = Conversion();
        var s_Partition = s_Conversion.Convert(Emitter());

        Assert.Equal(3, s_Partition.Instances.Count());
        Assert.Equal(1, s_Conversion.Report.Unreferenced["EmitterTemplateData"]);
        Assert.Equal(1, s_Conversion.Report.Unreferenced["SpawnSizeData"]);
        Assert.Equal(1, s_Conversion.Report.DroppedFields["ScalableEmitterDocument.TemplateDataLow"]);
        Assert.DoesNotContain("ScalableEmitterDocument.TemplateDataHigh", s_Conversion.Report.DroppedFields.Keys);
    }

    [Fact]
    public void AlignsQuadsByTheirType()
    {
        var s_Partition = Conversion().Convert(Emitter());

        Assert.Equal(fb.EmittableType.DirectionAlignedQuad, ((fb.EmitterTemplateData)s_Partition.PrimaryInstance).EmittableType);
        Assert.True(s_Partition.Instances.OfType<fb.SpawnSizeData>().Single().Enable);
    }

    [Fact]
    public void EnablesEffectsByQualityAndKeepsTheConnectionRealms()
    {
        var s_Effect = new fb.Entity.EffectEntityData
        {
            InstanceId = new DataContainerId.Guid(s_Primary),
            // Event connections from the server, property connections from both realms.
            Flags = (2u << 25) | (3u << 27),
        };
        s_Effect.Enable.Low = false;
        s_Effect.Enable.Medium = true;
        s_Effect.Enable.High = true;
        s_Effect.MaxActiveInstanceCount.High = 8;

        var s_Conversion = Conversion();
        var s_Converted = (fb.EffectEntityData)s_Conversion.Convert(Partition(s_Effect)).PrimaryInstance;

        Assert.False(s_Converted.LowEndPc);
        Assert.True(s_Converted.MediumPc);
        Assert.True(s_Converted.HighEndPc);
        Assert.Equal(8u, s_Converted.MaxInstanceCount);
        Assert.Equal(1, s_Converted.IsEventConnectionTarget);
        Assert.Equal(2, s_Converted.IsPropertyConnectionTarget);
        Assert.DoesNotContain("GameObjectData.IsEventConnectionTarget", s_Conversion.Report.MissingFields.Keys);
    }

    [Fact]
    public void MarksAnObjectNoConnectionTargets()
    {
        var s_Effect = new fb.Entity.EffectEntityData { InstanceId = new DataContainerId.Guid(s_Primary) };

        var s_Converted = (fb.EffectEntityData)Conversion().Convert(Partition(s_Effect)).PrimaryInstance;

        Assert.Equal(3, s_Converted.IsEventConnectionTarget);
        Assert.Equal(3, s_Converted.IsPropertyConnectionTarget);
    }

    /// <summary>An evaluator using a parameter of a global list in another partition, as BF4's do.</summary>
    private static (Bf4 Evaluator, Bf4 List) EvaluatorWithParameter(string p_Name)
    {
        var s_ListGuid = new GUID(Guid.Parse("99999999-2222-3333-4444-555555555555"));
        var s_Parameter = new fb.Entity.EffectParameter { InstanceId = new DataContainerId.Guid(new GUID(Guid.NewGuid())), Name = p_Name };
        var s_List = new Bf4 { Name = "fx/globaleffectparameterlist", PartitionGuid = s_ListGuid, PrimaryInstanceGuid = ((DataContainerId.Guid)s_Parameter.InstanceId).Id };
        s_List.InstanceMap.Add(s_Parameter.InstanceId, s_Parameter);

        var s_Evaluator = new fb.Emitter.PolynomialData { InstanceId = new DataContainerId.Guid(s_Primary) };
        s_Evaluator.Parameter.SetValue(new CtrRefBase(s_ListGuid, s_Parameter.InstanceId));
        return (Partition(s_Evaluator), s_List);
    }

    [Fact]
    public void NamesTheEvaluatorsParameterThroughThePartitionItIsIn()
    {
        var (s_Evaluator, s_List) = EvaluatorWithParameter("EmitterParameterDistance");
        var s_Conversion = Conversion();
        s_Conversion.SourcePartitions = p_Guid => p_Guid == s_List.PartitionGuid ? s_List : null;

        var s_Converted = (fb.PolynomialData)s_Conversion.Convert(s_Evaluator).PrimaryInstance;

        Assert.Equal(fb.EmitterParameter.EmitterParameterDistance, s_Converted.EmitterParameter);
    }

    [Fact]
    public void CountsParametersTheTargetHasNoValueForAndOnesNotFound()
    {
        var (s_Evaluator, s_List) = EvaluatorWithParameter("Speed");
        var s_Named = Conversion();
        s_Named.SourcePartitions = _ => s_List;
        var s_Unfound = Conversion();

        s_Named.Convert(s_Evaluator);
        s_Unfound.Convert(s_Evaluator);

        Assert.Equal(1, s_Named.Report.UnconvertedValues["PolynomialData.Parameter.Name: no EmitterParameter Speed"]);
        Assert.Equal(1, s_Unfound.Report.UnconvertedValues["PolynomialData.Parameter.Name: a reference on the way to a partition not found"]);
    }

    [Fact]
    public void GivesEachSoundVariationItsRangeOfTheWavesSegments()
    {
        var s_Wave = new fb.Audio.SoundWaveAsset { InstanceId = new DataContainerId.Guid(s_Primary), Name = "Sound/Test_Wave" };
        for (var i = 0; i < 3; i++)
            s_Wave.Segments.Add(new fb.Audio.SoundWaveVariationSegment { SamplesOffset = (uint)i * 100 });
        s_Wave.RuntimeVariations.Add(new fb.Audio.SoundWaveRuntimeVariation { FirstSegmentIndex = 0, SegmentCount = 1, ChunkIndex = 0 });
        s_Wave.RuntimeVariations.Add(new fb.Audio.SoundWaveRuntimeVariation { FirstSegmentIndex = 1, SegmentCount = 2, ChunkIndex = 1, LastLoopSegmentIndex = 1, PersistentDataSize = 44 });
        var s_Conversion = Conversion();

        var s_Partition = s_Conversion.Convert(Partition(s_Wave));

        var s_Converted = (fb.SoundWaveAsset)s_Partition.PrimaryInstance;
        var s_Variations = s_Converted.Variations
            .Select(p_Ref => (fb.SoundWaveVariation)s_Partition.Instances.Single(p_I => p_I.InstanceId == p_Ref.InstanceId))
            .ToList();
        Assert.Equal(new uint[] { 0 }, s_Variations[0].Segments.Select(p_S => p_S.SamplesOffset));
        Assert.Equal(new uint[] { 100, 200 }, s_Variations[1].Segments.Select(p_S => p_S.SamplesOffset));
        Assert.Equal(1, s_Variations[1].ChunkIndex);
        Assert.Equal(1, s_Variations[1].LastLoopSegmentIndex);
        Assert.Equal(44u, s_Variations[1].SeekTablesSize);
        Assert.Equal(RimeLib.Frostbite.Utils.HashQuick("Sound/Test_Wave"), s_Converted.NameHash);
        Assert.DoesNotContain("SoundWaveAsset.Segments", s_Conversion.Report.DroppedFields.Keys);
    }

    [Fact]
    public void SplitsTheBusFlagsIntoTheirFields()
    {
        var s_Blueprint = new fb.Entity.LogicPrefabBlueprint { InstanceId = new DataContainerId.Guid(s_Primary), Flags = 0b1010 };

        var s_Converted = (fb.LogicPrefabBlueprint)Conversion().Convert(Partition(s_Blueprint)).PrimaryInstance;

        Assert.False(s_Converted.NeedNetworkId);
        Assert.True(s_Converted.InterfaceHasConnections);
        Assert.False(s_Converted.AlwaysCreateEntityBusClient);
        Assert.True(s_Converted.AlwaysCreateEntityBusServer);
    }
}
