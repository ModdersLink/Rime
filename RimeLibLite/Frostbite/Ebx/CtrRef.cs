using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Containers;
using System;
using System.ComponentModel;

namespace RimeLib.Serialization.Ebx
{
    /// <inheritdoc />
    public class CtrRef<T> : CtrRefBase
        where T : DataContainer
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

        /// <summary>
        /// Gets the referenced instance
        /// </summary>
        /// <typeparam name="T">Type to cast the instance to</typeparam>
        /// <returns>Casted instance, or default value</returns>
        public T? Get()
        {
            return As<T>();
        }

        /// <summary>
        /// Gets the referenced instance
        /// </summary>
        /// <typeparam name="T0">Type to cast the instance to</typeparam>
        /// <returns>Casted instance, or default value</returns>
        public T0? As<T0>()
            where T0 : T
        {
            if (PartitionGuid == GUID.Empty || InstanceGuid == GUID.Empty)
                return default;

            var s_Partition = PartitionRegistry.LookupPartition(PartitionGuid);

            return (T0?)s_Partition?.LookupContainer(InstanceGuid);
        }

        /// <summary>
        /// Gets the DataContainer of specified reference
        /// </summary>
        /// <param name="p_CtrRef">Reference</param>
        public static implicit operator T(CtrRef<T> p_CtrRef)
        {
#pragma warning disable CS8603 // Possible null reference return.
            return p_CtrRef.Get();
#pragma warning restore CS8603 // Possible null reference return.
        }
    }

    /// <summary>
    /// Reference to a game data instance
    /// </summary>
    public abstract class CtrRefBase
    {
        /// <summary>
        /// This is used for late-resolution of internal class references.
        /// </summary>
        [Browsable(false)]
        public uint ImportIndex { get; set; }

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
        protected CtrRefBase()
        {
            ImportIndex = 0;
            PartitionGuid = Guid.Empty;
            InstanceGuid = Guid.Empty;
        }

        /// <summary>
        /// Constructor that creates a new CtrRef based on supplied partition and instance guid's
        /// </summary>
        /// <param name="p_PartitionGuid">Partition guid</param>
        /// <param name="p_InstanceGuid">Instance guid</param>
        protected CtrRefBase(GUID p_PartitionGuid, GUID p_InstanceGuid)
        {
            ImportIndex = 0;
            PartitionGuid = p_PartitionGuid == Guid.Empty ? Guid.Empty : p_PartitionGuid;
            InstanceGuid = p_InstanceGuid == Guid.Empty ? Guid.Empty : p_InstanceGuid;
        }

        /// <summary>
        /// Sets the value of this ref to the specified DataContainer
        /// </summary>
        /// <param name="p_Container">Container to set this reference to</param>
        public void SetValue(DataContainer p_Container)
        {
            if (p_Container.PartitionGuid == Guid.Empty || p_Container.InstanceGuid == Guid.Empty)
            {
                PartitionGuid = Guid.Empty;
                InstanceGuid = Guid.Empty;
                return;
            }

            PartitionGuid = p_Container.PartitionGuid == Guid.Empty ? Guid.Empty : p_Container.PartitionGuid;
            InstanceGuid = p_Container.InstanceGuid == Guid.Empty ? Guid.Empty : p_Container.InstanceGuid;
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

        /// <summary>
        /// String conversion
        /// </summary>
        /// <returns>String</returns>
        public override string ToString()
        {
            if (PartitionGuid == Guid.Empty || InstanceGuid == Guid.Empty)
                return "*null*";

            var s_Partition = PartitionRegistry.LookupPartition(PartitionGuid);

            if (s_Partition is null)
                return $"{PartitionGuid}/{InstanceGuid}";

            var s_Container = s_Partition?.LookupContainer(InstanceGuid);

            if (s_Container == null)
                return $"{s_Partition?.Name}/{InstanceGuid}";

#pragma warning disable IDE0059 // Unnecessary assignment of a value
            var s_Name = "";
#pragma warning restore IDE0059 // Unnecessary assignment of a value
            var s_NameProperty = s_Container.GetType().GetProperty("Name");

            if (s_NameProperty != null)
            {
                s_Name = s_NameProperty.GetValue(s_Container) as string;
                s_Name += $" ({s_Container.InstanceGuid})";
            }
            else
            {
                s_Name = $"{s_Partition?.Name}/{s_Container.InstanceGuid}";
            }

            return s_Name;
        }

        /// <summary>
        /// Gets the DataContainer this reference points to
        /// </summary>
        public DataContainer? GetDataContainer()
        {
            if (PartitionGuid == Guid.Empty || InstanceGuid == Guid.Empty)
                return null;

            var s_Partition = PartitionRegistry.LookupPartition(PartitionGuid);
            return s_Partition?.LookupContainer(InstanceGuid);
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
