using RimeLib.Frostbite;
using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace RimeLib.Serialization.Frostbite2_0.Ebx
{
    public class StreamingPartitionInstanceEntry : IFbSerializable
    {
        public uint InternalCount { get; set; }
        public uint ExportCount { get; set; }
        public uint TypeDescriptorIndex { get; set; }

        public StreamingPartitionInstanceEntry()
        {

        }

        public StreamingPartitionInstanceEntry(RimeReader p_Reader)
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
            InternalCount = p_Reader.ReadUInt32();
            ExportCount = p_Reader.ReadUInt32();
            TypeDescriptorIndex = p_Reader.ReadUInt32();
        }

        public void Deserialize(byte[] p_Data)
        {
            throw new System.NotImplementedException();
        }

        bool IFbSerializable.Serialize(RimeWriter p_Writer)
        {
            throw new NotImplementedException();
        }

        public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
        {
            p_Data = null;
            throw new NotImplementedException();
        }
    }
}
