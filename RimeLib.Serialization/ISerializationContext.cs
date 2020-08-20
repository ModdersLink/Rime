using RimeLib.Frostbite.Core;
using RimeLib.IO;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RimeLib.Serialization
{
    public interface ISerializationContext
    {
        RimeWriter BeginSerialization(SerializationFlags p_Flags, dynamic p_Object);

        void EndSerialization();

        BinaryReader BeginDeserialization(SerializationFlags p_Flags, dynamic p_Object);

        void EndDeserialization();

        dynamic ResolveReference<T>(CtrRef<T> p_Reference) where T : DataContainer;

        bool ValidateReference<T>(CtrRef<T> p_Reference) where T : DataContainer;

        RimeReader? GetChunkData(GUID p_Guid);

        RimeReader? GetResourceData(string p_Path);

        RimeReader? GetPartitionData(string p_Path);
    }
}
