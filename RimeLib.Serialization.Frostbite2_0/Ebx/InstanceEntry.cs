using RimeLib.IO;
using System;
using System.Runtime.Serialization;

namespace RimeLib.Serialization.Frostbite2_0.Ebx;

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

    protected bool Equals(InstanceEntry p_Other)
    {
        return InternalCount == p_Other.InternalCount && ExportCount == p_Other.ExportCount && TypeDescriptorIndex == p_Other.TypeDescriptorIndex;
    }

    public override bool Equals(object? p_Obj)
    {
        if (ReferenceEquals(null, p_Obj)) return false;
        if (ReferenceEquals(this, p_Obj)) return true;
        if (p_Obj.GetType() != this.GetType()) return false;
        return Equals((InstanceEntry)p_Obj);
    }

    public override int GetHashCode()
    {
        unchecked
        {
            var s_HashCode = (int)InternalCount;
            s_HashCode = (s_HashCode * 397) ^ (int)ExportCount;
            s_HashCode = (s_HashCode * 397) ^ (int)TypeDescriptorIndex;
            return s_HashCode;
        }
    }

    public static bool operator ==(InstanceEntry p_Left, InstanceEntry p_Right)
    {
        return Equals(p_Left, p_Right);
    }

    public static bool operator !=(InstanceEntry left, InstanceEntry right)
    {
        return !Equals(left, right);
    }
}