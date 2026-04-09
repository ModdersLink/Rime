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
	[ContainerType(16, 144)]
	public partial class RotorComponentData :
		ComponentData
	{
		[ObservableProperty]
		[property: ContainerField(96), JsonProperty(Order = 96)]
		private RotorModelData _LowRpmModel = new();

		[ObservableProperty]
		[property: ContainerField(104), JsonProperty(Order = 104)]
		private RotorModelData _HighRpmModel = new();

		[ObservableProperty]
		[property: ContainerField(112), JsonProperty(Order = 112)]
		private RotationAxis _RotationAxis = new();

		[ObservableProperty]
		[property: ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		private float _RotationMultiplier;

		[ObservableProperty]
		[property: ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		private float _ChangeModelRpm;

		[ObservableProperty]
		[property: ContainerField(124), JsonProperty(Order = 124)]
		private CtrRef<EffectBlueprint> _BlowEffect = new();

		[ObservableProperty]
		[property: ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		private float _TriggerGroundEffectHeight;

		[ObservableProperty]
		[property: ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		private float _CriticallyDamagedRotationForce;

		[ObservableProperty]
		[property: ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		private bool _OnlyTriggerBlowEffectInWater;

		[ObservableProperty]
		[property: ContainerField(137), LayoutImmutable, Blittable, JsonProperty(Order = 137)]
		private bool _GroundEffectOnTerrainOnly;

		[ObservableProperty]
		[property: ContainerField(138), LayoutImmutable, Blittable, JsonProperty(Order = 138)]
		private bool _CriticalDamage;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			LowRpmModel.Serialize(p_Writer, p_EbxWriter);
			HighRpmModel.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) RotationAxis);
			p_Writer.Write(RotationMultiplier);
			p_Writer.Write(ChangeModelRpm);
			p_Writer.Write(p_EbxWriter.WriteImport(BlowEffect));
			p_Writer.Write(TriggerGroundEffectHeight);
			p_Writer.Write(CriticallyDamagedRotationForce);
			p_Writer.Write(OnlyTriggerBlowEffectInWater);
			p_Writer.Write(GroundEffectOnTerrainOnly);
			p_Writer.Write(CriticalDamage);
			p_Writer.WriteNullBytes(5);
		}
	}
}
