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
	[ContainerType(16, 208)]
	public partial class DamageEffectComponentData :
		ComponentData
	{
		[ObservableProperty]
		[property: ContainerField(96), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private Vec4 _RightDamage = new();

		[ObservableProperty]
		[property: ContainerField(112), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		private Vec4 _TopDamage = new();

		[ObservableProperty]
		[property: ContainerField(128), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		private Vec4 _LeftDamage = new();

		[ObservableProperty]
		[property: ContainerField(144), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		private Vec4 _BottomDamage = new();

		[ObservableProperty]
		[property: ContainerField(160), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		private float _OuterFrameOpacity;

		[ObservableProperty]
		[property: ContainerField(164), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
		private float _InnerFrameOpacity;

		[ObservableProperty]
		[property: ContainerField(168), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
		private float _FrameWidth;

		[ObservableProperty]
		[property: ContainerField(172), JsonProperty(Order = 172)]
		private CtrRef<SurfaceShaderBaseAsset> _Shader = new();

		[ObservableProperty]
		[property: ContainerField(176), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		private float _StartCriticalEffectHealthThreshold;

		[ObservableProperty]
		[property: ContainerField(180), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
		private float _EndCriticalEffectHealthThreshold;

		[ObservableProperty]
		[property: ContainerField(184), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
		private float _MinDamagePercentageThreshold;

		[ObservableProperty]
		[property: ContainerField(188), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
		private float _FallofTime;

		[ObservableProperty]
		[property: ContainerField(192), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
		private float _MaxOpacityDamagePercentage;

		[ObservableProperty]
		[property: ContainerField(196), JsonProperty(Order = 196)]
		private Realm _Realm = new();

		[ObservableProperty]
		[property: ContainerField(200), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
		private bool _DebugDamage;

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
