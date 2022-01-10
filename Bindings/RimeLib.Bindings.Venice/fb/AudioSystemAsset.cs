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
	[ContainerType(4, 68)]
	public class AudioSystemAsset : 
		Asset
	{
		[ContainerField(12)]
		public CtrRef<SoundMasterPatchAsset> MasterPatch { get; set; } = new();

		[ContainerField(16)]
		public CtrRef<SoundWaveAsset> DefaultWave { get; set; } = new();

		[ContainerField(20)]
		public List<CtrRef<StreamPoolAsset>> StreamPools { get; set; } = new();

		[ContainerField(24), LayoutImmutable, Blittable]
		public uint SampleRate { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public float SoundSpeed { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public float DopplerFactor { get; set; }

		[ContainerField(36)]
		public CtrRef<SoundTestAsset> Tests { get; set; } = new();

		[ContainerField(40)]
		public CtrRef<MixerSystemAsset> MixerSystem { get; set; } = new();

		[ContainerField(44)]
		public List<CtrRef<AudioLanguage>> Languages { get; set; } = new();

		[ContainerField(48)]
		public List<CtrRef<AudioLanguageSetting>> LanguageSettings { get; set; } = new();

		[ContainerField(52)]
		public CtrRef<AudioLanguage> DefaultLanguage { get; set; } = new();

		[ContainerField(56)]
		public List<CtrRef<SoundScopeData>> Scopes { get; set; } = new();

		[ContainerField(60)]
		public List<CtrRef<SoundScopeStrategyData>> ScopeStrategies { get; set; } = new();

		[ContainerField(64)]
		public List<CtrRef<SoundScopeSetupData>> ScopeSetups { get; set; } = new();

		public static void Deserialize(AudioSystemAsset p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.MasterPatch.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.DefaultWave.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.StreamPools.Clear();
			(RimeReader Reader, uint Count) s_StreamPools = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_StreamPools.Count; ++i)
			{
				var s_CtrRef = new CtrRef<StreamPoolAsset>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_StreamPools.Reader.ReadUInt32()));
				p_Instance.StreamPools.Add(s_CtrRef);
			}
			
			s_StreamPools.Reader.Dispose();
			p_Instance.SampleRate = p_Reader.ReadUInt32();
			p_Instance.SoundSpeed = p_Reader.ReadSingle();
			p_Instance.DopplerFactor = p_Reader.ReadSingle();
			p_Instance.Tests.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.MixerSystem.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Languages.Clear();
			(RimeReader Reader, uint Count) s_Languages = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Languages.Count; ++i)
			{
				var s_CtrRef = new CtrRef<AudioLanguage>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Languages.Reader.ReadUInt32()));
				p_Instance.Languages.Add(s_CtrRef);
			}
			
			s_Languages.Reader.Dispose();
			p_Instance.LanguageSettings.Clear();
			(RimeReader Reader, uint Count) s_LanguageSettings = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_LanguageSettings.Count; ++i)
			{
				var s_CtrRef = new CtrRef<AudioLanguageSetting>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_LanguageSettings.Reader.ReadUInt32()));
				p_Instance.LanguageSettings.Add(s_CtrRef);
			}
			
			s_LanguageSettings.Reader.Dispose();
			p_Instance.DefaultLanguage.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Scopes.Clear();
			(RimeReader Reader, uint Count) s_Scopes = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Scopes.Count; ++i)
			{
				var s_CtrRef = new CtrRef<SoundScopeData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Scopes.Reader.ReadUInt32()));
				p_Instance.Scopes.Add(s_CtrRef);
			}
			
			s_Scopes.Reader.Dispose();
			p_Instance.ScopeStrategies.Clear();
			(RimeReader Reader, uint Count) s_ScopeStrategies = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_ScopeStrategies.Count; ++i)
			{
				var s_CtrRef = new CtrRef<SoundScopeStrategyData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_ScopeStrategies.Reader.ReadUInt32()));
				p_Instance.ScopeStrategies.Add(s_CtrRef);
			}
			
			s_ScopeStrategies.Reader.Dispose();
			p_Instance.ScopeSetups.Clear();
			(RimeReader Reader, uint Count) s_ScopeSetups = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_ScopeSetups.Count; ++i)
			{
				var s_CtrRef = new CtrRef<SoundScopeSetupData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_ScopeSetups.Reader.ReadUInt32()));
				p_Instance.ScopeSetups.Add(s_CtrRef);
			}
			
			s_ScopeSetups.Reader.Dispose();
		}

	}
}
