using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite.Core;

namespace RimeLib.Serialization;

public abstract class DatabasePartitionBase
{
    public string Name { get; set; } = string.Empty;

    public GUID PartitionGuid { get; set; } = GUID.Empty;

    [JsonIgnore]
    public abstract IEnumerable<DataContainerBase> Instances { get; }
    
    [JsonIgnore]
    public abstract DataContainerBase PrimaryInstance { get; }

    public IObjectVariant? AssociatedVariant { get; set; } = null;

    public abstract string ToJsonString(Formatting p_Formatting = Formatting.None);
    public abstract void ToJsonStream(TextWriter p_Writer, Formatting p_Formatting = Formatting.None);

    public void ToJsonFile(string p_FilePath, Formatting p_Formatting = Formatting.None)
    {
        using var s_Writer = new StreamWriter(p_FilePath);
        ToJsonStream(s_Writer, p_Formatting);
    }
}
