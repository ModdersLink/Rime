using System.Diagnostics.CodeAnalysis;
using RimeLib.Frostbite;
using RimeLib.IO;

namespace RimeLib.Content.Frostbite2014_4.Frostbite.ServerPatch;

public class PatchedBundle : IFbSerializable
{
	public int FirstEntryIndex { get; set; } = -1;
	
	public uint BundleNameHash { get; set; } = 0;

	public uint NumEntries { get; set; } = 0;


	public PatchEntry[] Entries { get; set; } = new PatchEntry[0];
	

	public PatchedBundle(int p_FirstEntryIndex = -1)
	{
		FirstEntryIndex = p_FirstEntryIndex;
	}

	public PatchedBundle(RimeReader p_Reader, int p_FirstEntryIndex = -1)
		: this(p_FirstEntryIndex)
	{
		Deserialize(p_Reader);
	}
	
	public void Deserialize(RimeReader p_Reader)
	{
		BundleNameHash = p_Reader.Read7Bit();
		NumEntries = p_Reader.Read7Bit();
	}

	public bool Serialize(RimeWriter p_Writer)
	{
		p_Writer.Encode7Bit(BundleNameHash);
		p_Writer.Encode7Bit(NumEntries);
		
		return true;
	}

	public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
	{
		var s_Stream = new MemoryStream();
		using var s_Writer = new RimeWriter(s_Stream);

		if (Serialize(s_Writer))
		{
			p_Data = s_Stream.ToArray();
			return true;
		}

		p_Data = null;
		return false;
	}

	
	public void Deserialize(byte[] p_Data)
	{
		using var s_Reader = new RimeReader(new MemoryStream(p_Data));
		Deserialize(s_Reader);
	}
}