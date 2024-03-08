using System.Diagnostics.CodeAnalysis;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.IO;

namespace RimeLib.Content.Frostbite2013_2.Frostbite.Cas;

public class CatalogEntry : IFbSerializable
{
	public Sha1 Hash { get; set; } = new();
	public uint FileOffset { get; set; } = 0;
	public uint FileSize { get; set; } = 0;
	public uint FileNumber { get; set; } = 0;
	public Catalog ContainedCatalog { get; set; }

	public CatalogEntry(Catalog p_ContainedCatalog)
	{
		ContainedCatalog = p_ContainedCatalog;
	}

	public CatalogEntry(RimeReader p_Reader, Catalog p_ContainedCatalog)
	{
		ContainedCatalog = p_ContainedCatalog;
		Deserialize(p_Reader);
	}

	public bool Serialize(RimeWriter p_Writer)
	{
		if (!Hash.Serialize(p_Writer))
			return false;

		p_Writer.Write(FileOffset);
		p_Writer.Write(FileSize);
		p_Writer.Write(FileNumber);

		return true;
	}

	public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
	{
		p_Data = null;

		using (var s_Writer = new RimeWriter(new MemoryStream()))
		{
			this.Serialize(s_Writer);

			p_Data = ((MemoryStream) s_Writer.BaseStream).ToArray();
		}

		return true;
	}

	public void Deserialize(RimeReader p_Reader)
	{
		Hash = new Sha1(p_Reader);
		FileOffset = p_Reader.ReadUInt32();
		FileSize = p_Reader.ReadUInt32();
		FileNumber = p_Reader.ReadUInt32(); // BF4 its char with 3 bytes padding?
	}

	public void Deserialize(byte[] p_Data)
	{
		Deserialize(new RimeReader(new MemoryStream(p_Data)));
	}
}