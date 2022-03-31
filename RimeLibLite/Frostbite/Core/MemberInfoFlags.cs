using System;
using RimeLib.IO;

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
            return (FieldType)((FlagBits >> (ushort) MemberInfoFlagsEnum.TypeCodeShift) & (ushort) MemberInfoFlagsEnum.TypeCodeMask);
        }

        /// <summary>
        /// Gets the Frostbite member type
        /// </summary>
        /// <returns>Member type</returns>
        public MemberType GetMemberType()
        {
            return (MemberType)(FlagBits & (ushort) MemberInfoFlagsEnum.MemberTypeMask);
        }

        /// <summary>
        /// Gets the Frostbite type category
        /// </summary>
        /// <returns>Type category</returns>
        public TypeCategory GetTypeCategory()
        {
            return (TypeCategory)((FlagBits >> (ushort) MemberInfoFlagsEnum.TypeCategoryShift) & (ushort) MemberInfoFlagsEnum.TypeCategoryMask);
        }

        public void SetIsClass(bool p_IsField)
        {
            if (p_IsField)
                FlagBits = (ushort)MemberType.Field;
            else
                FlagBits = (ushort)MemberType.TypeInfo;

            FlagBits |= (ushort)TypeCategory.Class << (ushort)MemberInfoFlagsEnum.TypeCategoryShift;
            FlagBits |= (ushort)FieldType.Class << (ushort)MemberInfoFlagsEnum.TypeCodeShift;
        }

        public void SetIsValueType(bool p_IsField)
        {
            if (p_IsField)
                FlagBits = (ushort)MemberType.Field;
            else
                FlagBits = (ushort)MemberType.TypeInfo;

            FlagBits |= (ushort)TypeCategory.ValueType << (ushort)MemberInfoFlagsEnum.TypeCategoryShift;
            FlagBits |= (ushort)FieldType.ValueType << (ushort)MemberInfoFlagsEnum.TypeCodeShift;
        }

        public void SetIsPrimitive(bool p_IsField, Type p_PrimitiveType)
        {
            if (p_IsField)
                FlagBits = (ushort)MemberType.Field;
            else
                FlagBits = (ushort)MemberType.TypeInfo;

            if (p_PrimitiveType.IsEnum)
            {
                FlagBits |= (ushort)TypeCategory.ValueType << (ushort)MemberInfoFlagsEnum.TypeCategoryShift;
                FlagBits |= (ushort)FieldType.Enum << (ushort)MemberInfoFlagsEnum.TypeCodeShift;
                return;
            }

            FlagBits |= (ushort)TypeCategory.PrimitiveType << (ushort)MemberInfoFlagsEnum.TypeCategoryShift;

            if (p_PrimitiveType == typeof(bool))
                FlagBits |= (ushort)FieldType.Boolean << (ushort)MemberInfoFlagsEnum.TypeCodeShift;
            else if (p_PrimitiveType == typeof(sbyte))
                FlagBits |= (ushort)FieldType.Int8 << (ushort)MemberInfoFlagsEnum.TypeCodeShift;
            else if (p_PrimitiveType == typeof(byte))
                FlagBits |= (ushort)FieldType.UInt8 << (ushort)MemberInfoFlagsEnum.TypeCodeShift;
            else if (p_PrimitiveType == typeof(short))
                FlagBits |= (ushort)FieldType.Int16 << (ushort)MemberInfoFlagsEnum.TypeCodeShift;
            else if (p_PrimitiveType == typeof(ushort))
                FlagBits |= (ushort)FieldType.UInt16 << (ushort)MemberInfoFlagsEnum.TypeCodeShift;
            else if (p_PrimitiveType == typeof(int))
                FlagBits |= (ushort)FieldType.Int32 << (ushort)MemberInfoFlagsEnum.TypeCodeShift;
            else if (p_PrimitiveType == typeof(uint))
                FlagBits |= (ushort)FieldType.UInt32 << (ushort)MemberInfoFlagsEnum.TypeCodeShift;
            else if (p_PrimitiveType == typeof(long))
                FlagBits |= (ushort)FieldType.Int64 << (ushort)MemberInfoFlagsEnum.TypeCodeShift;
            else if (p_PrimitiveType == typeof(ulong))
                FlagBits |= (ushort)FieldType.UInt64 << (ushort)MemberInfoFlagsEnum.TypeCodeShift;
            else if (p_PrimitiveType == typeof(float))
                FlagBits |= (ushort)FieldType.Float32 << (ushort)MemberInfoFlagsEnum.TypeCodeShift;
            else if (p_PrimitiveType == typeof(double))
                FlagBits |= (ushort)FieldType.Float64 << (ushort)MemberInfoFlagsEnum.TypeCodeShift;
            else if (p_PrimitiveType == typeof(string))
                FlagBits |= (ushort)FieldType.CString << (ushort)MemberInfoFlagsEnum.TypeCodeShift;
            else if (p_PrimitiveType == typeof(GUID))
                FlagBits |= (ushort)FieldType.Guid << (ushort)MemberInfoFlagsEnum.TypeCodeShift;
            else
                throw new Exception($"Unsupported primitive type '{p_PrimitiveType}'.");
        }

        public void SetIsVoid()
        {
            FlagBits = (ushort)MemberType.Field;
            FlagBits |= (ushort)TypeCategory.NotApplicable << (ushort)MemberInfoFlagsEnum.TypeCategoryShift;
            FlagBits |= (ushort)FieldType.Void << (ushort)MemberInfoFlagsEnum.TypeCodeShift;
        }

        public void SetIsArray(bool p_IsField)
        {
            if (p_IsField)
                FlagBits = (ushort)MemberType.Field;
            else
                FlagBits = (ushort)MemberType.TypeInfo;

            FlagBits |= (ushort)TypeCategory.NotApplicable << (ushort)MemberInfoFlagsEnum.TypeCategoryShift;
            FlagBits |= (ushort)FieldType.Array << (ushort)MemberInfoFlagsEnum.TypeCodeShift;
        }

        public void SetHomogenous()
        {
            FlagBits |= (ushort)MemberInfoFlagsEnum.Homogeneous;
        }

        public void SetLayoutImmutable()
        {
            FlagBits |= (ushort)MemberInfoFlagsEnum.LayoutImmutable;
        }

        public void SetBlittable()
        {
            FlagBits |= (ushort)MemberInfoFlagsEnum.Blittable;
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
        public override bool Equals(object? obj)
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

        public void Deserialize(RimeReader p_Reader)
        {
            FlagBits = p_Reader.ReadUInt16();
        }
    }
}
