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
	public abstract class EndianBinaryWriter : IDisposable
	{
		#region Fields not directly related to properties
		/// <summary>
		/// Whether or not this writer has been disposed yet.
		/// </summary>
		bool m_Disposed=false;
		/// <summary>
		/// Buffer used for temporary storage during conversion from primitives
		/// </summary>
		byte[] m_Buffer = new byte[16];
		/// <summary>
		/// Buffer used for Write(char)
		/// </summary>
		char[] m_CharBuffer = new char[1];
		#endregion

		#region Constructors
		/// <summary>
		/// Constructs a new binary writer with the given bit converter, writing
		/// to the given stream, using UTF-8 encoding.
		/// </summary>
		/// <param name="p_BitConverter">Converter to use when writing data</param>
		/// <param name="p_Stream">Stream to write data to</param>
		protected EndianBinaryWriter (EndianBitConverter p_BitConverter,
			Stream p_Stream) : this (p_BitConverter, p_Stream, Encoding.UTF8)
		{
		}

		/// <summary>
		/// Constructs a new binary writer with the given bit converter, writing
		/// to the given stream, using the given encoding.
		/// </summary>
		/// <param name="p_BitConverter">Converter to use when writing data</param>
		/// <param name="p_Stream">Stream to write data to</param>
		/// <param name="p_Encoding">Encoding to use when writing character data</param>
		protected EndianBinaryWriter (EndianBitConverter p_BitConverter,	Stream p_Stream, Encoding p_Encoding)
		{
			if (p_BitConverter==null)
			{
				throw new ArgumentNullException("p_BitConverter");
			}
			if (p_Stream==null)
			{
				throw new ArgumentNullException("p_Stream");
			}
			if (p_Encoding==null)
			{
				throw new ArgumentNullException("p_Encoding");
			}
			if (!p_Stream.CanWrite)
			{
				throw new ArgumentException("Stream isn't writable", "p_Stream");
			}
			this.m_Stream = p_Stream;
			this.m_BitConverter = p_BitConverter;
			this.m_Encoding = p_Encoding;
		}
		#endregion

		#region Properties
		EndianBitConverter m_BitConverter;
		/// <summary>
		/// The bit converter used to write values to the stream
		/// </summary>
		public EndianBitConverter BitConverter
		{
			get { return m_BitConverter; }
		}

		Encoding m_Encoding;
		/// <summary>
		/// The encoding used to write strings
		/// </summary>
		public Encoding Encoding
		{
			get { return m_Encoding; }
		}

		Stream m_Stream;
		/// <summary>
		/// Gets the underlying stream of the EndianBinaryWriter.
		/// </summary>
		public Stream BaseStream
		{
			get { return m_Stream; }
		}
		#endregion
	
		#region Public methods
		/// <summary>
		/// Closes the writer, including the underlying stream.
		/// </summary>
        public virtual void Close()
		{
			Dispose();
		}

		/// <summary>
		/// Flushes the underlying stream.
		/// </summary>
        public virtual void Flush()
		{
			CheckDisposed();
			m_Stream.Flush();
		}

		/// <summary>
		/// Seeks within the stream.
		/// </summary>
		/// <param name="p_Offset">Offset to seek to.</param>
		/// <param name="p_Origin">Origin of seek operation.</param>
        public virtual void Seek(long p_Offset, SeekOrigin p_Origin)
		{
			CheckDisposed();
			m_Stream.Seek (p_Offset, p_Origin);
		}

		/// <summary>
		/// Writes a boolean value to the stream. 1 byte is written.
		/// </summary>
		/// <param name="p_Value">The value to write</param>
        public virtual void Write(bool p_Value)
		{
			m_BitConverter.CopyBytes(p_Value, m_Buffer, 0);
			WriteInternal(m_Buffer, 1);
		}

		/// <summary>
		/// Writes a 16-bit signed integer to the stream, using the bit converter
		/// for this writer. 2 bytes are written.
		/// </summary>
		/// <param name="p_Value">The value to write</param>
        public virtual void Write(short p_Value)
		{
			m_BitConverter.CopyBytes(p_Value, m_Buffer, 0);
			WriteInternal(m_Buffer, 2);
		}

		/// <summary>
		/// Writes a 32-bit signed integer to the stream, using the bit converter
		/// for this writer. 4 bytes are written.
		/// </summary>
		/// <param name="p_Value">The value to write</param>
        public virtual void Write(int p_Value)
		{
			m_BitConverter.CopyBytes(p_Value, m_Buffer, 0);
			WriteInternal(m_Buffer, 4);
		}

		/// <summary>
		/// Writes a 64-bit signed integer to the stream, using the bit converter
		/// for this writer. 8 bytes are written.
		/// </summary>
		/// <param name="p_Value">The value to write</param>
        public virtual void Write(long p_Value)
		{
			m_BitConverter.CopyBytes(p_Value, m_Buffer, 0);
			WriteInternal(m_Buffer, 8);
		}

		/// <summary>
		/// Writes a 16-bit unsigned integer to the stream, using the bit converter
		/// for this writer. 2 bytes are written.
		/// </summary>
		/// <param name="p_Value">The value to write</param>
        public virtual void Write(ushort p_Value)
		{
			m_BitConverter.CopyBytes(p_Value, m_Buffer, 0);
			WriteInternal(m_Buffer, 2);
		}

		/// <summary>
		/// Writes a 32-bit unsigned integer to the stream, using the bit converter
		/// for this writer. 4 bytes are written.
		/// </summary>
		/// <param name="p_Value">The value to write</param>
        public virtual void Write(uint p_Value)
		{
			m_BitConverter.CopyBytes(p_Value, m_Buffer, 0);
			WriteInternal(m_Buffer, 4);
		}

		/// <summary>
		/// Writes a 64-bit unsigned integer to the stream, using the bit converter
		/// for this writer. 8 bytes are written.
		/// </summary>
		/// <param name="p_Value">The value to write</param>
        public virtual void Write(ulong p_Value)
		{
			m_BitConverter.CopyBytes(p_Value, m_Buffer, 0);
			WriteInternal(m_Buffer, 8);
		}

		/// <summary>
		/// Writes a single-precision floating-point value to the stream, using the bit converter
		/// for this writer. 4 bytes are written.
		/// </summary>
		/// <param name="p_Value">The value to write</param>
        public virtual void Write(float p_Value)
		{
			m_BitConverter.CopyBytes(p_Value, m_Buffer, 0);
			WriteInternal(m_Buffer, 4);
		}

		/// <summary>
		/// Writes a double-precision floating-point value to the stream, using the bit converter
		/// for this writer. 8 bytes are written.
		/// </summary>
		/// <param name="p_Value">The value to write</param>
        public virtual void Write(double p_Value)
		{
			m_BitConverter.CopyBytes(p_Value, m_Buffer, 0);
			WriteInternal(m_Buffer, 8);
		}

		/// <summary>
		/// Writes a decimal value to the stream, using the bit converter for this writer.
		/// 16 bytes are written.
		/// </summary>
		/// <param name="p_Value">The value to write</param>
        public virtual void Write(decimal p_Value)
		{
			m_BitConverter.CopyBytes(p_Value, m_Buffer, 0);
			WriteInternal(m_Buffer, 16);
		}

		/// <summary>
		/// Writes a signed byte to the stream.
		/// </summary>
		/// <param name="p_Value">The value to write</param>
        public virtual void Write(byte p_Value)
		{
			m_Buffer[0] = p_Value;
			WriteInternal(m_Buffer, 1);
		}

		/// <summary>
		/// Writes an unsigned byte to the stream.
		/// </summary>
		/// <param name="p_Value">The value to write</param>
        public virtual void Write(sbyte p_Value)
		{
			m_Buffer[0] = unchecked((byte)p_Value);
			WriteInternal(m_Buffer, 1);
		}

		/// <summary>
		/// Writes an array of bytes to the stream.
		/// </summary>
		/// <param name="p_Value">The values to write</param>
        public virtual void Write(byte[] p_Value)
		{
			if (p_Value == null)
			{
				throw (new ArgumentNullException("p_Value"));
			}
			WriteInternal(p_Value, p_Value.Length);
		}

		/// <summary>
		/// Writes a portion of an array of bytes to the stream.
		/// </summary>
		/// <param name="p_Value">An array containing the bytes to write</param>
		/// <param name="p_Offset">The index of the first byte to write within the array</param>
		/// <param name="p_Count">The number of bytes to write</param>
        public virtual void Write(byte[] p_Value, int p_Offset, int p_Count)
		{
			CheckDisposed();
			m_Stream.Write(p_Value, p_Offset, p_Count);
		}

		/// <summary>
		/// Writes a single character to the stream, using the encoding for this writer.
		/// </summary>
		/// <param name="p_Value">The value to write</param>
        public virtual void Write(char p_Value)
		{
			m_CharBuffer[0] = p_Value;
			Write(m_CharBuffer);
		}

		/// <summary>
		/// Writes an array of characters to the stream, using the encoding for this writer.
		/// </summary>
		/// <param name="p_Value">An array containing the characters to write</param>
        public virtual void Write(char[] p_Value)
		{
			if (p_Value==null)
			{
				throw new ArgumentNullException("p_Value");
			}
			CheckDisposed();
			byte[] data = Encoding.GetBytes(p_Value, 0, p_Value.Length);
			WriteInternal(data, data.Length);
		}

		/// <summary>
		/// Writes a string to the stream, using the encoding for this writer.
		/// </summary>
		/// <param name="p_Value">The value to write. Must not be null.</param>
		/// <exception cref="ArgumentNullException">value is null</exception>
        public virtual void Write(string p_Value)
		{
			if (p_Value==null)
			{
				throw new ArgumentNullException("p_Value");
			}
			CheckDisposed();
			byte[] data = Encoding.GetBytes(p_Value);
			Write7BitEncodedInt(data.Length);
			WriteInternal(data, data.Length);
		}

		/// <summary>
		/// Writes a 7-bit encoded integer from the stream. This is stored with the least significant
		/// information first, with 7 bits of information per byte of value, and the top
		/// bit as a continuation flag.
		/// </summary>
		/// <param name="p_Value">The 7-bit encoded integer to write to the stream</param>
        public virtual void Write7BitEncodedInt(int p_Value)
		{
			CheckDisposed();
			/*if (value < 0)
			{
				throw new ArgumentOutOfRangeException("value", "Value must be greater than or equal to 0.");
			}
			int index=0;
			while (value >= 128)
			{
				buffer[index++]= (byte)((value&0x7f) | 0x80);
				value = value >> 7;
				index++;
			}
			buffer[index++]=(byte)value;
			stream.Write(buffer, 0, index);*/

		    var s_Value = (uint) p_Value;

		    do
		    {
		        var c = (byte) (s_Value & 0x7F);
		        s_Value >>= 7;

		        if (s_Value != 0)
		            c |= 0x80;

		        Write(c);
		    } 
            while (s_Value != 0);
		}

		#endregion

		#region Private methods
		/// <summary>
		/// Checks whether or not the writer has been disposed, throwing an exception if so.
		/// </summary>
		void CheckDisposed()
		{
			if (m_Disposed)
			{
				throw new ObjectDisposedException("EndianBinaryWriter");
			}
		}

		/// <summary>
		/// Writes the specified number of bytes from the start of the given byte array,
		/// after checking whether or not the writer has been disposed.
		/// </summary>
		/// <param name="p_Bytes">The array of bytes to write from</param>
		/// <param name="p_Length">The number of bytes to write</param>
        protected virtual void WriteInternal(byte[] p_Bytes, int p_Length)
		{
			CheckDisposed();
			m_Stream.Write(p_Bytes, 0, p_Length);
		}
		#endregion

		#region IDisposable Members
		/// <summary>
		/// Disposes of the underlying stream.
		/// </summary>
		public void Dispose()
		{
			if (!m_Disposed)
			{
				Flush();
				m_Disposed = true;
				((IDisposable)m_Stream).Dispose();
			}
		}
		#endregion
	}
}
