using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace RimeLib.Serialization.Frostbite2_0.Json;

public class CtrRefJsonConverter : JsonConverter
{
    public override void WriteJson(JsonWriter p_Writer, object? p_Value, JsonSerializer p_Serializer)
    {
        if (p_Value == null)
        {
            p_Writer.WriteNull();
            return;
        }
        
        var s_Value = (CtrRefBase) p_Value;

        if (s_Value.IsNull())
        { 
            p_Writer.WriteNull();
            return;
        }

        p_Writer.WriteStartObject();

        p_Writer.WritePropertyName("PartitionGuid");
        p_Writer.WriteValue(s_Value.PartitionGuid.ToString());

        p_Writer.WritePropertyName("InstanceGuid");

        switch (s_Value.InstanceId)
        {
            case DataContainerId.Guid s_Guid:
                p_Writer.WriteValue(s_Guid.Id.ToString());
                break;
            
            case DataContainerId.Index s_Index:
                p_Writer.WriteValue(s_Index.Id);
                break;
        }

        p_Writer.WriteEndObject();
    }

    public override object? ReadJson(
        JsonReader p_Reader,
        Type p_ObjectType,
        object? p_ExistingValue,
        JsonSerializer p_Serializer
    )
    {
        if (p_Reader.TokenType == JsonToken.Null)
            return Activator.CreateInstance(p_ObjectType, GUID.Empty, new DataContainerId.Guid(GUID.Empty));
        
        var s_Object = JObject.Load(p_Reader);

        if (!s_Object.ContainsKey("PartitionGuid"))
            throw new Exception("Partition JSON does not have 'PartitionGuid' key.");

        if (!s_Object.ContainsKey("InstanceGuid"))
            throw new Exception("Partition JSON does not have 'InstanceGuid' key.");

        var s_PartGuid = s_Object["PartitionGuid"]?.Value<string>();

        if (s_PartGuid == null)
            throw new Exception("Partition JSON 'PartitionGuid' key is not a string.");

        var s_PartitionGuid = new GUID(s_PartGuid);
        
        DataContainerId s_DataContainerId = s_Object["InstanceGuid"]?.Type switch
        {
            JTokenType.Integer => new DataContainerId.Index(s_Object["InstanceGuid"]!.Value<int>()),
            JTokenType.String => new DataContainerId.Guid(new GUID(s_Object["InstanceGuid"]!.Value<string>()!)),
            _ => throw new Exception("Partition JSON 'InstanceGuid' key is not a string or integer.")
        };

        return Activator.CreateInstance(p_ObjectType, s_PartitionGuid, s_DataContainerId);
    }

    public override bool CanConvert(Type p_ObjectType)
    {
        return typeof(CtrRefBase).IsAssignableFrom(p_ObjectType);
    }
}
