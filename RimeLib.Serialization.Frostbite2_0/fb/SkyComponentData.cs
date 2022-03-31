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
	[ContainerType(16, 304)]
	public class SkyComponentData :
		ComponentData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public Vec3 CloudLayerSunColor { get; set; } = new();

		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		public Vec3 CloudLayer2Color { get; set; } = new();

		[ContainerField(128), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		public Vec3 CloudLayer1Color { get; set; } = new();

		[ContainerField(144), JsonProperty(Order = 144)]
		public CtrRef<TextureAsset> SkyGradientTexture { get; set; } = new();

		[ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		public float SunSize { get; set; }

		[ContainerField(152), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		public float BrightnessScale { get; set; }

		[ContainerField(156), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
		public float SunScale { get; set; }

		[ContainerField(160), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		public float PanoramicUVMaxX { get; set; }

		[ContainerField(164), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
		public float PanoramicUVMinY { get; set; }

		[ContainerField(168), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
		public float PanoramicUVMaxY { get; set; }

		[ContainerField(172), JsonProperty(Order = 172)]
		public Realm Realm { get; set; } = new();

		[ContainerField(176), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		public float PanoramicUVMinX { get; set; }

		[ContainerField(180), JsonProperty(Order = 180)]
		public CtrRef<TextureAsset> PanoramicTexture { get; set; } = new();

		[ContainerField(184), JsonProperty(Order = 184)]
		public CtrRef<TextureAsset> PanoramicAlphaTexture { get; set; } = new();

		[ContainerField(188), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
		public float PanoramicTileFactor { get; set; }

		[ContainerField(192), JsonProperty(Order = 192)]
		public CtrRef<TextureAsset> CloudLayerMaskTexture { get; set; } = new();

		[ContainerField(196), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
		public float CloudLayer1Altitude { get; set; }

		[ContainerField(200), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
		public float CloudLayer1TileFactor { get; set; }

		[ContainerField(204), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
		public float CloudLayer1Rotation { get; set; }

		[ContainerField(208), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
		public float CloudLayer1Speed { get; set; }

		[ContainerField(212), LayoutImmutable, Blittable, JsonProperty(Order = 212)]
		public float CloudLayer1SunLightIntensity { get; set; }

		[ContainerField(216), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
		public float PanoramicRotation { get; set; }

		[ContainerField(220), LayoutImmutable, Blittable, JsonProperty(Order = 220)]
		public float CloudLayer1AmbientLightIntensity { get; set; }

		[ContainerField(224), LayoutImmutable, Blittable, JsonProperty(Order = 224)]
		public float CloudLayer1SunLightPower { get; set; }

		[ContainerField(228), LayoutImmutable, Blittable, JsonProperty(Order = 228)]
		public float CloudLayer1AlphaMul { get; set; }

		[ContainerField(232), JsonProperty(Order = 232)]
		public CtrRef<TextureAsset> CloudLayer1Texture { get; set; } = new();

		[ContainerField(236), LayoutImmutable, Blittable, JsonProperty(Order = 236)]
		public float CloudLayer2Altitude { get; set; }

		[ContainerField(240), LayoutImmutable, Blittable, JsonProperty(Order = 240)]
		public float CloudLayer2TileFactor { get; set; }

		[ContainerField(244), LayoutImmutable, Blittable, JsonProperty(Order = 244)]
		public float CloudLayer2Rotation { get; set; }

		[ContainerField(248), LayoutImmutable, Blittable, JsonProperty(Order = 248)]
		public float CloudLayer2Speed { get; set; }

		[ContainerField(252), LayoutImmutable, Blittable, JsonProperty(Order = 252)]
		public float CloudLayer2SunLightIntensity { get; set; }

		[ContainerField(256), LayoutImmutable, Blittable, JsonProperty(Order = 256)]
		public float CloudLayer2SunLightPower { get; set; }

		[ContainerField(260), LayoutImmutable, Blittable, JsonProperty(Order = 260)]
		public float CloudLayer2AmbientLightIntensity { get; set; }

		[ContainerField(264), LayoutImmutable, Blittable, JsonProperty(Order = 264)]
		public float StaticEnvmapScale { get; set; }

		[ContainerField(268), LayoutImmutable, Blittable, JsonProperty(Order = 268)]
		public float CloudLayer2AlphaMul { get; set; }

		[ContainerField(272), JsonProperty(Order = 272)]
		public CtrRef<TextureAsset> CloudLayer2Texture { get; set; } = new();

		[ContainerField(276), JsonProperty(Order = 276)]
		public CtrRef<TextureAsset> StaticEnvmapTexture { get; set; } = new();

		[ContainerField(280), LayoutImmutable, Blittable, JsonProperty(Order = 280)]
		public float SkyVisibilityExponent { get; set; }

		[ContainerField(284), LayoutImmutable, Blittable, JsonProperty(Order = 284)]
		public float SkyEnvmap8BitTexScale { get; set; }

		[ContainerField(288), JsonProperty(Order = 288)]
		public CtrRef<TextureAsset> CustomEnvmapTexture { get; set; } = new();

		[ContainerField(292), LayoutImmutable, Blittable, JsonProperty(Order = 292)]
		public float CustomEnvmapScale { get; set; }

		[ContainerField(296), LayoutImmutable, Blittable, JsonProperty(Order = 296)]
		public float CustomEnvmapAmbient { get; set; }

		[ContainerField(300), LayoutImmutable, Blittable, JsonProperty(Order = 300)]
		public bool Enable { get; set; }

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
