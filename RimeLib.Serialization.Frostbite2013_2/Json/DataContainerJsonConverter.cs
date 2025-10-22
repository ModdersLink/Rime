using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace RimeLib.Serialization.Frostbite2013_2.Json;

public class DataContainerJsonConverter : JsonConverter<DataContainerBase>
{
    public override bool CanWrite => false;

    public override void WriteJson(JsonWriter p_Writer, DataContainerBase? p_Value, JsonSerializer p_Serializer)
    {
        throw new Exception(
            "Tried serializing DataContainer with the custom converter. This isn't supported. The converter should only be used for reading."
        );
    }

    public override DataContainerBase ReadJson(
        JsonReader p_Reader,
        Type p_ObjectType,
        DataContainerBase? p_ExistingValue,
        bool p_HasExistingValue,
        JsonSerializer p_Serializer
    )
    {
        var s_Object = JObject.Load(p_Reader);

        if (!s_Object.ContainsKey("$type"))
            throw new Exception("DataContainer doesn't have a '$type' property.");

        var s_Type = s_Object["$type"]?.Value<string>();
        
        if (s_Type == null)
            throw new Exception("DataContainer doesn't have a '$type' property.");

        var s_ContainerType = DataContainerTypeRegistry.FindByName(s_Type);

        if (s_ContainerType == null)
            throw new Exception($"Could not find container type '{s_Type}'.");

        var s_Serializer = new JsonSerializer();
        s_Serializer.Converters.Add(new StringEnumConverter());
        s_Serializer.Converters.Add(new CtrRefJsonConverter());
        s_Serializer.NullValueHandling = NullValueHandling.Include;
        s_Serializer.MissingMemberHandling = MissingMemberHandling.Error;
        s_Serializer.TypeNameHandling = TypeNameHandling.None;

        return (s_Object.ToObject(s_ContainerType, s_Serializer) as DataContainerBase)!;
    }
}
