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
	public class SoundState : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable]
		public string Name { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float LpCutoffFrequency { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float Duration { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float FadeInTime { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float FadeOutTime { get; set; } // 0x18 (24)
		
		[ContainerField(28)]
		public CtrRef<SoundAsset> BypassSound { get; set; } = new CtrRef<SoundAsset>(); // 0x1C (28)
		
		[ContainerField(32)]
		public CtrRef<HdrSetting> HdrSetting { get; set; } = new CtrRef<HdrSetting>(); // 0x20 (32)
		
		[ContainerField(36)]
		public CtrRef<MixerAsset> Mixer { get; set; } = new CtrRef<MixerAsset>(); // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public bool FadeSound { get; set; } // 0x28 (40)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088949890:
					Name = (string) p_Value;
					break;

				case 414264080:
					LpCutoffFrequency = (float) p_Value;
					break;

				case 1828507227:
					Duration = (float) p_Value;
					break;

				case 1781703921:
					FadeInTime = (float) p_Value;
					break;

				case 1285109176:
					FadeOutTime = (float) p_Value;
					break;

				case 1531107980:
					BypassSound = (CtrRef<SoundAsset>) p_Value;
					break;

				case 1761163949:
					HdrSetting = (CtrRef<HdrSetting>) p_Value;
					break;

				case 209965422:
					Mixer = (CtrRef<MixerAsset>) p_Value;
					break;

				case 3181011744:
					FadeSound = (bool) p_Value;
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

				case 414264080:
					return LpCutoffFrequency;

				case 1828507227:
					return Duration;

				case 1781703921:
					return FadeInTime;

				case 1285109176:
					return FadeOutTime;

				case 1531107980:
					return BypassSound;

				case 1761163949:
					return HdrSetting;

				case 209965422:
					return Mixer;

				case 3181011744:
					return FadeSound;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088949890:
					return typeof(SoundState).GetProperty(nameof(Name));

				case 414264080:
					return typeof(SoundState).GetProperty(nameof(LpCutoffFrequency));

				case 1828507227:
					return typeof(SoundState).GetProperty(nameof(Duration));

				case 1781703921:
					return typeof(SoundState).GetProperty(nameof(FadeInTime));

				case 1285109176:
					return typeof(SoundState).GetProperty(nameof(FadeOutTime));

				case 1531107980:
					return typeof(SoundState).GetProperty(nameof(BypassSound));

				case 1761163949:
					return typeof(SoundState).GetProperty(nameof(HdrSetting));

				case 209965422:
					return typeof(SoundState).GetProperty(nameof(Mixer));

				case 3181011744:
					return typeof(SoundState).GetProperty(nameof(FadeSound));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
