///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class DriverSettings : 
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float MinRadius { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float RadiusGrowthSpeed { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float StoppingDeceleration { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float SteeringSensitivity { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float MaxBrakeOutput { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float MaxDec { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float LookAheadTime { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public float AngleDiffForNoSlowdown { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public float AngleDiffForFullSlowdown { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public float VelocityAtFullSlowdown { get; set; } // 0x30 (48)
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public float VelDiffAtMinAcc { get; set; } // 0x34 (52)
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public float VelDiffAtMaxAcc { get; set; } // 0x38 (56)
		
		[ContainerField(60), LayoutImmutable, Blittable]
		public float MaxYawToApplySprint { get; set; } // 0x3C (60)
		
		[ContainerField(64), LayoutImmutable, Blittable]
		public float MinAcc { get; set; } // 0x40 (64)
		
		[ContainerField(68), LayoutImmutable, Blittable]
		public float MaxAcc { get; set; } // 0x44 (68)
		
		[ContainerField(72), LayoutImmutable, Blittable]
		public float VelDiffAtMinDec { get; set; } // 0x48 (72)
		
		[ContainerField(76), LayoutImmutable, Blittable]
		public float VelDiffAtMaxDec { get; set; } // 0x4C (76)
		
		[ContainerField(80), LayoutImmutable, Blittable]
		public float AccDiffAtMinThrottleVelocityDecelerating { get; set; } // 0x50 (80)
		
		[ContainerField(84), LayoutImmutable, Blittable]
		public float MinDec { get; set; } // 0x54 (84)
		
		[ContainerField(88), LayoutImmutable, Blittable]
		public float MinThrottleVelocityDecelerating { get; set; } // 0x58 (88)
		
		[ContainerField(92), LayoutImmutable, Blittable]
		public float AccDiffAtMinThrottleVelocityAccelerating { get; set; } // 0x5C (92)
		
		[ContainerField(96), LayoutImmutable, Blittable]
		public float AccDiffAtMaxThrottleVelocityAccelerating { get; set; } // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public float MaxThrottleVelocityDecelerating { get; set; } // 0x64 (100)
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public float MinThrottleVelocityAccelerating { get; set; } // 0x68 (104)
		
		[ContainerField(108), LayoutImmutable, Blittable]
		public float MaxThrottleVelocityAccelerating { get; set; } // 0x6C (108)
		
		[ContainerField(112), LayoutImmutable, Blittable]
		public float MaxPTerm { get; set; } // 0x70 (112)
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public float AccDiffAtMaxThrottleVelocityDecelerating { get; set; } // 0x74 (116)
		
		[ContainerField(120), LayoutImmutable, Blittable]
		public float P { get; set; } // 0x78 (120)
		
		[ContainerField(124), LayoutImmutable, Blittable]
		public float I { get; set; } // 0x7C (124)
		
		[ContainerField(128), LayoutImmutable, Blittable]
		public float MaxError { get; set; } // 0x80 (128)
		
		[ContainerField(132), LayoutImmutable, Blittable]
		public float MaxITerm { get; set; } // 0x84 (132)
		
		[ContainerField(136), LayoutImmutable, Blittable]
		public float MaxSumError { get; set; } // 0x88 (136)
		
		[ContainerField(140), LayoutImmutable, Blittable]
		public float D { get; set; } // 0x8C (140)
		
		[ContainerField(144), LayoutImmutable, Blittable]
		public bool UseSquareVelDiffCurveDec { get; set; } // 0x90 (144)
		
		[ContainerField(145), LayoutImmutable, Blittable]
		public bool UseSquareAccDiffCurveDec { get; set; } // 0x91 (145)
		
		[ContainerField(146), LayoutImmutable, Blittable]
		public bool SquareBrakeOutput { get; set; } // 0x92 (146)
		
		[ContainerField(147), LayoutImmutable, Blittable]
		public bool UseSquareVelDiffCurveAcc { get; set; } // 0x93 (147)
		
		[ContainerField(148), LayoutImmutable, Blittable]
		public bool UsePIDRegulator { get; set; } // 0x94 (148)
		
		[ContainerField(149), LayoutImmutable, Blittable]
		public bool UseSquareAccDiffCurveAcc { get; set; } // 0x95 (149)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4053568023:
					MinRadius = (float) p_Value;
					break;

				case 2845828299:
					RadiusGrowthSpeed = (float) p_Value;
					break;

				case 2524085644:
					StoppingDeceleration = (float) p_Value;
					break;

				case 1426555133:
					SteeringSensitivity = (float) p_Value;
					break;

				case 3490155569:
					MaxBrakeOutput = (float) p_Value;
					break;

				case 2642836051:
					MaxDec = (float) p_Value;
					break;

				case 3422362878:
					LookAheadTime = (float) p_Value;
					break;

				case 2445158886:
					AngleDiffForNoSlowdown = (float) p_Value;
					break;

				case 2342024436:
					AngleDiffForFullSlowdown = (float) p_Value;
					break;

				case 2165330977:
					VelocityAtFullSlowdown = (float) p_Value;
					break;

				case 391295721:
					VelDiffAtMinAcc = (float) p_Value;
					break;

				case 401137847:
					VelDiffAtMaxAcc = (float) p_Value;
					break;

				case 3013304403:
					MaxYawToApplySprint = (float) p_Value;
					break;

				case 2633700366:
					MinAcc = (float) p_Value;
					break;

				case 2642832976:
					MaxAcc = (float) p_Value;
					break;

				case 391300970:
					VelDiffAtMinDec = (float) p_Value;
					break;

				case 401134772:
					VelDiffAtMaxDec = (float) p_Value;
					break;

				case 2612984288:
					AccDiffAtMinThrottleVelocityDecelerating = (float) p_Value;
					break;

				case 2633695117:
					MinDec = (float) p_Value;
					break;

				case 1371861369:
					MinThrottleVelocityDecelerating = (float) p_Value;
					break;

				case 3857427267:
					AccDiffAtMinThrottleVelocityAccelerating = (float) p_Value;
					break;

				case 3986228061:
					AccDiffAtMaxThrottleVelocityAccelerating = (float) p_Value;
					break;

				case 203746407:
					MaxThrottleVelocityDecelerating = (float) p_Value;
					break;

				case 2561805594:
					MinThrottleVelocityAccelerating = (float) p_Value;
					break;

				case 1704883972:
					MaxThrottleVelocityAccelerating = (float) p_Value;
					break;

				case 396390927:
					MaxPTerm = (float) p_Value;
					break;

				case 203251454:
					AccDiffAtMaxThrottleVelocityDecelerating = (float) p_Value;
					break;

				case 177653:
					P = (float) p_Value;
					break;

				case 177644:
					I = (float) p_Value;
					break;

				case 421240457:
					MaxError = (float) p_Value;
					break;

				case 426983126:
					MaxITerm = (float) p_Value;
					break;

				case 859402786:
					MaxSumError = (float) p_Value;
					break;

				case 177633:
					D = (float) p_Value;
					break;

				case 2792647328:
					UseSquareVelDiffCurveDec = (bool) p_Value;
					break;

				case 3859830206:
					UseSquareAccDiffCurveDec = (bool) p_Value;
					break;

				case 4011213668:
					SquareBrakeOutput = (bool) p_Value;
					break;

				case 2792641955:
					UseSquareVelDiffCurveAcc = (bool) p_Value;
					break;

				case 4246854618:
					UsePIDRegulator = (bool) p_Value;
					break;

				case 3859833405:
					UseSquareAccDiffCurveAcc = (bool) p_Value;
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
				case 4053568023:
					return MinRadius;

				case 2845828299:
					return RadiusGrowthSpeed;

				case 2524085644:
					return StoppingDeceleration;

				case 1426555133:
					return SteeringSensitivity;

				case 3490155569:
					return MaxBrakeOutput;

				case 2642836051:
					return MaxDec;

				case 3422362878:
					return LookAheadTime;

				case 2445158886:
					return AngleDiffForNoSlowdown;

				case 2342024436:
					return AngleDiffForFullSlowdown;

				case 2165330977:
					return VelocityAtFullSlowdown;

				case 391295721:
					return VelDiffAtMinAcc;

				case 401137847:
					return VelDiffAtMaxAcc;

				case 3013304403:
					return MaxYawToApplySprint;

				case 2633700366:
					return MinAcc;

				case 2642832976:
					return MaxAcc;

				case 391300970:
					return VelDiffAtMinDec;

				case 401134772:
					return VelDiffAtMaxDec;

				case 2612984288:
					return AccDiffAtMinThrottleVelocityDecelerating;

				case 2633695117:
					return MinDec;

				case 1371861369:
					return MinThrottleVelocityDecelerating;

				case 3857427267:
					return AccDiffAtMinThrottleVelocityAccelerating;

				case 3986228061:
					return AccDiffAtMaxThrottleVelocityAccelerating;

				case 203746407:
					return MaxThrottleVelocityDecelerating;

				case 2561805594:
					return MinThrottleVelocityAccelerating;

				case 1704883972:
					return MaxThrottleVelocityAccelerating;

				case 396390927:
					return MaxPTerm;

				case 203251454:
					return AccDiffAtMaxThrottleVelocityDecelerating;

				case 177653:
					return P;

				case 177644:
					return I;

				case 421240457:
					return MaxError;

				case 426983126:
					return MaxITerm;

				case 859402786:
					return MaxSumError;

				case 177633:
					return D;

				case 2792647328:
					return UseSquareVelDiffCurveDec;

				case 3859830206:
					return UseSquareAccDiffCurveDec;

				case 4011213668:
					return SquareBrakeOutput;

				case 2792641955:
					return UseSquareVelDiffCurveAcc;

				case 4246854618:
					return UsePIDRegulator;

				case 3859833405:
					return UseSquareAccDiffCurveAcc;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4053568023:
					return typeof(DriverSettings).GetProperty(nameof(MinRadius));

				case 2845828299:
					return typeof(DriverSettings).GetProperty(nameof(RadiusGrowthSpeed));

				case 2524085644:
					return typeof(DriverSettings).GetProperty(nameof(StoppingDeceleration));

				case 1426555133:
					return typeof(DriverSettings).GetProperty(nameof(SteeringSensitivity));

				case 3490155569:
					return typeof(DriverSettings).GetProperty(nameof(MaxBrakeOutput));

				case 2642836051:
					return typeof(DriverSettings).GetProperty(nameof(MaxDec));

				case 3422362878:
					return typeof(DriverSettings).GetProperty(nameof(LookAheadTime));

				case 2445158886:
					return typeof(DriverSettings).GetProperty(nameof(AngleDiffForNoSlowdown));

				case 2342024436:
					return typeof(DriverSettings).GetProperty(nameof(AngleDiffForFullSlowdown));

				case 2165330977:
					return typeof(DriverSettings).GetProperty(nameof(VelocityAtFullSlowdown));

				case 391295721:
					return typeof(DriverSettings).GetProperty(nameof(VelDiffAtMinAcc));

				case 401137847:
					return typeof(DriverSettings).GetProperty(nameof(VelDiffAtMaxAcc));

				case 3013304403:
					return typeof(DriverSettings).GetProperty(nameof(MaxYawToApplySprint));

				case 2633700366:
					return typeof(DriverSettings).GetProperty(nameof(MinAcc));

				case 2642832976:
					return typeof(DriverSettings).GetProperty(nameof(MaxAcc));

				case 391300970:
					return typeof(DriverSettings).GetProperty(nameof(VelDiffAtMinDec));

				case 401134772:
					return typeof(DriverSettings).GetProperty(nameof(VelDiffAtMaxDec));

				case 2612984288:
					return typeof(DriverSettings).GetProperty(nameof(AccDiffAtMinThrottleVelocityDecelerating));

				case 2633695117:
					return typeof(DriverSettings).GetProperty(nameof(MinDec));

				case 1371861369:
					return typeof(DriverSettings).GetProperty(nameof(MinThrottleVelocityDecelerating));

				case 3857427267:
					return typeof(DriverSettings).GetProperty(nameof(AccDiffAtMinThrottleVelocityAccelerating));

				case 3986228061:
					return typeof(DriverSettings).GetProperty(nameof(AccDiffAtMaxThrottleVelocityAccelerating));

				case 203746407:
					return typeof(DriverSettings).GetProperty(nameof(MaxThrottleVelocityDecelerating));

				case 2561805594:
					return typeof(DriverSettings).GetProperty(nameof(MinThrottleVelocityAccelerating));

				case 1704883972:
					return typeof(DriverSettings).GetProperty(nameof(MaxThrottleVelocityAccelerating));

				case 396390927:
					return typeof(DriverSettings).GetProperty(nameof(MaxPTerm));

				case 203251454:
					return typeof(DriverSettings).GetProperty(nameof(AccDiffAtMaxThrottleVelocityDecelerating));

				case 177653:
					return typeof(DriverSettings).GetProperty(nameof(P));

				case 177644:
					return typeof(DriverSettings).GetProperty(nameof(I));

				case 421240457:
					return typeof(DriverSettings).GetProperty(nameof(MaxError));

				case 426983126:
					return typeof(DriverSettings).GetProperty(nameof(MaxITerm));

				case 859402786:
					return typeof(DriverSettings).GetProperty(nameof(MaxSumError));

				case 177633:
					return typeof(DriverSettings).GetProperty(nameof(D));

				case 2792647328:
					return typeof(DriverSettings).GetProperty(nameof(UseSquareVelDiffCurveDec));

				case 3859830206:
					return typeof(DriverSettings).GetProperty(nameof(UseSquareAccDiffCurveDec));

				case 4011213668:
					return typeof(DriverSettings).GetProperty(nameof(SquareBrakeOutput));

				case 2792641955:
					return typeof(DriverSettings).GetProperty(nameof(UseSquareVelDiffCurveAcc));

				case 4246854618:
					return typeof(DriverSettings).GetProperty(nameof(UsePIDRegulator));

				case 3859833405:
					return typeof(DriverSettings).GetProperty(nameof(UseSquareAccDiffCurveAcc));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
