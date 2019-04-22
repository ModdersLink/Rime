using System;
using System.IO;
using System.Text;
using RimeLib.IO.Conversion;

namespace RimeLib.IO
{
	/// <summary>
	/// Equivalent of System.IO.BinaryReader, but with either endianness, depending on
	/// the EndianBitConverter it is constructed with. No data is buffered in the
	/// reader; the client may seek within the stream at will.
	/// </summary>
	public abstract class EndianBinaryReader : IDisposable
	{
	    public long SetLength
	    {
	        get
	        {
	            return m_SetLength;
	        }
            set 
            { 
                if (m_HasSetLength) 
                    return;

                m_HasSetLength = true;
                m_SetLength = value;
            }
		}

		public long StartPosition { get; set; }

		public virtual long Position
		{
			get
			{
				if (m_HasSetLength)
					return m_Stream.Position - StartPosition;

				return m_Stream.Position;
			}
		}

		#region Fields not directly related to properties
		/// <summary>
		/// Whether or not this reader has been disposed yet.
		/// </summary>
		bool m_Disposed=false;
		/// <summary>
		/// Decoder to use for string conversions.
		/// </summary>
		Decoder m_Decoder;
		/// <summary>
		/// Buffer used for temporary storage before conversion into primitives
		/// </summary>
		byte[] m_Buffer = new byte[16];
		/// <summary>
		/// Buffer used for temporary storage when reading a single character
		/// </summary>
		char[] m_CharBuffer = new char[1];
		/// <summary>
		/// Minimum number of bytes used to encode a character
		/// </summary>
        int m_MinBytesPerChar;

        protected bool m_HasSetLength = false;
	    protected long m_SetLength;
		#endregion

		#region Constructors
		/// <summary>
		/// Equivalent of System.IO.BinaryWriter, but with either endianness, depending on
		/// the EndianBitConverter it is constructed with.
		/// </summary>
		/// <param name="p_BitConverter">Converter to use when reading data</param>
		/// <param name="p_Stream">Stream to read data from</param>
		protected EndianBinaryReader (EndianBitConverter p_BitConverter,
								   Stream p_Stream) : this (p_BitConverter, p_Stream, Encoding.UTF8)
		{
		}

		/// <summary>
		/// Constructs a new binary reader with the given bit converter, reading
		/// to the given stream, using the given encoding.
		/// </summary>
		/// <param name="p_BitConverter">Converter to use when reading data</param>
		/// <param name="p_Stream">Stream to read data from</param>
		/// <param name="p_Encoding">Encoding to use when reading character data</param>
		protected EndianBinaryReader (EndianBitConverter p_BitConverter,	Stream p_Stream, Encoding p_Encoding)
		{
			if (p_BitConverter==null)
			{
				throw new ArgumentNullException("p_BitConverter");
			}

			if (p_Encoding==null)
			{
				throw new ArgumentNullException("p_Encoding");
			}

			if (p_Stream != null && !p_Stream.CanRead)
			{
				throw new ArgumentException("Stream isn't writable", "p_Stream");
			}

			this.m_Stream = p_Stream;
			this.m_BitConverter = p_BitConverter;
			this.m_Encoding = p_Encoding;
			this.m_Decoder = p_Encoding.GetDecoder();
			this.m_MinBytesPerChar = 1;

			if (p_Encoding is UnicodeEncoding)
			{
				m_MinBytesPerChar = 2;
			}
		}
		#endregion

		#region Properties
		protected EndianBitConverter m_BitConverter;
		/// <summary>
		/// The bit converter used to read values from the stream
		/// </summary>
		public EndianBitConverter BitConverter
		{
			get { return m_BitConverter; }
		}

		Encoding m_Encoding;
		/// <summary>
		/// The encoding used to read strings
		/// </summary>
		public Encoding Encoding
		{
			get { return m_Encoding; }
		}

		Stream m_Stream;
		/// <summary>
		/// Gets the underlying stream of the EndianBinaryReader.
		/// </summary>
		public Stream BaseStream
		{
			get { return m_Stream; }
		}
		#endregion
	
