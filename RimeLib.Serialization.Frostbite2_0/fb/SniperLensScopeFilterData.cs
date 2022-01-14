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
	public class SniperLensScopeFilterData :
		ScopeFilterData
	{
		[ContainerField(12), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public Vec2 ChromaticAberrationStrengths { get; set; } = new();

		[ContainerField(20), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public Vec2 BlurCenter { get; set; } = new();

		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public Vec3 ChromaticAberrationColor1 { get; set; } = new();

		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public Vec3 ChromaticAberrationColor2 { get; set; } = new();

		[ContainerField(64), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		public Vec2 RadialBlendDistanceCoefficients { get; set; } = new();

		[ContainerField(72), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		public Vec2 ChromaticAberrationDisplacement1 { get; set; } = new();

		[ContainerField(80), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		public Vec2 ChromaticAberrationDisplacement2 { get; set; } = new();

		[ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		public float BlurScale { get; set; }

		[ContainerField(96), JsonProperty(Order = 96)]
		public ColorTintData ColorTintData { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			ChromaticAberrationStrengths.Serialize(p_Writer, p_EbxWriter);
			BlurCenter.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(4);
			ChromaticAberrationColor1.Serialize(p_Writer, p_EbxWriter);
			ChromaticAberrationColor2.Serialize(p_Writer, p_EbxWriter);
			RadialBlendDistanceCoefficients.Serialize(p_Writer, p_EbxWriter);
			ChromaticAberrationDisplacement1.Serialize(p_Writer, p_EbxWriter);
			ChromaticAberrationDisplacement2.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(BlurScale);
			p_Writer.WriteNullBytes(4);
			ColorTintData.Serialize(p_Writer, p_EbxWriter);
		}
	}
}
