using System.Diagnostics.CodeAnalysis;
using fb;
using RimeLib.Frostbite;
using RimeLib.IO;
using RimeLib.IO.Conversion;
using RimeLib.Serialization.Frostbite2_0.Extensions;

namespace RimeLib.Havok.Frostbite2_0;

public class HavokPhysicsData : IFbSerializable
{
    public uint PartCount { get; private set; }
    public float Scale { get; private set; }
    public byte MaterialCountUsed { get; private set; }
    public byte HighestMaterialIndex { get; private set; }
    public List<Vec3> PartTranslations { get; private set; } = [];
    public List<AxisAlignedBox> LocalAabbs { get; private set; } = [];
    public List<byte> MaterialIndices { get; private set; } = [];
    public List<uint> MaterialFlagsAndIndices { get; private set; } = [];
    public HavokInstance HavokInstance32 { get; private set; } = new();
    public HavokInstance HavokInstance64 { get; private set; } = new();

    /// <summary>
    /// Where each array sits in the file. These are stored rather than recomputed because they are
    /// what the four relocation entries at the end of the resource point at, and a writer that
    /// derived them instead would silently disagree with those entries the moment an array changed
    /// size.
    /// </summary>
    public long PartTranslationsOffset { get; private set; }
    public long LocalAabbsOffset { get; private set; }
    public long MaterialIndicesOffset { get; private set; }
    public long MaterialFlagsAndIndicesOffset { get; private set; }

    /// <summary>
    /// The four trailing relocations: the file offsets of the four 64-bit array pointers in the
    /// header, so the engine can fix them up on load. Read back and written back.
    /// </summary>
    public int[] Relocations { get; private set; } = new int[4];

    public HavokPhysicsData(RimeReader p_Reader)
    {
        Deserialize(p_Reader);
    }

    public class HavokInstance : IFbSerializable
    {
        public byte PointerSize { get; private set; } = 4;
        public byte EndianType { get; private set; } = 1;
        public hkPackfileHeader HkPackfile { get; private set; } = new();
        public hkPackfileSectionHeader ClassNamesSection { get; private set; } = new();
        public hkPackfileSectionHeader TypesSection { get; private set; } = new();
        public hkPackfileSectionHeader DataSection { get; private set; } = new();
        public List<hkDescriptor> Descriptors { get; private set; } = [];
        public List<hkDescriptorInfo> DescriptorInfos { get; private set; } = [];
        public LimitedRimeReader Reader { get; private set; }
        public Dictionary<long, long> ArrayOffsets { get; internal set; } = [];
        public Dictionary<long, long> ObjectOffsets { get; internal set; } = [];

        /// <summary>
        /// The body of the __data__ section: every Havok object, byte for byte.
        ///
        /// NOT MODELLED. Deserialize decodes only the virtual fixups that index into this span --
        /// where each object starts and which class it is -- and never the objects themselves. So
        /// there are no fields to write it back from, and it is carried verbatim. Anything that
        /// edits a shape has to rebuild this span itself; that is what the Python builder in
        /// MapEditor's tools/havok/build_collision.py does.
        /// </summary>
        public byte[] ObjectData { get; internal set; } = [];

        /// <summary>
        /// This instance's Frostbite-level fixup blob, which sits after both packfiles.
        ///
        /// NOT MODELLED for writing. SetOffsets decodes it into ArrayOffsets and ObjectOffsets, but
        /// those are unordered lookup tables that drop the -1 terminators and the padding out to
        /// the declared blob size, so they cannot reproduce the bytes. Carried verbatim.
        /// </summary>
        public byte[] FixupData { get; internal set; } = [];


        public HavokInstance()
        {
            
        }

        public HavokInstance(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }

        public void Deserialize(RimeReader p_Reader)
        {
            // Size is not correct, but does not matter.
            Reader = new LimitedRimeReader(p_Reader, p_Reader.Length - p_Reader.Position);

            HkPackfile.Deserialize(Reader);

            PointerSize = HkPackfile.LayoutRules[(int)hkPackfileHeader.LayoutRule.PointerSize];
            EndianType = HkPackfile.LayoutRules[(int)hkPackfileHeader.LayoutRule.EndianType];

            if (EndianType != 1)
                throw new NotSupportedException("Big endian Havok data is not supported.");

            ClassNamesSection.Deserialize(Reader);
            TypesSection.Deserialize(Reader);
            DataSection.Deserialize(Reader);

            /// SECTION 1: CLASS NAMES
            DeserializeClassNames(Reader);
            // Skip section 2 because it is always empty.
            DeserializeData(Reader);

            // The object bytes, kept so that Serialize has something to write for the span it does
            // not model. Read AFTER the fixups so the reader is left where DeserializeData left it.
            var s_Resume = Reader.Position;

            Reader.Seek(DataSection.AbsoluteDataStart, SeekOrigin.Begin);
            ObjectData = Reader.ReadBytes(DataSection.VirtualFixupsOffset);

            Reader.Seek(s_Resume, SeekOrigin.Begin);
        }

        private void DeserializeClassNames(RimeReader p_Reader)
        {
            // Go to the start of the Havok descriptor start
            p_Reader.Seek(ClassNamesSection.AbsoluteDataStart,  SeekOrigin.Begin);
            var s_DescriptorReader = new LimitedRimeReader(p_Reader, ClassNamesSection.EndOffset);

            Descriptors = new List<hkDescriptor>();

            while (s_DescriptorReader.Position < s_DescriptorReader.Length)
            {
                var s_EndByte = s_DescriptorReader.ReadByte();
                s_DescriptorReader.Seek(-1, SeekOrigin.Current);
                
                if (s_EndByte == 0xFF) // alignment leftover bytes.
                    break;

                var s_Descriptor = new hkDescriptor();
                s_Descriptor.Deserialize(s_DescriptorReader);
                
                Descriptors.Add(s_Descriptor);
            }
        }

        private void DeserializeData(RimeReader p_Reader)
        {
            // Jump to the DescriptorInfo.
            p_Reader.Seek(DataSection.AbsoluteDataStart + DataSection.VirtualFixupsOffset, SeekOrigin.Begin);

            var s_DescriptorInfoCount = (DataSection.EndOffset - DataSection.VirtualFixupsOffset) / hkDescriptorInfo.c_SizeOfDescriptorInfo;
            for (var i = 0; i < s_DescriptorInfoCount; i++)
            {
                DescriptorInfos.Add(new hkDescriptorInfo(p_Reader));
            }
        }

        public void Deserialize(byte[] p_Data)
        {
            using var s_Reader = new RimeReader(new MemoryStream(p_Data));
            
            Deserialize(s_Reader);
        }