		#region Public methods
		/// <summary>
		/// Closes the reader, including the underlying stream..
		/// </summary>
		public virtual void Close()
		{
			Dispose();
		}

	    /// <summary>
	    /// Seeks within the stream.
	    /// </summary>
	    /// <param name="p_Offset">Offset to seek to.</param>
	    /// <param name="p_Origin">Origin of seek operation.</param>
	    public virtual void Seek(long p_Offset, SeekOrigin p_Origin)
		{
			CheckDisposed();

			if (m_HasSetLength)
		    {
				// Custom handling for readers with set length and custom start.
			    switch (p_Origin)
			    {
				    case SeekOrigin.Begin:
					    m_Stream.Seek(StartPosition + p_Offset, SeekOrigin.Begin);
					    break;

					case SeekOrigin.End:
					    m_Stream.Seek(StartPosition + m_SetLength + p_Offset, SeekOrigin.Begin);
					    break;

					case SeekOrigin.Current:
					    if (m_Stream.Position + p_Offset > StartPosition + m_SetLength)
						    throw new ArgumentOutOfRangeException(nameof(p_Offset), "Tried to seek beyond the end of the stream.");

					    m_Stream.Seek(p_Offset, SeekOrigin.Current);
					    break;
			    }

			    return;
		    }

			m_Stream.Seek(p_Offset, p_Origin);
		}

		/// <summary>
		/// Reads a single byte from the stream.
		/// </summary>
		/// <returns>The byte read</returns>
        public virtual byte ReadByte()
		{
			ReadInternal(m_Buffer, 1);
			return m_Buffer[0];
		}

		/// <summary>
		/// Reads a single signed byte from the stream.
		/// </summary>
		/// <returns>The byte read</returns>
        public virtual sbyte ReadSByte()
		{
			ReadInternal(m_Buffer, 1);
			return unchecked((sbyte)m_Buffer[0]);
		}

		/// <summary>
		/// Reads a boolean from the stream. 1 byte is read.
		/// </summary>
		/// <returns>The boolean read</returns>
        public virtual bool ReadBoolean()
		{
			ReadInternal(m_Buffer, 1);
			return m_BitConverter.ToBoolean(m_Buffer, 0);
		}

		/// <summary>
		/// Reads a 16-bit signed integer from the stream, using the bit converter
		/// for this reader. 2 bytes are read.
		/// </summary>
		/// <returns>The 16-bit integer read</returns>
        public virtual short ReadInt16()
		{
			ReadInternal(m_Buffer, 2);
			return m_BitConverter.ToInt16(m_Buffer, 0);
		}

		/// <summary>
		/// Reads a 32-bit signed integer from the stream, using the bit converter
		/// for this reader. 4 bytes are read.
		/// </summary>
		/// <returns>The 32-bit integer read</returns>
        public virtual int ReadInt32()
		{
			ReadInternal(m_Buffer, 4);
			return m_BitConverter.ToInt32(m_Buffer, 0);
		}

		/// <summary>
		/// Reads a 64-bit signed integer from the stream, using the bit converter
		/// for this reader. 8 bytes are read.
		/// </summary>
		/// <returns>The 64-bit integer read</returns>
        public virtual long ReadInt64()
		{
			ReadInternal(m_Buffer, 8);
			return m_BitConverter.ToInt64(m_Buffer, 0);
		}

		/// <summary>
		/// Reads a 16-bit unsigned integer from the stream, using the bit converter
		/// for this reader. 2 bytes are read.
		/// </summary>
		/// <returns>The 16-bit unsigned integer read</returns>
        public virtual ushort ReadUInt16()
		{
			ReadInternal(m_Buffer, 2);
			return m_BitConverter.ToUInt16(m_Buffer, 0);
		}

		/// <summary>
		/// Reads a 32-bit unsigned integer from the stream, using the bit converter
		/// for this reader. 4 bytes are read.
		/// </summary>
		/// <returns>The 32-bit unsigned integer read</returns>
        public virtual uint ReadUInt32()
		{
			ReadInternal(m_Buffer, 4);
			return m_BitConverter.ToUInt32(m_Buffer, 0);
		}

