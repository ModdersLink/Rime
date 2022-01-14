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
	[ContainerType(4, 56)]
	public class MasterUnitSettings :
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, JsonProperty(Order = 8)]
		public string Name { get; set; } = string.Empty;

		[ContainerField(12), JsonProperty(Order = 12)]
		public CtrRef<EqualizerSettings> Equalizer { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public CtrRef<CompressorSettings> Compressor { get; set; } = new();

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public float MasterVolume { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public float MasterLfeGain { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public float MasterDialogGain { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public float ReverbVolume { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public float MainMixVolume { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public float DistortionClipLevel { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public float ParallelDistortionGain { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public float PostEffectsGain { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		public float FadeTime { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(Name));
			p_Writer.Write(p_EbxWriter.WriteImport(Equalizer));
			p_Writer.Write(p_EbxWriter.WriteImport(Compressor));
			p_Writer.Write(MasterVolume);
			p_Writer.Write(MasterLfeGain);
			p_Writer.Write(MasterDialogGain);
			p_Writer.Write(ReverbVolume);
			p_Writer.Write(MainMixVolume);
			p_Writer.Write(DistortionClipLevel);
			p_Writer.Write(ParallelDistortionGain);
			p_Writer.Write(PostEffectsGain);
			p_Writer.Write(FadeTime);
		}
	}
}
