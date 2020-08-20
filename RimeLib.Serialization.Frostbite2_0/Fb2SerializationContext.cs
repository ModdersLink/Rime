using RimeLib.Frostbite.Core;
using RimeLib.IO;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace RimeLib.Serialization.Frostbite2_0
{
    public class Fb2SerializationContext : ISerializationContext
    {
        public class ContextRequest
        {
        }

        private ConcurrentDictionary<string, Task<dynamic>> m_Resources;

        public RimeWriter BeginSerialization(SerializationFlags p_Flags, dynamic p_Object)
        {
            throw new NotImplementedException();
        }

        public void EndSerialization()
        {
            throw new NotImplementedException();
        }

        public BinaryReader BeginDeserialization(SerializationFlags p_Flags, dynamic p_Object)
        {
            throw new NotImplementedException();
        }

        public void EndDeserialization()
        {
            throw new NotImplementedException();
        }

        public dynamic ResolveReference<T>(CtrRef<T> p_Reference) where T : DataContainer
        {
            throw new NotImplementedException();
        }

        public bool ValidateReference<T>(CtrRef<T> p_Reference) where T : DataContainer
        {
            throw new NotImplementedException();
        }

        public RimeReader GetChunkData(GUID p_Guid)
        {
            throw new NotImplementedException();
        }

        public RimeReader GetResourceData(string p_Path)
        {
            throw new NotImplementedException();
        }

        public RimeReader GetPartitionData(string p_Path)
        {
            throw new NotImplementedException();
        }

        
    }
}
