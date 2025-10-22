using System;
using System.Runtime.Serialization;
using RimeLib.Frostbite.Core;
using RimeLib.IO;

namespace RimeLib.Serialization.Frostbite2013_2.Ebx;

public class ImportEntry
{
    public static int SizeOf => GUID.SizeOf * 2;

    public GUID PartitionGuid { get; set; }
    public GUID InstanceGuid { get; set; }

    public ImportEntry(RimeReader p_Reader)
    {
        PartitionGuid = new GUID(p_Reader);
        InstanceGuid = new GUID(p_Reader);
    }

    public ImportEntry()
    {
        PartitionGuid = GUID.Empty;
        InstanceGuid = GUID.Empty;
    }

    public void Serialize(RimeWriter p_Writer)
    {
        p_Writer.Write(PartitionGuid.Id);
        p_Writer.Write(InstanceGuid.Id);
    }

    public void GetObjectData(SerializationInfo p_Info, StreamingContext p_Context)
    {
        throw new NotImplementedException();
    }

    protected bool Equals(ImportEntry other)
    {
        return Equals(PartitionGuid, other.PartitionGuid) && Equals(InstanceGuid, other.InstanceGuid);
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((ImportEntry)obj);
    }

    public override int GetHashCode()
    {
        unchecked
        {
            return ((PartitionGuid != GUID.Empty ? PartitionGuid.GetHashCode() : 0) * 397) ^ (InstanceGuid != GUID.Empty ? InstanceGuid.GetHashCode() : 0);
        }
    }

    public static bool operator ==(ImportEntry left, ImportEntry right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(ImportEntry left, ImportEntry right)
    {
        return !Equals(left, right);
    }
}