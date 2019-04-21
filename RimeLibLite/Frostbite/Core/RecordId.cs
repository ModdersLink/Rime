using System;
using System.IO;
using RimeLib.IO;

namespace RimeLib.Frostbite.Core
{
    /// <summary>
    /// Implementation for fb::RecordId
    /// </summary>
    public class RecordId : IFbSerializable
    {
        /// <summary>
        /// Extent ID
        /// </summary>
        public short ExtentId { get; set; }

        /// <summary>
        /// Page ID
        /// </summary>
        public short PageId { get; set; }

        /// <summary>
        /// Slot ID
        /// </summary>
        public short SlotId { get; set; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public RecordId()
        {
        }

        /// <summary>
        /// Constructor that reads a recordid from an opened reader
        /// </summary>
        /// <param name="p_Reader">Reader opened to the position of a RecordID</param>
        public RecordId(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }

        /// <summary>
        /// Constructor from a byte array
        /// </summary>
        /// <param name="p_Data">RecordID as a byte array</param>
        public RecordId(byte[] p_Data)
        {
            if (p_Data.Length < 6)
                throw new ArgumentException("Cannot parse RecordId, too few bytes for the class.");

            ExtentId = BitConverter.ToInt16(p_Data, 0);
            PageId = BitConverter.ToInt16(p_Data, 2);
            SlotId = BitConverter.ToInt16(p_Data, 4);
        }

        /// <summary>
        /// Writes a RecordID to an opened writer
        /// </summary>
        /// <param name="p_Writer">Writer opened to the position of a RecordID</param>
        /// <returns></returns>
        public bool Serialize(RimeWriter p_Writer)
        {
            p_Writer.Write(ExtentId);
            p_Writer.Write(PageId);
            p_Writer.Write(SlotId);
            return true;
        }

        void IFbSerializable.Serialize(RimeWriter p_Writer)
        {
            p_Writer.Write(ExtentId);
            p_Writer.Write(PageId);
            p_Writer.Write(SlotId);
        }

        /// <summary>
        /// Returns a recordID as a byte array
        /// </summary>
        /// <returns>Byte array of a recordid</returns>
        public byte[] Serialize()
        {
            using (var s_Writer = new RimeWriter(new MemoryStream()))
            {
                if (!Serialize(s_Writer))
                    throw new Exception("RecordId serialization failed.");

                s_Writer.Flush();
                return ((MemoryStream) s_Writer.BaseStream).ToArray();
            }
        }

        public void Deserialize(RimeReader p_Reader)
        {
            ExtentId = p_Reader.ReadInt16();
            PageId = p_Reader.ReadInt16();
            SlotId = p_Reader.ReadInt16();
        }

        public void Deserialize(byte[] p_Data)
        {
            throw new NotImplementedException();
        }
    }
}
