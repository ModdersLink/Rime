using System.Diagnostics.CodeAnalysis;
using System.IO;
using RimeLib.Animation.EA.GenericData;
using RimeLib.Frostbite;
using RimeLib.IO;
using RimeLib.IO.Conversion;

namespace RimeLib.Animation.Frostbite
{
    /// <summary>
    /// The bank of an AnimationSet package, an AssetBank resource: its packaging type, big-endian,
    /// then a GenericData stream with an object per data blob. Its objects refer to each other by
    /// local ids, the bank keeps no package meta, and what refers into it counts its objects in
    /// stream order.
    /// </summary>
    public class AnimationSetBank : IFbSerializable
    {
        /// <summary>The engine's AntPackagingType value, AnimationSet for a bank of this kind.</summary>
        public uint PackagingType { get; set; }

        public Archive Archive { get; set; } = new();

        public bool Serialize(RimeWriter p_Writer)
        {
            var s_LastEndianness = p_Writer.Endianness;
            p_Writer.Endianness = Endianness.BigEndian;
            p_Writer.Write(PackagingType);
            p_Writer.Endianness = s_LastEndianness;

            return Archive.Serialize(p_Writer);
        }

        public void Deserialize(RimeReader p_Reader)
        {
            var s_LastEndianness = p_Reader.Endianness;
            p_Reader.Endianness = Endianness.BigEndian;
            PackagingType = p_Reader.ReadUInt32();
            p_Reader.Endianness = s_LastEndianness;

            Archive = new Archive();
            Archive.Deserialize(p_Reader);
        }

        /// <summary>The packaging type a bank starts with.</summary>
        public static uint ReadPackagingType(byte[] p_Data)
        {
            using var s_Reader = new RimeReader(new MemoryStream(p_Data, false), Endianness.BigEndian);
            return s_Reader.ReadUInt32();
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
