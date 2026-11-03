using RimeLib.Frostbite;
using RimeLib.IO;
using RimeLib.IO.Conversion;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;

namespace RimeLib.Animation.EA.GenericData
{
    /// <summary>
    /// A GenericData stream: a stream blob holding the size of its largest blob, a reflection blob
    /// with the layouts and a data blob per object.
    /// </summary>
    public class Archive : IFbSerializable
    {
        IAssetBankLoader? m_LoaderCallback = null;

        public Archive()
        {
        }

        public Archive(IAssetBankLoader p_Callback)
        {
            m_LoaderCallback = p_Callback;
        }

        public Archive(RimeReader p_Reader, IAssetBankLoader p_Callback)
        {
            m_LoaderCallback = p_Callback;
            Deserialize(p_Reader);
        }

        public bool BigEndian { get; set; } = false;

        /// <summary>
        /// The buffer a loader may load each data blob into in turn. It is written as at least the
        /// largest data blob's payload with its relocation table, so a stream read keeps its own
        /// value and a new one gets that.
        /// </summary>
        public uint SizeOfLargestBlock { get; set; } = 0;

        public Reflection? Reflection { get; set; } = null;

        /// <summary>The objects, one per data blob, in the stream's order.</summary>
        public List<Instance> Objects { get; set; } = new();

        /// <summary>
        /// Where the data blob currently being handed to the loader begins in the FILE, so a
        /// consumer can turn the blob-relative offsets its parser sees into file offsets. Set
        /// immediately before each ParseData callback.
        /// </summary>
        public long CurrentDataBlobOffset { get; private set; } = 0;

        public bool Serialize(RimeWriter p_Writer)
        {
            if (Reflection == null)
                throw new InvalidOperationException("An archive without a reflection.");

            var s_Endianness = BigEndian ? Endianness.BigEndian : Endianness.LittleEndian;

            var s_Blobs = new List<RelocatableBlob>
            {
                new(GenericDataBlobType.Reflection, BigEndian, Reflection.Payload(s_Endianness, out var s_Pointers), s_Pointers),
            };
            s_Blobs.AddRange(Objects.Select(p_Object => new DataBlob(Reflection, p_Object).ToBlob(BigEndian)));

            using var s_Stream = new MemoryStream();
            using (var s_Writer = new RimeWriter(s_Stream, s_Endianness, false))
            {
                s_Writer.Write(System.Math.Max(SizeOfLargestBlock, (uint)s_Blobs.Skip(1).Select(p_Blob => p_Blob.Data.Length).DefaultIfEmpty().Max()));

                foreach (var s_Blob in s_Blobs)
                    s_Blob.Serialize(s_Writer);

                s_Writer.Flush();
            }

            var s_Root = new Blob
            {
                Type = GenericDataBlobType.Stream,
                BigEndian = BigEndian,
                Data = s_Stream.ToArray(),
            };

            return s_Root.Serialize(p_Writer);
        }

        public void Deserialize(RimeReader p_Reader)
        {
            var s_RootHeader = new Blob(p_Reader);

            if (s_RootHeader.Type == GenericDataBlobType.RefPack)
                throw new NotSupportedException("RefPack-compressed GenericData is not read.");

            if (s_RootHeader.Type != GenericDataBlobType.Stream)
                throw new InvalidDataException("Unsupported blob format");

            BigEndian = s_RootHeader.BigEndian;

            using var s_RootStream = s_RootHeader.GetReader();

            SizeOfLargestBlock = s_RootStream.ReadUInt32();

            var s_ReflHeader = new RelocatableBlob(s_RootStream);

            if (s_ReflHeader.Type == GenericDataBlobType.Reflection)
            {
                using var s_ReflReader = s_ReflHeader.GetReader();
                Reflection = new Reflection(s_ReflReader);
            }
            else if (s_ReflHeader.Type == GenericDataBlobType.Ref2)
                throw new NotSupportedException("Ref2 reflection blobs are not read.");
            else
                throw new InvalidDataException($"Expected Reflection block as first block. Got [{s_ReflHeader.Type}]");

            Objects = new List<Instance>();

            while (s_RootStream.Position < s_RootStream.Length)
            {
                var s_DataHeader = new RelocatableBlob(s_RootStream);

                if (s_DataHeader.Type != GenericDataBlobType.Data)
                    throw new InvalidDataException("Unsupported blob format");

                using (var s_ObjectReader = s_DataHeader.GetReader())
                {
                    var s_Object = new DataBlob(Reflection);
                    s_Object.Deserialize(s_ObjectReader);
                    Objects.Add(s_Object.Root!);
                }

                if (m_LoaderCallback == null)
                    continue;

                using var s_Reader = s_DataHeader.GetReader();
                var s_Data = new Data(s_Reader);

                // The blob's payload sits at its own offset INSIDE the root stream, and the root
                // stream is itself a copy taken from the file at s_RootHeader.DataOffset.
                CurrentDataBlobOffset = s_RootHeader.DataOffset + s_DataHeader.DataOffset;

                m_LoaderCallback.ParseData(s_Reader, s_Data);
            }
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
