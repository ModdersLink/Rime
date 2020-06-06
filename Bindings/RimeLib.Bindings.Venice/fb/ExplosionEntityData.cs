///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class ExplosionEntityData : 
		GameEntityData
	{
		[ContainerField(96)]
		public CtrRef<EffectBlueprint> DetonationEffect { get; set; } = new CtrRef<EffectBlueprint>(); // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public float BlastImpulse { get; set; } // 0x64 (100)
		
		[ContainerField(104)]
		public CtrRef<MaskVolumeEntityData> MaskVolume { get; set; } = new CtrRef<MaskVolumeEntityData>(); // 0x68 (104)
		
		[ContainerField(108)]
		public CtrRef<DestructionMaskVolumeEntityData> DestructionMaskVolume { get; set; } = new CtrRef<DestructionMaskVolumeEntityData>(); // 0x6C (108)
		
		[ContainerField(112)]
		public CtrRef<MaterialContainerPair> MaterialPair { get; set; } = new CtrRef<MaterialContainerPair>(); // 0x70 (112)
		
		[ContainerField(116)]
		public DamageIndicationType DamageIndicationType { get; set; } = new DamageIndicationType(); // 0x74 (116)
		
		[ContainerField(120), LayoutImmutable, Blittable]
		public float EmpTime { get; set; } // 0x78 (120)
		
		[ContainerField(124), LayoutImmutable, Blittable]
		public float MaxOcclusionRaycastRadius { get; set; } // 0x7C (124)
		
		[ContainerField(128), LayoutImmutable, Blittable]
		public float InnerBlastRadius { get; set; } // 0x80 (128)
		
		[ContainerField(132), LayoutImmutable, Blittable]
		public float BlastDamage { get; set; } // 0x84 (132)
		
		[ContainerField(136), LayoutImmutable, Blittable]
		public float BlastRadius { get; set; } // 0x88 (136)
		
		[ContainerField(140), LayoutImmutable, Blittable]
		public float ShockwaveImpulse { get; set; } // 0x8C (140)
		
		[ContainerField(144), LayoutImmutable, Blittable]
		public float SpawnDelay { get; set; } // 0x90 (144)
		
		[ContainerField(148), LayoutImmutable, Blittable]
		public float ShockwaveDamage { get; set; } // 0x94 (148)
		
		[ContainerField(152), LayoutImmutable, Blittable]
		public float ShockwaveRadius { get; set; } // 0x98 (152)
		
		[ContainerField(156), LayoutImmutable, Blittable]
		public float CameraShockwaveRadius { get; set; } // 0x9C (156)
		
		[ContainerField(160), LayoutImmutable, Blittable]
		public float ShockwaveTime { get; set; } // 0xA0 (160)
		
		[ContainerField(164), LayoutImmutable, Blittable]
		public bool DisableOcclusion { get; set; } // 0xA4 (164)
		
		[ContainerField(165), LayoutImmutable, Blittable]
		public bool DisableStaticEntityOcclusion { get; set; } // 0xA5 (165)
		
		[ContainerField(166), LayoutImmutable, Blittable]
		public bool UseEntityTransformForDetonationEffect { get; set; } // 0xA6 (166)
		
		[ContainerField(167), LayoutImmutable, Blittable]
		public bool HasStunEffect { get; set; } // 0xA7 (167)
		
		[ContainerField(168), LayoutImmutable, Blittable]
		public bool TriggerImpairedHearing { get; set; } // 0xA8 (168)
		
		[ContainerField(169), LayoutImmutable, Blittable]
		public bool DetonateOnce { get; set; } // 0xA9 (169)
		
		[ContainerField(170), LayoutImmutable, Blittable]
		public bool ShowOnMinimap { get; set; } // 0xAA (170)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2442173307:
					DetonationEffect = (CtrRef<EffectBlueprint>) p_Value;
					break;

				case 1357093398:
					BlastImpulse = (float) p_Value;
					break;

				case 3961586169:
					MaskVolume = (CtrRef<MaskVolumeEntityData>) p_Value;
					break;

				case 2657972903:
					DestructionMaskVolume = (CtrRef<DestructionMaskVolumeEntityData>) p_Value;
					break;

				case 161392100:
					MaterialPair = (CtrRef<MaterialContainerPair>) p_Value;
					break;

				case 1466039938:
					DamageIndicationType = (DamageIndicationType) Enum.ToObject(typeof(DamageIndicationType), p_Value);
					break;

				case 50680072:
					EmpTime = (float) p_Value;
					break;

				case 3529203691:
					MaxOcclusionRaycastRadius = (float) p_Value;
					break;

				case 3210314251:
					InnerBlastRadius = (float) p_Value;
					break;

				case 2404506214:
					BlastDamage = (float) p_Value;
					break;

				case 3113578581:
					BlastRadius = (float) p_Value;
					break;

				case 2645636871:
					ShockwaveImpulse = (float) p_Value;
					break;

				case 3473198411:
					SpawnDelay = (float) p_Value;
					break;

				case 1308225879:
					ShockwaveDamage = (float) p_Value;
					break;

				case 764886628:
					ShockwaveRadius = (float) p_Value;
					break;

				case 1681428477:
					CameraShockwaveRadius = (float) p_Value;
					break;

				case 2690395625:
					ShockwaveTime = (float) p_Value;
					break;

				case 4105695996:
					DisableOcclusion = (bool) p_Value;
					break;

				case 1182367647:
					DisableStaticEntityOcclusion = (bool) p_Value;
					break;

				case 28012372:
					UseEntityTransformForDetonationEffect = (bool) p_Value;
					break;

				case 3580962068:
					HasStunEffect = (bool) p_Value;
					break;

				case 3966072268:
					TriggerImpairedHearing = (bool) p_Value;
					break;

				case 1593780038:
					DetonateOnce = (bool) p_Value;
					break;

				case 1450528952:
					ShowOnMinimap = (bool) p_Value;
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
				case 2442173307:
					return DetonationEffect;

				case 1357093398:
					return BlastImpulse;

				case 3961586169:
					return MaskVolume;

				case 2657972903:
					return DestructionMaskVolume;

				case 161392100:
					return MaterialPair;

				case 1466039938:
					return DamageIndicationType;

				case 50680072:
					return EmpTime;

				case 3529203691:
					return MaxOcclusionRaycastRadius;

				case 3210314251:
					return InnerBlastRadius;

				case 2404506214:
					return BlastDamage;

				case 3113578581:
					return BlastRadius;

				case 2645636871:
					return ShockwaveImpulse;

				case 3473198411:
					return SpawnDelay;

				case 1308225879:
					return ShockwaveDamage;

				case 764886628:
					return ShockwaveRadius;

				case 1681428477:
					return CameraShockwaveRadius;

				case 2690395625:
					return ShockwaveTime;

				case 4105695996:
					return DisableOcclusion;

				case 1182367647:
					return DisableStaticEntityOcclusion;

				case 28012372:
					return UseEntityTransformForDetonationEffect;

				case 3580962068:
					return HasStunEffect;

				case 3966072268:
					return TriggerImpairedHearing;

				case 1593780038:
					return DetonateOnce;

				case 1450528952:
					return ShowOnMinimap;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2442173307:
					return typeof(ExplosionEntityData).GetProperty(nameof(DetonationEffect));

				case 1357093398:
					return typeof(ExplosionEntityData).GetProperty(nameof(BlastImpulse));

				case 3961586169:
					return typeof(ExplosionEntityData).GetProperty(nameof(MaskVolume));

				case 2657972903:
					return typeof(ExplosionEntityData).GetProperty(nameof(DestructionMaskVolume));

				case 161392100:
					return typeof(ExplosionEntityData).GetProperty(nameof(MaterialPair));

				case 1466039938:
					return typeof(ExplosionEntityData).GetProperty(nameof(DamageIndicationType));

				case 50680072:
					return typeof(ExplosionEntityData).GetProperty(nameof(EmpTime));

				case 3529203691:
					return typeof(ExplosionEntityData).GetProperty(nameof(MaxOcclusionRaycastRadius));

				case 3210314251:
					return typeof(ExplosionEntityData).GetProperty(nameof(InnerBlastRadius));

				case 2404506214:
					return typeof(ExplosionEntityData).GetProperty(nameof(BlastDamage));

				case 3113578581:
					return typeof(ExplosionEntityData).GetProperty(nameof(BlastRadius));

				case 2645636871:
					return typeof(ExplosionEntityData).GetProperty(nameof(ShockwaveImpulse));

				case 3473198411:
					return typeof(ExplosionEntityData).GetProperty(nameof(SpawnDelay));

				case 1308225879:
					return typeof(ExplosionEntityData).GetProperty(nameof(ShockwaveDamage));

				case 764886628:
					return typeof(ExplosionEntityData).GetProperty(nameof(ShockwaveRadius));

				case 1681428477:
					return typeof(ExplosionEntityData).GetProperty(nameof(CameraShockwaveRadius));

				case 2690395625:
					return typeof(ExplosionEntityData).GetProperty(nameof(ShockwaveTime));

				case 4105695996:
					return typeof(ExplosionEntityData).GetProperty(nameof(DisableOcclusion));

				case 1182367647:
					return typeof(ExplosionEntityData).GetProperty(nameof(DisableStaticEntityOcclusion));

				case 28012372:
					return typeof(ExplosionEntityData).GetProperty(nameof(UseEntityTransformForDetonationEffect));

				case 3580962068:
					return typeof(ExplosionEntityData).GetProperty(nameof(HasStunEffect));

				case 3966072268:
					return typeof(ExplosionEntityData).GetProperty(nameof(TriggerImpairedHearing));

				case 1593780038:
					return typeof(ExplosionEntityData).GetProperty(nameof(DetonateOnce));

				case 1450528952:
					return typeof(ExplosionEntityData).GetProperty(nameof(ShowOnMinimap));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
