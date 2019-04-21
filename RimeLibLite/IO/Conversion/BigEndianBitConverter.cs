
namespace RimeLib.IO.Conversion
{
	/// <summary>
	/// Implementation of EndianBitConverter which converts to/from big-endian
	/// byte arrays.
	/// </summary>
	public sealed class BigEndianBitConverter : EndianBitConverter
	{
		/// <summary>
		/// Indicates the byte order ("endianess") in which data is converted using this class.
		/// </summary>
		/// <remarks>
		/// Different computer architectures store data using different byte orders. "Big-endian"
		/// means the most significant byte is on the left end of a word. "Little-endian" means the 
		/// most significant byte is on the right end of a word.
		/// </remarks>
		/// <returns>true if this converter is little-endian, false otherwise.</returns>
		public sealed override bool IsLittleEndian()
		{
			return false;
		}

		/// <summary>
		/// Indicates the byte order ("endianess") in which data is converted using this class.
		/// </summary>
		public sealed override Endianness Endianness 
		{ 
			get { return Endianness.BigEndian; }
		}

		/// <summary>
		/// Copies the specified number of bytes from value to buffer, starting at index.
		/// </summary>
		/// <param name="p_Value">The value to copy</param>
		/// <param name="p_Bytes">The number of bytes to copy</param>
		/// <param name="p_Buffer">The buffer to copy the bytes into</param>
		/// <param name="p_Index">The index to start at</param>
		protected override void CopyBytesImpl(long p_Value, int p_Bytes, byte[] p_Buffer, int p_Index)
		{
			int endOffset = p_Index+p_Bytes-1;
			for (int i=0; i < p_Bytes; i++)
			{
				p_Buffer[endOffset-i] = unchecked((byte)(p_Value&0xff));
				p_Value = p_Value >> 8;
			}
		}
		
		/// <summary>
		/// Returns a value built from the specified number of bytes from the given buffer,
		/// starting at index.
		/// </summary>
		/// <param name="p_Buffer">The data in byte array format</param>
		/// <param name="p_StartIndex">The first index to use</param>
		/// <param name="p_BytesToConvert">The number of bytes to use</param>
		/// <returns>The value built from the given bytes</returns>
		protected override long FromBytes(byte[] p_Buffer, int p_StartIndex, int p_BytesToConvert)
		{
			long ret = 0;
			for (int i=0; i < p_BytesToConvert; i++)
			{
				ret = unchecked((ret << 8) | p_Buffer[p_StartIndex+i]);
			}
			return ret;
		}
	}
}
