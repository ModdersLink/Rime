using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using RimeLib.Frostbite;
using RimeLib.IO;

namespace RimeLib.Audio.EA.Audio;

public class SndPlayerAssetHeader : IFbSerializable
{
	public uint FormatVersion { get; set; } = 1;
	public SndPlayerCodec Decoder { get; set; }
	public SndPlayerPlayType PlayType { get; set; }
	
	public uint NumChannels { get; set; }
	public uint SampleRate { get; set; }
	public uint NumSamples { get; set; }
	

	public int LoopStart { get; set; } = -1;
	public uint GigaSamplesInRam { get; set; } = 0;
	public uint LoopStartStreamOffset { get; set; }

	public SndPlayerAssetHeader()
	{
	}

	public SndPlayerAssetHeader(RimeReader p_Reader)
	{
		Deserialize(p_Reader);
	}

	public void Deserialize(RimeReader p_Reader)
	{
		var s_BitReader = new BitReader(p_Reader);

		FormatVersion = (uint) s_BitReader.ReadUIntHigh(4);
		Decoder = (SndPlayerCodec) s_BitReader.ReadUIntHigh(4);
		
		NumChannels = (uint) s_BitReader.ReadUIntHigh(6) + 1;
		SampleRate = (uint) s_BitReader.ReadUIntHigh(18);
		
		PlayType = (SndPlayerPlayType) s_BitReader.ReadUIntHigh(2);

		var s_IsLooping = s_BitReader.ReadHighBit();
		
		NumSamples = (uint) s_BitReader.ReadUIntHigh(29);
		
		if (s_IsLooping)
			LoopStart = (int) s_BitReader.ReadIntHigh(32);
		
		if (PlayType == SndPlayerPlayType.GigaSample)
			GigaSamplesInRam = (uint) s_BitReader.ReadUIntHigh(32);

		if (s_IsLooping)
		{
			if (PlayType == SndPlayerPlayType.Stream ||
			    (PlayType == SndPlayerPlayType.GigaSample && LoopStart >= GigaSamplesInRam))
			{
				LoopStartStreamOffset = (uint) s_BitReader.ReadUIntHigh(32);
			}
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