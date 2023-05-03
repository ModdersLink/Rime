using System;
using System.IO;
using System.Text;
using RimeLib.IO.Conversion;

namespace RimeLib.IO
{
	/// <summary>
	/// Equivalent of System.IO.BinaryWriter, but with either endianness, depending on
	/// the EndianBitConverter it is constructed with.
	/// </summary>
	public abstract class EndianBinaryWriter : Stream, IDisposable
	{
        /// <summary>
        /// Current position of the stream.
        /// </summary>
        public override long Position
        {
            get => BaseStream.Position;
            set => throw new NotSupportedException();
        }

        /// <summary>
        /// Length of the underlying stream.
        /// </summary>
        public override long Length => BaseStream.Length;

        // Declare our capabilities.
        public override bool CanRead => BaseStream.CanRead;
        public override bool CanSeek => BaseStream.CanSeek;
        public override bool CanWrite => BaseStream.CanWrite;

        /// <summary>
        /// The bit converter used to write values to the stream
        /// </summary>
        public EndianBitConverter BitConverter { get; private set; }

        /// <summary>
        /// The endianness of the endian converter.
        /// </summary>
        public Endianness Endianness
        {
	        get => BitConverter.Endianness;
	        set
	        {
		        if (value == Endianness.BigEndian)
			        BitConverter = EndianBitConverter.Big;
		        else
			        BitConverter = EndianBitConverter.Little;
	        }
        }

        /// <summary>
        /// Gets the underlying stream of the EndianBinaryWriter.
        /// </summary>
        public Stream BaseStream { get; }

		/// <summary>
		/// Whether or not this writer has been disposed yet.
		/// </summary>
		protected bool m_Disposed;

		/// <summary>
		/// Buffer used for temporary storage during conversion from primitives
		/// </summary>
        protected readonly byte[] m_Buffer = new byte[16];

        protected bool m_ShouldDispose;
        
        /// <summary>
        /// Constructs a new binary writer with the given bit converter, writing
        /// to the given stream, using UTF-8 encoding.
        /// </summary>
        /// <param name="p_BitConverter">Converter to use when writing data</param>
        /// <param name="p_Stream">Stream to write data to</param>
		protected EndianBinaryWriter(EndianBitConverter p_BitConverter, Stream p_Stream, bool p_ShouldDispose)
		{
			if (!p_Stream.CanWrite)
                throw new ArgumentException("Stream isn't writable", nameof(p_Stream));

            m_ShouldDispose = p_ShouldDispose;
			BaseStream = p_Stream;
			BitConverter = p_BitConverter;
		}

		/// <summary>
		/// Flushes the underlying stream.
		/// </summary>
        public override void Flush()
		{
			CheckDisposed();
			BaseStream.Flush();
		}

		/// <summary>
		/// Seeks within the stream.
		/// </summary>
		/// <param name="p_Offset">Offset to seek to.</param>
		/// <param name="p_Origin">Origin of seek operation.</param>
        public override long Seek(long p_Offset, SeekOrigin p_Origin)
		{
			CheckDisposed();
            return BaseStream.Seek(p_Offset, p_Origin);
		}

		/// <summary>
		/// Writes a boolean value to the stream. 1 byte is written.
		/// </summary>
		/// <param name="p_Value">The value to write</param>
        public void Write(bool p_Value)
		{
			BitConverter.CopyBytes(p_Value, m_Buffer, 0);
			WriteInternal(m_Buffer, 0, 1);
		}

		/// <summary>
		/// Writes a 16-bit signed integer to the stream, using the bit converter
		/// for this writer. 2 bytes are written.
		/// </summary>
		/// <param name="p_Value">The value to write</param>
        public void Write(short p_Value)
		{
            BitConverter.CopyBytes(p_Value, m_Buffer, 0);
			WriteInternal(m_Buffer, 0, 2);
		}

		/// <summary>
		/// Writes a 32-bit signed integer to the stream, using the bit converter
		/// for this writer. 4 bytes are written.
		/// </summary>
		/// <param name="p_Value">The value to write</param>
        public void Write(int p_Value)
		{
            BitConverter.CopyBytes(p_Value, m_Buffer, 0);
			WriteInternal(m_Buffer, 0, 4);
		}

		/// <summary>
		/// Writes a 64-bit signed integer to the stream, using the bit converter
		/// for this writer. 8 bytes are written.
		/// </summary>
		/// <param name="p_Value">The value to write</param>
        public void Write(long p_Value)
		{
            BitConverter.CopyBytes(p_Value, m_Buffer, 0);
			WriteInternal(m_Buffer, 0, 8);
		}

		/// <summary>
		/// Writes a 16-bit unsigned integer to the stream, using the bit converter
		/// for this writer. 2 bytes are written.
		/// </summary>
		/// <param name="p_Value">The value to write</param>
        public void Write(ushort p_Value)
		{
            BitConverter.CopyBytes(p_Value, m_Buffer, 0);
			WriteInternal(m_Buffer, 0, 2);
		}

