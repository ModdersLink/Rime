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
	public class FirstPersonCameraData : 
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Offset { get; set; } = new Vec3(); // 0x10 (16)
		
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 WeaponBaseOffset { get; set; } = new Vec3(); // 0x20 (32)
		
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 WeaponLagRotationOffset { get; set; } = new Vec3(); // 0x30 (48)
		
		[ContainerField(64), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Rotation { get; set; } = new Vec3(); // 0x40 (64)
		
		[ContainerField(80)]
		public CtrRef<WeaponLagSpringEffectData> WeaponSpringEffect { get; set; } = new CtrRef<WeaponLagSpringEffectData>(); // 0x50 (80)
		
		[ContainerField(84)]
		public CtrRef<WeaponLagSpringEffectData> CameraSpringEffect { get; set; } = new CtrRef<WeaponLagSpringEffectData>(); // 0x54 (84)
		
		[ContainerField(88), LayoutImmutable, Blittable]
		public float MoveStrafeModifier { get; set; } // 0x58 (88)
		
		[ContainerField(92), LayoutImmutable, Blittable]
		public float MoveForwardModifier { get; set; } // 0x5C (92)
		
		[ContainerField(96), LayoutImmutable, Blittable]
		public float RotateYawModifier { get; set; } // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public float RotatePitchModifier { get; set; } // 0x64 (100)
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public float RotateRollModifier { get; set; } // 0x68 (104)
		
		[ContainerField(108), LayoutImmutable, Blittable]
		public float ZoomMoveStrafeModifier { get; set; } // 0x6C (108)
		
		[ContainerField(112), LayoutImmutable, Blittable]
		public float ZoomMoveForwardModifier { get; set; } // 0x70 (112)
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public float ZoomRotateYawModifier { get; set; } // 0x74 (116)
		
		[ContainerField(120), LayoutImmutable, Blittable]
		public float ZoomRotatePitchModifier { get; set; } // 0x78 (120)
		
		[ContainerField(124), LayoutImmutable, Blittable]
		public float ZoomRotateRollModifier { get; set; } // 0x7C (124)
		
		[ContainerField(128), LayoutImmutable, Blittable]
		public float ReleaseModifier { get; set; } // 0x80 (128)
		
		[ContainerField(132), LayoutImmutable, Blittable]
		public float ReleaseModifierPitch { get; set; } // 0x84 (132)
		
		[ContainerField(136), LayoutImmutable, Blittable]
		public float ReleaseModifierYaw { get; set; } // 0x88 (136)
		
		[ContainerField(140), LayoutImmutable, Blittable]
		public float ReleaseModifierRoll { get; set; } // 0x8C (140)
		
		[ContainerField(144), LayoutImmutable, Blittable]
		public float OffsetReleaseModifier { get; set; } // 0x90 (144)
		
		[ContainerField(148), LayoutImmutable, Blittable]
		public float ZoomReleaseModifierPitch { get; set; } // 0x94 (148)
		
		[ContainerField(152), LayoutImmutable, Blittable]
		public float ZoomReleaseModifierYaw { get; set; } // 0x98 (152)
		
		[ContainerField(156), LayoutImmutable, Blittable]
		public float ZoomReleaseModifierRoll { get; set; } // 0x9C (156)
		
		[ContainerField(160), LayoutImmutable, Blittable]
		public float ZoomOffsetReleaseModifier { get; set; } // 0xA0 (160)
		
		[ContainerField(164), LayoutImmutable, Blittable]
		public float RotationAdditionToOffset { get; set; } // 0xA4 (164)
		
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
