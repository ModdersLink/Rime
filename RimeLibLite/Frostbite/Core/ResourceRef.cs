using System;
using System.IO;
using System.Runtime.Serialization;
using RimeLib.IO;

namespace RimeLib.Frostbite.Core
{
    /// <summary>
    /// fb::ResourceRef implementation
    /// </summary>
    public class ResourceRef : IFbSerializable, ISerializable
    {
        /// <summary>
        /// Internal structure
        /// </summary>
        public ulong Id { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public ResourceRef()
        {

        }

        /// <summary>
        /// Construct from a opened RimeReader
        /// </summary>
        /// <param name="p_Reader">Reader opened to the position of the ResourceRef</param>
        public ResourceRef(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }

        /// <summary>
        /// Constructor from Id
        /// </summary>
        /// <param name="p_Id">Id</param>
        public ResourceRef(ulong p_Id)
        {
            Id = p_Id;
        }

        /// <summary>
        /// TODO: Documentation
        /// </summary>
        /// <param name="p_Info"></param>
        /// <param name="p_Context"></param>
        protected ResourceRef(SerializationInfo p_Info, StreamingContext p_Context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Produces string representation of id in hex
        /// </summary>
        /// <returns>String of id in hex string</returns>
        public override string ToString()
        {
            return Id.ToString("X");
        }

        /// <summary>
        /// ToString with provided format
        /// </summary>
        /// <param name="p_Format">Format to produce the id (uint64)</param>
        /// <returns>String of id</returns>
        public string ToString(string p_Format)
        {
            return Id.ToString(p_Format);
        }

        /// <summary>
        /// TODO: Documentation
        /// </summary>
        /// <param name="p_Id"></param>
        public static implicit operator ResourceRef(ulong p_Id)
        {
            return new ResourceRef(p_Id);
        }

        /// <summary>
        /// Equals operator
        /// </summary>
        /// <param name="p_First">First</param>
        /// <param name="p_Second">Second</param>
        /// <returns>True if equal, false otherwise</returns>
        public static bool operator ==(ResourceRef p_First, ResourceRef p_Second)
        {
            if (ReferenceEquals(p_First, p_Second))
                return true;

            if (p_First is null || p_Second is null)
                return false;

            return p_First.Id == p_Second.Id;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_Left"></param>
        /// <param name="p_Right"></param>
        /// <returns></returns>
        public static bool operator !=(ResourceRef p_Left, ResourceRef p_Right)
        {
            if (p_Left is null || p_Right is null)
                return true;

            return p_Left.Id != p_Right.Id;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_Obj"></param>
        /// <returns></returns>
        public override bool Equals(object? p_Obj)
        {
            if (ReferenceEquals(null, p_Obj))
                return false;

            if (ReferenceEquals(this, p_Obj))
                return true;

            if (p_Obj is ResourceRef s_Ref)
                return s_Ref == this;

            return false;
        }

        /// <summary>
        /// Gets the hash code of the Id
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_Info"></param>
        /// <param name="p_Context"></param>
        public virtual void GetObjectData(SerializationInfo p_Info, StreamingContext p_Context)
        {
            p_Info.AddValue("fb::ResourceRef", ToString(), typeof(string));
        }

        /// <summary>
        /// Writes this ResourceRef to an opened writer
        /// </summary>
        /// <param name="p_Writer">Writer opened to the position where the ResourceRef is going</param>
        /// <returns>True always</returns>
        public bool Serialize(RimeWriter p_Writer)
        {
            p_Writer.Write(Id);
            return true;
        }

        /// <summary>
        /// Serializes to a byte array
        /// </summary>
        /// <returns>Bytes of the id</returns>
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
            Id = p_Reader.ReadUInt64();
        }

        public void Deserialize(byte[] p_Data)
        {
            throw new NotImplementedException();
        }
    }
}
