using System.Diagnostics.CodeAnalysis;
using System.IO;
using RimeLib.IO;

namespace RimeLib.Frostbite.Core
{
    /// <summary>
    /// Implementation of fb::RelocPtr
    /// </summary>
    /// <typeparam name="T">Type that this reloc pointer points to</typeparam>
    public class RelocPtr<T> : IFbSerializable
    {
        /// <summary>
        /// Base address of the relocptr
        /// </summary>
        public ulong BaseAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public T Object { get; }

        /// <summary>
        /// Constructor that takes an opened reader to read out a RelocPtr
        /// </summary>
        /// <param name="p_Reader">Reader opened to the position of RelocPtr</param>
        public RelocPtr(RimeReader p_Reader)
        {
            Object = DeserializeObject(p_Reader);
        }

        public RelocPtr()
        {
            Object = default;
            BaseAddress = 0;
        }

        /// <summary>
        /// Writes the pointer slot: the same 64 bits <see cref="DeserializeObject"/> reads.
        ///
        /// A RelocPtr is an OFFSET, so this writes the slot and nothing else -- the pointee lives
        /// elsewhere in the file and is placed by whoever owns the layout, which is also who has to
        /// set <see cref="BaseAddress"/> and emit the relocation table entry for it. Following the
        /// pointer here and writing the object inline would corrupt the struct it sits in.
        /// </summary>
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

            if (Serialize(s_Writer))
            {
                p_Data = s_Stream.ToArray();
                return true;
            }

            p_Data = null;
            return false;
        }

        public void Deserialize(RimeReader p_Reader)
        {
            DeserializeObject(p_Reader);
        }

        public T DeserializeObject(RimeReader p_Reader)
        {
            // The slot is 64 bits wide, so read it whole rather than as two 32-bit halves, or the
            // pointer comes out wrong on big-endian data.
            BaseAddress = p_Reader.ReadUInt64();

            if (BaseAddress == 0)
            {
                return default(T);
            }

            // Some MeshSet layouts store a RelocPtr holding a runtime or placeholder value instead of
            // an offset into the file. Such a pointer cannot be a valid in-file target, so treat it as
            // null rather than seeking out of bounds and aborting the whole resource parse.
            if (p_Reader.CanSeek && (BaseAddress > (ulong)long.MaxValue || (long)BaseAddress >= p_Reader.Length))
            {
                return default(T);
            }

            // Save the offset
            var s_CurOffset = p_Reader.Position;

            try
            {
                p_Reader.Seek((long) BaseAddress, System.IO.SeekOrigin.Begin);
                return RelocElement.Read<T>(p_Reader);
            }
            finally
            {
                // Reset the position
                p_Reader.Seek(s_CurOffset, System.IO.SeekOrigin.Begin);
            }
        }

        public void Deserialize(byte[] p_Data)
        {
            using var s_Reader = new RimeReader(new MemoryStream(p_Data, false));
            Deserialize(s_Reader);
        }
    }
}