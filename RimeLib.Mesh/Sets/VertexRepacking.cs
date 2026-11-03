using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using RimeLib.IO;

namespace RimeLib.Mesh.Sets;

/// <summary>A subset's vertex layout: its elements, all in one per-vertex stream, and the stride. Equal by content.</summary>
public sealed record VertexLayout(IReadOnlyList<VertexElement> Elements, byte Stride)
{
    public static VertexLayout Of(MeshSubsetModel p_Subset)
    {
        if (p_Subset.Streams.Count != 1 || p_Subset.Streams[0].Classification != VertexClassification.PerVertex
            || p_Subset.Elements.Any(p_E => p_E.StreamIndex != 0))
            throw new NotSupportedException($"a subset of {p_Subset.Streams.Count} vertex streams");
        return new VertexLayout(p_Subset.Elements, p_Subset.VertexStride);
    }

    public bool Equals(VertexLayout? p_Other) => p_Other != null && Stride == p_Other.Stride && Elements.SequenceEqual(p_Other.Elements);

    public override int GetHashCode() => HashCode.Combine(Stride, Elements.Count);
}

/// <summary>
/// Rewrites a LOD's chunk for other vertex layouts. A chunk holds the subsets' vertices back to
/// back, padded to 16 bytes, then the indices, padded to 16 bytes; the indices count from each
/// subset's first vertex, so they stay as they are.
/// </summary>
public static class VertexRepacking
{
    private const int Alignment = 16;

    /// <summary>
    /// The LOD and its chunk with each subset's vertices in the layout at its index. A target
    /// element takes the source element of the same usage, converted to its format if that
    /// differs; one whose usage the source lacks is zero, and its usage is in <paramref name="p_Missing"/>.
    /// Subsets that share their vertices keep sharing them.
    /// </summary>
    public static (MeshLodModel Lod, byte[] Chunk) Repack(MeshLodModel p_Lod, byte[] p_Chunk, IReadOnlyList<VertexLayout> p_Layouts, out IReadOnlyList<VertexUsage> p_Missing)
    {
        if (p_Layouts.Count != p_Lod.Subsets.Count)
            throw new ArgumentException($"{p_Layouts.Count} layouts for {p_Lod.Subsets.Count} subsets");
        if (p_Chunk.Length < p_Lod.VertexDataSize + p_Lod.IndexDataSize)
            throw new InvalidDataException($"a {p_Chunk.Length} byte chunk for {p_Lod.VertexDataSize} bytes of vertices and {p_Lod.IndexDataSize} of indices");

        var s_Missing = new HashSet<VertexUsage>();
        var s_Placed = new Dictionary<(uint Offset, VertexLayout Layout), uint>();
        var s_Subsets = new List<MeshSubsetModel>();

        using var s_Reader = new RimeReader(new MemoryStream(p_Chunk, false));
        var s_Stream = new MemoryStream();
        using var s_Writer = new RimeWriter(s_Stream);

        for (var i = 0; i < p_Lod.Subsets.Count; ++i)
        {
            var s_Subset = p_Lod.Subsets[i];
            var s_From = VertexLayout.Of(s_Subset);
            var s_To = p_Layouts[i];
            if (s_Subset.VertexOffset + (long)s_Subset.VertexCount * s_From.Stride > p_Lod.VertexDataSize)
                throw new InvalidDataException("a subset's vertices past the LOD's vertex data");

            if (!s_Placed.TryGetValue((s_Subset.VertexOffset, s_To), out var s_Offset))
            {
                s_Offset = (uint)s_Writer.Position;
                s_Placed[(s_Subset.VertexOffset, s_To)] = s_Offset;
                for (var v = 0L; v < s_Subset.VertexCount; ++v)
                    WriteVertex(s_Reader, s_Subset.VertexOffset + v * s_From.Stride, s_From, s_To, s_Writer, s_Missing);
            }

            s_Subsets.Add(s_Subset with
            {
                VertexOffset = s_Offset,
                VertexStride = s_To.Stride,
                Elements = s_To.Elements,
                Streams = [new VertexStream(s_To.Stride, VertexClassification.PerVertex)],
            });
        }

        Pad(s_Writer);
        var s_VertexDataSize = (uint)s_Writer.Position;
        s_Reader.Seek(p_Lod.VertexDataSize, SeekOrigin.Begin);
        s_Writer.Write(s_Reader.ReadBytes((int)p_Lod.IndexDataSize));
        Pad(s_Writer);
        s_Writer.Flush();

        p_Missing = s_Missing.Order().ToList();
        return (p_Lod with { Subsets = s_Subsets, VertexDataSize = s_VertexDataSize }, s_Stream.ToArray());
    }

    private static void WriteVertex(RimeReader p_Reader, long p_Vertex, VertexLayout p_From, VertexLayout p_To, RimeWriter p_Writer, ISet<VertexUsage> p_Missing)
    {
        var s_Start = p_Writer.Position;
        foreach (var s_Element in p_To.Elements.OrderBy(p_E => p_E.Offset))
        {
            if (s_Element.Offset < p_Writer.Position - s_Start)
                throw new InvalidDataException($"overlapping vertex elements at offset {s_Element.Offset}");
            p_Writer.WriteNullBytes((uint)(s_Start + s_Element.Offset - p_Writer.Position));

            var s_Source = p_From.Elements.FirstOrDefault(p_E => p_E.Usage == s_Element.Usage);
            if (s_Source == null)
            {
                p_Missing.Add(s_Element.Usage);
                p_Writer.WriteNullBytes((uint)VertexFormats.Size(s_Element.Format));
                continue;
            }

            p_Reader.Seek(p_Vertex + s_Source.Offset, SeekOrigin.Begin);
            if (s_Source.Format == s_Element.Format)
                p_Writer.Write(p_Reader.ReadBytes(VertexFormats.Size(s_Element.Format)));
            else
                VertexFormats.Write(s_Element.Format, VertexFormats.Read(s_Source.Format, p_Reader), p_Writer);
        }

        if (p_Writer.Position - s_Start > p_To.Stride)
            throw new InvalidDataException($"vertex elements past the stride of {p_To.Stride}");
        p_Writer.WriteNullBytes((uint)(s_Start + p_To.Stride - p_Writer.Position));
    }

    private static void Pad(RimeWriter p_Writer) =>
        p_Writer.WriteNullBytes((uint)((Alignment - p_Writer.Position % Alignment) % Alignment));
}
