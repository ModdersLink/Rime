///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(16, 224)]
	public class MotorbikeData : 
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 WheelieForceBodyOffset { get; set; } = new();

		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 WheelieForce { get; set; } = new();

		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 DampBigJumpImpactCounterForce { get; set; } = new();

		[ContainerField(64), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 ProximityExtScale { get; set; } = new();

		[ContainerField(80), LayoutImmutable, Blittable]
		public float JumpForwardLeanMinAngle { get; set; }

		[ContainerField(84), LayoutImmutable, Blittable]
		public float JumpForwardLeanMomentum { get; set; }

		[ContainerField(88), LayoutImmutable, Blittable]
		public float KickstandRoll { get; set; }

		[ContainerField(92), LayoutImmutable, Blittable]
		public float KickstandLinearDamping { get; set; }

		[ContainerField(96), LayoutImmutable, Blittable]
		public float LeanForceMaxVel { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable]
		public float CounterLeanForce { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable]
		public float StandStillRoll { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable]
		public float DampBigJumpImpactVelocity { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable]
		public float YawBrakeDampingLerpStartScale { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable]
		public float YawBrakeDampingLerpEndScale { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable]
		public float StoppieActivationVelocity { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable]
		public float StoppieStartVelocity { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable]
		public float LeanForce { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable]
		public float StoppieMomentum { get; set; }

		[ContainerField(136), LayoutImmutable, Blittable]
		public float ShortOffgroundGravityMultiplier { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable]
		public float MaxLeaningRoll { get; set; }

		[ContainerField(144), LayoutImmutable, Blittable]
		public float StoppieStopVelocity { get; set; }

		[ContainerField(148), LayoutImmutable, Blittable]
		public float ProximityHeightTranslation { get; set; }

		[ContainerField(152), LayoutImmutable, Blittable]
		public float WheelieMaxNoDownForceContactTime { get; set; }

		[ContainerField(156), LayoutImmutable, Blittable]
		public float WheelieMaxNoContactTime { get; set; }

		[ContainerField(160), LayoutImmutable, Blittable]
		public float WheelieSteeringFactor { get; set; }

		[ContainerField(164), LayoutImmutable, Blittable]
		public float WheelieInertia { get; set; }

		[ContainerField(168), LayoutImmutable, Blittable]
		public float WheelieStartVelocity { get; set; }

		[ContainerField(172), LayoutImmutable, Blittable]
		public float WheelieMaxVelocityUndamped { get; set; }

		[ContainerField(176), LayoutImmutable, Blittable]
		public float WheelieMaxVelocityDampRange { get; set; }

		[ContainerField(180), LayoutImmutable, Blittable]
		public float WheelieOutAngularMomentum { get; set; }

		[ContainerField(184), LayoutImmutable, Blittable]
		public float WheelieSpringDamping { get; set; }

		[ContainerField(188), LayoutImmutable, Blittable]
		public float WheelieAngularDamping { get; set; }

		[ContainerField(192), LayoutImmutable, Blittable]
		public float WheelieAngularDampingSpeed { get; set; }

		[ContainerField(196), LayoutImmutable, Blittable]
		public float ShortOffgroundPeriod { get; set; }

		[ContainerField(200), LayoutImmutable, Blittable]
		public float WheelieMaxAngle { get; set; }

		[ContainerField(204), LayoutImmutable, Blittable]
		public float WheelieAngularStartMomentum { get; set; }

		[ContainerField(208), LayoutImmutable, Blittable]
		public float WheelieMaxVelocity { get; set; }

		[ContainerField(212), LayoutImmutable, Blittable]
		public float WheelieVelocityForceScale { get; set; }

		[ContainerField(216), LayoutImmutable, Blittable]
		public bool DampBigJumpImpact { get; set; }

		public static void Deserialize(MotorbikeData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Reader.Seek(8, SeekOrigin.Current);
			fb.Vec3.Deserialize(p_Instance.WheelieForceBodyOffset, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			fb.Vec3.Deserialize(p_Instance.WheelieForce, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			fb.Vec3.Deserialize(p_Instance.DampBigJumpImpactCounterForce, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			fb.Vec3.Deserialize(p_Instance.ProximityExtScale, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.JumpForwardLeanMinAngle = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.JumpForwardLeanMomentum = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.KickstandRoll = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.KickstandLinearDamping = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.LeanForceMaxVel = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.CounterLeanForce = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.StandStillRoll = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.DampBigJumpImpactVelocity = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.YawBrakeDampingLerpStartScale = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.YawBrakeDampingLerpEndScale = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.StoppieActivationVelocity = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.StoppieStartVelocity = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.LeanForce = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.StoppieMomentum = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.ShortOffgroundGravityMultiplier = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.MaxLeaningRoll = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.StoppieStopVelocity = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.ProximityHeightTranslation = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.WheelieMaxNoDownForceContactTime = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.WheelieMaxNoContactTime = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.WheelieSteeringFactor = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.WheelieInertia = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.WheelieStartVelocity = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.WheelieMaxVelocityUndamped = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.WheelieMaxVelocityDampRange = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.WheelieOutAngularMomentum = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.WheelieSpringDamping = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.WheelieAngularDamping = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.WheelieAngularDampingSpeed = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.ShortOffgroundPeriod = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.WheelieMaxAngle = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.WheelieAngularStartMomentum = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.WheelieMaxVelocity = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.WheelieVelocityForceScale = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.DampBigJumpImpact = p_Reader.ReadBool();
			p_Reader.Seek(15, SeekOrigin.Current);
		}

	}
}
