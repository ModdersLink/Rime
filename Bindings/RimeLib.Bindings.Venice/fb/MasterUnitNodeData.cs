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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(172), ContainerClass]
	public class MasterUnitNodeData : 
		AudioGraphNodeData
	{
		protected AudioGraphNodePort m_SettingsIndex = new AudioGraphNodePort();
		[ContainerField(8), MemberInfoFlag(41), ContainerFieldNameHash(3467073726)]
		public AudioGraphNodePort SettingsIndex { get { return m_SettingsIndex; } set { if (OnPropertyChanging("MasterUnitNodeData." + nameof(SettingsIndex), this, m_SettingsIndex, value)) m_SettingsIndex = value; } } // 0x8 (8)
		
		protected AudioGraphNodePort m_Amplitude = new AudioGraphNodePort();
		[ContainerField(16), MemberInfoFlag(41), ContainerFieldNameHash(698564572)]
		public AudioGraphNodePort Amplitude { get { return m_Amplitude; } set { if (OnPropertyChanging("MasterUnitNodeData." + nameof(Amplitude), this, m_Amplitude, value)) m_Amplitude = value; } } // 0x10 (16)
		
		protected AudioGraphNodePort m_MasterGain = new AudioGraphNodePort();
		[ContainerField(24), MemberInfoFlag(41), ContainerFieldNameHash(3418201912)]
		public AudioGraphNodePort MasterGain { get { return m_MasterGain; } set { if (OnPropertyChanging("MasterUnitNodeData." + nameof(MasterGain), this, m_MasterGain, value)) m_MasterGain = value; } } // 0x18 (24)
		
		protected AudioGraphNodePort m_MasterLfeGain = new AudioGraphNodePort();
		[ContainerField(32), MemberInfoFlag(41), ContainerFieldNameHash(3456654679)]
		public AudioGraphNodePort MasterLfeGain { get { return m_MasterLfeGain; } set { if (OnPropertyChanging("MasterUnitNodeData." + nameof(MasterLfeGain), this, m_MasterLfeGain, value)) m_MasterLfeGain = value; } } // 0x20 (32)
		
		protected AudioGraphNodePort m_MasterDialogGain = new AudioGraphNodePort();
		[ContainerField(40), MemberInfoFlag(41), ContainerFieldNameHash(3075029008)]
		public AudioGraphNodePort MasterDialogGain { get { return m_MasterDialogGain; } set { if (OnPropertyChanging("MasterUnitNodeData." + nameof(MasterDialogGain), this, m_MasterDialogGain, value)) m_MasterDialogGain = value; } } // 0x28 (40)
		
		protected AudioGraphNodePort m_MainMixGain = new AudioGraphNodePort();
		[ContainerField(48), MemberInfoFlag(41), ContainerFieldNameHash(2469993203)]
		public AudioGraphNodePort MainMixGain { get { return m_MainMixGain; } set { if (OnPropertyChanging("MasterUnitNodeData." + nameof(MainMixGain), this, m_MainMixGain, value)) m_MainMixGain = value; } } // 0x30 (48)
		
		protected AudioGraphNodePort m_PostEffectsGain = new AudioGraphNodePort();
		[ContainerField(56), MemberInfoFlag(41), ContainerFieldNameHash(974497912)]
		public AudioGraphNodePort PostEffectsGain { get { return m_PostEffectsGain; } set { if (OnPropertyChanging("MasterUnitNodeData." + nameof(PostEffectsGain), this, m_PostEffectsGain, value)) m_PostEffectsGain = value; } } // 0x38 (56)
		
		protected AudioGraphNodePort m_ReverbGain = new AudioGraphNodePort();
		[ContainerField(64), MemberInfoFlag(41), ContainerFieldNameHash(622241232)]
		public AudioGraphNodePort ReverbGain { get { return m_ReverbGain; } set { if (OnPropertyChanging("MasterUnitNodeData." + nameof(ReverbGain), this, m_ReverbGain, value)) m_ReverbGain = value; } } // 0x40 (64)
		
		protected AudioGraphNodePort m_FadeTime = new AudioGraphNodePort();
		[ContainerField(72), MemberInfoFlag(41), ContainerFieldNameHash(4001222838)]
		public AudioGraphNodePort FadeTime { get { return m_FadeTime; } set { if (OnPropertyChanging("MasterUnitNodeData." + nameof(FadeTime), this, m_FadeTime, value)) m_FadeTime = value; } } // 0x48 (72)
		
		protected AudioGraphNodePort m_HighPassFreq = new AudioGraphNodePort();
		[ContainerField(80), MemberInfoFlag(41), ContainerFieldNameHash(1050320730)]
		public AudioGraphNodePort HighPassFreq { get { return m_HighPassFreq; } set { if (OnPropertyChanging("MasterUnitNodeData." + nameof(HighPassFreq), this, m_HighPassFreq, value)) m_HighPassFreq = value; } } // 0x50 (80)
		
		protected AudioGraphNodePort m_LowShelfFreq = new AudioGraphNodePort();
		[ContainerField(88), MemberInfoFlag(41), ContainerFieldNameHash(4093395621)]
		public AudioGraphNodePort LowShelfFreq { get { return m_LowShelfFreq; } set { if (OnPropertyChanging("MasterUnitNodeData." + nameof(LowShelfFreq), this, m_LowShelfFreq, value)) m_LowShelfFreq = value; } } // 0x58 (88)
		
		protected AudioGraphNodePort m_LowShelfGain = new AudioGraphNodePort();
		[ContainerField(96), MemberInfoFlag(41), ContainerFieldNameHash(4093417540)]
		public AudioGraphNodePort LowShelfGain { get { return m_LowShelfGain; } set { if (OnPropertyChanging("MasterUnitNodeData." + nameof(LowShelfGain), this, m_LowShelfGain, value)) m_LowShelfGain = value; } } // 0x60 (96)
		
		protected AudioGraphNodePort m_HighShelfFreq = new AudioGraphNodePort();
		[ContainerField(104), MemberInfoFlag(41), ContainerFieldNameHash(110900543)]
		public AudioGraphNodePort HighShelfFreq { get { return m_HighShelfFreq; } set { if (OnPropertyChanging("MasterUnitNodeData." + nameof(HighShelfFreq), this, m_HighShelfFreq, value)) m_HighShelfFreq = value; } } // 0x68 (104)
		
		protected AudioGraphNodePort m_HighShelfGain = new AudioGraphNodePort();
		[ContainerField(112), MemberInfoFlag(41), ContainerFieldNameHash(110952414)]
		public AudioGraphNodePort HighShelfGain { get { return m_HighShelfGain; } set { if (OnPropertyChanging("MasterUnitNodeData." + nameof(HighShelfGain), this, m_HighShelfGain, value)) m_HighShelfGain = value; } } // 0x70 (112)
		
		protected AudioGraphNodePort m_CompThreshold = new AudioGraphNodePort();
		[ContainerField(120), MemberInfoFlag(41), ContainerFieldNameHash(201040259)]
		public AudioGraphNodePort CompThreshold { get { return m_CompThreshold; } set { if (OnPropertyChanging("MasterUnitNodeData." + nameof(CompThreshold), this, m_CompThreshold, value)) m_CompThreshold = value; } } // 0x78 (120)
		
		protected AudioGraphNodePort m_CompRatio = new AudioGraphNodePort();
		[ContainerField(128), MemberInfoFlag(41), ContainerFieldNameHash(1938039989)]
		public AudioGraphNodePort CompRatio { get { return m_CompRatio; } set { if (OnPropertyChanging("MasterUnitNodeData." + nameof(CompRatio), this, m_CompRatio, value)) m_CompRatio = value; } } // 0x80 (128)
		
		protected AudioGraphNodePort m_CompAttack = new AudioGraphNodePort();
		[ContainerField(136), MemberInfoFlag(41), ContainerFieldNameHash(171486556)]
		public AudioGraphNodePort CompAttack { get { return m_CompAttack; } set { if (OnPropertyChanging("MasterUnitNodeData." + nameof(CompAttack), this, m_CompAttack, value)) m_CompAttack = value; } } // 0x88 (136)
		
		protected AudioGraphNodePort m_CompRelease = new AudioGraphNodePort();
		[ContainerField(144), MemberInfoFlag(41), ContainerFieldNameHash(1539642909)]
		public AudioGraphNodePort CompRelease { get { return m_CompRelease; } set { if (OnPropertyChanging("MasterUnitNodeData." + nameof(CompRelease), this, m_CompRelease, value)) m_CompRelease = value; } } // 0x90 (144)
		
		protected AudioGraphNodePort m_DistClipLevel = new AudioGraphNodePort();
		[ContainerField(152), MemberInfoFlag(41), ContainerFieldNameHash(3419995663)]
		public AudioGraphNodePort DistClipLevel { get { return m_DistClipLevel; } set { if (OnPropertyChanging("MasterUnitNodeData." + nameof(DistClipLevel), this, m_DistClipLevel, value)) m_DistClipLevel = value; } } // 0x98 (152)
		
		protected AudioGraphNodePort m_ParallelDistortionGain = new AudioGraphNodePort();
		[ContainerField(160), MemberInfoFlag(41), ContainerFieldNameHash(2605372900)]
		public AudioGraphNodePort ParallelDistortionGain { get { return m_ParallelDistortionGain; } set { if (OnPropertyChanging("MasterUnitNodeData." + nameof(ParallelDistortionGain), this, m_ParallelDistortionGain, value)) m_ParallelDistortionGain = value; } } // 0xA0 (160)
		
		protected RefArray<MasterUnitSettings> m_Settings = new RefArray<MasterUnitSettings>();
		[ContainerField(168), MemberInfoFlag(65), ContainerFieldNameHash(649772672), ContainerRefArray]
		public RefArray<MasterUnitSettings> Settings { get { return m_Settings; } set { if (OnPropertyChanging("MasterUnitNodeData." + nameof(Settings), this, m_Settings, value)) m_Settings = value; } } // 0xA8 (168)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3467073726:
					SettingsIndex = (AudioGraphNodePort) p_Value;
					break;

				case 698564572:
					Amplitude = (AudioGraphNodePort) p_Value;
					break;

				case 3418201912:
					MasterGain = (AudioGraphNodePort) p_Value;
					break;

				case 3456654679:
					MasterLfeGain = (AudioGraphNodePort) p_Value;
					break;

				case 3075029008:
					MasterDialogGain = (AudioGraphNodePort) p_Value;
					break;

				case 2469993203:
					MainMixGain = (AudioGraphNodePort) p_Value;
					break;

				case 974497912:
					PostEffectsGain = (AudioGraphNodePort) p_Value;
					break;

				case 622241232:
					ReverbGain = (AudioGraphNodePort) p_Value;
					break;

				case 4001222838:
					FadeTime = (AudioGraphNodePort) p_Value;
					break;

				case 1050320730:
					HighPassFreq = (AudioGraphNodePort) p_Value;
					break;

				case 4093395621:
					LowShelfFreq = (AudioGraphNodePort) p_Value;
					break;

				case 4093417540:
					LowShelfGain = (AudioGraphNodePort) p_Value;
					break;

				case 110900543:
					HighShelfFreq = (AudioGraphNodePort) p_Value;
					break;

				case 110952414:
					HighShelfGain = (AudioGraphNodePort) p_Value;
					break;

				case 201040259:
					CompThreshold = (AudioGraphNodePort) p_Value;
					break;

				case 1938039989:
					CompRatio = (AudioGraphNodePort) p_Value;
					break;

				case 171486556:
					CompAttack = (AudioGraphNodePort) p_Value;
					break;

				case 1539642909:
					CompRelease = (AudioGraphNodePort) p_Value;
					break;

				case 3419995663:
					DistClipLevel = (AudioGraphNodePort) p_Value;
					break;

				case 2605372900:
					ParallelDistortionGain = (AudioGraphNodePort) p_Value;
					break;

				case 649772672:
					Settings = (RefArray<MasterUnitSettings>) p_Value;
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
				case 3467073726:
					return SettingsIndex;

				case 698564572:
					return Amplitude;

				case 3418201912:
					return MasterGain;

				case 3456654679:
					return MasterLfeGain;

				case 3075029008:
					return MasterDialogGain;

				case 2469993203:
					return MainMixGain;

				case 974497912:
					return PostEffectsGain;

				case 622241232:
					return ReverbGain;

				case 4001222838:
					return FadeTime;

				case 1050320730:
					return HighPassFreq;

				case 4093395621:
					return LowShelfFreq;

				case 4093417540:
					return LowShelfGain;

				case 110900543:
					return HighShelfFreq;

				case 110952414:
					return HighShelfGain;

				case 201040259:
					return CompThreshold;

				case 1938039989:
					return CompRatio;

				case 171486556:
					return CompAttack;

				case 1539642909:
					return CompRelease;

				case 3419995663:
					return DistClipLevel;

				case 2605372900:
					return ParallelDistortionGain;

				case 649772672:
					return Settings;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3467073726:
					return typeof(MasterUnitNodeData).GetProperty(nameof(SettingsIndex));

				case 698564572:
					return typeof(MasterUnitNodeData).GetProperty(nameof(Amplitude));

				case 3418201912:
					return typeof(MasterUnitNodeData).GetProperty(nameof(MasterGain));

				case 3456654679:
					return typeof(MasterUnitNodeData).GetProperty(nameof(MasterLfeGain));

				case 3075029008:
					return typeof(MasterUnitNodeData).GetProperty(nameof(MasterDialogGain));

				case 2469993203:
					return typeof(MasterUnitNodeData).GetProperty(nameof(MainMixGain));

				case 974497912:
					return typeof(MasterUnitNodeData).GetProperty(nameof(PostEffectsGain));

				case 622241232:
					return typeof(MasterUnitNodeData).GetProperty(nameof(ReverbGain));

				case 4001222838:
					return typeof(MasterUnitNodeData).GetProperty(nameof(FadeTime));

				case 1050320730:
					return typeof(MasterUnitNodeData).GetProperty(nameof(HighPassFreq));

				case 4093395621:
					return typeof(MasterUnitNodeData).GetProperty(nameof(LowShelfFreq));

				case 4093417540:
					return typeof(MasterUnitNodeData).GetProperty(nameof(LowShelfGain));

				case 110900543:
					return typeof(MasterUnitNodeData).GetProperty(nameof(HighShelfFreq));

				case 110952414:
					return typeof(MasterUnitNodeData).GetProperty(nameof(HighShelfGain));

				case 201040259:
					return typeof(MasterUnitNodeData).GetProperty(nameof(CompThreshold));

				case 1938039989:
					return typeof(MasterUnitNodeData).GetProperty(nameof(CompRatio));

				case 171486556:
					return typeof(MasterUnitNodeData).GetProperty(nameof(CompAttack));

				case 1539642909:
					return typeof(MasterUnitNodeData).GetProperty(nameof(CompRelease));

				case 3419995663:
					return typeof(MasterUnitNodeData).GetProperty(nameof(DistClipLevel));

				case 2605372900:
					return typeof(MasterUnitNodeData).GetProperty(nameof(ParallelDistortionGain));

				case 649772672:
					return typeof(MasterUnitNodeData).GetProperty(nameof(Settings));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
