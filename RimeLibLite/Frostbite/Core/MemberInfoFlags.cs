using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace RimeLib.Frostbite.Core
{
    public enum MemberInfoFlagsEnum
    {
        MemberTypeMask = 0x3,
        TypeCategoryShift = 0x2,
        TypeCategoryMask = 0x3,
        TypeCodeShift = 0x4,
        TypeCodeMask = 0x1F,
        Metadata = 0x800,
        Homogeneous = 0x1000,
        AlwaysPersist = 0x2000,
        Exposed = 0x2000,
        LayoutImmutable = 0x4000,
        Blittable = 0x8000,
    };

    public enum MemberTypeEnum
    {
        Field = 0x0,
        TypeInfo = 0x1,
    };

    public enum TypeCategoryEnum
    {
        NotApplicable = 0x0,
        Class = 0x1,
        ValueType = 0x2,
        PrimitiveType = 0x3,
    };

    /// <summary>
    /// Implementation of fb::MemberInfoFlags
    /// </summary>
	public class MemberInfoFlags
    {
        /// <summary>
        /// Size of the member info flags
        /// </summary>
	    public static int SizeOf => 2;

        /// <summary>
        /// Internal flag bits
        /// </summary>
        public ushort FlagBits { get; set; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public MemberInfoFlags(ushort p_Bits = 0)
        {
            FlagBits = p_Bits;
        }

        /// <summary>
        /// Constructor that reads flags from an opened reader
        /// </summary>
        /// <param name="p_Reader">Reader opened to the position of memberinfoflags</param>
        public MemberInfoFlags(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns>Flag bits as a string</returns>
        public override string ToString()
        {
            return FlagBits.ToString();
        }

        /// <summary>
        /// Gets the Frostbite Field Type
        /// </summary>
        /// <returns>Field type</returns>
        public FieldType GetFieldType()
        {
            return (FieldType)((FlagBits >> 4) & 0x1F);
        }

        /// <summary>
        /// Gets the Frostbite member type
        /// </summary>
        /// <returns>Member type</returns>
        public MemberType GetMemberType()
        {
            return (MemberType)(FlagBits & 3);
        }

        /// <summary>
        /// Gets the Frostbite type category
        /// </summary>
        /// <returns>Type category</returns>
        public TypeCategory GetTypeCategory()
        {
            return (TypeCategory)((FlagBits >> 2) & 3);
        }

        /// <summary>
        /// Flag comparison
        /// </summary>
        /// <param name="other">Other flags</param>
        /// <returns>True if equal, false otherwise</returns>
        protected bool Equals(MemberInfoFlags other)
        {
            return FlagBits == other.FlagBits;
        }

        /// <summary>
        /// Flag comparison
        /// </summary>
        /// <param name="obj">Other flag object</param>
        /// <returns>True if equal, false otherwise</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((MemberInfoFlags)obj);
        }

        /// <summary>
        /// Gets the has code for these flags
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            return FlagBits.GetHashCode();
        }

        /// <summary>
        /// Flag equals operator
        /// </summary>
        /// <param name="left">First flag</param>
        /// <param name="right">Second flag</param>
        /// <returns>True if equal, false otherwise</returns>
        public static bool operator ==(MemberInfoFlags left, MemberInfoFlags right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Flag not equals operator
        /// </summary>
        /// <param name="left">First flag</param>
        /// <param name="right">Second flag</param>
        /// <returns>True if equal, false otherwise</returns>
        public static bool operator !=(MemberInfoFlags left, MemberInfoFlags right)
        {
            return !Equals(left, right);
        }

        public void Serialize(RimeWriter p_Writer)
        {
            throw new System.NotImplementedException();
        }

        public byte[] Serialize()
        {
            throw new System.NotImplementedException();
        }

        public void Deserialize(RimeReader p_Reader)
        {
            FlagBits = p_Reader.ReadUInt16();
        }

        public void Deserialize(byte[] p_Data)
        {
            throw new System.NotImplementedException();
        }
    }
}
