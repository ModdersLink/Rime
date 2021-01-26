using System;
using RimeLib.IO;

namespace RimeLib.Frostbite.Core
{
    /// <summary>
    /// Implementation of fb::RelocPtr
    /// </summary>
    /// <typeparam name="T">Type that this reloc pointer points to</typeparam>
    public class RelocPtr<T> : IFbSerializable
    {
        /// <summary>
        /// Base address of the relocptr
        /// </summary>
        public ulong BaseAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public T Object { get; }

        /// <summary>
        /// Constructor that takes an opened reader to read out a RelocPtr
        /// </summary>
        /// <param name="p_Reader">Reader opened to the position of RelocPtr</param>
        public RelocPtr(RimeReader p_Reader)
        {
            Object = DeserializeObject(p_Reader);
        }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public RelocPtr()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
#pragma warning disable CS8601 // Possible null reference assignment.
            Object = default;
#pragma warning restore CS8601 // Possible null reference assignment.
            BaseAddress = 0;
        }

        public bool Serialize(RimeWriter p_Writer)
        {
            throw new NotImplementedException();
        }

        public bool Serialize(out byte[] p_Data)
        {
            throw new NotImplementedException();
        }

        public void Deserialize(RimeReader p_Reader)
        {
            DeserializeObject(p_Reader);
        }

        public T DeserializeObject(RimeReader p_Reader)
        {
            BaseAddress = p_Reader.ReadUInt32();
            p_Reader.ReadUInt32();

            if (BaseAddress == 0)
            {
#pragma warning disable CS8603
                return default(T);
#pragma warning restore CS8603
            }

            // Save the offset
            var s_CurOffset = p_Reader.Position;

            try
            {
                // We will need to create a new instance of the class we want here, so lets start...
                // Set the position to where we need to go
                p_Reader.Seek((long) BaseAddress, System.IO.SeekOrigin.Begin);

                // Get the current type
                var s_Type = typeof(T);

                switch (Type.GetTypeCode(s_Type))
                {
                    case TypeCode.String:
                        return (T) Convert.ChangeType(p_Reader.ReadNullTerminatedString(), typeof(T)); // This could be problematic later, time will tell

                    case TypeCode.Boolean:
                        return (T) Convert.ChangeType(p_Reader.ReadUByte(), typeof(T));

                    case TypeCode.Byte:
                        return (T) Convert.ChangeType(p_Reader.ReadUByte(), typeof(T));

                    case TypeCode.SByte:
                        return (T) Convert.ChangeType(p_Reader.ReadSByte(), typeof(T));

                    case TypeCode.Char:
                        return (T) Convert.ChangeType(p_Reader.ReadChar(), typeof(T));

                    case TypeCode.Decimal:
                        return (T) Convert.ChangeType(p_Reader.ReadDecimal(), typeof(T));

                    case TypeCode.Double:
                        return (T) Convert.ChangeType(p_Reader.ReadDouble(), typeof(T));

                    case TypeCode.Single:
                        return (T) Convert.ChangeType(p_Reader.ReadSingle(), typeof(T));

                    case TypeCode.Int32:
                        return (T) Convert.ChangeType(p_Reader.ReadInt32(), typeof(T));

                    case TypeCode.UInt32:
                        return (T) Convert.ChangeType(p_Reader.ReadUInt32(), typeof(T));

                    case TypeCode.Int64:
                        return (T) Convert.ChangeType(p_Reader.ReadInt64(), typeof(T));

                    case TypeCode.UInt64:
                        return (T) Convert.ChangeType(p_Reader.ReadUInt64(), typeof(T));

                    case TypeCode.Int16:
                        return (T) Convert.ChangeType(p_Reader.ReadInt16(), typeof(T));

                    case TypeCode.UInt16:
                        return (T) Convert.ChangeType(p_Reader.ReadUInt16(), typeof(T));

                    case TypeCode.Object:
                        // Check if IFbSerializable this is an IFbSerializable.
                        if (!typeof(IFbSerializable).IsAssignableFrom(typeof(T)))
                        {
                            // TODO: Exception message
                            throw new NotImplementedException();
                        }

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                        var s_Val = (IFbSerializable) Activator.CreateInstance(typeof(T), new object[] { });
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                        s_Val.Deserialize(p_Reader);
#pragma warning restore CS8602 // Dereference of a possibly null reference.

                        return (T) s_Val;

                    default:
                        throw new NotImplementedException();
                }
            }
            finally
            {
                // Reset the position
                p_Reader.Seek(s_CurOffset, System.IO.SeekOrigin.Begin);
            }
        }

        public void Deserialize(byte[] p_Data)
        {
            throw new NotImplementedException();
        }
    }
}