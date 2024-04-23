using RimeLib.Content.Frostbite2014_4.Frostbite.Bundles;
using RimeLib.Content.Frostbite2014_4.Frostbite.Cas;
using RimeLib.Frostbite.Core;
using RimeLib.IO;

namespace RimeLib.Content.Frostbite2014_4.Mounting;

internal class CatalogReadable : IReadableObjectWithHash
{
	protected CatalogRegistry m_Catalog;
	protected IPatchableEntry? m_PatchEntry;
	protected Sha1 m_Hash;
	protected bool m_Compressed;

	public CatalogReadable(CatalogRegistry p_Catalog, Sha1 p_Hash, bool p_Compressed, IPatchableEntry? p_PatchedEntry = null)
	{
		m_Catalog = p_Catalog;
		m_Hash = p_Hash;
		m_Compressed = p_Compressed;
		m_PatchEntry = p_PatchedEntry;
	}

	public RimeReader GetReader()
	{
		if (m_PatchEntry != null &&
		    m_PatchEntry.CasPatchType != null)
		{

			switch (m_PatchEntry.CasPatchType!)
			{
				// if its type 1, skip
				case 1:
					break;
				
				// type 2 has patch, read it.
				case 2:
				{
					
					RimeReader s_BaseReader = m_Catalog.ReadEntry(m_PatchEntry.BaseHash!);
					RimeReader? s_DeltaReader = null;

					if (m_PatchEntry.DeltaHash != null)
						s_DeltaReader = m_Catalog.ReadEntry(m_PatchEntry.DeltaHash!);
					else if (m_PatchEntry.DeltaIndex != null)
						throw new NotImplementedException();

					if (s_DeltaReader == null)
						throw new InvalidDataException();

					
					//return new RimePatchEntryReader(s_BaseReader, s_DeltaReader);
					
					break;
				}
				default:
					throw new Exception($"Patch type [{m_PatchEntry.CasPatchType}] not supported");
			}
		}

		var s_Reader =  m_Catalog.ReadEntry(m_Hash);

		// If we're compressed, wrap in a Zlib reader.
		if (m_Compressed)
		{
			s_Reader = new CodecRimeReader(s_Reader);
			//File.WriteAllBytes("/home/txt/Documents/RE/frostbite/bfh/invalidfile.bin", s_Reader.ReadBytes((int) s_Reader.Length));

			// Wrap this inside a limited reader as well.
			s_Reader = new LimitedRimeReader(s_Reader, s_Reader.Length);;
		}

		return s_Reader;
	}

	public long GetSize()
	{
		if (!m_Compressed)
			return m_Catalog[m_Hash].FileSize;

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