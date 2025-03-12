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

	[AntBinding(0xbd96c8d5)]
	public class PIDData
		: AntObject
	{
		[AntField(0)]
		public float ProportionalModifier { get; set; }

		[AntField(1)]
		public float IntegralModifier { get; set; }

		[AntField(2)]
		public float DifferentialModifier { get; set; }

		[AntField(3)]
		public float ErrorModifier { get; set; }

		[AntField(4)]
		public float InputModifier { get; set; }

		[AntField(5)]
		public float MaxAngle { get; set; }

	}
}
