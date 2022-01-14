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
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(16, 272)]
	public class ChaseCameraData :
		TargetCameraData
	{
		[ContainerField(160), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		public Vec3 TargetOffset { get; set; } = new();

		[ContainerField(176), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		public Vec3 ToWantedPositionScale { get; set; } = new();

		[ContainerField(192), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
		public float AwayFromTargetForceScale { get; set; }

		[ContainerField(196), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
		public float TargetRotationOffset { get; set; }

		[ContainerField(200), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
		public float MaxViewRotationAngleDeg { get; set; }

		[ContainerField(204), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
		public float WantedAngleDeg { get; set; }

		[ContainerField(208), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
		public float WantedDistance { get; set; }

		[ContainerField(212), LayoutImmutable, Blittable, JsonProperty(Order = 212)]
		public float MaxDistance { get; set; }

		[ContainerField(216), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
		public float SnapDistance { get; set; }

		[ContainerField(220), LayoutImmutable, Blittable, JsonProperty(Order = 220)]
		public float ForceFieldRadius { get; set; }

		[ContainerField(224), LayoutImmutable, Blittable, JsonProperty(Order = 224)]
		public float CollisionRadius { get; set; }

		[ContainerField(228), LayoutImmutable, Blittable, JsonProperty(Order = 228)]
		public float ForceFieldForceScale { get; set; }

		[ContainerField(232), LayoutImmutable, Blittable, JsonProperty(Order = 232)]
		public float MaxVelocity { get; set; }

		[ContainerField(236), LayoutImmutable, Blittable, JsonProperty(Order = 236)]
		public float VelocityDrag { get; set; }

		[ContainerField(240), LayoutImmutable, Blittable, JsonProperty(Order = 240)]
		public float PillExpandSizeSpeedAcceleration { get; set; }

		[ContainerField(244), LayoutImmutable, Blittable, JsonProperty(Order = 244)]
		public float PillMinimumCollisionRadius { get; set; }

		[ContainerField(248), LayoutImmutable, Blittable, JsonProperty(Order = 248)]
		public float PillMaximumCollisionRadius { get; set; }

		[ContainerField(252), LayoutImmutable, Blittable, JsonProperty(Order = 252)]
		public float PillMinimumCollisionLength { get; set; }

		[ContainerField(256), LayoutImmutable, Blittable, JsonProperty(Order = 256)]
		public float LookDistanceScale { get; set; }

		[ContainerField(260), LayoutImmutable, Blittable, JsonProperty(Order = 260)]
		public float LookDistanceInFrontOfTarget { get; set; }

		[ContainerField(264), LayoutImmutable, Blittable, JsonProperty(Order = 264)]
		public uint UpdateRate { get; set; }

		[ContainerField(268), LayoutImmutable, Blittable, JsonProperty(Order = 268)]
		public bool KeepTargetPitch { get; set; }

		[ContainerField(269), LayoutImmutable, Blittable, JsonProperty(Order = 269)]
		public bool InheritTargetVelocity { get; set; }

		[ContainerField(270), LayoutImmutable, Blittable, JsonProperty(Order = 270)]
		public bool ShouldRollWithTarget { get; set; }

		[ContainerField(271), LayoutImmutable, Blittable, JsonProperty(Order = 271)]
		public bool HasCollision { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			TargetOffset.Serialize(p_Writer, p_EbxWriter);
			ToWantedPositionScale.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(AwayFromTargetForceScale);
			p_Writer.Write(TargetRotationOffset);
			p_Writer.Write(MaxViewRotationAngleDeg);
			p_Writer.Write(WantedAngleDeg);
			p_Writer.Write(WantedDistance);
			p_Writer.Write(MaxDistance);
			p_Writer.Write(SnapDistance);
			p_Writer.Write(ForceFieldRadius);
			p_Writer.Write(CollisionRadius);
			p_Writer.Write(ForceFieldForceScale);
			p_Writer.Write(MaxVelocity);
			p_Writer.Write(VelocityDrag);
			p_Writer.Write(PillExpandSizeSpeedAcceleration);
			p_Writer.Write(PillMinimumCollisionRadius);
			p_Writer.Write(PillMaximumCollisionRadius);
			p_Writer.Write(PillMinimumCollisionLength);
			p_Writer.Write(LookDistanceScale);
			p_Writer.Write(LookDistanceInFrontOfTarget);
			p_Writer.Write(UpdateRate);
			p_Writer.Write(KeepTargetPitch);
			p_Writer.Write(InheritTargetVelocity);
			p_Writer.Write(ShouldRollWithTarget);
			p_Writer.Write(HasCollision);
		}
	}
}
