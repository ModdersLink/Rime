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
	[ContainerType(16, 192)]
	public class LensScopeComponentData :
		ComponentData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public Vec3 ChromaticAberrationColor1 { get; set; } = new();

		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		public Vec2 RadialBlendDistanceCoefficients { get; set; } = new();

		[ContainerField(128), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		public Vec3 ChromaticAberrationColor2 { get; set; } = new();

		[ContainerField(144), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		public Vec2 BlurCenter { get; set; } = new();

		[ContainerField(152), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		public Vec2 ChromaticAberrationDisplacement2 { get; set; } = new();

		[ContainerField(160), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		public Vec2 ChromaticAberrationDisplacement1 { get; set; } = new();

		[ContainerField(168), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 168)]
		public Vec2 ChromaticAberrationStrengths { get; set; } = new();

		[ContainerField(176), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		public float BlurScale { get; set; }

		[ContainerField(180), JsonProperty(Order = 180)]
		public Realm Realm { get; set; } = new();

		[ContainerField(184), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
		public bool Enable { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			ChromaticAberrationColor1.Serialize(p_Writer, p_EbxWriter);
			RadialBlendDistanceCoefficients.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			ChromaticAberrationColor2.Serialize(p_Writer, p_EbxWriter);
			BlurCenter.Serialize(p_Writer, p_EbxWriter);
			ChromaticAberrationDisplacement2.Serialize(p_Writer, p_EbxWriter);
			ChromaticAberrationDisplacement1.Serialize(p_Writer, p_EbxWriter);
			ChromaticAberrationStrengths.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(BlurScale);
			p_Writer.Write((int) Realm);
			p_Writer.Write(Enable);
			p_Writer.WriteNullBytes(7);
		}
	}
}
