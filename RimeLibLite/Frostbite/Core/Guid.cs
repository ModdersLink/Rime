using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Json;

namespace RimeLib.Frostbite.Core
{
    /// <summary>
    /// Implementation of fb::Guid
    /// </summary>
    [Serializable, JsonConverter(typeof(GuidJsonConverter)), TypeConverter(typeof(GuidTypeConverter))]
    public class GUID : ISerializable, IFbSerializable, IComparable<GUID>
    {
        /// <summary>
        /// Internal size of the structure.
        /// </summary>
        public static int SizeOf => 16;
        
        public static GUID Empty = new();

        private Guid m_Guid;

        /// <summary>
        /// Default constructor
        /// </summary>
        public GUID()
        {
            m_Guid = Guid.Empty;
        }

        /// <summary>
        /// Constructor that reads a guid from an opened reader
        /// </summary>
        /// <param name="p_Reader"></param>
        public GUID(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }

        /// <summary>
        /// Constructor taking a string representation of a guid
        /// </summary>
        /// <param name="p_ParseString">String representation of guid</param>
        public GUID(string p_ParseString)
        {
            if (!Guid.TryParse(p_ParseString, out m_Guid))
                throw new FormatException("The specified GUID is not in a recognized format.");
        }

        /// <summary>
        /// Constructor for assigning a System.Guid to a frostbite guid
        /// </summary>
        /// <param name="p_Guid"></param>
        public GUID(Guid p_Guid)
        {
            m_Guid = p_Guid;
            SetCompressionFlag(false);
        }

        /// <summary>
        /// TODO: Documentation
        /// 
        /// Currently unimplemented
        /// </summary>
        /// <param name="p_Info"></param>
        /// <param name="p_Context"></param>
        protected GUID(SerializationInfo p_Info, StreamingContext p_Context)
        {
            // TODO: Figure out what the hell to do here
            throw new NotImplementedException();

            //m_Guid = (Guid)info.GetValue("field", typeof(Guid));
        }

        /// <summary>
        /// Internal bytes of a guid structure
        /// </summary>
        public byte[] Id => m_Guid.ToByteArray();

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns>Returns a guid in "N" format</returns>
        public override string ToString()
        {
            return m_Guid.ToString("D");
		}

        /// <summary>
        /// ToString
        /// </summary>
        /// <param name="p_Format">Format to return the guid structure in</param>
        /// <returns>Guid string representation</returns>
		public string ToString(string p_Format)
		{
			return m_Guid.ToString(p_Format);
		}

        /// <summary>
        /// Implicit cast from a System.Guid
        /// </summary>
        /// <param name="p_Guid">System.Guid to cast from</param>
        public static implicit operator GUID(Guid p_Guid)
        {
            return new GUID(p_Guid);
        }

		//public string Dashes => m_Guid.ToString("D");

        /// <summary>
        /// Guid equals
        /// </summary>
        /// <param name="p_G1">First guid</param>
        /// <param name="p_G2">Second guid</param>
        /// <returns>True if equal, false otherwise</returns>
		public static bool operator ==(GUID? p_G1, GUID? p_G2)
        {
            if (ReferenceEquals(p_G1, p_G2))
                return true;

            if (p_G1 is null && p_G2 is null)
                return true;

            if (p_G1 is null || p_G2 is null)
                return false;

            return p_G1.m_Guid == p_G2.m_Guid;
        }

        /// <summary>
        /// Guid not equals
        /// </summary>
        /// <param name="p_G1">First guid</param>
        /// <param name="p_G2">Second guid</param>
        /// <returns>True if not equal, false otherwise</returns>
        public static bool operator !=(GUID p_G1, GUID p_G2)
        {
            return p_G1.m_Guid != p_G2.m_Guid;
        }

        /// <summary>
        /// Guid equals
        /// </summary>
        /// <param name="p_G1">First guid</param>
        /// <param name="p_G2">Second guid</param>
        /// <returns>True if equal, false otherwise</returns>
        public static bool operator ==(GUID p_G1, Guid p_G2)
        {
            return p_G1.m_Guid == p_G2;
        }

        /// <summary>
        /// Guid not equals
        /// </summary>
        /// <param name="p_G1">First guid</param>
        /// <param name="p_G2">Second guid</param>
        /// <returns>True if not equal, false otherwise</returns>
        public static bool operator !=(GUID p_G1, Guid p_G2)
        {
            return p_G1.m_Guid != p_G2;
        }

        public int CompareTo(GUID? p_Other)
        {
            if (p_Other == null)
                return 1;

            // ReSharper disable once StringCompareToIsCultureSpecific
            return m_Guid.CompareTo(p_Other.m_Guid);
        }

        /// <summary>
        /// Equals
        /// </summary>
        /// <param name="p_Obj">Object to compare</param>
        /// <returns>True if equal, false otherwise</returns>
        public override bool Equals(object? p_Obj)
        {
            if (ReferenceEquals(this, p_Obj)) 
                return true;

            switch (p_Obj)
            {
                case GUID s_GUID:
                    return s_GUID == this;

                case Guid s_GUID:
                    return s_GUID == m_Guid;

                default:
                    return false;
            }
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            return m_Guid.GetHashCode();
        }

        /// <summary>
        /// Gets object data
        /// </summary>
        /// <param name="p_Info">Serialization Information</param>
        /// <param name="p_Context">Streaming Context</param>
        public virtual void GetObjectData(SerializationInfo p_Info, StreamingContext p_Context)
        {
            p_Info.AddValue("fb::Guid", ToString(), typeof(string));
        }

        /// <summary>
        /// Writes the guid to an opened writer
        /// </summary>
        /// <param name="p_Writer">Writer opened to the position of a guid</param>
        /// <returns>True on success, false otherwise</returns>
        public bool Serialize(RimeWriter p_Writer)
        {
            // TODO: This is invalid due to endianness. ToByteArray() always encodes in little-endian.
            p_Writer.Write(m_Guid.ToByteArray());
            return true;
        }

        /// <summary>
        /// Serializes the guid to a byte array
        /// </summary>
        /// <returns>Byte array containing the data of this guid</returns>
        public bool Serialize(out byte[] p_Data)
        {
            p_Data = new byte[0];

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
            m_Guid = new Guid(p_Reader.ReadInt32(), p_Reader.ReadInt16(), p_Reader.ReadInt16(), p_Reader.ReadBytes(8));
        }

        public void Deserialize(byte[] p_Data)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Checks if the guid has the compression flag set.
        /// </summary>
        /// <returns>Whether the compression flag is set or not.</returns>
        public bool HasCompressionFlag()
        {
            if (!Serialize(out var s_Data))
                return false;

            return (s_Data[15] & 0x01) != 0;
        }

        /// <summary>
        /// Sets the compression flag for this guid.
        /// </summary>
        /// <param name="p_Compressed">Compression flag</param>
        public void SetCompressionFlag(bool p_Compressed)
        {
            if (!Serialize(out var s_Data))
                return;

            if (p_Compressed)
                s_Data[15] |= 0x01;
            else
                s_Data[15] &= 0xFE;

            using (var s_Reader = new RimeReader(new MemoryStream(s_Data)))
                Deserialize(s_Reader);
        }
    }
}