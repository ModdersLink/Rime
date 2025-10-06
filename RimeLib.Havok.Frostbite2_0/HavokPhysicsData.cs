using System.Diagnostics.CodeAnalysis;
using fb;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using RimeLib.IO.Conversion;
using RimeLib.Serialization.Frostbite2_0.Extensions;

namespace RimeLib.Havok.Frostbite2_0;

public class HavokPhysicsData : IFbSerializable
{
    public class LoadedData : IFbSerializable
    {
        public uint PartCount { get; set; }
        // public RelocArray<Vec3> PartTranslations { get; set; } = new RelocArray<Vec3>();
        public List<Vec3> PartTranslations { get; set; } = new();
        // TODO: Wait for RelocArray/Ptr to be unfucked, manually parse for now
        // public RelocArray<AxisAlignedBox> LocalAabbs { get; set; } = new RelocArray<AxisAlignedBox>();
        public List<AxisAlignedBox> LocalAabbs { get; set; } = new();
        // public RelocArray<byte> MaterialIndices { get; set; } = new RelocArray<byte>();
        public List<byte> MaterialIndices { get; set; } = new();
        // public RelocArray<uint> MaterialFlagsAndIndices { get; set; } = new RelocArray<uint>();
        public List<uint> MaterialFlagsAndIndices { get; set; } = new();
        public float Scale { get; set; }
        public byte MaterialCountUsed { get; set; }
        public byte HighestMaterialIndex { get; set; }
        public ushort Padding { get; set; }
    
        public hkPackfileHeader HkPackfile { get; set; }
        public bool Serialize(RimeWriter p_Writer)
        {
            throw new NotImplementedException();
        }

        public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
        {
            throw new NotImplementedException();
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
            
            Scale = p_Reader.ReadSingle();
            MaterialCountUsed = p_Reader.ReadUByte();
            HighestMaterialIndex = p_Reader.ReadUByte();
            Padding =  p_Reader.ReadUInt16();
            
            p_Reader.Seek(s_PartTranslationsOffset, SeekOrigin.Begin);
            for (var s_PartTranslationIndex = 0;
                 s_PartTranslationIndex < s_PartTranslationsCount;
                 s_PartTranslationIndex++)
            {
                var s_Vec = new Vec3();
                s_Vec.Deserialize(p_Reader);
                
                PartTranslations.Add(s_Vec);
            }
            
            p_Reader.Seek(s_LocalAabbsOffset, SeekOrigin.Begin);
            for (var s_LocalAabbIndex = 0; s_LocalAabbIndex < s_LocalAabbsCount; ++s_LocalAabbIndex)
            {
                var s_AxisAlignedBox = new AxisAlignedBox();
                s_AxisAlignedBox.Deserialize(p_Reader);

                LocalAabbs.Add(s_AxisAlignedBox);
            }
            
            p_Reader.Seek(s_MaterialIndiciesOffset, SeekOrigin.Begin);
            for (var s_MaterialIndicesIndex = 0;
                 s_MaterialIndicesIndex < s_MaterialIndicesCount;
                 ++s_MaterialIndicesIndex)
            {
                MaterialIndices.Add(p_Reader.ReadUByte());
            }
            
            p_Reader.Seek(s_MaterialFlagsAndIndicesOffset, SeekOrigin.Begin);
            for (var s_MaterialFlagsAndIndicesIndex = 0; s_MaterialFlagsAndIndicesIndex < s_MaterialFlagsAndIndicesCount; ++s_MaterialFlagsAndIndicesIndex)
                MaterialFlagsAndIndices.Add(p_Reader.ReadUInt16());
            
            p_Reader.Align(16);
            
            // So the data that we need is 0x57E0E057
        }

