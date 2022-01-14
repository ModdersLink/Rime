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
	[ContainerType(4, 72)]
	public class UIPostProcessComponentData :
		UIComponentData
	{
		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public float HighlightThreshold { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public float XPower { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public float YPower { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public float Distort { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public float TimeScale { get; set; }

		[ContainerField(48), JsonProperty(Order = 48)]
		public CtrRef<TextureAsset> NoiseTexture { get; set; } = new();

		[ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		public float Highlight { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		public float RShift { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		public float GShift { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		public float BShift { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		public bool TweakMode { get; set; }

		[ContainerField(69), LayoutImmutable, Blittable, JsonProperty(Order = 69)]
		public bool Enabled { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(HighlightThreshold);
			p_Writer.Write(XPower);
			p_Writer.Write(YPower);
			p_Writer.Write(Distort);
			p_Writer.Write(TimeScale);
			p_Writer.Write(p_EbxWriter.WriteImport(NoiseTexture));
			p_Writer.Write(Highlight);
			p_Writer.Write(RShift);
			p_Writer.Write(GShift);
			p_Writer.Write(BShift);
			p_Writer.Write(TweakMode);
			p_Writer.Write(Enabled);
			p_Writer.WriteNullBytes(2);
		}
	}
}
