using RimeLib.Content.Frostbite2014_4.Frostbite.Cas;
using RimeLib.Frostbite.Core;
using RimeLib.IO;

namespace RimeLib.Content.Frostbite2014_4.Frostbite.Chunks;

class CasChunkEntry : ChunkEntry
{
	public Sha1 Hash { get; set; }

	public Catalog[] ContainedCatalogs { get; set; }

	public CasChunkEntry(GUID p_Id, Sha1 p_Hash, Catalog[] p_Catalogs) : 
		base(p_Id)
	{
		Hash = p_Hash;
		ContainedCatalogs = p_Catalogs;
	}

	public override RimeReader GetReader()
	{
		if (ContainedCatalogs.Length == 0)
			throw new Exception("Catalog chunk not contained in any catalog");
		
		// just use the first one..
		var s_Reader = ContainedCatalogs[0].ReadEntry(Hash);

		// If we're compressed, wrap in a Zlib reader.
		if (Compressed)
		{
			s_Reader = new CodecRimeReader(s_Reader);

			// Wrap this inside a limited reader as well.
			s_Reader = new LimitedRimeReader(s_Reader, s_Reader.Length);;
		}

		return s_Reader;
	}

	public override long GetSize()
	{
		if (!Compressed)
			return ContainedCatalogs[0][Hash].FileSize;

		using var s_Reader = GetReader();
		return s_Reader.Length;
	}

	public override Sha1? GetSha1()
	{
		if (Compressed)
			return null;

		return Hash;
	}
}