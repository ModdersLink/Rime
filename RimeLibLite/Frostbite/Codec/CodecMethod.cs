using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimeLib.Frostbite.Codec
{
	public enum CodecMethod
	{
		// TODO: what is segmented?

		None = 0,
		RefPack = 1,
		Zlib = 2,

		LZO = 3,
		LZMA = 4,
		LZF = 5,
		SegmentedZlib = 6,
		LZHAM = 7,
		Snappy = 8,
		LZ4 = 9,
		LZ4BigEndian = 10,
		SegmentedLZ4 = 11,
		SegmentedNone = 12,

		Zstd = 15,
		SegmentedZstd = 16, // unconfirmed

		// oodle has diffrent methods
		// check decompressor code and match enum at https://github.com/JKAnderson/SoulsFormats/blob/master/SoulsFormats/Util/Oodle26.cs#L192
        
		// checked in pvz neighbourville
		Oodle_Kraken = 17,
		Oodle_Kraken_Segmented = 18, // unconfirmed
		Oodle_Mermaid = 19,
		Oodle_Mermaid_Segmented = 20, // unconfirmed
		Oodle_Selkie = 21,
		Oodle_Selkie_Segmented = 22, // unconfirmed
		Oodle_Hydra = 23,
		Oodle_Hydra_Segmented = 24, // unconfirmed
		Oodle_Leviathan = 25,
		Oodle_Leviathan_Segmented = 26, // unconfirmed
        
        
        
		Count
	}
}