		/// <summary>
		/// Reads a 64-bit unsigned integer from the stream, using the bit converter
		/// for this reader. 8 bytes are read.
		/// </summary>
		/// <returns>The 64-bit unsigned integer read</returns>
        public virtual ulong ReadUInt64()
		{
			ReadInternal(m_Buffer, 8);
			return m_BitConverter.ToUInt64(m_Buffer, 0);
		}

		/// <summary>
		/// Reads a single-precision floating-point value from the stream, using the bit converter
		/// for this reader. 4 bytes are read.
		/// </summary>
		/// <returns>The floating point value read</returns>
        public virtual float ReadSingle()
		{
			ReadInternal(m_Buffer, 4);
			return m_BitConverter.ToSingle(m_Buffer, 0);
		}

		/// <summary>
		/// Reads a double-precision floating-point value from the stream, using the bit converter
		/// for this reader. 8 bytes are read.
		/// </summary>
		/// <returns>The floating point value read</returns>
        public virtual double ReadDouble()
		{
			ReadInternal(m_Buffer, 8);
			return m_BitConverter.ToDouble(m_Buffer, 0);
		}

		/// <summary>
		/// Reads a decimal value from the stream, using the bit converter
		/// for this reader. 16 bytes are read.
		/// </summary>
		/// <returns>The decimal value read</returns>
        public virtual decimal ReadDecimal()
		{
			ReadInternal(m_Buffer, 16);
			return m_BitConverter.ToDecimal(m_Buffer, 0);
		}

		/// <summary>
		/// Reads a single character from the stream, using the character encoding for
		/// this reader. If no characters have been fully read by the time the stream ends,
		/// -1 is returned.
		/// </summary>
		/// <returns>The character read, or -1 for end of stream.</returns>
        public virtual int Read()
		{
			int charsRead = Read(m_CharBuffer, 0, 1);
			if (charsRead==0)
			{
				return -1;
			}
			else
			{
				return m_CharBuffer[0];
			}
		}

		/// <summary>
		/// Reads the specified number of characters into the given buffer, starting at
		/// the given index.
		/// </summary>
		/// <param name="p_Data">The buffer to copy data into</param>
		/// <param name="p_Index">The first index to copy data into</param>
		/// <param name="p_Count">The number of characters to read</param>
		/// <returns>The number of characters actually read. This will only be less than
		/// the requested number of characters if the end of the stream is reached.
		/// </returns>
        public virtual int Read(char[] p_Data, int p_Index, int p_Count)
		{
			CheckDisposed();
			if (m_Buffer==null)
			{
				throw new ArgumentNullException("buffer");
			}
			if (p_Index < 0)
			{
				throw new ArgumentOutOfRangeException("p_Index");
			}
			if (p_Count < 0)
			{
				throw new ArgumentOutOfRangeException("p_Index");
			}
			if (p_Count+p_Index > p_Data.Length)
			{
				throw new ArgumentException
					("Not enough space in buffer for specified number of characters starting at specified index");
			}

			int read=0;
			bool firstTime=true;

			// Use the normal buffer if we're only reading a small amount, otherwise
			// use at most 4K at a time.
			byte[] byteBuffer = m_Buffer;

			if (byteBuffer.Length < p_Count*m_MinBytesPerChar)
			{
				byteBuffer = new byte[4096];
			}

			while (read < p_Count)
			{
				int amountToRead;
				// First time through we know we haven't previously read any data
				if (firstTime)
				{
					amountToRead = p_Count*m_MinBytesPerChar;
					firstTime=false;
				}
				// After that we can only assume we need to fully read "chars left -1" characters
				// and a single byte of the character we may be in the middle of
				else
				{
					amountToRead = ((p_Count-read-1)*m_MinBytesPerChar)+1;
				}
				if (amountToRead > byteBuffer.Length)
				{
					amountToRead = byteBuffer.Length;
				}
				int bytesRead = TryReadInternal(byteBuffer, amountToRead);
				if (bytesRead==0)
				{
					return read;
				}
				int decoded = m_Decoder.GetChars(byteBuffer, 0, bytesRead, p_Data, p_Index);
				read += decoded;
				p_Index += decoded;
			}
			return read;
		}

