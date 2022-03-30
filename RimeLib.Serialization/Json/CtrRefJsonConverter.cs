using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Ebx;

namespace RimeLib.Serialization.Json
{
    public class CtrRefJsonConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter p_Writer, object p_Value, JsonSerializer p_Serializer)
        {
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
            p_Writer.WriteValue(s_Value.InstanceGuid.ToString());

            p_Writer.WriteEndObject();
        }

        public override object? ReadJson(
            JsonReader p_Reader,
            Type p_ObjectType,
            object p_ExistingValue,
            JsonSerializer p_Serializer
        )
        {
            var s_PartitionGuid = GUID.Empty;
            var s_InstanceGuid = GUID.Empty;

            if (p_Reader.TokenType != JsonToken.Null)
            {
                var s_Object = JObject.Load(p_Reader);

                if (!s_Object.ContainsKey("PartitionGuid"))
                    throw new Exception("Container reference does not have 'PartitionGuid' key.");

                if (!s_Object.ContainsKey("InstanceGuid"))
                    throw new Exception("Container reference does not have 'InstanceGuid' key.");

                s_PartitionGuid = new GUID(s_Object["PartitionGuid"].Value<string>());
                s_InstanceGuid = new GUID(s_Object["InstanceGuid"].Value<string>());
            }

            return Activator.CreateInstance(p_ObjectType, s_PartitionGuid, s_InstanceGuid);
        }

        public override bool CanConvert(Type p_ObjectType)
        {
            return typeof(CtrRefBase).IsAssignableFrom(p_ObjectType);
        }
    }
}
