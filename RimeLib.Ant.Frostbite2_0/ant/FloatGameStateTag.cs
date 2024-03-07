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

	[AntBinding(0xa05d12f5)]
	public class FloatGameStateTag
		: GameStateTagAsset
	{
		[AntField(0)]
		public float Value { get; set; }

		[AntField(1)]
		public byte Mode { get; set; }

		[AntField(2)]
		public List<float> Spline { get; set; } = new();

		[AntField(3)]
		public List<byte> SplineRaw { get; set; } = new();

		[AntField(4)]
		public byte SplineStorageFlags { get; set; }

	}
}
