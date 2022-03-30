using RimeLib.Frostbite;
using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace RimeLib.Serialization.Frostbite2_0.Ebx
{
    public class StreamingPartitionArrayEntry : IFbSerializable
    {
        public uint Offset { get; set; }
        public uint ElementCount { get; set; }
        public uint TypeDescriptorIndex { get; set; }

        public StreamingPartitionArrayEntry()
        {

        }

        public StreamingPartitionArrayEntry(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }

        public void Deserialize(RimeReader p_Reader)
        {
            Offset = p_Reader.ReadUInt32();
            ElementCount = p_Reader.ReadUInt32();
            TypeDescriptorIndex = p_Reader.ReadUInt32();
        }

        public void Deserialize(byte[] p_Data)
        {
            throw new System.NotImplementedException();
        }

        public bool Serialize(RimeWriter p_Writer)
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
