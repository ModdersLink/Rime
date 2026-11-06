using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Text;
using RimeLib.Frostbite;
using RimeLib.IO;

namespace RimeLib.Content.Frostbite2013_2.Resources
{
    /// <summary>
    /// A CompiledLuaResource: its CompiledLuaHeader, the signature's name and argument list (each
    /// with its terminator, their sizes in the header) and the payload, Lua bytecode.
    /// </summary>
    public class CompiledLuaResource : IFbSerializable
    {
        public uint Version { get; set; }
        public uint IsByteCode { get; set; }
        public uint SignatureArgCount { get; set; }
        public string SignatureName { get; set; } = string.Empty;
        public string SignatureArgs { get; set; } = string.Empty;
        public byte[] Payload { get; set; } = Array.Empty<byte>();

        /// <summary>Reads the resource from the reader's position; it runs to the reader's end.</summary>
        public void Deserialize(RimeReader p_Reader)
        {
            var s_Size = p_Reader.Length - p_Reader.Position;
            Version = p_Reader.ReadUInt32();
            IsByteCode = p_Reader.ReadUInt32();
            var s_NameSize = p_Reader.ReadInt32();
            var s_ArgsSize = p_Reader.ReadInt32();
            SignatureArgCount = p_Reader.ReadUInt32();
            var s_PayloadSize = p_Reader.ReadInt32();

            if (24L + s_NameSize + s_ArgsSize + s_PayloadSize != s_Size)
                throw new InvalidDataException($"A compiled Lua resource of {s_Size} bytes with a {s_NameSize}, {s_ArgsSize} and {s_PayloadSize} byte body.");

            SignatureName = ReadString(p_Reader, s_NameSize);
            SignatureArgs = ReadString(p_Reader, s_ArgsSize);
            Payload = p_Reader.ReadBytes(s_PayloadSize);
        }

        public void Deserialize(byte[] p_Data)
        {
            using var s_Reader = new RimeReader(new MemoryStream(p_Data, false));
            Deserialize(s_Reader);
        }

        /// <summary>A signature string, which fills its size with its terminator.</summary>
        private static string ReadString(RimeReader p_Reader, int p_Size)
        {
            var s_End = p_Reader.Position + p_Size;
            var s_String = p_Reader.ReadNullTerminatedString();
            if (p_Reader.Position != s_End)
                throw new InvalidDataException("A compiled Lua signature string that does not end at its size.");
            return s_String;
        }

        private static uint StringSize(string p_Value) => (uint)Encoding.UTF8.GetByteCount(p_Value) + 1;

        public bool Serialize(RimeWriter p_Writer)
        {
            p_Writer.Write(Version);
            p_Writer.Write(IsByteCode);
            p_Writer.Write(StringSize(SignatureName));
            p_Writer.Write(StringSize(SignatureArgs));
            p_Writer.Write(SignatureArgCount);
            p_Writer.Write((uint)Payload.Length);
            p_Writer.WriteNullTerminatedString(SignatureName);
            p_Writer.WriteNullTerminatedString(SignatureArgs);
            p_Writer.Write(Payload);
            return true;
        }

        public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
        {
            var s_Stream = new MemoryStream();
            using (var s_Writer = new RimeWriter(s_Stream))
                Serialize(s_Writer);

            p_Data = s_Stream.ToArray();
            return true;
        }
    }
}
