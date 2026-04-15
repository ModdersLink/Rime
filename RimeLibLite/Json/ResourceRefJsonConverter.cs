using System;
using Newtonsoft.Json;
using RimeLib.Frostbite.Core;
using RimeLib.IO;

namespace RimeLib.Json;

public class ResourceRefJsonConverter : JsonConverter
{
    public override void WriteJson(JsonWriter p_Writer, object? p_Value, JsonSerializer p_Serializer)
    {
        if (p_Value == null)
        {
            p_Writer.WriteNull();
            return;
        }

        var s_Value = (ResourceRef)p_Value;
        p_Writer.WriteValue(s_Value.Id);
    }

    public override object? ReadJson(
        JsonReader p_Reader,
        Type p_ObjectType,
        object? p_ExistingValue,
        JsonSerializer p_Serializer
    )
    {
        if (p_Reader.TokenType == JsonToken.Null)
            return null;

        if (p_Reader.TokenType == JsonToken.String)
        {
            var s_Str = (string?)p_Reader.Value;
            if (s_Str != null && ulong.TryParse(s_Str, System.Globalization.NumberStyles.HexNumber, null, out var s_Id))
                return new ResourceRef(s_Id);
        }

        if (p_Reader.TokenType == JsonToken.Integer)
        {
            var s_Value = (long?)p_Reader.Value;
            if (s_Value.HasValue)
                return new ResourceRef((ulong)s_Value.Value);
        }

        throw new JsonSerializationException(
            $"Expected integer or hex string for ResourceRef, got {p_Reader.TokenType}");
    }

    public override bool CanConvert(Type p_ObjectType)
    {
        return p_ObjectType == typeof(ResourceRef);
    }
}
