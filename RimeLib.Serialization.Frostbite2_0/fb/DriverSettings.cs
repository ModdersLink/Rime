///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Frostbite2_0.Ebx;
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(4, 152)]
	public partial class DriverSettings :
		Asset
	{
		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private float _MinRadius;

		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private float _RadiusGrowthSpeed;

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private float _StoppingDeceleration;

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private float _SteeringSensitivity;

		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private float _MaxBrakeOutput;

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private float _MaxDec;

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private float _LookAheadTime;

		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private float _AngleDiffForNoSlowdown;

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private float _AngleDiffForFullSlowdown;

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private float _VelocityAtFullSlowdown;

		[ObservableProperty]
		[property: ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		private float _VelDiffAtMinAcc;

		[ObservableProperty]
		[property: ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		private float _VelDiffAtMaxAcc;

		[ObservableProperty]
		[property: ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		private float _MaxYawToApplySprint;

		[ObservableProperty]
		[property: ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		private float _MinAcc;

		[ObservableProperty]
		[property: ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		private float _MaxAcc;

		[ObservableProperty]
		[property: ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		private float _VelDiffAtMinDec;

		[ObservableProperty]
		[property: ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		private float _VelDiffAtMaxDec;

		[ObservableProperty]
		[property: ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		private float _AccDiffAtMinThrottleVelocityDecelerating;

		[ObservableProperty]
		[property: ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		private float _MinDec;

		[ObservableProperty]
		[property: ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		private float _MinThrottleVelocityDecelerating;

		[ObservableProperty]
		[property: ContainerField(92), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
		private float _AccDiffAtMinThrottleVelocityAccelerating;

		[ObservableProperty]
		[property: ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private float _AccDiffAtMaxThrottleVelocityAccelerating;

		[ObservableProperty]
		[property: ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		private float _MaxThrottleVelocityDecelerating;

		[ObservableProperty]
		[property: ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		private float _MinThrottleVelocityAccelerating;

		[ObservableProperty]
		[property: ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		private float _MaxThrottleVelocityAccelerating;

		[ObservableProperty]
		[property: ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		private float _MaxPTerm;

		[ObservableProperty]
		[property: ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		private float _AccDiffAtMaxThrottleVelocityDecelerating;

		[ObservableProperty]
		[property: ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		private float _P;

		[ObservableProperty]
		[property: ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		private float _I;

		[ObservableProperty]
		[property: ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		private float _MaxError;

		[ObservableProperty]
		[property: ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		private float _MaxITerm;

		[ObservableProperty]
		[property: ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		private float _MaxSumError;

		[ObservableProperty]
		[property: ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		private float _D;

		[ObservableProperty]
		[property: ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		private bool _UseSquareVelDiffCurveDec;

		[ObservableProperty]
		[property: ContainerField(145), LayoutImmutable, Blittable, JsonProperty(Order = 145)]
		private bool _UseSquareAccDiffCurveDec;

		[ObservableProperty]
		[property: ContainerField(146), LayoutImmutable, Blittable, JsonProperty(Order = 146)]
		private bool _SquareBrakeOutput;

		[ObservableProperty]
		[property: ContainerField(147), LayoutImmutable, Blittable, JsonProperty(Order = 147)]
		private bool _UseSquareVelDiffCurveAcc;

		[ObservableProperty]
		[property: ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		private bool _UsePIDRegulator;

		[ObservableProperty]
		[property: ContainerField(149), LayoutImmutable, Blittable, JsonProperty(Order = 149)]
		private bool _UseSquareAccDiffCurveAcc;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(MinRadius);
			p_Writer.Write(RadiusGrowthSpeed);
			p_Writer.Write(StoppingDeceleration);
			p_Writer.Write(SteeringSensitivity);
			p_Writer.Write(MaxBrakeOutput);
			p_Writer.Write(MaxDec);
			p_Writer.Write(LookAheadTime);
			p_Writer.Write(AngleDiffForNoSlowdown);
			p_Writer.Write(AngleDiffForFullSlowdown);
			p_Writer.Write(VelocityAtFullSlowdown);
			p_Writer.Write(VelDiffAtMinAcc);
			p_Writer.Write(VelDiffAtMaxAcc);
			p_Writer.Write(MaxYawToApplySprint);
			p_Writer.Write(MinAcc);
			p_Writer.Write(MaxAcc);
			p_Writer.Write(VelDiffAtMinDec);
			p_Writer.Write(VelDiffAtMaxDec);
			p_Writer.Write(AccDiffAtMinThrottleVelocityDecelerating);
			p_Writer.Write(MinDec);
			p_Writer.Write(MinThrottleVelocityDecelerating);
			p_Writer.Write(AccDiffAtMinThrottleVelocityAccelerating);
			p_Writer.Write(AccDiffAtMaxThrottleVelocityAccelerating);
			p_Writer.Write(MaxThrottleVelocityDecelerating);
			p_Writer.Write(MinThrottleVelocityAccelerating);
			p_Writer.Write(MaxThrottleVelocityAccelerating);
			p_Writer.Write(MaxPTerm);
			p_Writer.Write(AccDiffAtMaxThrottleVelocityDecelerating);
			p_Writer.Write(P);
			p_Writer.Write(I);
			p_Writer.Write(MaxError);
			p_Writer.Write(MaxITerm);
			p_Writer.Write(MaxSumError);
			p_Writer.Write(D);
			p_Writer.Write(UseSquareVelDiffCurveDec);
			p_Writer.Write(UseSquareAccDiffCurveDec);
			p_Writer.Write(SquareBrakeOutput);
			p_Writer.Write(UseSquareVelDiffCurveAcc);
			p_Writer.Write(UsePIDRegulator);
			p_Writer.Write(UseSquareAccDiffCurveAcc);
			p_Writer.WriteNullBytes(2);
		}
	}
}
