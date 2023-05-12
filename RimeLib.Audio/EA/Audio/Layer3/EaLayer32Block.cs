using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using RimeLib.Frostbite;
using RimeLib.IO;
using RimeLib.IO.Conversion;

namespace RimeLib.Audio.EA.Audio.Layer3;

public class EaLayer32Block : IFbSerializable
{

	public uint GranuleOffset { get; set; } = 2;
	public uint GranuleSize { get; set; }


	public uint PcmDataOffset { get; set; } = 0;
	public uint PcmSamples { get; set; } = 0;

	public uint NumChannels { get; set; }

	public uint OffsetSamples { get; set; } = 0;


	public uint BlockOffsetMode { get; set; } = 0; // BLOCKOFFSETMODE_IGNORE




	public EaLayer32Block()
	{
	}

	public EaLayer32Block(RimeReader p_Reader)
	{
		Deserialize(p_Reader);
	}

	public void Deserialize(RimeReader p_Reader)
	{
		var s_LastEndianess = p_Reader.Endianness;
		p_Reader.Endianness = Endianness.BigEndian;

		var s_A1 = p_Reader.ReadUInt16();

		GranuleSize = (uint)s_A1 & 0xFFF;
		NumChannels = 1;
		if ((s_A1 & 0x4000) != 0)
			NumChannels = 2;


		if ((s_A1 & 0x8000) != 0)
		{
			var s_A2 = p_Reader.ReadUInt32();

			BlockOffsetMode = (s_A2 >> 30) & 3;
			OffsetSamples = (s_A2 >> 20) & 0x3FF;
			PcmSamples = (s_A2 >> 10) & 0x3FF;
			GranuleSize = s_A2 & 0x3FF;

			
			// 6 = sizeof(s_A1) + sizeof(s_A2)
			PcmDataOffset = GranuleSize + 6;

			GranuleOffset = 0;
			if (GranuleSize != 0)
				GranuleOffset = 6;
		}
		

		p_Reader.Endianness = s_LastEndianess;
		
	
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