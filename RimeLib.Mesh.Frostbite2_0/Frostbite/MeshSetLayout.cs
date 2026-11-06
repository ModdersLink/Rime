using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using fb;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.IO;

namespace RimeLib.Mesh.Frostbite2_0.Frostbite
{
    /// <summary>A MeshSet resource's header (fb::MeshSetLayout): counts, bounding box, five LOD pointers and the names.</summary>
    public class MeshSetLayout : IFbSerializable
    {
        public const int Size = 0x70;
        public const int MaxLodCount = 5;

        public MeshType MeshType { get; set; }
        public MeshLayoutFlags Flags { get; set; }
        public uint LodCount { get; set; }
        public uint TotalSubsetCount { get; set; }
        public AxisAlignedBox BoundingBox { get; set; } = new();
        public RelocPtr<MeshLayout>[] Lods { get; set; } = new RelocPtr<MeshLayout>[MaxLodCount];
        public RelocPtr<string> Name { get; set; } = new();
        public RelocPtr<string> ShortName { get; set; } = new();
        public uint NameHash { get; set; }

        /// <summary>The word after the name hash, which pads the header to 16 bytes.</summary>
        public uint Padding { get; set; }

        public MeshSetLayout()
        {
        }

        public MeshSetLayout(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }

        public void Deserialize(RimeReader p_Reader)
        {
            MeshType = (MeshType)p_Reader.ReadUInt32();
            Flags = (MeshLayoutFlags)p_Reader.ReadUInt32();
            LodCount = p_Reader.ReadUInt32();
            TotalSubsetCount = p_Reader.ReadUInt32();

            var s_Min = new Vec3 { x = p_Reader.ReadSingle(), y = p_Reader.ReadSingle(), z = p_Reader.ReadSingle() };
            p_Reader.ReadSingle(); // padding
            var s_Max = new Vec3 { x = p_Reader.ReadSingle(), y = p_Reader.ReadSingle(), z = p_Reader.ReadSingle() };
            p_Reader.ReadSingle(); // padding
            BoundingBox = new AxisAlignedBox { min = s_Min, max = s_Max };

            Lods = new RelocPtr<MeshLayout>[MaxLodCount];
            for (var i = 0; i < MaxLodCount; ++i)
                Lods[i] = new RelocPtr<MeshLayout>(p_Reader);

            Name = new RelocPtr<string>(p_Reader);
            ShortName = new RelocPtr<string>(p_Reader);
            NameHash = p_Reader.ReadUInt32();
            Padding = p_Reader.ReadUInt32();
        }

        /// <summary>Writes the header; its pointers are the slots, whose targets the MeshSet places.</summary>
        public bool Serialize(RimeWriter p_Writer)
        {
            p_Writer.Write((uint)MeshType);
            p_Writer.Write((uint)Flags);
            p_Writer.Write(LodCount);
            p_Writer.Write(TotalSubsetCount);

            p_Writer.Write(BoundingBox.min.x);
            p_Writer.Write(BoundingBox.min.y);
            p_Writer.Write(BoundingBox.min.z);
            p_Writer.Write(0f);
            p_Writer.Write(BoundingBox.max.x);
            p_Writer.Write(BoundingBox.max.y);
            p_Writer.Write(BoundingBox.max.z);
            p_Writer.Write(0f);

            foreach (var s_Lod in Lods)
                s_Lod.Serialize(p_Writer);

            Name.Serialize(p_Writer);
            ShortName.Serialize(p_Writer);
            p_Writer.Write(NameHash);
            p_Writer.Write(Padding);
            return true;
        }

        public bool Serialize([NotNullWhen(true)] out byte[]? p_Data) =>
            throw new NotSupportedException("A MeshSet header is written as part of its MeshSet.");

        public void Deserialize(byte[] p_Data)
        {
            using var s_Reader = new RimeReader(new MemoryStream(p_Data, false));
            Deserialize(s_Reader);
        }
    }
}
