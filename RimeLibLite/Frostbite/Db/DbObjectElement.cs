using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using RimeLib.Frostbite.Core;
using RimeLib.IO;

namespace RimeLib.Frostbite.Db
{
    public class DbObjectElement<T>
    {
        public string FieldName => m_Element.FieldName;

        public T Value => (T) m_Element.Value;

        private readonly DbObjectElement m_Element;

        internal DbObjectElement(DbObjectElement p_Element)
        {
            m_Element = p_Element;
            // TODO: Add type checks!
        }

        public static implicit operator DbObjectElement(DbObjectElement<T> p_Element)
        {
            return p_Element.m_Element;
        }

        public static implicit operator T(DbObjectElement<T> p_Element)
        {
            return (T) p_Element.m_Element.Value;
        }
    }

    /// <summary>
    /// Implementation of fb::DbObjectElement
    /// </summary>
    [JsonConverter(typeof(DbObjectJsonConverter))]
    public class DbObjectElement : IFbSerializable
    {
        /// <summary>
        /// Field name
        /// </summary>
        public string FieldName { get; set; } = string.Empty;

        /// <summary>
        /// Object type
        /// </summary>
        public DbObjectType Type { get; set; } = DbObjectType.Eoo;

        public bool IsNull => Type == DbObjectType.Null;

        private object? m_ObjectValue;
        private byte m_Int8Value;
        private int m_Int32Value;
        private long m_Int64Value;
        private float m_FloatValue;
        private double m_DoubleValue;
        private string m_StringValue = "";

