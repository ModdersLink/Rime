using System;
using RimeLib.Frostbite.Core;

namespace RimeLib.Serialization;

public class CtrRef<T> : CtrRefBase where T : DataContainerBase
{
    public CtrRef()
    {
    }

    public CtrRef(GUID p_PartitionGuid, GUID p_InstanceGuid) : base(p_PartitionGuid,
        new DataContainerId.Guid(p_InstanceGuid))
    {
    }

    public CtrRef(GUID p_PartitionGuid, long p_InstanceIndex) : base(p_PartitionGuid,
        new DataContainerId.Index(p_InstanceIndex))
    {
    }
    
    public CtrRef(GUID p_PartitionGuid, DataContainerId p_InstanceId) : base(p_PartitionGuid, p_InstanceId)
    {
    }

    public new T? Get()
    {
        return base.Get() as T;
    }
    
    public T? Instance => Get() as T
}

public class CtrRefBase
{
    public GUID PartitionGuid { get; private set; }

    public DataContainerId InstanceId { get; private set; }

    public CtrRefBase()
    {
        PartitionGuid = GUID.Empty;
        InstanceId = new DataContainerId.Guid(GUID.Empty);
    }

    public CtrRefBase(GUID p_PartitionGuid, DataContainerId p_InstanceId)
    {
        PartitionGuid = p_PartitionGuid;
        InstanceId = p_InstanceId;
    }

    public void SetValue(GUID p_PartitionGuid, DataContainerId p_InstanceId)
    {
        PartitionGuid = p_PartitionGuid;
        InstanceId = p_InstanceId;
    }

    public void SetValue(CtrRefBase p_Other)
    {
        PartitionGuid = p_Other.PartitionGuid;
        InstanceId = p_Other.InstanceId;
    }

    public bool IsNull()
    {
        return PartitionGuid == GUID.Empty;
    }

    public DataContainerBase? Get()
    {
        if (!PartitionRegistry.TryGetInstance(PartitionGuid, InstanceId, out var s_Instance))
            return null;

        return s_Instance;
    }

    protected bool Equals(CtrRefBase p_Other)
    {
        return PartitionGuid.Equals(p_Other.PartitionGuid) && InstanceId.Equals(p_Other.InstanceId);
    }

    public override bool Equals(object? p_Obj)
    {
        if (ReferenceEquals(null, p_Obj)) return false;
        if (ReferenceEquals(this, p_Obj)) return true;
        if (p_Obj.GetType() != GetType()) return false;
        return Equals((CtrRefBase)p_Obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(PartitionGuid, InstanceId);
    }

    public static bool operator ==(CtrRefBase? p_Left, CtrRefBase? p_Right)
    {
        return Equals(p_Left, p_Right);
    }

    public static bool operator !=(CtrRefBase? p_Left, CtrRefBase? p_Right)
    {
        return !Equals(p_Left, p_Right);
    }


    public override string ToString()
    {
        return $"({PartitionGuid}, {InstanceId})";
    }
}