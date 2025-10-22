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
    
        // Ignore this shit in serialization
        public hkPackfileHeader HkPackfile { get; set; }

        public LoadedData()
        {
            PartCount = 0;
            PartTranslations = new List<Vec3>();
            LocalAabbs = new List<AxisAlignedBox>();
            MaterialIndices = new List<byte>();
            MaterialFlagsAndIndices = new List<uint>();
            Scale = 1.0f;
            MaterialCountUsed = 0;
            HighestMaterialIndex = 0;
            Padding = 0;
        }

        public LoadedData(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }
        
        public bool Serialize(RimeWriter p_Writer)
        {
            throw new NotImplementedException();
        }

        public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
        {
            throw new NotImplementedException();
        }

        static long RoundUp(long p_Position, long p_Alignment)
        {
            return (p_Position + (p_Alignment - 1)) & ~(p_Alignment - 1);
        }

        public void Deserialize(RimeReader p_Reader)
        {
            p_Reader.Align(1);
            PartCount = p_Reader.ReadUInt32();
            
            var s_PartTranslationsCount = p_Reader.ReadInt32();
            var s_PartTranslationsOffset = p_Reader.ReadInt64();
            
            var s_LocalAabbsCount = p_Reader.ReadInt32();
            var s_LocalAabbsOffset = p_Reader.ReadInt64();
            
            var s_MaterialIndicesCount = p_Reader.ReadInt32();
            var s_MaterialIndiciesOffset = p_Reader.ReadInt64();
            
            var s_MaterialFlagsAndIndicesCount = p_Reader.ReadInt32();
            var s_MaterialFlagsAndIndicesOffset = p_Reader.ReadInt64();

            var s_PartTranslationsSize = RoundUp((s_PartTranslationsCount * /*sizeof(Vec3)*/ 16), 16);
            var s_LocalAabsSize = RoundUp((s_LocalAabbsCount * /*sizeof(AxisAlignedBox)*/ 32), 16);
            var s_MaterialIndicesSize = RoundUp((s_MaterialIndicesCount * /*sizeof(unsigned char)*/ 1), 16);
            var s_MaterialFlagsAndIndicesSize = RoundUp((s_MaterialFlagsAndIndicesCount * /*sizeof(uint32_t)*/ 4), 16);
            
            var s_HavokOffset = RoundUp(s_PartTranslationsSize + s_LocalAabsSize + s_MaterialIndicesSize + s_MaterialFlagsAndIndicesSize + 60, 16);
            
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
            
            // This should be the aligned size
            p_Reader.Seek(s_HavokOffset, SeekOrigin.Begin);
            
            // Everything after this point is probably cooked, will need to go through it with a debugger
            // or leave it to Bree_Arnold to fix huehuehuehuehue
            
            // So the data that we need is 0x57E0E057
            Console.WriteLine($"hkxHeader: {p_Reader.Position}");
            HkPackfile = new hkPackfileHeader();
            HkPackfile.Deserialize(p_Reader);
            
            // Alright we are converting this shit from a 010 template made by the god Pow-backkkkkenssss
            var s_Sections = new List<hkPackfileSectionHeader>();

            long s_ClassDataStart = 0;
            long s_ClassFixupOffset = 0;
            long s_DataDataStart = 0;
            long s_DataFixupOffset = 0;
            long s_DataExportsOffset = 0;

            for (var s_CurrentSelection = 0; s_CurrentSelection < HkPackfile.NumSections; ++s_CurrentSelection)
            {
                var s_Section = new  hkPackfileSectionHeader();
                s_Section.Deserialize(p_Reader);

                if (s_Section.SectionTag == "__classnames__")
                {
                    s_ClassDataStart = s_Section.AbsoluteDataStart;
                    s_ClassFixupOffset = s_Section.GlobalFixupsOffset;
                }
                else if (s_Section.SectionTag == "__types__")
                {
                    // Nothing to do here...
                }
                else if (s_Section.SectionTag == "__data__")
                {
                    s_DataDataStart = s_Section.AbsoluteDataStart;
                    s_DataFixupOffset = s_Section.VirtualFixupsOffset;
                    s_DataExportsOffset = s_Section.ExportsOffset;
                }
            }
            
            // Go to the start of the Havok descriptor start
            p_Reader.Seek(s_HavokOffset + s_ClassDataStart,  SeekOrigin.Begin);

            var s_Descriptors = new List<hkDescriptor>();

            for (;;)
            {
                // Nani the fuck
                var s_Key = p_Reader.Position - s_HavokOffset - s_ClassDataStart + 5;
                
                var s_Descriptor = new hkDescriptor();
                s_Descriptor.Key = s_Key;
                s_Descriptor.Deserialize(p_Reader);
                
                s_Descriptors.Add(s_Descriptor);

                if (s_Descriptor.EndByte != 0xFF)
                    continue;

                break;
            }
            
            p_Reader.Seek(s_HavokOffset + s_DataDataStart,  SeekOrigin.Begin);
            
            Console.WriteLine($"Root Start: {p_Reader.Position}");
            var s_HavokRoot = new hkxRoot(p_Reader);
            var s_HavokBlock = new hkxBlock(p_Reader);

            var s_DescriptorInfoOffsetStart = s_HavokOffset + s_DataDataStart + s_DataFixupOffset;
            Console.WriteLine($"DescriptorInfoStart: {s_DescriptorInfoOffsetStart}");
            
            p_Reader.Seek(s_DescriptorInfoOffsetStart,  SeekOrigin.Begin);

            var s_DescriptorInfoOffsetEnd = s_HavokOffset + s_DataDataStart + s_DataExportsOffset;
            Console.WriteLine($"num8: {s_DescriptorInfoOffsetEnd}");

            var s_DescriptorInfos = new List<hkDescriptorInfo>();

            long s_Offset = 0;

            var s_Vecs = new List<Vec4>();
            
            var s_DescriptorInfoCount = (s_DescriptorInfoOffsetEnd - s_DescriptorInfoOffsetStart) / hkDescriptorInfo.c_SizeOfDescriptorInfo;
            for (var s_DescriptorInfoIndex = 0; s_DescriptorInfoIndex < s_DescriptorInfoCount; s_DescriptorInfoIndex++)
            {
                Console.WriteLine($"DescriptorInfo Offset: {p_Reader.Position}");
                var s_DescriptorInfo = new hkDescriptorInfo(p_Reader);
                // bro wth is this
                s_DescriptorInfo.FinalOffset = s_HavokOffset + s_DataDataStart + s_DescriptorInfo.Offset;
                
                s_DescriptorInfos.Add(s_DescriptorInfo);
            }

            var s_ExtendedMeshShapes = new List<hkpExtendedMeshShape>();

            foreach (var s_DescriptorInfo in s_DescriptorInfos)
            {
                // This code no workey
                var s_Descriptor =
                    s_Descriptors.FirstOrDefault(p_Descriptor => p_Descriptor.Key == s_DescriptorInfo.Key);
                
                if (s_Descriptor is null)
                    continue;

                switch (s_Descriptor.Name)
                {
                    case "hkpExtendedMeshShape":
                        p_Reader.Seek(s_DescriptorInfo.Offset, SeekOrigin.Begin);
                        s_ExtendedMeshShapes.Add(new hkpExtendedMeshShape(p_Reader));
                        break;
                    default:
                        Console.WriteLine($"Unknown Descriptor {s_Descriptor.Name}.");
                        break;
                }
                
                if (s_DescriptorInfo.Key == -1)
                    continue;
                
                var s_DescriptorDataOffset = s_HavokOffset + s_DataDataStart + s_DescriptorInfo.Offset;
                
                p_Reader.Seek(s_DescriptorDataOffset, SeekOrigin.Begin);

                if (s_DescriptorInfo.Key == 169) // wth is 169
                {
                    var s_ExtendedMeshHeader = new hkExtendedMeshHeader(p_Reader);

                    for (var s_EntryIndex = 0; s_EntryIndex < s_ExtendedMeshHeader.IndexCount; s_EntryIndex++)
                    {
                        var s_ExtendedMeshEntry = new  hkExtendedMeshEntry(p_Reader);
                    }
                }
                else
                {
                    // What do we even do with this information????
                    var s_Vec4 = new Vec4
                    {
                        x = p_Reader.ReadSingle(),
                        y = p_Reader.ReadSingle(),
                        z = p_Reader.ReadSingle(),
                        w = p_Reader.ReadSingle()
                    };

                    s_Vecs.Add(s_Vec4);
                }
            }
            
            while (p_Reader.Position < s_DescriptorInfoOffsetEnd)
            {
                var s_DescriptorInfo = new hkDescriptorInfo(p_Reader);
                // bro wth is this
                s_DescriptorInfo.FinalOffset = s_HavokOffset + s_DataDataStart + s_DescriptorInfo.Offset;

                if (s_DescriptorInfo.Key != -1 && p_Reader.Position < s_DescriptorInfoOffsetEnd)
                {
                    s_Offset = p_Reader.Position;
                    
                    p_Reader.Seek(s_HavokOffset + s_DataDataStart + s_DescriptorInfo.Offset,  SeekOrigin.Begin);

                    if (s_DescriptorInfo.Key == 169) // wth is 169
                    {
                        var s_ExtendedMeshHeader = new hkExtendedMeshHeader(p_Reader);

                        for (var s_EntryIndex = 0; s_EntryIndex < s_ExtendedMeshHeader.IndexCount; s_EntryIndex++)
                        {
                            var s_ExtendedMeshEntry = new  hkExtendedMeshEntry(p_Reader);

                            Console.WriteLine(
                                $"Transform: {s_ExtendedMeshEntry.Transform.X}, {s_ExtendedMeshEntry.Transform.Y}, {s_ExtendedMeshEntry.Transform.Z}");
                            
                        }
                    }
                    else
                    {
                        var s_Root = new hkxRoot(p_Reader);
                        
                        // What do we even do with this information????
                        /*var s_Vec4 = new Vec4
                        {
                            x = p_Reader.ReadSingle(),
                            y = p_Reader.ReadSingle(),
                            z = p_Reader.ReadSingle(),
                            w = p_Reader.ReadSingle()
                        };

                        s_Vecs.Add(s_Vec4);*/
                    }
                    
                    p_Reader.Seek(s_Offset, SeekOrigin.Begin);
                }
            }
        }

        public void Deserialize(byte[] p_Data)
        {
            using var s_Reader = new RimeReader(new MemoryStream(p_Data));
            
            Deserialize(s_Reader);
        }
    }

    public LoadedData LoadedDatas { get; set; }

    public HavokPhysicsData(RimeReader p_Reader)
    {
        LoadedDatas = new LoadedData(p_Reader);
    }

    public HavokPhysicsData()
    {
        LoadedDatas = new LoadedData();
    }
    
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