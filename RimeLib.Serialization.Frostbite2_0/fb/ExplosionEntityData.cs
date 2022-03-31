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

namespace fb
{
	[ContainerType(16, 176)]
	public class ExplosionEntityData :
		GameEntityData
	{
		[ContainerField(96), JsonProperty(Order = 96)]
		public CtrRef<EffectBlueprint> DetonationEffect { get; set; } = new();

		[ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		public float BlastImpulse { get; set; }

		[ContainerField(104), JsonProperty(Order = 104)]
		public CtrRef<MaskVolumeEntityData> MaskVolume { get; set; } = new();

		[ContainerField(108), JsonProperty(Order = 108)]
		public CtrRef<DestructionMaskVolumeEntityData> DestructionMaskVolume { get; set; } = new();

		[ContainerField(112), JsonProperty(Order = 112)]
		public CtrRef<MaterialContainerPair> MaterialPair { get; set; } = new();

		[ContainerField(116), JsonProperty(Order = 116)]
		public DamageIndicationType DamageIndicationType { get; set; } = new();

		[ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		public float EmpTime { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		public float MaxOcclusionRaycastRadius { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		public float InnerBlastRadius { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		public float BlastDamage { get; set; }

		[ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		public float BlastRadius { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		public float ShockwaveImpulse { get; set; }

		[ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		public float SpawnDelay { get; set; }

		[ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		public float ShockwaveDamage { get; set; }

		[ContainerField(152), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		public float ShockwaveRadius { get; set; }

		[ContainerField(156), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
		public float CameraShockwaveRadius { get; set; }

		[ContainerField(160), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		public float ShockwaveTime { get; set; }

		[ContainerField(164), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
		public bool DisableOcclusion { get; set; }

		[ContainerField(165), LayoutImmutable, Blittable, JsonProperty(Order = 165)]
		public bool DisableStaticEntityOcclusion { get; set; }

		[ContainerField(166), LayoutImmutable, Blittable, JsonProperty(Order = 166)]
		public bool UseEntityTransformForDetonationEffect { get; set; }

		[ContainerField(167), LayoutImmutable, Blittable, JsonProperty(Order = 167)]
		public bool HasStunEffect { get; set; }

		[ContainerField(168), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
		public bool TriggerImpairedHearing { get; set; }

		[ContainerField(169), LayoutImmutable, Blittable, JsonProperty(Order = 169)]
		public bool DetonateOnce { get; set; }

		[ContainerField(170), LayoutImmutable, Blittable, JsonProperty(Order = 170)]
		public bool ShowOnMinimap { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(DetonationEffect));
			p_Writer.Write(BlastImpulse);
			p_Writer.Write(p_EbxWriter.WriteImport(MaskVolume));
			p_Writer.Write(p_EbxWriter.WriteImport(DestructionMaskVolume));
			p_Writer.Write(p_EbxWriter.WriteImport(MaterialPair));
			p_Writer.Write((int) DamageIndicationType);
			p_Writer.Write(EmpTime);
			p_Writer.Write(MaxOcclusionRaycastRadius);
			p_Writer.Write(InnerBlastRadius);
			p_Writer.Write(BlastDamage);
			p_Writer.Write(BlastRadius);
			p_Writer.Write(ShockwaveImpulse);
			p_Writer.Write(SpawnDelay);
			p_Writer.Write(ShockwaveDamage);
			p_Writer.Write(ShockwaveRadius);
			p_Writer.Write(CameraShockwaveRadius);
			p_Writer.Write(ShockwaveTime);
			p_Writer.Write(DisableOcclusion);
			p_Writer.Write(DisableStaticEntityOcclusion);
			p_Writer.Write(UseEntityTransformForDetonationEffect);
			p_Writer.Write(HasStunEffect);
			p_Writer.Write(TriggerImpairedHearing);
			p_Writer.Write(DetonateOnce);
			p_Writer.Write(ShowOnMinimap);
			p_Writer.WriteNullBytes(5);
		}
	}
}
