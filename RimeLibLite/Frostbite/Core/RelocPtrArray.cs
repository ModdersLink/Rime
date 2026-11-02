using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using RimeLib.IO;

namespace RimeLib.Frostbite.Core
{
    /// <summary>
    /// A pointer to an array whose count is stored elsewhere in the struct (a RelocPtr to the first
    /// of several elements). Like <see cref="RelocPtr{T}"/> its slot is the 64-bit offset alone; the
    /// owning layout places the elements and sets <see cref="BaseAddress"/>.
    /// </summary>
    public class RelocPtrArray<T> : IFbSerializable
    {
        public ulong BaseAddress { get; set; }

        public T[] Get { get; set; } = Array.Empty<T>();

        public RelocPtrArray()
        {
        }

        /// <summary>Reads the slot and the <paramref name="p_Count"/> elements it points at.</summary>
        public RelocPtrArray(RimeReader p_Reader, uint p_Count)
        {
            BaseAddress = p_Reader.ReadUInt64();
            if (BaseAddress == 0)
                return;

            var s_CurOffset = p_Reader.Position;
            p_Reader.Seek((long)BaseAddress, System.IO.SeekOrigin.Begin);

            Get = new T[p_Count];
            for (var i = 0; i < p_Count; ++i)
                Get[i] = RelocElement.Read<T>(p_Reader);

            p_Reader.Seek(s_CurOffset, System.IO.SeekOrigin.Begin);
        }

        public bool Serialize(RimeWriter p_Writer)
        {
            if (BaseAddress != 0)
                (p_Writer as RelocationRimeWriter)?.RecordPointer();
            p_Writer.Write(BaseAddress);
            return true;
        }

        public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
        {
            var s_Stream = new System.IO.MemoryStream();
            using var s_Writer = new RimeWriter(s_Stream);
            Serialize(s_Writer);
            p_Data = s_Stream.ToArray();
            return true;
        }

        /// <summary>Reads the slot only; the count is not known here.</summary>
        public void Deserialize(RimeReader p_Reader)
        {
            BaseAddress = p_Reader.ReadUInt64();
        }

        public void Deserialize(byte[] p_Data)
        {
            using var s_Reader = new RimeReader(new MemoryStream(p_Data, false));
            Deserialize(s_Reader);
        }
    }
}
