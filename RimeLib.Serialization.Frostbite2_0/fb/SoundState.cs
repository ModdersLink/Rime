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
	[ContainerType(4, 44)]
	public class SoundState :
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, JsonProperty(Order = 8)]
		public string Name { get; set; } = string.Empty;

		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public float LpCutoffFrequency { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public float Duration { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public float FadeInTime { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public float FadeOutTime { get; set; }

		[ContainerField(28), JsonProperty(Order = 28)]
		public CtrRef<SoundAsset> BypassSound { get; set; } = new();

		[ContainerField(32), JsonProperty(Order = 32)]
		public CtrRef<HdrSetting> HdrSetting { get; set; } = new();

		[ContainerField(36), JsonProperty(Order = 36)]
		public CtrRef<MixerAsset> Mixer { get; set; } = new();

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public bool FadeSound { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(Name));
			p_Writer.Write(LpCutoffFrequency);
			p_Writer.Write(Duration);
			p_Writer.Write(FadeInTime);
			p_Writer.Write(FadeOutTime);
			p_Writer.Write(p_EbxWriter.WriteImport(BypassSound));
			p_Writer.Write(p_EbxWriter.WriteImport(HdrSetting));
			p_Writer.Write(p_EbxWriter.WriteImport(Mixer));
			p_Writer.Write(FadeSound);
			p_Writer.WriteNullBytes(3);
		}
	}
}
