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
	[ContainerType(16, 224)]
	public partial class MotorbikeData :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private Vec3 _WheelieForceBodyOffset = new();

		[ObservableProperty]
		[property: ContainerField(32), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private Vec3 _WheelieForce = new();

		[ObservableProperty]
		[property: ContainerField(48), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private Vec3 _DampBigJumpImpactCounterForce = new();

		[ObservableProperty]
		[property: ContainerField(64), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		private Vec3 _ProximityExtScale = new();

		[ObservableProperty]
		[property: ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		private float _JumpForwardLeanMinAngle;

		[ObservableProperty]
		[property: ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		private float _JumpForwardLeanMomentum;

		[ObservableProperty]
		[property: ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		private float _KickstandRoll;

		[ObservableProperty]
		[property: ContainerField(92), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
		private float _KickstandLinearDamping;

		[ObservableProperty]
		[property: ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private float _LeanForceMaxVel;

		[ObservableProperty]
		[property: ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		private float _CounterLeanForce;

		[ObservableProperty]
		[property: ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		private float _StandStillRoll;

		[ObservableProperty]
		[property: ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		private float _DampBigJumpImpactVelocity;

		[ObservableProperty]
		[property: ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		private float _YawBrakeDampingLerpStartScale;

		[ObservableProperty]
		[property: ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		private float _YawBrakeDampingLerpEndScale;

		[ObservableProperty]
		[property: ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		private float _StoppieActivationVelocity;

		[ObservableProperty]
		[property: ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		private float _StoppieStartVelocity;

		[ObservableProperty]
		[property: ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		private float _LeanForce;

		[ObservableProperty]
		[property: ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		private float _StoppieMomentum;

		[ObservableProperty]
		[property: ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		private float _ShortOffgroundGravityMultiplier;

		[ObservableProperty]
		[property: ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		private float _MaxLeaningRoll;

		[ObservableProperty]
		[property: ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		private float _StoppieStopVelocity;

		[ObservableProperty]
		[property: ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		private float _ProximityHeightTranslation;

		[ObservableProperty]
		[property: ContainerField(152), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		private float _WheelieMaxNoDownForceContactTime;

		[ObservableProperty]
		[property: ContainerField(156), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
		private float _WheelieMaxNoContactTime;

		[ObservableProperty]
		[property: ContainerField(160), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		private float _WheelieSteeringFactor;

		[ObservableProperty]
		[property: ContainerField(164), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
		private float _WheelieInertia;

		[ObservableProperty]
		[property: ContainerField(168), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
		private float _WheelieStartVelocity;

		[ObservableProperty]
		[property: ContainerField(172), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
		private float _WheelieMaxVelocityUndamped;

		[ObservableProperty]
		[property: ContainerField(176), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		private float _WheelieMaxVelocityDampRange;

		[ObservableProperty]
		[property: ContainerField(180), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
		private float _WheelieOutAngularMomentum;

		[ObservableProperty]
		[property: ContainerField(184), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
		private float _WheelieSpringDamping;

		[ObservableProperty]
		[property: ContainerField(188), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
		private float _WheelieAngularDamping;

		[ObservableProperty]
		[property: ContainerField(192), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
		private float _WheelieAngularDampingSpeed;

		[ObservableProperty]
		[property: ContainerField(196), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
		private float _ShortOffgroundPeriod;

		[ObservableProperty]
		[property: ContainerField(200), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
		private float _WheelieMaxAngle;

		[ObservableProperty]
		[property: ContainerField(204), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
		private float _WheelieAngularStartMomentum;

		[ObservableProperty]
		[property: ContainerField(208), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
		private float _WheelieMaxVelocity;

		[ObservableProperty]
		[property: ContainerField(212), LayoutImmutable, Blittable, JsonProperty(Order = 212)]
		private float _WheelieVelocityForceScale;

		[ObservableProperty]
		[property: ContainerField(216), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
		private bool _DampBigJumpImpact;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(16);
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
