using System.IO;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.IO;

namespace RimeLib.Mesh.Frostbite.Fb2
{
    /// <summary>
    /// Implementation for fb::MeshSetLayout
    /// </summary>
    public class MeshSetLayout : IFbSerializable
    {
        /// <summary>
        /// Mesh type
        /// </summary>
        public MeshType MeshType { get; set; }

        /// <summary>
        /// Flags
        /// </summary>
        public MeshLayout.MeshLayoutFlags Flags { get; set; }

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
        public AxisAlignedBox BoundingBox { get; set; }

        /// <summary>
        /// Level of details
        /// </summary>
        public RelocPtr<MeshLayout>[] Lods { get; set; } // RelocPtr[5]

        /// <summary>
        /// Mesh name
        /// </summary>
        public RelocPtr<string> Name { get; set; } // RelocPtr

        /// <summary>
        /// Mesh short name
        /// </summary>
        public RelocPtr<string> ShortName { get; set; } // RelocPtr

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
        public void Serialize(RimeWriter p_Writer)
        {
            p_Writer.Write((uint)MeshType);
            p_Writer.Write((uint)Flags);
            p_Writer.Write(LodCount);
            p_Writer.Write(TotalSubsetCount);
            BoundingBox.Serialize(p_Writer);
            // This should be 5 iterations
            foreach (var l_Lod in Lods)
                p_Writer.Write(l_Lod.BaseAddress);

            p_Writer.Write(Name.BaseAddress);
            p_Writer.Write(ShortName.BaseAddress);
            p_Writer.Write(NameHash);
            p_Writer.Write(Padding);
        }

        public byte[] Serialize()
        {
            throw new System.NotImplementedException();
        }

        public void Deserialize(RimeReader p_Reader)
        {
            MeshType = (MeshType)p_Reader.ReadUInt32();
            Flags = (MeshLayout.MeshLayoutFlags)p_Reader.ReadUInt32();
            LodCount = p_Reader.ReadUInt32();
            TotalSubsetCount = p_Reader.ReadUInt32();
            BoundingBox = new AxisAlignedBox(p_Reader);

            Lods = new RelocPtr<MeshLayout>[5];
            for (var i = 0; i < 5; ++i)
                Lods[i] = new RelocPtr<MeshLayout>(p_Reader);

            Name = new RelocPtr<string>(p_Reader);
            ShortName = new RelocPtr<string>(p_Reader);
            NameHash = p_Reader.ReadUInt32();
            Padding = p_Reader.ReadUInt32();
        }

        public void Deserialize(byte[] p_Data)
        {
            Deserialize(new RimeReader(new MemoryStream(p_Data)));
        }
    }
}
