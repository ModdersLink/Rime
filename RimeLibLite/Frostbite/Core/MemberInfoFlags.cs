using System;
using RimeLib.IO;

namespace RimeLib.Frostbite.Core
{
   

    /// <summary>
    /// Implementation of fb::MemberInfoFlags
    /// </summary>
	public class MemberInfoFlags
    {
        /// <summary>
        /// Size of the member info flags
        /// </summary>
	    public static int SizeOf => 2;


        public MemberType Member { get; set; } = MemberType.Field;
        public TypeCategory Category { get; set; } = TypeCategory.NotApplicable;
        public FieldType Type { get; set; } = FieldType.Void;

        public bool Metadata { get; set; } = false;
        public bool Homogeneous { get; set; } = false;
        public bool AlwaysPersist { get; set; } = false;
        public bool Exposed { get; set; } = false;
        public bool LayoutImmutable { get; set; } = false;
        public bool Blittable { get; set; } = false;
        
     

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns>Flag bits as a string</returns>
        public override string ToString()
        {
            return $"({Member}, {Category}, {Type} | {Metadata}, {Homogeneous}, {AlwaysPersist}, {Exposed}, {LayoutImmutable}, {Blittable})";
        }


        
        public void SetIsClass(bool p_IsField)
        {
            if (p_IsField)
                Member = MemberType.Field;
            else
                Member = MemberType.TypeInfo;

            Category = TypeCategory.Class;
            Type = FieldType.Class;
        }

        public void SetIsValueType(bool p_IsField)
        {
            if (p_IsField)
                Member = MemberType.Field;
            else
                Member = MemberType.TypeInfo;

            Category = TypeCategory.ValueType;
            Type = FieldType.ValueType;
        }

        public void SetIsPrimitive(bool p_IsField, Type p_PrimitiveType)
        {
            if (p_IsField)
                Member = MemberType.Field;
            else
                Member = MemberType.TypeInfo;

            if (p_PrimitiveType.IsEnum)
            {
                Category = TypeCategory.ValueType;
                Type = FieldType.Enum;
                return;
            }

            Category = TypeCategory.PrimitiveType;

            if (p_PrimitiveType == typeof(bool))
                Type = FieldType.Boolean;
            else if (p_PrimitiveType == typeof(sbyte))
                Type = FieldType.Int8;
            else if (p_PrimitiveType == typeof(byte))
                Type = FieldType.UInt8;
            else if (p_PrimitiveType == typeof(short))
                Type = FieldType.Int16;
            else if (p_PrimitiveType == typeof(ushort))
                Type = FieldType.UInt16;
            else if (p_PrimitiveType == typeof(int))
                Type = FieldType.Int32;
            else if (p_PrimitiveType == typeof(uint))
                Type = FieldType.UInt32;
            else if (p_PrimitiveType == typeof(long))
                Type = FieldType.Int64;
            else if (p_PrimitiveType == typeof(ulong))
                Type = FieldType.UInt64;
            else if (p_PrimitiveType == typeof(float))
                Type = FieldType.Float32;
            else if (p_PrimitiveType == typeof(double))
                Type = FieldType.Float64;
            else if (p_PrimitiveType == typeof(string))
                Type = FieldType.CString;
            else if (p_PrimitiveType == typeof(GUID))
                Type = FieldType.Guid;
            else
                throw new Exception($"Unsupported primitive type '{p_PrimitiveType}'.");
        }

        public void SetIsVoid()
        {
            Member = MemberType.Field;
            Category = TypeCategory.NotApplicable;
            Type = FieldType.Void;
        }

        public void SetIsArray(bool p_IsField)
        {
            if (p_IsField)
                Member = MemberType.Field;
            else
                Member = MemberType.TypeInfo;

            Category = TypeCategory.NotApplicable;
            Type = FieldType.Array;
        }

        public void SetHomogenous()
        {
            Homogeneous = true;
        }

        public void SetLayoutImmutable()
        {
            LayoutImmutable = true;
        }

        public void SetBlittable()
        {
            Blittable = true;
        }

        /// <summary>
        /// Flag comparison
        /// </summary>
        /// <param name="other">Other flags</param>
        /// <returns>True if equal, false otherwise</returns>
        protected bool Equals(MemberInfoFlags other)
        {
            return Member.Equals(other.Member) &&
                   Category.Equals(other.Category) &&
                   Type.Equals(other.Type) &&

                   Metadata == other.Metadata &&
                   Homogeneous == other.Homogeneous &&
                   AlwaysPersist == other.Homogeneous &&
                   Exposed == other.Homogeneous &&
                   LayoutImmutable == other.Homogeneous &&
                   Blittable == other.Homogeneous;
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
            return 11*Member.GetHashCode() +
                   17*Category.GetHashCode() +
                   23*Type.GetHashCode() +
                   
                   29*Metadata.GetHashCode() +
                   37*Homogeneous.GetHashCode() +
                   47*AlwaysPersist.GetHashCode() +
                   59*Exposed.GetHashCode() +
                   71*LayoutImmutable.GetHashCode() +
                   89*Blittable.GetHashCode();
            
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
    }
}