        /// <summary>
        /// Mirrors <see cref="Deserialize(RimeReader)"/> section by section, in its order.
        ///
        /// Modelled and written from fields: the packfile header, the three section headers, the
        /// class-name descriptors and the virtual fixups. Carried verbatim: the __data__ objects
        /// (see <see cref="ObjectData"/>), which the reader never decodes.
        /// </summary>
        public bool Serialize(RimeWriter p_Writer)
        {
            var s_Start = p_Writer.Position;

            HkPackfile.Serialize(p_Writer);

            ClassNamesSection.Serialize(p_Writer);
            TypesSection.Serialize(p_Writer);
            DataSection.Serialize(p_Writer);

            // SECTION 1: CLASS NAMES.
            p_Writer.Seek(s_Start + ClassNamesSection.AbsoluteDataStart, SeekOrigin.Begin);

            foreach (var l_Descriptor in Descriptors)
                l_Descriptor.Serialize(p_Writer);

            // The reader stops on the first 0xFF, so the leftover of the section is 0xFF and not
            // zero -- padding it with zero would produce a section that reads back as more,
            // empty-named descriptors.
            var s_ClassNamesEnd = s_Start + ClassNamesSection.AbsoluteDataStart + ClassNamesSection.EndOffset;

            while (p_Writer.Position < s_ClassNamesEnd)
                p_Writer.Write((byte) 0xFF);

            // SECTION 2: TYPES. Always empty, so there is nothing to write.

            // SECTION 3: DATA. The objects, then the virtual fixups that index them.
            p_Writer.Seek(s_Start + DataSection.AbsoluteDataStart, SeekOrigin.Begin);
            p_Writer.Write(ObjectData);

            p_Writer.Seek(s_Start + DataSection.AbsoluteDataStart + DataSection.VirtualFixupsOffset,
                          SeekOrigin.Begin);

            foreach (var l_Info in DescriptorInfos)
            {
                p_Writer.Write(l_Info.Offset);
                p_Writer.Write(l_Info.Key);
            }

            // The section rarely ends on a whole 12-byte fixup -- DeserializeData divides the region
            // by the record size and drops the remainder -- and that remainder is 0xFF, not zero.
            // MEASURED: writing zero there was the only difference in 2,887 of BF3's 7,593 physics
            // resources, at 0x2288 of MEHouse01Large (8 leftover bytes) and 0x59C of the canals
            // bridge pillar (4).
            var s_DataEnd = s_Start + DataSection.AbsoluteDataStart + DataSection.EndOffset;

            while (p_Writer.Position < s_DataEnd)
                p_Writer.Write((byte) 0xFF);

            p_Writer.Seek(s_DataEnd, SeekOrigin.Begin);

            return true;
        }

        public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
        {
            var s_Stream = new MemoryStream();
            using var s_Writer = new RimeWriter(s_Stream);

            if (Serialize(s_Writer))
            {
                p_Data = s_Stream.ToArray();
                return true;
            }

            p_Data = null;
            return false;
        }
    }

    static long RoundUp(long p_Position, long p_Alignment)
    {
        return (p_Position + (p_Alignment - 1)) & ~(p_Alignment - 1);
    }

    public void Deserialize(byte[] p_Data)
    {
        using var s_Reader = new RimeReader(new MemoryStream(p_Data));
        
        Deserialize(s_Reader);
    }

