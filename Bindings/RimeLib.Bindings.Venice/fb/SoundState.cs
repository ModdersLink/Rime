///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 44)]
	public class SoundState : 
		DataContainer
	{
		protected string m_Name = string.Empty;
		[ContainerField(Name: "Name", Offset: 8, NameHash: 2088949890, Flags: 16509), LayoutImmutable]
		public string Name { get { return m_Name; } set { if (OnPropertyChanging("SoundState." + nameof(Name), this, m_Name, value)) m_Name = value; } } // 0x8 (8)
		
		protected float m_LpCutoffFrequency = new float();
		[ContainerField(Name: "LpCutoffFrequency", Offset: 12, NameHash: 414264080, Flags: 49469), LayoutImmutable, Blittable]
		public float LpCutoffFrequency { get { return m_LpCutoffFrequency; } set { if (OnPropertyChanging("SoundState." + nameof(LpCutoffFrequency), this, m_LpCutoffFrequency, value)) m_LpCutoffFrequency = value; } } // 0xC (12)
		
		protected float m_Duration = new float();
		[ContainerField(Name: "Duration", Offset: 16, NameHash: 1828507227, Flags: 49469), LayoutImmutable, Blittable]
		public float Duration { get { return m_Duration; } set { if (OnPropertyChanging("SoundState." + nameof(Duration), this, m_Duration, value)) m_Duration = value; } } // 0x10 (16)
		
		protected float m_FadeInTime = new float();
		[ContainerField(Name: "FadeInTime", Offset: 20, NameHash: 1781703921, Flags: 49469), LayoutImmutable, Blittable]
		public float FadeInTime { get { return m_FadeInTime; } set { if (OnPropertyChanging("SoundState." + nameof(FadeInTime), this, m_FadeInTime, value)) m_FadeInTime = value; } } // 0x14 (20)
		
		protected float m_FadeOutTime = new float();
		[ContainerField(Name: "FadeOutTime", Offset: 24, NameHash: 1285109176, Flags: 49469), LayoutImmutable, Blittable]
		public float FadeOutTime { get { return m_FadeOutTime; } set { if (OnPropertyChanging("SoundState." + nameof(FadeOutTime), this, m_FadeOutTime, value)) m_FadeOutTime = value; } } // 0x18 (24)
		
		protected CtrRef<SoundAsset> m_BypassSound = new CtrRef<SoundAsset>();
		[ContainerField(Name: "BypassSound", Offset: 28, NameHash: 1531107980, Flags: 53)]
		public CtrRef<SoundAsset> BypassSound { get { return m_BypassSound; } set { if (OnPropertyChanging("SoundState." + nameof(BypassSound), this, m_BypassSound, value)) m_BypassSound = value; } } // 0x1C (28)
		
		protected CtrRef<HdrSetting> m_HdrSetting = new CtrRef<HdrSetting>();
		[ContainerField(Name: "HdrSetting", Offset: 32, NameHash: 1761163949, Flags: 53)]
		public CtrRef<HdrSetting> HdrSetting { get { return m_HdrSetting; } set { if (OnPropertyChanging("SoundState." + nameof(HdrSetting), this, m_HdrSetting, value)) m_HdrSetting = value; } } // 0x20 (32)
		
		protected CtrRef<MixerAsset> m_Mixer = new CtrRef<MixerAsset>();
		[ContainerField(Name: "Mixer", Offset: 36, NameHash: 209965422, Flags: 53)]
		public CtrRef<MixerAsset> Mixer { get { return m_Mixer; } set { if (OnPropertyChanging("SoundState." + nameof(Mixer), this, m_Mixer, value)) m_Mixer = value; } } // 0x24 (36)
		
		protected bool m_FadeSound = new bool();
		[ContainerField(Name: "FadeSound", Offset: 40, NameHash: 3181011744, Flags: 49325), LayoutImmutable, Blittable]
		public bool FadeSound { get { return m_FadeSound; } set { if (OnPropertyChanging("SoundState." + nameof(FadeSound), this, m_FadeSound, value)) m_FadeSound = value; } } // 0x28 (40)
		
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
