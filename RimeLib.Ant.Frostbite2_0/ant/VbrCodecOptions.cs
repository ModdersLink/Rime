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

	[AntBinding(0xa8826b5)]
	public class VbrCodecOptions
		: AntObject
	{
		[AntField(0)]
		public float MaxRotationErrorPercentage { get; set; }

		[AntField(1)]
		public float MaxTranslationErrorPercentage { get; set; }

		[AntField(2)]
		public float MaxTrajectoryErrorPercentage { get; set; }

		[AntField(3)]
		public int CurveFitTranslations { get; set; }

		[AntField(4)]
		public bool LinearSearchQuantizationTables { get; set; }

	}
}
