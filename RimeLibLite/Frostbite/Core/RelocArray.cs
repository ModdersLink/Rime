using System;
using RimeLib.IO;

namespace RimeLib.Frostbite.Core
{
    /// <summary>
    /// Implementation of fb::RelocArray
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class RelocArray<T> : IFbSerializable
    {
        /// <summary>
        /// Count of how many items are in the array
        /// </summary>
        public uint Count { get; set; }

        /// <summary>
        /// Base offset in file where the array starts
        /// </summary>
        public ulong BaseAddress { get; set; }

        readonly Array<T> m_Objects;

        /// <summary>
        /// Indexer into the array
        /// </summary>
        public T[] Get => m_Objects?.AsArray;

        /// <summary>
        /// Default constructor
        /// </summary>
        public RelocArray()
        {
            // Fuck yo couch
        }

        /// <summary>
        /// Constructor reading a array from an opened stream
        /// </summary>
        /// <param name="p_Reader">Reader opened to the position of a reloc array</param>
        public RelocArray(RimeReader p_Reader)
        {
            m_Objects = new Array<T>();
            
            Count = p_Reader.ReadUInt32();
            BaseAddress = p_Reader.ReadUInt64();

            if (BaseAddress == 0)
                return;

            // Save current offset
            var s_CurrentOffset = p_Reader.BaseStream.Position;

            p_Reader.BaseStream.Position = (long)BaseAddress;

            for (var i = 0; i < Count; ++i)
            {
                T s_Object;
                var s_Type = typeof(T);
                
                // Builtin FieldType
                switch (Type.GetTypeCode(s_Type))
                {
                    case TypeCode.String:
                        s_Object = (T) Convert.ChangeType(p_Reader.ReadNullTerminatedString(), typeof(T)); // This could be problematic later, time will tell
                        break;

                    case TypeCode.Boolean:
                        s_Object = (T) Convert.ChangeType(p_Reader.ReadByte(), typeof(T));
                        break;

                    case TypeCode.Byte:
                        s_Object = (T) Convert.ChangeType(p_Reader.ReadByte(), typeof(T));
                        break;

                    case TypeCode.SByte:
                        s_Object = (T) Convert.ChangeType(p_Reader.ReadSByte(), typeof(T));
                        break;

                    case TypeCode.Char:
                        s_Object = (T) Convert.ChangeType(p_Reader.ReadChar(), typeof(T));
                        break;

                    case TypeCode.Decimal:
                        s_Object = (T) Convert.ChangeType(p_Reader.ReadDecimal(), typeof(T));
                        break;

                    case TypeCode.Double:
                        s_Object = (T) Convert.ChangeType(p_Reader.ReadDouble(), typeof(T));
                        break;

                    case TypeCode.Single:
                        s_Object = (T) Convert.ChangeType(p_Reader.ReadSingle(), typeof(T));
                        break;

                    case TypeCode.Int32:
                        s_Object = (T) Convert.ChangeType(p_Reader.ReadInt32(), typeof(T));
                        break;

                    case TypeCode.UInt32:
                        s_Object = (T) Convert.ChangeType(p_Reader.ReadUInt32(), typeof(T));
                        break;

                    case TypeCode.Int64:
                        s_Object = (T) Convert.ChangeType(p_Reader.ReadInt64(), typeof(T));
                        break;

                    case TypeCode.UInt64:
                        s_Object = (T) Convert.ChangeType(p_Reader.ReadUInt64(), typeof(T));
                        break;

                    case TypeCode.Int16:
                        s_Object = (T) Convert.ChangeType(p_Reader.ReadInt16(), typeof(T));
                        break;

                    case TypeCode.UInt16:
                        s_Object = (T) Convert.ChangeType(p_Reader.ReadUInt16(), typeof(T));
                        break;

                    case TypeCode.Object:
                        // Check if IFbSerializable this is an IFbSerializable.
                        if (!s_Type.IsSubclassOf(typeof(IFbSerializable)))
                        {
                            // TODO: Exception message
                            throw new NotImplementedException();
                        }

                        s_Object = (T) Activator.CreateInstance(typeof(T), new object[] { });
                        ((IFbSerializable) s_Object).Deserialize(p_Reader);

                        break;

                    default:
                        // TODO: Exception message
                        throw new NotImplementedException();
                }

                m_Objects.Add(s_Object);
            }

            // Reset the position
            p_Reader.BaseStream.Position = s_CurrentOffset;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_Writer"></param>
        public void Serialize(RimeWriter p_Writer)
        {
            p_Writer.Write(Count);
            p_Writer.Write(BaseAddress);
        }

        public byte[] Serialize()
        {
            throw new NotImplementedException();
        }

        public void Deserialize(RimeReader p_Reader)
        {
            throw new NotImplementedException();
        }

        public void Deserialize(byte[] p_Data)
        {
            throw new NotImplementedException();
        }
    }
}
