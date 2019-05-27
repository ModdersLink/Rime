using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using RimeLib.IO;

namespace RimeLib.Frostbite.Db
{
    /// <summary>
    /// Implementation of fb::DbObject
    /// </summary>
    [JsonConverter(typeof(DbObjectJsonConverter))]
    public class DbObject : IFbSerializable
    {
        private readonly List<DbObjectElement> m_Elements = new List<DbObjectElement>();
        //private Dictionary<string, DbObjectElement> m_elements = new Dictionary<string,DbObjectElement>(StringComparer.InvariantCultureIgnoreCase);

        /// <summary>
        /// Indexer into the dbobject by integer
        /// </summary>
        /// <param name="p_Index">Integer indexer</param>
        /// <returns>Object element into this object</returns>
        public DbObjectElement this[int p_Index] => m_Elements[p_Index];

        /// <summary>
        /// Indexer into the dboject by string
        /// </summary>
        /// <param name="p_Key">String key</param>
        /// <returns>Object element by string in this object</returns>
        public DbObjectElement this[string p_Key]
        {
            get { return m_Elements.FirstOrDefault(p_T => StringComparer.InvariantCultureIgnoreCase.Equals(p_Key, p_T.FieldName)); }
        }

        /// <summary>
        /// Gets the count of elements in this object
        /// </summary>
        public int Count => m_Elements.Count;

        /// <summary>
        /// Does this object have any elements
        /// </summary>
        public bool Null => m_Elements?.Any() ?? false;

        /// <summary>
        /// Default constructor
        /// </summary>
        public DbObject()
        {
            m_Elements = new List<DbObjectElement>();
        }

        /// <summary>
        /// Constructor that reads a dbobject from an opened reader
        /// </summary>
        /// <param name="p_Reader">Reader opened to the position of a dbobject</param>
        public DbObject(RimeReader p_Reader)
        {
            if (p_Reader.Length - p_Reader.Position == 0)
                throw new IndexOutOfRangeException();

            while (p_Reader.Length - p_Reader.Position > 0)
            {
                var s_Element = new DbObjectElement(p_Reader);

                if (s_Element.Type == DbObjectType.Eoo)
                    break;

                m_Elements.Add(s_Element);
            }
        }

        /// <summary>
        /// Constructor that reads a dbobject from and opened reader with provided length
        /// </summary>
        /// <param name="p_Reader">Reader opened to the position of the dbobject</param>
        /// <param name="p_Length">Length of the data to read</param>
        public DbObject(RimeReader p_Reader, long p_Length)
        {
            var s_EndOffset = p_Reader.Position + p_Length;

            if (s_EndOffset - p_Reader.Position == 0)
                throw new IndexOutOfRangeException();

            while (s_EndOffset - p_Reader.Position > 0)
            {
                var s_Element = new DbObjectElement(p_Reader);

                if (s_Element.Type == DbObjectType.Eoo)
                    continue;

                m_Elements.Add(s_Element);
            }
        }

        /// <summary>
        /// Does this object have a specified key
        /// </summary>
        /// <param name="p_Key">Element key to search for</param>
        /// <returns>True if specified key is found, false otherwise</returns>
        public bool HasKey(string p_Key)
        {
            return m_Elements.Any(p_Element => p_Element.FieldName.Equals(p_Key, StringComparison.InvariantCultureIgnoreCase));
        }

        /// <summary>
        /// Get the element for a specific field key.
        /// </summary>
        /// <typeparam name="T">The type of the element</typeparam>
        /// <param name="p_Key">The field key</param>
        /// <returns>The associated element</returns>
        public DbObjectElement<T> GetByKey<T>(string p_Key)
        {
            var s_Element = m_Elements.First(p_Element => p_Element.FieldName.Equals(p_Key, StringComparison.InvariantCultureIgnoreCase));

            if (!s_Element.TryGetSpecialization<T>(out var s_SpecializedElement))
                throw new Exception("Could not get element of expected type.");

            return s_SpecializedElement;
        }

        /// <summary>
        /// Tries to get the element for a specific field key.
        /// </summary>
        /// <typeparam name="T">The type of the element</typeparam>
        /// <param name="p_Key">The field key</param>
        /// <param name="p_Value">The associated element</param>
        /// <returns>True if the element was found and was of the right type, false otherwise.</returns>
        public bool TryGetByKey<T>(string p_Key, out DbObjectElement<T>? p_Value)
        {
            var s_Element = m_Elements.FirstOrDefault(p_Element => p_Element.FieldName.Equals(p_Key, StringComparison.InvariantCultureIgnoreCase));
            p_Value = null;

            if (s_Element == null)
                return false;

            return s_Element.TryGetSpecialization(out p_Value);
        }

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns>DbObject serialized in json format</returns>
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }

        /// <summary>
        /// Writes this dbobject to an opened writer
        /// </summary>
        /// <param name="p_Writer">Writer opened to the position of a dbobject</param>
        /// <returns>True on success, false otherwise</returns>
        public bool Serialize(RimeWriter p_Writer)
        {
            foreach (var s_Element in m_Elements)
                s_Element.Serialize(p_Writer);

            return true;
        }

        public bool Serialize(out byte[] p_Data)
        {
            p_Data = new byte[0];

            var s_Stream = new MemoryStream();

            using (var s_Writer = new RimeWriter(s_Stream))
            {
                foreach (var s_Element in m_Elements)
                    if (!s_Element.Serialize(s_Writer))
                        return false;

                p_Data = s_Stream.ToArray();
            }

            return true;
        }

        /// <summary>
        /// Serializes this dbobject to a byte array
        /// </summary>
        /// <returns>Byte array containing the serialized data</returns>
        public byte[] Serialize()
        {
            using (var s_Writer = new RimeWriter(new MemoryStream()))
            {
                if (!Serialize(s_Writer))
                    throw new Exception("DbObject serialization failed.");

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

        /// <summary>
        /// Adds and element to this dbobject
        /// </summary>
        /// <param name="p_NewElement">Filled out DbObjectElement structure</param>
        /// <returns>True on success, false otherwise</returns>
        public bool AddElement(DbObjectElement p_NewElement)
        {
            if (!string.IsNullOrWhiteSpace(p_NewElement.FieldName) && m_Elements.Any(p_Element => p_Element.FieldName == p_NewElement.FieldName))
                return false;

            m_Elements.Add(p_NewElement);

            return true;
        }
    }
}
