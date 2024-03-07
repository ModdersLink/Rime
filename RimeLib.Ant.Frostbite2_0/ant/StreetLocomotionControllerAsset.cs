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

	[AntBinding(0x70ec8d4c)]
	public class StreetLocomotionControllerAsset
		: ControllerAsset
	{
		[AntField(0)]
		public IdRef<StreetMoveGroupControllerAsset> MoveGroupControllerAsset { get; set; } = new();

		[AntField(1)]
		public IdRef<FloatAsset> SpeedSignalAsset { get; set; } = new();

		[AntField(2)]
		public IdRef<FloatAsset> MoveAngleSignalAsset { get; set; } = new();

		[AntField(3)]
		public IdRef<FloatAsset> FaceAngleSignalAsset { get; set; } = new();

		[AntField(4)]
		public IdRef<FloatAsset> PhaseSignalAsset { get; set; } = new();

		[AntField(5)]
		public IdRef<AntObject> SkillSignalAsset { get; set; } = new();

		[AntField(6)]
		public bool Mirrored { get; set; }

		[AntField(7)]
		public bool LeanEnabled { get; set; }

		[AntField(8)]
		public float InitMaxSpeedRatio { get; set; }

		[AntField(9)]
		public float InitMaxAccelRatio { get; set; }

		[AntField(10)]
		public float InitMaxDecelRatio { get; set; }

		[AntField(11)]
		public float InitMaxTurn { get; set; }

		[AntField(12)]
		public bool ShouldInitSpeedFromGS { get; set; }

		[AntField(13)]
		public bool SpeedSignalNormalized { get; set; }

		[AntField(14)]
		public IdRef<AntObject> MaxTurnGamestateOverride { get; set; } = new();

		[AntField(15)]
		public float InitMaxMoveAngleChange { get; set; }

	}
}
