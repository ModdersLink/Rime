using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using RimeLib.IO;

namespace RimeLib.Frostbite
{
    /// <summary>
    /// A resource's 16-byte meta, which the engine calls its cookie: what the loader needs before it
    /// reads the payload, mostly the sizes of the payload's parts.
    /// </summary>
    public abstract class ResourceCookie : IFbSerializable
    {
        public const int Size = 16;

        /// <summary>The payload length the cookie describes.</summary>
        public abstract long PayloadSize { get; }

        public abstract bool Serialize(RimeWriter p_Writer);

        public abstract void Deserialize(RimeReader p_Reader);

        public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
        {
            var s_Stream = new MemoryStream();
            using (var s_Writer = new RimeWriter(s_Stream))
                Serialize(s_Writer);

            p_Data = s_Stream.ToArray();
            return true;
        }

        public void Deserialize(byte[] p_Data)
        {
            if (p_Data.Length != Size)
                throw new InvalidDataException($"A resource cookie is {Size} bytes, not {p_Data.Length}.");

            using var s_Reader = new RimeReader(new MemoryStream(p_Data, false));
            Deserialize(s_Reader);
        }

        public byte[] ToArray() => Serialize(out var s_Data) ? s_Data : Array.Empty<byte>();

        public static T Read<T>(byte[] p_Data) where T : ResourceCookie, new()
        {
            var s_Cookie = new T();
            s_Cookie.Deserialize(p_Data);
            return s_Cookie;
        }
    }
}
