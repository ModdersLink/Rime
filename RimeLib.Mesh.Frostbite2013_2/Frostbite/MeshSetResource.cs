using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using fb.Render;
using RimeLib.Frostbite;
using RimeLib.IO;
using RimeLib.Mesh.Frostbite2_0.Frostbite;

namespace RimeLib.Mesh.Frostbite2013_2.Frostbite;

/// <summary>
/// A MeshSet resource: a relocatable image of the <see cref="MeshSetLayout"/> and its meshes, the
/// embedded data of meshes without a chunk, then the relocation table. Reading takes the three
/// sizes from <see cref="Cookie"/> and checks its layout and subset sizes against this engine's;
/// writing sets them.
/// </summary>
public class MeshSetResource : IFbSerializable
{
    public MeshLayoutCookie Cookie { get; set; } = new() { MeshSetSize = MeshSetLayout.Size, SubsetSize = MeshSubset.Size };

    public MeshSetLayout Layout { get; set; } = new();

    /// <summary>Vertex and index data stored in the resource instead of a chunk.</summary>
    public byte[] EmbeddedData { get; set; } = Array.Empty<byte>();

    public List<MeshLayout> Lods => Layout.Lods.Take(Layout.LodCount).Select(p_L => p_L.Object!).ToList();

    public void Deserialize(RimeReader p_Reader)
    {
        if (Cookie.MeshSetSize != MeshSetLayout.Size || Cookie.SubsetSize != MeshSubset.Size)
            throw new InvalidDataException($"A MeshSet of {Cookie.MeshSetSize} byte layouts and {Cookie.SubsetSize} byte subsets; this engine's are {MeshSetLayout.Size} and {MeshSubset.Size}.");

        var s_Image = p_Reader.ReadBytes((int)Cookie.CellBlockSize);
        EmbeddedData = p_Reader.ReadBytes((int)Cookie.RsxBlockSize);
        p_Reader.Seek(Cookie.RelocationSize, SeekOrigin.Current);

        using (var s_Reader = new RimeReader(new MemoryStream(s_Image, false)))
            Layout = new MeshSetLayout(s_Reader);

        // Pointers the engine fills at runtime; one set in the file would be missing from the relocations.
        foreach (var s_Lod in Lods)
        {
            if (s_Lod == null)
                throw new InvalidDataException("a MeshSet layout pointer leaves the image");
            if (s_Lod.Data != 0 || s_Lod.Subsets.Get.Any(p_S => p_S.GeometryDeclarations != 0))
                throw new InvalidDataException("a mesh layout with m_data or a subset with geometryDeclarations set");
            if (s_Lod.Type == MeshType.MeshType_Rigid && s_Lod.BoneOrPartCount != 0)
                throw new InvalidDataException("a rigid mesh layout with a bone or part count");
        }
    }

    public void Deserialize(byte[] p_Data)
    {
        using var s_Reader = new RimeReader(new MemoryStream(p_Data, false));
        Deserialize(s_Reader);
    }

