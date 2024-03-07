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

	[AntBinding(0x4e6aff0b)]
	public class SpeedCurveAsset
		: AntObject
	{
		[AntField(0)]
		public int NumControlPoints { get; set; }

		[AntField(1)]
		public List<AntVector4> XData { get; set; } = new();

		[AntField(2)]
		public List<AntVector4> YData { get; set; } = new();

	}
}
