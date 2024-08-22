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

	[AntBinding(0xb53f0f33)]
	public class TimeScaleBlendAsset
		: IBlendAsset
	{
		[AntField(1)]
		public IdRef<DofWeightCurvesAsset> WeightCurves { get; set; } = new();

		[AntField(2)]
		public IdRef<AntObject> WeightCurvesOut { get; set; } = new();

		[AntField(3)]
		public IdRef<AntObject> BlendWeight { get; set; } = new();

	}
}
