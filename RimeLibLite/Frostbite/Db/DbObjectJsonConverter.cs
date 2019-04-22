using System;
using Newtonsoft.Json;
using RimeLib.Frostbite.Core;

namespace RimeLib.Frostbite.Db
{
    class DbObjectJsonConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter p_Writer, object p_Value, JsonSerializer p_Serializer)
        {
            switch (p_Value)
            {
                case DbObject s_DbObject:
                    WriteDbObjectJson(p_Writer, s_DbObject, p_Serializer);
                    break;

                case DbObjectElement s_Element:
                    WriteDbObjectElementJson(p_Writer, s_Element, p_Serializer);
                    break;

                default:
                    throw new NotImplementedException("Tried to serialize an unsupported type.");
            }
        }

        protected void WriteDbObjectJson(JsonWriter p_Writer, DbObject p_Object, JsonSerializer p_Serializer)
        {
            if (p_Object.Count == 0)
                return;

            if (p_Object.Count > 1 && string.IsNullOrWhiteSpace(p_Object[0].FieldName))
            {
                p_Writer.WriteStartArray();

                for (var i = 0; i < p_Object.Count; ++i)
                {
                    var s_Element = p_Object[i];
                    p_Serializer.Serialize(p_Writer, s_Element);
                }

                p_Writer.WriteEndArray();

                return;
            } 
            
            if (p_Object.Count == 1 && string.IsNullOrWhiteSpace(p_Object[0].FieldName))
            {
                p_Serializer.Serialize(p_Writer, p_Object[0]);
                return;
            }

            p_Writer.WriteStartObject();

            for (var i = 0; i < p_Object.Count; ++i)
            {
                var s_Element = p_Object[i];

                p_Writer.WritePropertyName(s_Element.FieldName);
                p_Serializer.Serialize(p_Writer, s_Element);
            }

            p_Writer.WriteEndObject();
        }

        protected void WriteDbObjectElementJson(JsonWriter p_Writer, DbObjectElement p_Object, JsonSerializer p_Serializer)
        {
            switch (p_Object.Type)
            {
                case DbObjectType.Eoo:
                    break;

                case DbObjectType.Null:
                    WriteNull(p_Writer, p_Object, p_Serializer);
                    break;

                case DbObjectType.Array:
                    WriteArray(p_Writer, p_Object, p_Serializer);
                    break;

                case DbObjectType.Object:
                    WriteObject(p_Writer, p_Object, p_Serializer);
                    break;

                case DbObjectType.HomoArray:
                    WriteHomoArray(p_Writer, p_Object, p_Serializer);
                    break;

                case DbObjectType.ObjectId:
                    WriteObjectId(p_Writer, p_Object, p_Serializer);
                    break;

                case DbObjectType.Bool:
                    WriteBool(p_Writer, p_Object, p_Serializer);
                    break;

                case DbObjectType.String:
                    WriteString(p_Writer, p_Object, p_Serializer);
                    break;

                case DbObjectType.Integer:
                    WriteInteger(p_Writer, p_Object, p_Serializer);
                    break;

                case DbObjectType.Long:
                    WriteLong(p_Writer, p_Object, p_Serializer);
                    break;

                case DbObjectType.VarInt:
                    WriteVarInt(p_Writer, p_Object, p_Serializer);
                    break;

                case DbObjectType.Float:
                    WriteFloat(p_Writer, p_Object, p_Serializer);
                    break;

                case DbObjectType.Double:
                    WriteDouble(p_Writer, p_Object, p_Serializer);
                    break;

                case DbObjectType.Timestamp:
                    WriteTimestamp(p_Writer, p_Object, p_Serializer);
                    break;

                case DbObjectType.RecordId:
                    WriteRecordId(p_Writer, p_Object, p_Serializer);
                    break;

                case DbObjectType.Guid:
                    WriteGuid(p_Writer, p_Object, p_Serializer);
                    break;

                case DbObjectType.Sha1:
                    WriteSha1(p_Writer, p_Object, p_Serializer);
                    break;

                case DbObjectType.Blob:
                    WriteBlob(p_Writer, p_Object, p_Serializer);
                    break;

                case DbObjectType.Attachment:
                    WriteAttachment(p_Writer, p_Object, p_Serializer);
                    break;

                case DbObjectType.Timespan:
                    WriteTimespan(p_Writer, p_Object, p_Serializer);
                    break;

                default:
                    // TODO: Better exception message.
                    throw new NotImplementedException("");
            }
        }

        protected void WriteNull(JsonWriter p_Writer, DbObjectElement p_Object, JsonSerializer p_Serializer)
        {
            p_Writer.WriteNull();
        }

        protected void WriteArray(JsonWriter p_Writer, DbObjectElement p_Object, JsonSerializer p_Serializer)
        {
            p_Writer.WriteStartArray();

            var s_Array = p_Object.Value as DbObject;

            if (s_Array is null)
                throw new Exception("Tried serializing DbObject array but instead got different type.");

            for (var i = 0; i < s_Array.Count; ++i)
                WriteDbObjectElementJson(p_Writer, s_Array[i], p_Serializer);

            p_Writer.WriteEndArray();
        }

        protected void WriteObject(JsonWriter p_Writer, DbObjectElement p_Object, JsonSerializer p_Serializer)
        {
            var s_Object = p_Object.Value as DbObject;

            if (s_Object is null)
            {
                p_Writer.WriteNull();
                return;
            }

            p_Writer.WriteStartObject();

            for (var i = 0; i < s_Object.Count; ++i)
            {
                var s_Element = s_Object[i];

                p_Writer.WritePropertyName(s_Element.FieldName);
                p_Serializer.Serialize(p_Writer, s_Element);
            }

            p_Writer.WriteEndObject();
        }

        protected void WriteHomoArray(JsonWriter p_Writer, DbObjectElement p_Object, JsonSerializer p_Serializer)
        {
            throw new NotImplementedException("We do not support HomoArray serialization.");
        }

        protected void WriteObjectId(JsonWriter p_Writer, DbObjectElement p_Object, JsonSerializer p_Serializer)
        {
            var s_ObjectId = (ObjectId) p_Object.Value;
            p_Writer.WriteValue(s_ObjectId.ToString());
        }

        protected void WriteBool(JsonWriter p_Writer, DbObjectElement p_Object, JsonSerializer p_Serializer)
        {
            var s_Value = (bool) p_Object.Value;
            p_Writer.WriteValue(s_Value);
        }

        protected void WriteString(JsonWriter p_Writer, DbObjectElement p_Object, JsonSerializer p_Serializer)
        {
            var s_Value = (string) p_Object.Value;
            p_Writer.WriteValue(s_Value);
        }

        protected void WriteInteger(JsonWriter p_Writer, DbObjectElement p_Object, JsonSerializer p_Serializer)
        {
            var s_Value = (int) p_Object.Value;
            p_Writer.WriteValue(s_Value);
        }

        protected void WriteLong(JsonWriter p_Writer, DbObjectElement p_Object, JsonSerializer p_Serializer)
        {
            var s_Value = (long) p_Object.Value;
            p_Writer.WriteValue(s_Value);
        }

        protected void WriteVarInt(JsonWriter p_Writer, DbObjectElement p_Object, JsonSerializer p_Serializer)
        {
            var s_Value = (long) p_Object.Value;
            p_Writer.WriteValue(s_Value);
        }

        protected void WriteFloat(JsonWriter p_Writer, DbObjectElement p_Object, JsonSerializer p_Serializer)
        {
            var s_Value = (float) p_Object.Value;
            p_Writer.WriteValue(s_Value);
        }

        protected void WriteDouble(JsonWriter p_Writer, DbObjectElement p_Object, JsonSerializer p_Serializer)
        {
            var s_Value = (double) p_Object.Value;
            p_Writer.WriteValue(s_Value);
        }

        protected void WriteTimestamp(JsonWriter p_Writer, DbObjectElement p_Object, JsonSerializer p_Serializer)
        {
            var s_Value = (DbObjectTimestamp) p_Object.Value;
            p_Writer.WriteValue(s_Value.ToString());
        }

        protected void WriteRecordId(JsonWriter p_Writer, DbObjectElement p_Object, JsonSerializer p_Serializer)
        {
            var s_Value = (RecordId) p_Object.Value;
            p_Serializer.Serialize(p_Writer, s_Value);
        }

        protected void WriteGuid(JsonWriter p_Writer, DbObjectElement p_Object, JsonSerializer p_Serializer)
        {
            var s_Value = (GUID) p_Object.Value;
            p_Writer.WriteValue(s_Value.ToString());
        }

        protected void WriteSha1(JsonWriter p_Writer, DbObjectElement p_Object, JsonSerializer p_Serializer)
        {
            var s_Value = (Sha1) p_Object.Value;
            p_Writer.WriteValue(s_Value.ToString());
        }

        protected void WriteBlob(JsonWriter p_Writer, DbObjectElement p_Object, JsonSerializer p_Serializer)
        {
            var s_Value = (byte[]) p_Object.Value;
            p_Writer.WriteValue(Convert.ToBase64String(s_Value));
        }

        protected void WriteAttachment(JsonWriter p_Writer, DbObjectElement p_Object, JsonSerializer p_Serializer)
        {
            var s_Value = (Attachment) p_Object.Value;
            p_Writer.WriteValue(s_Value.ToString());
        }

        protected void WriteTimespan(JsonWriter p_Writer, DbObjectElement p_Object, JsonSerializer p_Serializer)
        {
            var s_Value = (DbObjectTimespan) p_Object.Value;
            p_Writer.WriteValue(s_Value.TimeSpan);
        }

        public override bool CanRead => false;

        public override object ReadJson(JsonReader p_Reader, Type p_ObjectType, object p_ExistingValue, JsonSerializer p_Serializer)
        {
            throw new NotImplementedException();
        }

        public override bool CanConvert(Type p_ObjectType)
        {
            return typeof(DbObject).IsAssignableFrom(p_ObjectType) || typeof(DbObjectElement).IsAssignableFrom(p_ObjectType);
        }
    }
}
