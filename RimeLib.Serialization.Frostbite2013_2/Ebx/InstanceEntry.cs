using RimeLib.IO;
using System;
using System.Runtime.Serialization;

namespace RimeLib.Serialization.Frostbite2013_2.Ebx;

public class InstanceEntry
{
    public static int SizeOf => 8;

    public ushort TypeDescriptorIndex { get; set; }
    public ushort ExportCount { get; set; }

    public InstanceEntry(EndianBinaryReader p_Reader)
    {
        TypeDescriptorIndex = p_Reader.ReadUInt16();
        ExportCount = p_Reader.ReadUInt16();
    }

    public InstanceEntry()
    {
    }

    public void Serialize(RimeWriter p_Writer)
    {
        p_Writer.Write(TypeDescriptorIndex);
        p_Writer.Write(ExportCount);
    }

    public void GetObjectData(SerializationInfo p_Info, StreamingContext p_Context)
    {
        throw new NotImplementedException();
    }

    protected bool Equals(InstanceEntry p_Other)
    {
        return ExportCount == p_Other.ExportCount && TypeDescriptorIndex == p_Other.TypeDescriptorIndex;
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
        return HashCode.Combine(TypeDescriptorIndex, ExportCount);
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