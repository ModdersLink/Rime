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

	[AntBinding(0x5497013c)]
	public class RawAnimationAsset
		: AnimationAsset
	{
		[AntField(0)]
		public List<short> KeyTimes { get; set; } = new();

		[AntField(1)]
		public List<float> Data { get; set; } = new();

		[AntField(2)]
		public uint FloatCount { get; set; }

		[AntField(3)]
		public uint Vec3Count { get; set; }

		[AntField(4)]
		public uint QuatCount { get; set; }

		[AntField(5)]
		public uint NumKeys { get; set; }

		[AntField(6)]
		public bool Cycle { get; set; }

	}
}
