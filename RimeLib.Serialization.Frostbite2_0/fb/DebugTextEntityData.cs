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
	public class DebugTextEntityData :
		SpatialEntityData
	{
		[ContainerField(80), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		public Vec3 TextColor { get; set; } = new();

		[ContainerField(96), LayoutImmutable, JsonProperty(Order = 96)]
		public string DebugText { get; set; } = string.Empty;

		[ContainerField(100), JsonProperty(Order = 100)]
		public Realm Realm { get; set; } = new();

		[ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		public float Scale { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		public bool Visible { get; set; }

		[ContainerField(109), LayoutImmutable, Blittable, JsonProperty(Order = 109)]
		public bool Centered { get; set; }

		[ContainerField(110), LayoutImmutable, Blittable, JsonProperty(Order = 110)]
		public bool DepthTest { get; set; }

		[ContainerField(111), LayoutImmutable, Blittable, JsonProperty(Order = 111)]
		public bool ScaleWithDistance { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			TextColor.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(DebugText));
			p_Writer.Write((int) Realm);
			p_Writer.Write(Scale);
			p_Writer.Write(Visible);
			p_Writer.Write(Centered);
			p_Writer.Write(DepthTest);
			p_Writer.Write(ScaleWithDistance);
		}
	}
}
