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
        var s_Value = (CtrRefBase) p_Value!;

        if (s_Value.IsNull())
        {
            p_Writer.WriteNull();
            return;
        }

        p_Writer.WriteStartObject();

        p_Writer.WritePropertyName("PartitionGuid");
        p_Writer.WriteValue(s_Value.PartitionGuid.ToString());

        p_Writer.WritePropertyName("InstanceGuid");
        if (s_Value.InstanceId is DataContainerId.Guid guid)
            p_Writer.WriteValue(guid.Id.ToString());
        else if (s_Value.InstanceId is DataContainerId.Index index)
            p_Writer.WriteValue(index.Id);

        p_Writer.WriteEndObject();
    }

    public override object? ReadJson(
        JsonReader p_Reader,
        Type p_ObjectType,
        object? p_ExistingValue,
        JsonSerializer p_Serializer
    )
    {
        if (p_Reader.TokenType != JsonToken.Null)
        {
            var s_Object = JObject.Load(p_Reader);

            if (!s_Object.ContainsKey("PartitionGuid"))
                throw new Exception("Container reference does not have 'PartitionGuid' key.");

            if (!s_Object.ContainsKey("InstanceGuid"))
                throw new Exception("Container reference does not have 'InstanceGuid' key.");

#pragma warning disable CS8604 // Possible null reference argument.
            var s_PartitionGuid = new GUID(s_Object["PartitionGuid"].Value<string>());

            if (s_Object["InstanceGuid"]?.Type == JTokenType.String)
            {
                var s_InstanceGuid = new GUID(s_Object["InstanceGuid"].Value<string>());
                return Activator.CreateInstance(p_ObjectType, s_PartitionGuid, s_InstanceGuid);
            }
            else if (s_Object["InstanceGuid"]?.Type == JTokenType.Integer)
            {
                long s_InstanceId = s_Object["InstanceGuid"].Value<long>();
                return Activator.CreateInstance(p_ObjectType, s_PartitionGuid, s_InstanceId);
            }

            throw new Exception("Container reference does have an invalid 'InstanceGuid' key.");
#pragma warning restore CS8604 // Possible null reference argument.
        }

        return Activator.CreateInstance(p_ObjectType, GUID.Empty, GUID.Empty);
    }

    public override bool CanConvert(Type p_ObjectType)
    {
        return typeof(CtrRefBase).IsAssignableFrom(p_ObjectType);
    }
}