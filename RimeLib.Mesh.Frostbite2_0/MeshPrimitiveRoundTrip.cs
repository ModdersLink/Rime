using System;
using System.Collections.Generic;
using System.IO;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.IO;

namespace RimeLib.Mesh.Frostbite2_0;

/// <summary>
/// Writes the relocatable pointers and arrays of every mounted MeshSet, and the matrices of every
/// OccluderMesh, back and compares them with the shipped bytes at the offsets they were read from.
/// </summary>
public class MeshPrimitiveRoundTrip : IWriterRoundTrip
{
    public EngineType[] GetSupportedEngines() => new[] { EngineType.Frostbite2_0 };

    public void Run(IEngineMounter p_Mounter, int p_Limit, TextWriter p_Writer)
    {
        TestMeshSetPrimitives(p_Mounter, p_Limit, p_Writer);
        TestOccluderMatrices(p_Mounter, p_Limit, p_Writer);
    }

    // ---------------------------------------------------------------- RelocPtr / RelocArray

    // MeshSetLayout, Frostbite 2.0, from its own Deserialize:
    //   0x00 MeshType, 0x04 Flags, 0x08 LodCount, 0x0C TotalSubsetCount,
    //   0x10 min Vec3+pad, 0x20 max Vec3+pad,
    //   0x30..0x57 Lods[5] RelocPtr, 0x58 Name RelocPtr, 0x60 ShortName RelocPtr.
    // The offsets are spelled out rather than taken from MeshSetLayout so that this measurement
    // does not move when the mesh layout code does.
    private static readonly int[] c_MeshSetPointerSlots = { 0x30, 0x38, 0x40, 0x48, 0x50, 0x58, 0x60 };

    // MeshLayout, from its own Deserialize: 0x00 Type, then Subsets and the four
    // CategorySubsetIndices as consecutive 12-byte RelocArray slots.
    private static readonly int[] c_MeshLayoutArraySlots = { 0x04, 0x10, 0x1C, 0x28, 0x34 };

    private static void TestMeshSetPrimitives(IEngineMounter p_Mounter, int p_Limit, TextWriter p_Writer)
    {
        var s_Resources = p_Mounter.GetResources();

        var s_MeshSets = 0;
        var s_PtrTotal = 0;
        var s_PtrIdentical = 0;
        var s_ArrayTotal = 0;
        var s_ArrayIdentical = 0;
        var s_FirstFailure = string.Empty;

        foreach (var l_Resource in s_Resources.Values)
        {
            if (l_Resource.FirstVariant.GetResourceType() != ResourceType.MeshSet)
                continue;

            if (p_Limit > 0 && s_MeshSets >= p_Limit)
                break;

            byte[] s_Payload;

            try
            {
                s_Payload = WriterRoundTrip.ReadAll(l_Resource.FirstVariant);
            }
            catch (Exception)
            {
                continue;
            }

            if (s_Payload.Length < 0x70)
                continue;

            ++s_MeshSets;

            var s_LodOffsets = new List<long>();

            foreach (var l_Slot in c_MeshSetPointerSlots)
            {
                var s_Pointer = new RelocPtr<byte>();

                using (var s_Reader = new RimeReader(new MemoryStream(s_Payload)))
                {
                    s_Reader.Seek(l_Slot, SeekOrigin.Begin);
                    s_Pointer.Deserialize(s_Reader);
                }

                ++s_PtrTotal;

                if (!s_Pointer.Serialize(out var s_Written) || s_Written.Length != 8)
                {
                    if (s_FirstFailure.Length == 0)
                        s_FirstFailure = $"{l_Resource.OriginalName} ptr@0x{l_Slot:X}: writer produced {(s_Written?.Length ?? -1)} bytes";

                    continue;
                }

                if (WriterRoundTrip.FirstDiff(s_Payload, l_Slot, s_Written) < 0)
                    ++s_PtrIdentical;
                else if (s_FirstFailure.Length == 0)
                    s_FirstFailure = $"{l_Resource.OriginalName} ptr@0x{l_Slot:X}";

                // The first five slots are the LODs; each points at a MeshLayout, whose own
                // RelocArray slots are what exercises the array writer on real data.
                if (l_Slot <= 0x50 && s_Pointer.BaseAddress != 0 &&
                    s_Pointer.BaseAddress + 0x40 <= (ulong) s_Payload.Length)
                    s_LodOffsets.Add((long) s_Pointer.BaseAddress);
            }

            foreach (var l_Lod in s_LodOffsets)
            {
                foreach (var l_Slot in c_MeshLayoutArraySlots)
                {
                    var s_Offset = l_Lod + l_Slot;

                    if (s_Offset + 12 > s_Payload.Length)
                        continue;

                    var s_Array = new RelocArray<byte>();

                    using (var s_Reader = new RimeReader(new MemoryStream(s_Payload)))
                    {
                        s_Reader.Seek(s_Offset, SeekOrigin.Begin);
                        s_Array.Deserialize(s_Reader);
                    }

                    ++s_ArrayTotal;

                    if (!s_Array.Serialize(out var s_Written) || s_Written.Length != 12)
                    {
                        if (s_FirstFailure.Length == 0)
                            s_FirstFailure = $"{l_Resource.OriginalName} array@0x{s_Offset:X}: writer produced {(s_Written?.Length ?? -1)} bytes";

                        continue;
                    }

                    if (WriterRoundTrip.FirstDiff(s_Payload, (int) s_Offset, s_Written) < 0)
                        ++s_ArrayIdentical;
                    else if (s_FirstFailure.Length == 0)
                        s_FirstFailure = $"{l_Resource.OriginalName} array@0x{s_Offset:X}";
                }
            }
        }

        p_Writer.WriteLine($"MESHSET resources walked = {s_MeshSets}");
        p_Writer.WriteLine($"RELOCPTR {s_PtrIdentical} of {s_PtrTotal} byte-identical " +
                           $"{(s_PtrTotal > 0 && s_PtrIdentical == s_PtrTotal ? "PASS" : "FAIL")}");
        p_Writer.WriteLine($"RELOCARRAY {s_ArrayIdentical} of {s_ArrayTotal} byte-identical " +
                           $"{(s_ArrayTotal > 0 && s_ArrayIdentical == s_ArrayTotal ? "PASS" : "FAIL")}");

        if (s_FirstFailure.Length > 0)
            p_Writer.WriteLine($"  first mismatch: {s_FirstFailure}");

        if (s_PtrTotal == 0 || s_ArrayTotal == 0)
            p_Writer.WriteLine("  NOTHING TESTED for at least one primitive -- that verdict means nothing.");
    }

