using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameToolsDotNet.IO.Streams
{
    public class VirtualMemoryStream : MemoryStream
    {
        /// <summary>
        /// Gets the base memory address for the memory stream.
        /// </summary>
        public long BaseAddress { get; private set; }

        /// <summary>
        /// Gets or sets the current position in the stream.
        /// </summary>
        public override long Position
        {
            get
            {
                // Adjust the offset.
                return base.Position + BaseAddress;
            }
            set
            {
                // Adjust the offset.
                base.Position = value - BaseAddress;
            }
        }

        public VirtualMemoryStream(long baseAddress)
        {
            // Initialize fields.
            this.BaseAddress = baseAddress;
        }

        public VirtualMemoryStream(long baseAddress, int capacity)
        {
            // Initialize fields.
            this.BaseAddress = baseAddress;
            this.Capacity = capacity;
        }
    }
}
