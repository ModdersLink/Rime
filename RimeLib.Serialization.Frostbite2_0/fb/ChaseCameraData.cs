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
	[ContainerType(16, 272)]
	public partial class ChaseCameraData :
		TargetCameraData
	{
		[ObservableProperty]
		[property: ContainerField(160), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		private Vec3 _TargetOffset = new();

		[ObservableProperty]
		[property: ContainerField(176), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		private Vec3 _ToWantedPositionScale = new();

		[ObservableProperty]
		[property: ContainerField(192), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
		private float _AwayFromTargetForceScale;

		[ObservableProperty]
		[property: ContainerField(196), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
		private float _TargetRotationOffset;

		[ObservableProperty]
		[property: ContainerField(200), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
		private float _MaxViewRotationAngleDeg;

		[ObservableProperty]
		[property: ContainerField(204), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
		private float _WantedAngleDeg;

		[ObservableProperty]
		[property: ContainerField(208), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
		private float _WantedDistance;

		[ObservableProperty]
		[property: ContainerField(212), LayoutImmutable, Blittable, JsonProperty(Order = 212)]
		private float _MaxDistance;

		[ObservableProperty]
		[property: ContainerField(216), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
		private float _SnapDistance;

		[ObservableProperty]
		[property: ContainerField(220), LayoutImmutable, Blittable, JsonProperty(Order = 220)]
		private float _ForceFieldRadius;

		[ObservableProperty]
		[property: ContainerField(224), LayoutImmutable, Blittable, JsonProperty(Order = 224)]
		private float _CollisionRadius;

		[ObservableProperty]
		[property: ContainerField(228), LayoutImmutable, Blittable, JsonProperty(Order = 228)]
		private float _ForceFieldForceScale;

		[ObservableProperty]
		[property: ContainerField(232), LayoutImmutable, Blittable, JsonProperty(Order = 232)]
		private float _MaxVelocity;

		[ObservableProperty]
		[property: ContainerField(236), LayoutImmutable, Blittable, JsonProperty(Order = 236)]
		private float _VelocityDrag;

		[ObservableProperty]
		[property: ContainerField(240), LayoutImmutable, Blittable, JsonProperty(Order = 240)]
		private float _PillExpandSizeSpeedAcceleration;

		[ObservableProperty]
		[property: ContainerField(244), LayoutImmutable, Blittable, JsonProperty(Order = 244)]
		private float _PillMinimumCollisionRadius;

		[ObservableProperty]
		[property: ContainerField(248), LayoutImmutable, Blittable, JsonProperty(Order = 248)]
		private float _PillMaximumCollisionRadius;

		[ObservableProperty]
		[property: ContainerField(252), LayoutImmutable, Blittable, JsonProperty(Order = 252)]
		private float _PillMinimumCollisionLength;

		[ObservableProperty]
		[property: ContainerField(256), LayoutImmutable, Blittable, JsonProperty(Order = 256)]
		private float _LookDistanceScale;

		[ObservableProperty]
		[property: ContainerField(260), LayoutImmutable, Blittable, JsonProperty(Order = 260)]
		private float _LookDistanceInFrontOfTarget;

		[ObservableProperty]
		[property: ContainerField(264), LayoutImmutable, Blittable, JsonProperty(Order = 264)]
		private uint _UpdateRate;

		[ObservableProperty]
		[property: ContainerField(268), LayoutImmutable, Blittable, JsonProperty(Order = 268)]
		private bool _KeepTargetPitch;

		[ObservableProperty]
		[property: ContainerField(269), LayoutImmutable, Blittable, JsonProperty(Order = 269)]
		private bool _InheritTargetVelocity;

		[ObservableProperty]
		[property: ContainerField(270), LayoutImmutable, Blittable, JsonProperty(Order = 270)]
		private bool _ShouldRollWithTarget;

		[ObservableProperty]
		[property: ContainerField(271), LayoutImmutable, Blittable, JsonProperty(Order = 271)]
		private bool _HasCollision;

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