        public void Deserialize(byte[] p_Data)
        {
            using var s_Reader = new RimeReader(new MemoryStream(p_Data));
            
            Deserialize(s_Reader);
        }
    }
    
    
    /*public HavokPhysicsData(
        RimeReader p_Reader,
        int p_ResourceHeaderSize,
        int p_HavokDataSize32,
        int p_HavokDataSize64,
        int p_FixupTableSize
    )
    {
        var s_StartPos = p_Reader.Position;
        PartCount = p_Reader.ReadUInt32();

        // Manually parse this out until we can fix the hack
        var s_PartTranslationsCount = p_Reader.ReadUInt32();
        var s_PartTranslationsOffset = p_Reader.ReadInt64();

        var s_Position = p_Reader.Position;
        p_Reader.Seek(s_PartTranslationsOffset, SeekOrigin.Begin);
        for (var i = 0; i < s_PartTranslationsCount; i++)
        {
            PartTranslations.Add(new Vec3
            {
                x = p_Reader.ReadSingle(),
                y = p_Reader.ReadSingle(),
                z = p_Reader.ReadSingle(),
            });
            // Vec3 has padding
            p_Reader.ReadSingle();
        }
        p_Reader.Seek(s_Position, SeekOrigin.Begin);

        // PartTranslations = new RelocArray<Vec3>(p_Reader);

        var s_LocalAabbsCount = p_Reader.ReadUInt32();
        var s_LocalAabbsOffset = p_Reader.ReadInt64();

        s_Position = p_Reader.Position;
        p_Reader.Seek(s_LocalAabbsOffset, SeekOrigin.Begin);
        for (var i = 0; i < s_LocalAabbsCount; i++)
        {
            var s_Min = new Vec3
            {
                x = p_Reader.ReadSingle(),
                y = p_Reader.ReadSingle(),
                z = p_Reader.ReadSingle()
            };
            p_Reader.ReadSingle();

            var s_Max = new Vec3
            {
                x = p_Reader.ReadSingle(),
                y = p_Reader.ReadSingle(),
                z = p_Reader.ReadSingle()
            };
            p_Reader.ReadSingle();

            LocalAabbs.Add(new AxisAlignedBox
            {
                min = s_Min,
                max = s_Max,
            });
        }
        p_Reader.Seek(s_Position,SeekOrigin.Begin);

        // LocalAabbs = new RelocArray<AxisAlignedBox>(p_Reader);

        var s_MaterialIndicesCount = p_Reader.ReadUInt32();
        var s_MaterialIndicesOffset = p_Reader.ReadInt64();

        s_Position = p_Reader.Position;
        p_Reader.Seek(s_MaterialIndicesOffset, SeekOrigin.Begin);
        for (var i = 0; i < s_MaterialIndicesCount; i++)
            MaterialIndices.Add(p_Reader.ReadUByte());

        p_Reader.Seek(s_Position, SeekOrigin.Begin);

        // MaterialIndices = new RelocArray<byte>(p_Reader);

        var s_MaterialFlagAndIndicesCount = p_Reader.ReadUInt32();
        var s_MateiralFlagAndIndciesOffset = p_Reader.ReadInt64();
        s_Position = p_Reader.Position;
        p_Reader.Seek(s_MateiralFlagAndIndciesOffset, SeekOrigin.Begin);
        for (var i = 0; i < s_MaterialFlagAndIndicesCount; ++i)
            MaterialFlagsAndIndices.Add(p_Reader.ReadUInt32());

        p_Reader.Seek(s_Position, SeekOrigin.Begin);

        // MaterialFlagsAndIndices = new RelocArray<uint>(p_Reader);

        Scale = p_Reader.ReadSingle();
        MaterialCountUsed = p_Reader.ReadUByte();
        HighestMaterialIndex = p_Reader.ReadUByte();
        Padding = p_Reader.ReadUInt16();

        p_Reader.Seek(
            s_StartPos + p_ResourceHeaderSize + p_HavokDataSize32 + p_HavokDataSize64,
            SeekOrigin.Begin
        );

        var s_FixupTable = p_Reader.ReadBytes(p_FixupTableSize);
        using var s_FixupTableReader = new RimeReader(new MemoryStream(s_FixupTable));
        
        p_Reader.Seek(s_StartPos + p_ResourceHeaderSize, SeekOrigin.Begin);
        using var s_Havok32Reader = new LimitedRimeReader(p_Reader, p_HavokDataSize32, false);

        HkPackfile = new HkPackfileHeader(s_Havok32Reader, s_FixupTableReader);
    }*/
    public bool Serialize(RimeWriter p_Writer)
    {
        throw new NotImplementedException();
    }

    public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
    {
        throw new NotImplementedException();
    }

    public void Deserialize(RimeReader p_Reader)
    {
        
    }

    public void Deserialize(byte[] p_Data)
    {
        using var s_Reader = new RimeReader(new MemoryStream(p_Data));
        
        Deserialize(s_Reader);
    }
}