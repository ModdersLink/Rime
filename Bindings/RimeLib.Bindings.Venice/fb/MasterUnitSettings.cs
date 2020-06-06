///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class MasterUnitSettings : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable]
		public string Name { get; set; } // 0x8 (8)
		
		[ContainerField(12)]
		public CtrRef<EqualizerSettings> Equalizer { get; set; } = new CtrRef<EqualizerSettings>(); // 0xC (12)
		
		[ContainerField(16)]
		public CtrRef<CompressorSettings> Compressor { get; set; } = new CtrRef<CompressorSettings>(); // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float MasterVolume { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float MasterLfeGain { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float MasterDialogGain { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float ReverbVolume { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float MainMixVolume { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public float DistortionClipLevel { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public float ParallelDistortionGain { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public float PostEffectsGain { get; set; } // 0x30 (48)
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public float FadeTime { get; set; } // 0x34 (52)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088949890:
					Name = (string) p_Value;
					break;

				case 1319916845:
					Equalizer = (CtrRef<EqualizerSettings>) p_Value;
					break;

				case 2651512702:
					Compressor = (CtrRef<CompressorSettings>) p_Value;
					break;

				case 2602803985:
					MasterVolume = (float) p_Value;
					break;

				case 3456654679:
					MasterLfeGain = (float) p_Value;
					break;

				case 3075029008:
					MasterDialogGain = (float) p_Value;
					break;

				case 2647402425:
					ReverbVolume = (float) p_Value;
					break;

				case 592568858:
					MainMixVolume = (float) p_Value;
					break;

				case 3542291182:
					DistortionClipLevel = (float) p_Value;
					break;

				case 2605372900:
					ParallelDistortionGain = (float) p_Value;
					break;

				case 974497912:
					PostEffectsGain = (float) p_Value;
					break;

				case 4001222838:
					FadeTime = (float) p_Value;
					break;

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088949890:
					return Name;

				case 1319916845:
					return Equalizer;

				case 2651512702:
					return Compressor;

				case 2602803985:
					return MasterVolume;

				case 3456654679:
					return MasterLfeGain;

				case 3075029008:
					return MasterDialogGain;

				case 2647402425:
					return ReverbVolume;

				case 592568858:
					return MainMixVolume;

				case 3542291182:
					return DistortionClipLevel;

				case 2605372900:
					return ParallelDistortionGain;

				case 974497912:
					return PostEffectsGain;

				case 4001222838:
					return FadeTime;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088949890:
					return typeof(MasterUnitSettings).GetProperty(nameof(Name));

				case 1319916845:
					return typeof(MasterUnitSettings).GetProperty(nameof(Equalizer));

				case 2651512702:
					return typeof(MasterUnitSettings).GetProperty(nameof(Compressor));

				case 2602803985:
					return typeof(MasterUnitSettings).GetProperty(nameof(MasterVolume));

				case 3456654679:
					return typeof(MasterUnitSettings).GetProperty(nameof(MasterLfeGain));

				case 3075029008:
					return typeof(MasterUnitSettings).GetProperty(nameof(MasterDialogGain));

				case 2647402425:
					return typeof(MasterUnitSettings).GetProperty(nameof(ReverbVolume));

				case 592568858:
					return typeof(MasterUnitSettings).GetProperty(nameof(MainMixVolume));

				case 3542291182:
					return typeof(MasterUnitSettings).GetProperty(nameof(DistortionClipLevel));

				case 2605372900:
					return typeof(MasterUnitSettings).GetProperty(nameof(ParallelDistortionGain));

				case 974497912:
					return typeof(MasterUnitSettings).GetProperty(nameof(PostEffectsGain));

				case 4001222838:
					return typeof(MasterUnitSettings).GetProperty(nameof(FadeTime));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
