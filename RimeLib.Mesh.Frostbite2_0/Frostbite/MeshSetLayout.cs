using System.Diagnostics.CodeAnalysis;
using System.IO;
using fb;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using RimeLib.Mesh.Frostbite;

namespace RimeLib.Mesh.Frostbite2_0.Frostbite
{
    /// <summary>
    /// Implementation for fb::MeshSetLayout
    /// </summary>
    public class MeshSetLayout : Mesh.Frostbite.MeshSetLayout
    {
        /// <summary>
        /// Mesh type
        /// </summary>
        public MeshType MeshType { get; set; }

        /// <summary>
        /// Flags
        /// </summary>
        public MeshLayoutFlags Flags { get; set; }

        /// <summary>
        /// Level of detail count
        /// </summary>
        public uint LodCount { get; set; }

        /// <summary>
        /// Subset count
        /// </summary>
        public uint TotalSubsetCount { get; set; }

        /// <summary>
        /// Bounding box
        /// </summary>
        public AxisAlignedBox BoundingBox { get; set; } = new AxisAlignedBox();

        /// <summary>
        /// Level of details
        /// </summary>
        public RelocPtr<MeshLayout>[] Lods { get; set; } = new RelocPtr<MeshLayout>[5]; // RelocPtr[5]

        /// <summary>
        /// Mesh name
        /// </summary>
        public RelocPtr<string> Name { get; set; } = new RelocPtr<string>(); // RelocPtr

        /// <summary>
        /// Mesh short name
        /// </summary>
        public RelocPtr<string> ShortName { get; set; } = new RelocPtr<string>(); // RelocPtr

        /// <summary>
        /// Name hash
        /// </summary>
        public uint NameHash { get; set; }

        /// <summary>
        /// Unknown
        /// </summary>
        public uint Padding { get; set; } // TODO: See if this is used?

        /// <summary>
        /// Default constructor
        /// </summary>
        public MeshSetLayout()
        {

        }

        /// <summary>
        /// Constructor that reads a mesh set layout from an opened reader
        /// </summary>
        /// <param name="p_Reader">Reader opened to the position of a MeshSetLayout class</param>
        public MeshSetLayout(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }

        /// <summary>
        /// Writes a MeshSetLayout to an opened writer
        /// </summary>
        /// <param name="p_Writer">Writer opened to the position of a MeshSetLayout</param>
        public override bool Serialize(RimeWriter p_Writer)
        {
            p_Writer.Write((uint)MeshType);
            p_Writer.Write((uint)Flags);
            p_Writer.Write(LodCount);
            p_Writer.Write(TotalSubsetCount);

            p_Writer.Write(BoundingBox.min.x);
            p_Writer.Write(BoundingBox.min.y);
            p_Writer.Write(BoundingBox.min.z);
            p_Writer.Write((float)0);

            p_Writer.Write(BoundingBox.max.x);
            p_Writer.Write(BoundingBox.max.y);
            p_Writer.Write(BoundingBox.max.z);
            p_Writer.Write((float)0);

            // This should be 5 iterations
            foreach (var s_Lod in Lods)
                p_Writer.Write(s_Lod.BaseAddress);

            p_Writer.Write(Name.BaseAddress);
            p_Writer.Write(ShortName.BaseAddress);
            p_Writer.Write(NameHash);
            p_Writer.Write(Padding);

            return true;
        }

        public override bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
        {
            p_Data = null;
            throw new System.NotImplementedException();
        }

        public override void Deserialize(RimeReader p_Reader)
        {
            MeshType = (MeshType)p_Reader.ReadUInt32();
            Flags = (MeshLayoutFlags)p_Reader.ReadUInt32();
            LodCount = p_Reader.ReadUInt32();
            TotalSubsetCount = p_Reader.ReadUInt32();

            var s_MinVec = new Vec3
            {
                x = p_Reader.ReadSingle(),
                y = p_Reader.ReadSingle(),
                z = p_Reader.ReadSingle()
            };
            p_Reader.ReadSingle(); // Padding

            var s_MaxVec = new Vec3
            {
                x = p_Reader.ReadSingle(),
                y = p_Reader.ReadSingle(),
                z = p_Reader.ReadSingle()
            };
            p_Reader.ReadSingle(); // Padding

            BoundingBox = new AxisAlignedBox
            {
                min = s_MinVec,
                max = s_MaxVec
            };

            Lods = new RelocPtr<MeshLayout>[5];
            for (var i = 0; i < 5; ++i)
                Lods[i] = new RelocPtr<MeshLayout>(p_Reader);

            Name = new RelocPtr<string>(p_Reader);
            ShortName = new RelocPtr<string>(p_Reader);
            NameHash = p_Reader.ReadUInt32();
            Padding = p_Reader.ReadUInt32();
        }

        public override void Deserialize(byte[] p_Data)
        {
            Deserialize(new RimeReader(new MemoryStream(p_Data)));
        }
    }
}
