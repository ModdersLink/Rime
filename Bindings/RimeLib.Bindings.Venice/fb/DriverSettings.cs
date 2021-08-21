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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 152)]
	public class DriverSettings : 
		Asset
	{
		protected float m_MinRadius = new float();
		[ContainerField(Name: "MinRadius", Offset: 12, NameHash: 4053568023, Flags: 49469), LayoutImmutable, Blittable]
		public float MinRadius { get { return m_MinRadius; } set { if (OnPropertyChanging("DriverSettings." + nameof(MinRadius), this, m_MinRadius, value)) m_MinRadius = value; } } // 0xC (12)
		
		protected float m_RadiusGrowthSpeed = new float();
		[ContainerField(Name: "RadiusGrowthSpeed", Offset: 16, NameHash: 2845828299, Flags: 49469), LayoutImmutable, Blittable]
		public float RadiusGrowthSpeed { get { return m_RadiusGrowthSpeed; } set { if (OnPropertyChanging("DriverSettings." + nameof(RadiusGrowthSpeed), this, m_RadiusGrowthSpeed, value)) m_RadiusGrowthSpeed = value; } } // 0x10 (16)
		
		protected float m_StoppingDeceleration = new float();
		[ContainerField(Name: "StoppingDeceleration", Offset: 20, NameHash: 2524085644, Flags: 49469), LayoutImmutable, Blittable]
		public float StoppingDeceleration { get { return m_StoppingDeceleration; } set { if (OnPropertyChanging("DriverSettings." + nameof(StoppingDeceleration), this, m_StoppingDeceleration, value)) m_StoppingDeceleration = value; } } // 0x14 (20)
		
		protected float m_SteeringSensitivity = new float();
		[ContainerField(Name: "SteeringSensitivity", Offset: 24, NameHash: 1426555133, Flags: 49469), LayoutImmutable, Blittable]
		public float SteeringSensitivity { get { return m_SteeringSensitivity; } set { if (OnPropertyChanging("DriverSettings." + nameof(SteeringSensitivity), this, m_SteeringSensitivity, value)) m_SteeringSensitivity = value; } } // 0x18 (24)
		
		protected float m_MaxBrakeOutput = new float();
		[ContainerField(Name: "MaxBrakeOutput", Offset: 28, NameHash: 3490155569, Flags: 49469), LayoutImmutable, Blittable]
		public float MaxBrakeOutput { get { return m_MaxBrakeOutput; } set { if (OnPropertyChanging("DriverSettings." + nameof(MaxBrakeOutput), this, m_MaxBrakeOutput, value)) m_MaxBrakeOutput = value; } } // 0x1C (28)
		
		protected float m_MaxDec = new float();
		[ContainerField(Name: "MaxDec", Offset: 32, NameHash: 2642836051, Flags: 49469), LayoutImmutable, Blittable]
		public float MaxDec { get { return m_MaxDec; } set { if (OnPropertyChanging("DriverSettings." + nameof(MaxDec), this, m_MaxDec, value)) m_MaxDec = value; } } // 0x20 (32)
		
		protected float m_LookAheadTime = new float();
		[ContainerField(Name: "LookAheadTime", Offset: 36, NameHash: 3422362878, Flags: 49469), LayoutImmutable, Blittable]
		public float LookAheadTime { get { return m_LookAheadTime; } set { if (OnPropertyChanging("DriverSettings." + nameof(LookAheadTime), this, m_LookAheadTime, value)) m_LookAheadTime = value; } } // 0x24 (36)
		
		protected float m_AngleDiffForNoSlowdown = new float();
		[ContainerField(Name: "AngleDiffForNoSlowdown", Offset: 40, NameHash: 2445158886, Flags: 49469), LayoutImmutable, Blittable]
		public float AngleDiffForNoSlowdown { get { return m_AngleDiffForNoSlowdown; } set { if (OnPropertyChanging("DriverSettings." + nameof(AngleDiffForNoSlowdown), this, m_AngleDiffForNoSlowdown, value)) m_AngleDiffForNoSlowdown = value; } } // 0x28 (40)
		
		protected float m_AngleDiffForFullSlowdown = new float();
		[ContainerField(Name: "AngleDiffForFullSlowdown", Offset: 44, NameHash: 2342024436, Flags: 49469), LayoutImmutable, Blittable]
		public float AngleDiffForFullSlowdown { get { return m_AngleDiffForFullSlowdown; } set { if (OnPropertyChanging("DriverSettings." + nameof(AngleDiffForFullSlowdown), this, m_AngleDiffForFullSlowdown, value)) m_AngleDiffForFullSlowdown = value; } } // 0x2C (44)
		
		protected float m_VelocityAtFullSlowdown = new float();
		[ContainerField(Name: "VelocityAtFullSlowdown", Offset: 48, NameHash: 2165330977, Flags: 49469), LayoutImmutable, Blittable]
		public float VelocityAtFullSlowdown { get { return m_VelocityAtFullSlowdown; } set { if (OnPropertyChanging("DriverSettings." + nameof(VelocityAtFullSlowdown), this, m_VelocityAtFullSlowdown, value)) m_VelocityAtFullSlowdown = value; } } // 0x30 (48)
		
		protected float m_VelDiffAtMinAcc = new float();
		[ContainerField(Name: "VelDiffAtMinAcc", Offset: 52, NameHash: 391295721, Flags: 49469), LayoutImmutable, Blittable]
		public float VelDiffAtMinAcc { get { return m_VelDiffAtMinAcc; } set { if (OnPropertyChanging("DriverSettings." + nameof(VelDiffAtMinAcc), this, m_VelDiffAtMinAcc, value)) m_VelDiffAtMinAcc = value; } } // 0x34 (52)
		
		protected float m_VelDiffAtMaxAcc = new float();
		[ContainerField(Name: "VelDiffAtMaxAcc", Offset: 56, NameHash: 401137847, Flags: 49469), LayoutImmutable, Blittable]
		public float VelDiffAtMaxAcc { get { return m_VelDiffAtMaxAcc; } set { if (OnPropertyChanging("DriverSettings." + nameof(VelDiffAtMaxAcc), this, m_VelDiffAtMaxAcc, value)) m_VelDiffAtMaxAcc = value; } } // 0x38 (56)
		
		protected float m_MaxYawToApplySprint = new float();
		[ContainerField(Name: "MaxYawToApplySprint", Offset: 60, NameHash: 3013304403, Flags: 49469), LayoutImmutable, Blittable]
		public float MaxYawToApplySprint { get { return m_MaxYawToApplySprint; } set { if (OnPropertyChanging("DriverSettings." + nameof(MaxYawToApplySprint), this, m_MaxYawToApplySprint, value)) m_MaxYawToApplySprint = value; } } // 0x3C (60)
		
		protected float m_MinAcc = new float();
		[ContainerField(Name: "MinAcc", Offset: 64, NameHash: 2633700366, Flags: 49469), LayoutImmutable, Blittable]
		public float MinAcc { get { return m_MinAcc; } set { if (OnPropertyChanging("DriverSettings." + nameof(MinAcc), this, m_MinAcc, value)) m_MinAcc = value; } } // 0x40 (64)
		
		protected float m_MaxAcc = new float();
		[ContainerField(Name: "MaxAcc", Offset: 68, NameHash: 2642832976, Flags: 49469), LayoutImmutable, Blittable]
		public float MaxAcc { get { return m_MaxAcc; } set { if (OnPropertyChanging("DriverSettings." + nameof(MaxAcc), this, m_MaxAcc, value)) m_MaxAcc = value; } } // 0x44 (68)
		
		protected float m_VelDiffAtMinDec = new float();
		[ContainerField(Name: "VelDiffAtMinDec", Offset: 72, NameHash: 391300970, Flags: 49469), LayoutImmutable, Blittable]
		public float VelDiffAtMinDec { get { return m_VelDiffAtMinDec; } set { if (OnPropertyChanging("DriverSettings." + nameof(VelDiffAtMinDec), this, m_VelDiffAtMinDec, value)) m_VelDiffAtMinDec = value; } } // 0x48 (72)
		
		protected float m_VelDiffAtMaxDec = new float();
		[ContainerField(Name: "VelDiffAtMaxDec", Offset: 76, NameHash: 401134772, Flags: 49469), LayoutImmutable, Blittable]
		public float VelDiffAtMaxDec { get { return m_VelDiffAtMaxDec; } set { if (OnPropertyChanging("DriverSettings." + nameof(VelDiffAtMaxDec), this, m_VelDiffAtMaxDec, value)) m_VelDiffAtMaxDec = value; } } // 0x4C (76)
		
		protected float m_AccDiffAtMinThrottleVelocityDecelerating = new float();
		[ContainerField(Name: "AccDiffAtMinThrottleVelocityDecelerating", Offset: 80, NameHash: 2612984288, Flags: 49469), LayoutImmutable, Blittable]
		public float AccDiffAtMinThrottleVelocityDecelerating { get { return m_AccDiffAtMinThrottleVelocityDecelerating; } set { if (OnPropertyChanging("DriverSettings." + nameof(AccDiffAtMinThrottleVelocityDecelerating), this, m_AccDiffAtMinThrottleVelocityDecelerating, value)) m_AccDiffAtMinThrottleVelocityDecelerating = value; } } // 0x50 (80)
		
		protected float m_MinDec = new float();
		[ContainerField(Name: "MinDec", Offset: 84, NameHash: 2633695117, Flags: 49469), LayoutImmutable, Blittable]
		public float MinDec { get { return m_MinDec; } set { if (OnPropertyChanging("DriverSettings." + nameof(MinDec), this, m_MinDec, value)) m_MinDec = value; } } // 0x54 (84)
		
		protected float m_MinThrottleVelocityDecelerating = new float();
		[ContainerField(Name: "MinThrottleVelocityDecelerating", Offset: 88, NameHash: 1371861369, Flags: 49469), LayoutImmutable, Blittable]
		public float MinThrottleVelocityDecelerating { get { return m_MinThrottleVelocityDecelerating; } set { if (OnPropertyChanging("DriverSettings." + nameof(MinThrottleVelocityDecelerating), this, m_MinThrottleVelocityDecelerating, value)) m_MinThrottleVelocityDecelerating = value; } } // 0x58 (88)
		
		protected float m_AccDiffAtMinThrottleVelocityAccelerating = new float();
		[ContainerField(Name: "AccDiffAtMinThrottleVelocityAccelerating", Offset: 92, NameHash: 3857427267, Flags: 49469), LayoutImmutable, Blittable]
		public float AccDiffAtMinThrottleVelocityAccelerating { get { return m_AccDiffAtMinThrottleVelocityAccelerating; } set { if (OnPropertyChanging("DriverSettings." + nameof(AccDiffAtMinThrottleVelocityAccelerating), this, m_AccDiffAtMinThrottleVelocityAccelerating, value)) m_AccDiffAtMinThrottleVelocityAccelerating = value; } } // 0x5C (92)
		
		protected float m_AccDiffAtMaxThrottleVelocityAccelerating = new float();
		[ContainerField(Name: "AccDiffAtMaxThrottleVelocityAccelerating", Offset: 96, NameHash: 3986228061, Flags: 49469), LayoutImmutable, Blittable]
		public float AccDiffAtMaxThrottleVelocityAccelerating { get { return m_AccDiffAtMaxThrottleVelocityAccelerating; } set { if (OnPropertyChanging("DriverSettings." + nameof(AccDiffAtMaxThrottleVelocityAccelerating), this, m_AccDiffAtMaxThrottleVelocityAccelerating, value)) m_AccDiffAtMaxThrottleVelocityAccelerating = value; } } // 0x60 (96)
		
		protected float m_MaxThrottleVelocityDecelerating = new float();
		[ContainerField(Name: "MaxThrottleVelocityDecelerating", Offset: 100, NameHash: 203746407, Flags: 49469), LayoutImmutable, Blittable]
		public float MaxThrottleVelocityDecelerating { get { return m_MaxThrottleVelocityDecelerating; } set { if (OnPropertyChanging("DriverSettings." + nameof(MaxThrottleVelocityDecelerating), this, m_MaxThrottleVelocityDecelerating, value)) m_MaxThrottleVelocityDecelerating = value; } } // 0x64 (100)
		
		protected float m_MinThrottleVelocityAccelerating = new float();
		[ContainerField(Name: "MinThrottleVelocityAccelerating", Offset: 104, NameHash: 2561805594, Flags: 49469), LayoutImmutable, Blittable]
		public float MinThrottleVelocityAccelerating { get { return m_MinThrottleVelocityAccelerating; } set { if (OnPropertyChanging("DriverSettings." + nameof(MinThrottleVelocityAccelerating), this, m_MinThrottleVelocityAccelerating, value)) m_MinThrottleVelocityAccelerating = value; } } // 0x68 (104)
		
		protected float m_MaxThrottleVelocityAccelerating = new float();
		[ContainerField(Name: "MaxThrottleVelocityAccelerating", Offset: 108, NameHash: 1704883972, Flags: 49469), LayoutImmutable, Blittable]
		public float MaxThrottleVelocityAccelerating { get { return m_MaxThrottleVelocityAccelerating; } set { if (OnPropertyChanging("DriverSettings." + nameof(MaxThrottleVelocityAccelerating), this, m_MaxThrottleVelocityAccelerating, value)) m_MaxThrottleVelocityAccelerating = value; } } // 0x6C (108)
		
		protected float m_MaxPTerm = new float();
		[ContainerField(Name: "MaxPTerm", Offset: 112, NameHash: 396390927, Flags: 49469), LayoutImmutable, Blittable]
		public float MaxPTerm { get { return m_MaxPTerm; } set { if (OnPropertyChanging("DriverSettings." + nameof(MaxPTerm), this, m_MaxPTerm, value)) m_MaxPTerm = value; } } // 0x70 (112)
		
		protected float m_AccDiffAtMaxThrottleVelocityDecelerating = new float();
		[ContainerField(Name: "AccDiffAtMaxThrottleVelocityDecelerating", Offset: 116, NameHash: 203251454, Flags: 49469), LayoutImmutable, Blittable]
		public float AccDiffAtMaxThrottleVelocityDecelerating { get { return m_AccDiffAtMaxThrottleVelocityDecelerating; } set { if (OnPropertyChanging("DriverSettings." + nameof(AccDiffAtMaxThrottleVelocityDecelerating), this, m_AccDiffAtMaxThrottleVelocityDecelerating, value)) m_AccDiffAtMaxThrottleVelocityDecelerating = value; } } // 0x74 (116)
		
		protected float m_P = new float();
		[ContainerField(Name: "P", Offset: 120, NameHash: 177653, Flags: 49469), LayoutImmutable, Blittable]
		public float P { get { return m_P; } set { if (OnPropertyChanging("DriverSettings." + nameof(P), this, m_P, value)) m_P = value; } } // 0x78 (120)
		
		protected float m_I = new float();
		[ContainerField(Name: "I", Offset: 124, NameHash: 177644, Flags: 49469), LayoutImmutable, Blittable]
		public float I { get { return m_I; } set { if (OnPropertyChanging("DriverSettings." + nameof(I), this, m_I, value)) m_I = value; } } // 0x7C (124)
		
		protected float m_MaxError = new float();
		[ContainerField(Name: "MaxError", Offset: 128, NameHash: 421240457, Flags: 49469), LayoutImmutable, Blittable]
		public float MaxError { get { return m_MaxError; } set { if (OnPropertyChanging("DriverSettings." + nameof(MaxError), this, m_MaxError, value)) m_MaxError = value; } } // 0x80 (128)
		
		protected float m_MaxITerm = new float();
		[ContainerField(Name: "MaxITerm", Offset: 132, NameHash: 426983126, Flags: 49469), LayoutImmutable, Blittable]
		public float MaxITerm { get { return m_MaxITerm; } set { if (OnPropertyChanging("DriverSettings." + nameof(MaxITerm), this, m_MaxITerm, value)) m_MaxITerm = value; } } // 0x84 (132)
		
		protected float m_MaxSumError = new float();
		[ContainerField(Name: "MaxSumError", Offset: 136, NameHash: 859402786, Flags: 49469), LayoutImmutable, Blittable]
		public float MaxSumError { get { return m_MaxSumError; } set { if (OnPropertyChanging("DriverSettings." + nameof(MaxSumError), this, m_MaxSumError, value)) m_MaxSumError = value; } } // 0x88 (136)
		
		protected float m_D = new float();
		[ContainerField(Name: "D", Offset: 140, NameHash: 177633, Flags: 49469), LayoutImmutable, Blittable]
		public float D { get { return m_D; } set { if (OnPropertyChanging("DriverSettings." + nameof(D), this, m_D, value)) m_D = value; } } // 0x8C (140)
		
		protected bool m_UseSquareVelDiffCurveDec = new bool();
		[ContainerField(Name: "UseSquareVelDiffCurveDec", Offset: 144, NameHash: 2792647328, Flags: 49325), LayoutImmutable, Blittable]
		public bool UseSquareVelDiffCurveDec { get { return m_UseSquareVelDiffCurveDec; } set { if (OnPropertyChanging("DriverSettings." + nameof(UseSquareVelDiffCurveDec), this, m_UseSquareVelDiffCurveDec, value)) m_UseSquareVelDiffCurveDec = value; } } // 0x90 (144)
		
		protected bool m_UseSquareAccDiffCurveDec = new bool();
		[ContainerField(Name: "UseSquareAccDiffCurveDec", Offset: 145, NameHash: 3859830206, Flags: 49325), LayoutImmutable, Blittable]
		public bool UseSquareAccDiffCurveDec { get { return m_UseSquareAccDiffCurveDec; } set { if (OnPropertyChanging("DriverSettings." + nameof(UseSquareAccDiffCurveDec), this, m_UseSquareAccDiffCurveDec, value)) m_UseSquareAccDiffCurveDec = value; } } // 0x91 (145)
		
		protected bool m_SquareBrakeOutput = new bool();
		[ContainerField(Name: "SquareBrakeOutput", Offset: 146, NameHash: 4011213668, Flags: 49325), LayoutImmutable, Blittable]
		public bool SquareBrakeOutput { get { return m_SquareBrakeOutput; } set { if (OnPropertyChanging("DriverSettings." + nameof(SquareBrakeOutput), this, m_SquareBrakeOutput, value)) m_SquareBrakeOutput = value; } } // 0x92 (146)
		
		protected bool m_UseSquareVelDiffCurveAcc = new bool();
		[ContainerField(Name: "UseSquareVelDiffCurveAcc", Offset: 147, NameHash: 2792641955, Flags: 49325), LayoutImmutable, Blittable]
		public bool UseSquareVelDiffCurveAcc { get { return m_UseSquareVelDiffCurveAcc; } set { if (OnPropertyChanging("DriverSettings." + nameof(UseSquareVelDiffCurveAcc), this, m_UseSquareVelDiffCurveAcc, value)) m_UseSquareVelDiffCurveAcc = value; } } // 0x93 (147)
		
		protected bool m_UsePIDRegulator = new bool();
		[ContainerField(Name: "UsePIDRegulator", Offset: 148, NameHash: 4246854618, Flags: 49325), LayoutImmutable, Blittable]
		public bool UsePIDRegulator { get { return m_UsePIDRegulator; } set { if (OnPropertyChanging("DriverSettings." + nameof(UsePIDRegulator), this, m_UsePIDRegulator, value)) m_UsePIDRegulator = value; } } // 0x94 (148)
		
		protected bool m_UseSquareAccDiffCurveAcc = new bool();
		[ContainerField(Name: "UseSquareAccDiffCurveAcc", Offset: 149, NameHash: 3859833405, Flags: 49325), LayoutImmutable, Blittable]
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
