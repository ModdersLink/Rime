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
	[ContainerType(16, 224)]
	public class EnlightenComponentData :
		ComponentData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public Vec3 SkyBoxSkyColor { get; set; } = new();

		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		public Vec3 SkyBoxBackLightColor { get; set; } = new();

		[ContainerField(128), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		public Vec3 SkyBoxGroundColor { get; set; } = new();

		[ContainerField(144), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		public Vec3 TerrainColor { get; set; } = new();

		[ContainerField(160), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		public Vec3 SkyBoxSunLightColor { get; set; } = new();

		[ContainerField(176), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		public float BounceScale { get; set; }

		[ContainerField(180), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
		public float CullDistance { get; set; }

		[ContainerField(184), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
		public float SunScale { get; set; }

		[ContainerField(188), JsonProperty(Order = 188)]
		public Realm Realm { get; set; } = new();

		[ContainerField(192), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
		public float SkyBoxBackLightRotationY { get; set; }

		[ContainerField(196), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
		public float SkyBoxSunLightColorSize { get; set; }

		[ContainerField(200), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
		public float SkyBoxBackLightColorSize { get; set; }

		[ContainerField(204), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
		public float SkyBoxBackLightRotationX { get; set; }

		[ContainerField(208), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
		public bool SkyBoxEnable { get; set; }

		[ContainerField(209), LayoutImmutable, Blittable, JsonProperty(Order = 209)]
		public bool Enable { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			SkyBoxSkyColor.Serialize(p_Writer, p_EbxWriter);
			SkyBoxBackLightColor.Serialize(p_Writer, p_EbxWriter);
			SkyBoxGroundColor.Serialize(p_Writer, p_EbxWriter);
			TerrainColor.Serialize(p_Writer, p_EbxWriter);
			SkyBoxSunLightColor.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(BounceScale);
			p_Writer.Write(CullDistance);
			p_Writer.Write(SunScale);
			p_Writer.Write((int) Realm);
			p_Writer.Write(SkyBoxBackLightRotationY);
			p_Writer.Write(SkyBoxSunLightColorSize);
			p_Writer.Write(SkyBoxBackLightColorSize);
			p_Writer.Write(SkyBoxBackLightRotationX);
			p_Writer.Write(SkyBoxEnable);
			p_Writer.Write(Enable);
			p_Writer.WriteNullBytes(14);
		}
	}
}
