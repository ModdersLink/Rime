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
	[ContainerType(16, 112)]
	public class OutdoorLightEffectState :
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public Vec3 SkyColor { get; set; } = new();

		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public Vec3 GroundColor { get; set; } = new();

		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public Vec3 SunColor { get; set; } = new();

		[ContainerField(64), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		public Vec2 CloudShadowSpeed { get; set; } = new();

		[ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		public float SunRotationX { get; set; }

		[ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		public float SunRotationY { get; set; }

		[ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		public float SkyLightAngleFactor { get; set; }

		[ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		public float SunShadowHeightScale { get; set; }

		[ContainerField(88), JsonProperty(Order = 88)]
		public CtrRef<TextureAsset> CloudShadowTexture { get; set; } = new();

		[ContainerField(92), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
		public float CloudShadowSize { get; set; }

		[ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public float CloudShadowExponent { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		public float CloudShadowCoverage { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		public bool CloudShadowEnable { get; set; }

		[ContainerField(105), LayoutImmutable, Blittable, JsonProperty(Order = 105)]
		public bool Enable { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
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
