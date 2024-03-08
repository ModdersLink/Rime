using System.Diagnostics.CodeAnalysis;
using RimeLib.Frostbite;
using RimeLib.IO;
using RimeLib.IO.Conversion;


namespace RimeLib.Content.Frostbite2013_2.Frostbite.Patch;

public class PatchDecompressedSegment  : IFbSerializable
{
	public ushort BaseDataPosition { get; set; }
	public byte BaseSkip { get; set; }
	public byte PatchSize { get; set; }
	
	public PatchDecompressedSegment()
	{
	}

	public PatchDecompressedSegment(RimeReader p_Reader)
	{
		Deserialize(p_Reader);
	}

	public void Deserialize(RimeReader p_Reader)
	{
		var s_LastEndianess = p_Reader.Endianness;
		p_Reader.Endianness = Endianness.BigEndian;
		
		BaseDataPosition = p_Reader.ReadUInt16();
		BaseSkip = p_Reader.ReadUByte();
		PatchSize = p_Reader.ReadUByte();

		p_Reader.Endianness = s_LastEndianess;
	}

	public bool Serialize(RimeWriter p_Writer)
	{
		p_Writer.Write(BaseDataPosition);
		p_Writer.Write(BaseSkip);
		p_Writer.Write(PatchSize);

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