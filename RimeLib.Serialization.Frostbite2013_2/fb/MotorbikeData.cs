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

namespace fb.Physics;

[ContainerType(16, 240)]
public class MotorbikeData
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public float MaxLeaningRoll { get; set; } = 0.650f;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public float CounterLeanForce { get; set; } = 25.000f;
	
	[ContainerField(0x20), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public Vec3 DampBigJumpImpactCounterForce { get; set; } = new()
	{
		z = 20.000f,
		y = 32.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x30), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public Vec3 WheelieForce { get; set; } = new()
	{
		z = 2400.000f,
		y = -3000.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x40), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public Vec3 WheelieForceBodyOffset { get; set; } = new()
	{
		z = 0.600f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public float StandStillLeanForce { get; set; } = 20.000f;
	
	[ContainerField(0x54), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
	public float LeanForce { get; set; } = 30.000f;
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public float JumpForwardLeanMinAngle { get; set; } = -0.160f;
	
	[ContainerField(0x5c), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
	public float JumpForwardLeanMomentum { get; set; } = 20.000f;
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public float JumpForwardLeanMinNoContactTime { get; set; } = 0.200f;
	
	[ContainerField(0x64), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
	public float LeanForceMaxVel { get; set; } = 70.000f;
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public float KickstandRoll { get; set; } = -0.250f;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public float KickstandLinearDamping { get; set; } = 0.700f;
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public float StandStillRoll { get; set; } = 0.170f;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public float DampBigJumpImpactVelocity { get; set; } = -20.000f;
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public float DampBigJumpMaxSpringForceFraction { get; set; } = 0.600f;
	
	[ContainerField(0x7c), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
	public float DampBigJumpImpactVerticalVelocity { get; set; } = 0.200f;
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public float YawBrakeDampingLerpStartScale { get; set; } = 10.000f;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public float YawBrakeDampingLerpEndScale { get; set; } = 0.100f;
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public float StoppieActivationVelocity { get; set; } = 50.000f;
	
	[ContainerField(0x8c), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
	public float StoppieStartVelocity { get; set; } = 30.000f;
	
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public float StoppieStopVelocity { get; set; } = 7.000f;
	
	[ContainerField(0x94), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
	public float StoppieMomentum { get; set; } = 76.000f;
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public float ShortOffgroundGravityMultiplier { get; set; } = 1.700f;
	
	[ContainerField(0x9c), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
	public float ShortOffgroundPeriod { get; set; } = 0.400f;
	
	[ContainerField(0xa0), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public float WheelieSwitchOffNoContactTime { get; set; } = 0.500f;
	
	[ContainerField(0xa4), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
	public float WheelieMaxNoDownForceContactTime { get; set; } = 0.050f;
	
	[ContainerField(0xa8), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
	public float WheelieMaxNoContactTime { get; set; } = 0.200f;
	
	[ContainerField(0xac), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
	public float WheelieSteeringFactor { get; set; } = 0.400f;
	
	[ContainerField(0xb0), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public float WheelieInertia { get; set; } = 10.000f;
	
	[ContainerField(0xb4), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
	public float WheelieStartVelocity { get; set; } = 15.000f;
	
	[ContainerField(0xb8), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
	public float WheelieMaxVelocityUndamped { get; set; } = 70.000f;
	
	[ContainerField(0xbc), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
	public float WheelieMaxVelocityDampRange { get; set; } = 40.000f;
	
	[ContainerField(0xc0), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
	public float WheelieOutAngularMomentum { get; set; } = 5.000f;
	
	[ContainerField(0xc4), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
	public float WheelieSpringDamping { get; set; } = 0.100f;
	
	[ContainerField(0xc8), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
	public float WheelieSpringKScale { get; set; } = 3.000f;
	
	[ContainerField(0xcc), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
	public float WheelieAngularDamping { get; set; } = 10.000f;
	
	[ContainerField(0xd0), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
	public float WheelieAngularDampingSpeed { get; set; } = 1.500f;
	
	[ContainerField(0xd4), LayoutImmutable, Blittable, JsonProperty(Order = 212)]
	public float WheelieMaxAngle { get; set; } = 0.750f;
	
	[ContainerField(0xd8), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
	public float WheelieMaxVelocity { get; set; } = 200.000f;
	
	[ContainerField(0xdc), LayoutImmutable, Blittable, JsonProperty(Order = 220)]
	public float WheelieVelocityForceScale { get; set; } = 1.000f;
	
	[ContainerField(0xe0), LayoutImmutable, Blittable, JsonProperty(Order = 224)]
	public float WheelieAngularStartMomentum { get; set; } = 400.000f;
	
	[ContainerField(0xe4), LayoutImmutable, Blittable, JsonProperty(Order = 228)]
	public bool DampBigJumpImpact { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(MaxLeaningRoll);
		p_Writer.Write(CounterLeanForce);
		p_Writer.WriteNullBytes(8);
		DampBigJumpImpactCounterForce.Serialize(p_Writer, p_EbxWriter);
		WheelieForce.Serialize(p_Writer, p_EbxWriter);
		WheelieForceBodyOffset.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(StandStillLeanForce);
		p_Writer.Write(LeanForce);
		p_Writer.Write(JumpForwardLeanMinAngle);
		p_Writer.Write(JumpForwardLeanMomentum);
		p_Writer.Write(JumpForwardLeanMinNoContactTime);
		p_Writer.Write(LeanForceMaxVel);
		p_Writer.Write(KickstandRoll);
		p_Writer.Write(KickstandLinearDamping);
		p_Writer.Write(StandStillRoll);
		p_Writer.Write(DampBigJumpImpactVelocity);
		p_Writer.Write(DampBigJumpMaxSpringForceFraction);
		p_Writer.Write(DampBigJumpImpactVerticalVelocity);
		p_Writer.Write(YawBrakeDampingLerpStartScale);
		p_Writer.Write(YawBrakeDampingLerpEndScale);
		p_Writer.Write(StoppieActivationVelocity);
		p_Writer.Write(StoppieStartVelocity);
		p_Writer.Write(StoppieStopVelocity);
		p_Writer.Write(StoppieMomentum);
		p_Writer.Write(ShortOffgroundGravityMultiplier);
		p_Writer.Write(ShortOffgroundPeriod);
		p_Writer.Write(WheelieSwitchOffNoContactTime);
		p_Writer.Write(WheelieMaxNoDownForceContactTime);
		p_Writer.Write(WheelieMaxNoContactTime);
		p_Writer.Write(WheelieSteeringFactor);
		p_Writer.Write(WheelieInertia);
		p_Writer.Write(WheelieStartVelocity);
		p_Writer.Write(WheelieMaxVelocityUndamped);
		p_Writer.Write(WheelieMaxVelocityDampRange);
		p_Writer.Write(WheelieOutAngularMomentum);
		p_Writer.Write(WheelieSpringDamping);
		p_Writer.Write(WheelieSpringKScale);
		p_Writer.Write(WheelieAngularDamping);
		p_Writer.Write(WheelieAngularDampingSpeed);
		p_Writer.Write(WheelieMaxAngle);
		p_Writer.Write(WheelieMaxVelocity);
		p_Writer.Write(WheelieVelocityForceScale);
		p_Writer.Write(WheelieAngularStartMomentum);
		p_Writer.Write(DampBigJumpImpact);
		p_Writer.WriteNullBytes(11);
	}
}

