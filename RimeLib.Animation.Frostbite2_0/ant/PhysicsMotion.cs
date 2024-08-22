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

	[AntBinding(0x58c63b94)]
	public class PhysicsMotion
		: AntObject
	{
		[AntField(0)]
		public IdRef<FloatAsset> SIGAimLeftRight { get; set; } = new();

		[AntField(1)]
		public IdRef<ExpressionFloatAsset> SIGAccelerationAngle { get; set; } = new();

		[AntField(2)]
		public IdRef<ExpressionFloatAsset> SIGAccelerationMagnitude { get; set; } = new();

		[AntField(3)]
		public IdRef<BoolAsset> SIGIsCrouching { get; set; } = new();

		[AntField(4)]
		public IdRef<BoolAsset> SIGIsSprinting { get; set; } = new();

		[AntField(5)]
		public IdRef<BoolAsset> SIGIsProne { get; set; } = new();

		[AntField(6)]
		public IdRef<BoolAsset> SIGIsZooming { get; set; } = new();

		[AntField(7)]
		public IdRef<BoolAsset> SIGJump { get; set; } = new();

		[AntField(8)]
		public IdRef<BoolAsset> SIGForceSetTrajectory { get; set; } = new();

		[AntField(9)]
		public IdRef<BoolAsset> SIGVaultHigh { get; set; } = new();

		[AntField(10)]
		public IdRef<BoolAsset> SIGVaultUpHigh { get; set; } = new();

		[AntField(11)]
		public IdRef<BoolAsset> SIGVaultLow { get; set; } = new();

		[AntField(12)]
		public IdRef<FloatAsset> SIGVaultPositionX { get; set; } = new();

		[AntField(13)]
		public IdRef<FloatAsset> SIGVaultPositionZ { get; set; } = new();

		[AntField(14)]
		public IdRef<FloatAsset> SIGPreVaultPositionY { get; set; } = new();

		[AntField(15)]
		public IdRef<BoolAsset> SIGVaultCancel { get; set; } = new();

		[AntField(16)]
		public IdRef<FloatAsset> SIGOutFacingAngle { get; set; } = new();

		[AntField(17)]
		public IdRef<FloatAsset> SIGOutRelativeFacingAngle { get; set; } = new();

		[AntField(18)]
		public IdRef<FloatAsset> SIGOutLeanFactor { get; set; } = new();

		[AntField(19)]
		public IdRef<FloatAsset> SIGOutMovementAngle { get; set; } = new();

		[AntField(20)]
		public IdRef<FloatAsset> SIGOutRelativeMovementAngle { get; set; } = new();

		[AntField(21)]
		public IdRef<BoolAsset> SIGOutIsMovingForward { get; set; } = new();

		[AntField(22)]
		public IdRef<BoolAsset> SIGOutIsMovingBackwards { get; set; } = new();

		[AntField(23)]
		public IdRef<FloatAsset> SIGOutMovementSpeed { get; set; } = new();

		[AntField(24)]
		public IdRef<FloatAsset> SIGOutAccelerationAngle { get; set; } = new();

		[AntField(25)]
		public IdRef<FloatAsset> SIGOutAccelerationMagnitude { get; set; } = new();

		[AntField(26)]
		public IdRef<AntObject> SIGOutPhysicsSpeed { get; set; } = new();

		[AntField(27)]
		public IdRef<AntObject> SIGOutVelocityRightLeft { get; set; } = new();

		[AntField(28)]
		public IdRef<AntObject> SIGOutVelocityFwdBwd { get; set; } = new();

		[AntField(29)]
		public IdRef<BoolAsset> SIGOutIsInAir { get; set; } = new();

		[AntField(30)]
		public IdRef<BoolAsset> SIGOutIsCrouching { get; set; } = new();

		[AntField(31)]
		public IdRef<BoolAsset> SIGOutIsProne { get; set; } = new();

		[AntField(32)]
		public IdRef<BoolAsset> SIGDisableForceSetYPosition { get; set; } = new();

		[AntField(33)]
		public IdRef<BoolAsset> SIGEnableAnimationControlled { get; set; } = new();

		[AntField(34)]
		public IdRef<BoolAsset> SIGOutVaultHigh { get; set; } = new();

		[AntField(35)]
		public IdRef<BoolAsset> SIGOutVaultUpHigh { get; set; } = new();

		[AntField(36)]
		public IdRef<BoolAsset> SIGOutVaultLow { get; set; } = new();

		[AntField(37)]
		public IdRef<Vector3Asset> SIGOutRigPosition { get; set; } = new();

		[AntField(38)]
		public IdRef<Vector3Asset> SIGOutPositionBlend { get; set; } = new();

		[AntField(39)]
		public float OutputMovementAngleOffset { get; set; }

		[AntField(40)]
		public float AngularVelocityFactor { get; set; }

		[AntField(41)]
		public float SprintMultiplier { get; set; }

		[AntField(42)]
		public float SprintGain { get; set; }

		[AntField(43)]
		public float ZoomMultiplier { get; set; }

		[AntField(44)]
		public float JumpHeight { get; set; }

		[AntField(45)]
		public float JumpSprintMultiplier { get; set; }

		[AntField(46)]
		public float FreeFallVelocity { get; set; }

		[AntField(47)]
		public float JumpPenaltyFactor { get; set; }

		[AntField(48)]
		public float JumpPenaltyTime { get; set; }

		[AntField(49)]
		public float StandVelocity { get; set; }

		[AntField(50)]
		public float StandAccelerationGain { get; set; }

		[AntField(51)]
		public float StandDecelerationGain { get; set; }

		[AntField(52)]
		public float StandForwardConstant { get; set; }

		[AntField(53)]
		public float StandNonForwardConstant { get; set; }

		[AntField(54)]
		public float StandTransitionTime { get; set; }

		[AntField(55)]
		public float CrouchVelocity { get; set; }

		[AntField(56)]
		public float CrouchAccelerationGain { get; set; }

		[AntField(57)]
		public float CrouchDecelerationGain { get; set; }

		[AntField(58)]
		public float CrouchForwardConstant { get; set; }

		[AntField(59)]
		public float CrouchNonForwardConstant { get; set; }

		[AntField(60)]
		public float CrouchTransitionTime { get; set; }

		[AntField(61)]
		public float ProneVelocity { get; set; }

		[AntField(62)]
		public float ProneAccelerationGain { get; set; }

		[AntField(63)]
		public float ProneDecelerationGain { get; set; }

		[AntField(64)]
		public float ProneForwardConstant { get; set; }

		[AntField(65)]
		public float ProneNonForwardConstant { get; set; }

		[AntField(66)]
		public float ProneTransitionTime { get; set; }

		[AntField(67)]
		public List<float> LeanBezierPoints { get; set; } = new();

	}
}
