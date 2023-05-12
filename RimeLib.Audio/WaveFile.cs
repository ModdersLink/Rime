using System;
using System.Transactions;
using RimeLib.IO;

namespace RimeLib.Audio;

public class WaveFile
{
	// https://tech.ebu.ch/docs/tech/tech3306v1_0.pdf
	// does good reading of chunks
	// https://github.com/rochars/wavefile/blob/f9311ad2b98419386f9b0630918af16ef1ad829a/lib/wavefile-reader.js#L524

	// https://exiftool.org/TagNames/RIFF.html#Info has good docs
	
	
	class DataSize64 // "ds64"
	{
		private ulong RiffSize { get; set; } //0x0000
		private ulong DataSize { get; set; } //0x0008
		private uint OriginationTime { get; set; } //0x0010
		private ulong SampleCount { get; set; } //0x0014
	}; //0x001C

	public class AudioFormat //"fmt "
	{
		public enum AudioFormatType
		{
			// fuck this
			
			// This should be enough for now
			Ms_PCM = 0x1,
			Ms_ADPCM = 0x2,
			Ms_IEEE_float = 0x3,
			
			
			Extensible = 0xFFFE,
		}
		
		
		public AudioFormatType Format { get; set; } //0x0000 AudioFormatType
		public ushort NumChannels { get; set; } //0x0002
		public uint SampleRate { get; set; } //0x0004
		public uint AvgBytesPerSec { get; set; } //0x0008
		public ushort BlockAlign { get; set; } //0x000C
		public ushort BitsPerSample { get; set; } //0x000E
		
		// optional
		public ushort Size { get; set; } //0x0010


		public virtual void Serialize(RimeWriter p_Writer)
		{
			p_Writer.Write((ushort)Format);
			p_Writer.Write(NumChannels);
			p_Writer.Write(SampleRate);
			p_Writer.Write(AvgBytesPerSec);
			p_Writer.Write(BlockAlign);
			p_Writer.Write(BitsPerSample);
			p_Writer.Write(Size);
		}
	} //0x0010 - 0x0012


	public class AudioFormatExtended
		: AudioFormat
	{
		public ushort BitsPerSample2 { get; set; } //0x0012
		public uint ChannelMask { get; set; } //0x0014
		public byte[] Guid { get; set; } = new byte[0x10]; //0x0018
		
		public override void Serialize(RimeWriter p_Writer)
		{
			base.Size = 0x16;
			
			base.Serialize(p_Writer);
			p_Writer.Write(BitsPerSample2);
			p_Writer.Write(ChannelMask);
			p_Writer.Write(Guid);
		}
	} //0x0028
	

	public class FACT // "fact"
	{
		public uint SampleLength { get; set; } //0x0000
		
		public virtual void Serialize(RimeWriter p_Writer)
		{
			p_Writer.Write(SampleLength);
		}
	} //0x0004
	
	
	class BroadcastExtension // "bext"
	{
		private string Description { get; set; } = string.Empty; //0x0000 - 256
		private string Originator { get; set; } = string.Empty; //0x0100 - 32
		private string OriginatorReference { get; set; } = string.Empty; //0x0120 - 32
		private string OriginationDate { get; set; } = string.Empty; //0x0140 - 10
		private string OriginationTime { get; set; } = string.Empty; //0x014A - 8
		private uint[] TimeReference = new uint[2]; //0x0152 - 4*2
		private ushort Version { get; set; } //0x015a
		private string Umid { get; set; } = string.Empty; //0x015c - 64
		private ushort LoudnessValue { get; set; } //0x019C
		private ushort LoudnessRange { get; set; } //0x019E
		private ushort MaxTruePeakLevel { get; set; } //0x01A0
		private ushort MaxMomentaryLoudness { get; set; } //0x01A2
		private ushort MaxShortTermLoudness { get; set; } //0x01A4
		private byte[] _reserved = new byte[180];
		private string CodingHistory { get; set; } = String.Empty; //0x025A
	}

	class CuePoints // "cue "
	{
		class Point
		{
			private uint Name { get; set; }
			private uint Position { get; set; }
			private uint FccChunk { get; set; }
			private uint ChunkStart { get; set; }
			private uint BlockStart { get; set; }
			private uint SampleOffset { get; set; }
		}

		private Point[] Points = new Point[0];
	}
	
	
}
