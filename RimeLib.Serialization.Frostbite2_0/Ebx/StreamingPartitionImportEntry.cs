using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using System;
using System.Diagnostics.CodeAnalysis;

namespace RimeLib.Serialization.Frostbite2_0.Ebx
{
    public class StreamingPartitionImportEntry : IFbSerializable
    {
        private GUID PartitionGuid { get; set; }
        private GUID InstanceGuid { get; set; }

        public StreamingPartitionImportEntry()
        {

        }

        public StreamingPartitionImportEntry(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
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

        public void Deserialize(RimeReader p_Reader)
        {
            PartitionGuid = new GUID(p_Reader);
            InstanceGuid = new GUID(p_Reader);
        }

        public void Deserialize(byte[] p_Data)
        {
            throw new NotImplementedException();
        }
    }
}
