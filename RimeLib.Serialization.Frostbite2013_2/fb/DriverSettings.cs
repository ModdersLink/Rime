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

using fb.Core;

namespace fb.GameShared;

[ContainerType(8, 192)]
public class DriverSettings
	: fb.Core.Asset
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public float MinRadius { get; set; } = 3.000f;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public float RadiusGrowthSpeed { get; set; } = 0.200f;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public float StoppingDeceleration { get; set; } = 10.000f;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public float SteeringSensitivity { get; set; } = 25.000f;
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public CtrRef<RegulatedSteering> RegulatedSteering { get; set; } = new();
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public float MaxBrakeOutput { get; set; } = 1.000f;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public float LookAheadTime { get; set; } = 1.000f;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public float AngleDiffForNoSlowdown { get; set; } = 50.000f;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public float AngleDiffForFullSlowdown { get; set; } = 90.000f;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public float VelocityAtFullSlowdown { get; set; } = 5.000f;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public float VelDiffAtMinAcc { get; set; } = 0.100f;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public float VelDiffAtMaxAcc { get; set; } = 7.000f;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public float MinAcc { get; set; } = 0.000f;
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public float MaxAcc { get; set; } = 8.000f;
	
	[ContainerField(0x54), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
	public float VelDiffAtMinDec { get; set; } = 0.100f;
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public float VelDiffAtMaxDec { get; set; } = 5.000f;
	
	[ContainerField(0x5c), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
	public float MinDec { get; set; } = 0.000f;
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public float MaxDec { get; set; } = 25.000f;
	
	[ContainerField(0x64), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
	public float AccDiffAtMinThrottleVelocityAccelerating { get; set; } = 1.000f;
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public float AccDiffAtMaxThrottleVelocityAccelerating { get; set; } = 20.000f;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public float MinThrottleVelocityAccelerating { get; set; } = 0.200f;
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public float MaxThrottleVelocityAccelerating { get; set; } = 1.000f;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public float AccDiffAtMinThrottleVelocityDecelerating { get; set; } = 3.000f;
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public float AccDiffAtMaxThrottleVelocityDecelerating { get; set; } = 10.000f;
	
	[ContainerField(0x7c), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
	public float MinThrottleVelocityDecelerating { get; set; } = 0.100f;
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public float MaxThrottleVelocityDecelerating { get; set; } = 5.000f;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public float P { get; set; } = 0.100f;
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public float I { get; set; } = 0.010f;
	
	[ContainerField(0x8c), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
	public float D { get; set; } = 0.010f;
	
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public float MaxError { get; set; } = 100.000f;
	
	[ContainerField(0x94), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
	public float MaxSumError { get; set; } = 100.000f;
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public float MaxPTerm { get; set; } = 1.000f;
	
	[ContainerField(0x9c), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
	public float MaxITerm { get; set; } = 1.000f;
	
	[ContainerField(0xa0), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public float MaxYawToApplySprint { get; set; } = 0.300f;
	
	[ContainerField(0xa4), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
	public float MaxAngleDiffToApplySprint { get; set; } = 0.000f;
	
	[ContainerField(0xa8), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
	public float MaxAngularVelocityToApplySprint { get; set; } = 0.000f;
	
	[ContainerField(0xac), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
	public float MinVelocityToApplySprint { get; set; } = 0.000f;
	
	[ContainerField(0xb0), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public float LookAheadAimTime { get; set; } = 0.000f;
	
	[ContainerField(0xb4), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
	public float MinLookAheadDist { get; set; } = 0.000f;
	
	[ContainerField(0xb8), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
	public bool SquareBrakeOutput { get; set; } = true;
	
	[ContainerField(0xb9), LayoutImmutable, Blittable, JsonProperty(Order = 185)]
	public bool UseSquareVelDiffCurveAcc { get; set; } = false;
	
	[ContainerField(0xba), LayoutImmutable, Blittable, JsonProperty(Order = 186)]
	public bool UseSquareVelDiffCurveDec { get; set; } = true;
	
	[ContainerField(0xbb), LayoutImmutable, Blittable, JsonProperty(Order = 187)]
	public bool UseSquareAccDiffCurveAcc { get; set; } = false;
	
	[ContainerField(0xbc), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
	public bool UseSquareAccDiffCurveDec { get; set; } = false;
	
	[ContainerField(0xbd), LayoutImmutable, Blittable, JsonProperty(Order = 189)]
	public bool UsePIDRegulator { get; set; } = false;
	
	[ContainerField(0xbe), LayoutImmutable, Blittable, JsonProperty(Order = 190)]
	public bool IncludeYDifference { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(MinRadius);
		p_Writer.Write(RadiusGrowthSpeed);
		p_Writer.Write(StoppingDeceleration);
		p_Writer.Write(SteeringSensitivity);
		p_Writer.Write(p_EbxWriter.WriteImport(RegulatedSteering));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(MaxBrakeOutput);
		p_Writer.Write(LookAheadTime);
		p_Writer.Write(AngleDiffForNoSlowdown);
		p_Writer.Write(AngleDiffForFullSlowdown);
		p_Writer.Write(VelocityAtFullSlowdown);
		p_Writer.Write(VelDiffAtMinAcc);
		p_Writer.Write(VelDiffAtMaxAcc);
		p_Writer.Write(MinAcc);
		p_Writer.Write(MaxAcc);
		p_Writer.Write(VelDiffAtMinDec);
		p_Writer.Write(VelDiffAtMaxDec);
		p_Writer.Write(MinDec);
		p_Writer.Write(MaxDec);
		p_Writer.Write(AccDiffAtMinThrottleVelocityAccelerating);
		p_Writer.Write(AccDiffAtMaxThrottleVelocityAccelerating);
		p_Writer.Write(MinThrottleVelocityAccelerating);
		p_Writer.Write(MaxThrottleVelocityAccelerating);
		p_Writer.Write(AccDiffAtMinThrottleVelocityDecelerating);
		p_Writer.Write(AccDiffAtMaxThrottleVelocityDecelerating);
		p_Writer.Write(MinThrottleVelocityDecelerating);
		p_Writer.Write(MaxThrottleVelocityDecelerating);
		p_Writer.Write(P);
		p_Writer.Write(I);
		p_Writer.Write(D);
		p_Writer.Write(MaxError);
		p_Writer.Write(MaxSumError);
		p_Writer.Write(MaxPTerm);
		p_Writer.Write(MaxITerm);
		p_Writer.Write(MaxYawToApplySprint);
		p_Writer.Write(MaxAngleDiffToApplySprint);
		p_Writer.Write(MaxAngularVelocityToApplySprint);
		p_Writer.Write(MinVelocityToApplySprint);
		p_Writer.Write(LookAheadAimTime);
		p_Writer.Write(MinLookAheadDist);
		p_Writer.Write(SquareBrakeOutput);
		p_Writer.Write(UseSquareVelDiffCurveAcc);
		p_Writer.Write(UseSquareVelDiffCurveDec);
		p_Writer.Write(UseSquareAccDiffCurveAcc);
		p_Writer.Write(UseSquareAccDiffCurveDec);
		p_Writer.Write(UsePIDRegulator);
		p_Writer.Write(IncludeYDifference);
		p_Writer.WriteNullBytes(1);
	}
}

