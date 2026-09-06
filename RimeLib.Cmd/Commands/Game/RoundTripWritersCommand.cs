using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Frostbite;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using RimeLib.Shader;

namespace RimeLib.Cmd.Commands.Game
{
    /// <summary>
    /// Reads a shipped structure, writes it back, and diffs the BYTES.
    ///
    /// This exists because "the Serialize no longer throws" is not the same claim as "the bytes
    /// reach the game", and this project has repeatedly been burned by the gap. Every count below
    /// is asserted non-zero before any verdict is printed: a writer that emitted nothing would
    /// otherwise report a clean sweep of an empty set, which reads exactly like success.
    ///
    /// Each section reports "n of m byte-identical" against the game's own bytes at the offset the
    /// reader consumed them from -- not against a re-parse of our own output, which would only
    /// prove the writer agrees with itself.
    /// </summary>
    [CommandDescription("Round-trips the newly-written Serialize implementations against the mounted game and reports byte equality.")]
    public class RoundTripWritersCommand : Command
    {
        [CommandArgument(Description = "Directory to dump HavokPhysicsData payloads into, for offline work.", Optional = true)]
        public DirectoryInfo? HavokDumpDir { get; set; }

        [CommandArgument(Description = "Cap on how many resources of each kind to test (0 = all).", Optional = true)]
        public int Limit { get; set; } = 0;

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_Context = (GameContext) p_Context;
            var s_Mounter = s_Context.GetMounter();

            var s_Resources = s_Context.GetMountedResourceVariations();
            var s_Partitions = s_Mounter.GetPartitions();

            p_Writer.WriteLine($"CORPUS resources={s_Resources.Count} partitions={s_Partitions.Count}");
            p_Writer.WriteLine();

            // Counting first: a writer for something BF3 never ships is wasted effort.
            var s_ByType = new Dictionary<ResourceType, int>();

            foreach (var l_Resource in s_Resources.Values)
            {
                var s_Type = l_Resource.FirstVariant.GetResourceType();
                s_ByType[s_Type] = s_ByType.TryGetValue(s_Type, out var l_Count) ? l_Count + 1 : 1;
            }

            foreach (var l_Pair in s_ByType.OrderByDescending(p => p.Value))
                p_Writer.WriteLine($"COUNT {l_Pair.Key} = {l_Pair.Value}");

            p_Writer.WriteLine();

            TestPartitionHeaders(s_Context, p_Writer);
            TestShaderConstants(s_Context, s_Mounter, p_Writer);
            TestMeshSetPrimitives(s_Context, p_Writer);
            TestOccluderMatrices(s_Context, p_Writer);
            TestHavok(s_Context, p_Writer);

            return true;
        }

        static byte[] ReadAll(IReadableObject p_Object)
        {
            using var s_Reader = p_Object.GetReader();
            using var s_Stream = new MemoryStream();

            s_Reader.CopyTo(s_Stream);

            return s_Stream.ToArray();
        }

        /// <summary>Index of the first differing byte, or -1 when the spans match.</summary>
        static int FirstDiff(byte[] p_Left, int p_Offset, byte[] p_Right)
        {
            for (var i = 0; i < p_Right.Length; ++i)
                if (p_Left[p_Offset + i] != p_Right[i])
                    return i;

            return -1;
        }

        // ---------------------------------------------------------------- partition headers

        void TestPartitionHeaders(GameContext p_Context, TextWriter p_Writer)
        {
            var s_Partitions = p_Context.GetMounter().GetPartitions();
            var s_Total = 0;
            var s_Identical = 0;
            var s_Unreadable = 0;
            var s_FirstFailure = string.Empty;

            foreach (var l_Pair in s_Partitions)
            {
                if (Limit > 0 && s_Total >= Limit)
                    break;

                byte[] s_Payload;

                try
                {
                    s_Payload = ReadAll(l_Pair.Value.FirstVariant);
                }
                catch (Exception)
                {
                    ++s_Unreadable;
                    continue;
                }

                // 80 bytes: the Frostbite 2.0 header. A partition shorter than that is not one.
                if (s_Payload.Length < 80)
                {
                    ++s_Unreadable;
                    continue;
                }

                ++s_Total;

                var s_Header = new RimeLib.Serialization.Frostbite2_0.Ebx.StreamingPartitionHeader();

                using (var s_Reader = new RimeReader(new MemoryStream(s_Payload)))
                    s_Header.Deserialize(s_Reader);

                if (!s_Header.Serialize(out var s_Written) || s_Written.Length != 80)
                {
                    if (s_FirstFailure.Length == 0)
                        s_FirstFailure = $"{l_Pair.Key} (writer produced {(s_Written?.Length ?? -1)} bytes)";

                    continue;
                }

                var s_Diff = FirstDiff(s_Payload, 0, s_Written);

                if (s_Diff < 0)
                    ++s_Identical;
                else if (s_FirstFailure.Length == 0)
                    s_FirstFailure = $"{l_Pair.Key} @ 0x{s_Diff:X}";
            }

            p_Writer.WriteLine($"STREAMINGPARTITIONHEADER {s_Identical} of {s_Total} byte-identical " +
                               $"(unreadable={s_Unreadable}) {(s_Total > 0 && s_Identical == s_Total ? "PASS" : "FAIL")}");

            if (s_FirstFailure.Length > 0)
                p_Writer.WriteLine($"  first mismatch: {s_FirstFailure}");

            if (s_Total == 0)
                p_Writer.WriteLine("  NOTHING TESTED -- the corpus was empty, so the verdict above means nothing.");
        }

