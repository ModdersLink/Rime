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
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(16, 240)]
	public class SkyEffectState :
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public Vec3 CloudLayerSunColor { get; set; } = new();

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public float PanoramicTileFactor { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public float SunSize { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public float SkyGradientScale { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public float SunScale { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public float PanoramicUVMinX { get; set; }

		[ContainerField(52), JsonProperty(Order = 52)]
		public CtrRef<TextureAsset> SkyGradientTexture { get; set; } = new();

		[ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		public float PanoramicUVMinY { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		public float PanoramicUVMaxY { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		public float PanoramicUVMaxX { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		public float PanoramicRotation { get; set; }

		[ContainerField(72), JsonProperty(Order = 72)]
		public CtrRef<TextureAsset> PanoramicTexture { get; set; } = new();

		[ContainerField(76), JsonProperty(Order = 76)]
		public CtrRef<TextureAsset> PanoramicAlphaTexture { get; set; } = new();

		[ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		public float WindDirection { get; set; }

		[ContainerField(84), JsonProperty(Order = 84)]
		public CtrRef<TextureAsset> CloudLayerMaskTexture { get; set; } = new();

		[ContainerField(96), JsonProperty(Order = 96)]
		public SkyCloudLayer CloudLayer1 { get; set; } = new();

		[ContainerField(160), JsonProperty(Order = 160)]
		public SkyCloudLayer CloudLayer2 { get; set; } = new();

		[ContainerField(224), JsonProperty(Order = 224)]
		public CtrRef<TextureAsset> StaticEnvmapTexture { get; set; } = new();

		[ContainerField(228), LayoutImmutable, Blittable, JsonProperty(Order = 228)]
		public bool Enable { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
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
