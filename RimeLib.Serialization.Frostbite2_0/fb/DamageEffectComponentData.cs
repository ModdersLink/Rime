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
	[ContainerType(16, 208)]
	public class DamageEffectComponentData :
		ComponentData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public Vec4 RightDamage { get; set; } = new();

		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		public Vec4 TopDamage { get; set; } = new();

		[ContainerField(128), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		public Vec4 LeftDamage { get; set; } = new();

		[ContainerField(144), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		public Vec4 BottomDamage { get; set; } = new();

		[ContainerField(160), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		public float OuterFrameOpacity { get; set; }

		[ContainerField(164), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
		public float InnerFrameOpacity { get; set; }

		[ContainerField(168), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
		public float FrameWidth { get; set; }

		[ContainerField(172), JsonProperty(Order = 172)]
		public CtrRef<SurfaceShaderBaseAsset> Shader { get; set; } = new();

		[ContainerField(176), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		public float StartCriticalEffectHealthThreshold { get; set; }

		[ContainerField(180), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
		public float EndCriticalEffectHealthThreshold { get; set; }

		[ContainerField(184), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
		public float MinDamagePercentageThreshold { get; set; }

		[ContainerField(188), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
		public float FallofTime { get; set; }

		[ContainerField(192), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
		public float MaxOpacityDamagePercentage { get; set; }

		[ContainerField(196), JsonProperty(Order = 196)]
		public Realm Realm { get; set; } = new();

		[ContainerField(200), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
		public bool DebugDamage { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			RightDamage.Serialize(p_Writer, p_EbxWriter);
			TopDamage.Serialize(p_Writer, p_EbxWriter);
			LeftDamage.Serialize(p_Writer, p_EbxWriter);
			BottomDamage.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(OuterFrameOpacity);
			p_Writer.Write(InnerFrameOpacity);
			p_Writer.Write(FrameWidth);
			p_Writer.Write(p_EbxWriter.WriteImport(Shader));
			p_Writer.Write(StartCriticalEffectHealthThreshold);
			p_Writer.Write(EndCriticalEffectHealthThreshold);
			p_Writer.Write(MinDamagePercentageThreshold);
			p_Writer.Write(FallofTime);
			p_Writer.Write(MaxOpacityDamagePercentage);
			p_Writer.Write((int) Realm);
			p_Writer.Write(DebugDamage);
			p_Writer.WriteNullBytes(7);
		}
	}
}
