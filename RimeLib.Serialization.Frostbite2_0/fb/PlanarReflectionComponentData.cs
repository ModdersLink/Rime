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
	[ContainerType(16, 128)]
	public class PlanarReflectionComponentData :
		ComponentData
	{
		[ContainerField(96), JsonProperty(Order = 96)]
		public BlurFilter VerticalBlurFilter { get; set; } = new();

		[ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		public float HorizontalDeviation { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		public float GroundHeight { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		public float VerticalDeviation { get; set; }

		[ContainerField(112), JsonProperty(Order = 112)]
		public BlurFilter HorizontalBlurFilter { get; set; } = new();

		[ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		public bool SkyRenderEnable { get; set; }

		[ContainerField(117), LayoutImmutable, Blittable, JsonProperty(Order = 117)]
		public bool Enable { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) VerticalBlurFilter);
			p_Writer.Write(HorizontalDeviation);
			p_Writer.Write(GroundHeight);
			p_Writer.Write(VerticalDeviation);
			p_Writer.Write((int) HorizontalBlurFilter);
			p_Writer.Write(SkyRenderEnable);
			p_Writer.Write(Enable);
			p_Writer.WriteNullBytes(10);
		}
	}
}
