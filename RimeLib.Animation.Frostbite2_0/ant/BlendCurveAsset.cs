///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// As type schemas dont contain full information, modifying  //
// can be done to fix information thats wrong or missing.    //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using RimeLib.Animation.EA.Attributes;
using RimeLib.Animation.EA.Types;

namespace ant
{

	[AntBinding(0xa2b9f679)]
	public class BlendCurveAsset
		: IBlendAsset
	{
		[AntField(0)]
		public int CurveType { get; set; }

		[AntField(1)]
		public bool ShouldSyncPhase { get; set; }

	}
}
