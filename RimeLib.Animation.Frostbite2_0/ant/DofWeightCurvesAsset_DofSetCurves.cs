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

	[AntBinding(0x79aeddca)]
	public class DofWeightCurvesAsset_DofSetCurves
		: AntObject
	{
		[AntField(0)]
		public bool ForEachDof { get; set; }

		[AntField(1)]
		public List<byte> CurveBytes { get; set; } = new();

		[AntField(2)]
		public List<byte> InheritedMaskBytes { get; set; } = new();

	}
}
