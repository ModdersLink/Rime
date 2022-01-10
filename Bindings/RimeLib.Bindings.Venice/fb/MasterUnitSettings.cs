///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 56)]
	public class MasterUnitSettings : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable]
		public string Name { get; set; } = string.Empty;

		[ContainerField(12)]
		public CtrRef<EqualizerSettings> Equalizer { get; set; } = new();

		[ContainerField(16)]
		public CtrRef<CompressorSettings> Compressor { get; set; } = new();

		[ContainerField(20), LayoutImmutable, Blittable]
		public float MasterVolume { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float MasterLfeGain { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public float MasterDialogGain { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public float ReverbVolume { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public float MainMixVolume { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public float DistortionClipLevel { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public float ParallelDistortionGain { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public float PostEffectsGain { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable]
		public float FadeTime { get; set; }

		public static void Deserialize(MasterUnitSettings p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Name = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Equalizer.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Compressor.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.MasterVolume = p_Reader.ReadSingle();
			p_Instance.MasterLfeGain = p_Reader.ReadSingle();
			p_Instance.MasterDialogGain = p_Reader.ReadSingle();
			p_Instance.ReverbVolume = p_Reader.ReadSingle();
			p_Instance.MainMixVolume = p_Reader.ReadSingle();
			p_Instance.DistortionClipLevel = p_Reader.ReadSingle();
			p_Instance.ParallelDistortionGain = p_Reader.ReadSingle();
			p_Instance.PostEffectsGain = p_Reader.ReadSingle();
			p_Instance.FadeTime = p_Reader.ReadSingle();
		}

	}
}
