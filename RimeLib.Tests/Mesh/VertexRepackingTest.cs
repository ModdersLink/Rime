using System;
using System.IO;
using System.Linq;
using System.Numerics;
using RimeLib.IO;
using RimeLib.Mesh.Sets;
using Xunit;

namespace RimeLib.Tests.Mesh;

public class VertexRepackingTest
{
    private static readonly VertexLayout s_Half = new(
        [new VertexElement(VertexUsage.Pos, VertexFormat.Half4, 0, 0), new VertexElement(VertexUsage.TexCoord0, VertexFormat.Half2, 8, 0)], 12);

    private static readonly VertexLayout s_Float = new(
        [new VertexElement(VertexUsage.TexCoord0, VertexFormat.Float2, 0, 0), new VertexElement(VertexUsage.Pos, VertexFormat.Float3, 8, 0), new VertexElement(VertexUsage.Normal, VertexFormat.UByte4N, 20, 0)], 24);

    private static MeshSubsetModel Subset(VertexLayout p_Layout, uint p_Offset, uint p_Count) => new()
    {
        MaterialName = "Opaque",
        VertexOffset = p_Offset,
        VertexCount = p_Count,
        VertexStride = p_Layout.Stride,
        PrimitiveCount = 1,
        Elements = p_Layout.Elements,
        Streams = [new VertexStream(p_Layout.Stride, VertexClassification.PerVertex)],
        TexCoordRatios = new float[6],
    };

    /// <summary>A LOD of two subsets in <see cref="s_Half"/>, three vertices each, and six 16-bit indices.</summary>
    private static (MeshLodModel Lod, byte[] Chunk) HalfLod()
    {
        var s_Stream = new MemoryStream();
        using (var s_Writer = new RimeWriter(s_Stream))
        {
            for (var v = 0; v < 6; ++v)
            {
                VertexFormats.Write(VertexFormat.Half4, new Vector4(v, v + 0.5f, -v, 1), s_Writer);
                VertexFormats.Write(VertexFormat.Half2, new Vector4(v / 8f, 1 - v / 8f, 0, 0), s_Writer);
            }

            s_Writer.WriteNullBytes(8); // 72 bytes of vertices, padded to 80
            for (ushort i = 0; i < 6; ++i)
                s_Writer.Write((ushort)(i % 3));
            s_Writer.WriteNullBytes(4); // 92 bytes, padded to 96
        }

        var s_Lod = new MeshLodModel
        {
            Subsets = [Subset(s_Half, 0, 3), Subset(s_Half, 36, 3)],
            CategorySubsetIndices = [[0, 1], [], [], []],
            VertexDataSize = 80,
            IndexDataSize = 12,
            ShaderDebugName = "crate/lod0",
            Name = "crate/lod0",
            ShortName = "lod0",
        };
        return (s_Lod, s_Stream.ToArray());
    }

    [Fact]
    public void RepacksToItsOwnLayoutAsItIs()
    {
        var (s_Lod, s_Chunk) = HalfLod();

        var (s_Repacked, s_Written) = VertexRepacking.Repack(s_Lod, s_Chunk, [s_Half, s_Half], out var s_Missing);

        Assert.Equal(s_Chunk, s_Written);
        Assert.Empty(s_Missing);
        Assert.Equal(s_Lod.Subsets.Select(p_S => p_S.VertexOffset), s_Repacked.Subsets.Select(p_S => p_S.VertexOffset));
    }

    [Fact]
    public void ConvertsFormatsAndBackWithoutLoss()
    {
        var (s_Lod, s_Chunk) = HalfLod();

        var (s_Float32, s_FloatChunk) = VertexRepacking.Repack(s_Lod, s_Chunk, [s_Float, s_Float], out var s_Missing);
        var (s_Back, s_BackChunk) = VertexRepacking.Repack(s_Float32, s_FloatChunk, [s_Half, s_Half], out _);

        Assert.Equal([VertexUsage.Normal], s_Missing);
        Assert.Equal([0u, 72u], s_Float32.Subsets.Select(p_S => p_S.VertexOffset));
        Assert.Equal(144u, s_Float32.VertexDataSize);
        Assert.Equal(24, s_Float32.Subsets[1].VertexStride);
        // Pos.W is 1 in the source; Float3 has no W, so it comes back as 0.
        Assert.Equal(s_Chunk.Length, s_BackChunk.Length);
        for (var v = 0; v < 6; ++v)
        {
            using var s_Reader = new RimeReader(new MemoryStream(s_BackChunk, 12 * v, 12, false));
            Assert.Equal(new Vector4(v, v + 0.5f, -v, 0), VertexFormats.Read(VertexFormat.Half4, s_Reader));
            Assert.Equal(new Vector4(v / 8f, 1 - v / 8f, 0, 0), VertexFormats.Read(VertexFormat.Half2, s_Reader));
        }

        Assert.Equal(s_Chunk[80..], s_BackChunk[80..]);
        Assert.Equal(s_Lod.Subsets.Select(p_S => p_S.VertexOffset), s_Back.Subsets.Select(p_S => p_S.VertexOffset));
    }

    [Fact]
    public void KeepsSharedVerticesShared()
    {
        var (s_Lod, s_Chunk) = HalfLod();
        s_Lod = s_Lod with { Subsets = [s_Lod.Subsets[0], s_Lod.Subsets[0] with { StartIndex = 3 }] };

        var (s_Repacked, _) = VertexRepacking.Repack(s_Lod, s_Chunk, [s_Float, s_Float], out _);

        Assert.Equal([0u, 0u], s_Repacked.Subsets.Select(p_S => p_S.VertexOffset));
        Assert.Equal(80u, s_Repacked.VertexDataSize);
    }

    [Theory]
    [InlineData(VertexFormat.UByte4N, 0.25f)]
    [InlineData(VertexFormat.Byte4N, -0.5f)]
    [InlineData(VertexFormat.Short4N, 0.125f)]
    [InlineData(VertexFormat.UShort4N, 0.75f)]
    public void ReadsBackWhatItWritesWithinAStep(VertexFormat p_Format, float p_Value)
    {
        var s_Stream = new MemoryStream();
        using (var s_Writer = new RimeWriter(s_Stream))
            VertexFormats.Write(p_Format, new Vector4(p_Value), s_Writer);

        var s_Data = s_Stream.ToArray();
        Assert.Equal(VertexFormats.Size(p_Format), s_Data.Length);
        using var s_Reader = new RimeReader(new MemoryStream(s_Data, false));
        Assert.Equal(p_Value, VertexFormats.Read(p_Format, s_Reader).X, 0.01f);
    }
}
