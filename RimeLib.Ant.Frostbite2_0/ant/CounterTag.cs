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

	[AntBinding(0xd9c31ec3)]
	public class CounterTag
		: AntObject
	{
		[AntField(0)]
		public IdRef<FloatAsset> ValueAsset { get; set; } = new();

		[AntField(1)]
		public float Time { get; set; }

		[AntField(2)]
		public float Duration { get; set; }

		[AntField(3)]
		public bool ResetOnLeave { get; set; }

	}
}
