using System;
using Newtonsoft.Json;
using RimeLib.Frostbite.Core;

namespace RimeLib.Json
{
    public class GuidJsonConverter : JsonConverter<GUID>
    {
        public override void WriteJson(JsonWriter p_Writer, GUID p_Value, JsonSerializer p_Serializer)
        {
            p_Writer.WriteValue(p_Value.ToString());
        }

        public override GUID ReadJson(
            JsonReader p_Reader,
            Type p_ObjectType,
            GUID p_ExistingValue,
            bool p_HasExistingValue,
            JsonSerializer p_Serializer
        )
        {
            return new GUID((string) p_Reader.Value);
        }
    }
}
