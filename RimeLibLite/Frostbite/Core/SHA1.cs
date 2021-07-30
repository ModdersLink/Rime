using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using RimeLib.IO;

// Testing

namespace RimeLib.Frostbite.Core
{
    /// <summary>
    /// Implementation of fb::Sha1
    /// </summary>
    [Serializable]
    public class Sha1 : ISerializable, IFbSerializable
    {
        /// <summary>
        /// Sha1 hash in byte array
        /// </summary>
        public byte[] Hash { get; private set; } = new byte[20];

        /// <summary>
        /// Default constructor
        /// </summary>
        public Sha1()
        {
        }

        /// <summary>
        /// Constructor that reads a sha1 object from an opened reader
        /// </summary>
        /// <param name="p_Reader">Reader opened to the position of a sha1 object</param>
        public Sha1(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }

        /// <summary>
        /// Constructor to create a sha1 from a hex string (no dashes or spaces)
        /// </summary>
        /// <param name="p_ParseString">Hex string of a sha1</param>
        public Sha1(string p_ParseString)
        {
            if (p_ParseString.Length != 40)
                return;

            Hash = Enumerable.Range(0, p_ParseString.Length)
                .Where(p_X => p_X % 2 == 0)
                .Select(p_X => Convert.ToByte(p_ParseString.Substring(p_X, 2), 16))
                .ToArray();
        }

        /// <summary>
        /// Constructor by passing a sha1 byte array
        /// </summary>
        /// <param name="p_Sha">Byte array with a length of 20 representing a sha1 object</param>
        public Sha1(byte[] p_Sha)
        {
            if (p_Sha.Length != 20)
                throw new ArgumentException("Data is not the correct length of a SHA1 hash.");

            Hash = p_Sha;
        }

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns>Hex string of the hash</returns>
        public override string ToString()
        {
            return Regex.Replace(BitConverter.ToString(Hash), @"[\0\-]", "", RegexOptions.None);
        }
        
        /// <summary>
        /// Sha1 equals
        /// </summary>
        /// <param name="p_Obj">Object to compare to this hash</param>
        /// <returns>True if equal, false otherwise</returns>
        public override bool Equals(object? p_Obj)
        {
            if (p_Obj is Sha1 s_Sha1)
                return Hash.SequenceEqual(s_Sha1.Hash);
            
            return false;
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // TODO: Optimize this. It's not very efficient.
            var s_HashCode = Hash.Aggregate(0, (p_Current, p_Byte) => p_Current + p_Byte);
            s_HashCode = (s_HashCode % int.MaxValue);
            return s_HashCode;
        }

        /// <summary>
        /// Gets the object data
        /// </summary>
        /// <param name="p_Info">Serialization information</param>
        /// <param name="p_Context">Streaming context</param>
        public virtual void GetObjectData(SerializationInfo p_Info, StreamingContext p_Context)
        {
            p_Info.AddValue("fb::Sha1", ToString(), typeof(string));
        }

        /// <summary>
        /// Writes the sha1 hash to an opened writer
        /// </summary>
        /// <param name="p_Writer">Writer opened to the position to where the hash is going to be written</param>
        /// <returns>True on success, false otherwise</returns>
        public bool Serialize(RimeWriter p_Writer)
        {
            if (Hash.Length != 20)
                return false;

            p_Writer.Write(Hash);
            return true;
        }

        /// <summary>
        /// Serializes the hash to a byte array
        /// </summary>
        /// <returns>Byte array containing the sha1 hash</returns>
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
            Hash = p_Reader.ReadBytes(20);
        }

        public void Deserialize(byte[] p_Data)
        {
            throw new NotImplementedException();
        }
    }
}