    // ---------------------------------------------------------------- Matrix44

    private static void TestOccluderMatrices(IEngineMounter p_Mounter, int p_Limit, TextWriter p_Writer)
    {
        var s_Resources = p_Mounter.GetResources();

        var s_Occluders = 0;
        var s_Total = 0;
        var s_Identical = 0;
        var s_FirstFailure = string.Empty;

        foreach (var l_Resource in s_Resources.Values)
        {
            if (l_Resource.FirstVariant.GetResourceType() != ResourceType.OccluderMesh)
                continue;

            if (p_Limit > 0 && s_Occluders >= p_Limit)
                break;

            byte[] s_Payload;

            try
            {
                s_Payload = WriterRoundTrip.ReadAll(l_Resource.FirstVariant);
            }
            catch (Exception)
            {
                continue;
            }

            // OccluderMeshData: 0x00 AxisAlignedBox (32), 0x20 VertexCount, 0x22 IndexCount,
            // 0x24 vertexDataOffset -- the transforms, IndexCount/3 of them, 64 bytes each.
            if (s_Payload.Length < 0x38)
                continue;

            ++s_Occluders;

            int s_IndexCount;
            uint s_TransformOffset;

            using (var s_Reader = new RimeReader(new MemoryStream(s_Payload)))
            {
                s_Reader.Seek(0x22, SeekOrigin.Begin);
                s_IndexCount = s_Reader.ReadUInt16();
                s_TransformOffset = s_Reader.ReadUInt32();
            }

            var s_TriangleCount = s_IndexCount / 3;

            for (var i = 0; i < s_TriangleCount; ++i)
            {
                var s_Offset = s_TransformOffset + (long) i * 64;

                if (s_Offset + 64 > s_Payload.Length)
                    break;

                var s_Matrix = new Matrix44();

                using (var s_Reader = new RimeReader(new MemoryStream(s_Payload)))
                {
                    s_Reader.Seek(s_Offset, SeekOrigin.Begin);
                    s_Matrix.Deserialize(s_Reader);
                }

                ++s_Total;

                if (!s_Matrix.Serialize(out var s_Written) || s_Written.Length != 64)
                {
                    if (s_FirstFailure.Length == 0)
                        s_FirstFailure = $"{l_Resource.OriginalName} @0x{s_Offset:X}: writer produced {(s_Written?.Length ?? -1)} bytes";

                    continue;
                }

                if (WriterRoundTrip.FirstDiff(s_Payload, (int) s_Offset, s_Written) < 0)
                    ++s_Identical;
                else if (s_FirstFailure.Length == 0)
                    s_FirstFailure = $"{l_Resource.OriginalName} @0x{s_Offset:X}";
            }
        }

        p_Writer.WriteLine($"OCCLUDERMESH resources walked = {s_Occluders}");
        p_Writer.WriteLine($"MATRIX44 {s_Identical} of {s_Total} byte-identical " +
                           $"{(s_Total > 0 && s_Identical == s_Total ? "PASS" : "FAIL")}");

        if (s_FirstFailure.Length > 0)
            p_Writer.WriteLine($"  first mismatch: {s_FirstFailure}");

        if (s_Total == 0)
            p_Writer.WriteLine("  NOTHING TESTED -- that verdict means nothing.");
    }
}
