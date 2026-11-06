using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using RimeLib.Content.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.IO;

namespace RimeLib.Content.Mounting
{
    /// <summary>What a resource names inside its own payload, which appears nowhere in the EBX.</summary>
    public sealed class ResourcePayloadNames
    {
        /// <summary>Resources the payload binds by name. A name that is also a partition names the asset too.</summary>
        public List<string> ResourceNames { get; } = new();

        /// <summary>Names that are EBX partitions only: shaders, or meshes bound as assets.</summary>
        public List<string> PartitionNames { get; } = new();

        public List<GUID> ChunkIds { get; } = new();

        public string? Error { get; set; }
    }

    /// <summary>Reads the dependencies of resources whose payloads name them.</summary>
    public interface IResourcePayloadReader : IEngineInterface
    {
        bool Handles(ResourceType p_Type);

        /// <summary>Never throws; a payload that can't be walked comes back with <see cref="ResourcePayloadNames.Error"/> set.</summary>
        ResourcePayloadNames Read(ResourceType p_Type, byte[] p_Data);
    }

    /// <summary>
    /// The engine's stream conventions for these payloads: byte-packed, little-endian, a string is
    /// NUL-terminated with no length prefix, and an empty name means "no dependency".
    /// </summary>
    public static class PayloadStream
    {
        /// <summary>
        /// A lowercased name. The end of the payload is checked on every byte: a walk that has
        /// gone wrong reaches it inside a string, and RimeReader.ReadNullTerminatedString would
        /// keep returning the last byte there.
        /// </summary>
        public static string ReadCString(RimeReader p_Reader)
        {
            var s_Bytes = new List<byte>();

            while (true)
            {
                if (p_Reader.Position >= p_Reader.Length)
                    throw new InvalidDataException("payload ended inside a string");

                var s_Byte = p_Reader.ReadByte();
                if (s_Byte == 0)
                    break;

                s_Bytes.Add((byte)s_Byte);
            }

            return Encoding.UTF8.GetString(s_Bytes.ToArray()).ToLowerInvariant();
        }

        /// <summary>
        /// Reads an element count and rejects one that cannot be real. A misaligned walk shows up
        /// here first, as a count in the millions.
        /// </summary>
        public static uint ReadCount(RimeReader p_Reader, string p_What, uint p_Max = 1_000_000)
        {
            var s_Count = p_Reader.ReadUInt32();

            if (s_Count > p_Max)
                throw new InvalidDataException($"{p_What} is {s_Count}, the walk is misaligned");

            return s_Count;
        }

        /// <summary>Skips a count followed by that many bytes.</summary>
        public static void SkipByteArray(RimeReader p_Reader, string p_What)
        {
            p_Reader.Seek(ReadCount(p_Reader, p_What, 0xFFFF), SeekOrigin.Current);
        }

        public static void AddName(List<string> p_Names, string p_Name)
        {
            if (p_Name.Length > 0)
                p_Names.Add(p_Name);
        }

        public static void AddChunk(ResourcePayloadNames p_Names, GUID p_Id)
        {
            if (p_Id != GUID.Empty)
                p_Names.ChunkIds.Add(p_Id);
        }

        /// <summary>
        /// Runs a walk, turning any failure into the result's error. With <paramref name="p_WholePayload"/>
        /// a walk that stops before the end is an error too: for a format walked field by field, that
        /// is the check that the layout is right.
        /// </summary>
        public static ResourcePayloadNames Walk(byte[] p_Data, bool p_WholePayload, Action<RimeReader, ResourcePayloadNames> p_Walk)
        {
            var s_Result = new ResourcePayloadNames();
            try
            {
                using var s_Reader = new RimeReader(new MemoryStream(p_Data, false));
                p_Walk(s_Reader, s_Result);
                if (p_WholePayload && s_Reader.Position != s_Reader.Length)
                    s_Result.Error ??= $"walk ended {s_Reader.Length - s_Reader.Position} byte(s) before the payload";
            }
            catch (Exception s_Ex)
            {
                s_Result.Error = s_Ex.Message;
            }

            return s_Result;
        }
    }
}