    public void Deserialize(RimeReader p_Reader)
    {
        var s_PrevEndianness = p_Reader.Endianness;
        p_Reader.Endianness = Endianness.LittleEndian;

        PartCount = p_Reader.ReadUInt32();

        var s_PartTranslationsCount = p_Reader.ReadInt32();
        var s_PartTranslationsOffset = PartTranslationsOffset = p_Reader.ReadInt64();

        var s_LocalAabbsCount = p_Reader.ReadInt32();
        var s_LocalAabbsOffset = LocalAabbsOffset = p_Reader.ReadInt64();

        var s_MaterialIndicesCount = p_Reader.ReadInt32();
        var s_MaterialIndiciesOffset = MaterialIndicesOffset = p_Reader.ReadInt64();

        var s_MaterialFlagsAndIndicesCount = p_Reader.ReadInt32();
        var s_MaterialFlagsAndIndicesOffset = MaterialFlagsAndIndicesOffset = p_Reader.ReadInt64();

        var s_PartTranslationsSize = RoundUp(s_PartTranslationsCount * 16, 16);
        var s_LocalAabbsSize = RoundUp(s_LocalAabbsCount * 32, 16);
        var s_MaterialIndicesSize = RoundUp(s_MaterialIndicesCount * 1, 16);
        var s_MaterialFlagsAndIndicesSize = RoundUp(s_MaterialFlagsAndIndicesCount * 4, 16);

        Scale = p_Reader.ReadSingle(); // TODO: Seems to be something else.
        MaterialCountUsed = p_Reader.ReadUByte();
        HighestMaterialIndex = p_Reader.ReadUByte();
        p_Reader.Align(16);

        p_Reader.Seek(s_PartTranslationsOffset, SeekOrigin.Begin);
        for (var i = 0; i < s_PartTranslationsCount; i++)
        {
            var s_Vec = new Vec3();
            s_Vec.Deserialize(p_Reader);

            PartTranslations.Add(s_Vec);
        }

        p_Reader.Seek(s_LocalAabbsOffset, SeekOrigin.Begin);
        for (var i = 0; i < s_LocalAabbsCount; ++i)
        {
            var s_AxisAlignedBox = new AxisAlignedBox();
            s_AxisAlignedBox.Deserialize(p_Reader);

            LocalAabbs.Add(s_AxisAlignedBox);
        }

        p_Reader.Seek(s_MaterialIndiciesOffset, SeekOrigin.Begin);
        for (var i = 0; i < s_MaterialIndicesCount; ++i)
        {
            MaterialIndices.Add(p_Reader.ReadUByte());
        }

        p_Reader.Seek(s_MaterialFlagsAndIndicesOffset, SeekOrigin.Begin);
        for (var i = 0; i < s_MaterialFlagsAndIndicesCount; ++i)
        {
            // UInt32, not UInt16: the stride this very method computes is count * 4, and the list
            // is List<uint>. Reading 2 bytes at a time walked half the array and shifted every
            // value -- MEHouse01Large holds [0, 1164, 0] at offset 1104 and came back
            // [0, 0, 1164], which is exactly those 12 bytes read as six shorts.
            MaterialFlagsAndIndices.Add(p_Reader.ReadUInt32());
        }

        var s_HavokOffset = RoundUp(s_PartTranslationsSize + s_LocalAabbsSize + s_MaterialIndicesSize + s_MaterialFlagsAndIndicesSize + 60, 16);
        p_Reader.Seek(s_HavokOffset, SeekOrigin.Begin);
        HavokInstance32 = new HavokInstance(p_Reader);
        p_Reader.Align(16);
        HavokInstance64 = new HavokInstance(p_Reader);
        p_Reader.Align(16);

        var fixupSize32 = p_Reader.ReadInt32();
        var fixupSize64 = p_Reader.ReadInt32();

        SetOffsets(p_Reader, HavokInstance32, fixupSize32);
        SetOffsets(p_Reader, HavokInstance64, fixupSize64);

        // 0x10 bytes remaining. Relocations for the HavokPhysicsData.
        Relocations[0] = p_Reader.ReadInt32(); // 0x08. Offset of PartTranslationsOffset.
        Relocations[1] = p_Reader.ReadInt32(); // 0x14. Offset of LocalAabbsOffset.
        Relocations[2] = p_Reader.ReadInt32(); // 0x20. Offset of MaterialIndiciesOffset.
        Relocations[3] = p_Reader.ReadInt32(); // 0x2C. Offset of MaterialFlagsAndIndicesSize.

        p_Reader.Endianness = s_PrevEndianness;
    }

    private void SetOffsets(RimeReader p_Reader, HavokInstance p_Instance, int p_FixupSize)
    {
        var s_StartPos = p_Reader.Position;
        var s_ExpectedEndPos = s_StartPos + p_FixupSize;

        // Kept whole before it is decoded: the decode below drops the -1 terminators and whatever
        // pads the blob out to p_FixupSize, so the dictionaries it builds cannot write it back.
        p_Instance.FixupData = p_Reader.ReadBytes(p_FixupSize);
        p_Reader.Seek(s_StartPos, SeekOrigin.Begin);

        var endPos = p_Reader.Position + p_Instance.DataSection.GlobalFixupsOffset;
        while (p_Reader.Position < endPos)
        {
            int offset = p_Reader.ReadInt32();

            if (offset != -1)
            {
                int objOffset = p_Reader.ReadInt32();
                p_Instance.ArrayOffsets.Add(offset, objOffset);
            }
            else
            {
                p_Reader.Seek(-4, SeekOrigin.Current);
                break;
            }
        }
        
        endPos = p_Reader.Position + p_Instance.DataSection.LocalFixupsOffset - p_Instance.DataSection.GlobalFixupsOffset;
        
        while (p_Reader.Position < endPos)
        {
            int offset = p_Reader.ReadInt32();

            if (offset != -1)
            {
                p_Reader.ReadInt32();
                int objOffset = p_Reader.ReadInt32();
                p_Instance.ObjectOffsets.Add(offset, objOffset);
            }
            else
            {
                p_Reader.Seek(-4, SeekOrigin.Current);
                break;
            }
        }

        if (p_Reader.Position != s_ExpectedEndPos)
        {
            p_Reader.Seek((int)(s_ExpectedEndPos - p_Reader.Position), SeekOrigin.Current);
        }
    }

