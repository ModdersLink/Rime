using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using RimeLib.Frostbite;
using RimeLib.IO;

namespace RimeLib.Content.Scaleform
{
    /// <summary>A SWF or GFx tag: its type and its undecoded body.</summary>
    public class SwfTagSection : IFbSerializable
    {
        /// <summary>Where the tag starts in the uncompressed movie, when it was read from one.</summary>
        public long? Offset { get; set; }

        public SwfTag Tag { get; set; } = SwfTag.End;

        /// <summary>Whether the header uses the long form; a tag can do so for a short length.</summary>
        public bool LongHeader { get; set; }

        public byte[] Data { get; set; } = Array.Empty<byte>();

        public override string ToString() => $"{Tag} - length 0x{Data.Length:X}";

        public RimeReader GetReader() => new(new MemoryStream(Data, false));

        public SwfTagSection()
        {
        }

        public SwfTagSection(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }

        public void Deserialize(RimeReader p_Reader)
        {
            Offset = p_Reader.Position;

            var s_Header = p_Reader.ReadUInt16();
            Tag = (SwfTag)(s_Header >> 6);

            var s_Length = s_Header & 0x3F;
            if (s_Length == 0x3F)
            {
                LongHeader = true;
                s_Length = p_Reader.ReadInt32();
            }

            Data = p_Reader.ReadBytes(s_Length);
        }

        public bool Serialize(RimeWriter p_Writer)
        {
            var s_Long = LongHeader || Data.Length >= 0x3F;
            p_Writer.Write((ushort)(((ushort)Tag << 6) | (s_Long ? 0x3F : Data.Length)));
            if (s_Long)
                p_Writer.Write(Data.Length);
            p_Writer.Write(Data);
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

        public void Deserialize(byte[] p_Data)
        {
            using var s_Reader = new RimeReader(new MemoryStream(p_Data, false));
            Deserialize(s_Reader);
        }
    }
}
