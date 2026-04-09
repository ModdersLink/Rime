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
	[ContainerType(16, 304)]
	public partial class SkyComponentData :
		ComponentData
	{
		[ObservableProperty]
		[property: ContainerField(96), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private Vec3 _CloudLayerSunColor = new();

		[ObservableProperty]
		[property: ContainerField(112), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		private Vec3 _CloudLayer2Color = new();

		[ObservableProperty]
		[property: ContainerField(128), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		private Vec3 _CloudLayer1Color = new();

		[ObservableProperty]
		[property: ContainerField(144), JsonProperty(Order = 144)]
		private CtrRef<TextureAsset> _SkyGradientTexture = new();

		[ObservableProperty]
		[property: ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		private float _SunSize;

		[ObservableProperty]
		[property: ContainerField(152), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		private float _BrightnessScale;

		[ObservableProperty]
		[property: ContainerField(156), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
		private float _SunScale;

		[ObservableProperty]
		[property: ContainerField(160), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		private float _PanoramicUVMaxX;

		[ObservableProperty]
		[property: ContainerField(164), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
		private float _PanoramicUVMinY;

		[ObservableProperty]
		[property: ContainerField(168), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
		private float _PanoramicUVMaxY;

		[ObservableProperty]
		[property: ContainerField(172), JsonProperty(Order = 172)]
		private Realm _Realm = new();

		[ObservableProperty]
		[property: ContainerField(176), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		private float _PanoramicUVMinX;

		[ObservableProperty]
		[property: ContainerField(180), JsonProperty(Order = 180)]
		private CtrRef<TextureAsset> _PanoramicTexture = new();

		[ObservableProperty]
		[property: ContainerField(184), JsonProperty(Order = 184)]
		private CtrRef<TextureAsset> _PanoramicAlphaTexture = new();

		[ObservableProperty]
		[property: ContainerField(188), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
		private float _PanoramicTileFactor;

		[ObservableProperty]
		[property: ContainerField(192), JsonProperty(Order = 192)]
		private CtrRef<TextureAsset> _CloudLayerMaskTexture = new();

		[ObservableProperty]
		[property: ContainerField(196), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
		private float _CloudLayer1Altitude;

		[ObservableProperty]
		[property: ContainerField(200), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
		private float _CloudLayer1TileFactor;

		[ObservableProperty]
		[property: ContainerField(204), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
		private float _CloudLayer1Rotation;

		[ObservableProperty]
		[property: ContainerField(208), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
		private float _CloudLayer1Speed;

		[ObservableProperty]
		[property: ContainerField(212), LayoutImmutable, Blittable, JsonProperty(Order = 212)]
		private float _CloudLayer1SunLightIntensity;

		[ObservableProperty]
		[property: ContainerField(216), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
		private float _PanoramicRotation;

		[ObservableProperty]
		[property: ContainerField(220), LayoutImmutable, Blittable, JsonProperty(Order = 220)]
		private float _CloudLayer1AmbientLightIntensity;

		[ObservableProperty]
		[property: ContainerField(224), LayoutImmutable, Blittable, JsonProperty(Order = 224)]
		private float _CloudLayer1SunLightPower;

		[ObservableProperty]
		[property: ContainerField(228), LayoutImmutable, Blittable, JsonProperty(Order = 228)]
		private float _CloudLayer1AlphaMul;

		[ObservableProperty]
		[property: ContainerField(232), JsonProperty(Order = 232)]
		private CtrRef<TextureAsset> _CloudLayer1Texture = new();

		[ObservableProperty]
		[property: ContainerField(236), LayoutImmutable, Blittable, JsonProperty(Order = 236)]
		private float _CloudLayer2Altitude;

		[ObservableProperty]
		[property: ContainerField(240), LayoutImmutable, Blittable, JsonProperty(Order = 240)]
		private float _CloudLayer2TileFactor;

		[ObservableProperty]
		[property: ContainerField(244), LayoutImmutable, Blittable, JsonProperty(Order = 244)]
		private float _CloudLayer2Rotation;

		[ObservableProperty]
		[property: ContainerField(248), LayoutImmutable, Blittable, JsonProperty(Order = 248)]
		private float _CloudLayer2Speed;

		[ObservableProperty]
		[property: ContainerField(252), LayoutImmutable, Blittable, JsonProperty(Order = 252)]
		private float _CloudLayer2SunLightIntensity;

		[ObservableProperty]
		[property: ContainerField(256), LayoutImmutable, Blittable, JsonProperty(Order = 256)]
		private float _CloudLayer2SunLightPower;

		[ObservableProperty]
		[property: ContainerField(260), LayoutImmutable, Blittable, JsonProperty(Order = 260)]
		private float _CloudLayer2AmbientLightIntensity;

		[ObservableProperty]
		[property: ContainerField(264), LayoutImmutable, Blittable, JsonProperty(Order = 264)]
		private float _StaticEnvmapScale;

		[ObservableProperty]
		[property: ContainerField(268), LayoutImmutable, Blittable, JsonProperty(Order = 268)]
		private float _CloudLayer2AlphaMul;

		[ObservableProperty]
		[property: ContainerField(272), JsonProperty(Order = 272)]
		private CtrRef<TextureAsset> _CloudLayer2Texture = new();

		[ObservableProperty]
		[property: ContainerField(276), JsonProperty(Order = 276)]
		private CtrRef<TextureAsset> _StaticEnvmapTexture = new();

		[ObservableProperty]
		[property: ContainerField(280), LayoutImmutable, Blittable, JsonProperty(Order = 280)]
		private float _SkyVisibilityExponent;

		[ObservableProperty]
		[property: ContainerField(284), LayoutImmutable, Blittable, JsonProperty(Order = 284)]
		private float _SkyEnvmap8BitTexScale;

		[ObservableProperty]
		[property: ContainerField(288), JsonProperty(Order = 288)]
		private CtrRef<TextureAsset> _CustomEnvmapTexture = new();

		[ObservableProperty]
		[property: ContainerField(292), LayoutImmutable, Blittable, JsonProperty(Order = 292)]
		private float _CustomEnvmapScale;

		[ObservableProperty]
		[property: ContainerField(296), LayoutImmutable, Blittable, JsonProperty(Order = 296)]
		private float _CustomEnvmapAmbient;

		[ObservableProperty]
		[property: ContainerField(300), LayoutImmutable, Blittable, JsonProperty(Order = 300)]
		private bool _Enable;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			CloudLayerSunColor.Serialize(p_Writer, p_EbxWriter);
			CloudLayer2Color.Serialize(p_Writer, p_EbxWriter);
			CloudLayer1Color.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(SkyGradientTexture));
			p_Writer.Write(SunSize);
			p_Writer.Write(BrightnessScale);
			p_Writer.Write(SunScale);
			p_Writer.Write(PanoramicUVMaxX);
			p_Writer.Write(PanoramicUVMinY);
			p_Writer.Write(PanoramicUVMaxY);
			p_Writer.Write((int) Realm);
			p_Writer.Write(PanoramicUVMinX);
			p_Writer.Write(p_EbxWriter.WriteImport(PanoramicTexture));
			p_Writer.Write(p_EbxWriter.WriteImport(PanoramicAlphaTexture));
			p_Writer.Write(PanoramicTileFactor);
			p_Writer.Write(p_EbxWriter.WriteImport(CloudLayerMaskTexture));
			p_Writer.Write(CloudLayer1Altitude);
			p_Writer.Write(CloudLayer1TileFactor);
			p_Writer.Write(CloudLayer1Rotation);
			p_Writer.Write(CloudLayer1Speed);
			p_Writer.Write(CloudLayer1SunLightIntensity);
			p_Writer.Write(PanoramicRotation);
			p_Writer.Write(CloudLayer1AmbientLightIntensity);
			p_Writer.Write(CloudLayer1SunLightPower);
			p_Writer.Write(CloudLayer1AlphaMul);
			p_Writer.Write(p_EbxWriter.WriteImport(CloudLayer1Texture));
			p_Writer.Write(CloudLayer2Altitude);
			p_Writer.Write(CloudLayer2TileFactor);
			p_Writer.Write(CloudLayer2Rotation);
			p_Writer.Write(CloudLayer2Speed);
			p_Writer.Write(CloudLayer2SunLightIntensity);
			p_Writer.Write(CloudLayer2SunLightPower);
			p_Writer.Write(CloudLayer2AmbientLightIntensity);
			p_Writer.Write(StaticEnvmapScale);
			p_Writer.Write(CloudLayer2AlphaMul);
			p_Writer.Write(p_EbxWriter.WriteImport(CloudLayer2Texture));
			p_Writer.Write(p_EbxWriter.WriteImport(StaticEnvmapTexture));
			p_Writer.Write(SkyVisibilityExponent);
			p_Writer.Write(SkyEnvmap8BitTexScale);
			p_Writer.Write(p_EbxWriter.WriteImport(CustomEnvmapTexture));
			p_Writer.Write(CustomEnvmapScale);
			p_Writer.Write(CustomEnvmapAmbient);
			p_Writer.Write(Enable);
			p_Writer.WriteNullBytes(3);
		}
	}
}
