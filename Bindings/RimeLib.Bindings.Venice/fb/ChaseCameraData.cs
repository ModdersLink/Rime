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
	[ContainerType(16, 272)]
	public class ChaseCameraData : 
		TargetCameraData
	{
		[ContainerField(160), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 TargetOffset { get; set; } = new();

		[ContainerField(176), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 ToWantedPositionScale { get; set; } = new();

		[ContainerField(192), LayoutImmutable, Blittable]
		public float AwayFromTargetForceScale { get; set; }

		[ContainerField(196), LayoutImmutable, Blittable]
		public float TargetRotationOffset { get; set; }

		[ContainerField(200), LayoutImmutable, Blittable]
		public float MaxViewRotationAngleDeg { get; set; }

		[ContainerField(204), LayoutImmutable, Blittable]
		public float WantedAngleDeg { get; set; }

		[ContainerField(208), LayoutImmutable, Blittable]
		public float WantedDistance { get; set; }

		[ContainerField(212), LayoutImmutable, Blittable]
		public float MaxDistance { get; set; }

		[ContainerField(216), LayoutImmutable, Blittable]
		public float SnapDistance { get; set; }

		[ContainerField(220), LayoutImmutable, Blittable]
		public float ForceFieldRadius { get; set; }

		[ContainerField(224), LayoutImmutable, Blittable]
		public float CollisionRadius { get; set; }

		[ContainerField(228), LayoutImmutable, Blittable]
		public float ForceFieldForceScale { get; set; }

		[ContainerField(232), LayoutImmutable, Blittable]
		public float MaxVelocity { get; set; }

		[ContainerField(236), LayoutImmutable, Blittable]
		public float VelocityDrag { get; set; }

		[ContainerField(240), LayoutImmutable, Blittable]
		public float PillExpandSizeSpeedAcceleration { get; set; }

		[ContainerField(244), LayoutImmutable, Blittable]
		public float PillMinimumCollisionRadius { get; set; }

		[ContainerField(248), LayoutImmutable, Blittable]
		public float PillMaximumCollisionRadius { get; set; }

		[ContainerField(252), LayoutImmutable, Blittable]
		public float PillMinimumCollisionLength { get; set; }

		[ContainerField(256), LayoutImmutable, Blittable]
		public float LookDistanceScale { get; set; }

		[ContainerField(260), LayoutImmutable, Blittable]
		public float LookDistanceInFrontOfTarget { get; set; }

		[ContainerField(264), LayoutImmutable, Blittable]
		public uint UpdateRate { get; set; }

		[ContainerField(268), LayoutImmutable, Blittable]
		public bool KeepTargetPitch { get; set; }

		[ContainerField(269), LayoutImmutable, Blittable]
		public bool InheritTargetVelocity { get; set; }

		[ContainerField(270), LayoutImmutable, Blittable]
		public bool ShouldRollWithTarget { get; set; }

		[ContainerField(271), LayoutImmutable, Blittable]
		public bool HasCollision { get; set; }

		public static void Deserialize(ChaseCameraData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec3.Deserialize(p_Instance.TargetOffset, p_Reader, p_Parser);
			fb.Vec3.Deserialize(p_Instance.ToWantedPositionScale, p_Reader, p_Parser);
			p_Instance.AwayFromTargetForceScale = p_Reader.ReadSingle();
			p_Instance.TargetRotationOffset = p_Reader.ReadSingle();
			p_Instance.MaxViewRotationAngleDeg = p_Reader.ReadSingle();
			p_Instance.WantedAngleDeg = p_Reader.ReadSingle();
			p_Instance.WantedDistance = p_Reader.ReadSingle();
			p_Instance.MaxDistance = p_Reader.ReadSingle();
			p_Instance.SnapDistance = p_Reader.ReadSingle();
			p_Instance.ForceFieldRadius = p_Reader.ReadSingle();
			p_Instance.CollisionRadius = p_Reader.ReadSingle();
			p_Instance.ForceFieldForceScale = p_Reader.ReadSingle();
			p_Instance.MaxVelocity = p_Reader.ReadSingle();
			p_Instance.VelocityDrag = p_Reader.ReadSingle();
			p_Instance.PillExpandSizeSpeedAcceleration = p_Reader.ReadSingle();
			p_Instance.PillMinimumCollisionRadius = p_Reader.ReadSingle();
			p_Instance.PillMaximumCollisionRadius = p_Reader.ReadSingle();
			p_Instance.PillMinimumCollisionLength = p_Reader.ReadSingle();
			p_Instance.LookDistanceScale = p_Reader.ReadSingle();
			p_Instance.LookDistanceInFrontOfTarget = p_Reader.ReadSingle();
			p_Instance.UpdateRate = p_Reader.ReadUInt32();
			p_Instance.KeepTargetPitch = p_Reader.ReadBool();
			p_Instance.InheritTargetVelocity = p_Reader.ReadBool();
			p_Instance.ShouldRollWithTarget = p_Reader.ReadBool();
			p_Instance.HasCollision = p_Reader.ReadBool();
		}

	}
}
