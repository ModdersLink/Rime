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
	[ContainerType(16, 224)]
	public partial class OutdoorLightComponentData :
		ComponentData
	{
		[ObservableProperty]
		[property: ContainerField(96), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private Vec3 _SunColor = new();

		[ObservableProperty]
		[property: ContainerField(112), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		private Vec2 _CloudShadowSpeed = new();

		[ObservableProperty]
		[property: ContainerField(128), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		private Vec3 _SkyColor = new();

		[ObservableProperty]
		[property: ContainerField(144), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		private Vec3 _GroundColor = new();

		[ObservableProperty]
		[property: ContainerField(160), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		private float _SunRotationY;

		[ObservableProperty]
		[property: ContainerField(164), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
		private float _SunRotationX;

		[ObservableProperty]
		[property: ContainerField(168), JsonProperty(Order = 168)]
		private Realm _Realm = new();

		[ObservableProperty]
		[property: ContainerField(172), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
		private float _SkyLightAngleFactor;

		[ObservableProperty]
		[property: ContainerField(176), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		private float _SunSpecularScale;

		[ObservableProperty]
		[property: ContainerField(180), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
		private float _SkyEnvmapShadowScale;

		[ObservableProperty]
		[property: ContainerField(184), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
		private float _SunShadowHeightScale;

		[ObservableProperty]
		[property: ContainerField(188), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
		private float _CloudShadowCoverage;

		[ObservableProperty]
		[property: ContainerField(192), JsonProperty(Order = 192)]
		private CtrRef<TextureAsset> _CloudShadowTexture = new();

		[ObservableProperty]
		[property: ContainerField(196), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
		private float _TranslucencyDistortion;

		[ObservableProperty]
		[property: ContainerField(200), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
		private float _CloudShadowSize;

		[ObservableProperty]
		[property: ContainerField(204), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
		private float _TranslucencyAmbient;

		[ObservableProperty]
		[property: ContainerField(208), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
		private float _CloudShadowExponent;

		[ObservableProperty]
		[property: ContainerField(212), LayoutImmutable, Blittable, JsonProperty(Order = 212)]
		private float _TranslucencyScale;

		[ObservableProperty]
		[property: ContainerField(216), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
		private float _TranslucencyPower;

		[ObservableProperty]
		[property: ContainerField(220), LayoutImmutable, Blittable, JsonProperty(Order = 220)]
		private bool _Enable;

		[ObservableProperty]
		[property: ContainerField(221), LayoutImmutable, Blittable, JsonProperty(Order = 221)]
		private bool _CloudShadowEnable;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			SunColor.Serialize(p_Writer, p_EbxWriter);
			CloudShadowSpeed.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			SkyColor.Serialize(p_Writer, p_EbxWriter);
			GroundColor.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(SunRotationY);
			p_Writer.Write(SunRotationX);
			p_Writer.Write((int) Realm);
			p_Writer.Write(SkyLightAngleFactor);
			p_Writer.Write(SunSpecularScale);
			p_Writer.Write(SkyEnvmapShadowScale);
			p_Writer.Write(SunShadowHeightScale);
			p_Writer.Write(CloudShadowCoverage);
			p_Writer.Write(p_EbxWriter.WriteImport(CloudShadowTexture));
			p_Writer.Write(TranslucencyDistortion);
			p_Writer.Write(CloudShadowSize);
			p_Writer.Write(TranslucencyAmbient);
			p_Writer.Write(CloudShadowExponent);
			p_Writer.Write(TranslucencyScale);
			p_Writer.Write(TranslucencyPower);
			p_Writer.Write(Enable);
			p_Writer.Write(CloudShadowEnable);
			p_Writer.WriteNullBytes(2);
		}
	}
}
