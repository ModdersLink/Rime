using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using RimeLib.Frostbite;
using RimeLib.IO;

namespace RimeLib.Audio.EA.Audio.Format1;

public class ChunkHeader : IFbSerializable
{
	public ChunkType Type { get; set; } 

	public uint TotalSize { get; set; }

	public uint SizeWithoutHeader => TotalSize - 4; // sizeof(ChunkHeader)
	
	public ChunkHeader()
	{
	}

	public ChunkHeader(RimeReader p_Reader)
	{
		Deserialize(p_Reader);
	}

	public void Deserialize(RimeReader p_Reader)
	{
		Type = (ChunkType) p_Reader.ReadByte();

		var s_SizeBytes = p_Reader.ReadBytes(3);

		TotalSize = (((uint)s_SizeBytes[0] << (8 * 2)) |
		             ((uint)s_SizeBytes[1] << (8 * 1)) |
		             ((uint)s_SizeBytes[2] << (8 * 0)));
	}

	public bool Serialize(RimeWriter p_Writer)
	{
		throw new NotImplementedException();
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