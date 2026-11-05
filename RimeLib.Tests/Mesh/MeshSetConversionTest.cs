using System;
using System.IO;
using System.Linq;
using System.Numerics;
using RimeLib.Mesh.Sets;
using Xunit;
using Bf3Codec = RimeLib.Mesh.Frostbite2_0.MeshSetCodec;
using Bf4Codec = RimeLib.Mesh.Frostbite2013_2.MeshSetCodec;

namespace RimeLib.Tests.Mesh;

public class MeshSetConversionTest
{
    private static MeshSubsetModel Subset(params VertexUsage[] p_Usages) => new()
    {
        MaterialName = "Opaque",
        PrimitiveCount = 12,
        VertexCount = 8,
        VertexStride = (byte)(8 * p_Usages.Length),
        Elements = p_Usages.Select((p_Usage, i) => new VertexElement(p_Usage, VertexFormat.Half4, (byte)(8 * i), 0)).ToList(),
        Streams = [new VertexStream((byte)(8 * p_Usages.Length), VertexClassification.PerVertex)],
        TexCoordRatios = [1, 0, 0, 0, 0, 0],
    };

    private static MeshLodModel Lod(int p_Index, params MeshSubsetModel[] p_Subsets) => new()
    {
        Flags = p_Index == 0 ? MeshFlags.IsBaseLod | MeshFlags.StreamingEnable : MeshFlags.StreamingEnable,
        Subsets = p_Subsets,
        CategorySubsetIndices = [Enumerable.Range(0, p_Subsets.Length).Select(i => (byte)i).ToArray(), [], [], []],
        ChunkId = Guid.NewGuid(),
        ShaderDebugName = $"objects/crate/crate_mesh/lod{p_Index}",
        Name = $"crate_mesh/lod{p_Index}",
        ShortName = $"lod{p_Index}",
        NameHash = (uint)p_Index,
    };

    private static MeshSetModel Bf4Crate() => new()
    {
        Name = "objects/crate/crate_mesh",
        ShortName = "crate_mesh",
        NameHash = 0x1234,
        Flags = MeshFlags.StreamingEnable,
        BoundsMin = new Vector3(-1),
        BoundsMax = new Vector3(1),
        Lods = Enumerable.Range(0, 6)
            .Select(i => Lod(i, Subset(VertexUsage.Pos, VertexUsage.Normal, VertexUsage.DestructionMaskDistance)))
            .ToList(),
    };

    [Fact]
    public void DropsWhatBf3HasNoRoomFor()
    {
        var s_Fitted = MeshSetConversion.ToEngine(Bf4Crate(), new Bf3Codec(), out var s_Dropped);

        Assert.Equal(5, s_Fitted.Lods.Count);
        Assert.All(s_Fitted.Lods, p_Lod => Assert.Equal(
            [VertexUsage.Pos, VertexUsage.Normal],
            p_Lod.Subsets[0].Elements.Select(p_E => p_E.Usage)));
        Assert.Equal(["LODs past 5", "usage DestructionMaskDistance"], s_Dropped);

        // The vertex data keeps its layout: the stride still covers the dropped element.
        Assert.Equal(24, s_Fitted.Lods[0].Subsets[0].VertexStride);
    }

    [Fact]
    public void KeepsWhatBf4HasRoomFor()
    {
        var s_Model = Bf4Crate();
        var s_Fitted = MeshSetConversion.ToEngine(s_Model, new Bf4Codec(), out var s_Dropped);

        Assert.Empty(s_Dropped);
        Assert.Equal(6, s_Fitted.Lods.Count);
        Assert.Equal(3, s_Fitted.Lods[5].Subsets[0].Elements.Count);
    }

    [Fact]
    public void Bf3ReadsBackWhatItWrites()
    {
        var s_Codec = new Bf3Codec();
        var s_Model = MeshSetConversion.ToEngine(Bf4Crate(), s_Codec, out _);
        var s_Payload = s_Codec.Encode(s_Model);
        var s_Read = s_Codec.Decode(s_Payload);

        Assert.Equal(s_Model.Name, s_Read.Name);
        Assert.Equal(s_Model.ShortName, s_Read.ShortName);
        Assert.Equal(s_Model.BoundsMax, s_Read.BoundsMax);
        Assert.Equal(s_Model.Lods.Select(p_L => p_L.ShaderDebugName), s_Read.Lods.Select(p_L => p_L.ShaderDebugName));
        Assert.Equal(s_Model.Lods.Select(p_L => p_L.ChunkId), s_Read.Lods.Select(p_L => p_L.ChunkId));
        Assert.Equal(s_Model.Lods[0].Subsets[0].Elements, s_Read.Lods[0].Subsets[0].Elements);
        Assert.Equal(s_Model.Lods[0].Subsets[0].Streams, s_Read.Lods[0].Subsets[0].Streams);
        Assert.Equal(s_Payload.Data, s_Codec.Encode(s_Read).Data);
        Assert.Equal(s_Payload.Meta, s_Codec.Encode(s_Read).Meta);
    }

    [Fact]
    public void Bf4MeshSetConvertsToBf3()
    {
        var s_Bf4 = new Bf4Codec();
        var s_Bf3 = new Bf3Codec();
        var s_Model = s_Bf4.Decode(s_Bf4.Encode(Bf4Crate()));

        var s_Read = s_Bf3.Decode(s_Bf3.Encode(MeshSetConversion.ToEngine(s_Model, s_Bf3, out _)));

        Assert.Equal(s_Model.Lods.Take(5).Select(p_L => p_L.ChunkId), s_Read.Lods.Select(p_L => p_L.ChunkId));
        Assert.Equal([VertexUsage.Pos, VertexUsage.Normal], s_Read.Lods[4].Subsets[0].Elements.Select(p_E => p_E.Usage));
    }

    [Fact]
    public void RefusesMoreLodsThanTheEngineHolds()
    {
        Assert.Throws<InvalidDataException>(() => new Bf3Codec().Encode(Bf4Crate()));
    }

    [Fact]
    public void MapsUsagesByNameAcrossTheEnginesNumbering()
    {
        // BF4 inserts DisplacementMapTexCoord before RadiosityTexCoord, which shifts its number.
        Assert.Equal(41, (int)EngineEnums.ToEngine<fb.VertexElementUsage>(VertexUsage.RadiosityTexCoord));
        Assert.Equal(42, (int)EngineEnums.ToEngine<fb.Render.VertexElementUsage>(VertexUsage.RadiosityTexCoord));
        Assert.Equal(VertexUsage.RadiosityTexCoord, EngineEnums.ToModel<VertexUsage>((fb.Render.VertexElementUsage)42));
        Assert.False(EngineEnums.TryToEngine<fb.VertexElementUsage>(VertexUsage.DisplacementMapTexCoord, out _));
    }
}
