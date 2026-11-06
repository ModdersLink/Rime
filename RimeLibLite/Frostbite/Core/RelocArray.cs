using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
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

        readonly Array<T> m_Objects = new Array<T>();

        /// <summary>
        /// Indexer into the array
        /// </summary>
        public T[] Get => m_Objects.AsArray;

        /// <summary>
        /// Default constructor
        /// </summary>
        public RelocArray()
        {
            // Fuck yo couch
        }

        /// <summary>An array of <paramref name="p_Items"/>, whose place the owning layout sets.</summary>
        public RelocArray(IEnumerable<T> p_Items)
        {
            m_Objects = new Array<T>(new List<T>(p_Items));
            Count = (uint)m_Objects.Count;
        }

        /// <summary>
        /// Constructor reading a array from an opened stream
        /// </summary>
        /// <param name="p_Reader">Reader opened to the position of a reloc array</param>
        public RelocArray(RimeReader p_Reader)
        {
            Count = p_Reader.ReadUInt32();
            BaseAddress = p_Reader.ReadUInt64();

            if (BaseAddress == 0)
                return;

            // Save current offset
            var s_CurOffset = p_Reader.Position;

            p_Reader.Seek((long)BaseAddress, System.IO.SeekOrigin.Begin);

            for (var i = 0; i < Count; ++i)
            {
                if (RelocElement.Read<T>(p_Reader) is { } s_Object)
                    m_Objects.Add(s_Object);
            }

            // Reset the position
            p_Reader.Seek(s_CurOffset, System.IO.SeekOrigin.Begin);
        }

        /// <summary>
        /// Writes the array slot: the count and the pointer, the same 12 bytes the constructor
        /// reads. As with <see cref="RelocPtr{T}"/> the ELEMENTS are not written here -- they live
        /// at <see cref="BaseAddress"/> and belong to the owning layout.
        /// </summary>
        /// <param name="p_Writer"></param>
        public bool Serialize(RimeWriter p_Writer)
        {
            p_Writer.Write(Count);
            if (BaseAddress != 0)
                (p_Writer as RelocationRimeWriter)?.RecordPointer();
            p_Writer.Write(BaseAddress);

            return true;
        }

        public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
        {
            var s_Stream = new System.IO.MemoryStream();
            using var s_Writer = new RimeWriter(s_Stream);

            if (Serialize(s_Writer))
            {
                p_Data = s_Stream.ToArray();
                return true;
            }

            p_Data = null;
            return false;
        }

        /// <summary>
        /// Reads the array slot in place. The constructor is what reads the ELEMENTS too; this is
        /// the interface entry point and reads only the slot, so that it mirrors
        /// <see cref="Serialize(RimeWriter)"/> exactly.
        /// </summary>
        public void Deserialize(RimeReader p_Reader)
        {
            Count = p_Reader.ReadUInt32();
            BaseAddress = p_Reader.ReadUInt64();
        }

        public void Deserialize(byte[] p_Data)
        {
            using var s_Reader = new RimeReader(new MemoryStream(p_Data, false));
            Deserialize(s_Reader);
        }
    }
}
