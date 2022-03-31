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
	[ContainerType(16, 80)]
	public class SampleTextureData :
		EvaluatorData
	{
		[ContainerField(12), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public Vec2 TextureDimensions { get; set; } = new();

		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public Vec3 ColorIntensityMax { get; set; } = new();

		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public Vec3 ColorIntensityMin { get; set; } = new();

		[ContainerField(64), JsonProperty(Order = 64)]
		public List<Vec4> GradientData { get; set; } = new();

		[ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		public float TextureOriginU { get; set; }

		[ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		public float TextureOriginV { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			TextureDimensions.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(12);
			ColorIntensityMax.Serialize(p_Writer, p_EbxWriter);
			ColorIntensityMin.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_GradientData = p_EbxWriter.GetArrayWriter(GradientData.GetType(), GradientData.Count);
			p_Writer.Write(s_GradientData.ArrayIndex);
			foreach (var s_Entry in GradientData)
			{
				s_Entry.Serialize(s_GradientData.Writer, p_EbxWriter);
			}
			p_Writer.Write(TextureOriginU);
			p_Writer.Write(TextureOriginV);
			p_Writer.WriteNullBytes(4);
		}
	}
}
