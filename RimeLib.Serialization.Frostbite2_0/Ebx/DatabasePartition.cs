using System;
using System.Collections.Generic;
using System.IO;
using fb;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Frostbite2_0.Json;

namespace RimeLib.Serialization.Frostbite2_0.Ebx;

public class DatabasePartition : DatabasePartitionBase
{
    public GUID PrimaryInstanceGuid { get; set; } = GUID.Empty;

    [JsonProperty("Instances")]
    public SortedDictionary<GUID, DataContainer> InstanceMap { get; set; } = new();

    [JsonIgnore]
    public override IEnumerable<DataContainerBase> Instances => InstanceMap.Values;

    [JsonIgnore]
    public override DataContainerBase PrimaryInstance => InstanceMap[PrimaryInstanceGuid];
        
    [JsonIgnore]
    public DataContainer PrimaryInstanceCtr => InstanceMap[PrimaryInstanceGuid];

    public override string ToJsonString(Formatting p_Formatting = Formatting.None)
    {
        return JsonConvert.SerializeObject(this, p_Formatting, new CtrRefJsonConverter(), new StringEnumConverter());
    }

    public override void ToJsonStream(TextWriter p_Writer, Formatting p_Formatting = Formatting.None)
    {
        var s_Serializer = new JsonSerializer();
        s_Serializer.Converters.Add(new CtrRefJsonConverter());
        s_Serializer.Converters.Add(new StringEnumConverter());
        s_Serializer.NullValueHandling = NullValueHandling.Include;
        s_Serializer.MissingMemberHandling = MissingMemberHandling.Error;
        s_Serializer.TypeNameHandling = TypeNameHandling.None;
        s_Serializer.Formatting = p_Formatting;

        s_Serializer.Serialize(p_Writer, this);
    }

    public static DatabasePartition FromJsonString(string p_Json)
    {
        using var s_Reader = new StringReader(p_Json);
        return FromJsonStream(s_Reader);
    }

    public static DatabasePartition FromJsonFile(string p_FilePath)
    {
        using var s_Reader = File.OpenText(p_FilePath);
        return FromJsonStream(s_Reader);
    }

    public static DatabasePartition FromJsonStream(TextReader p_Reader)
    {
        var s_Serializer = new JsonSerializer();
        s_Serializer.Converters.Add(new DataContainerJsonConverter());
        s_Serializer.Converters.Add(new StringEnumConverter());
        s_Serializer.Converters.Add(new CtrRefJsonConverter());
        s_Serializer.NullValueHandling = NullValueHandling.Include;
        s_Serializer.MissingMemberHandling = MissingMemberHandling.Error;
        s_Serializer.TypeNameHandling = TypeNameHandling.None;
        
        var s_Partition = s_Serializer.Deserialize(p_Reader, typeof(DatabasePartition));
        
        if (s_Partition == null)
            throw new Exception("Failed to deserialize partition.");
        
        return (DatabasePartition) s_Partition;
    }
}
