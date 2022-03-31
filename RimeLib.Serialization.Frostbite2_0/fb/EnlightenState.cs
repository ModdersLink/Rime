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
	[ContainerType(16, 112)]
	public class EnlightenState :
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public Vec3 SkyBoxGroundColor { get; set; } = new();

		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public Vec3 SkyBoxSunLightColor { get; set; } = new();

		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public Vec3 SkyBoxBackLightColor { get; set; } = new();

		[ContainerField(64), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		public Vec3 SkyBoxSkyColor { get; set; } = new();

		[ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		public float SunScale { get; set; }

		[ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		public float OutputScale { get; set; }

		[ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		public float BounceScale { get; set; }

		[ContainerField(92), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
		public float SkyBoxSunLightColorSize { get; set; }

		[ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public float SkyBoxBackLightRotationY { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		public float SkyBoxBackLightColorSize { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		public float SkyBoxBackLightRotationX { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		public bool SkyBoxEnable { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			SkyBoxGroundColor.Serialize(p_Writer, p_EbxWriter);
			SkyBoxSunLightColor.Serialize(p_Writer, p_EbxWriter);
			SkyBoxBackLightColor.Serialize(p_Writer, p_EbxWriter);
			SkyBoxSkyColor.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(SunScale);
			p_Writer.Write(OutputScale);
			p_Writer.Write(BounceScale);
			p_Writer.Write(SkyBoxSunLightColorSize);
			p_Writer.Write(SkyBoxBackLightRotationY);
			p_Writer.Write(SkyBoxBackLightColorSize);
			p_Writer.Write(SkyBoxBackLightRotationX);
			p_Writer.Write(SkyBoxEnable);
			p_Writer.WriteNullBytes(3);
		}
	}
}
