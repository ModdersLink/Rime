using RimeLib.IO;
using System;
using System.Runtime.Serialization;

namespace RimeLib.Serialization.Ebx
{
    public class ArrayEntry // arrayRepeater
    {
        public static int SizeOf => 12;

        public uint Offset { get; set; }
        public uint ElementCount { get; set; }
        public uint TypeDescriptorIndex { get; set; }

        public ArrayEntry(RimeReader p_Reader)
        {
            Offset = p_Reader.ReadUInt32();
            ElementCount = p_Reader.ReadUInt32();
            TypeDescriptorIndex = p_Reader.ReadUInt32();
        }

        public ArrayEntry()
        {
        }

        public void Serialize(RimeWriter p_Writer)
        {
            p_Writer.Write(Offset);
            p_Writer.Write(ElementCount);
            p_Writer.Write(TypeDescriptorIndex);
        }

        public void GetObjectData(SerializationInfo p_Info, StreamingContext p_Context)
        {
            throw new NotImplementedException();
        }

        protected bool Equals(ArrayEntry other)
        {
            return Offset == other.Offset && ElementCount == other.ElementCount && TypeDescriptorIndex == other.TypeDescriptorIndex;
        }

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((ArrayEntry)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (int)Offset;
                hashCode = (hashCode * 397) ^ (int)ElementCount;
                hashCode = (hashCode * 397) ^ (int)TypeDescriptorIndex;
                return hashCode;
            }
        }

        public static bool operator ==(ArrayEntry left, ArrayEntry right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ArrayEntry left, ArrayEntry right)
        {
            return !Equals(left, right);
        }
    }
}
