///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// As type schemas dont contain full information, modifying  //
// can be done to fix information thats wrong or missing.    //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using RimeLib.Ant.EA.Attributes;
using RimeLib.Ant.EA.Types;

namespace ant
{

	[AntBinding(0xb5a06c02)]
	public class DctAnimationAsset
		: AnimationAsset
	{
		[AntField(0)]
		public ushort NumKeys { get; set; }

		[AntField(1)]
		public ushort NumQuats { get; set; }

		[AntField(2)]
		public ushort NumVec3 { get; set; }

		[AntField(3)]
		public ushort NumFloat { get; set; }

		[AntField(4)]
		public ushort NumFloatVec { get; set; }

		[AntField(5)]
		public bool Cycle { get; set; }

		[AntField(6)]
		public ushort QuantizeMultBlock { get; set; }

		[AntField(7)]
		public List<ushort> KeyTimes { get; set; } = new();

		[AntField(8)]
		public byte QuantizeMultSubblock { get; set; }

		[AntField(9)]
		public byte CatchAllBitCount { get; set; }

		[AntField(10)]
		public List<byte> DofTableDescBytes { get; set; } = new();

		[AntField(11)]
		public List<short> DeltaBaseX { get; set; } = new();

		[AntField(12)]
		public List<short> DeltaBaseY { get; set; } = new();

		[AntField(13)]
		public List<short> DeltaBaseZ { get; set; } = new();

		[AntField(14)]
		public List<short> DeltaBaseW { get; set; } = new();

		[AntField(15)]
		public List<ushort> BitsPerSubblock { get; set; } = new();

		[AntField(16)]
		public uint DataSize { get; set; }

		[AntField(17)]
		public List<byte> Data { get; set; } = new();

	}
}
