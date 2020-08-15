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
	public class ExplosionEntityData : 
		GameEntityData
	{
		protected CtrRef<EffectBlueprint> m_DetonationEffect = new CtrRef<EffectBlueprint>();
		[ContainerField(96), ContainerFieldNameHash(2442173307)]
		public CtrRef<EffectBlueprint> DetonationEffect { get { return m_DetonationEffect; } set { if (OnPropertyChanging("ExplosionEntityData." + nameof(DetonationEffect), this, m_DetonationEffect, value)) m_DetonationEffect = value; } } // 0x60 (96)
		
		protected float m_BlastImpulse = new float();
		[ContainerField(100), LayoutImmutable, Blittable, ContainerFieldNameHash(1357093398)]
		public float BlastImpulse { get { return m_BlastImpulse; } set { if (OnPropertyChanging("ExplosionEntityData." + nameof(BlastImpulse), this, m_BlastImpulse, value)) m_BlastImpulse = value; } } // 0x64 (100)
		
		protected CtrRef<MaskVolumeEntityData> m_MaskVolume = new CtrRef<MaskVolumeEntityData>();
		[ContainerField(104), ContainerFieldNameHash(3961586169)]
		public CtrRef<MaskVolumeEntityData> MaskVolume { get { return m_MaskVolume; } set { if (OnPropertyChanging("ExplosionEntityData." + nameof(MaskVolume), this, m_MaskVolume, value)) m_MaskVolume = value; } } // 0x68 (104)
		
		protected CtrRef<DestructionMaskVolumeEntityData> m_DestructionMaskVolume = new CtrRef<DestructionMaskVolumeEntityData>();
		[ContainerField(108), ContainerFieldNameHash(2657972903)]
		public CtrRef<DestructionMaskVolumeEntityData> DestructionMaskVolume { get { return m_DestructionMaskVolume; } set { if (OnPropertyChanging("ExplosionEntityData." + nameof(DestructionMaskVolume), this, m_DestructionMaskVolume, value)) m_DestructionMaskVolume = value; } } // 0x6C (108)
		
		protected CtrRef<MaterialContainerPair> m_MaterialPair = new CtrRef<MaterialContainerPair>();
		[ContainerField(112), ContainerFieldNameHash(161392100)]
		public CtrRef<MaterialContainerPair> MaterialPair { get { return m_MaterialPair; } set { if (OnPropertyChanging("ExplosionEntityData." + nameof(MaterialPair), this, m_MaterialPair, value)) m_MaterialPair = value; } } // 0x70 (112)
		
		protected DamageIndicationType m_DamageIndicationType = new DamageIndicationType();
		[ContainerField(116), ContainerFieldNameHash(1466039938)]
		public DamageIndicationType DamageIndicationType { get { return m_DamageIndicationType; } set { if (OnPropertyChanging("ExplosionEntityData." + nameof(DamageIndicationType), this, m_DamageIndicationType, value)) m_DamageIndicationType = value; } } // 0x74 (116)
		
		protected float m_EmpTime = new float();
		[ContainerField(120), LayoutImmutable, Blittable, ContainerFieldNameHash(50680072)]
		public float EmpTime { get { return m_EmpTime; } set { if (OnPropertyChanging("ExplosionEntityData." + nameof(EmpTime), this, m_EmpTime, value)) m_EmpTime = value; } } // 0x78 (120)
		
		protected float m_MaxOcclusionRaycastRadius = new float();
		[ContainerField(124), LayoutImmutable, Blittable, ContainerFieldNameHash(3529203691)]
		public float MaxOcclusionRaycastRadius { get { return m_MaxOcclusionRaycastRadius; } set { if (OnPropertyChanging("ExplosionEntityData." + nameof(MaxOcclusionRaycastRadius), this, m_MaxOcclusionRaycastRadius, value)) m_MaxOcclusionRaycastRadius = value; } } // 0x7C (124)
		
		protected float m_InnerBlastRadius = new float();
		[ContainerField(128), LayoutImmutable, Blittable, ContainerFieldNameHash(3210314251)]
		public float InnerBlastRadius { get { return m_InnerBlastRadius; } set { if (OnPropertyChanging("ExplosionEntityData." + nameof(InnerBlastRadius), this, m_InnerBlastRadius, value)) m_InnerBlastRadius = value; } } // 0x80 (128)
		
		protected float m_BlastDamage = new float();
		[ContainerField(132), LayoutImmutable, Blittable, ContainerFieldNameHash(2404506214)]
		public float BlastDamage { get { return m_BlastDamage; } set { if (OnPropertyChanging("ExplosionEntityData." + nameof(BlastDamage), this, m_BlastDamage, value)) m_BlastDamage = value; } } // 0x84 (132)
		
		protected float m_BlastRadius = new float();
		[ContainerField(136), LayoutImmutable, Blittable, ContainerFieldNameHash(3113578581)]
		public float BlastRadius { get { return m_BlastRadius; } set { if (OnPropertyChanging("ExplosionEntityData." + nameof(BlastRadius), this, m_BlastRadius, value)) m_BlastRadius = value; } } // 0x88 (136)
		
		protected float m_ShockwaveImpulse = new float();
		[ContainerField(140), LayoutImmutable, Blittable, ContainerFieldNameHash(2645636871)]
		public float ShockwaveImpulse { get { return m_ShockwaveImpulse; } set { if (OnPropertyChanging("ExplosionEntityData." + nameof(ShockwaveImpulse), this, m_ShockwaveImpulse, value)) m_ShockwaveImpulse = value; } } // 0x8C (140)
		
		protected float m_SpawnDelay = new float();
		[ContainerField(144), LayoutImmutable, Blittable, ContainerFieldNameHash(3473198411)]
		public float SpawnDelay { get { return m_SpawnDelay; } set { if (OnPropertyChanging("ExplosionEntityData." + nameof(SpawnDelay), this, m_SpawnDelay, value)) m_SpawnDelay = value; } } // 0x90 (144)
		
		protected float m_ShockwaveDamage = new float();
		[ContainerField(148), LayoutImmutable, Blittable, ContainerFieldNameHash(1308225879)]
		public float ShockwaveDamage { get { return m_ShockwaveDamage; } set { if (OnPropertyChanging("ExplosionEntityData." + nameof(ShockwaveDamage), this, m_ShockwaveDamage, value)) m_ShockwaveDamage = value; } } // 0x94 (148)
		
		protected float m_ShockwaveRadius = new float();
		[ContainerField(152), LayoutImmutable, Blittable, ContainerFieldNameHash(764886628)]
		public float ShockwaveRadius { get { return m_ShockwaveRadius; } set { if (OnPropertyChanging("ExplosionEntityData." + nameof(ShockwaveRadius), this, m_ShockwaveRadius, value)) m_ShockwaveRadius = value; } } // 0x98 (152)
		
		protected float m_CameraShockwaveRadius = new float();
		[ContainerField(156), LayoutImmutable, Blittable, ContainerFieldNameHash(1681428477)]
		public float CameraShockwaveRadius { get { return m_CameraShockwaveRadius; } set { if (OnPropertyChanging("ExplosionEntityData." + nameof(CameraShockwaveRadius), this, m_CameraShockwaveRadius, value)) m_CameraShockwaveRadius = value; } } // 0x9C (156)
		
		protected float m_ShockwaveTime = new float();
		[ContainerField(160), LayoutImmutable, Blittable, ContainerFieldNameHash(2690395625)]
		public float ShockwaveTime { get { return m_ShockwaveTime; } set { if (OnPropertyChanging("ExplosionEntityData." + nameof(ShockwaveTime), this, m_ShockwaveTime, value)) m_ShockwaveTime = value; } } // 0xA0 (160)
		
		protected bool m_DisableOcclusion = new bool();
		[ContainerField(164), LayoutImmutable, Blittable, ContainerFieldNameHash(4105695996)]
		public bool DisableOcclusion { get { return m_DisableOcclusion; } set { if (OnPropertyChanging("ExplosionEntityData." + nameof(DisableOcclusion), this, m_DisableOcclusion, value)) m_DisableOcclusion = value; } } // 0xA4 (164)
		
		protected bool m_DisableStaticEntityOcclusion = new bool();
		[ContainerField(165), LayoutImmutable, Blittable, ContainerFieldNameHash(1182367647)]
		public bool DisableStaticEntityOcclusion { get { return m_DisableStaticEntityOcclusion; } set { if (OnPropertyChanging("ExplosionEntityData." + nameof(DisableStaticEntityOcclusion), this, m_DisableStaticEntityOcclusion, value)) m_DisableStaticEntityOcclusion = value; } } // 0xA5 (165)
		
		protected bool m_UseEntityTransformForDetonationEffect = new bool();
		[ContainerField(166), LayoutImmutable, Blittable, ContainerFieldNameHash(28012372)]
		public bool UseEntityTransformForDetonationEffect { get { return m_UseEntityTransformForDetonationEffect; } set { if (OnPropertyChanging("ExplosionEntityData." + nameof(UseEntityTransformForDetonationEffect), this, m_UseEntityTransformForDetonationEffect, value)) m_UseEntityTransformForDetonationEffect = value; } } // 0xA6 (166)
		
		protected bool m_HasStunEffect = new bool();
		[ContainerField(167), LayoutImmutable, Blittable, ContainerFieldNameHash(3580962068)]
		public bool HasStunEffect { get { return m_HasStunEffect; } set { if (OnPropertyChanging("ExplosionEntityData." + nameof(HasStunEffect), this, m_HasStunEffect, value)) m_HasStunEffect = value; } } // 0xA7 (167)
		
		protected bool m_TriggerImpairedHearing = new bool();
		[ContainerField(168), LayoutImmutable, Blittable, ContainerFieldNameHash(3966072268)]
		public bool TriggerImpairedHearing { get { return m_TriggerImpairedHearing; } set { if (OnPropertyChanging("ExplosionEntityData." + nameof(TriggerImpairedHearing), this, m_TriggerImpairedHearing, value)) m_TriggerImpairedHearing = value; } } // 0xA8 (168)
		
		protected bool m_DetonateOnce = new bool();
		[ContainerField(169), LayoutImmutable, Blittable, ContainerFieldNameHash(1593780038)]
		public bool DetonateOnce { get { return m_DetonateOnce; } set { if (OnPropertyChanging("ExplosionEntityData." + nameof(DetonateOnce), this, m_DetonateOnce, value)) m_DetonateOnce = value; } } // 0xA9 (169)
		
		protected bool m_ShowOnMinimap = new bool();
		[ContainerField(170), LayoutImmutable, Blittable, ContainerFieldNameHash(1450528952)]
		public bool ShowOnMinimap { get { return m_ShowOnMinimap; } set { if (OnPropertyChanging("ExplosionEntityData." + nameof(ShowOnMinimap), this, m_ShowOnMinimap, value)) m_ShowOnMinimap = value; } } // 0xAA (170)
		
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
