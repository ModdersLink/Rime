using RimeLib.Frostbite.Core;
using System;

namespace RimeLib.Serialization.Ebx
{
    /// <inheritdoc />
    public class CtrRef<T> : CtrRefBase
        where T : class
    {
        /// <inheritdoc />
        public CtrRef() : base()
        {
        }

        /// <inheritdoc />
        public CtrRef(GUID p_PartitionGuid, GUID p_InstanceGuid)
            : base(p_PartitionGuid, p_InstanceGuid)
        {
        }

        // TODO
    }

    /// <summary>
    /// Reference to a game data instance
    /// </summary>
    public class CtrRefBase
    {
        /// <summary>
        /// The partition guid that the instance is found in
        /// </summary>
        public GUID PartitionGuid { get; protected set; }

        /// <summary>
        /// The instance guid
        /// </summary>
        public GUID InstanceGuid { get; protected set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public CtrRefBase()
        {
            PartitionGuid = Guid.Empty;
            InstanceGuid = Guid.Empty;
        }

        /// <summary>
        /// Constructor that creates a new CtrRef based on supplied partition and instance guid's
        /// </summary>
        /// <param name="p_PartitionGuid">Partition guid</param>
        /// <param name="p_InstanceGuid">Instance guid</param>
        public CtrRefBase(GUID p_PartitionGuid, GUID p_InstanceGuid)
        {
            PartitionGuid = p_PartitionGuid == Guid.Empty ? Guid.Empty : p_PartitionGuid;
            InstanceGuid = p_InstanceGuid == Guid.Empty ? Guid.Empty : p_InstanceGuid;
        }

        /// <summary>
        /// Sets the value of this ref to the specified partition and instance
        /// </summary>
        /// <param name="p_PartitionGuid">Partition ID</param>
        /// <param name="p_InstanceGuid">Instance ID</param>

        public void SetValue(GUID p_PartitionGuid, GUID p_InstanceGuid)
        {
            PartitionGuid = p_PartitionGuid == Guid.Empty ? Guid.Empty : p_PartitionGuid;
            InstanceGuid = p_InstanceGuid == Guid.Empty ? Guid.Empty : p_InstanceGuid;
        }

        public void SetValue(CtrRefBase p_Other)
        {
            PartitionGuid = p_Other.PartitionGuid;
            InstanceGuid = p_Other.InstanceGuid;
        }

        /// <summary>
        /// Equals operator
        /// </summary>
        /// <param name="other">Other reference</param>
        /// <returns>True if they are the same reference, false otherwise</returns>
        protected bool Equals(CtrRefBase other)
        {
            return Equals(PartitionGuid, other.PartitionGuid) && Equals(InstanceGuid, other.InstanceGuid);
        }

        /// <summary>
        /// Equals operator
        /// </summary>
        /// <param name="obj">Other reference</param>
        /// <returns>True if equal, false otherwise</returns>
        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((CtrRefBase)obj);
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked
            {
                return ((PartitionGuid != GUID.Empty ? PartitionGuid.GetHashCode() : 0) * 397) ^ (InstanceGuid != GUID.Empty ? InstanceGuid.GetHashCode() : 0);
            }
        }

        /// <summary>
        /// Equals operator
        /// </summary>
        /// <param name="left">First reference</param>
        /// <param name="right">Second reference</param>
        /// <returns>True if same reference, false otherwise</returns>
        public static bool operator ==(CtrRefBase left, CtrRefBase right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Not equals operator
        /// </summary>
        /// <param name="left">First reference</param>
        /// <param name="right">Second reference</param>
        /// <returns>True if not equal, false otherwise</returns>
        public static bool operator !=(CtrRefBase left, CtrRefBase right)
        {
            return !Equals(left, right);
        }

        public bool IsNull()
        {
            return InstanceGuid == GUID.Empty && PartitionGuid == GUID.Empty;
        }
    }
}
