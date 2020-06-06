///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class ChaseCameraData : 
		TargetCameraData
	{
		[ContainerField(160), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 TargetOffset { get; set; } = new Vec3(); // 0xA0 (160)
		
		[ContainerField(176), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 ToWantedPositionScale { get; set; } = new Vec3(); // 0xB0 (176)
		
		[ContainerField(192), LayoutImmutable, Blittable]
		public float AwayFromTargetForceScale { get; set; } // 0xC0 (192)
		
		[ContainerField(196), LayoutImmutable, Blittable]
		public float TargetRotationOffset { get; set; } // 0xC4 (196)
		
		[ContainerField(200), LayoutImmutable, Blittable]
		public float MaxViewRotationAngleDeg { get; set; } // 0xC8 (200)
		
		[ContainerField(204), LayoutImmutable, Blittable]
		public float WantedAngleDeg { get; set; } // 0xCC (204)
		
		[ContainerField(208), LayoutImmutable, Blittable]
		public float WantedDistance { get; set; } // 0xD0 (208)
		
		[ContainerField(212), LayoutImmutable, Blittable]
		public float MaxDistance { get; set; } // 0xD4 (212)
		
		[ContainerField(216), LayoutImmutable, Blittable]
		public float SnapDistance { get; set; } // 0xD8 (216)
		
		[ContainerField(220), LayoutImmutable, Blittable]
		public float ForceFieldRadius { get; set; } // 0xDC (220)
		
		[ContainerField(224), LayoutImmutable, Blittable]
		public float CollisionRadius { get; set; } // 0xE0 (224)
		
		[ContainerField(228), LayoutImmutable, Blittable]
		public float ForceFieldForceScale { get; set; } // 0xE4 (228)
		
		[ContainerField(232), LayoutImmutable, Blittable]
		public float MaxVelocity { get; set; } // 0xE8 (232)
		
		[ContainerField(236), LayoutImmutable, Blittable]
		public float VelocityDrag { get; set; } // 0xEC (236)
		
		[ContainerField(240), LayoutImmutable, Blittable]
		public float PillExpandSizeSpeedAcceleration { get; set; } // 0xF0 (240)
		
		[ContainerField(244), LayoutImmutable, Blittable]
		public float PillMinimumCollisionRadius { get; set; } // 0xF4 (244)
		
		[ContainerField(248), LayoutImmutable, Blittable]
		public float PillMaximumCollisionRadius { get; set; } // 0xF8 (248)
		
		[ContainerField(252), LayoutImmutable, Blittable]
		public float PillMinimumCollisionLength { get; set; } // 0xFC (252)
		
		[ContainerField(256), LayoutImmutable, Blittable]
		public float LookDistanceScale { get; set; } // 0x100 (256)
		
		[ContainerField(260), LayoutImmutable, Blittable]
		public float LookDistanceInFrontOfTarget { get; set; } // 0x104 (260)
		
		[ContainerField(264), LayoutImmutable, Blittable]
		public uint UpdateRate { get; set; } // 0x108 (264)
		
		[ContainerField(268), LayoutImmutable, Blittable]
		public bool KeepTargetPitch { get; set; } // 0x10C (268)
		
		[ContainerField(269), LayoutImmutable, Blittable]
		public bool InheritTargetVelocity { get; set; } // 0x10D (269)
		
		[ContainerField(270), LayoutImmutable, Blittable]
		public bool ShouldRollWithTarget { get; set; } // 0x10E (270)
		
		[ContainerField(271), LayoutImmutable, Blittable]
		public bool HasCollision { get; set; } // 0x10F (271)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1634518457:
					TargetOffset = (Vec3) p_Value;
					break;

				case 2553064018:
					ToWantedPositionScale = (Vec3) p_Value;
					break;

				case 2623914665:
					AwayFromTargetForceScale = (float) p_Value;
					break;

				case 1618502637:
					TargetRotationOffset = (float) p_Value;
					break;

				case 389369231:
					MaxViewRotationAngleDeg = (float) p_Value;
					break;

				case 3363627311:
					WantedAngleDeg = (float) p_Value;
					break;

				case 543265451:
					WantedDistance = (float) p_Value;
					break;

				case 3520454034:
					MaxDistance = (float) p_Value;
					break;

				case 2841439402:
					SnapDistance = (float) p_Value;
					break;

				case 1763697730:
					ForceFieldRadius = (float) p_Value;
					break;

				case 1874505603:
					CollisionRadius = (float) p_Value;
					break;

				case 3317981151:
					ForceFieldForceScale = (float) p_Value;
					break;

				case 81127366:
					MaxVelocity = (float) p_Value;
					break;

				case 58335362:
					VelocityDrag = (float) p_Value;
					break;

				case 2985104634:
					PillExpandSizeSpeedAcceleration = (float) p_Value;
					break;

				case 804419372:
					PillMinimumCollisionRadius = (float) p_Value;
					break;

				case 3536568050:
					PillMaximumCollisionRadius = (float) p_Value;
					break;

				case 1361574600:
					PillMinimumCollisionLength = (float) p_Value;
					break;

				case 4112376025:
					LookDistanceScale = (float) p_Value;
					break;

				case 4045244511:
					LookDistanceInFrontOfTarget = (float) p_Value;
					break;

				case 2270996982:
					UpdateRate = (uint) p_Value;
					break;

				case 3248397385:
					KeepTargetPitch = (bool) p_Value;
					break;

				case 219688038:
					InheritTargetVelocity = (bool) p_Value;
					break;

				case 2421688066:
					ShouldRollWithTarget = (bool) p_Value;
					break;

				case 2369733505:
					HasCollision = (bool) p_Value;
					break;

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1634518457:
					return TargetOffset;

				case 2553064018:
					return ToWantedPositionScale;

				case 2623914665:
					return AwayFromTargetForceScale;

				case 1618502637:
					return TargetRotationOffset;

				case 389369231:
					return MaxViewRotationAngleDeg;

				case 3363627311:
					return WantedAngleDeg;

				case 543265451:
					return WantedDistance;

				case 3520454034:
					return MaxDistance;

				case 2841439402:
					return SnapDistance;

				case 1763697730:
					return ForceFieldRadius;

				case 1874505603:
					return CollisionRadius;

				case 3317981151:
					return ForceFieldForceScale;

				case 81127366:
					return MaxVelocity;

				case 58335362:
					return VelocityDrag;

				case 2985104634:
					return PillExpandSizeSpeedAcceleration;

				case 804419372:
					return PillMinimumCollisionRadius;

				case 3536568050:
					return PillMaximumCollisionRadius;

				case 1361574600:
					return PillMinimumCollisionLength;

				case 4112376025:
					return LookDistanceScale;

				case 4045244511:
					return LookDistanceInFrontOfTarget;

				case 2270996982:
					return UpdateRate;

				case 3248397385:
					return KeepTargetPitch;

				case 219688038:
					return InheritTargetVelocity;

				case 2421688066:
					return ShouldRollWithTarget;

				case 2369733505:
					return HasCollision;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1634518457:
					return typeof(ChaseCameraData).GetProperty(nameof(TargetOffset));

				case 2553064018:
					return typeof(ChaseCameraData).GetProperty(nameof(ToWantedPositionScale));

				case 2623914665:
					return typeof(ChaseCameraData).GetProperty(nameof(AwayFromTargetForceScale));

				case 1618502637:
					return typeof(ChaseCameraData).GetProperty(nameof(TargetRotationOffset));

				case 389369231:
					return typeof(ChaseCameraData).GetProperty(nameof(MaxViewRotationAngleDeg));

				case 3363627311:
					return typeof(ChaseCameraData).GetProperty(nameof(WantedAngleDeg));

				case 543265451:
					return typeof(ChaseCameraData).GetProperty(nameof(WantedDistance));

				case 3520454034:
					return typeof(ChaseCameraData).GetProperty(nameof(MaxDistance));

				case 2841439402:
					return typeof(ChaseCameraData).GetProperty(nameof(SnapDistance));

				case 1763697730:
					return typeof(ChaseCameraData).GetProperty(nameof(ForceFieldRadius));

				case 1874505603:
					return typeof(ChaseCameraData).GetProperty(nameof(CollisionRadius));

				case 3317981151:
					return typeof(ChaseCameraData).GetProperty(nameof(ForceFieldForceScale));

				case 81127366:
					return typeof(ChaseCameraData).GetProperty(nameof(MaxVelocity));

				case 58335362:
					return typeof(ChaseCameraData).GetProperty(nameof(VelocityDrag));

				case 2985104634:
					return typeof(ChaseCameraData).GetProperty(nameof(PillExpandSizeSpeedAcceleration));

				case 804419372:
					return typeof(ChaseCameraData).GetProperty(nameof(PillMinimumCollisionRadius));

				case 3536568050:
					return typeof(ChaseCameraData).GetProperty(nameof(PillMaximumCollisionRadius));

				case 1361574600:
					return typeof(ChaseCameraData).GetProperty(nameof(PillMinimumCollisionLength));

				case 4112376025:
					return typeof(ChaseCameraData).GetProperty(nameof(LookDistanceScale));

				case 4045244511:
					return typeof(ChaseCameraData).GetProperty(nameof(LookDistanceInFrontOfTarget));

				case 2270996982:
					return typeof(ChaseCameraData).GetProperty(nameof(UpdateRate));

				case 3248397385:
					return typeof(ChaseCameraData).GetProperty(nameof(KeepTargetPitch));

				case 219688038:
					return typeof(ChaseCameraData).GetProperty(nameof(InheritTargetVelocity));

				case 2421688066:
					return typeof(ChaseCameraData).GetProperty(nameof(ShouldRollWithTarget));

				case 2369733505:
					return typeof(ChaseCameraData).GetProperty(nameof(HasCollision));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
