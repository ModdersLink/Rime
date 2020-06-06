using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using System.ComponentModel;

namespace RimeLib.Serialization.Containers
{
    /// <summary>
    /// Implementation for fb::DataContainer
    /// </summary>
    [ContainerType(4)]
    public class DataContainer : FrostbiteContainer
    {
        /// <summary>
        /// Instance identifier
        /// </summary>
		[Browsable(false)]
        public GUID InstanceGuid { get; set; } = GUID.Empty;

        /// <summary>
        /// Partition identifier
        /// </summary>
		[Browsable(false)]
        public GUID PartitionGuid { get; set; } = GUID.Empty;

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns>Type name and instance id</returns>
        public override string ToString()
        {
            return $"{GetType().Name} ({InstanceGuid})";
        }
    }

}