	    /// <summary>
	    /// Reads the specified number of bytes into the given buffer, starting at
	    /// the given index.
	    /// </summary>
	    /// <param name="p_Data">The buffer to copy data into</param>
	    /// <param name="p_Index">The first index to copy data into</param>
	    /// <param name="p_Count"></param>
	    /// <returns>The number of bytes actually read. This will only be less than
	    /// the requested number of bytes if the end of the stream is reached.
	    /// </returns>
	    public virtual int Read(byte[] p_Data, int p_Index, int p_Count)
		{
			CheckDisposed();
			if (p_Data==null)
			{
				throw new ArgumentNullException("p_Data");
			}
			if (p_Index < 0)
			{
				throw new ArgumentOutOfRangeException("p_Index");
			}
			if (p_Count < 0)
			{
				throw new ArgumentOutOfRangeException("p_Index");
			}
			if (p_Count+p_Index > p_Data.Length)
			{
				throw new ArgumentException
					("Not enough space in buffer for specified number of bytes starting at specified index");
			}
			
			if (m_HasSetLength && m_Stream.Position + p_Count > StartPosition + m_SetLength)
                p_Count = (int) ((StartPosition + m_SetLength) - m_Stream.Position);

			int read=0;
			while (p_Count > 0)
			{
				int block = m_Stream.Read(p_Data, p_Index, p_Count);
				if (block==0)
                {
					return read;
				}
				p_Index += block;
				read += block;
				p_Count -= block;
			}

			return read;
		}

	    /// <summary>
	    /// Reads the specified number of bytes, returning them in a new byte array.
	    /// If not enough bytes are available before the end of the stream, this
	    /// method will return what is available.
	    /// </summary>
	    /// <param name="p_Count">The number of bytes to read</param>
	    /// <returns>The bytes read</returns>
	    public virtual byte[] ReadBytes(int p_Count)
		{
			CheckDisposed();
			if (p_Count < 0)
			{
				throw new ArgumentOutOfRangeException("p_Count");
            }

            if (m_HasSetLength && m_Stream.Position + p_Count > StartPosition + m_SetLength)
                p_Count = (int) ((StartPosition + m_SetLength) - m_Stream.Position);

			byte[] ret = new byte[p_Count];
			int index=0;
			while (index < p_Count)
			{
				int read = m_Stream.Read(ret, index, (int) (p_Count-index));
				// Stream has finished half way through. That's fine, return what we've got.
				if (read==0)
				{
					byte[] copy = new byte[index];
					Buffer.BlockCopy(ret, 0, copy, 0, index);
					
					return copy;
				}
				index += read;
            }

			return ret;
		}

		/// <summary>
		/// Reads the specified number of bytes, returning them in a new byte array.
		/// If not enough bytes are available before the end of the stream, this
		/// method will throw an IOException.
		/// </summary>
		/// <param name="p_Count">The number of bytes to read</param>
		/// <returns>The bytes read</returns>
        public virtual byte[] ReadBytesOrThrow(int p_Count)
		{
			byte[] ret = new byte[p_Count];
			ReadInternal(ret, p_Count);
			return ret;
		}

		/// <summary>
		/// Reads a 7-bit encoded integer from the stream. This is stored with the least significant
		/// information first, with 7 bits of information per byte of value, and the top
		/// bit as a continuation flag. This method is not affected by the endianness
		/// of the bit converter.
		/// </summary>
		/// <returns>The 7-bit encoded integer read from the stream.</returns>
        public virtual int Read7BitEncodedInt()
		{
			CheckDisposed();

			/*int ret=0;
			for (int shift = 0; shift < 35; shift+=7)
			{
				int b = stream.ReadByte();
				if (b==-1)
				{
					throw new EndOfStreamException();
				}
				ret = ret | ((b&0x7f) << shift);
				if ((b & 0x80) == 0)
				{
					return ret;
				}
			}
			// Still haven't seen a byte with the high bit unset? Dodgy data.
			throw new IOException("Invalid 7-bit encoded integer in stream.");*/

            byte c;
		    uint s_Value = 0;
		    int s = 0;

		    do
		    {
		        c = ReadByte();
		        var x = (uint) (c & 0x7F);
		        x <<= s;
		        s_Value += x;
		        s += 7;
		    } 
            while ((c & 0x80) != 0);

		    return (int) s_Value;
		}

