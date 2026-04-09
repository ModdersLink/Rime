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
	[ContainerType(16, 112)]
	public partial class OutdoorLightEffectState :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private Vec3 _SkyColor = new();

		[ObservableProperty]
		[property: ContainerField(32), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private Vec3 _GroundColor = new();

		[ObservableProperty]
		[property: ContainerField(48), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private Vec3 _SunColor = new();

		[ObservableProperty]
		[property: ContainerField(64), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		private Vec2 _CloudShadowSpeed = new();

		[ObservableProperty]
		[property: ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		private float _SunRotationX;

		[ObservableProperty]
		[property: ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		private float _SunRotationY;

		[ObservableProperty]
		[property: ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		private float _SkyLightAngleFactor;

		[ObservableProperty]
		[property: ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		private float _SunShadowHeightScale;

		[ObservableProperty]
		[property: ContainerField(88), JsonProperty(Order = 88)]
		private CtrRef<TextureAsset> _CloudShadowTexture = new();

		[ObservableProperty]
		[property: ContainerField(92), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
		private float _CloudShadowSize;

		[ObservableProperty]
		[property: ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private float _CloudShadowExponent;

		[ObservableProperty]
		[property: ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		private float _CloudShadowCoverage;

		[ObservableProperty]
		[property: ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		private bool _CloudShadowEnable;

		[ObservableProperty]
		[property: ContainerField(105), LayoutImmutable, Blittable, JsonProperty(Order = 105)]
		private bool _Enable;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(16);
			SkyColor.Serialize(p_Writer, p_EbxWriter);
			GroundColor.Serialize(p_Writer, p_EbxWriter);
			SunColor.Serialize(p_Writer, p_EbxWriter);
			CloudShadowSpeed.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(SunRotationX);
			p_Writer.Write(SunRotationY);
			p_Writer.Write(SkyLightAngleFactor);
			p_Writer.Write(SunShadowHeightScale);
			p_Writer.Write(p_EbxWriter.WriteImport(CloudShadowTexture));
			p_Writer.Write(CloudShadowSize);
			p_Writer.Write(CloudShadowExponent);
			p_Writer.Write(CloudShadowCoverage);
			p_Writer.Write(CloudShadowEnable);
			p_Writer.Write(Enable);
			p_Writer.WriteNullBytes(6);
		}
	}
}
