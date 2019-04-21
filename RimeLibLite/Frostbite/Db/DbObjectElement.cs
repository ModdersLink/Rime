using System;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using RimeLib.Frostbite.Core;
using RimeLib.IO;

namespace RimeLib.Frostbite.Db
{
    /// <summary>
    /// Implementation of fb::DbObjectElement
    /// </summary>
    [JsonConverter(typeof(DbObjectConverter))]
    public class DbObjectElement : IFbSerializable
    {
        /// <summary>
        /// Field name
        /// </summary>
        public string FieldName { get; set; }

        /// <summary>
        /// Object type
        /// </summary>
        public DbObjectType Type { get; set; }

        /// <summary>
        /// Value of this object element
        /// </summary>
        public object Value { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public DbObjectElement()
        {
            Value = null;
            Type = DbObjectType.Eoo;
            FieldName = "";
        }

        public DbObjectElement(string p_FieldName, int p_Value)
        {
            Value = p_Value;
            Type = DbObjectType.Integer;
            FieldName = p_FieldName;
        }
        public DbObjectElement(string p_FieldName, long p_Value)
        {
            Value = p_Value;
            Type = DbObjectType.Long;
            FieldName = p_FieldName;
        }

        public DbObjectElement(string p_FieldName, Sha1 p_Hash)
        {
            Value = p_Hash;
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
            Value = p_Id;
            Type = DbObjectType.ObjectId;
            FieldName = p_FieldName;
        }

        /// <summary>
        /// Create a new DbObjectElement from object value
        /// </summary>
        /// <param name="p_FieldName">Field name</param>
        /// <param name="p_Object">Object</param>
        public DbObjectElement(string p_FieldName, DbObject p_Object)
        {
            Value = p_Object;
            Type = DbObjectType.Object;
            FieldName = p_FieldName;
        }

        /// <summary>
        /// Create a new DbObjectElement from string value
        /// </summary>
        /// <param name="p_FieldName">Field name</param>
        /// <param name="p_Value">Value</param>
        public DbObjectElement(string p_FieldName, string p_Value)
        {
            Value = p_Value;
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
            Value = p_Value;
            Type = DbObjectType.Bool;
            FieldName = p_FieldName;
        }

