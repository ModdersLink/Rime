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
	[ContainerType(16, 96)]
	public class UIRenderCompData :
		UIComponentData
	{
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public Vec4 BackgroundRect1 { get; set; } = new();

		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public Vec4 BackgroundRect0 { get; set; } = new();

		[ContainerField(64), JsonProperty(Order = 64)]
		public CtrRef<TextureAsset> BgTexture2 { get; set; } = new();

		[ContainerField(68), JsonProperty(Order = 68)]
		public CtrRef<TextureAsset> BgTexture1 { get; set; } = new();

		[ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		public float AlphaMin { get; set; }

		[ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		public float AlphaAnimationSpeed { get; set; }

		[ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		public float AlphaOffset { get; set; }

		[ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		public float AlphaMax { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(4);
			BackgroundRect1.Serialize(p_Writer, p_EbxWriter);
			BackgroundRect0.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(BgTexture2));
			p_Writer.Write(p_EbxWriter.WriteImport(BgTexture1));
			p_Writer.Write(AlphaMin);
			p_Writer.Write(AlphaAnimationSpeed);
			p_Writer.Write(AlphaOffset);
			p_Writer.Write(AlphaMax);
			p_Writer.WriteNullBytes(8);
		}
	}
}
