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
    /// How many (count, offset) array slots the header carries: four, or five for water.
    ///
    /// MEASURED across all 7,617 HavokPhysicsData resources BF3 ships -- 7,593 carry four slots and
    /// 24 carry five, and the 24 are exactly the `.water.mesh` resources that this reader used to
    /// reject as "Big endian Havok data". They are not big endian. A four-slot reader computes a
    /// packfile offset 16 bytes short, lands on the tail of MaterialFlagsAndIndices, reads it as an
    /// hkPackfileHeader and finds a zero in the layout-rule byte that says EndianType 0.
    /// </summary>
    public int ArraySlotCount { get; private set; } = 4;

    /// <summary>
    /// The fifth array, present only in the five-slot header.
    ///
    /// Kept as a count and an offset and nothing more, because every one of BF3's 24 instances
    /// declares ZERO elements -- so its element type is unobservable and inventing a stride for it
    /// would be assuming what cannot be checked. That is enough to write the header back exactly;
    /// Deserialize throws rather than guess if a resource ever ships a non-empty one.
    /// </summary>
    public int ExtraArrayCount { get; private set; }

    public long ExtraArrayOffset { get; private set; }

    /// <summary>
    /// The trailing relocations: the file offsets of the 64-bit array pointers in the header, so
    /// the engine can fix them up on load. One per array slot -- four normally, five for water --
    /// read back and written back.
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

    /// <summary>Bytes of header for a given number of array slots: 0x40 for four, 0x50 for five.</summary>
    static long HeaderSizeFor(int p_SlotCount)
    {
        // PartCount, then slot_count * (int32 count + int64 offset), then Scale and the two
        // material bytes, padded to 16.
        return RoundUp(4 + p_SlotCount * 12 + 6, 16);
    }

    /// <summary>
    /// How many array slots the header carries, read off where the FIRST array starts -- which is
    /// the end of the header, so the resource names its own shape instead of being sniffed for.
    /// </summary>
    static int SlotCountFrom(long p_FirstArrayOffset)
    {
        for (var s_Slots = 4; s_Slots <= 5; ++s_Slots)
            if (HeaderSizeFor(s_Slots) == p_FirstArrayOffset)
                return s_Slots;

        throw new NotSupportedException(
            $"HavokPhysicsData header ends at 0x{p_FirstArrayOffset:X}, which is neither the " +
            "four-slot (0x40) nor the five-slot (0x50) layout.");
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

        ArraySlotCount = SlotCountFrom(s_PartTranslationsOffset);

        var s_LocalAabbsCount = p_Reader.ReadInt32();
        var s_LocalAabbsOffset = LocalAabbsOffset = p_Reader.ReadInt64();

        var s_MaterialIndicesCount = p_Reader.ReadInt32();
        var s_MaterialIndiciesOffset = MaterialIndicesOffset = p_Reader.ReadInt64();

        var s_MaterialFlagsAndIndicesCount = p_Reader.ReadInt32();
        var s_MaterialFlagsAndIndicesOffset = MaterialFlagsAndIndicesOffset = p_Reader.ReadInt64();

        if (ArraySlotCount > 4)
        {
            ExtraArrayCount = p_Reader.ReadInt32();
            ExtraArrayOffset = p_Reader.ReadInt64();

            // All 24 shipped five-slot resources declare zero, so a non-zero one would need a
            // stride nothing has ever shown. Refuse loudly rather than mislay the packfile.
            if (ExtraArrayCount != 0)
                throw new NotSupportedException(
                    $"HavokPhysicsData's fifth array declares {ExtraArrayCount} element(s); every " +
                    "resource BF3 ships declares zero, so its element size is unknown.");
        }

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

        // Header first, then the arrays. This used to add a literal 60 and round; every array size
        // above is already a multiple of 16, so `+ 60` and `+ HeaderSizeFor(4)` land on the same
        // byte for the four-slot layout -- but only the header form follows the five-slot one.
        var s_HavokOffset = RoundUp(HeaderSizeFor(ArraySlotCount)
                                    + s_PartTranslationsSize + s_LocalAabbsSize
                                    + s_MaterialIndicesSize + s_MaterialFlagsAndIndicesSize, 16);
        p_Reader.Seek(s_HavokOffset, SeekOrigin.Begin);
        HavokInstance32 = new HavokInstance(p_Reader);
        p_Reader.Align(16);
        HavokInstance64 = new HavokInstance(p_Reader);
        p_Reader.Align(16);

        var fixupSize32 = p_Reader.ReadInt32();
        var fixupSize64 = p_Reader.ReadInt32();

        SetOffsets(p_Reader, HavokInstance32, fixupSize32);
        SetOffsets(p_Reader, HavokInstance64, fixupSize64);

        // One relocation per array slot: the file offset of that slot's 64-bit pointer -- 0x08,
        // 0x14, 0x20, 0x2C and, in the five-slot layout, 0x38.
        Relocations = new int[ArraySlotCount];

        for (var i = 0; i < ArraySlotCount; ++i)
            Relocations[i] = p_Reader.ReadInt32();

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

        // The two fixup regions are located from the SECTION HEADER, not from wherever the previous
        // loop stopped reading.
        //
        // MEASURED: 3,335 of BF3's 7,617 physics resources terminate the first region with -1 well
        // before its declared end. Resuming the second loop from that terminator made it read the
        // -1 and stop immediately, so ObjectOffsets came back EMPTY -- and ObjectOffsets is every
        // pointer the shape graph is made of. 1,238,946 object pointers were being lost that way,
        // silently, because an empty dictionary reads exactly like a resource with no children.
        var endPos = s_StartPos + p_Instance.DataSection.GlobalFixupsOffset;

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
                break;
            }
        }

        p_Reader.Seek(s_StartPos + p_Instance.DataSection.GlobalFixupsOffset, SeekOrigin.Begin);

        endPos = s_StartPos + p_Instance.DataSection.LocalFixupsOffset;

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
    /// Every leaf shape in the 32-bit packfile, ONCE PER PLACE THE GAME PUTS IT.
    ///
    /// This walks the object graph the fixup table describes rather than sweeping the virtual
    /// fixups for shape classes, and the difference is not cosmetic. BigRadioTower places 89 shapes
    /// through an hkpListShape: 67 of them behind an hkpConvexTransformShape (rotation AND
    /// translation), 2 behind an hkpConvexTranslateShape, 11 cylinders and 9 hulls directly. The
    /// old sweep read the 26 distinct hkpBoxShape objects and the 9 hulls -- 35 shapes -- gave 24
    /// of the boxes no position at all because only the 2 translate wrappers were understood, and
    /// collapsed the tower's 69 girder placements onto the 26 boxes they share. Corpus-wide the
    /// wrapper split is 102,842 hkpConvexTranslateShape against 52,448 hkpConvexTransformShape, so
    /// a third of BF3's placements were being dropped along with their rotation.
    ///
    /// The GRAPH IS THE FIXUP TABLE: a pointer slot inside object A that resolves to object B is an
    /// edge A -> B, and that is read out of the global fixups instead of decoding each class's
    /// array counts. It costs nothing in fidelity -- the fixups are how the engine itself finds the
    /// children -- and it means a list with a disabled or null child is walked correctly without
    /// this having to know what "disabled" looks like.
    /// </summary>
    public List<hkpCollisionShape> GetShapes()
    {
        return GetShapes(out _);
    }

    /// <summary>
    /// <inheritdoc cref="GetShapes()"/>
    /// </summary>
    /// <param name="p_Unread">
    /// Classes the walk reached and could not turn into geometry, by name and count. Reported
    /// rather than swallowed: a shape count with nothing to compare it against cannot say whether
    /// it is all of them, and the honest answer for hkpMoppCode or hkpCompressedMeshShape is that
    /// they are baked by the Havok SDK and are not modelled here.
    /// </param>
    public List<hkpCollisionShape> GetShapes(out Dictionary<string, int> p_Unread)
    {
        var s_Shapes = new List<hkpCollisionShape>();
        var s_Instance = HavokInstance32;
        var s_DataStart = s_Instance.DataSection.AbsoluteDataStart;

        var s_Unread = new Dictionary<string, int>();
        p_Unread = s_Unread;

        var s_ClassOf = BuildObjectIndex(s_Instance, out var s_ObjectStarts);

        if (s_ObjectStarts.Length == 0)
            return s_Shapes;

        // Sources of the global fixups, sorted, so the children of an object are the slice that
        // falls inside it.
        var s_FixupSources = s_Instance.ObjectOffsets.Keys.ToArray();
        Array.Sort(s_FixupSources);

        List<long> ChildrenOf(long p_Offset)
        {
            var s_Children = new List<long>();
            var s_Index = Array.BinarySearch(s_ObjectStarts, p_Offset);

            // The end of this object is where the next one begins.
            var s_End = s_Index >= 0 && s_Index + 1 < s_ObjectStarts.Length
                ? s_ObjectStarts[s_Index + 1]
                : long.MaxValue;

            var s_At = Array.BinarySearch(s_FixupSources, p_Offset);

            if (s_At < 0)
                s_At = ~s_At;

            for (; s_At < s_FixupSources.Length && s_FixupSources[s_At] < s_End; ++s_At)
                s_Children.Add(s_Instance.ObjectOffsets[s_FixupSources[s_At]]);

            return s_Children;
        }

        void Note(string p_Name)
        {
            s_Unread[p_Name] = s_Unread.TryGetValue(p_Name, out var s_Count) ? s_Count + 1 : 1;
        }

        // Depth is bounded because a list can hold a list -- 325 of BF3's do -- and a malformed
        // fixup could otherwise loop forever.
        void Visit(long p_Offset, hkpPlacement p_Placement, long p_PlacedBy, int p_Depth)
        {
            if (p_Depth > 32)
                return;

            if (!s_ClassOf.TryGetValue(p_Offset, out var s_Name))
            {
                Note("<no class name>");
                return;
            }

            hkpCollisionShape? s_Leaf = null;

            switch (s_Name)
            {
                case "hkpMoppBvTreeShape":
                case "hkpListShape":
                // The storage mesh's geometry lives in a child subpart storage, and any wrappers it
                // holds are ordinary placements. hkpExtendedMeshShape is deliberately NOT here: its
                // subparts hold 819,307 pointer slots onto a few hundred shared wrappers, so
                // walking it would emit the same shape thousands of times.
                case "hkpStorageExtendedMeshShape":
                    foreach (var l_Child in ChildrenOf(p_Offset))
                        Visit(l_Child, p_Placement, p_PlacedBy, p_Depth + 1);

                    return;

                // The MOPP acceleration blob hangs off the bv-tree beside the real shape. It is not
                // geometry, so it is skipped rather than counted as something unread.
                case "hkpMoppCode":
                    return;

                case "hkpConvexTranslateShape":
                {
                    var s_Wrapper = hkpShapeReader.ReadTranslate(s_Instance.Reader, s_DataStart,
                                                                 p_Offset, s_Instance.ObjectOffsets);

                    if (s_Wrapper == null)
                    {
                        Note(s_Name);
                        return;
                    }

                    Visit(s_Wrapper.Value.Child,
                          p_Placement.Compose(hkpPlacement.FromTranslation(s_Wrapper.Value.Centre)),
                          p_Offset, p_Depth + 1);

                    return;
                }

                case "hkpConvexTransformShape":
                {
                    var s_Wrapper = hkpShapeReader.ReadTransform(s_Instance.Reader, s_DataStart,
                                                                 p_Offset, s_Instance.ObjectOffsets);

                    if (s_Wrapper == null)
                    {
                        Note(s_Name);
                        return;
                    }

                    Visit(s_Wrapper.Value.Child, p_Placement.Compose(s_Wrapper.Value.Placement),
                          p_Offset, p_Depth + 1);

                    return;
                }

                case "hkpBoxShape":
                    s_Leaf = hkpShapeReader.ReadBox(s_Instance.Reader, s_DataStart, p_Offset);
                    break;

                case "hkpConvexVerticesShape":
                    s_Leaf = hkpShapeReader.ReadConvex(s_Instance.Reader, s_DataStart, p_Offset,
                                                       s_Instance.ArrayOffsets,
                                                       s_Instance.ObjectOffsets);
                    break;

                case "hkpCylinderShape":
                    s_Leaf = hkpShapeReader.ReadCylinder(s_Instance.Reader, s_DataStart, p_Offset);
                    break;

                case "hkpCapsuleShape":
                    s_Leaf = hkpShapeReader.ReadCapsule(s_Instance.Reader, s_DataStart, p_Offset);
                    break;

                case "hkpSphereShape":
                    s_Leaf = hkpShapeReader.ReadSphere(s_Instance.Reader, s_DataStart, p_Offset);
                    break;

                case "hkpStorageExtendedMeshShapeMeshSubpartStorage":
                {
                    var s_At = Array.BinarySearch(s_ObjectStarts, p_Offset);
                    var s_End = s_At >= 0 && s_At + 1 < s_ObjectStarts.Length
                        ? s_ObjectStarts[s_At + 1]
                        : s_Instance.DataSection.VirtualFixupsOffset;

                    s_Leaf = hkpShapeReader.ReadStorageMesh(s_Instance.Reader, s_DataStart, p_Offset,
                                                            s_End, s_Instance.ArrayOffsets);

                    if (s_Leaf == null)
                    {
                        Note(s_Name);
                        return;
                    }

                    break;
                }

                default:
                    Note(s_Name);
                    return;
            }

            s_Leaf.Centre = p_Placement.Translation;
            s_Leaf.Placement = p_Placement;
            s_Leaf.PlacementOffset = p_PlacedBy;

            s_Shapes.Add(s_Leaf);
        }

        // The roots are whatever HavokPhysicsContainer points at. Its shape slots start at +32 and
        // BF3 uses one, two or three of them (7,617 resources: 4,485 at +32 alone, 3,626 with a
        // second at +36, 24 with a third at +40), so they are taken from the fixup table rather
        // than from an assumed count.
        foreach (var l_Object in s_ObjectStarts)
        {
            if (s_ClassOf.TryGetValue(l_Object, out var l_Name) && l_Name == "HavokPhysicsContainer")
                foreach (var l_Root in ChildrenOf(l_Object))
                    Visit(l_Root, hkpPlacement.Identity, l_Root, 0);
        }

        return s_Shapes;
    }

    /// <summary>Class name per object offset, plus those offsets sorted.</summary>
    static Dictionary<long, string> BuildObjectIndex(HavokInstance p_Instance, out long[] p_Starts)
    {
        var s_NameOf = new Dictionary<long, string>();

        foreach (var l_Descriptor in p_Instance.Descriptors)
            s_NameOf[l_Descriptor.Key] = l_Descriptor.Name;

        var s_ClassOf = new Dictionary<long, string>();

        foreach (var l_Info in p_Instance.DescriptorInfos)
            if (s_NameOf.TryGetValue(l_Info.Key, out var l_Name))
                s_ClassOf[l_Info.Offset] = l_Name;

        p_Starts = p_Instance.DescriptorInfos.Select(i => i.Offset).Distinct().OrderBy(o => o).ToArray();

        return s_ClassOf;
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

        if (ArraySlotCount > 4)
        {
            p_Writer.Write(ExtraArrayCount);
            p_Writer.Write(ExtraArrayOffset);
        }

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

        var s_HavokOffset = RoundUp(HeaderSizeFor(ArraySlotCount)
                                    + s_PartTranslationsSize + s_LocalAabbsSize
                                    + s_MaterialIndicesSize + s_MaterialFlagsAndIndicesSize, 16);
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