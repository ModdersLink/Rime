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

namespace fb
{
	[ContainerType(4, 152)]
	public class DriverSettings :
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public float MinRadius { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public float RadiusGrowthSpeed { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public float StoppingDeceleration { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public float SteeringSensitivity { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public float MaxBrakeOutput { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public float MaxDec { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public float LookAheadTime { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public float AngleDiffForNoSlowdown { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public float AngleDiffForFullSlowdown { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public float VelocityAtFullSlowdown { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		public float VelDiffAtMinAcc { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		public float VelDiffAtMaxAcc { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		public float MaxYawToApplySprint { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		public float MinAcc { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		public float MaxAcc { get; set; }

		[ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		public float VelDiffAtMinDec { get; set; }

		[ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		public float VelDiffAtMaxDec { get; set; }

		[ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		public float AccDiffAtMinThrottleVelocityDecelerating { get; set; }

		[ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		public float MinDec { get; set; }

		[ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		public float MinThrottleVelocityDecelerating { get; set; }

		[ContainerField(92), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
		public float AccDiffAtMinThrottleVelocityAccelerating { get; set; }

		[ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public float AccDiffAtMaxThrottleVelocityAccelerating { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		public float MaxThrottleVelocityDecelerating { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		public float MinThrottleVelocityAccelerating { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		public float MaxThrottleVelocityAccelerating { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		public float MaxPTerm { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		public float AccDiffAtMaxThrottleVelocityDecelerating { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		public float P { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		public float I { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		public float MaxError { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		public float MaxITerm { get; set; }

		[ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		public float MaxSumError { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		public float D { get; set; }

		[ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		public bool UseSquareVelDiffCurveDec { get; set; }

		[ContainerField(145), LayoutImmutable, Blittable, JsonProperty(Order = 145)]
		public bool UseSquareAccDiffCurveDec { get; set; }

		[ContainerField(146), LayoutImmutable, Blittable, JsonProperty(Order = 146)]
		public bool SquareBrakeOutput { get; set; }

		[ContainerField(147), LayoutImmutable, Blittable, JsonProperty(Order = 147)]
		public bool UseSquareVelDiffCurveAcc { get; set; }

		[ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		public bool UsePIDRegulator { get; set; }

		[ContainerField(149), LayoutImmutable, Blittable, JsonProperty(Order = 149)]
		public bool UseSquareAccDiffCurveAcc { get; set; }

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
