using System;
using RimeLib.IO;

namespace RimeLib.Frostbite.Core
{
    /// <summary>Reads one element a <see cref="RelocArray{T}"/> or <see cref="RelocPtrArray{T}"/> points at.</summary>
    internal static class RelocElement
    {
        public static T Read<T>(RimeReader p_Reader)
        {
            var s_Type = typeof(T);
            if (s_Type == typeof(System.Numerics.Vector4))
                return (T)(object)p_Reader.ReadVector4();
            if (s_Type == typeof(System.Numerics.Matrix4x4))
                return (T)(object)p_Reader.ReadMatrix4x4();

            switch (Type.GetTypeCode(s_Type))
            {
                case TypeCode.String:
                    return (T)Convert.ChangeType(p_Reader.ReadNullTerminatedString(), s_Type); // This could be problematic later, time will tell
                case TypeCode.Boolean:
                case TypeCode.Byte:
                    return (T)Convert.ChangeType(p_Reader.ReadUByte(), s_Type);
                case TypeCode.SByte:
                    return (T)Convert.ChangeType(p_Reader.ReadSByte(), s_Type);
                case TypeCode.Char:
                    return (T)Convert.ChangeType(p_Reader.ReadChar(), s_Type);
                case TypeCode.Decimal:
                    return (T)Convert.ChangeType(p_Reader.ReadDecimal(), s_Type);
                case TypeCode.Double:
                    return (T)Convert.ChangeType(p_Reader.ReadDouble(), s_Type);
                case TypeCode.Single:
                    return (T)Convert.ChangeType(p_Reader.ReadSingle(), s_Type);
                case TypeCode.Int32:
                    return (T)Convert.ChangeType(p_Reader.ReadInt32(), s_Type);
                case TypeCode.UInt32:
                    return (T)Convert.ChangeType(p_Reader.ReadUInt32(), s_Type);
                case TypeCode.Int64:
                    return (T)Convert.ChangeType(p_Reader.ReadInt64(), s_Type);
                case TypeCode.UInt64:
                    return (T)Convert.ChangeType(p_Reader.ReadUInt64(), s_Type);
                case TypeCode.Int16:
                    return (T)Convert.ChangeType(p_Reader.ReadInt16(), s_Type);
                case TypeCode.UInt16:
                    return (T)Convert.ChangeType(p_Reader.ReadUInt16(), s_Type);
                case TypeCode.Object when typeof(IFbSerializable).IsAssignableFrom(s_Type):
                    var s_Object = (IFbSerializable)Activator.CreateInstance(s_Type)!;
                    s_Object.Deserialize(p_Reader);
                    return (T)s_Object;
                default:
                    throw new NotSupportedException($"Cannot read a {s_Type.Name} through a relocated pointer.");
            }
        }
    }
}
