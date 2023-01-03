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

	[AntBinding(0xc675a586)]
	public class BranchInWindowTag
		: AntObject
	{
		[AntField(0)]
		public float Time { get; set; }

		[AntField(1)]
		public float TuningOffset { get; set; }

		[AntField(2)]
		public IdRef<BranchTypeAsset> BranchType { get; set; } = new();

	}
}