    public List<hkpTransform> GetTransforms()
    {
        var s_Transforms = new List<hkpTransform>();

        for (var i = 0; i < HavokInstance32.DescriptorInfos.Count; i++)
        {
            var s_DescriptorInfo = HavokInstance32.DescriptorInfos[i];
            var s_Descriptor = HavokInstance32.Descriptors.FirstOrDefault(d => d.Key == s_DescriptorInfo.Key);

            if (s_Descriptor == null)
                continue;

            if (s_Descriptor.Name == "hkpExtendedMeshShape")
            {
                HavokInstance32.Reader.Seek(HavokInstance32.DataSection.AbsoluteDataStart + s_DescriptorInfo.Offset, SeekOrigin.Begin);
                var s_ExtendedMeshShape = new hkpExtendedMeshShape(HavokInstance32.Reader);
                s_Transforms = s_ExtendedMeshShape.Transforms;
            }
        }

        return s_Transforms;
    }

    /// <summary>
    /// Every box and convex hull in the 32-bit packfile, with the translation its wrapper gives it.
    ///
    /// Shapes are reached through hkpConvexTranslateShape where there is one, because that wrapper
    /// carries the placement -- the child alone knows its size and not where it sits. A shape with
    /// no wrapper is still reported, at the origin.
    /// </summary>
    public List<hkpCollisionShape> GetShapes()
    {
        var s_Shapes = new List<hkpCollisionShape>();
        var s_Instance = HavokInstance32;
        var s_DataStart = s_Instance.DataSection.AbsoluteDataStart;
        var s_Placed = new Dictionary<long, (System.Numerics.Vector3 Centre, float Radius)>();

        string? NameOf(hkDescriptorInfo p_Info)
        {
            return s_Instance.Descriptors.FirstOrDefault(d => d.Key == p_Info.Key)?.Name;
        }

        // Wrappers first: a child has to know where it was placed before it is read.
        foreach (var l_Info in s_Instance.DescriptorInfos)
        {
            if (NameOf(l_Info) != "hkpConvexTranslateShape")
                continue;

            var s_Placement = hkpShapeReader.ReadTranslate(s_Instance.Reader, s_DataStart,
                                                           l_Info.Offset, s_Instance.ObjectOffsets);

            if (s_Placement != null)
                s_Placed[s_Placement.Value.Child] = (s_Placement.Value.Centre, s_Placement.Value.Radius);
        }

        foreach (var l_Info in s_Instance.DescriptorInfos)
        {
            var s_Name = NameOf(l_Info);
            hkpCollisionShape? s_Shape = null;

            if (s_Name == "hkpBoxShape")
                s_Shape = hkpShapeReader.ReadBox(s_Instance.Reader, s_DataStart, l_Info.Offset);
            else if (s_Name == "hkpConvexVerticesShape")
                s_Shape = hkpShapeReader.ReadConvex(s_Instance.Reader, s_DataStart, l_Info.Offset,
                                                    s_Instance.ArrayOffsets);

            if (s_Shape == null)
                continue;

            if (s_Placed.TryGetValue(l_Info.Offset, out var s_Placement))
                s_Shape.Centre = s_Placement.Centre;

            s_Shapes.Add(s_Shape);
        }

        return s_Shapes;
    }

