using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using RimeLib.Frostbite;
using RimeLib.IO;
using RimeLib.IO.Conversion;

namespace RimeLib.Audio.EA.Audio.Layer3;

public class EALayer3Header : IFbSerializable
{

	public int Version { get; set; } 
	
	public int Mode { get; set; }
	public int ModeExt { get; set; } 
	
	public bool BigEndian { get; set; }
	public int SampleFrequency { get; set; }




	public EALayer3Header()
	{
	}

	public EALayer3Header(RimeReader p_Reader)
	{
		Deserialize(p_Reader);
	}

	public void Deserialize(RimeReader p_Reader)
	{
	
		var s_A1 = p_Reader.ReadUByte();

		var s_Ver1 = (s_A1 >> 6);
		
		Version = s_Ver1& 1;
		var s_SampleRateBits = (s_A1 >> 4) & 3;
		Mode = (s_A1 >> 2) & 3;
		ModeExt = s_A1 & 3;

		BigEndian = s_Ver1 != 3;

		SampleFrequency = s_SampleRateBits + 6;
		if (s_Ver1 != 0)
		{
			SampleFrequency = s_SampleRateBits;

			if (BigEndian)
				SampleFrequency += 3;
		}

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