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

	[AntBinding(0x85e14b0c)]
	public class FpsFootPlantPreHIk_RightFoot
		: AntObject
	{
		[AntField(0)]
		public float FootHeightTolerance { get; set; }

		[AntField(1)]
		public float ToeHeightTolerance { get; set; }

		[AntField(2)]
		public float SpeedTolerance { get; set; }

		[AntField(3)]
		public float FootHeight { get; set; }

		[AntField(4)]
		public float ToeHeight { get; set; }

		[AntField(5)]
		public float HeightClamprate { get; set; }

		[AntField(6)]
		public float MaxLegStretch { get; set; }

		[AntField(7)]
		public float MaxCorrection { get; set; }

		[AntField(8)]
		public uint MagicCircle { get; set; }

		[AntField(9)]
		public float EffectorPull { get; set; }

	}
}
