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
	[ContainerType(16)]
	public class FirstPersonCameraData : 
		DataContainer
	{
		protected Vec3 m_Offset = new Vec3();
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, ContainerFieldNameHash(2871410728)]
		public Vec3 Offset { get { return m_Offset; } set { if (OnPropertyChanging("FirstPersonCameraData." + nameof(Offset), this, m_Offset, value)) m_Offset = value; } } // 0x10 (16)
		
		protected Vec3 m_WeaponBaseOffset = new Vec3();
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable, ContainerFieldNameHash(1777154239)]
		public Vec3 WeaponBaseOffset { get { return m_WeaponBaseOffset; } set { if (OnPropertyChanging("FirstPersonCameraData." + nameof(WeaponBaseOffset), this, m_WeaponBaseOffset, value)) m_WeaponBaseOffset = value; } } // 0x20 (32)
		
		protected Vec3 m_WeaponLagRotationOffset = new Vec3();
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable, ContainerFieldNameHash(3300383668)]
		public Vec3 WeaponLagRotationOffset { get { return m_WeaponLagRotationOffset; } set { if (OnPropertyChanging("FirstPersonCameraData." + nameof(WeaponLagRotationOffset), this, m_WeaponLagRotationOffset, value)) m_WeaponLagRotationOffset = value; } } // 0x30 (48)
		
		protected Vec3 m_Rotation = new Vec3();
		[ContainerField(64), Homogeneous, LayoutImmutable, Blittable, ContainerFieldNameHash(48673745)]
		public Vec3 Rotation { get { return m_Rotation; } set { if (OnPropertyChanging("FirstPersonCameraData." + nameof(Rotation), this, m_Rotation, value)) m_Rotation = value; } } // 0x40 (64)
		
		protected CtrRef<WeaponLagSpringEffectData> m_WeaponSpringEffect = new CtrRef<WeaponLagSpringEffectData>();
		[ContainerField(80), ContainerFieldNameHash(1606596257)]
		public CtrRef<WeaponLagSpringEffectData> WeaponSpringEffect { get { return m_WeaponSpringEffect; } set { if (OnPropertyChanging("FirstPersonCameraData." + nameof(WeaponSpringEffect), this, m_WeaponSpringEffect, value)) m_WeaponSpringEffect = value; } } // 0x50 (80)
		
		protected CtrRef<WeaponLagSpringEffectData> m_CameraSpringEffect = new CtrRef<WeaponLagSpringEffectData>();
		[ContainerField(84), ContainerFieldNameHash(1276058650)]
		public CtrRef<WeaponLagSpringEffectData> CameraSpringEffect { get { return m_CameraSpringEffect; } set { if (OnPropertyChanging("FirstPersonCameraData." + nameof(CameraSpringEffect), this, m_CameraSpringEffect, value)) m_CameraSpringEffect = value; } } // 0x54 (84)
		
		protected float m_MoveStrafeModifier = new float();
		[ContainerField(88), LayoutImmutable, Blittable, ContainerFieldNameHash(3886718324)]
		public float MoveStrafeModifier { get { return m_MoveStrafeModifier; } set { if (OnPropertyChanging("FirstPersonCameraData." + nameof(MoveStrafeModifier), this, m_MoveStrafeModifier, value)) m_MoveStrafeModifier = value; } } // 0x58 (88)
		
		protected float m_MoveForwardModifier = new float();
		[ContainerField(92), LayoutImmutable, Blittable, ContainerFieldNameHash(3166800568)]
		public float MoveForwardModifier { get { return m_MoveForwardModifier; } set { if (OnPropertyChanging("FirstPersonCameraData." + nameof(MoveForwardModifier), this, m_MoveForwardModifier, value)) m_MoveForwardModifier = value; } } // 0x5C (92)
		
		protected float m_RotateYawModifier = new float();
		[ContainerField(96), LayoutImmutable, Blittable, ContainerFieldNameHash(2055262564)]
		public float RotateYawModifier { get { return m_RotateYawModifier; } set { if (OnPropertyChanging("FirstPersonCameraData." + nameof(RotateYawModifier), this, m_RotateYawModifier, value)) m_RotateYawModifier = value; } } // 0x60 (96)
		
		protected float m_RotatePitchModifier = new float();
		[ContainerField(100), LayoutImmutable, Blittable, ContainerFieldNameHash(3243027341)]
		public float RotatePitchModifier { get { return m_RotatePitchModifier; } set { if (OnPropertyChanging("FirstPersonCameraData." + nameof(RotatePitchModifier), this, m_RotatePitchModifier, value)) m_RotatePitchModifier = value; } } // 0x64 (100)
		
		protected float m_RotateRollModifier = new float();
		[ContainerField(104), LayoutImmutable, Blittable, ContainerFieldNameHash(4236533558)]
		public float RotateRollModifier { get { return m_RotateRollModifier; } set { if (OnPropertyChanging("FirstPersonCameraData." + nameof(RotateRollModifier), this, m_RotateRollModifier, value)) m_RotateRollModifier = value; } } // 0x68 (104)
		
		protected float m_ZoomMoveStrafeModifier = new float();
		[ContainerField(108), LayoutImmutable, Blittable, ContainerFieldNameHash(1005106531)]
		public float ZoomMoveStrafeModifier { get { return m_ZoomMoveStrafeModifier; } set { if (OnPropertyChanging("FirstPersonCameraData." + nameof(ZoomMoveStrafeModifier), this, m_ZoomMoveStrafeModifier, value)) m_ZoomMoveStrafeModifier = value; } } // 0x6C (108)
		
		protected float m_ZoomMoveForwardModifier = new float();
		[ContainerField(112), LayoutImmutable, Blittable, ContainerFieldNameHash(3195664463)]
		public float ZoomMoveForwardModifier { get { return m_ZoomMoveForwardModifier; } set { if (OnPropertyChanging("FirstPersonCameraData." + nameof(ZoomMoveForwardModifier), this, m_ZoomMoveForwardModifier, value)) m_ZoomMoveForwardModifier = value; } } // 0x70 (112)
		
		protected float m_ZoomRotateYawModifier = new float();
		[ContainerField(116), LayoutImmutable, Blittable, ContainerFieldNameHash(988089747)]
		public float ZoomRotateYawModifier { get { return m_ZoomRotateYawModifier; } set { if (OnPropertyChanging("FirstPersonCameraData." + nameof(ZoomRotateYawModifier), this, m_ZoomRotateYawModifier, value)) m_ZoomRotateYawModifier = value; } } // 0x74 (116)
		
		protected float m_ZoomRotatePitchModifier = new float();
		[ContainerField(120), LayoutImmutable, Blittable, ContainerFieldNameHash(426555514)]
		public float ZoomRotatePitchModifier { get { return m_ZoomRotatePitchModifier; } set { if (OnPropertyChanging("FirstPersonCameraData." + nameof(ZoomRotatePitchModifier), this, m_ZoomRotatePitchModifier, value)) m_ZoomRotatePitchModifier = value; } } // 0x78 (120)
		
		protected float m_ZoomRotateRollModifier = new float();
		[ContainerField(124), LayoutImmutable, Blittable, ContainerFieldNameHash(1820524705)]
		public float ZoomRotateRollModifier { get { return m_ZoomRotateRollModifier; } set { if (OnPropertyChanging("FirstPersonCameraData." + nameof(ZoomRotateRollModifier), this, m_ZoomRotateRollModifier, value)) m_ZoomRotateRollModifier = value; } } // 0x7C (124)
		
		protected float m_ReleaseModifier = new float();
		[ContainerField(128), LayoutImmutable, Blittable, ContainerFieldNameHash(2602876219)]
		public float ReleaseModifier { get { return m_ReleaseModifier; } set { if (OnPropertyChanging("FirstPersonCameraData." + nameof(ReleaseModifier), this, m_ReleaseModifier, value)) m_ReleaseModifier = value; } } // 0x80 (128)
		
		protected float m_ReleaseModifierPitch = new float();
		[ContainerField(132), LayoutImmutable, Blittable, ContainerFieldNameHash(2645975069)]
		public float ReleaseModifierPitch { get { return m_ReleaseModifierPitch; } set { if (OnPropertyChanging("FirstPersonCameraData." + nameof(ReleaseModifierPitch), this, m_ReleaseModifierPitch, value)) m_ReleaseModifierPitch = value; } } // 0x84 (132)
		
		protected float m_ReleaseModifierYaw = new float();
		[ContainerField(136), LayoutImmutable, Blittable, ContainerFieldNameHash(3764955572)]
		public float ReleaseModifierYaw { get { return m_ReleaseModifierYaw; } set { if (OnPropertyChanging("FirstPersonCameraData." + nameof(ReleaseModifierYaw), this, m_ReleaseModifierYaw, value)) m_ReleaseModifierYaw = value; } } // 0x88 (136)
		
		protected float m_ReleaseModifierRoll = new float();
		[ContainerField(140), LayoutImmutable, Blittable, ContainerFieldNameHash(3984487174)]
		public float ReleaseModifierRoll { get { return m_ReleaseModifierRoll; } set { if (OnPropertyChanging("FirstPersonCameraData." + nameof(ReleaseModifierRoll), this, m_ReleaseModifierRoll, value)) m_ReleaseModifierRoll = value; } } // 0x8C (140)
		
		protected float m_OffsetReleaseModifier = new float();
		[ContainerField(144), LayoutImmutable, Blittable, ContainerFieldNameHash(569129014)]
		public float OffsetReleaseModifier { get { return m_OffsetReleaseModifier; } set { if (OnPropertyChanging("FirstPersonCameraData." + nameof(OffsetReleaseModifier), this, m_OffsetReleaseModifier, value)) m_OffsetReleaseModifier = value; } } // 0x90 (144)
		
		protected float m_ZoomReleaseModifierPitch = new float();
		[ContainerField(148), LayoutImmutable, Blittable, ContainerFieldNameHash(2609595722)]
		public float ZoomReleaseModifierPitch { get { return m_ZoomReleaseModifierPitch; } set { if (OnPropertyChanging("FirstPersonCameraData." + nameof(ZoomReleaseModifierPitch), this, m_ZoomReleaseModifierPitch, value)) m_ZoomReleaseModifierPitch = value; } } // 0x94 (148)
		
		protected float m_ZoomReleaseModifierYaw = new float();
		[ContainerField(152), LayoutImmutable, Blittable, ContainerFieldNameHash(3027400355)]
		public float ZoomReleaseModifierYaw { get { return m_ZoomReleaseModifierYaw; } set { if (OnPropertyChanging("FirstPersonCameraData." + nameof(ZoomReleaseModifierYaw), this, m_ZoomReleaseModifierYaw, value)) m_ZoomReleaseModifierYaw = value; } } // 0x98 (152)
		
		protected float m_ZoomReleaseModifierRoll = new float();
		[ContainerField(156), LayoutImmutable, Blittable, ContainerFieldNameHash(1120205489)]
		public float ZoomReleaseModifierRoll { get { return m_ZoomReleaseModifierRoll; } set { if (OnPropertyChanging("FirstPersonCameraData." + nameof(ZoomReleaseModifierRoll), this, m_ZoomReleaseModifierRoll, value)) m_ZoomReleaseModifierRoll = value; } } // 0x9C (156)
		
		protected float m_ZoomOffsetReleaseModifier = new float();
		[ContainerField(160), LayoutImmutable, Blittable, ContainerFieldNameHash(2315980993)]
		public float ZoomOffsetReleaseModifier { get { return m_ZoomOffsetReleaseModifier; } set { if (OnPropertyChanging("FirstPersonCameraData." + nameof(ZoomOffsetReleaseModifier), this, m_ZoomOffsetReleaseModifier, value)) m_ZoomOffsetReleaseModifier = value; } } // 0xA0 (160)
		
		protected float m_RotationAdditionToOffset = new float();
		[ContainerField(164), LayoutImmutable, Blittable, ContainerFieldNameHash(3933484403)]
		public float RotationAdditionToOffset { get { return m_RotationAdditionToOffset; } set { if (OnPropertyChanging("FirstPersonCameraData." + nameof(RotationAdditionToOffset), this, m_RotationAdditionToOffset, value)) m_RotationAdditionToOffset = value; } } // 0xA4 (164)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2871410728:
					Offset = (Vec3) p_Value;
					break;

				case 1777154239:
					WeaponBaseOffset = (Vec3) p_Value;
					break;

				case 3300383668:
					WeaponLagRotationOffset = (Vec3) p_Value;
					break;

				case 48673745:
					Rotation = (Vec3) p_Value;
					break;

				case 1606596257:
					WeaponSpringEffect = (CtrRef<WeaponLagSpringEffectData>) p_Value;
					break;

				case 1276058650:
					CameraSpringEffect = (CtrRef<WeaponLagSpringEffectData>) p_Value;
					break;

				case 3886718324:
					MoveStrafeModifier = (float) p_Value;
					break;

				case 3166800568:
					MoveForwardModifier = (float) p_Value;
					break;

				case 2055262564:
					RotateYawModifier = (float) p_Value;
					break;

				case 3243027341:
					RotatePitchModifier = (float) p_Value;
					break;

				case 4236533558:
					RotateRollModifier = (float) p_Value;
					break;

				case 1005106531:
					ZoomMoveStrafeModifier = (float) p_Value;
					break;

				case 3195664463:
					ZoomMoveForwardModifier = (float) p_Value;
					break;

				case 988089747:
					ZoomRotateYawModifier = (float) p_Value;
					break;

				case 426555514:
					ZoomRotatePitchModifier = (float) p_Value;
					break;

				case 1820524705:
					ZoomRotateRollModifier = (float) p_Value;
					break;

				case 2602876219:
					ReleaseModifier = (float) p_Value;
					break;

				case 2645975069:
					ReleaseModifierPitch = (float) p_Value;
					break;

				case 3764955572:
					ReleaseModifierYaw = (float) p_Value;
					break;

				case 3984487174:
					ReleaseModifierRoll = (float) p_Value;
					break;

				case 569129014:
					OffsetReleaseModifier = (float) p_Value;
					break;

				case 2609595722:
					ZoomReleaseModifierPitch = (float) p_Value;
					break;

				case 3027400355:
					ZoomReleaseModifierYaw = (float) p_Value;
					break;

				case 1120205489:
					ZoomReleaseModifierRoll = (float) p_Value;
					break;

				case 2315980993:
					ZoomOffsetReleaseModifier = (float) p_Value;
					break;

				case 3933484403:
					RotationAdditionToOffset = (float) p_Value;
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
				case 2871410728:
					return Offset;

				case 1777154239:
					return WeaponBaseOffset;

				case 3300383668:
					return WeaponLagRotationOffset;

				case 48673745:
					return Rotation;

				case 1606596257:
					return WeaponSpringEffect;

				case 1276058650:
					return CameraSpringEffect;

				case 3886718324:
					return MoveStrafeModifier;

				case 3166800568:
					return MoveForwardModifier;

				case 2055262564:
					return RotateYawModifier;

				case 3243027341:
					return RotatePitchModifier;

				case 4236533558:
					return RotateRollModifier;

				case 1005106531:
					return ZoomMoveStrafeModifier;

				case 3195664463:
					return ZoomMoveForwardModifier;

				case 988089747:
					return ZoomRotateYawModifier;

				case 426555514:
					return ZoomRotatePitchModifier;

				case 1820524705:
					return ZoomRotateRollModifier;

				case 2602876219:
					return ReleaseModifier;

				case 2645975069:
					return ReleaseModifierPitch;

				case 3764955572:
					return ReleaseModifierYaw;

				case 3984487174:
					return ReleaseModifierRoll;

				case 569129014:
					return OffsetReleaseModifier;

				case 2609595722:
					return ZoomReleaseModifierPitch;

				case 3027400355:
					return ZoomReleaseModifierYaw;

				case 1120205489:
					return ZoomReleaseModifierRoll;

				case 2315980993:
					return ZoomOffsetReleaseModifier;

				case 3933484403:
					return RotationAdditionToOffset;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2871410728:
					return typeof(FirstPersonCameraData).GetProperty(nameof(Offset));

				case 1777154239:
					return typeof(FirstPersonCameraData).GetProperty(nameof(WeaponBaseOffset));

				case 3300383668:
					return typeof(FirstPersonCameraData).GetProperty(nameof(WeaponLagRotationOffset));

				case 48673745:
					return typeof(FirstPersonCameraData).GetProperty(nameof(Rotation));

				case 1606596257:
					return typeof(FirstPersonCameraData).GetProperty(nameof(WeaponSpringEffect));

				case 1276058650:
					return typeof(FirstPersonCameraData).GetProperty(nameof(CameraSpringEffect));

				case 3886718324:
					return typeof(FirstPersonCameraData).GetProperty(nameof(MoveStrafeModifier));

				case 3166800568:
					return typeof(FirstPersonCameraData).GetProperty(nameof(MoveForwardModifier));

				case 2055262564:
					return typeof(FirstPersonCameraData).GetProperty(nameof(RotateYawModifier));

				case 3243027341:
					return typeof(FirstPersonCameraData).GetProperty(nameof(RotatePitchModifier));

				case 4236533558:
					return typeof(FirstPersonCameraData).GetProperty(nameof(RotateRollModifier));

				case 1005106531:
					return typeof(FirstPersonCameraData).GetProperty(nameof(ZoomMoveStrafeModifier));

				case 3195664463:
					return typeof(FirstPersonCameraData).GetProperty(nameof(ZoomMoveForwardModifier));

				case 988089747:
					return typeof(FirstPersonCameraData).GetProperty(nameof(ZoomRotateYawModifier));

				case 426555514:
					return typeof(FirstPersonCameraData).GetProperty(nameof(ZoomRotatePitchModifier));

				case 1820524705:
					return typeof(FirstPersonCameraData).GetProperty(nameof(ZoomRotateRollModifier));

				case 2602876219:
					return typeof(FirstPersonCameraData).GetProperty(nameof(ReleaseModifier));

				case 2645975069:
					return typeof(FirstPersonCameraData).GetProperty(nameof(ReleaseModifierPitch));

				case 3764955572:
					return typeof(FirstPersonCameraData).GetProperty(nameof(ReleaseModifierYaw));

				case 3984487174:
					return typeof(FirstPersonCameraData).GetProperty(nameof(ReleaseModifierRoll));

				case 569129014:
					return typeof(FirstPersonCameraData).GetProperty(nameof(OffsetReleaseModifier));

				case 2609595722:
					return typeof(FirstPersonCameraData).GetProperty(nameof(ZoomReleaseModifierPitch));

				case 3027400355:
					return typeof(FirstPersonCameraData).GetProperty(nameof(ZoomReleaseModifierYaw));

				case 1120205489:
					return typeof(FirstPersonCameraData).GetProperty(nameof(ZoomReleaseModifierRoll));

				case 2315980993:
					return typeof(FirstPersonCameraData).GetProperty(nameof(ZoomOffsetReleaseModifier));

				case 3933484403:
					return typeof(FirstPersonCameraData).GetProperty(nameof(RotationAdditionToOffset));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
