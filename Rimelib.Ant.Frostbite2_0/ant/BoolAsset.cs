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

	[AntBinding(0xf6b24373)]
	public class BoolAsset
		: AntObject
	{
		[AntField(0)]
		public bool Default { get; set; }

		[AntField(1)]
		public bool DeactivateAfterUpdate { get; set; }

		[AntField(2)]
		public bool DeactivateAfterTransition { get; set; }

		[AntField(3)]
		public bool DeactivateAfterUpdateValue { get; set; }

	}
}
