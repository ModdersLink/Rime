using System;
using Newtonsoft.Json;
using RimeLib.Serialization.Ebx;

namespace RimeLib.Serialization.Json
{
    public class CtrRefJsonConverter : JsonConverter<CtrRefBase>
    {
        public override void WriteJson(JsonWriter p_Writer, CtrRefBase p_Value, JsonSerializer p_Serializer)
        {
            if (p_Value.IsNull())
            {
                p_Writer.WriteNull();
                return;
            }

            p_Writer.WriteStartObject();

            p_Writer.WritePropertyName("PartitionGuid");
            p_Writer.WriteValue(p_Value.PartitionGuid.ToString());

            p_Writer.WritePropertyName("InstanceGuid");
            p_Writer.WriteValue(p_Value.InstanceGuid.ToString());

            p_Writer.WriteEndObject();
        }

        public override CtrRefBase ReadJson(
            JsonReader p_Reader,
            Type p_ObjectType,
            CtrRefBase p_ExistingValue,
            bool p_HasExistingValue,
            JsonSerializer p_Serializer
        )
        {
            if (p_Reader.Value == null)
                return new CtrRefBase();

            return new CtrRefBase();
        }
    }
}
