using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using System;

namespace RimeLib.Serialization.Frostbite2_0.Ebx
{
    public class StreamingPartitionTypeDescriptor : IFbSerializable
    {
        public int TypeNameHash { get; set; }
        public uint LayoutDescriptor { get; set; }
        public byte FieldCount { get; set; }
        public byte Alignment { get; set; }
        public MemberInfoFlags TypeFlags { get; set; }
        public ushort InstanceSize { get; set; }
        public ushort SecondaryInstanceSize { get; set; }

        public StreamingPartitionTypeDescriptor()
        {

        }

        public StreamingPartitionTypeDescriptor(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }

        public void Serialize(RimeWriter p_Writer)
        {
            throw new System.NotImplementedException();
        }

        public byte[] Serialize()
        {
            throw new System.NotImplementedException();
        }

        public void Deserialize(RimeReader p_Reader)
        {
            TypeNameHash = p_Reader.ReadInt32();
            LayoutDescriptor = p_Reader.ReadUInt32();
            FieldCount = p_Reader.ReadUByte();
            Alignment = p_Reader.ReadUByte();
            TypeFlags = new MemberInfoFlags(p_Reader);
            InstanceSize = p_Reader.ReadUInt16();
            SecondaryInstanceSize = p_Reader.ReadUInt16();
        }

        public void Deserialize(byte[] p_Data)
        {
            throw new System.NotImplementedException();
        }

        bool IFbSerializable.Serialize(RimeWriter p_Writer)
        {
            throw new NotImplementedException();
        }

        public bool Serialize(out byte[] p_Data)
        {
            throw new NotImplementedException();
        }
    }
}
