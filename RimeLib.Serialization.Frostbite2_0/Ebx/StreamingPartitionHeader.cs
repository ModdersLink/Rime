using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace RimeLib.Serialization.Frostbite2_0.Ebx
{
    public class StreamingPartitionHeader : IFbSerializable
    {
        public static int SizeOf => 80;

        public uint Magic { get; set; }
        public uint MetaSize { get; set; }
        public uint PayloadSize { get; set; }
        public uint ImportCount { get; set; }
        public uint TypeCount { get; set; }
        public uint TypeDescriptorCount { get; set; }
        public uint FieldDescriptorCount { get; set; }
        public uint TypeStringTableSize { get; set; }
        public uint StringTableSize { get; set; }
        public uint ArrayCount { get; set; }
        public uint ArrayOffset { get; set; }
        public GUID PartitionGuid { get; set; }
        public GUID PrimaryInstanceGuid { get; set; }

        public StreamingPartitionHeader()
        {

        }

        public StreamingPartitionHeader(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }

        public bool Serialize(RimeWriter p_Writer)
        {
            p_Writer.Write(Magic);
            p_Writer.Write(MetaSize);
            p_Writer.Write(PayloadSize);
            p_Writer.Write(ImportCount);
            p_Writer.Write(0u);
            p_Writer.Write(TypeCount);
            p_Writer.Write(TypeDescriptorCount);
            p_Writer.Write(FieldDescriptorCount);
            p_Writer.Write(TypeStringTableSize);
            p_Writer.Write(StringTableSize);
            p_Writer.Write(ArrayCount);
            p_Writer.Write(ArrayOffset);
            PartitionGuid.Serialize(p_Writer);
            PrimaryInstanceGuid.Serialize(p_Writer);

            return true;
        }

        public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
        {
            p_Data = null;
            throw new NotImplementedException();
        }

        public void Deserialize(RimeReader p_Reader)
        {
            Magic = p_Reader.ReadUInt32();
            MetaSize = p_Reader.ReadUInt32();
            PayloadSize = p_Reader.ReadUInt32();
            ImportCount = p_Reader.ReadUInt32(); //
            p_Reader.ReadUInt32();
            TypeCount = p_Reader.ReadUInt32();
            TypeDescriptorCount = p_Reader.ReadUInt32(); //
            FieldDescriptorCount = p_Reader.ReadUInt32(); //
            TypeStringTableSize = p_Reader.ReadUInt32();
            StringTableSize = p_Reader.ReadUInt32();
            ArrayCount = p_Reader.ReadUInt32(); //
            ArrayOffset = p_Reader.ReadUInt32();
            PartitionGuid = new GUID(p_Reader);
            PrimaryInstanceGuid = new GUID(p_Reader);
        }

        public void Deserialize(byte[] p_Data)
        {
            throw new NotImplementedException();
        }
    }
}
