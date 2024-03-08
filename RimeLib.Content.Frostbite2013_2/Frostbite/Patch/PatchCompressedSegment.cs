using System.Diagnostics.CodeAnalysis;
using RimeLib.Frostbite;
using RimeLib.IO;
using RimeLib.IO.Conversion;


namespace RimeLib.Content.Frostbite2013_2.Frostbite.Patch;

public class PatchCompressedSegment  : IFbSerializable
{
	public ushort UncompressedOffset { get; set; }
	public ushort UncompressedSize { get; set; }

	public PatchCompressedSegment()
	{

	}

	public PatchCompressedSegment(RimeReader p_Reader)
	{
		Deserialize(p_Reader);
	}

	public void Deserialize(RimeReader p_Reader)
	{
		var s_LastEndianess = p_Reader.Endianness;
		p_Reader.Endianness = Endianness.BigEndian;

		UncompressedOffset = p_Reader.ReadUInt16();
		UncompressedSize = p_Reader.ReadUInt16();

		p_Reader.Endianness = s_LastEndianess;
	}

	public bool Serialize(RimeWriter p_Writer)
	{
		p_Writer.Write(UncompressedOffset);
		p_Writer.Write(UncompressedSize);

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