using System.Diagnostics.CodeAnalysis;
using fb;
using RimeLib.Frostbite;
using RimeLib.IO;
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

        public bool Serialize(RimeWriter p_Writer)
        {
            throw new NotImplementedException();
        }

        public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
        {
            throw new NotImplementedException();
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
        PartCount = p_Reader.ReadUInt32();

        var s_PartTranslationsCount = p_Reader.ReadInt32();
        var s_PartTranslationsOffset = p_Reader.ReadInt64();

        var s_LocalAabbsCount = p_Reader.ReadInt32();
        var s_LocalAabbsOffset = p_Reader.ReadInt64();

        var s_MaterialIndicesCount = p_Reader.ReadInt32();
        var s_MaterialIndiciesOffset = p_Reader.ReadInt64();

        var s_MaterialFlagsAndIndicesCount = p_Reader.ReadInt32();
        var s_MaterialFlagsAndIndicesOffset = p_Reader.ReadInt64();

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
            MaterialFlagsAndIndices.Add(p_Reader.ReadUInt16());
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
        p_Reader.ReadInt32(); // 0x08. Offset of PartTranslationsOffset.
        p_Reader.ReadInt32(); // 0x14. Offset of LocalAabbsOffset.
        p_Reader.ReadInt32(); // 0x20. Offset of MaterialIndiciesOffset.
        p_Reader.ReadInt32(); // 0x2C. Offset of MaterialFlagsAndIndicesSize.
    }

    private void SetOffsets(RimeReader p_Reader, HavokInstance p_Instance, int p_FixupSize)
    {
        var s_ExpectedEndPos = p_Reader.Position + p_FixupSize;

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

    public bool Serialize(RimeWriter p_Writer)
    {
        throw new NotImplementedException();
    }

    public bool Serialize(out byte[]? p_Data)
    {
        throw new NotImplementedException();
    }

}