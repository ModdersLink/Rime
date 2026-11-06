using RimeLib.Frostbite;
using RimeLib.IO;
using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace RimeLib.Animation.EA.GenericData
{
    /// <summary>
    /// The header of an object in a data blob, EA::GD::LayoutData: 64-bit slots for the vtable,
    /// which holds an id on disk, the allocator and the layout, which holds the layout's hash; then
    /// the reference count, where the object's data starts and whether it may change.
    /// </summary>
    public class Data : IFbSerializable
    {
        private const uint c_kIID = 0x030E6205; // EA::GD::DataId const EA::GD::LayoutData::kIID

        /// <summary>The header's size, which the object's data follows.</summary>
        public const ushort c_Size = 0x20;

        public uint LayoutHash { get; set; } = 0;

        public uint RefCount { get; set; } = 0;

        public uint DataOffset { get; set; } = c_Size;

        public bool Mutable { get; set; } = false;

        public Data()
        {
        }

        public Data(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }

        public bool Serialize(RimeWriter p_Writer)
        {
            p_Writer.Write((ulong)c_kIID);
            p_Writer.Write(0UL);
            p_Writer.Write((ulong)LayoutHash);
            p_Writer.Write(RefCount);
            p_Writer.Write((ushort)DataOffset);
            p_Writer.Write(Mutable);
            p_Writer.Write((byte)0);

            return true;
        }

        public void Deserialize(RimeReader p_Reader)
        {
            var s_Magic = (uint)p_Reader.ReadUInt64();

            if (s_Magic != c_kIID)
                throw new InvalidDataException("Invalid Data magic. Data is either already read or something is wrong!");

            p_Reader.ReadUInt64();
            LayoutHash = (uint)p_Reader.ReadUInt64();
            RefCount = p_Reader.ReadUInt32();
            DataOffset = p_Reader.ReadUInt16();
            Mutable = p_Reader.ReadBool();
            p_Reader.ReadUByte();
        }

        public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
        {
            var s_Stream = new MemoryStream();
            using var s_Writer = new RimeWriter(s_Stream);

            if (Serialize(s_Writer))
            {
                p_Data = s_Stream.ToArray();
                return true;
            }

            p_Data = null;
            return false;
        }

        public void Deserialize(byte[] p_Data)
        {
            using var s_Reader = new RimeReader(new MemoryStream(p_Data));
            Deserialize(s_Reader);
        }
    }
}
