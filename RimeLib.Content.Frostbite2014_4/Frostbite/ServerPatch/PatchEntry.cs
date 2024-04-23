using System.Diagnostics.CodeAnalysis;
using RimeLib.Frostbite;
using RimeLib.IO;

namespace RimeLib.Content.Frostbite2014_4.Frostbite.ServerPatch;

public class PatchEntry : IFbSerializable
{
	public uint Index { get; set; } = 0;

	public uint PayloadOffset { get; set; } = 0;
	

	public PatchEntry()
	{
	}

	public PatchEntry(RimeReader p_Reader)
	{
		Deserialize(p_Reader);
	}
	
	public void Deserialize(RimeReader p_Reader)
	{
		Index = p_Reader.Read7Bit();
		PayloadOffset = p_Reader.Read7Bit();
	}

	public bool Serialize(RimeWriter p_Writer)
	{
		p_Writer.Encode7Bit(Index);
		p_Writer.Encode7Bit(PayloadOffset);
		
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