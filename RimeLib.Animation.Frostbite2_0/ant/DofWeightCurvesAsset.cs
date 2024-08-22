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

	[AntBinding(0xf497587d)]
	public class DofWeightCurvesAsset
		: AntObject
	{
		[AntField(0)]
		public IdRef<LayoutHierarchyAsset> DofSetList { get; set; } = new();

		[AntField(1)]
		public List<DofWeightCurvesAsset_DofSetCurves> DofSetCurves { get; set; } = new();

		[AntField(2)]
		public List<byte> DefaultCurveBytes { get; set; } = new();

		[AntField(3)]
		public List<byte> DefaultInheritedMaskBytes { get; set; } = new();

	}
}