        public object Value
        {
            get
            {
                switch (Type)
                {
                    case DbObjectType.Null:
                        return 0;

                    case DbObjectType.Bool:
                        return m_Int8Value != 0;

                    case DbObjectType.String:
                        return m_StringValue;

                    case DbObjectType.Integer:
                        return m_Int32Value;

                    case DbObjectType.Long:
                    case DbObjectType.VarInt:
                        return m_Int64Value;

                    case DbObjectType.Float:
                        return m_FloatValue;

                    case DbObjectType.Double:
                        return m_DoubleValue;

                    case DbObjectType.Object | DbObjectType.Anonymous:
                    case DbObjectType.Array:
                    case DbObjectType.Object:
                    case DbObjectType.HomoArray:
                    case DbObjectType.ObjectId:
                    case DbObjectType.Timestamp:
                    case DbObjectType.RecordId:
                    case DbObjectType.Sha1:
                    case DbObjectType.Guid:
                    case DbObjectType.Blob:
                    case DbObjectType.Attachment:
                    case DbObjectType.Timespan:
                        return m_ObjectValue!;

                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public DbObjectElement()
        {
        }

        public DbObjectElement(string p_FieldName)
        {
            Type = DbObjectType.Null;
            FieldName = p_FieldName;
        }

        public DbObjectElement(string p_FieldName, DbObject p_Object, bool p_Array = false)
        {
            m_ObjectValue = p_Object;
            Type = p_Array ? DbObjectType.Array : DbObjectType.Object;
            FieldName = p_FieldName;
        }

        /// <summary>
        /// Create an Anonymous Object or Array.
        /// </summary>
        public DbObjectElement(DbObject p_Object, bool p_Array = false)
        {
            m_ObjectValue = p_Object;
            Type = p_Array ? DbObjectType.Array : DbObjectType.Object;
            Type |= DbObjectType.Anonymous;
        }

        public DbObjectElement(string p_FieldName, byte[] p_Data)
        {
            m_ObjectValue = p_Data;
            Type = DbObjectType.Blob;
            FieldName = p_FieldName;
        }

        public DbObjectElement(string p_FieldName, int p_Value)
        {
            m_Int32Value = p_Value;
            Type = DbObjectType.Integer;
            FieldName = p_FieldName;
        }

        public DbObjectElement(string p_FieldName, float p_Value)
        {
            m_FloatValue = p_Value;
            Type = DbObjectType.Float;
            FieldName = p_FieldName;
        }

        public DbObjectElement(string p_FieldName, double p_Value)
        {
            m_DoubleValue = p_Value;
            Type = DbObjectType.Float;
            FieldName = p_FieldName;
        }

        public DbObjectElement(string p_FieldName, long p_Value, bool p_VariableLength = false)
        {
            m_Int64Value = p_Value;
            Type = p_VariableLength ? DbObjectType.VarInt : DbObjectType.Long;
            FieldName = p_FieldName;
        }

        public DbObjectElement(string p_FieldName, Sha1 p_Hash)
        {
            m_ObjectValue = p_Hash;
            Type = DbObjectType.Sha1;
            FieldName = p_FieldName;
        }

        /// <summary>
        /// Create new DbObjectElement from Guid
        /// </summary>
        /// <param name="p_FieldName">Field name</param>
        /// <param name="p_Id">Id</param>
        public DbObjectElement(string p_FieldName, GUID p_Id)
        {
            m_ObjectValue = p_Id;
            Type = DbObjectType.Guid;
            FieldName = p_FieldName;
        }

        public DbObjectElement(string p_FieldName, ObjectId p_Value)
        {
            m_ObjectValue = p_Value;
            Type = DbObjectType.ObjectId;
            FieldName = p_FieldName;
        }

        public DbObjectElement(string p_FieldName, DbObjectTimestamp p_Value)
        {
            m_ObjectValue = p_Value;
            Type = DbObjectType.Timestamp;
            FieldName = p_FieldName;
        }

        public DbObjectElement(string p_FieldName, DbObjectTimespan p_Value)
        {
            m_ObjectValue = p_Value;
            Type = DbObjectType.Timespan;
            FieldName = p_FieldName;
        }

        public DbObjectElement(string p_FieldName, RecordId p_Value)
        {
            m_ObjectValue = p_Value;
            Type = DbObjectType.RecordId;
            FieldName = p_FieldName;
        }

        /// <summary>
        /// Create a new DbObjectElement from string value
        /// </summary>
        /// <param name="p_FieldName">Field name</param>
        /// <param name="p_Value">Value</param>
        public DbObjectElement(string p_FieldName, string p_Value)
        {
            m_StringValue = p_Value;
            Type = DbObjectType.String;
            FieldName = p_FieldName;
        }

        /// <summary>
        /// Create a new DbObjectElement from bool value
        /// </summary>
        /// <param name="p_FieldName">Field name</param>
        /// <param name="p_Value">Value</param>
        public DbObjectElement(string p_FieldName, bool p_Value)
        {
            m_Int8Value = p_Value ? (byte) 1 : (byte) 0;
            Type = DbObjectType.Bool;
            FieldName = p_FieldName;
        }

        /// <summary>
        /// Constructor to read a object element from an opened reader
        /// </summary>
        /// <param name="p_Reader">Reader opened to the position of a object element</param>
        public DbObjectElement(RimeReader p_Reader)
        {
            FieldName = "";
            Deserialize(p_Reader);
        }

        /// <summary>
        /// Parses a 4x4 matrix
        /// </summary>
        /// <param name="p_Reader">Reader opened to the position of a matrix4x4 object</param>
        private void ParseMatrix44(RimeReader p_Reader)
        {
            m_ObjectValue = new Matrix44(p_Reader);
        }

        // Parsing
        private void ParseString(RimeReader p_Reader)
        {
            var s_StringLen = (int) p_Reader.Decode7Bit(out _);
            m_StringValue = Encoding.UTF8.GetString(p_Reader.ReadBytes(s_StringLen)).Replace("\0", "");
        }

        private void ParseObject(RimeReader p_Reader)
        {
            var s_ObjectSize = (int) p_Reader.Decode7Bit(out _);

            var s_Stream = new MemoryStream(p_Reader.ReadBytes(s_ObjectSize));
            using var s_Reader = new RimeReader(s_Stream);

            var s_Object = new DbObject(s_Reader);
            
            m_ObjectValue = s_Object;
        }

        private void ParseHomoArray(RimeReader p_Reader)
        {
            ParseUnknown();
        }

        private void ParseObjectId(RimeReader p_Reader)
        {
            m_ObjectValue = new ObjectId(p_Reader);
        }

        private void ParseBool(RimeReader p_Reader)
        {
            m_Int8Value = p_Reader.ReadUByte();
        }

        private void ParseInteger(RimeReader p_Reader)
        {
            m_Int32Value = p_Reader.ReadInt32();
        }

        private void ParseLong(RimeReader p_Reader)
        {
            m_Int64Value = p_Reader.ReadInt64();
        }

        private void ParseVarInt(RimeReader p_Reader)
        {
            var s_Value = p_Reader.DecodeZigZag64(out _);
            m_Int64Value = s_Value;
        }

        private void ParseFloat(RimeReader p_Reader)
        {
            m_FloatValue = p_Reader.ReadSingle();
        }

        private void ParseDouble(RimeReader p_Reader)
        {
            m_DoubleValue = p_Reader.ReadDouble();
        }

        private void ParseTimestamp(RimeReader p_Reader)
        {
            m_ObjectValue = new DbObjectTimestamp(p_Reader);
        }

        private void ParseRecordId(RimeReader p_Reader)
        {
            m_ObjectValue = new RecordId(p_Reader);
        }

        private void ParseGuid(RimeReader p_Reader)
        {
            m_ObjectValue = new GUID(p_Reader);
        }

        private void ParseSha1(RimeReader p_Reader)
        {
            m_ObjectValue = new Sha1(p_Reader);
        }

        private void ParseBlob(RimeReader p_Reader)
        {
            var s_BlobLen = (int) p_Reader.Decode7Bit(out _);
            m_ObjectValue = p_Reader.ReadBytes(s_BlobLen);
        }

        private void ParseAttachment(RimeReader p_Reader)
        {
            // TODO: Do we need to handle this differently?
            m_ObjectValue = new Sha1(p_Reader);
        }

        private void ParseTimespan(RimeReader p_Reader)
        {
            m_ObjectValue = new DbObjectTimespan(p_Reader.DecodeZigZag64(out _));
        }

        private void ParseUnknown()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns>Fieldname and object element</returns>
        public override string ToString()
        {
            if (string.IsNullOrWhiteSpace(FieldName))
                return JsonConvert.SerializeObject(this);
            
            return FieldName + " = " + JsonConvert.SerializeObject(this);
        }

        #region Serialization
        /// <summary>
        /// Writes a DbObjectElement to an opened writer
        /// </summary>
        /// <param name="p_Writer">Writer opened to the position of this object element</param>
        /// <returns>True on success, false otherwise</returns>
        public bool Serialize(RimeWriter p_Writer)
        {
            if (Type == DbObjectType.Eoo)
                return true;

            var s_Type = Type;

            var s_HasName = !string.IsNullOrWhiteSpace(FieldName);

            if (!s_HasName)
                s_Type |= DbObjectType.Anonymous;

            //s_Type |= DbObjectType.Mask;

            p_Writer.Write((byte) s_Type);

            if (s_HasName)
                p_Writer.WriteNullTerminatedString(FieldName);

            switch (Type)
            {
                case DbObjectType.Null:
                    return true;

                case DbObjectType.Array:
                case DbObjectType.Object:
                case DbObjectType.Object | DbObjectType.Anonymous:
                    return SerializeObject(p_Writer);

                case DbObjectType.HomoArray:
                    return SerializeObject(p_Writer);

                case DbObjectType.ObjectId:
                    return SerializeObjectId(p_Writer);

                case DbObjectType.Bool:
                    return SerializeBool(p_Writer);

                case DbObjectType.String:
                    return SerializeString(p_Writer);

                case DbObjectType.Integer:
                    return SerializeInteger(p_Writer);

                case DbObjectType.Long:
                    return SerializeLong(p_Writer);

                case DbObjectType.VarInt:
                    return SerializeVarInt(p_Writer);

                case DbObjectType.Float:
                    return SerializeFloat(p_Writer);

                case DbObjectType.Double:
                    return SerializeDouble(p_Writer);

                case DbObjectType.Timestamp:
                    return SerializeTimestamp(p_Writer);

                case DbObjectType.RecordId:
                    return SerializeRecordId(p_Writer);

                case DbObjectType.Guid:
                    return SerializeGuid(p_Writer);

                case DbObjectType.Sha1:
                    return SerializeSha1(p_Writer);

                case DbObjectType.Blob:
                    return SerializeBlob(p_Writer);

                case DbObjectType.Attachment:
                    return SerializeAttachment(p_Writer);

                case DbObjectType.Timespan:
                    return SerializeTimespan(p_Writer);

                default:
                    throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Serializes this object element to a byte array
        /// </summary>
        /// <returns>byte array containing the serialized data</returns>
        public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
        {
            p_Data = null;

            using (var s_Writer = new RimeWriter(new MemoryStream()))
            {
                if (!Serialize(s_Writer))
                    return false;

                s_Writer.Flush();
                p_Data = ((MemoryStream) s_Writer.BaseStream).ToArray();
            }

            return true;
        }

        public void Deserialize(RimeReader p_Reader)
        {
            var s_Type = (DbObjectType) p_Reader.ReadUByte();

            // Get Type
            Type = s_Type & DbObjectType.Mask;

            // Do we have a name to parse?
            if ((Type == DbObjectType.Eoo) || (s_Type & DbObjectType.Anonymous) != 0)
                FieldName = "";
            else
                FieldName = p_Reader.ReadNullTerminatedString();

            // Parse the rest of the data.
            switch (Type)
            {
                case DbObjectType.Eoo:
                case DbObjectType.InternalMax:
                case DbObjectType.Null:
                    break;

                case DbObjectType.Array:
                case DbObjectType.Object:
                    ParseObject(p_Reader);
                    break;

                case DbObjectType.HomoArray:
                    ParseObject(p_Reader);
                    break;

                case DbObjectType.ObjectId:
                    ParseObjectId(p_Reader);
                    break;

                case DbObjectType.Bool:
                    ParseBool(p_Reader);
                    break;

                case DbObjectType.String:
                    ParseString(p_Reader);
                    break;

                case DbObjectType.Integer:
                    ParseInteger(p_Reader);
                    break;

                case DbObjectType.Long:
                    ParseLong(p_Reader);
                    break;

                case DbObjectType.VarInt:
                    ParseVarInt(p_Reader);
                    break;

                case DbObjectType.Float:
                    ParseFloat(p_Reader);
                    break;

                case DbObjectType.Double:
                    ParseDouble(p_Reader);
                    break;

                case DbObjectType.Timestamp:
                    ParseTimestamp(p_Reader);
                    break;

                case DbObjectType.RecordId:
                    ParseRecordId(p_Reader);
                    break;

                case DbObjectType.Guid:
                    ParseGuid(p_Reader);
                    break;

                case DbObjectType.Sha1:
                    ParseSha1(p_Reader);
                    break;

                case DbObjectType.Blob:
                    ParseBlob(p_Reader);
                    break;

                case DbObjectType.Attachment:
                    ParseAttachment(p_Reader);
                    break;

                case DbObjectType.Timespan:
                    ParseTimespan(p_Reader);
                    break;

                case DbObjectType.Matrix44:
                    ParseMatrix44(p_Reader);
                    break;

                default:
                    // TODO: Exception error message.
                    throw new NotImplementedException();
            }
        }

        public void Deserialize(byte[] p_Data)
        {
            using (var s_Reader = new RimeReader(new MemoryStream(p_Data)))
                Deserialize(s_Reader);
        }

        private bool SerializeString(RimeWriter p_Writer)
        {
            p_Writer.Encode7Bit((uint) (m_StringValue.Length + 1));

            p_Writer.Write(Encoding.ASCII.GetBytes(m_StringValue));
            p_Writer.Write((byte) 0);

            return true;
        }

        private bool SerializeObject(RimeWriter p_Writer)
        {
            var s_Value = (DbObject) m_ObjectValue!;

            var s_SerializedObject = s_Value.Serialize();

            p_Writer.Encode7Bit((uint) s_SerializedObject.Length + 1);
            p_Writer.Write(s_SerializedObject);

            p_Writer.Write((byte) 0x00);

            return true;
        }

        private bool SerializeHomoArray(RimeWriter p_Writer)
        {
            SerializeUnknown();
            return false;
        }

        private bool SerializeObjectId(RimeWriter p_Writer)
        {
            var s_Value = (ObjectId) m_ObjectValue!;
            return s_Value.Serialize(p_Writer);
        }

        private bool SerializeBool(RimeWriter p_Writer)
        {
            p_Writer.Write(m_Int8Value);
            return true;
        }

        private bool SerializeInteger(RimeWriter p_Writer)
        {
            p_Writer.Write(m_Int32Value);
            return true;
        }

        private bool SerializeLong(RimeWriter p_Writer)
        {
            p_Writer.Write(m_Int64Value);
            return true;
        }

        private bool SerializeVarInt(RimeWriter p_Writer)
        {
            p_Writer.EncodeZigZag(m_Int64Value);
            return true;
        }

        private bool SerializeFloat(RimeWriter p_Writer)
        {
            p_Writer.Write(m_FloatValue);
            return true;
        }

        private bool SerializeDouble(RimeWriter p_Writer)
        {
            p_Writer.Write(m_DoubleValue);
            return true;
        }

        private bool SerializeTimestamp(RimeWriter p_Writer)
        {
            var s_Value = (DbObjectTimestamp) m_ObjectValue!;
            return s_Value.Serialize(p_Writer);
        }

        private bool SerializeRecordId(RimeWriter p_Writer)
        {
            var s_Value = (RecordId) m_ObjectValue!;
            return s_Value.Serialize(p_Writer);
        }

        private bool SerializeGuid(RimeWriter p_Writer)
        {
            var s_Value = (GUID) m_ObjectValue!;
            return s_Value.Serialize(p_Writer);
        }

        private bool SerializeSha1(RimeWriter p_Writer)
        {
            var s_Value = (Sha1) m_ObjectValue!;
            return s_Value.Serialize(p_Writer);
        }

        private bool SerializeBlob(RimeWriter p_Writer)
        {
            var s_Value = (byte[]) m_ObjectValue!;

            p_Writer.Encode7Bit((uint) s_Value.Length);
            p_Writer.Write(s_Value);

            return true;
        }

        private bool SerializeAttachment(RimeWriter p_Writer)
        {
            // TODO: Do we need to handle this differently.
            var s_Value = (Sha1) m_ObjectValue!;
            return s_Value.Serialize(p_Writer);
        }

        private bool SerializeTimespan(RimeWriter p_Writer)
        {
            var s_Value = (DbObjectTimespan) m_ObjectValue!;
            return s_Value.Serialize(p_Writer);
        }

        private bool SerializeUnknown()
        {
            throw new NotImplementedException();
        }

        #endregion

        public bool TryGetSpecialization<T>(out DbObjectElement<T> p_Element)
        {
            // TODO: Add type validation.
            p_Element = new DbObjectElement<T>(this);
            return true;
        }
    }
}
