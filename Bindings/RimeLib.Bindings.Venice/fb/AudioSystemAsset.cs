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
	[ContainerType(4)]
	public class AudioSystemAsset : 
		Asset
	{
		protected CtrRef<SoundMasterPatchAsset> m_MasterPatch = new CtrRef<SoundMasterPatchAsset>();
		[ContainerField(12), ContainerFieldNameHash(1109008247)]
		public CtrRef<SoundMasterPatchAsset> MasterPatch { get { return m_MasterPatch; } set { if (OnPropertyChanging("AudioSystemAsset." + nameof(MasterPatch), this, m_MasterPatch, value)) m_MasterPatch = value; } } // 0xC (12)
		
		protected CtrRef<SoundWaveAsset> m_DefaultWave = new CtrRef<SoundWaveAsset>();
		[ContainerField(16), ContainerFieldNameHash(2015103915)]
		public CtrRef<SoundWaveAsset> DefaultWave { get { return m_DefaultWave; } set { if (OnPropertyChanging("AudioSystemAsset." + nameof(DefaultWave), this, m_DefaultWave, value)) m_DefaultWave = value; } } // 0x10 (16)
		
		protected RefArray<StreamPoolAsset> m_StreamPools = new RefArray<StreamPoolAsset>();
		[ContainerField(20), ContainerFieldNameHash(1846268918)]
		public RefArray<StreamPoolAsset> StreamPools { get { return m_StreamPools; } set { if (OnPropertyChanging("AudioSystemAsset." + nameof(StreamPools), this, m_StreamPools, value)) m_StreamPools = value; } } // 0x14 (20)
		
		protected uint m_SampleRate = new uint();
		[ContainerField(24), LayoutImmutable, Blittable, ContainerFieldNameHash(604757697)]
		public uint SampleRate { get { return m_SampleRate; } set { if (OnPropertyChanging("AudioSystemAsset." + nameof(SampleRate), this, m_SampleRate, value)) m_SampleRate = value; } } // 0x18 (24)
		
		protected float m_SoundSpeed = new float();
		[ContainerField(28), LayoutImmutable, Blittable, ContainerFieldNameHash(124014113)]
		public float SoundSpeed { get { return m_SoundSpeed; } set { if (OnPropertyChanging("AudioSystemAsset." + nameof(SoundSpeed), this, m_SoundSpeed, value)) m_SoundSpeed = value; } } // 0x1C (28)
		
		protected float m_DopplerFactor = new float();
		[ContainerField(32), LayoutImmutable, Blittable, ContainerFieldNameHash(1757845912)]
		public float DopplerFactor { get { return m_DopplerFactor; } set { if (OnPropertyChanging("AudioSystemAsset." + nameof(DopplerFactor), this, m_DopplerFactor, value)) m_DopplerFactor = value; } } // 0x20 (32)
		
		protected CtrRef<SoundTestAsset> m_Tests = new CtrRef<SoundTestAsset>();
		[ContainerField(36), ContainerFieldNameHash(227718400)]
		public CtrRef<SoundTestAsset> Tests { get { return m_Tests; } set { if (OnPropertyChanging("AudioSystemAsset." + nameof(Tests), this, m_Tests, value)) m_Tests = value; } } // 0x24 (36)
		
		protected CtrRef<MixerSystemAsset> m_MixerSystem = new CtrRef<MixerSystemAsset>();
		[ContainerField(40), ContainerFieldNameHash(1057148587)]
		public CtrRef<MixerSystemAsset> MixerSystem { get { return m_MixerSystem; } set { if (OnPropertyChanging("AudioSystemAsset." + nameof(MixerSystem), this, m_MixerSystem, value)) m_MixerSystem = value; } } // 0x28 (40)
		
		protected RefArray<AudioLanguage> m_Languages = new RefArray<AudioLanguage>();
		[ContainerField(44), ContainerFieldNameHash(3231948516)]
		public RefArray<AudioLanguage> Languages { get { return m_Languages; } set { if (OnPropertyChanging("AudioSystemAsset." + nameof(Languages), this, m_Languages, value)) m_Languages = value; } } // 0x2C (44)
		
		protected RefArray<AudioLanguageSetting> m_LanguageSettings = new RefArray<AudioLanguageSetting>();
		[ContainerField(48), ContainerFieldNameHash(689864818)]
		public RefArray<AudioLanguageSetting> LanguageSettings { get { return m_LanguageSettings; } set { if (OnPropertyChanging("AudioSystemAsset." + nameof(LanguageSettings), this, m_LanguageSettings, value)) m_LanguageSettings = value; } } // 0x30 (48)
		
		protected CtrRef<AudioLanguage> m_DefaultLanguage = new CtrRef<AudioLanguage>();
		[ContainerField(52), ContainerFieldNameHash(1869348380)]
		public CtrRef<AudioLanguage> DefaultLanguage { get { return m_DefaultLanguage; } set { if (OnPropertyChanging("AudioSystemAsset." + nameof(DefaultLanguage), this, m_DefaultLanguage, value)) m_DefaultLanguage = value; } } // 0x34 (52)
		
		protected RefArray<SoundScopeData> m_Scopes = new RefArray<SoundScopeData>();
		[ContainerField(56), ContainerFieldNameHash(3335461020)]
		public RefArray<SoundScopeData> Scopes { get { return m_Scopes; } set { if (OnPropertyChanging("AudioSystemAsset." + nameof(Scopes), this, m_Scopes, value)) m_Scopes = value; } } // 0x38 (56)
		
		protected RefArray<SoundScopeStrategyData> m_ScopeStrategies = new RefArray<SoundScopeStrategyData>();
		[ContainerField(60), ContainerFieldNameHash(3410651026)]
		public RefArray<SoundScopeStrategyData> ScopeStrategies { get { return m_ScopeStrategies; } set { if (OnPropertyChanging("AudioSystemAsset." + nameof(ScopeStrategies), this, m_ScopeStrategies, value)) m_ScopeStrategies = value; } } // 0x3C (60)
		
		protected RefArray<SoundScopeSetupData> m_ScopeSetups = new RefArray<SoundScopeSetupData>();
		[ContainerField(64), ContainerFieldNameHash(341454043)]
		public RefArray<SoundScopeSetupData> ScopeSetups { get { return m_ScopeSetups; } set { if (OnPropertyChanging("AudioSystemAsset." + nameof(ScopeSetups), this, m_ScopeSetups, value)) m_ScopeSetups = value; } } // 0x40 (64)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1109008247:
					MasterPatch = (CtrRef<SoundMasterPatchAsset>) p_Value;
					break;

				case 2015103915:
					DefaultWave = (CtrRef<SoundWaveAsset>) p_Value;
					break;

				case 1846268918:
					StreamPools = (RefArray<StreamPoolAsset>) p_Value;
					break;

				case 604757697:
					SampleRate = (uint) p_Value;
					break;

				case 124014113:
					SoundSpeed = (float) p_Value;
					break;

				case 1757845912:
					DopplerFactor = (float) p_Value;
					break;

				case 227718400:
					Tests = (CtrRef<SoundTestAsset>) p_Value;
					break;

				case 1057148587:
					MixerSystem = (CtrRef<MixerSystemAsset>) p_Value;
					break;

				case 3231948516:
					Languages = (RefArray<AudioLanguage>) p_Value;
					break;

				case 689864818:
					LanguageSettings = (RefArray<AudioLanguageSetting>) p_Value;
					break;

				case 1869348380:
					DefaultLanguage = (CtrRef<AudioLanguage>) p_Value;
					break;

				case 3335461020:
					Scopes = (RefArray<SoundScopeData>) p_Value;
					break;

				case 3410651026:
					ScopeStrategies = (RefArray<SoundScopeStrategyData>) p_Value;
					break;

				case 341454043:
					ScopeSetups = (RefArray<SoundScopeSetupData>) p_Value;
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
				case 1109008247:
					return MasterPatch;

				case 2015103915:
					return DefaultWave;

				case 1846268918:
					return StreamPools;

				case 604757697:
					return SampleRate;

				case 124014113:
					return SoundSpeed;

				case 1757845912:
					return DopplerFactor;

				case 227718400:
					return Tests;

				case 1057148587:
					return MixerSystem;

				case 3231948516:
					return Languages;

				case 689864818:
					return LanguageSettings;

				case 1869348380:
					return DefaultLanguage;

				case 3335461020:
					return Scopes;

				case 3410651026:
					return ScopeStrategies;

				case 341454043:
					return ScopeSetups;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1109008247:
					return typeof(AudioSystemAsset).GetProperty(nameof(MasterPatch));

				case 2015103915:
					return typeof(AudioSystemAsset).GetProperty(nameof(DefaultWave));

				case 1846268918:
					return typeof(AudioSystemAsset).GetProperty(nameof(StreamPools));

				case 604757697:
					return typeof(AudioSystemAsset).GetProperty(nameof(SampleRate));

				case 124014113:
					return typeof(AudioSystemAsset).GetProperty(nameof(SoundSpeed));

				case 1757845912:
					return typeof(AudioSystemAsset).GetProperty(nameof(DopplerFactor));

				case 227718400:
					return typeof(AudioSystemAsset).GetProperty(nameof(Tests));

				case 1057148587:
					return typeof(AudioSystemAsset).GetProperty(nameof(MixerSystem));

				case 3231948516:
					return typeof(AudioSystemAsset).GetProperty(nameof(Languages));

				case 689864818:
					return typeof(AudioSystemAsset).GetProperty(nameof(LanguageSettings));

				case 1869348380:
					return typeof(AudioSystemAsset).GetProperty(nameof(DefaultLanguage));

				case 3335461020:
					return typeof(AudioSystemAsset).GetProperty(nameof(Scopes));

				case 3410651026:
					return typeof(AudioSystemAsset).GetProperty(nameof(ScopeStrategies));

				case 341454043:
					return typeof(AudioSystemAsset).GetProperty(nameof(ScopeSetups));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
