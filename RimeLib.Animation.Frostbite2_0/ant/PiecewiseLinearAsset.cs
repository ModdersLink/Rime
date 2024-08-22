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

	[AntBinding(0xb83e2f50)]
	public class PiecewiseLinearAsset
		: AntObject
	{
		[AntField(0)]
		public List<AntVector2> PointValues { get; set; } = new();

		[AntField(1)]
		public string GraphTitle { get; set; } = string.Empty;

		[AntField(2)]
		public string XTitle { get; set; } = string.Empty;

		[AntField(3)]
		public string YTitle { get; set; } = string.Empty;

		[AntField(4)]
		public float XMin { get; set; }

		[AntField(5)]
		public float YMin { get; set; }

		[AntField(6)]
		public float XMax { get; set; }

		[AntField(7)]
		public float YMax { get; set; }

		[AntField(8)]
		public int Slope { get; set; }

	}
}
