using System;
using System.IO;
using System.Text;
using RimeLib.IO;

namespace RimeLib.Content.Frostbite2013_2.Resources
{
    /// <summary>
    /// A CompiledLuaResource: its CompiledLuaHeader, the signature's name and argument list (each
    /// with its terminator, their sizes in the header) and the payload, Lua bytecode.
    /// </summary>
    public class CompiledLuaResource
    {
        public uint Version { get; set; }
        public uint IsByteCode { get; set; }
        public uint SignatureArgCount { get; set; }
        public string SignatureName { get; set; } = string.Empty;
        public string SignatureArgs { get; set; } = string.Empty;
        public byte[] Payload { get; set; } = Array.Empty<byte>();

        public static CompiledLuaResource Read(byte[] p_Data)
        {
            using var s_Reader = new RimeReader(new MemoryStream(p_Data, false));
            var s_Lua = new CompiledLuaResource { Version = s_Reader.ReadUInt32(), IsByteCode = s_Reader.ReadUInt32() };
            var s_NameSize = s_Reader.ReadInt32();
            var s_ArgsSize = s_Reader.ReadInt32();
            s_Lua.SignatureArgCount = s_Reader.ReadUInt32();
            var s_PayloadSize = s_Reader.ReadInt32();

            if (24L + s_NameSize + s_ArgsSize + s_PayloadSize != p_Data.Length)
                throw new InvalidDataException($"A compiled Lua resource of {p_Data.Length} bytes with a {s_NameSize}, {s_ArgsSize} and {s_PayloadSize} byte body.");

            s_Lua.SignatureName = Terminated(s_Reader.ReadBytes(s_NameSize));
            s_Lua.SignatureArgs = Terminated(s_Reader.ReadBytes(s_ArgsSize));
            s_Lua.Payload = s_Reader.ReadBytes(s_PayloadSize);
            return s_Lua;
        }

        private static string Terminated(byte[] p_Bytes)
        {
            if (p_Bytes.Length == 0 || p_Bytes[^1] != 0)
                throw new InvalidDataException("A compiled Lua signature string without its terminator.");
            return Encoding.ASCII.GetString(p_Bytes, 0, p_Bytes.Length - 1);
        }

        public byte[] Write()
        {
            var s_Name = Encoding.ASCII.GetBytes(SignatureName + "\0");
            var s_Args = Encoding.ASCII.GetBytes(SignatureArgs + "\0");
            var s_Stream = new MemoryStream();
            using (var s_Writer = new RimeWriter(s_Stream))
            {
                s_Writer.Write(Version);
                s_Writer.Write(IsByteCode);
                s_Writer.Write((uint)s_Name.Length);
                s_Writer.Write((uint)s_Args.Length);
                s_Writer.Write(SignatureArgCount);
                s_Writer.Write((uint)Payload.Length);
                s_Writer.Write(s_Name);
                s_Writer.Write(s_Args);
                s_Writer.Write(Payload);
            }

            return s_Stream.ToArray();
        }
    }
}
