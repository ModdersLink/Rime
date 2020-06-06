///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class MotorbikeData : 
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 WheelieForceBodyOffset { get; set; } = new Vec3(); // 0x10 (16)
		
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 WheelieForce { get; set; } = new Vec3(); // 0x20 (32)
		
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 DampBigJumpImpactCounterForce { get; set; } = new Vec3(); // 0x30 (48)
		
		[ContainerField(64), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 ProximityExtScale { get; set; } = new Vec3(); // 0x40 (64)
		
		[ContainerField(80), LayoutImmutable, Blittable]
		public float JumpForwardLeanMinAngle { get; set; } // 0x50 (80)
		
		[ContainerField(84), LayoutImmutable, Blittable]
		public float JumpForwardLeanMomentum { get; set; } // 0x54 (84)
		
		[ContainerField(88), LayoutImmutable, Blittable]
		public float KickstandRoll { get; set; } // 0x58 (88)
		
		[ContainerField(92), LayoutImmutable, Blittable]
		public float KickstandLinearDamping { get; set; } // 0x5C (92)
		
		[ContainerField(96), LayoutImmutable, Blittable]
		public float LeanForceMaxVel { get; set; } // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public float CounterLeanForce { get; set; } // 0x64 (100)
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public float StandStillRoll { get; set; } // 0x68 (104)
		
		[ContainerField(108), LayoutImmutable, Blittable]
		public float DampBigJumpImpactVelocity { get; set; } // 0x6C (108)
		
		[ContainerField(112), LayoutImmutable, Blittable]
		public float YawBrakeDampingLerpStartScale { get; set; } // 0x70 (112)
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public float YawBrakeDampingLerpEndScale { get; set; } // 0x74 (116)
		
		[ContainerField(120), LayoutImmutable, Blittable]
		public float StoppieActivationVelocity { get; set; } // 0x78 (120)
		
		[ContainerField(124), LayoutImmutable, Blittable]
		public float StoppieStartVelocity { get; set; } // 0x7C (124)
		
		[ContainerField(128), LayoutImmutable, Blittable]
		public float LeanForce { get; set; } // 0x80 (128)
		
		[ContainerField(132), LayoutImmutable, Blittable]
		public float StoppieMomentum { get; set; } // 0x84 (132)
		
		[ContainerField(136), LayoutImmutable, Blittable]
		public float ShortOffgroundGravityMultiplier { get; set; } // 0x88 (136)
		
		[ContainerField(140), LayoutImmutable, Blittable]
		public float MaxLeaningRoll { get; set; } // 0x8C (140)
		
		[ContainerField(144), LayoutImmutable, Blittable]
		public float StoppieStopVelocity { get; set; } // 0x90 (144)
		
		[ContainerField(148), LayoutImmutable, Blittable]
		public float ProximityHeightTranslation { get; set; } // 0x94 (148)
		
		[ContainerField(152), LayoutImmutable, Blittable]
		public float WheelieMaxNoDownForceContactTime { get; set; } // 0x98 (152)
		
		[ContainerField(156), LayoutImmutable, Blittable]
		public float WheelieMaxNoContactTime { get; set; } // 0x9C (156)
		
		[ContainerField(160), LayoutImmutable, Blittable]
		public float WheelieSteeringFactor { get; set; } // 0xA0 (160)
		
		[ContainerField(164), LayoutImmutable, Blittable]
		public float WheelieInertia { get; set; } // 0xA4 (164)
		
		[ContainerField(168), LayoutImmutable, Blittable]
		public float WheelieStartVelocity { get; set; } // 0xA8 (168)
		
		[ContainerField(172), LayoutImmutable, Blittable]
		public float WheelieMaxVelocityUndamped { get; set; } // 0xAC (172)
		
		[ContainerField(176), LayoutImmutable, Blittable]
		public float WheelieMaxVelocityDampRange { get; set; } // 0xB0 (176)
		
		[ContainerField(180), LayoutImmutable, Blittable]
		public float WheelieOutAngularMomentum { get; set; } // 0xB4 (180)
		
		[ContainerField(184), LayoutImmutable, Blittable]
		public float WheelieSpringDamping { get; set; } // 0xB8 (184)
		
		[ContainerField(188), LayoutImmutable, Blittable]
		public float WheelieAngularDamping { get; set; } // 0xBC (188)
		
		[ContainerField(192), LayoutImmutable, Blittable]
		public float WheelieAngularDampingSpeed { get; set; } // 0xC0 (192)
		
		[ContainerField(196), LayoutImmutable, Blittable]
		public float ShortOffgroundPeriod { get; set; } // 0xC4 (196)
		
		[ContainerField(200), LayoutImmutable, Blittable]
		public float WheelieMaxAngle { get; set; } // 0xC8 (200)
		
		[ContainerField(204), LayoutImmutable, Blittable]
		public float WheelieAngularStartMomentum { get; set; } // 0xCC (204)
		
		[ContainerField(208), LayoutImmutable, Blittable]
		public float WheelieMaxVelocity { get; set; } // 0xD0 (208)
		
		[ContainerField(212), LayoutImmutable, Blittable]
		public float WheelieVelocityForceScale { get; set; } // 0xD4 (212)
		
		[ContainerField(216), LayoutImmutable, Blittable]
		public bool DampBigJumpImpact { get; set; } // 0xD8 (216)
		
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
