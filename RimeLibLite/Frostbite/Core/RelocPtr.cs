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
        public T Get { get; private set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public RelocPtr()
        {
        }

        /// <summary>
        /// Constructor that takes an opened reader to read out a RelocPtr
        /// </summary>
        /// <param name="p_Reader">Reader opened to the position of RelocPtr</param>
        public RelocPtr(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }

        public void Serialize(RimeWriter p_Writer)
        {
            throw new NotImplementedException();
        }

        public byte[] Serialize()
        {
            throw new NotImplementedException();
        }

        public void Deserialize(RimeReader p_Reader)
        {
            BaseAddress = p_Reader.ReadUInt32();
            p_Reader.ReadUInt32();

            if (BaseAddress == 0)
                return;

            // Save the offset
            var s_CurOffset = p_Reader.BaseStream.Position;

            // We will need to create a new instance of the class we want here, so lets start...
            // Set the position to where we need to go
            p_Reader.BaseStream.Position = (long)BaseAddress;

            // Get the current type
            var s_Type = typeof(T);
            
            switch (Type.GetTypeCode(s_Type))
            {
                case TypeCode.String:
                    Get = (T) Convert.ChangeType(p_Reader.ReadNullTerminatedString(), typeof(T)); // This could be problematic later, time will tell
                    break;

                case TypeCode.Boolean:
                    Get = (T) Convert.ChangeType(p_Reader.ReadByte(), typeof(T));
                    break;

                case TypeCode.Byte:
                    Get = (T) Convert.ChangeType(p_Reader.ReadByte(), typeof(T));
                    break;

                case TypeCode.SByte:
                    Get = (T) Convert.ChangeType(p_Reader.ReadSByte(), typeof(T));
                    break;

                case TypeCode.Char:
                    Get = (T) Convert.ChangeType(p_Reader.ReadChar(), typeof(T));
                    break;

                case TypeCode.Decimal:
                    Get = (T) Convert.ChangeType(p_Reader.ReadDecimal(), typeof(T));
                    break;

                case TypeCode.Double:
                    Get = (T) Convert.ChangeType(p_Reader.ReadDouble(), typeof(T));
                    break;

                case TypeCode.Single:
                    Get = (T) Convert.ChangeType(p_Reader.ReadSingle(), typeof(T));
                    break;

                case TypeCode.Int32:
                    Get = (T) Convert.ChangeType(p_Reader.ReadInt32(), typeof(T));
                    break;

                case TypeCode.UInt32:
                    Get = (T) Convert.ChangeType(p_Reader.ReadUInt32(), typeof(T));
                    break;

                case TypeCode.Int64:
                    Get = (T) Convert.ChangeType(p_Reader.ReadInt64(), typeof(T));
                    break;

                case TypeCode.UInt64:
                    Get = (T) Convert.ChangeType(p_Reader.ReadUInt64(), typeof(T));
                    break;

                case TypeCode.Int16:
                    Get = (T) Convert.ChangeType(p_Reader.ReadInt16(), typeof(T));
                    break;

                case TypeCode.UInt16:
                    Get = (T) Convert.ChangeType(p_Reader.ReadUInt16(), typeof(T));
                    break;

                case TypeCode.Object:
                    // Check if IFbSerializable this is an IFbSerializable.
                    if (!s_Type.IsSubclassOf(typeof(IFbSerializable)))
                    {
                        // TODO: Exception message
                        throw new NotImplementedException();
                    }

                    Get = (T) Activator.CreateInstance(typeof(T), new object[] { });
                    ((IFbSerializable) Get).Deserialize(p_Reader);

                    break;

                default:
                    throw new NotImplementedException();
            }
            

            // Reset the position
            p_Reader.BaseStream.Position = s_CurOffset;
        }

        public void Deserialize(byte[] p_Data)
        {
            throw new NotImplementedException();
        }
    }
}