		/// <summary>
		/// Writes a 32-bit unsigned integer to the stream, using the bit converter
		/// for this writer. 4 bytes are written.
		/// </summary>
		/// <param name="p_Value">The value to write</param>
        public void Write(uint p_Value)
		{
            BitConverter.CopyBytes(p_Value, m_Buffer, 0);
			WriteInternal(m_Buffer, 0, 4);
		}

		/// <summary>
		/// Writes a 64-bit unsigned integer to the stream, using the bit converter
		/// for this writer. 8 bytes are written.
		/// </summary>
		/// <param name="p_Value">The value to write</param>
        public void Write(ulong p_Value)
		{
            BitConverter.CopyBytes(p_Value, m_Buffer, 0);
			WriteInternal(m_Buffer, 0, 8);
		}

		/// <summary>
		/// Writes a single-precision floating-point value to the stream, using the bit converter
		/// for this writer. 4 bytes are written.
		/// </summary>
		/// <param name="p_Value">The value to write</param>
        public void Write(float p_Value)
		{
            BitConverter.CopyBytes(p_Value, m_Buffer, 0);
			WriteInternal(m_Buffer, 0, 4);
		}

		/// <summary>
		/// Writes a double-precision floating-point value to the stream, using the bit converter
		/// for this writer. 8 bytes are written.
		/// </summary>
		/// <param name="p_Value">The value to write</param>
        public void Write(double p_Value)
		{
            BitConverter.CopyBytes(p_Value, m_Buffer, 0);
			WriteInternal(m_Buffer, 0, 8);
		}

		/// <summary>
		/// Writes a decimal value to the stream, using the bit converter for this writer.
		/// 16 bytes are written.
		/// </summary>
		/// <param name="p_Value">The value to write</param>
        public void Write(decimal p_Value)
		{
            BitConverter.CopyBytes(p_Value, m_Buffer, 0);
			WriteInternal(m_Buffer, 0, 16);
		}

		/// <summary>
		/// Writes a signed byte to the stream.
		/// </summary>
		/// <param name="p_Value">The value to write</param>
        public void Write(byte p_Value)
		{
			m_Buffer[0] = p_Value;
			WriteInternal(m_Buffer, 0, 1);
		}

		/// <summary>
		/// Writes an unsigned byte to the stream.
		/// </summary>
		/// <param name="p_Value">The value to write</param>
        public void Write(sbyte p_Value)
		{
			m_Buffer[0] = unchecked((byte) p_Value);
			WriteInternal(m_Buffer, 0, 1);
		}

		/// <summary>
		/// Writes an array of bytes to the stream.
		/// </summary>
		/// <param name="p_Value">The values to write</param>
        public void Write(byte[] p_Value)
		{
			WriteInternal(p_Value, 0, p_Value.Length);
		}

		public void Write(string p_Value)
		{
			var s_Bytes = Encoding.UTF8.GetBytes(p_Value);
			WriteInternal(s_Bytes, 0, s_Bytes.Length);
		}

		/// <summary>
		/// Writes a portion of an array of bytes to the stream.
		/// </summary>
		/// <param name="p_Value">An array containing the bytes to write</param>
		/// <param name="p_Offset">The index of the first byte to write within the array</param>
		/// <param name="p_Count">The number of bytes to write</param>
        public override void Write(byte[] p_Value, int p_Offset, int p_Count)
		{
			WriteInternal(p_Value, p_Offset, p_Count);
		}

        /// <summary>
        /// Disposes of the underlying stream.
        /// </summary>
        public new void Dispose()
        {
            base.Dispose();

            CheckDisposed();

            Flush();
            m_Disposed = true;

            if (m_ShouldDispose)
                BaseStream.Dispose();
        }

        public override int Read(byte[] p_Buffer, int p_Offset, int p_Count)
        {
            CheckDisposed();
            return BaseStream.Read(p_Buffer, p_Offset, p_Count);
        }

        public override void SetLength(long p_Value)
        {
            CheckDisposed();
            BaseStream.SetLength(p_Value);
        }

        /// <summary>
        /// Checks whether or not the writer has been disposed, throwing an exception if so.
        /// </summary>
        protected void CheckDisposed()
		{
			if (m_Disposed)
				throw new ObjectDisposedException("EndianBinaryWriter");
        }

        /// <summary>
        /// Writes the specified number of bytes from the start of the given byte array,
        /// after checking whether or not the writer has been disposed.
        /// </summary>
        /// <param name="p_Bytes">The array of bytes to write from</param>
        /// <param name="p_Offset">The offset to start reading data from the array</param>
        /// <param name="p_Length">The number of bytes to write</param>
        protected virtual void WriteInternal(byte[] p_Bytes, int p_Offset, int p_Length)
		{
			CheckDisposed();
			BaseStream.Write(p_Bytes, p_Offset, p_Length);
		}
	}
}
