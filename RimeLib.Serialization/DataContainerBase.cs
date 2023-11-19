using RimeLib.Frostbite.Core;
using Newtonsoft.Json;

namespace RimeLib.Serialization;

public class DataContainerBase : EbxSerializable
{
    [JsonIgnore]
    public DataContainerId InstanceId { get; set; } = new DataContainerId.Guid(GUID.Empty);
    [JsonIgnore]
    public DatabasePartitionBase? Partition { get; set; } = null;
}