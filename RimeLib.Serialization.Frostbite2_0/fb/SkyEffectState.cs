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
	[ContainerType(16, 240)]
	public partial class SkyEffectState :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private Vec3 _CloudLayerSunColor = new();

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private float _PanoramicTileFactor;

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private float _SunSize;

		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private float _SkyGradientScale;

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private float _SunScale;

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private float _PanoramicUVMinX;

		[ObservableProperty]
		[property: ContainerField(52), JsonProperty(Order = 52)]
		private CtrRef<TextureAsset> _SkyGradientTexture = new();

		[ObservableProperty]
		[property: ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		private float _PanoramicUVMinY;

		[ObservableProperty]
		[property: ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		private float _PanoramicUVMaxY;

		[ObservableProperty]
		[property: ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		private float _PanoramicUVMaxX;

		[ObservableProperty]
		[property: ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		private float _PanoramicRotation;

		[ObservableProperty]
		[property: ContainerField(72), JsonProperty(Order = 72)]
		private CtrRef<TextureAsset> _PanoramicTexture = new();

		[ObservableProperty]
		[property: ContainerField(76), JsonProperty(Order = 76)]
		private CtrRef<TextureAsset> _PanoramicAlphaTexture = new();

		[ObservableProperty]
		[property: ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		private float _WindDirection;

		[ObservableProperty]
		[property: ContainerField(84), JsonProperty(Order = 84)]
		private CtrRef<TextureAsset> _CloudLayerMaskTexture = new();

		[ObservableProperty]
		[property: ContainerField(96), JsonProperty(Order = 96)]
		private SkyCloudLayer _CloudLayer1 = new();

		[ObservableProperty]
		[property: ContainerField(160), JsonProperty(Order = 160)]
		private SkyCloudLayer _CloudLayer2 = new();

		[ObservableProperty]
		[property: ContainerField(224), JsonProperty(Order = 224)]
		private CtrRef<TextureAsset> _StaticEnvmapTexture = new();

		[ObservableProperty]
		[property: ContainerField(228), LayoutImmutable, Blittable, JsonProperty(Order = 228)]
		private bool _Enable;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(16);
			CloudLayerSunColor.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(PanoramicTileFactor);
			p_Writer.Write(SunSize);
			p_Writer.Write(SkyGradientScale);
			p_Writer.Write(SunScale);
			p_Writer.Write(PanoramicUVMinX);
			p_Writer.Write(p_EbxWriter.WriteImport(SkyGradientTexture));
			p_Writer.Write(PanoramicUVMinY);
			p_Writer.Write(PanoramicUVMaxY);
			p_Writer.Write(PanoramicUVMaxX);
			p_Writer.Write(PanoramicRotation);
			p_Writer.Write(p_EbxWriter.WriteImport(PanoramicTexture));
			p_Writer.Write(p_EbxWriter.WriteImport(PanoramicAlphaTexture));
			p_Writer.Write(WindDirection);
			p_Writer.Write(p_EbxWriter.WriteImport(CloudLayerMaskTexture));
			p_Writer.WriteNullBytes(8);
			CloudLayer1.Serialize(p_Writer, p_EbxWriter);
			CloudLayer2.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(StaticEnvmapTexture));
			p_Writer.Write(Enable);
			p_Writer.WriteNullBytes(11);
		}
	}
}