    /// <summary>
    /// Mirrors <see cref="Deserialize(RimeReader)"/> field for field, in its order.
    ///
    /// Everything the reader decodes is written from a field: the header, the four arrays at the
    /// offsets they were read from, both packfiles' headers, class names and virtual fixups, and
    /// the four trailing relocations. The two spans the reader never decodes -- the Havok object
    /// data and the Frostbite fixup blobs -- are carried verbatim and say so at their declarations.
    ///
    /// The layout is offset-driven, so this seeks rather than streams: the header stores where each
    /// array lives, and writing them in sequence instead would silently move them.
    /// </summary>
    public bool Serialize(RimeWriter p_Writer)
    {
        var s_PrevEndianness = p_Writer.Endianness;
        p_Writer.Endianness = Endianness.LittleEndian;

        // Deserialize seeks from Begin, so it assumes the resource starts at position 0. This keeps
        // the same assumption but anchors it to wherever the writer actually is.
        var s_Start = p_Writer.Position;

        p_Writer.Write(PartCount);

        p_Writer.Write(PartTranslations.Count);
        p_Writer.Write(PartTranslationsOffset);

        p_Writer.Write(LocalAabbs.Count);
        p_Writer.Write(LocalAabbsOffset);

        p_Writer.Write(MaterialIndices.Count);
        p_Writer.Write(MaterialIndicesOffset);

        p_Writer.Write(MaterialFlagsAndIndices.Count);
        p_Writer.Write(MaterialFlagsAndIndicesOffset);

        var s_PartTranslationsSize = RoundUp(PartTranslations.Count * 16, 16);
        var s_LocalAabbsSize = RoundUp(LocalAabbs.Count * 32, 16);
        var s_MaterialIndicesSize = RoundUp(MaterialIndices.Count * 1, 16);
        var s_MaterialFlagsAndIndicesSize = RoundUp(MaterialFlagsAndIndices.Count * 4, 16);

        p_Writer.Write(Scale);
        p_Writer.Write(MaterialCountUsed);
        p_Writer.Write(HighestMaterialIndex);
        p_Writer.Align(16);

        p_Writer.Seek(s_Start + PartTranslationsOffset, SeekOrigin.Begin);
        foreach (var l_Translation in PartTranslations)
            l_Translation.Serialize(p_Writer);

        p_Writer.Seek(s_Start + LocalAabbsOffset, SeekOrigin.Begin);
        foreach (var l_Aabb in LocalAabbs)
            l_Aabb.Serialize(p_Writer);

        p_Writer.Seek(s_Start + MaterialIndicesOffset, SeekOrigin.Begin);
        foreach (var l_Index in MaterialIndices)
            p_Writer.Write(l_Index);

        p_Writer.Seek(s_Start + MaterialFlagsAndIndicesOffset, SeekOrigin.Begin);
        foreach (var l_Value in MaterialFlagsAndIndices)
            p_Writer.Write(l_Value);

        var s_HavokOffset = RoundUp(s_PartTranslationsSize + s_LocalAabbsSize + s_MaterialIndicesSize + s_MaterialFlagsAndIndicesSize + 60, 16);
        p_Writer.Seek(s_Start + s_HavokOffset, SeekOrigin.Begin);

        HavokInstance32.Serialize(p_Writer);
        p_Writer.Align(16);
        HavokInstance64.Serialize(p_Writer);
        p_Writer.Align(16);

        p_Writer.Write(HavokInstance32.FixupData.Length);
        p_Writer.Write(HavokInstance64.FixupData.Length);

        p_Writer.Write(HavokInstance32.FixupData);
        p_Writer.Write(HavokInstance64.FixupData);

        foreach (var l_Relocation in Relocations)
            p_Writer.Write(l_Relocation);

        p_Writer.Endianness = s_PrevEndianness;

        return true;
    }

    public bool Serialize(out byte[]? p_Data)
    {
        var s_Stream = new MemoryStream();
        using var s_Writer = new RimeWriter(s_Stream);

        if (Serialize(s_Writer))
        {
            p_Data = s_Stream.ToArray();
            return true;
        }

        p_Data = null;
        return false;
    }

}