        // ---------------------------------------------------------------- shader constants

        /// <summary>
        /// Rebuilds each external constant record and looks for those exact bytes in the shaderdb
        /// payload the record was read from.
        ///
        /// Positional comparison is not available here: ShaderConstant reaches its external arrays
        /// through offsets it keeps as locals, so nothing downstream knows where a record sat. A
        /// 0x28/0x30-byte match that includes a 32-byte name and, for values, four floats is not
        /// something a wrong writer hits by accident, so this is a search over the source bytes,
        /// not a re-parse of our own output.
        /// </summary>
        void TestShaderConstants(GameContext p_Context, RimeLib.Content.Mounting.IEngineMounter p_Mounter, TextWriter p_Writer)
        {
            var s_Resources = p_Context.GetMountedResourceVariations();

            var s_Dbs = 0;
            var s_ValueTotal = 0;
            var s_ValueFound = 0;
            var s_TextureTotal = 0;
            var s_TextureFound = 0;
            var s_FirstValueFailure = string.Empty;
            var s_FirstTextureFailure = string.Empty;

            foreach (var l_Resource in s_Resources.Values)
            {
                var s_Type = l_Resource.FirstVariant.GetResourceType();

                if (s_Type != ResourceType.DxShaderDatabase && s_Type != ResourceType.IShaderDatabase)
                    continue;

                if (Limit > 0 && s_Dbs >= Limit)
                    break;

                byte[] s_Payload;
                object? s_Container;

                try
                {
                    s_Payload = ReadAll(l_Resource.FirstVariant);

                    var s_Resolver = EngineInterfaceRegistry.Create<IShaderResolver>(p_Mounter.GetEngineType());
                    s_Resolver.Initialize(l_Resource.FirstVariant, p_Mounter);

                    s_Container = s_Resolver.GetType().GetProperty("ShaderDatabaseContainer")?.GetValue(s_Resolver);
                }
                catch (Exception)
                {
                    continue;
                }

                if (s_Container == null)
                    continue;

                if (s_Container.GetType().GetProperty("Databases")?.GetValue(s_Container) is not IDictionary s_Databases)
                    continue;

                ++s_Dbs;

                foreach (var l_Key in s_Databases.Keys)
                {
                    var s_Db = s_Databases[l_Key];

                    if (s_Db?.GetType().GetProperty("Constants")?.GetValue(s_Db) is not Array s_Constants)
                        continue;

                    foreach (var l_Constant in s_Constants)
                    {
                        if (l_Constant == null)
                            continue;

                        CheckRecords(l_Constant, "ExternalValues", s_Payload,
                                     ref s_ValueTotal, ref s_ValueFound, ref s_FirstValueFailure,
                                     l_Resource.OriginalName);

                        CheckRecords(l_Constant, "ExternalTextures", s_Payload,
                                     ref s_TextureTotal, ref s_TextureFound, ref s_FirstTextureFailure,
                                     l_Resource.OriginalName);
                    }
                }
            }

            p_Writer.WriteLine($"SHADERDB databases parsed = {s_Dbs}");
            p_Writer.WriteLine($"EXTERNALVALUECONSTANT {s_ValueFound} of {s_ValueTotal} byte-identical " +
                               $"{(s_ValueTotal > 0 && s_ValueFound == s_ValueTotal ? "PASS" : "FAIL")}");

            if (s_FirstValueFailure.Length > 0)
                p_Writer.WriteLine($"  first mismatch: {s_FirstValueFailure}");

            p_Writer.WriteLine($"EXTERNALTEXTURECONSTANT {s_TextureFound} of {s_TextureTotal} byte-identical " +
                               $"{(s_TextureTotal > 0 && s_TextureFound == s_TextureTotal ? "PASS" : "FAIL")}");

            if (s_FirstTextureFailure.Length > 0)
                p_Writer.WriteLine($"  first mismatch: {s_FirstTextureFailure}");

            if (s_ValueTotal == 0 || s_TextureTotal == 0)
                p_Writer.WriteLine("  NOTHING TESTED for at least one record kind -- that verdict means nothing.");
        }