		/// <summary>
		/// Reads a 7-bit encoded integer from the stream. This is stored with the most significant
		/// information first, with 7 bits of information per byte of value, and the top
		/// bit as a continuation flag. This method is not affected by the endianness
		/// of the bit converter.
		/// </summary>
		/// <returns>The 7-bit encoded integer read from the stream.</returns>
        public virtual int ReadBigEndian7BitEncodedInt()
		{
			CheckDisposed();

			int ret=0;
			for (int i=0; i < 5; i++)
			{
				int b = m_Stream.ReadByte();
				if (b==-1)
				{
					throw new EndOfStreamException();
				}
				ret = (ret << 7) | (b&0x7f);
				if ((b & 0x80) == 0)
				{
					return ret;
				}
			}
			// Still haven't seen a byte with the high bit unset? Dodgy data.
			throw new IOException("Invalid 7-bit encoded integer in stream.");
		}

		/// <summary>
		/// Reads a length-prefixed string from the stream, using the encoding for this reader.
		/// A 7-bit encoded integer is first read, which specifies the number of bytes 
		/// to read from the stream. These bytes are then converted into a string with
		/// the encoding for this reader.
		/// </summary>
		/// <returns>The string read from the stream.</returns>
        public virtual string ReadString()
		{
			int bytesToRead = Read7BitEncodedInt();

			byte[] data = new byte[bytesToRead];
			ReadInternal(data, bytesToRead);
			return m_Encoding.GetString(data, 0, data.Length);
		}

		#endregion

		#region Private methods
		/// <summary>
		/// Checks whether or not the reader has been disposed, throwing an exception if so.
		/// </summary>
		protected void CheckDisposed()
		{
			if (m_Disposed)
			{
				throw new ObjectDisposedException("EndianBinaryReader");
			}
		}

		/// <summary>
		/// Reads the given number of bytes from the stream, throwing an exception
		/// if they can't all be read.
		/// </summary>
		/// <param name="p_Data">Buffer to read into</param>
		/// <param name="p_Size">Number of bytes to read</param>
        protected virtual void ReadInternal(byte[] p_Data, int p_Size)
		{
			CheckDisposed();
			
			if (m_HasSetLength && m_Stream.Position + p_Size > StartPosition + m_SetLength)
				p_Size = (int)((StartPosition + m_SetLength) - m_Stream.Position);

			int index=0;
			while (index < p_Size)
			{
				int read = m_Stream.Read(p_Data, index, p_Size-index);
				if (read==0)
                {
					throw new EndOfStreamException
						($"End of stream reached with {p_Size - index} byte{(p_Size - index == 1 ? "s" : "")} left to read.");
				}
				index += read;
			}
		}

		/// <summary>
		/// Reads the given number of bytes from the stream if possible, returning
		/// the number of bytes actually read, which may be less than requested if
		/// (and only if) the end of the stream is reached.
		/// </summary>
		/// <param name="p_Data">Buffer to read into</param>
		/// <param name="p_Size">Number of bytes to read</param>
		/// <returns>Number of bytes actually read</returns>
        protected virtual int TryReadInternal(byte[] p_Data, int p_Size)
		{
			CheckDisposed();

			if (m_HasSetLength && m_Stream.Position + p_Size > StartPosition + m_SetLength)
				p_Size = (int)((StartPosition + m_SetLength) - m_Stream.Position);

			int index=0;
			while (index < p_Size)
			{
				int read = m_Stream.Read(p_Data, index, p_Size-index);
				if (read==0)
                {
					return index;
				}
				index += read;
			}

			return index;
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
				m_Disposed = true;
				((IDisposable)m_Stream).Dispose();
			}
		}
		#endregion
	}
}
