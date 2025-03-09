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

	[AntBinding(0xdda399dc)]
	public class SteeringControllerAsset
		: ControllerAsset
	{
		[AntField(0)]
		public IdRef<IndexChooserControllerAsset> SubjectControllerAsset { get; set; } = new();

		[AntField(1)]
		public IdRef<NullTag> SubjectControllerInit { get; set; } = new();

		[AntField(2)]
		public IdRef<FloatAsset> DesiredDirectionSignal { get; set; } = new();

		[AntField(3)]
		public IdRef<FloatAsset> StickMagnitudeSignal { get; set; } = new();

		[AntField(4)]
		public int SteeringType { get; set; }

		[AntField(5)]
		public float SteeringMaxRate { get; set; }

		[AntField(6)]
		public float SteeringMaxDeviation { get; set; }

		[AntField(7)]
		public float SteeringAlignOffset { get; set; }

		[AntField(8)]
		public float SteeringDeadZone { get; set; }

		[AntField(9)]
		public int SteeringAngleQuantizer { get; set; }

		[AntField(10)]
		public int SteeringFaceMode { get; set; }

		[AntField(11)]
		public float SteeringAngleTolerance { get; set; }

		[AntField(12)]
		public IdRef<AntObject> EnabledGameState { get; set; } = new();

	}
}
