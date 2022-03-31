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
	[ContainerType(16, 144)]
	public class RotorComponentData :
		ComponentData
	{
		[ContainerField(96), JsonProperty(Order = 96)]
		public RotorModelData LowRpmModel { get; set; } = new();

		[ContainerField(104), JsonProperty(Order = 104)]
		public RotorModelData HighRpmModel { get; set; } = new();

		[ContainerField(112), JsonProperty(Order = 112)]
		public RotationAxis RotationAxis { get; set; } = new();

		[ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		public float RotationMultiplier { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		public float ChangeModelRpm { get; set; }

		[ContainerField(124), JsonProperty(Order = 124)]
		public CtrRef<EffectBlueprint> BlowEffect { get; set; } = new();

		[ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		public float TriggerGroundEffectHeight { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		public float CriticallyDamagedRotationForce { get; set; }

		[ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		public bool OnlyTriggerBlowEffectInWater { get; set; }

		[ContainerField(137), LayoutImmutable, Blittable, JsonProperty(Order = 137)]
		public bool GroundEffectOnTerrainOnly { get; set; }

		[ContainerField(138), LayoutImmutable, Blittable, JsonProperty(Order = 138)]
		public bool CriticalDamage { get; set; }

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
