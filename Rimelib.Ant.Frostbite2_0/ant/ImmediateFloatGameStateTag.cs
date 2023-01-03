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

	[AntBinding(0x195453f7)]
	public class ImmediateFloatGameStateTag
		: AntObject
	{
		[AntField(0)]
		public IdRef<FloatAsset> ValueAsset { get; set; } = new();

		[AntField(1)]
		public float Time { get; set; }

		[AntField(2)]
		public float Duration { get; set; }

		[AntField(3)]
		public bool AlwaysActive { get; set; }

		[AntField(4)]
		public float Value { get; set; }

	}
}
