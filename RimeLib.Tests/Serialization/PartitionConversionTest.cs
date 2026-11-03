using System;
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
}