        static void CheckRecords(object p_Constant, string p_Property, byte[] p_Payload,
                                 ref int p_Total, ref int p_Found, ref string p_FirstFailure,
                                 string p_ResourceName)
        {
            if (p_Constant.GetType().GetProperty(p_Property)?.GetValue(p_Constant) is not Array s_Records)
                return;

            foreach (var l_Record in s_Records)
            {
                if (l_Record is not IFbSerializable s_Serializable)
                    continue;

                ++p_Total;

                byte[]? s_Written = null;

                try
                {
                    s_Serializable.Serialize(out s_Written);
                }
                catch (Exception s_Exception)
                {
                    if (p_FirstFailure.Length == 0)
                        p_FirstFailure = $"{p_ResourceName}: {s_Exception.GetType().Name}";

                    continue;
                }

                if (s_Written == null)
                    continue;

                if (IndexOf(p_Payload, s_Written) >= 0)
                    ++p_Found;
                else if (p_FirstFailure.Length == 0)
                    p_FirstFailure = $"{p_ResourceName}: {s_Written.Length}-byte record not present in the shipped payload";
            }
        }

        static int IndexOf(byte[] p_Haystack, byte[] p_Needle)
        {
            if (p_Needle.Length == 0 || p_Haystack.Length < p_Needle.Length)
                return -1;

            var s_Last = p_Haystack.Length - p_Needle.Length;

            for (var i = 0; i <= s_Last; ++i)
            {
                var j = 0;

                while (j < p_Needle.Length && p_Haystack[i + j] == p_Needle[j])
                    ++j;

                if (j == p_Needle.Length)
                    return i;
            }

            return -1;
        }

        // ---------------------------------------------------------------- RelocPtr / RelocArray

        // MeshSetLayout, Frostbite 2.0, from its own Deserialize:
        //   0x00 MeshType, 0x04 Flags, 0x08 LodCount, 0x0C TotalSubsetCount,
        //   0x10 min Vec3+pad, 0x20 max Vec3+pad,
        //   0x30..0x57 Lods[5] RelocPtr, 0x58 Name RelocPtr, 0x60 ShortName RelocPtr.
        // The offsets are spelled out rather than taken from MeshSetLayout so that this measurement
        // does not move when the mesh layout code does.
        static readonly int[] c_MeshSetPointerSlots = { 0x30, 0x38, 0x40, 0x48, 0x50, 0x58, 0x60 };

        // MeshLayout, from its own Deserialize: 0x00 Type, then Subsets and the four
        // CategorySubsetIndices as consecutive 12-byte RelocArray slots.
        static readonly int[] c_MeshLayoutArraySlots = { 0x04, 0x10, 0x1C, 0x28, 0x34 };

        void TestMeshSetPrimitives(GameContext p_Context, TextWriter p_Writer)
        {
            var s_Resources = p_Context.GetMountedResourceVariations();

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

                if (Limit > 0 && s_MeshSets >= Limit)
                    break;

                byte[] s_Payload;

                try
                {
                    s_Payload = ReadAll(l_Resource.FirstVariant);
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

                    if (FirstDiff(s_Payload, l_Slot, s_Written) < 0)
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

                        if (FirstDiff(s_Payload, (int) s_Offset, s_Written) < 0)
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

        void TestOccluderMatrices(GameContext p_Context, TextWriter p_Writer)
        {
            var s_Resources = p_Context.GetMountedResourceVariations();

            var s_Occluders = 0;
            var s_Total = 0;
            var s_Identical = 0;
            var s_FirstFailure = string.Empty;

            foreach (var l_Resource in s_Resources.Values)
            {
                if (l_Resource.FirstVariant.GetResourceType() != ResourceType.OccluderMesh)
                    continue;

                if (Limit > 0 && s_Occluders >= Limit)
                    break;

                byte[] s_Payload;

                try
                {
                    s_Payload = ReadAll(l_Resource.FirstVariant);
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

                    if (FirstDiff(s_Payload, (int) s_Offset, s_Written) < 0)
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

        // ---------------------------------------------------------------- Havok

        void TestHavok(GameContext p_Context, TextWriter p_Writer)
        {
            var s_Resources = p_Context.GetMountedResourceVariations();
            var s_Total = 0;
            var s_Dumped = 0;
            long s_Bytes = 0;

            if (HavokDumpDir != null && !HavokDumpDir.Exists)
                HavokDumpDir.Create();

            foreach (var l_Resource in s_Resources.Values)
            {
                if (l_Resource.FirstVariant.GetResourceType() != ResourceType.HavokPhysicsData)
                    continue;

                ++s_Total;

                if (HavokDumpDir == null || (Limit > 0 && s_Dumped >= Limit))
                    continue;

                try
                {
                    var s_Payload = ReadAll(l_Resource.FirstVariant);
                    var s_File = Path.Combine(HavokDumpDir.FullName,
                                              l_Resource.OriginalName.Replace('/', '_') + ".bin");

                    File.WriteAllBytes(s_File, s_Payload);

                    ++s_Dumped;
                    s_Bytes += s_Payload.Length;
                }
                catch (Exception)
                {
                    // A resource that cannot be read is counted but not dumped.
                }
            }

            p_Writer.WriteLine($"HAVOKPHYSICSDATA resources = {s_Total}, dumped = {s_Dumped} ({s_Bytes} bytes)");
        }
    }
}
