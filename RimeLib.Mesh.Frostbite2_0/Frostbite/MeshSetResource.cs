using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;
using fb;
using RimeLib.Frostbite;
using RimeLib.IO;

namespace RimeLib.Mesh.Frostbite2_0.Frostbite
{
    /// <summary>
    /// A MeshSet resource: a relocatable image of the <see cref="MeshSetLayout"/> and its meshes, the
    /// embedded data of meshes without a chunk, then the relocation table. Reading takes the three
    /// sizes from <see cref="Cookie"/> and checks its layout and subset sizes against this engine's;
    /// writing sets them.
    /// </summary>
    public class MeshSetResource : IFbSerializable
    {
        public MeshLayoutCookie Cookie { get; set; } = new() { MeshSetSize = MeshSetLayout.Size, SubsetSize = MeshSubset.Frostbite2Size };

        public MeshSetLayout Layout { get; set; } = new();

        /// <summary>Vertex and index data stored in the resource instead of a chunk.</summary>
        public byte[] EmbeddedData { get; set; } = Array.Empty<byte>();

        public List<MeshLayout> Lods => Layout.Lods.Take((int)Layout.LodCount).Select(p_L => p_L.Object!).ToList();

        public void Deserialize(RimeReader p_Reader)
        {
            if (Cookie.MeshSetSize != MeshSetLayout.Size || Cookie.SubsetSize != MeshSubset.Frostbite2Size)
                throw new InvalidDataException($"A MeshSet of {Cookie.MeshSetSize} byte layouts and {Cookie.SubsetSize} byte subsets; this engine's are {MeshSetLayout.Size} and {MeshSubset.Frostbite2Size}.");

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
        /// The image is laid out in the pipeline's order: header, layouts, each layout's subsets from a
        /// 16-byte boundary, bone indices, strings, category subset indices, then each layout's bone or
        /// part arrays.
        /// </summary>
        public bool Serialize(RimeWriter p_Writer)
        {
            var s_Stream = new MemoryStream();
            using var s_Image = new RelocationRimeWriter(s_Stream);
            var s_Lods = Lods;

            Reserve(s_Image, MeshSetLayout.Size);
            var s_LodOffsets = s_Lods.Select(p_L => Reserve(s_Image, p_L.Size)).ToArray();
            var s_SubsetOffsets = s_Lods.Select(p_L =>
            {
                s_Image.Align(16);
                return Reserve(s_Image, p_L.Subsets.Get.Sum(p_S => p_S.Size));
            }).ToArray();

            PlaceBoneIndices(s_Image, s_Lods);
            PlaceStrings(s_Image, s_Lods);
            PlaceCategorySubsetIndices(s_Image, s_Lods);
            PlaceBoneOrPartArrays(s_Image, s_Lods);
            var s_DataSize = s_Image.Position;

            for (var i = 0; i < Layout.Lods.Length; ++i)
                Layout.Lods[i].BaseAddress = i < s_Lods.Count ? (ulong)s_LodOffsets[i] : 0;

            var s_Relocations = WriteLayouts(s_Image, s_Lods, s_LodOffsets, s_SubsetOffsets);

            s_Image.Seek(s_DataSize, SeekOrigin.Begin);
            s_Image.Write(EmbeddedData);
            foreach (var s_Pointer in s_Relocations)
                s_Image.Write((uint)s_Pointer);

            Cookie.CellBlockSize = (uint)s_DataSize;
            Cookie.RsxBlockSize = (uint)EmbeddedData.Length;
            Cookie.RelocationSize = (uint)(4 * s_Relocations.Count);
            Cookie.MeshSetSize = MeshSetLayout.Size;
            Cookie.SubsetSize = MeshSubset.Frostbite2Size;

            s_Image.Flush();
            p_Writer.Write(s_Stream.ToArray());
            return true;
        }

        private static long Reserve(RimeWriter p_Image, int p_Size)
        {
            var s_Offset = p_Image.Position;
            p_Image.WriteNullBytes((uint)p_Size);
            return s_Offset;
        }

        private static ulong Here(RimeWriter p_Image) => (ulong)p_Image.Position;

        /// <summary>The subsets' bone indices, from the 16-byte boundary after the last subsets.</summary>
        private static void PlaceBoneIndices(RimeWriter p_Image, List<MeshLayout> p_Lods)
        {
            p_Image.Align(16);
            foreach (var s_Subset in p_Lods.SelectMany(p_L => p_L.Subsets.Get))
            {
                if (s_Subset.BoneIndices.BaseAddress == 0)
                    continue;

                s_Subset.BoneIndices.BaseAddress = Here(p_Image);
                foreach (var s_Bone in s_Subset.BoneIndices.Get)
                    p_Image.Write(s_Bone);
            }

            p_Image.Align(16);
        }

        /// <summary>
        /// The subsets' material names, then per layout its shader debug name, of which its name and
        /// short name are suffixes, then the set's name, of which its short name is one.
        /// </summary>
        private void PlaceStrings(RimeWriter p_Image, List<MeshLayout> p_Lods)
        {
            foreach (var s_Lod in p_Lods)
            {
                foreach (var s_Subset in s_Lod.Subsets.Get)
                {
                    s_Subset.MaterialName.BaseAddress = Here(p_Image);
                    p_Image.WriteNullTerminatedString(s_Subset.MaterialName.Object ?? "");
                }

                var s_Debug = s_Lod.ShaderDebugName.Object ?? "";
                var s_Name = s_Lod.Name.Object ?? "";
                var s_Short = s_Lod.ShortName.Object ?? "";
                if (!s_Debug.EndsWith(s_Name, StringComparison.Ordinal) || !s_Name.EndsWith(s_Short, StringComparison.Ordinal))
                    throw new InvalidDataException("a layout's name must end its shader debug name and its short name its name");

                s_Lod.ShaderDebugName.BaseAddress = Here(p_Image);
                s_Lod.Name.BaseAddress = Suffix(s_Lod.ShaderDebugName.BaseAddress, s_Debug, s_Name);
                s_Lod.ShortName.BaseAddress = Suffix(s_Lod.ShaderDebugName.BaseAddress, s_Debug, s_Short);
                p_Image.WriteNullTerminatedString(s_Debug);
            }

            var s_SetName = Layout.Name.Object ?? "";
            var s_SetShort = Layout.ShortName.Object;
            if (s_SetShort != null && !s_SetName.EndsWith(s_SetShort, StringComparison.Ordinal))
                throw new InvalidDataException("the short name must end the name");

            Layout.Name.BaseAddress = Here(p_Image);
            Layout.ShortName.BaseAddress = s_SetShort == null ? 0 : Suffix(Layout.Name.BaseAddress, s_SetName, s_SetShort);
            p_Image.WriteNullTerminatedString(s_SetName);
            p_Image.Align(16);
        }

        private static void PlaceCategorySubsetIndices(RimeWriter p_Image, List<MeshLayout> p_Lods)
        {
            foreach (var s_Indices in p_Lods.SelectMany(p_L => p_L.CategorySubsetIndices))
            {
                s_Indices.BaseAddress = Here(p_Image);
                p_Image.Write(s_Indices.Get);
            }

            p_Image.Align(16);
        }

        /// <summary>A skinned layout's bone arrays or a composite layout's part arrays; a layout's embedded edge data points where they begin.</summary>
        private static void PlaceBoneOrPartArrays(RimeWriter p_Image, List<MeshLayout> p_Lods)
        {
            var s_Arrays = Here(p_Image);
            foreach (var s_Lod in p_Lods)
            {
                if (s_Lod.EmbeddedEdgeData.BaseAddress != 0)
                    s_Lod.EmbeddedEdgeData.BaseAddress = s_Arrays;

                switch (s_Lod.Type)
                {
                    case MeshType.MeshType_Skinned:
                        p_Image.Align(4);
                        s_Lod.BoneIndexArray.BaseAddress = Here(p_Image);
                        foreach (var s_Value in s_Lod.BoneIndexArray.Get)
                            p_Image.Write(s_Value);
                        s_Lod.BoneShortNameArray.BaseAddress = Here(p_Image);
                        foreach (var s_Value in s_Lod.BoneShortNameArray.Get)
                            p_Image.Write(s_Value);
                        break;
                    case MeshType.MeshType_Composite:
                        p_Image.Align(16);
                        s_Lod.PartBoundingBoxes.BaseAddress = Here(p_Image);
                        foreach (var s_Value in s_Lod.PartBoundingBoxes.Get)
                            p_Image.Write(s_Value);
                        p_Image.Align(16);
                        s_Lod.PartTransforms.BaseAddress = Here(p_Image);
                        foreach (var s_Value in s_Lod.PartTransforms.Get)
                            p_Image.Write(s_Value);
                        s_Lod.SubsetPartIndices.BaseAddress = Here(p_Image);
                        p_Image.Write(s_Lod.SubsetPartIndices.Get);
                        break;
                }
            }

            p_Image.Align(16);
        }

        /// <summary>
        /// Writes the layouts, their subsets and the header into their reserved places, and returns
        /// the relocation table: a layout's pointers in field order, but those of its subsets right
        /// after the pointer to them, and the header's last.
        /// </summary>
        private List<long> WriteLayouts(RelocationRimeWriter p_Image, List<MeshLayout> p_Lods, long[] p_LodOffsets, long[] p_SubsetOffsets)
        {
            var s_Relocations = new List<long>();
            for (var i = 0; i < p_Lods.Count; ++i)
            {
                p_Lods[i].Subsets.BaseAddress = (ulong)p_SubsetOffsets[i];

                var s_LayoutStart = p_Image.Relocations.Count;
                p_Image.Seek(p_LodOffsets[i], SeekOrigin.Begin);
                p_Lods[i].Serialize(p_Image);
                var s_Layout = p_Image.Relocations.GetRange(s_LayoutStart, p_Image.Relocations.Count - s_LayoutStart);

                var s_SubsetStart = p_Image.Relocations.Count;
                p_Image.Seek(p_SubsetOffsets[i], SeekOrigin.Begin);
                foreach (var s_Subset in p_Lods[i].Subsets.Get)
                    s_Subset.Serialize(p_Image);

                s_Relocations.Add(s_Layout[0]);
                s_Relocations.AddRange(p_Image.Relocations.Skip(s_SubsetStart));
                s_Relocations.AddRange(s_Layout.Skip(1));
            }

            var s_HeaderStart = p_Image.Relocations.Count;
            p_Image.Seek(0, SeekOrigin.Begin);
            Layout.Serialize(p_Image);
            s_Relocations.AddRange(p_Image.Relocations.Skip(s_HeaderStart));
            return s_Relocations;
        }

        private static ulong Suffix(ulong p_String, string p_Whole, string p_Suffix) =>
            p_String + (ulong)(Encoding.UTF8.GetByteCount(p_Whole) - Encoding.UTF8.GetByteCount(p_Suffix));

        public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
        {
            var s_Stream = new MemoryStream();
            using (var s_Writer = new RimeWriter(s_Stream))
                Serialize(s_Writer);

            p_Data = s_Stream.ToArray();
            return true;
        }
    }
}