        /// <summary>
        /// Constructor to read a object element from an opened reader
        /// </summary>
        /// <param name="p_Reader">Reader opened to the position of a object element</param>
        public DbObjectElement(RimeReader p_Reader)
        {
            Value = null;

            var s_Type = (DbObjectType)p_Reader.ReadByte();

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

        /// <summary>
        /// Parses a 4x4 matrix
        /// </summary>
        /// <param name="p_Reader">Reader opened to the position of a matrix4x4 object</param>
        private void ParseMatrix44(RimeReader p_Reader)
        {
            Value = new Matrix44(p_Reader);
        }

        // Parsing
        private void ParseString(RimeReader p_Reader)
        {
            var s_StringLen = (int) p_Reader.Decode7Bit(out _);
            Value = Encoding.UTF8.GetString(p_Reader.ReadBytes(s_StringLen)).Replace("\0", "");
        }

        private void ParseObject(RimeReader p_Reader)
        {
            var s_ObjectSize = (int) p_Reader.Decode7Bit(out _);

            var s_Stream = new MemoryStream(p_Reader.ReadBytes(s_ObjectSize));
            var s_Reader = new RimeReader(s_Stream);

            var s_Object = new DbObject(s_Reader);

            // Cleanup
            s_Reader.Close();
            s_Stream.Close();

            Value = s_Object;
        }

        private void ParseHomoArray(RimeReader p_Reader)
        {
            ParseUnknown();
        }

        private void ParseObjectId(RimeReader p_Reader)
        {
            Value = new ObjectId(p_Reader);
        }

        private void ParseBool(RimeReader p_Reader)
        {
            Value = p_Reader.ReadByte() == 0x01;
        }

        private void ParseInteger(RimeReader p_Reader)
        {
            Value = p_Reader.ReadInt32();
        }

        private void ParseLong(RimeReader p_Reader)
        {
            Value = p_Reader.ReadInt64();
        }

        private void ParseVarInt(RimeReader p_Reader)
        {
            var s_Value = p_Reader.DecodeZigZag64(out _);
            Value = s_Value;
        }

        private void ParseFloat(RimeReader p_Reader)
        {
            Value = p_Reader.ReadSingle();
        }

        private void ParseDouble(RimeReader p_Reader)
        {
            Value = p_Reader.ReadDouble();
        }

        private void ParseTimestamp(RimeReader p_Reader)
        {
            Value = new DbObjectTimestamp(p_Reader);
        }

        private void ParseRecordId(RimeReader p_Reader)
        {
            Value = new RecordId(p_Reader);
        }

        private void ParseGuid(RimeReader p_Reader)
        {
            Value = new GUID(p_Reader);
        }

        private void ParseSha1(RimeReader p_Reader)
        {
            Value = new Sha1(p_Reader);
        }

        private void ParseBlob(RimeReader p_Reader)
        {
            var s_BlobLen = (int) p_Reader.Decode7Bit(out _);
            Value = p_Reader.ReadBytes(s_BlobLen);
        }

        private void ParseAttachment(RimeReader p_Reader)
        {
            Value = new Sha1(p_Reader);

            throw new NotImplementedException();
            // TODO: Do we need to handle this differently?
        }

        private void ParseTimespan(RimeReader p_Reader)
        {
            Value = new DbObjectTimespan(p_Reader.DecodeZigZag64(out _));
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

        void IFbSerializable.Serialize(RimeWriter p_Writer)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Serializes this object element to a byte array
        /// </summary>
        /// <returns>byte array containing the serialized data</returns>
        public byte[] Serialize()
        {
            using (var s_Writer = new RimeWriter(new MemoryStream()))
            {
                if (!Serialize(s_Writer))
                    throw new Exception("DbObjectElement serialization failed.");

                s_Writer.Flush();
                return ((MemoryStream) s_Writer.BaseStream).ToArray();
            }
        }

        public void Deserialize(RimeReader p_Reader)
        {
            throw new NotImplementedException();
        }

        public void Deserialize(byte[] p_Data)
        {
            throw new NotImplementedException();
        }

        private bool SerializeString(RimeWriter p_Writer)
        {
            var s_Value = (string) Value;
            p_Writer.Encode7Bit((uint) (s_Value.Length + 1));

            p_Writer.Write(Encoding.ASCII.GetBytes(s_Value));
            p_Writer.Write((byte) 0);

            return true;
        }

        private bool SerializeObject(RimeWriter p_Writer)
        {
            var s_Value = (DbObject) Value;

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
            var s_Value = (ObjectId) Value;
            return s_Value.Serialize(p_Writer);
        }

        private bool SerializeBool(RimeWriter p_Writer)
        {
            var s_Value = (bool) Value;
            p_Writer.Write((byte) (s_Value ? 0x01 : 0x00));
            return true;
        }

        private bool SerializeInteger(RimeWriter p_Writer)
        {
            var s_Value = (int) Value;
            p_Writer.Write(s_Value);
            return true;
        }

        private bool SerializeLong(RimeWriter p_Writer)
        {
            var s_Value = (long) Value;
            p_Writer.Write(s_Value);
            return true;
        }

        private bool SerializeVarInt(RimeWriter p_Writer)
        {
            var s_Value = (long) Value;
            p_Writer.EncodeZigZag(s_Value);
            return true;
        }

        private bool SerializeFloat(RimeWriter p_Writer)
        {
            var s_Value = (float) Value;
            p_Writer.Write(s_Value);
            return true;
        }

        private bool SerializeDouble(RimeWriter p_Writer)
        {
            var s_Value = (double) Value;
            p_Writer.Write(s_Value);
            return true;
        }

        private bool SerializeTimestamp(RimeWriter p_Writer)
        {
            var s_Value = (DbObjectTimestamp) Value;
            return s_Value.Serialize(p_Writer);
        }

        private bool SerializeRecordId(RimeWriter p_Writer)
        {
            var s_Value = (RecordId) Value;
            return s_Value.Serialize(p_Writer);
        }

        private bool SerializeGuid(RimeWriter p_Writer)
        {
            var s_Value = (GUID) Value;
            return s_Value.Serialize(p_Writer);
        }

        private bool SerializeSha1(RimeWriter p_Writer)
        {
            var s_Value = (Sha1) Value;
            return s_Value.Serialize(p_Writer);
        }

        private bool SerializeBlob(RimeWriter p_Writer)
        {
            var s_Value = (byte[]) Value;
            p_Writer.Encode7Bit((uint) s_Value.Length);
            p_Writer.Write(s_Value);
            return true;
        }

        private bool SerializeAttachment(RimeWriter p_Writer)
        {
            var s_Value = (Sha1) Value;
            return s_Value.Serialize(p_Writer);

            throw new NotImplementedException();
            // TODO: Do we need to handle this differently.
        }

        private bool SerializeTimespan(RimeWriter p_Writer)
        {
            var s_Value = (DbObjectTimespan) Value;
            return s_Value.Serialize(p_Writer);
        }

        private bool SerializeUnknown()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
