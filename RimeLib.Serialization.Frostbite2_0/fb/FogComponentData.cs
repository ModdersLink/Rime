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
	[ContainerType(16, 208)]
	public class FogComponentData :
		ComponentData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public Vec4 Curve { get; set; } = new();

		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		public Vec4 FogColorCurve { get; set; } = new();

		[ContainerField(128), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		public Vec3 FogColor { get; set; } = new();

		[ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		public float FogColorStart { get; set; }

		[ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		public float FogDistanceMultiplier { get; set; }

		[ContainerField(152), JsonProperty(Order = 152)]
		public Realm Realm { get; set; } = new();

		[ContainerField(156), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
		public float End { get; set; }

		[ContainerField(160), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		public float TransparencyFadeStart { get; set; }

		[ContainerField(164), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
		public float Start { get; set; }

		[ContainerField(168), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
		public float TransparencyFadeEnd { get; set; }

		[ContainerField(172), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
		public float FogColorEnd { get; set; }

		[ContainerField(176), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		public float TransparencyFadeClamp { get; set; }

		[ContainerField(180), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
		public float HeightFogVisibilityRange { get; set; }

		[ContainerField(184), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
		public float HeightFogAltitude { get; set; }

		[ContainerField(188), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
		public float HeightFogDepth { get; set; }

		[ContainerField(192), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
		public float HeightFogFollowCamera { get; set; }

		[ContainerField(196), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
		public bool FogGradientEnable { get; set; }

		[ContainerField(197), LayoutImmutable, Blittable, JsonProperty(Order = 197)]
		public bool Enable { get; set; }

		[ContainerField(198), LayoutImmutable, Blittable, JsonProperty(Order = 198)]
		public bool HeightFogEnable { get; set; }

		[ContainerField(199), LayoutImmutable, Blittable, JsonProperty(Order = 199)]
		public bool FogColorEnable { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			Curve.Serialize(p_Writer, p_EbxWriter);
			FogColorCurve.Serialize(p_Writer, p_EbxWriter);
			FogColor.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(FogColorStart);
			p_Writer.Write(FogDistanceMultiplier);
			p_Writer.Write((int) Realm);
			p_Writer.Write(End);
			p_Writer.Write(TransparencyFadeStart);
			p_Writer.Write(Start);
			p_Writer.Write(TransparencyFadeEnd);
			p_Writer.Write(FogColorEnd);
			p_Writer.Write(TransparencyFadeClamp);
			p_Writer.Write(HeightFogVisibilityRange);
			p_Writer.Write(HeightFogAltitude);
			p_Writer.Write(HeightFogDepth);
			p_Writer.Write(HeightFogFollowCamera);
			p_Writer.Write(FogGradientEnable);
			p_Writer.Write(Enable);
			p_Writer.Write(HeightFogEnable);
			p_Writer.Write(FogColorEnable);
			p_Writer.WriteNullBytes(8);
		}
	}
}
