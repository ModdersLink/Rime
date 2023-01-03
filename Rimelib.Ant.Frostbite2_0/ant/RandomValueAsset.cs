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

	[AntBinding(0x1e9350ac)]
	public class RandomValueAsset
		: AntObject
	{
		[AntField(0)]
		public uint Seed { get; set; }

		[AntField(1)]
		public float Min { get; set; }

		[AntField(2)]
		public float Max { get; set; }

	}
}
