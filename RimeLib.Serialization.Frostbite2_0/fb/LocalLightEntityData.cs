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
	[ContainerType(16, 160)]
	public class LocalLightEntityData :
		SpatialEntityData
	{
		[ContainerField(80), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		public Vec3 Color { get; set; } = new();

		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public Vec3 ParticleColorScale { get; set; } = new();

		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		public Vec3 EnlightenColorScale { get; set; } = new();

		[ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		public float Radius { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		public float Intensity { get; set; }

		[ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		public float AttenuationOffset { get; set; }

		[ContainerField(140), JsonProperty(Order = 140)]
		public EnlightenColorMode EnlightenColorMode { get; set; } = new();

		[ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		public bool EnlightenEnable { get; set; }

		[ContainerField(145), LayoutImmutable, Blittable, JsonProperty(Order = 145)]
		public bool Visible { get; set; }

		[ContainerField(146), LayoutImmutable, Blittable, JsonProperty(Order = 146)]
		public bool SpecularEnable { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			Color.Serialize(p_Writer, p_EbxWriter);
			ParticleColorScale.Serialize(p_Writer, p_EbxWriter);
			EnlightenColorScale.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(Radius);
			p_Writer.Write(Intensity);
			p_Writer.Write(AttenuationOffset);
			p_Writer.Write((int) EnlightenColorMode);
			p_Writer.Write(EnlightenEnable);
			p_Writer.Write(Visible);
			p_Writer.Write(SpecularEnable);
			p_Writer.WriteNullBytes(13);
		}
	}
}
