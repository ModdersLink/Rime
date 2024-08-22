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

	[AntBinding(0x3e354cda)]
	public class AnalogStickData
		: AntObject
	{
		[AntField(0)]
		public AntVector2 XY { get; set; } = new();

		[AntField(1)]
		public float Angle { get; set; }

		[AntField(2)]
		public float Magnitude { get; set; }

	}
}
