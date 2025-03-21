using System.IO;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite.Core;
using RimeLib.IO;

namespace RimeLib.Content.Frostbite2_0.Mounting;

internal class InlineReadable : IReadableObjectWithHash
{
	protected byte[] m_Data;
	
	protected Sha1 m_Hash;
	protected bool m_Compressed;

	public InlineReadable(byte[] p_Data, Sha1 p_Hash, bool p_Compressed)
	{
	   m_Data = p_Data;
	   m_Hash = p_Hash;
	   m_Compressed = p_Compressed;
	}

	public RimeReader GetReader()
	{
	   var s_Reader = new RimeReader(new MemoryStream(m_Data));

	   // If we're compressed, wrap in a Zlib reader.
	   if (m_Compressed)
	   {
		   s_Reader = new ZlibRimeReader(s_Reader);

		   // Wrap this inside a limited reader as well.
		   s_Reader = new LimitedRimeReader(s_Reader, s_Reader.Length);;
	   }

	   return s_Reader;
	}

	public long GetSize()
	{
	   using var s_Reader = GetReader();
	   return s_Reader.Length;
	}

	public Sha1? GetSha1()
	{
	   if (m_Compressed)
		   return null;

	   return m_Hash;
	}
}