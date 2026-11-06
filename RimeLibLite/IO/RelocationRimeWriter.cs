using System.Collections.Generic;
using System.IO;

namespace RimeLib.IO
{
    /// <summary>
    /// A writer for a relocatable image: every non-null RelocPtr, RelocArray or RelocPtrArray slot
    /// written through it records where it is, which is what the image's relocation table lists.
    /// </summary>
    public class RelocationRimeWriter : RimeWriter
    {
        /// <summary>The offsets of the pointer slots, in the order they were written.</summary>
        public List<long> Relocations { get; } = new();

        public RelocationRimeWriter(Stream p_Stream) : base(p_Stream)
        {
        }

        /// <summary>Called by a slot about to write a non-null pointer at the current position.</summary>
        public void RecordPointer() => Relocations.Add(Position);
    }
}
