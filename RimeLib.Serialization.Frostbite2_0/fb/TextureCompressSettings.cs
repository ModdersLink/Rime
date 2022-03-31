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
	[ContainerType(4, 24)]
	public class TextureCompressSettings :
		DataContainer
	{
		[ContainerField(8), JsonProperty(Order = 8)]
		public TextureCompressQualityMode ViewMode { get; set; } = new();

		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public uint TextureCompressJobPoolSize { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public float DebugDrawAlphaOverlayScale { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public bool DebugDrawEnable { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) ViewMode);
			p_Writer.Write(TextureCompressJobPoolSize);
			p_Writer.Write(DebugDrawAlphaOverlayScale);
			p_Writer.Write(DebugDrawEnable);
			p_Writer.WriteNullBytes(3);
		}
	}
}
