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
	[ContainerType(16, 160)]
	public class ColorCorrectionComponentData :
		ComponentData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public Vec3 Contrast { get; set; } = new();

		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		public Vec3 Saturation { get; set; } = new();

		[ContainerField(128), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		public Vec3 Brightness { get; set; } = new();

		[ContainerField(144), JsonProperty(Order = 144)]
		public Realm Realm { get; set; } = new();

		[ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		public float Hue { get; set; }

		[ContainerField(152), JsonProperty(Order = 152)]
		public CtrRef<TextureAsset> ColorGradingTexture { get; set; } = new();

		[ContainerField(156), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
		public bool ColorGradingEnable { get; set; }

		[ContainerField(157), LayoutImmutable, Blittable, JsonProperty(Order = 157)]
		public bool Enable { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			Contrast.Serialize(p_Writer, p_EbxWriter);
			Saturation.Serialize(p_Writer, p_EbxWriter);
			Brightness.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) Realm);
			p_Writer.Write(Hue);
			p_Writer.Write(p_EbxWriter.WriteImport(ColorGradingTexture));
			p_Writer.Write(ColorGradingEnable);
			p_Writer.Write(Enable);
			p_Writer.WriteNullBytes(2);
		}
	}
}