    /// <summary>
    /// Writes the image, the embedded data and the relocation table, and sets the cookie's sizes.
    /// The image is laid out in the pipeline's order: header, layouts, subsets, bone indices,
    /// strings, category subset indices, then each layout's bone or part arrays.
    /// </summary>
    public bool Serialize(RimeWriter p_Writer)
    {
        var s_Stream = new MemoryStream();
        using var w = new RelocationRimeWriter(s_Stream);
        var s_Lods = Lods;

        long Reserve(int p_Size)
        {
            var s_Offset = w.Position;
            w.WriteNullBytes((uint)p_Size);
            return s_Offset;
        }

        ulong Here() => (ulong)w.Position;

        Reserve(MeshSetLayout.Size);
        var s_LodOffsets = s_Lods.Select(p_L => Reserve(p_L.Size)).ToArray();
        var s_SubsetOffsets = s_Lods.Select(p_L => Reserve(MeshSubset.Size * p_L.Subsets.Get.Length)).ToArray();

        foreach (var s_Subset in s_Lods.SelectMany(p_L => p_L.Subsets.Get))
        {
            if (s_Subset.BoneIndices.BaseAddress == 0)
                continue;
            if (s_Subset.BoneIndices.Get.Length != s_Subset.BoneCount)
                throw new InvalidDataException("a subset's bone count does not match its indices");

            s_Subset.BoneIndices.BaseAddress = Here();
            foreach (var s_Bone in s_Subset.BoneIndices.Get)
                w.Write(s_Bone);
        }
        w.Align(16);

        // A layout's name and short name are suffixes of its shader debug name, and the set's short
        // name of its name, so each points into the longer string.
        foreach (var s_Lod in s_Lods)
        {
            foreach (var s_Subset in s_Lod.Subsets.Get)
            {
                s_Subset.MaterialName.BaseAddress = Here();
                w.WriteNullTerminatedString(s_Subset.MaterialName.Object ?? "");
            }

            var s_Debug = s_Lod.ShaderDebugName.Object ?? "";
            var s_Name = s_Lod.Name.Object ?? "";
            var s_Short = s_Lod.ShortName.Object ?? "";
            if (!s_Debug.EndsWith(s_Name, StringComparison.Ordinal) || !s_Name.EndsWith(s_Short, StringComparison.Ordinal))
                throw new InvalidDataException("a layout's name must end its shader debug name and its short name its name");

            s_Lod.ShaderDebugName.BaseAddress = Here();
            s_Lod.Name.BaseAddress = Suffix(s_Lod.ShaderDebugName.BaseAddress, s_Debug, s_Name);
            s_Lod.ShortName.BaseAddress = Suffix(s_Lod.ShaderDebugName.BaseAddress, s_Debug, s_Short);
            w.WriteNullTerminatedString(s_Debug);
        }

        var s_SetName = Layout.Name.Object ?? "";
        var s_SetShort = Layout.ShortName.Object;
        if (s_SetShort != null && !s_SetName.EndsWith(s_SetShort, StringComparison.Ordinal))
            throw new InvalidDataException("the short name must end the name");
        Layout.Name.BaseAddress = Here();
        Layout.ShortName.BaseAddress = s_SetShort == null ? 0 : Suffix(Layout.Name.BaseAddress, s_SetName, s_SetShort);
        w.WriteNullTerminatedString(s_SetName);
        w.Align(16);

        foreach (var s_Indices in s_Lods.SelectMany(p_L => p_L.CategorySubsetIndices))
        {
            s_Indices.BaseAddress = Here();
            w.Write(s_Indices.Get);
        }
        w.Align(16);

        // m_embeddedEdgeData points where the bone or part arrays begin.
        var s_Arrays = Here();
        foreach (var s_Lod in s_Lods)
        {
            if (s_Lod.EmbeddedEdgeData.BaseAddress != 0)
                s_Lod.EmbeddedEdgeData.BaseAddress = s_Arrays;

            switch (s_Lod.Type)
            {
                case MeshType.MeshType_Skinned:
                    w.Align(4);
                    s_Lod.BoneIndexArray.BaseAddress = Here();
                    foreach (var s_Value in s_Lod.BoneIndexArray.Get)
                        w.Write(s_Value);
                    s_Lod.BoneShortNameArray.BaseAddress = Here();
                    foreach (var s_Value in s_Lod.BoneShortNameArray.Get)
                        w.Write(s_Value);
                    break;
                case MeshType.MeshType_Composite:
                    w.Align(16);
                    s_Lod.PartBoundingBoxes.BaseAddress = Here();
                    foreach (var s_Value in s_Lod.PartBoundingBoxes.Get)
                        w.Write(s_Value);
                    w.Align(16);
                    s_Lod.PartTransforms.BaseAddress = Here();
                    foreach (var s_Value in s_Lod.PartTransforms.Get)
                        w.Write(s_Value);
                    s_Lod.SubsetPartIndices.BaseAddress = Here();
                    w.Write(s_Lod.SubsetPartIndices.Get);
                    break;
            }
        }
        w.Align(16);
        var s_DataSize = w.Position;

        for (var i = 0; i < Layout.Lods.Length; ++i)
            Layout.Lods[i].BaseAddress = i < s_Lods.Count ? (ulong)s_LodOffsets[i] : 0;

        // The relocation table lists a layout's pointers in field order, but those of its subsets
        // right after the pointer to them, and the header's last.
        var s_Relocations = new List<long>();
        for (var i = 0; i < s_Lods.Count; ++i)
        {
            s_Lods[i].Subsets.BaseAddress = (ulong)s_SubsetOffsets[i];

            var s_LayoutStart = w.Relocations.Count;
            w.Seek(s_LodOffsets[i], SeekOrigin.Begin);
            s_Lods[i].Serialize(w);
            var s_Layout = w.Relocations.GetRange(s_LayoutStart, w.Relocations.Count - s_LayoutStart);

            var s_SubsetStart = w.Relocations.Count;
            w.Seek(s_SubsetOffsets[i], SeekOrigin.Begin);
            foreach (var s_Subset in s_Lods[i].Subsets.Get)
                s_Subset.Serialize(w);

            s_Relocations.Add(s_Layout[0]);
            s_Relocations.AddRange(w.Relocations.Skip(s_SubsetStart));
            s_Relocations.AddRange(s_Layout.Skip(1));
        }

        var s_HeaderStart = w.Relocations.Count;
        w.Seek(0, SeekOrigin.Begin);
        Layout.Serialize(w);
        s_Relocations.AddRange(w.Relocations.Skip(s_HeaderStart));

        w.Seek(s_DataSize, SeekOrigin.Begin);
        w.Write(EmbeddedData);
        foreach (var s_Pointer in s_Relocations)
            w.Write((uint)s_Pointer);

        Cookie.CellBlockSize = (uint)s_DataSize;
        Cookie.RsxBlockSize = (uint)EmbeddedData.Length;
        Cookie.RelocationSize = (uint)(4 * s_Relocations.Count);
        Cookie.MeshSetSize = MeshSetLayout.Size;
        Cookie.SubsetSize = MeshSubset.Size;

        w.Flush();
        p_Writer.Write(s_Stream.ToArray());
        return true;
    }

    public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
    {
        var s_Stream = new MemoryStream();
        using (var s_Writer = new RimeWriter(s_Stream))
            Serialize(s_Writer);

        p_Data = s_Stream.ToArray();
        return true;
    }

    private static ulong Suffix(ulong p_String, string p_Whole, string p_Suffix) =>
        p_String + (ulong)(Encoding.UTF8.GetByteCount(p_Whole) - Encoding.UTF8.GetByteCount(p_Suffix));
}
