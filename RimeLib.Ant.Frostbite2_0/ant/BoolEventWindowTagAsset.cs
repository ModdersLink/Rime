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

	[AntBinding(0xe6b45f51)]
	public class BoolEventWindowTagAsset
		: AntObject
	{
		[AntField(0)]
		public IdRef<BoolAsset> ConditionAsset { get; set; } = new();

		[AntField(1)]
		public float Time { get; set; }

		[AntField(2)]
		public float Duration { get; set; }

		[AntField(3)]
		public bool ResetOnLeave { get; set; }

		[AntField(4)]
		public bool ResetOnEnter { get; set; }

		[AntField(7)]
		public IdRef<BoolAsset> BoolAsset { get; set; } = new();

		[AntField(8)]
		public bool BoolValue { get; set; }

	}
}
