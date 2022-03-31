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
	[ContainerType(16, 224)]
	public class MotorbikeData :
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public Vec3 WheelieForceBodyOffset { get; set; } = new();

		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public Vec3 WheelieForce { get; set; } = new();

		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public Vec3 DampBigJumpImpactCounterForce { get; set; } = new();

		[ContainerField(64), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		public Vec3 ProximityExtScale { get; set; } = new();

		[ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		public float JumpForwardLeanMinAngle { get; set; }

		[ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		public float JumpForwardLeanMomentum { get; set; }

		[ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		public float KickstandRoll { get; set; }

		[ContainerField(92), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
		public float KickstandLinearDamping { get; set; }

		[ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public float LeanForceMaxVel { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		public float CounterLeanForce { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		public float StandStillRoll { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		public float DampBigJumpImpactVelocity { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		public float YawBrakeDampingLerpStartScale { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		public float YawBrakeDampingLerpEndScale { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		public float StoppieActivationVelocity { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		public float StoppieStartVelocity { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		public float LeanForce { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		public float StoppieMomentum { get; set; }

		[ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		public float ShortOffgroundGravityMultiplier { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		public float MaxLeaningRoll { get; set; }

		[ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		public float StoppieStopVelocity { get; set; }

		[ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		public float ProximityHeightTranslation { get; set; }

		[ContainerField(152), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		public float WheelieMaxNoDownForceContactTime { get; set; }

		[ContainerField(156), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
		public float WheelieMaxNoContactTime { get; set; }

		[ContainerField(160), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		public float WheelieSteeringFactor { get; set; }

		[ContainerField(164), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
		public float WheelieInertia { get; set; }

		[ContainerField(168), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
		public float WheelieStartVelocity { get; set; }

		[ContainerField(172), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
		public float WheelieMaxVelocityUndamped { get; set; }

		[ContainerField(176), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		public float WheelieMaxVelocityDampRange { get; set; }

		[ContainerField(180), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
		public float WheelieOutAngularMomentum { get; set; }

		[ContainerField(184), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
		public float WheelieSpringDamping { get; set; }

		[ContainerField(188), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
		public float WheelieAngularDamping { get; set; }

		[ContainerField(192), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
		public float WheelieAngularDampingSpeed { get; set; }

		[ContainerField(196), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
		public float ShortOffgroundPeriod { get; set; }

		[ContainerField(200), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
		public float WheelieMaxAngle { get; set; }

		[ContainerField(204), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
		public float WheelieAngularStartMomentum { get; set; }

		[ContainerField(208), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
		public float WheelieMaxVelocity { get; set; }

		[ContainerField(212), LayoutImmutable, Blittable, JsonProperty(Order = 212)]
		public float WheelieVelocityForceScale { get; set; }

		[ContainerField(216), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
		public bool DampBigJumpImpact { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			WheelieForceBodyOffset.Serialize(p_Writer, p_EbxWriter);
			WheelieForce.Serialize(p_Writer, p_EbxWriter);
			DampBigJumpImpactCounterForce.Serialize(p_Writer, p_EbxWriter);
			ProximityExtScale.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(JumpForwardLeanMinAngle);
			p_Writer.Write(JumpForwardLeanMomentum);
			p_Writer.Write(KickstandRoll);
			p_Writer.Write(KickstandLinearDamping);
			p_Writer.Write(LeanForceMaxVel);
			p_Writer.Write(CounterLeanForce);
			p_Writer.Write(StandStillRoll);
			p_Writer.Write(DampBigJumpImpactVelocity);
			p_Writer.Write(YawBrakeDampingLerpStartScale);
			p_Writer.Write(YawBrakeDampingLerpEndScale);
			p_Writer.Write(StoppieActivationVelocity);
			p_Writer.Write(StoppieStartVelocity);
			p_Writer.Write(LeanForce);
			p_Writer.Write(StoppieMomentum);
			p_Writer.Write(ShortOffgroundGravityMultiplier);
			p_Writer.Write(MaxLeaningRoll);
			p_Writer.Write(StoppieStopVelocity);
			p_Writer.Write(ProximityHeightTranslation);
			p_Writer.Write(WheelieMaxNoDownForceContactTime);
			p_Writer.Write(WheelieMaxNoContactTime);
			p_Writer.Write(WheelieSteeringFactor);
			p_Writer.Write(WheelieInertia);
			p_Writer.Write(WheelieStartVelocity);
			p_Writer.Write(WheelieMaxVelocityUndamped);
			p_Writer.Write(WheelieMaxVelocityDampRange);
			p_Writer.Write(WheelieOutAngularMomentum);
			p_Writer.Write(WheelieSpringDamping);
			p_Writer.Write(WheelieAngularDamping);
			p_Writer.Write(WheelieAngularDampingSpeed);
			p_Writer.Write(ShortOffgroundPeriod);
			p_Writer.Write(WheelieMaxAngle);
			p_Writer.Write(WheelieAngularStartMomentum);
			p_Writer.Write(WheelieMaxVelocity);
			p_Writer.Write(WheelieVelocityForceScale);
			p_Writer.Write(DampBigJumpImpact);
			p_Writer.WriteNullBytes(7);
		}
	}
}
