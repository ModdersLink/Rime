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
	[ContainerType(16, 176)]
	public partial class ExplosionEntityData :
		GameEntityData
	{
		[ObservableProperty]
		[property: ContainerField(96), JsonProperty(Order = 96)]
		private CtrRef<EffectBlueprint> _DetonationEffect = new();

		[ObservableProperty]
		[property: ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		private float _BlastImpulse;

		[ObservableProperty]
		[property: ContainerField(104), JsonProperty(Order = 104)]
		private CtrRef<MaskVolumeEntityData> _MaskVolume = new();

		[ObservableProperty]
		[property: ContainerField(108), JsonProperty(Order = 108)]
		private CtrRef<DestructionMaskVolumeEntityData> _DestructionMaskVolume = new();

		[ObservableProperty]
		[property: ContainerField(112), JsonProperty(Order = 112)]
		private CtrRef<MaterialContainerPair> _MaterialPair = new();

		[ObservableProperty]
		[property: ContainerField(116), JsonProperty(Order = 116)]
		private DamageIndicationType _DamageIndicationType = new();

		[ObservableProperty]
		[property: ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		private float _EmpTime;

		[ObservableProperty]
		[property: ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		private float _MaxOcclusionRaycastRadius;

		[ObservableProperty]
		[property: ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		private float _InnerBlastRadius;

		[ObservableProperty]
		[property: ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		private float _BlastDamage;

		[ObservableProperty]
		[property: ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		private float _BlastRadius;

		[ObservableProperty]
		[property: ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		private float _ShockwaveImpulse;

		[ObservableProperty]
		[property: ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		private float _SpawnDelay;

		[ObservableProperty]
		[property: ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		private float _ShockwaveDamage;

		[ObservableProperty]
		[property: ContainerField(152), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		private float _ShockwaveRadius;

		[ObservableProperty]
		[property: ContainerField(156), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
		private float _CameraShockwaveRadius;

		[ObservableProperty]
		[property: ContainerField(160), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		private float _ShockwaveTime;

		[ObservableProperty]
		[property: ContainerField(164), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
		private bool _DisableOcclusion;

		[ObservableProperty]
		[property: ContainerField(165), LayoutImmutable, Blittable, JsonProperty(Order = 165)]
		private bool _DisableStaticEntityOcclusion;

		[ObservableProperty]
		[property: ContainerField(166), LayoutImmutable, Blittable, JsonProperty(Order = 166)]
		private bool _UseEntityTransformForDetonationEffect;

		[ObservableProperty]
		[property: ContainerField(167), LayoutImmutable, Blittable, JsonProperty(Order = 167)]
		private bool _HasStunEffect;

		[ObservableProperty]
		[property: ContainerField(168), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
		private bool _TriggerImpairedHearing;

		[ObservableProperty]
		[property: ContainerField(169), LayoutImmutable, Blittable, JsonProperty(Order = 169)]
		private bool _DetonateOnce;

		[ObservableProperty]
		[property: ContainerField(170), LayoutImmutable, Blittable, JsonProperty(Order = 170)]
		private bool _ShowOnMinimap;

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
