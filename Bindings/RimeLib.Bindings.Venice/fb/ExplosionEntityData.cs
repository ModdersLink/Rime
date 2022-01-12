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
	[ContainerType(16, 176)]
	public class ExplosionEntityData : 
		GameEntityData
	{
		[ContainerField(96)]
		public CtrRef<EffectBlueprint> DetonationEffect { get; set; } = new();

		[ContainerField(100), LayoutImmutable, Blittable]
		public float BlastImpulse { get; set; }

		[ContainerField(104)]
		public CtrRef<MaskVolumeEntityData> MaskVolume { get; set; } = new();

		[ContainerField(108)]
		public CtrRef<DestructionMaskVolumeEntityData> DestructionMaskVolume { get; set; } = new();

		[ContainerField(112)]
		public CtrRef<MaterialContainerPair> MaterialPair { get; set; } = new();

		[ContainerField(116)]
		public DamageIndicationType DamageIndicationType { get; set; } = new();

		[ContainerField(120), LayoutImmutable, Blittable]
		public float EmpTime { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable]
		public float MaxOcclusionRaycastRadius { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable]
		public float InnerBlastRadius { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable]
		public float BlastDamage { get; set; }

		[ContainerField(136), LayoutImmutable, Blittable]
		public float BlastRadius { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable]
		public float ShockwaveImpulse { get; set; }

		[ContainerField(144), LayoutImmutable, Blittable]
		public float SpawnDelay { get; set; }

		[ContainerField(148), LayoutImmutable, Blittable]
		public float ShockwaveDamage { get; set; }

		[ContainerField(152), LayoutImmutable, Blittable]
		public float ShockwaveRadius { get; set; }

		[ContainerField(156), LayoutImmutable, Blittable]
		public float CameraShockwaveRadius { get; set; }

		[ContainerField(160), LayoutImmutable, Blittable]
		public float ShockwaveTime { get; set; }

		[ContainerField(164), LayoutImmutable, Blittable]
		public bool DisableOcclusion { get; set; }

		[ContainerField(165), LayoutImmutable, Blittable]
		public bool DisableStaticEntityOcclusion { get; set; }

		[ContainerField(166), LayoutImmutable, Blittable]
		public bool UseEntityTransformForDetonationEffect { get; set; }

		[ContainerField(167), LayoutImmutable, Blittable]
		public bool HasStunEffect { get; set; }

		[ContainerField(168), LayoutImmutable, Blittable]
		public bool TriggerImpairedHearing { get; set; }

		[ContainerField(169), LayoutImmutable, Blittable]
		public bool DetonateOnce { get; set; }

		[ContainerField(170), LayoutImmutable, Blittable]
		public bool ShowOnMinimap { get; set; }

	}
}
