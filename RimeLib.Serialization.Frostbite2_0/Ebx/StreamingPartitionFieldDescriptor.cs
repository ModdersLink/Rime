using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace RimeLib.Serialization.Frostbite2_0.Ebx
{
    public class StreamingPartitionFieldDescriptor : IFbSerializable
    {
        public int FieldNameHash { get; set; } //fnv
        public MemberInfoFlags Flags { get; set; }
        public ushort FieldType { get; set; }
        public uint FieldOffset { get; set; }
        public uint SecondaryOffset { get; set; }

        public StreamingPartitionFieldDescriptor()
        {

        }

        public StreamingPartitionFieldDescriptor(RimeReader p_Reader)
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
            FieldNameHash = p_Reader.ReadInt32();
            Flags = new MemberInfoFlags(p_Reader);
            FieldType = p_Reader.ReadUInt16();
            FieldOffset = p_Reader.ReadUInt32();
            SecondaryOffset = p_Reader.ReadUInt32();
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
