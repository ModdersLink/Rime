using System;
using System.Collections.Generic;
using System.Linq;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization;
using RimeLib.Serialization.Conversion;
using RimeLib.Serialization.Frostbite2_0;
using Xunit;
using Bf3 = RimeLib.Serialization.Frostbite2_0.Ebx.DatabasePartition;
using Bf4 = RimeLib.Serialization.Frostbite2013_2.Ebx.DatabasePartition;

namespace RimeLib.Tests.Serialization;

public class PartitionConversionTest
{
    private static readonly GUID s_Partition = new(Guid.Parse("11111111-2222-3333-4444-555555555555"));
    private static readonly GUID s_Primary = new(Guid.Parse("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeeee"));

    /// <summary>A BF4 mesh asset whose material is an instance without a GUID, as BF4 stores them.</summary>
    private static Bf4 Bf4Mesh(fb.Render.EnlightenType p_Enlighten = fb.Render.EnlightenType.EnlightenType_Static)
    {
        var s_Material = new fb.Render.MeshMaterial { InstanceId = new DataContainerId.Index(1), TessellationTriangleSize = 4 };
        var s_Mesh = new fb.Render.RigidMeshAsset
        {
            InstanceId = new DataContainerId.Guid(s_Primary),
            Name = "objects/crate/crate_mesh",
            LodScale = 2,
            EnlightenType = p_Enlighten,
            MeshSetResource = new ResourceRef(0x1234),
        };
        s_Mesh.Materials.AddRef(new CtrRefBase(s_Partition, s_Material.InstanceId));

        var s_Partition4 = new Bf4 { Name = "objects/crate/crate_mesh", PartitionGuid = s_Partition, PrimaryInstanceGuid = s_Primary };
        s_Partition4.InstanceMap.Add(s_Mesh.InstanceId, s_Mesh);
        s_Partition4.InstanceMap.Add(s_Material.InstanceId, s_Material);
        return s_Partition4;
    }

    [Fact]
    public void CopiesFieldsByName()
    {
        var s_Conversion = new PartitionConversion(new EbxTypeLibrary());
        var s_Partition = (Bf3)s_Conversion.Convert(Bf4Mesh());

        var s_Mesh = Assert.IsType<fb.RigidMeshAsset>(s_Partition.PrimaryInstance);
        Assert.Equal("objects/crate/crate_mesh", s_Mesh.Name);
        Assert.Equal(2, s_Mesh.LodScale);
        Assert.Equal(fb.EnlightenType.EnlightenType_Static, s_Mesh.EnlightenType);
        Assert.Equal(2, s_Conversion.Report.ConvertedInstances);
    }

    [Fact]
    public void GivesInstancesWithoutAGuidOneTheirReferencesUseToo()
    {
        var s_Partition = (Bf3)new PartitionConversion(new EbxTypeLibrary()).Convert(Bf4Mesh());

        var s_Material = Assert.IsType<fb.MeshMaterial>(s_Partition.Instances.Single(p_I => p_I is fb.MeshMaterial));
        var s_Ref = ((fb.RigidMeshAsset)s_Partition.PrimaryInstance).Materials.Single();
        Assert.Equal(PartitionConversion.InstanceGuid(s_Partition.PartitionGuid, new DataContainerId.Index(1)), ((DataContainerId.Guid)s_Ref.InstanceId).Id);
        Assert.Equal(s_Material.InstanceId, s_Ref.InstanceId);
        Assert.Equal(s_Partition.PartitionGuid, s_Ref.PartitionGuid);
    }

    [Fact]
    public void CountsOnlyValuesSetInFieldsTheTargetLacks()
    {
        var s_Conversion = new PartitionConversion(new EbxTypeLibrary());
        s_Conversion.Convert(Bf4Mesh());

        // MeshSetResource is set; the material's tessellation fields other than the triangle size keep BF4's defaults.
        Assert.Equal(1, s_Conversion.Report.DroppedFields["RigidMeshAsset.MeshSetResource"]);
        Assert.Equal(1, s_Conversion.Report.DroppedFields["MeshMaterial.TessellationTriangleSize"]);
        Assert.DoesNotContain("MeshMaterial.TessellationMaxDistance", s_Conversion.Report.DroppedFields.Keys);
    }

    [Fact]
    public void MapsEnumsByValueName()
    {
        var s_Partition = new PartitionConversion(new EbxTypeLibrary()).Convert(Bf4Mesh(fb.Render.EnlightenType.EnlightenType_Dynamic));

        Assert.Equal(fb.EnlightenType.EnlightenType_Dynamic, ((fb.RigidMeshAsset)s_Partition.PrimaryInstance).EnlightenType);
    }

