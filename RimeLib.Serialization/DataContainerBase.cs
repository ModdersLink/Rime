using RimeLib.Frostbite.Core;

namespace RimeLib.Serialization;

public class DataContainerBase : EbxSerializable
{
    public DataContainerId InstanceId { get; set; } = new DataContainerId.Guid(GUID.Empty);
    public DatabasePartitionBase? Partition { get; set; } = null;
}