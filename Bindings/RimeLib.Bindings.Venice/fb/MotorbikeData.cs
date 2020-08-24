///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(16), MemberInfoFlag(53), ContainerClass]
	public class MotorbikeData : 
		DataContainer
	{
		protected Vec3 m_WheelieForceBodyOffset = new Vec3();
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(4050311162)]
		public Vec3 WheelieForceBodyOffset { get { return m_WheelieForceBodyOffset; } set { if (OnPropertyChanging("MotorbikeData." + nameof(WheelieForceBodyOffset), this, m_WheelieForceBodyOffset, value)) m_WheelieForceBodyOffset = value; } } // 0x10 (16)
		
		protected Vec3 m_WheelieForce = new Vec3();
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(1325583079)]
		public Vec3 WheelieForce { get { return m_WheelieForce; } set { if (OnPropertyChanging("MotorbikeData." + nameof(WheelieForce), this, m_WheelieForce, value)) m_WheelieForce = value; } } // 0x20 (32)
		
		protected Vec3 m_DampBigJumpImpactCounterForce = new Vec3();
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(425540600)]
		public Vec3 DampBigJumpImpactCounterForce { get { return m_DampBigJumpImpactCounterForce; } set { if (OnPropertyChanging("MotorbikeData." + nameof(DampBigJumpImpactCounterForce), this, m_DampBigJumpImpactCounterForce, value)) m_DampBigJumpImpactCounterForce = value; } } // 0x30 (48)
		
		protected Vec3 m_ProximityExtScale = new Vec3();
		[ContainerField(64), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(3588712321)]
		public Vec3 ProximityExtScale { get { return m_ProximityExtScale; } set { if (OnPropertyChanging("MotorbikeData." + nameof(ProximityExtScale), this, m_ProximityExtScale, value)) m_ProximityExtScale = value; } } // 0x40 (64)
		
		protected float m_JumpForwardLeanMinAngle = new float();
		[ContainerField(80), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(401127825)]
		public float JumpForwardLeanMinAngle { get { return m_JumpForwardLeanMinAngle; } set { if (OnPropertyChanging("MotorbikeData." + nameof(JumpForwardLeanMinAngle), this, m_JumpForwardLeanMinAngle, value)) m_JumpForwardLeanMinAngle = value; } } // 0x50 (80)
		
		protected float m_JumpForwardLeanMomentum = new float();
		[ContainerField(84), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2197270066)]
		public float JumpForwardLeanMomentum { get { return m_JumpForwardLeanMomentum; } set { if (OnPropertyChanging("MotorbikeData." + nameof(JumpForwardLeanMomentum), this, m_JumpForwardLeanMomentum, value)) m_JumpForwardLeanMomentum = value; } } // 0x54 (84)
		
		protected float m_KickstandRoll = new float();
		[ContainerField(88), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(743919134)]
		public float KickstandRoll { get { return m_KickstandRoll; } set { if (OnPropertyChanging("MotorbikeData." + nameof(KickstandRoll), this, m_KickstandRoll, value)) m_KickstandRoll = value; } } // 0x58 (88)
		
		protected float m_KickstandLinearDamping = new float();
		[ContainerField(92), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(184258502)]
		public float KickstandLinearDamping { get { return m_KickstandLinearDamping; } set { if (OnPropertyChanging("MotorbikeData." + nameof(KickstandLinearDamping), this, m_KickstandLinearDamping, value)) m_KickstandLinearDamping = value; } } // 0x5C (92)
		
		protected float m_LeanForceMaxVel = new float();
		[ContainerField(96), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(90919029)]
		public float LeanForceMaxVel { get { return m_LeanForceMaxVel; } set { if (OnPropertyChanging("MotorbikeData." + nameof(LeanForceMaxVel), this, m_LeanForceMaxVel, value)) m_LeanForceMaxVel = value; } } // 0x60 (96)
		
		protected float m_CounterLeanForce = new float();
		[ContainerField(100), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2727731914)]
		public float CounterLeanForce { get { return m_CounterLeanForce; } set { if (OnPropertyChanging("MotorbikeData." + nameof(CounterLeanForce), this, m_CounterLeanForce, value)) m_CounterLeanForce = value; } } // 0x64 (100)
		
		protected float m_StandStillRoll = new float();
		[ContainerField(104), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(877604538)]
		public float StandStillRoll { get { return m_StandStillRoll; } set { if (OnPropertyChanging("MotorbikeData." + nameof(StandStillRoll), this, m_StandStillRoll, value)) m_StandStillRoll = value; } } // 0x68 (104)
		
		protected float m_DampBigJumpImpactVelocity = new float();
		[ContainerField(108), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(441919910)]
		public float DampBigJumpImpactVelocity { get { return m_DampBigJumpImpactVelocity; } set { if (OnPropertyChanging("MotorbikeData." + nameof(DampBigJumpImpactVelocity), this, m_DampBigJumpImpactVelocity, value)) m_DampBigJumpImpactVelocity = value; } } // 0x6C (108)
		
		protected float m_YawBrakeDampingLerpStartScale = new float();
		[ContainerField(112), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(4278552638)]
		public float YawBrakeDampingLerpStartScale { get { return m_YawBrakeDampingLerpStartScale; } set { if (OnPropertyChanging("MotorbikeData." + nameof(YawBrakeDampingLerpStartScale), this, m_YawBrakeDampingLerpStartScale, value)) m_YawBrakeDampingLerpStartScale = value; } } // 0x70 (112)
		
		protected float m_YawBrakeDampingLerpEndScale = new float();
		[ContainerField(116), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3443030225)]
		public float YawBrakeDampingLerpEndScale { get { return m_YawBrakeDampingLerpEndScale; } set { if (OnPropertyChanging("MotorbikeData." + nameof(YawBrakeDampingLerpEndScale), this, m_YawBrakeDampingLerpEndScale, value)) m_YawBrakeDampingLerpEndScale = value; } } // 0x74 (116)
		
		protected float m_StoppieActivationVelocity = new float();
		[ContainerField(120), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2464692130)]
		public float StoppieActivationVelocity { get { return m_StoppieActivationVelocity; } set { if (OnPropertyChanging("MotorbikeData." + nameof(StoppieActivationVelocity), this, m_StoppieActivationVelocity, value)) m_StoppieActivationVelocity = value; } } // 0x78 (120)
		
		protected float m_StoppieStartVelocity = new float();
		[ContainerField(124), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3715175158)]
		public float StoppieStartVelocity { get { return m_StoppieStartVelocity; } set { if (OnPropertyChanging("MotorbikeData." + nameof(StoppieStartVelocity), this, m_StoppieStartVelocity, value)) m_StoppieStartVelocity = value; } } // 0x7C (124)
		
		protected float m_LeanForce = new float();
		[ContainerField(128), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3891742718)]
		public float LeanForce { get { return m_LeanForce; } set { if (OnPropertyChanging("MotorbikeData." + nameof(LeanForce), this, m_LeanForce, value)) m_LeanForce = value; } } // 0x80 (128)
		
		protected float m_StoppieMomentum = new float();
		[ContainerField(132), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2105377289)]
		public float StoppieMomentum { get { return m_StoppieMomentum; } set { if (OnPropertyChanging("MotorbikeData." + nameof(StoppieMomentum), this, m_StoppieMomentum, value)) m_StoppieMomentum = value; } } // 0x84 (132)
		
		protected float m_ShortOffgroundGravityMultiplier = new float();
		[ContainerField(136), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2398478128)]
		public float ShortOffgroundGravityMultiplier { get { return m_ShortOffgroundGravityMultiplier; } set { if (OnPropertyChanging("MotorbikeData." + nameof(ShortOffgroundGravityMultiplier), this, m_ShortOffgroundGravityMultiplier, value)) m_ShortOffgroundGravityMultiplier = value; } } // 0x88 (136)
		
		protected float m_MaxLeaningRoll = new float();
		[ContainerField(140), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2063770090)]
		public float MaxLeaningRoll { get { return m_MaxLeaningRoll; } set { if (OnPropertyChanging("MotorbikeData." + nameof(MaxLeaningRoll), this, m_MaxLeaningRoll, value)) m_MaxLeaningRoll = value; } } // 0x8C (140)
		
		protected float m_StoppieStopVelocity = new float();
		[ContainerField(144), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3176785966)]
		public float StoppieStopVelocity { get { return m_StoppieStopVelocity; } set { if (OnPropertyChanging("MotorbikeData." + nameof(StoppieStopVelocity), this, m_StoppieStopVelocity, value)) m_StoppieStopVelocity = value; } } // 0x90 (144)
		
		protected float m_ProximityHeightTranslation = new float();
		[ContainerField(148), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2388981380)]
		public float ProximityHeightTranslation { get { return m_ProximityHeightTranslation; } set { if (OnPropertyChanging("MotorbikeData." + nameof(ProximityHeightTranslation), this, m_ProximityHeightTranslation, value)) m_ProximityHeightTranslation = value; } } // 0x94 (148)
		
		protected float m_WheelieMaxNoDownForceContactTime = new float();
		[ContainerField(152), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3008032341)]
		public float WheelieMaxNoDownForceContactTime { get { return m_WheelieMaxNoDownForceContactTime; } set { if (OnPropertyChanging("MotorbikeData." + nameof(WheelieMaxNoDownForceContactTime), this, m_WheelieMaxNoDownForceContactTime, value)) m_WheelieMaxNoDownForceContactTime = value; } } // 0x98 (152)
		
		protected float m_WheelieMaxNoContactTime = new float();
		[ContainerField(156), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3277378970)]
		public float WheelieMaxNoContactTime { get { return m_WheelieMaxNoContactTime; } set { if (OnPropertyChanging("MotorbikeData." + nameof(WheelieMaxNoContactTime), this, m_WheelieMaxNoContactTime, value)) m_WheelieMaxNoContactTime = value; } } // 0x9C (156)
		
		protected float m_WheelieSteeringFactor = new float();
		[ContainerField(160), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(922430370)]
		public float WheelieSteeringFactor { get { return m_WheelieSteeringFactor; } set { if (OnPropertyChanging("MotorbikeData." + nameof(WheelieSteeringFactor), this, m_WheelieSteeringFactor, value)) m_WheelieSteeringFactor = value; } } // 0xA0 (160)
		
		protected float m_WheelieInertia = new float();
		[ContainerField(164), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(756716118)]
		public float WheelieInertia { get { return m_WheelieInertia; } set { if (OnPropertyChanging("MotorbikeData." + nameof(WheelieInertia), this, m_WheelieInertia, value)) m_WheelieInertia = value; } } // 0xA4 (164)
		
		protected float m_WheelieStartVelocity = new float();
		[ContainerField(168), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1112627949)]
		public float WheelieStartVelocity { get { return m_WheelieStartVelocity; } set { if (OnPropertyChanging("MotorbikeData." + nameof(WheelieStartVelocity), this, m_WheelieStartVelocity, value)) m_WheelieStartVelocity = value; } } // 0xA8 (168)
		
		protected float m_WheelieMaxVelocityUndamped = new float();
		[ContainerField(172), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2044326939)]
		public float WheelieMaxVelocityUndamped { get { return m_WheelieMaxVelocityUndamped; } set { if (OnPropertyChanging("MotorbikeData." + nameof(WheelieMaxVelocityUndamped), this, m_WheelieMaxVelocityUndamped, value)) m_WheelieMaxVelocityUndamped = value; } } // 0xAC (172)
		
		protected float m_WheelieMaxVelocityDampRange = new float();
		[ContainerField(176), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(911316990)]
		public float WheelieMaxVelocityDampRange { get { return m_WheelieMaxVelocityDampRange; } set { if (OnPropertyChanging("MotorbikeData." + nameof(WheelieMaxVelocityDampRange), this, m_WheelieMaxVelocityDampRange, value)) m_WheelieMaxVelocityDampRange = value; } } // 0xB0 (176)
		
		protected float m_WheelieOutAngularMomentum = new float();
		[ContainerField(180), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3287389598)]
		public float WheelieOutAngularMomentum { get { return m_WheelieOutAngularMomentum; } set { if (OnPropertyChanging("MotorbikeData." + nameof(WheelieOutAngularMomentum), this, m_WheelieOutAngularMomentum, value)) m_WheelieOutAngularMomentum = value; } } // 0xB4 (180)
		
		protected float m_WheelieSpringDamping = new float();
		[ContainerField(184), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2926554611)]
		public float WheelieSpringDamping { get { return m_WheelieSpringDamping; } set { if (OnPropertyChanging("MotorbikeData." + nameof(WheelieSpringDamping), this, m_WheelieSpringDamping, value)) m_WheelieSpringDamping = value; } } // 0xB8 (184)
		
		protected float m_WheelieAngularDamping = new float();
		[ContainerField(188), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3467767936)]
		public float WheelieAngularDamping { get { return m_WheelieAngularDamping; } set { if (OnPropertyChanging("MotorbikeData." + nameof(WheelieAngularDamping), this, m_WheelieAngularDamping, value)) m_WheelieAngularDamping = value; } } // 0xBC (188)
		
		protected float m_WheelieAngularDampingSpeed = new float();
		[ContainerField(192), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2883819815)]
		public float WheelieAngularDampingSpeed { get { return m_WheelieAngularDampingSpeed; } set { if (OnPropertyChanging("MotorbikeData." + nameof(WheelieAngularDampingSpeed), this, m_WheelieAngularDampingSpeed, value)) m_WheelieAngularDampingSpeed = value; } } // 0xC0 (192)
		
		protected float m_ShortOffgroundPeriod = new float();
		[ContainerField(196), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2265366232)]
		public float ShortOffgroundPeriod { get { return m_ShortOffgroundPeriod; } set { if (OnPropertyChanging("MotorbikeData." + nameof(ShortOffgroundPeriod), this, m_ShortOffgroundPeriod, value)) m_ShortOffgroundPeriod = value; } } // 0xC4 (196)
		
		protected float m_WheelieMaxAngle = new float();
		[ContainerField(200), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2419359695)]
		public float WheelieMaxAngle { get { return m_WheelieMaxAngle; } set { if (OnPropertyChanging("MotorbikeData." + nameof(WheelieMaxAngle), this, m_WheelieMaxAngle, value)) m_WheelieMaxAngle = value; } } // 0xC8 (200)
		
		protected float m_WheelieAngularStartMomentum = new float();
		[ContainerField(204), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(698093808)]
		public float WheelieAngularStartMomentum { get { return m_WheelieAngularStartMomentum; } set { if (OnPropertyChanging("MotorbikeData." + nameof(WheelieAngularStartMomentum), this, m_WheelieAngularStartMomentum, value)) m_WheelieAngularStartMomentum = value; } } // 0xCC (204)
		
		protected float m_WheelieMaxVelocity = new float();
		[ContainerField(208), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2291827481)]
		public float WheelieMaxVelocity { get { return m_WheelieMaxVelocity; } set { if (OnPropertyChanging("MotorbikeData." + nameof(WheelieMaxVelocity), this, m_WheelieMaxVelocity, value)) m_WheelieMaxVelocity = value; } } // 0xD0 (208)
		
		protected float m_WheelieVelocityForceScale = new float();
		[ContainerField(212), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(581384360)]
		public float WheelieVelocityForceScale { get { return m_WheelieVelocityForceScale; } set { if (OnPropertyChanging("MotorbikeData." + nameof(WheelieVelocityForceScale), this, m_WheelieVelocityForceScale, value)) m_WheelieVelocityForceScale = value; } } // 0xD4 (212)
		
		protected bool m_DampBigJumpImpact = new bool();
		[ContainerField(216), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1921216113)]
		public bool DampBigJumpImpact { get { return m_DampBigJumpImpact; } set { if (OnPropertyChanging("MotorbikeData." + nameof(DampBigJumpImpact), this, m_DampBigJumpImpact, value)) m_DampBigJumpImpact = value; } } // 0xD8 (216)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4050311162:
					WheelieForceBodyOffset = (Vec3) p_Value;
					break;

				case 1325583079:
					WheelieForce = (Vec3) p_Value;
					break;

				case 425540600:
					DampBigJumpImpactCounterForce = (Vec3) p_Value;
					break;

				case 3588712321:
					ProximityExtScale = (Vec3) p_Value;
					break;

				case 401127825:
					JumpForwardLeanMinAngle = (float) p_Value;
					break;

				case 2197270066:
					JumpForwardLeanMomentum = (float) p_Value;
					break;

				case 743919134:
					KickstandRoll = (float) p_Value;
					break;

				case 184258502:
					KickstandLinearDamping = (float) p_Value;
					break;

				case 90919029:
					LeanForceMaxVel = (float) p_Value;
					break;

				case 2727731914:
					CounterLeanForce = (float) p_Value;
					break;

				case 877604538:
					StandStillRoll = (float) p_Value;
					break;

				case 441919910:
					DampBigJumpImpactVelocity = (float) p_Value;
					break;

				case 4278552638:
					YawBrakeDampingLerpStartScale = (float) p_Value;
					break;

				case 3443030225:
					YawBrakeDampingLerpEndScale = (float) p_Value;
					break;

				case 2464692130:
					StoppieActivationVelocity = (float) p_Value;
					break;

				case 3715175158:
					StoppieStartVelocity = (float) p_Value;
					break;

				case 3891742718:
					LeanForce = (float) p_Value;
					break;

				case 2105377289:
					StoppieMomentum = (float) p_Value;
					break;

				case 2398478128:
					ShortOffgroundGravityMultiplier = (float) p_Value;
					break;

				case 2063770090:
					MaxLeaningRoll = (float) p_Value;
					break;

				case 3176785966:
					StoppieStopVelocity = (float) p_Value;
					break;

				case 2388981380:
					ProximityHeightTranslation = (float) p_Value;
					break;

				case 3008032341:
					WheelieMaxNoDownForceContactTime = (float) p_Value;
					break;

				case 3277378970:
					WheelieMaxNoContactTime = (float) p_Value;
					break;

				case 922430370:
					WheelieSteeringFactor = (float) p_Value;
					break;

				case 756716118:
					WheelieInertia = (float) p_Value;
					break;

				case 1112627949:
					WheelieStartVelocity = (float) p_Value;
					break;

				case 2044326939:
					WheelieMaxVelocityUndamped = (float) p_Value;
					break;

				case 911316990:
					WheelieMaxVelocityDampRange = (float) p_Value;
					break;

				case 3287389598:
					WheelieOutAngularMomentum = (float) p_Value;
					break;

				case 2926554611:
					WheelieSpringDamping = (float) p_Value;
					break;

				case 3467767936:
					WheelieAngularDamping = (float) p_Value;
					break;

				case 2883819815:
					WheelieAngularDampingSpeed = (float) p_Value;
					break;

				case 2265366232:
					ShortOffgroundPeriod = (float) p_Value;
					break;

				case 2419359695:
					WheelieMaxAngle = (float) p_Value;
					break;

				case 698093808:
					WheelieAngularStartMomentum = (float) p_Value;
					break;

				case 2291827481:
					WheelieMaxVelocity = (float) p_Value;
					break;

				case 581384360:
					WheelieVelocityForceScale = (float) p_Value;
					break;

				case 1921216113:
					DampBigJumpImpact = (bool) p_Value;
					break;

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4050311162:
					return WheelieForceBodyOffset;

				case 1325583079:
					return WheelieForce;

				case 425540600:
					return DampBigJumpImpactCounterForce;

				case 3588712321:
					return ProximityExtScale;

				case 401127825:
					return JumpForwardLeanMinAngle;

				case 2197270066:
					return JumpForwardLeanMomentum;

				case 743919134:
					return KickstandRoll;

				case 184258502:
					return KickstandLinearDamping;

				case 90919029:
					return LeanForceMaxVel;

				case 2727731914:
					return CounterLeanForce;

				case 877604538:
					return StandStillRoll;

				case 441919910:
					return DampBigJumpImpactVelocity;

				case 4278552638:
					return YawBrakeDampingLerpStartScale;

				case 3443030225:
					return YawBrakeDampingLerpEndScale;

				case 2464692130:
					return StoppieActivationVelocity;

				case 3715175158:
					return StoppieStartVelocity;

				case 3891742718:
					return LeanForce;

				case 2105377289:
					return StoppieMomentum;

				case 2398478128:
					return ShortOffgroundGravityMultiplier;

				case 2063770090:
					return MaxLeaningRoll;

				case 3176785966:
					return StoppieStopVelocity;

				case 2388981380:
					return ProximityHeightTranslation;

				case 3008032341:
					return WheelieMaxNoDownForceContactTime;

				case 3277378970:
					return WheelieMaxNoContactTime;

				case 922430370:
					return WheelieSteeringFactor;

				case 756716118:
					return WheelieInertia;

				case 1112627949:
					return WheelieStartVelocity;

				case 2044326939:
					return WheelieMaxVelocityUndamped;

				case 911316990:
					return WheelieMaxVelocityDampRange;

				case 3287389598:
					return WheelieOutAngularMomentum;

				case 2926554611:
					return WheelieSpringDamping;

				case 3467767936:
					return WheelieAngularDamping;

				case 2883819815:
					return WheelieAngularDampingSpeed;

				case 2265366232:
					return ShortOffgroundPeriod;

				case 2419359695:
					return WheelieMaxAngle;

				case 698093808:
					return WheelieAngularStartMomentum;

				case 2291827481:
					return WheelieMaxVelocity;

				case 581384360:
					return WheelieVelocityForceScale;

				case 1921216113:
					return DampBigJumpImpact;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4050311162:
					return typeof(MotorbikeData).GetProperty(nameof(WheelieForceBodyOffset));

				case 1325583079:
					return typeof(MotorbikeData).GetProperty(nameof(WheelieForce));

				case 425540600:
					return typeof(MotorbikeData).GetProperty(nameof(DampBigJumpImpactCounterForce));

				case 3588712321:
					return typeof(MotorbikeData).GetProperty(nameof(ProximityExtScale));

				case 401127825:
					return typeof(MotorbikeData).GetProperty(nameof(JumpForwardLeanMinAngle));

				case 2197270066:
					return typeof(MotorbikeData).GetProperty(nameof(JumpForwardLeanMomentum));

				case 743919134:
					return typeof(MotorbikeData).GetProperty(nameof(KickstandRoll));

				case 184258502:
					return typeof(MotorbikeData).GetProperty(nameof(KickstandLinearDamping));

				case 90919029:
					return typeof(MotorbikeData).GetProperty(nameof(LeanForceMaxVel));

				case 2727731914:
					return typeof(MotorbikeData).GetProperty(nameof(CounterLeanForce));

				case 877604538:
					return typeof(MotorbikeData).GetProperty(nameof(StandStillRoll));

				case 441919910:
					return typeof(MotorbikeData).GetProperty(nameof(DampBigJumpImpactVelocity));

				case 4278552638:
					return typeof(MotorbikeData).GetProperty(nameof(YawBrakeDampingLerpStartScale));

				case 3443030225:
					return typeof(MotorbikeData).GetProperty(nameof(YawBrakeDampingLerpEndScale));

				case 2464692130:
					return typeof(MotorbikeData).GetProperty(nameof(StoppieActivationVelocity));

				case 3715175158:
					return typeof(MotorbikeData).GetProperty(nameof(StoppieStartVelocity));

				case 3891742718:
					return typeof(MotorbikeData).GetProperty(nameof(LeanForce));

				case 2105377289:
					return typeof(MotorbikeData).GetProperty(nameof(StoppieMomentum));

				case 2398478128:
					return typeof(MotorbikeData).GetProperty(nameof(ShortOffgroundGravityMultiplier));

				case 2063770090:
					return typeof(MotorbikeData).GetProperty(nameof(MaxLeaningRoll));

				case 3176785966:
					return typeof(MotorbikeData).GetProperty(nameof(StoppieStopVelocity));

				case 2388981380:
					return typeof(MotorbikeData).GetProperty(nameof(ProximityHeightTranslation));

				case 3008032341:
					return typeof(MotorbikeData).GetProperty(nameof(WheelieMaxNoDownForceContactTime));

				case 3277378970:
					return typeof(MotorbikeData).GetProperty(nameof(WheelieMaxNoContactTime));

				case 922430370:
					return typeof(MotorbikeData).GetProperty(nameof(WheelieSteeringFactor));

				case 756716118:
					return typeof(MotorbikeData).GetProperty(nameof(WheelieInertia));

				case 1112627949:
					return typeof(MotorbikeData).GetProperty(nameof(WheelieStartVelocity));

				case 2044326939:
					return typeof(MotorbikeData).GetProperty(nameof(WheelieMaxVelocityUndamped));

				case 911316990:
					return typeof(MotorbikeData).GetProperty(nameof(WheelieMaxVelocityDampRange));

				case 3287389598:
					return typeof(MotorbikeData).GetProperty(nameof(WheelieOutAngularMomentum));

				case 2926554611:
					return typeof(MotorbikeData).GetProperty(nameof(WheelieSpringDamping));

				case 3467767936:
					return typeof(MotorbikeData).GetProperty(nameof(WheelieAngularDamping));

				case 2883819815:
					return typeof(MotorbikeData).GetProperty(nameof(WheelieAngularDampingSpeed));

				case 2265366232:
					return typeof(MotorbikeData).GetProperty(nameof(ShortOffgroundPeriod));

				case 2419359695:
					return typeof(MotorbikeData).GetProperty(nameof(WheelieMaxAngle));

				case 698093808:
					return typeof(MotorbikeData).GetProperty(nameof(WheelieAngularStartMomentum));

				case 2291827481:
					return typeof(MotorbikeData).GetProperty(nameof(WheelieMaxVelocity));

				case 581384360:
					return typeof(MotorbikeData).GetProperty(nameof(WheelieVelocityForceScale));

				case 1921216113:
					return typeof(MotorbikeData).GetProperty(nameof(DampBigJumpImpact));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
