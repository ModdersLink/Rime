///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(16), MemberInfoFlag(53), ContainerSize(272), ContainerClass]
	public class ChaseCameraData : 
		TargetCameraData
	{
		protected Vec3 m_TargetOffset = new Vec3();
		[ContainerField(160), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(1634518457)]
		public Vec3 TargetOffset { get { return m_TargetOffset; } set { if (OnPropertyChanging("ChaseCameraData." + nameof(TargetOffset), this, m_TargetOffset, value)) m_TargetOffset = value; } } // 0xA0 (160)
		
		protected Vec3 m_ToWantedPositionScale = new Vec3();
		[ContainerField(176), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(2553064018)]
		public Vec3 ToWantedPositionScale { get { return m_ToWantedPositionScale; } set { if (OnPropertyChanging("ChaseCameraData." + nameof(ToWantedPositionScale), this, m_ToWantedPositionScale, value)) m_ToWantedPositionScale = value; } } // 0xB0 (176)
		
		protected float m_AwayFromTargetForceScale = new float();
		[ContainerField(192), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2623914665)]
		public float AwayFromTargetForceScale { get { return m_AwayFromTargetForceScale; } set { if (OnPropertyChanging("ChaseCameraData." + nameof(AwayFromTargetForceScale), this, m_AwayFromTargetForceScale, value)) m_AwayFromTargetForceScale = value; } } // 0xC0 (192)
		
		protected float m_TargetRotationOffset = new float();
		[ContainerField(196), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1618502637)]
		public float TargetRotationOffset { get { return m_TargetRotationOffset; } set { if (OnPropertyChanging("ChaseCameraData." + nameof(TargetRotationOffset), this, m_TargetRotationOffset, value)) m_TargetRotationOffset = value; } } // 0xC4 (196)
		
		protected float m_MaxViewRotationAngleDeg = new float();
		[ContainerField(200), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(389369231)]
		public float MaxViewRotationAngleDeg { get { return m_MaxViewRotationAngleDeg; } set { if (OnPropertyChanging("ChaseCameraData." + nameof(MaxViewRotationAngleDeg), this, m_MaxViewRotationAngleDeg, value)) m_MaxViewRotationAngleDeg = value; } } // 0xC8 (200)
		
		protected float m_WantedAngleDeg = new float();
		[ContainerField(204), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3363627311)]
		public float WantedAngleDeg { get { return m_WantedAngleDeg; } set { if (OnPropertyChanging("ChaseCameraData." + nameof(WantedAngleDeg), this, m_WantedAngleDeg, value)) m_WantedAngleDeg = value; } } // 0xCC (204)
		
		protected float m_WantedDistance = new float();
		[ContainerField(208), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(543265451)]
		public float WantedDistance { get { return m_WantedDistance; } set { if (OnPropertyChanging("ChaseCameraData." + nameof(WantedDistance), this, m_WantedDistance, value)) m_WantedDistance = value; } } // 0xD0 (208)
		
		protected float m_MaxDistance = new float();
		[ContainerField(212), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3520454034)]
		public float MaxDistance { get { return m_MaxDistance; } set { if (OnPropertyChanging("ChaseCameraData." + nameof(MaxDistance), this, m_MaxDistance, value)) m_MaxDistance = value; } } // 0xD4 (212)
		
		protected float m_SnapDistance = new float();
		[ContainerField(216), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2841439402)]
		public float SnapDistance { get { return m_SnapDistance; } set { if (OnPropertyChanging("ChaseCameraData." + nameof(SnapDistance), this, m_SnapDistance, value)) m_SnapDistance = value; } } // 0xD8 (216)
		
		protected float m_ForceFieldRadius = new float();
		[ContainerField(220), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1763697730)]
		public float ForceFieldRadius { get { return m_ForceFieldRadius; } set { if (OnPropertyChanging("ChaseCameraData." + nameof(ForceFieldRadius), this, m_ForceFieldRadius, value)) m_ForceFieldRadius = value; } } // 0xDC (220)
		
		protected float m_CollisionRadius = new float();
		[ContainerField(224), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1874505603)]
		public float CollisionRadius { get { return m_CollisionRadius; } set { if (OnPropertyChanging("ChaseCameraData." + nameof(CollisionRadius), this, m_CollisionRadius, value)) m_CollisionRadius = value; } } // 0xE0 (224)
		
		protected float m_ForceFieldForceScale = new float();
		[ContainerField(228), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3317981151)]
		public float ForceFieldForceScale { get { return m_ForceFieldForceScale; } set { if (OnPropertyChanging("ChaseCameraData." + nameof(ForceFieldForceScale), this, m_ForceFieldForceScale, value)) m_ForceFieldForceScale = value; } } // 0xE4 (228)
		
		protected float m_MaxVelocity = new float();
		[ContainerField(232), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(81127366)]
		public float MaxVelocity { get { return m_MaxVelocity; } set { if (OnPropertyChanging("ChaseCameraData." + nameof(MaxVelocity), this, m_MaxVelocity, value)) m_MaxVelocity = value; } } // 0xE8 (232)
		
		protected float m_VelocityDrag = new float();
		[ContainerField(236), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(58335362)]
		public float VelocityDrag { get { return m_VelocityDrag; } set { if (OnPropertyChanging("ChaseCameraData." + nameof(VelocityDrag), this, m_VelocityDrag, value)) m_VelocityDrag = value; } } // 0xEC (236)
		
		protected float m_PillExpandSizeSpeedAcceleration = new float();
		[ContainerField(240), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2985104634)]
		public float PillExpandSizeSpeedAcceleration { get { return m_PillExpandSizeSpeedAcceleration; } set { if (OnPropertyChanging("ChaseCameraData." + nameof(PillExpandSizeSpeedAcceleration), this, m_PillExpandSizeSpeedAcceleration, value)) m_PillExpandSizeSpeedAcceleration = value; } } // 0xF0 (240)
		
		protected float m_PillMinimumCollisionRadius = new float();
		[ContainerField(244), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(804419372)]
		public float PillMinimumCollisionRadius { get { return m_PillMinimumCollisionRadius; } set { if (OnPropertyChanging("ChaseCameraData." + nameof(PillMinimumCollisionRadius), this, m_PillMinimumCollisionRadius, value)) m_PillMinimumCollisionRadius = value; } } // 0xF4 (244)
		
		protected float m_PillMaximumCollisionRadius = new float();
		[ContainerField(248), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3536568050)]
		public float PillMaximumCollisionRadius { get { return m_PillMaximumCollisionRadius; } set { if (OnPropertyChanging("ChaseCameraData." + nameof(PillMaximumCollisionRadius), this, m_PillMaximumCollisionRadius, value)) m_PillMaximumCollisionRadius = value; } } // 0xF8 (248)
		
		protected float m_PillMinimumCollisionLength = new float();
		[ContainerField(252), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1361574600)]
		public float PillMinimumCollisionLength { get { return m_PillMinimumCollisionLength; } set { if (OnPropertyChanging("ChaseCameraData." + nameof(PillMinimumCollisionLength), this, m_PillMinimumCollisionLength, value)) m_PillMinimumCollisionLength = value; } } // 0xFC (252)
		
		protected float m_LookDistanceScale = new float();
		[ContainerField(256), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(4112376025)]
		public float LookDistanceScale { get { return m_LookDistanceScale; } set { if (OnPropertyChanging("ChaseCameraData." + nameof(LookDistanceScale), this, m_LookDistanceScale, value)) m_LookDistanceScale = value; } } // 0x100 (256)
		
		protected float m_LookDistanceInFrontOfTarget = new float();
		[ContainerField(260), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(4045244511)]
		public float LookDistanceInFrontOfTarget { get { return m_LookDistanceInFrontOfTarget; } set { if (OnPropertyChanging("ChaseCameraData." + nameof(LookDistanceInFrontOfTarget), this, m_LookDistanceInFrontOfTarget, value)) m_LookDistanceInFrontOfTarget = value; } } // 0x104 (260)
		
		protected uint m_UpdateRate = new uint();
		[ContainerField(264), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(2270996982)]
		public uint UpdateRate { get { return m_UpdateRate; } set { if (OnPropertyChanging("ChaseCameraData." + nameof(UpdateRate), this, m_UpdateRate, value)) m_UpdateRate = value; } } // 0x108 (264)
		
		protected bool m_KeepTargetPitch = new bool();
		[ContainerField(268), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3248397385)]
		public bool KeepTargetPitch { get { return m_KeepTargetPitch; } set { if (OnPropertyChanging("ChaseCameraData." + nameof(KeepTargetPitch), this, m_KeepTargetPitch, value)) m_KeepTargetPitch = value; } } // 0x10C (268)
		
		protected bool m_InheritTargetVelocity = new bool();
		[ContainerField(269), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(219688038)]
		public bool InheritTargetVelocity { get { return m_InheritTargetVelocity; } set { if (OnPropertyChanging("ChaseCameraData." + nameof(InheritTargetVelocity), this, m_InheritTargetVelocity, value)) m_InheritTargetVelocity = value; } } // 0x10D (269)
		
		protected bool m_ShouldRollWithTarget = new bool();
		[ContainerField(270), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2421688066)]
		public bool ShouldRollWithTarget { get { return m_ShouldRollWithTarget; } set { if (OnPropertyChanging("ChaseCameraData." + nameof(ShouldRollWithTarget), this, m_ShouldRollWithTarget, value)) m_ShouldRollWithTarget = value; } } // 0x10E (270)
		
		protected bool m_HasCollision = new bool();
		[ContainerField(271), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2369733505)]
		public bool HasCollision { get { return m_HasCollision; } set { if (OnPropertyChanging("ChaseCameraData." + nameof(HasCollision), this, m_HasCollision, value)) m_HasCollision = value; } } // 0x10F (271)
		
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
