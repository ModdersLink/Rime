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
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class MasterUnitSettings : 
		DataContainer
	{
		protected string m_Name = string.Empty;
		[ContainerField(8), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(2088949890)]
		public string Name { get { return m_Name; } set { if (OnPropertyChanging("MasterUnitSettings." + nameof(Name), this, m_Name, value)) m_Name = value; } } // 0x8 (8)
		
		protected CtrRef<EqualizerSettings> m_Equalizer = new CtrRef<EqualizerSettings>();
		[ContainerField(12), MemberInfoFlag(53), ContainerFieldNameHash(1319916845), ContainerCtrRef]
		public CtrRef<EqualizerSettings> Equalizer { get { return m_Equalizer; } set { if (OnPropertyChanging("MasterUnitSettings." + nameof(Equalizer), this, m_Equalizer, value)) m_Equalizer = value; } } // 0xC (12)
		
		protected CtrRef<CompressorSettings> m_Compressor = new CtrRef<CompressorSettings>();
		[ContainerField(16), MemberInfoFlag(53), ContainerFieldNameHash(2651512702), ContainerCtrRef]
		public CtrRef<CompressorSettings> Compressor { get { return m_Compressor; } set { if (OnPropertyChanging("MasterUnitSettings." + nameof(Compressor), this, m_Compressor, value)) m_Compressor = value; } } // 0x10 (16)
		
		protected float m_MasterVolume = new float();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2602803985)]
		public float MasterVolume { get { return m_MasterVolume; } set { if (OnPropertyChanging("MasterUnitSettings." + nameof(MasterVolume), this, m_MasterVolume, value)) m_MasterVolume = value; } } // 0x14 (20)
		
		protected float m_MasterLfeGain = new float();
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3456654679)]
		public float MasterLfeGain { get { return m_MasterLfeGain; } set { if (OnPropertyChanging("MasterUnitSettings." + nameof(MasterLfeGain), this, m_MasterLfeGain, value)) m_MasterLfeGain = value; } } // 0x18 (24)
		
		protected float m_MasterDialogGain = new float();
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3075029008)]
		public float MasterDialogGain { get { return m_MasterDialogGain; } set { if (OnPropertyChanging("MasterUnitSettings." + nameof(MasterDialogGain), this, m_MasterDialogGain, value)) m_MasterDialogGain = value; } } // 0x1C (28)
		
		protected float m_ReverbVolume = new float();
		[ContainerField(32), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2647402425)]
		public float ReverbVolume { get { return m_ReverbVolume; } set { if (OnPropertyChanging("MasterUnitSettings." + nameof(ReverbVolume), this, m_ReverbVolume, value)) m_ReverbVolume = value; } } // 0x20 (32)
		
		protected float m_MainMixVolume = new float();
		[ContainerField(36), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(592568858)]
		public float MainMixVolume { get { return m_MainMixVolume; } set { if (OnPropertyChanging("MasterUnitSettings." + nameof(MainMixVolume), this, m_MainMixVolume, value)) m_MainMixVolume = value; } } // 0x24 (36)
		
		protected float m_DistortionClipLevel = new float();
		[ContainerField(40), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3542291182)]
		public float DistortionClipLevel { get { return m_DistortionClipLevel; } set { if (OnPropertyChanging("MasterUnitSettings." + nameof(DistortionClipLevel), this, m_DistortionClipLevel, value)) m_DistortionClipLevel = value; } } // 0x28 (40)
		
		protected float m_ParallelDistortionGain = new float();
		[ContainerField(44), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2605372900)]
		public float ParallelDistortionGain { get { return m_ParallelDistortionGain; } set { if (OnPropertyChanging("MasterUnitSettings." + nameof(ParallelDistortionGain), this, m_ParallelDistortionGain, value)) m_ParallelDistortionGain = value; } } // 0x2C (44)
		
		protected float m_PostEffectsGain = new float();
		[ContainerField(48), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(974497912)]
		public float PostEffectsGain { get { return m_PostEffectsGain; } set { if (OnPropertyChanging("MasterUnitSettings." + nameof(PostEffectsGain), this, m_PostEffectsGain, value)) m_PostEffectsGain = value; } } // 0x30 (48)
		
		protected float m_FadeTime = new float();
		[ContainerField(52), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(4001222838)]
		public float FadeTime { get { return m_FadeTime; } set { if (OnPropertyChanging("MasterUnitSettings." + nameof(FadeTime), this, m_FadeTime, value)) m_FadeTime = value; } } // 0x34 (52)
		
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