    [Fact]
    public void MakesInstancesOfStructsTheTargetReferences()
    {
        // BF4 keeps mesh variation database entries as structs; BF3 references entry instances.
        var s_Database = new fb.Render.MeshVariationDatabase { InstanceId = new DataContainerId.Guid(s_Primary) };
        var s_Entry = new fb.Render.MeshVariationDatabaseEntry { VariationAssetNameHash = 7 };
        s_Entry.Materials.Add(new fb.Render.MeshVariationDatabaseMaterial
        {
            TextureParameters = [new fb.Render.TextureShaderParameter { ParameterName = "_CS" }],
        });
        s_Database.Entries.Add(s_Entry);
        var s_Source = new Bf4 { Name = "levels/crate/meshvariationdb_win32", PartitionGuid = s_Partition, PrimaryInstanceGuid = s_Primary };
        s_Source.InstanceMap.Add(s_Database.InstanceId, s_Database);

        var s_Conversion = new PartitionConversion(new EbxTypeLibrary());
        var s_Converted = (Bf3)s_Conversion.Convert(s_Source);

        var s_Ref = Assert.Single(((fb.MeshVariationDatabase)s_Converted.PrimaryInstance).Entries);
        var s_Made = Assert.IsType<fb.MeshVariationDatabaseEntry>(s_Converted.InstanceMap[((DataContainerId.Guid)s_Ref.InstanceId).Id]);
        Assert.Equal(s_Converted.PartitionGuid, s_Ref.PartitionGuid);
        Assert.Equal(7u, s_Made.VariationAssetNameHash);
        Assert.Equal("_CS", Assert.Single(Assert.Single(s_Made.Materials).TextureParameters).ParameterName);
        Assert.Equal(1, s_Conversion.Report.StructsMadeInstances["MeshVariationDatabase.Entries"]);
    }

    [Fact]
    public void FollowsTheSourceEnginesRules()
    {
        var s_Wave = new fb.Audio.SoundWaveAsset
        {
            InstanceId = new DataContainerId.Guid(s_Primary),
            Selection = fb.Audio.SoundWaveVariationSelection.SoundWaveVariationSelection_Random,
        };
        var s_Source = new Bf4 { Name = "sound/crate", PartitionGuid = s_Partition, PrimaryInstanceGuid = s_Primary };
        s_Source.InstanceMap.Add(s_Wave.InstanceId, s_Wave);
        var s_Rules = new RimeLib.Serialization.Frostbite2013_2.ConversionRules().For(RimeLib.Frostbite.EngineType.Frostbite2_0);

        var s_Converted = new PartitionConversion(new EbxTypeLibrary(), s_Rules).Convert(s_Source);

        Assert.Equal(fb.SoundWaveVariationSelection.SwvsRandom, ((fb.SoundWaveAsset)s_Converted.PrimaryInstance).Selection);
    }

    [Fact]
    public void KeepsTheFieldOfAStructTheRulesUnwrap()
    {
        var s_Emitter = new fb.Emitter.EmitterEntityData
        {
            InstanceId = new DataContainerId.Guid(s_Primary),
            CullDistance = new fb.Core.QualityScalableFloat { Low = 1, Medium = 2, High = 3, Ultra = 4 },
        };
        var s_Source = new Bf4 { Name = "fx/crate", PartitionGuid = s_Partition, PrimaryInstanceGuid = s_Primary };
        s_Source.InstanceMap.Add(s_Emitter.InstanceId, s_Emitter);
        var s_Conversion = new PartitionConversion(new EbxTypeLibrary(), new RimeLib.Serialization.Frostbite2013_2.ConversionRules().For(RimeLib.Frostbite.EngineType.Frostbite2_0));

        var s_Converted = s_Conversion.Convert(s_Source);

        Assert.Equal(3, ((fb.EmitterEntityData)s_Converted.PrimaryInstance).CullDistance);
        Assert.Equal(1, s_Conversion.Report.Unwrapped["EmitterEntityData.CullDistance: QualityScalableFloat.High"]);
    }

    [Fact]
    public void CountsResourcesTheTargetFindsByNameApart()
    {
        var s_Conversion = new PartitionConversion(new EbxTypeLibrary(), new RimeLib.Serialization.Frostbite2013_2.ConversionRules().For(RimeLib.Frostbite.EngineType.Frostbite2_0));
        s_Conversion.Convert(Bf4Mesh());

        Assert.Equal(1, s_Conversion.Report.NamedResources["RigidMeshAsset.MeshSetResource"]);
        Assert.DoesNotContain("RigidMeshAsset.MeshSetResource", s_Conversion.Report.DroppedFields.Keys);
    }

    [Fact]
    public void LeavesReferencesToPartitionsNotShippedOut()
    {
        var s_Source = Bf4Mesh();
        var s_Other = new GUID(Guid.Parse("99999999-2222-3333-4444-555555555555"));
        ((fb.Render.RigidMeshAsset)s_Source.PrimaryInstance).Materials.AddRef(new CtrRefBase(s_Other, new DataContainerId.Guid(s_Primary)));
        var s_Conversion = new PartitionConversion(new EbxTypeLibrary()) { ShippedPartitions = new HashSet<GUID> { s_Partition } };

        var s_Mesh = (fb.RigidMeshAsset)s_Conversion.Convert(s_Source).PrimaryInstance;

        Assert.Single(s_Mesh.Materials);
        Assert.Equal(1, s_Conversion.Report.UnshippedReferences["RigidMeshAsset.Materials"]);
    }

    [Fact]
    public void RewritesStringsAndThePartitionsName()
    {
        var s_Conversion = new PartitionConversion(new EbxTypeLibrary()) { Strings = p_S => p_S.Replace("objects/crate/", "props/") };

        var s_Partition = s_Conversion.Convert(Bf4Mesh());

        Assert.Equal("props/crate_mesh", s_Partition.Name);
        Assert.Equal("props/crate_mesh", ((fb.RigidMeshAsset)s_Partition.PrimaryInstance).Name);
    }
}
