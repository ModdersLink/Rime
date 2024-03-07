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

	[AntBinding(0xfc2f7fc5)]
	public class FbLocoUpdateSceneOp
		: AntObject
	{
		[AntField(0)]
		public IdRef<FloatAsset> DeltaTicks { get; set; } = new();

		[AntField(1)]
		public IdRef<FloatAsset> LeftStickDirection { get; set; } = new();

		[AntField(2)]
		public IdRef<FloatAsset> LeftStickMagnitude { get; set; } = new();

		[AntField(3)]
		public IdRef<FloatAsset> RightStickDirection { get; set; } = new();

		[AntField(4)]
		public IdRef<FloatAsset> RightStickMagnitude { get; set; } = new();

		[AntField(5)]
		public IdRef<BoolAsset> AllowStrafing { get; set; } = new();

		[AntField(6)]
		public IdRef<FbLocoTargetGSAsset> FbLocoTarget { get; set; } = new();

		[AntField(7)]
		public IdRef<AntObject> CadenceOverride { get; set; } = new();

		[AntField(8)]
		public IdRef<FloatAsset> GroundAngle { get; set; } = new();

		[AntField(9)]
		public List<float> SpeedVsAngleBezier { get; set; } = new();

		[AntField(10)]
		public IdRef<Vector3Asset> EntitySpaceTrans { get; set; } = new();

		[AntField(11)]
		public IdRef<QuaternionAsset> EntitySpaceRot { get; set; } = new();

		[AntField(12)]
		public List<AntVector4> CurveData { get; set; } = new();

		[AntField(13)]
		public List<short> Lengths { get; set; } = new();

		[AntField(14)]
		public List<short> XOffsets { get; set; } = new();

		[AntField(15)]
		public List<short> YOffsets { get; set; } = new();

		[AntField(16)]
		public IdRef<GameStateEnumerationAsset> EndPose { get; set; } = new();

		[AntField(17)]
		public IdRef<GameStateEnumerationAsset> CurrentPose { get; set; } = new();

		[AntField(18)]
		public IdRef<FloatAsset> CurrentSpeed { get; set; } = new();

		[AntField(19)]
		public IdRef<FloatAsset> CurrentSpace { get; set; } = new();

		[AntField(20)]
		public IdRef<Vector3Asset> CurrentMoveDir { get; set; } = new();

		[AntField(21)]
		public IdRef<FloatAsset> CurrentRelativeMoveDir { get; set; } = new();

		[AntField(22)]
		public IdRef<GameStateEnumerationAsset> Attention { get; set; } = new();

		[AntField(23)]
		public IdRef<GameStateEnumerationAsset> CruiseSpeedLevel { get; set; } = new();

		[AntField(24)]
		public IdRef<BoolAsset> StandingStillSignal { get; set; } = new();

		[AntField(25)]
		public IdRef<FloatAsset> RelativeAimSignal { get; set; } = new();

		[AntField(26)]
		public IdRef<FbLocoUpdateDataAsset> LocoUpdateData { get; set; } = new();

		[AntField(27)]
		public List<float> AttribFloatConstants { get; set; } = new();

		[AntField(28)]
		public int TopJointIndex { get; set; }

		[AntField(29)]
		public int BottomJointIndex { get; set; }

		[AntField(30)]
		public float CrouchHeightDelimiter { get; set; }

		[AntField(31)]
		public IdRef<ContextDatabaseAsset> SpeedCurveDb { get; set; } = new();

	}
}
