using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace RimeLib.Serialization.Frostbite2_0.Ebx
{
    public class InstanceEntry
    {
        public static int SizeOf => 12;

        public uint InternalCount { get; set; }
        public uint ExportCount { get; set; }
        public uint TypeDescriptorIndex { get; set; }

        public InstanceEntry(EndianBinaryReader p_Reader)
        {
            InternalCount = p_Reader.ReadUInt32();
            ExportCount = p_Reader.ReadUInt32();
            TypeDescriptorIndex = p_Reader.ReadUInt32();
        }

        public InstanceEntry()
        {
        }

        public void Serialize(RimeWriter p_Writer)
        {
            p_Writer.Write(InternalCount);
            p_Writer.Write(ExportCount);
            p_Writer.Write(TypeDescriptorIndex);
        }

        public void GetObjectData(SerializationInfo p_Info, StreamingContext p_Context)
        {
            throw new NotImplementedException();
        }

        protected bool Equals(InstanceEntry other)
        {
            return InternalCount == other.InternalCount && ExportCount == other.ExportCount && TypeDescriptorIndex == other.TypeDescriptorIndex;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((InstanceEntry)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (int)InternalCount;
                hashCode = (hashCode * 397) ^ (int)ExportCount;
                hashCode = (hashCode * 397) ^ (int)TypeDescriptorIndex;
                return hashCode;
            }
        }

        public static bool operator ==(InstanceEntry left, InstanceEntry right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InstanceEntry left, InstanceEntry right)
        {
            return !Equals(left, right);
        }
    }
}
