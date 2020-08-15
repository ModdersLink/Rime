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
	[ContainerType(4)]
	public class DriverSettings : 
		Asset
	{
		protected float m_MinRadius = new float();
		[ContainerField(12), LayoutImmutable, Blittable, ContainerFieldNameHash(4053568023)]
		public float MinRadius { get { return m_MinRadius; } set { if (OnPropertyChanging("DriverSettings." + nameof(MinRadius), this, m_MinRadius, value)) m_MinRadius = value; } } // 0xC (12)
		
		protected float m_RadiusGrowthSpeed = new float();
		[ContainerField(16), LayoutImmutable, Blittable, ContainerFieldNameHash(2845828299)]
		public float RadiusGrowthSpeed { get { return m_RadiusGrowthSpeed; } set { if (OnPropertyChanging("DriverSettings." + nameof(RadiusGrowthSpeed), this, m_RadiusGrowthSpeed, value)) m_RadiusGrowthSpeed = value; } } // 0x10 (16)
		
		protected float m_StoppingDeceleration = new float();
		[ContainerField(20), LayoutImmutable, Blittable, ContainerFieldNameHash(2524085644)]
		public float StoppingDeceleration { get { return m_StoppingDeceleration; } set { if (OnPropertyChanging("DriverSettings." + nameof(StoppingDeceleration), this, m_StoppingDeceleration, value)) m_StoppingDeceleration = value; } } // 0x14 (20)
		
		protected float m_SteeringSensitivity = new float();
		[ContainerField(24), LayoutImmutable, Blittable, ContainerFieldNameHash(1426555133)]
		public float SteeringSensitivity { get { return m_SteeringSensitivity; } set { if (OnPropertyChanging("DriverSettings." + nameof(SteeringSensitivity), this, m_SteeringSensitivity, value)) m_SteeringSensitivity = value; } } // 0x18 (24)
		
		protected float m_MaxBrakeOutput = new float();
		[ContainerField(28), LayoutImmutable, Blittable, ContainerFieldNameHash(3490155569)]
		public float MaxBrakeOutput { get { return m_MaxBrakeOutput; } set { if (OnPropertyChanging("DriverSettings." + nameof(MaxBrakeOutput), this, m_MaxBrakeOutput, value)) m_MaxBrakeOutput = value; } } // 0x1C (28)
		
		protected float m_MaxDec = new float();
		[ContainerField(32), LayoutImmutable, Blittable, ContainerFieldNameHash(2642836051)]
		public float MaxDec { get { return m_MaxDec; } set { if (OnPropertyChanging("DriverSettings." + nameof(MaxDec), this, m_MaxDec, value)) m_MaxDec = value; } } // 0x20 (32)
		
		protected float m_LookAheadTime = new float();
		[ContainerField(36), LayoutImmutable, Blittable, ContainerFieldNameHash(3422362878)]
		public float LookAheadTime { get { return m_LookAheadTime; } set { if (OnPropertyChanging("DriverSettings." + nameof(LookAheadTime), this, m_LookAheadTime, value)) m_LookAheadTime = value; } } // 0x24 (36)
		
		protected float m_AngleDiffForNoSlowdown = new float();
		[ContainerField(40), LayoutImmutable, Blittable, ContainerFieldNameHash(2445158886)]
		public float AngleDiffForNoSlowdown { get { return m_AngleDiffForNoSlowdown; } set { if (OnPropertyChanging("DriverSettings." + nameof(AngleDiffForNoSlowdown), this, m_AngleDiffForNoSlowdown, value)) m_AngleDiffForNoSlowdown = value; } } // 0x28 (40)
		
		protected float m_AngleDiffForFullSlowdown = new float();
		[ContainerField(44), LayoutImmutable, Blittable, ContainerFieldNameHash(2342024436)]
		public float AngleDiffForFullSlowdown { get { return m_AngleDiffForFullSlowdown; } set { if (OnPropertyChanging("DriverSettings." + nameof(AngleDiffForFullSlowdown), this, m_AngleDiffForFullSlowdown, value)) m_AngleDiffForFullSlowdown = value; } } // 0x2C (44)
		
		protected float m_VelocityAtFullSlowdown = new float();
		[ContainerField(48), LayoutImmutable, Blittable, ContainerFieldNameHash(2165330977)]
		public float VelocityAtFullSlowdown { get { return m_VelocityAtFullSlowdown; } set { if (OnPropertyChanging("DriverSettings." + nameof(VelocityAtFullSlowdown), this, m_VelocityAtFullSlowdown, value)) m_VelocityAtFullSlowdown = value; } } // 0x30 (48)
		
		protected float m_VelDiffAtMinAcc = new float();
		[ContainerField(52), LayoutImmutable, Blittable, ContainerFieldNameHash(391295721)]
		public float VelDiffAtMinAcc { get { return m_VelDiffAtMinAcc; } set { if (OnPropertyChanging("DriverSettings." + nameof(VelDiffAtMinAcc), this, m_VelDiffAtMinAcc, value)) m_VelDiffAtMinAcc = value; } } // 0x34 (52)
		
		protected float m_VelDiffAtMaxAcc = new float();
		[ContainerField(56), LayoutImmutable, Blittable, ContainerFieldNameHash(401137847)]
		public float VelDiffAtMaxAcc { get { return m_VelDiffAtMaxAcc; } set { if (OnPropertyChanging("DriverSettings." + nameof(VelDiffAtMaxAcc), this, m_VelDiffAtMaxAcc, value)) m_VelDiffAtMaxAcc = value; } } // 0x38 (56)
		
		protected float m_MaxYawToApplySprint = new float();
		[ContainerField(60), LayoutImmutable, Blittable, ContainerFieldNameHash(3013304403)]
		public float MaxYawToApplySprint { get { return m_MaxYawToApplySprint; } set { if (OnPropertyChanging("DriverSettings." + nameof(MaxYawToApplySprint), this, m_MaxYawToApplySprint, value)) m_MaxYawToApplySprint = value; } } // 0x3C (60)
		
		protected float m_MinAcc = new float();
		[ContainerField(64), LayoutImmutable, Blittable, ContainerFieldNameHash(2633700366)]
		public float MinAcc { get { return m_MinAcc; } set { if (OnPropertyChanging("DriverSettings." + nameof(MinAcc), this, m_MinAcc, value)) m_MinAcc = value; } } // 0x40 (64)
		
		protected float m_MaxAcc = new float();
		[ContainerField(68), LayoutImmutable, Blittable, ContainerFieldNameHash(2642832976)]
		public float MaxAcc { get { return m_MaxAcc; } set { if (OnPropertyChanging("DriverSettings." + nameof(MaxAcc), this, m_MaxAcc, value)) m_MaxAcc = value; } } // 0x44 (68)
		
		protected float m_VelDiffAtMinDec = new float();
		[ContainerField(72), LayoutImmutable, Blittable, ContainerFieldNameHash(391300970)]
		public float VelDiffAtMinDec { get { return m_VelDiffAtMinDec; } set { if (OnPropertyChanging("DriverSettings." + nameof(VelDiffAtMinDec), this, m_VelDiffAtMinDec, value)) m_VelDiffAtMinDec = value; } } // 0x48 (72)
		
		protected float m_VelDiffAtMaxDec = new float();
		[ContainerField(76), LayoutImmutable, Blittable, ContainerFieldNameHash(401134772)]
		public float VelDiffAtMaxDec { get { return m_VelDiffAtMaxDec; } set { if (OnPropertyChanging("DriverSettings." + nameof(VelDiffAtMaxDec), this, m_VelDiffAtMaxDec, value)) m_VelDiffAtMaxDec = value; } } // 0x4C (76)
		
		protected float m_AccDiffAtMinThrottleVelocityDecelerating = new float();
		[ContainerField(80), LayoutImmutable, Blittable, ContainerFieldNameHash(2612984288)]
		public float AccDiffAtMinThrottleVelocityDecelerating { get { return m_AccDiffAtMinThrottleVelocityDecelerating; } set { if (OnPropertyChanging("DriverSettings." + nameof(AccDiffAtMinThrottleVelocityDecelerating), this, m_AccDiffAtMinThrottleVelocityDecelerating, value)) m_AccDiffAtMinThrottleVelocityDecelerating = value; } } // 0x50 (80)
		
		protected float m_MinDec = new float();
		[ContainerField(84), LayoutImmutable, Blittable, ContainerFieldNameHash(2633695117)]
		public float MinDec { get { return m_MinDec; } set { if (OnPropertyChanging("DriverSettings." + nameof(MinDec), this, m_MinDec, value)) m_MinDec = value; } } // 0x54 (84)
		
		protected float m_MinThrottleVelocityDecelerating = new float();
		[ContainerField(88), LayoutImmutable, Blittable, ContainerFieldNameHash(1371861369)]
		public float MinThrottleVelocityDecelerating { get { return m_MinThrottleVelocityDecelerating; } set { if (OnPropertyChanging("DriverSettings." + nameof(MinThrottleVelocityDecelerating), this, m_MinThrottleVelocityDecelerating, value)) m_MinThrottleVelocityDecelerating = value; } } // 0x58 (88)
		
		protected float m_AccDiffAtMinThrottleVelocityAccelerating = new float();
		[ContainerField(92), LayoutImmutable, Blittable, ContainerFieldNameHash(3857427267)]
		public float AccDiffAtMinThrottleVelocityAccelerating { get { return m_AccDiffAtMinThrottleVelocityAccelerating; } set { if (OnPropertyChanging("DriverSettings." + nameof(AccDiffAtMinThrottleVelocityAccelerating), this, m_AccDiffAtMinThrottleVelocityAccelerating, value)) m_AccDiffAtMinThrottleVelocityAccelerating = value; } } // 0x5C (92)
		
		protected float m_AccDiffAtMaxThrottleVelocityAccelerating = new float();
		[ContainerField(96), LayoutImmutable, Blittable, ContainerFieldNameHash(3986228061)]
		public float AccDiffAtMaxThrottleVelocityAccelerating { get { return m_AccDiffAtMaxThrottleVelocityAccelerating; } set { if (OnPropertyChanging("DriverSettings." + nameof(AccDiffAtMaxThrottleVelocityAccelerating), this, m_AccDiffAtMaxThrottleVelocityAccelerating, value)) m_AccDiffAtMaxThrottleVelocityAccelerating = value; } } // 0x60 (96)
		
		protected float m_MaxThrottleVelocityDecelerating = new float();
		[ContainerField(100), LayoutImmutable, Blittable, ContainerFieldNameHash(203746407)]
		public float MaxThrottleVelocityDecelerating { get { return m_MaxThrottleVelocityDecelerating; } set { if (OnPropertyChanging("DriverSettings." + nameof(MaxThrottleVelocityDecelerating), this, m_MaxThrottleVelocityDecelerating, value)) m_MaxThrottleVelocityDecelerating = value; } } // 0x64 (100)
		
		protected float m_MinThrottleVelocityAccelerating = new float();
		[ContainerField(104), LayoutImmutable, Blittable, ContainerFieldNameHash(2561805594)]
		public float MinThrottleVelocityAccelerating { get { return m_MinThrottleVelocityAccelerating; } set { if (OnPropertyChanging("DriverSettings." + nameof(MinThrottleVelocityAccelerating), this, m_MinThrottleVelocityAccelerating, value)) m_MinThrottleVelocityAccelerating = value; } } // 0x68 (104)
		
		protected float m_MaxThrottleVelocityAccelerating = new float();
		[ContainerField(108), LayoutImmutable, Blittable, ContainerFieldNameHash(1704883972)]
		public float MaxThrottleVelocityAccelerating { get { return m_MaxThrottleVelocityAccelerating; } set { if (OnPropertyChanging("DriverSettings." + nameof(MaxThrottleVelocityAccelerating), this, m_MaxThrottleVelocityAccelerating, value)) m_MaxThrottleVelocityAccelerating = value; } } // 0x6C (108)
		
		protected float m_MaxPTerm = new float();
		[ContainerField(112), LayoutImmutable, Blittable, ContainerFieldNameHash(396390927)]
		public float MaxPTerm { get { return m_MaxPTerm; } set { if (OnPropertyChanging("DriverSettings." + nameof(MaxPTerm), this, m_MaxPTerm, value)) m_MaxPTerm = value; } } // 0x70 (112)
		
		protected float m_AccDiffAtMaxThrottleVelocityDecelerating = new float();
		[ContainerField(116), LayoutImmutable, Blittable, ContainerFieldNameHash(203251454)]
		public float AccDiffAtMaxThrottleVelocityDecelerating { get { return m_AccDiffAtMaxThrottleVelocityDecelerating; } set { if (OnPropertyChanging("DriverSettings." + nameof(AccDiffAtMaxThrottleVelocityDecelerating), this, m_AccDiffAtMaxThrottleVelocityDecelerating, value)) m_AccDiffAtMaxThrottleVelocityDecelerating = value; } } // 0x74 (116)
		
		protected float m_P = new float();
		[ContainerField(120), LayoutImmutable, Blittable, ContainerFieldNameHash(177653)]
		public float P { get { return m_P; } set { if (OnPropertyChanging("DriverSettings." + nameof(P), this, m_P, value)) m_P = value; } } // 0x78 (120)
		
		protected float m_I = new float();
		[ContainerField(124), LayoutImmutable, Blittable, ContainerFieldNameHash(177644)]
		public float I { get { return m_I; } set { if (OnPropertyChanging("DriverSettings." + nameof(I), this, m_I, value)) m_I = value; } } // 0x7C (124)
		
		protected float m_MaxError = new float();
		[ContainerField(128), LayoutImmutable, Blittable, ContainerFieldNameHash(421240457)]
		public float MaxError { get { return m_MaxError; } set { if (OnPropertyChanging("DriverSettings." + nameof(MaxError), this, m_MaxError, value)) m_MaxError = value; } } // 0x80 (128)
		
		protected float m_MaxITerm = new float();
		[ContainerField(132), LayoutImmutable, Blittable, ContainerFieldNameHash(426983126)]
		public float MaxITerm { get { return m_MaxITerm; } set { if (OnPropertyChanging("DriverSettings." + nameof(MaxITerm), this, m_MaxITerm, value)) m_MaxITerm = value; } } // 0x84 (132)
		
		protected float m_MaxSumError = new float();
		[ContainerField(136), LayoutImmutable, Blittable, ContainerFieldNameHash(859402786)]
		public float MaxSumError { get { return m_MaxSumError; } set { if (OnPropertyChanging("DriverSettings." + nameof(MaxSumError), this, m_MaxSumError, value)) m_MaxSumError = value; } } // 0x88 (136)
		
		protected float m_D = new float();
		[ContainerField(140), LayoutImmutable, Blittable, ContainerFieldNameHash(177633)]
		public float D { get { return m_D; } set { if (OnPropertyChanging("DriverSettings." + nameof(D), this, m_D, value)) m_D = value; } } // 0x8C (140)
		
		protected bool m_UseSquareVelDiffCurveDec = new bool();
		[ContainerField(144), LayoutImmutable, Blittable, ContainerFieldNameHash(2792647328)]
		public bool UseSquareVelDiffCurveDec { get { return m_UseSquareVelDiffCurveDec; } set { if (OnPropertyChanging("DriverSettings." + nameof(UseSquareVelDiffCurveDec), this, m_UseSquareVelDiffCurveDec, value)) m_UseSquareVelDiffCurveDec = value; } } // 0x90 (144)
		
		protected bool m_UseSquareAccDiffCurveDec = new bool();
		[ContainerField(145), LayoutImmutable, Blittable, ContainerFieldNameHash(3859830206)]
		public bool UseSquareAccDiffCurveDec { get { return m_UseSquareAccDiffCurveDec; } set { if (OnPropertyChanging("DriverSettings." + nameof(UseSquareAccDiffCurveDec), this, m_UseSquareAccDiffCurveDec, value)) m_UseSquareAccDiffCurveDec = value; } } // 0x91 (145)
		
		protected bool m_SquareBrakeOutput = new bool();
		[ContainerField(146), LayoutImmutable, Blittable, ContainerFieldNameHash(4011213668)]
		public bool SquareBrakeOutput { get { return m_SquareBrakeOutput; } set { if (OnPropertyChanging("DriverSettings." + nameof(SquareBrakeOutput), this, m_SquareBrakeOutput, value)) m_SquareBrakeOutput = value; } } // 0x92 (146)
		
		protected bool m_UseSquareVelDiffCurveAcc = new bool();
		[ContainerField(147), LayoutImmutable, Blittable, ContainerFieldNameHash(2792641955)]
		public bool UseSquareVelDiffCurveAcc { get { return m_UseSquareVelDiffCurveAcc; } set { if (OnPropertyChanging("DriverSettings." + nameof(UseSquareVelDiffCurveAcc), this, m_UseSquareVelDiffCurveAcc, value)) m_UseSquareVelDiffCurveAcc = value; } } // 0x93 (147)
		
		protected bool m_UsePIDRegulator = new bool();
		[ContainerField(148), LayoutImmutable, Blittable, ContainerFieldNameHash(4246854618)]
		public bool UsePIDRegulator { get { return m_UsePIDRegulator; } set { if (OnPropertyChanging("DriverSettings." + nameof(UsePIDRegulator), this, m_UsePIDRegulator, value)) m_UsePIDRegulator = value; } } // 0x94 (148)
		
		protected bool m_UseSquareAccDiffCurveAcc = new bool();
		[ContainerField(149), LayoutImmutable, Blittable, ContainerFieldNameHash(3859833405)]
		public bool UseSquareAccDiffCurveAcc { get { return m_UseSquareAccDiffCurveAcc; } set { if (OnPropertyChanging("DriverSettings." + nameof(UseSquareAccDiffCurveAcc), this, m_UseSquareAccDiffCurveAcc, value)) m_UseSquareAccDiffCurveAcc = value; } } // 0x95 (149)
		
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
