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

	[AntBinding(0x1d6c4f71)]
	public class FrameAnimationAsset
		: AnimationAsset
	{
		[AntField(0)]
		public List<float> Data { get; set; } = new();

		[AntField(1)]
		public uint FloatCount { get; set; }

		[AntField(2)]
		public uint Vec3Count { get; set; }

		[AntField(3)]
		public uint QuatCount { get; set; }

	}
}
