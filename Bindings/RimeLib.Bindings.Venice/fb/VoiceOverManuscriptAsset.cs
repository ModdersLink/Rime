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

namespace fb
{
	[ContainerType(4, 76)]
	public class VoiceOverManuscriptAsset : 
		Asset
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public CtrRef<AudioLanguage> MasterLanguage { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public RefArray<VoiceOverLanguageRoot> Languages { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public VoiceOverWaveNameTranslation NameTranslation { get; set; } = new();

		[ContainerField(24), LayoutImmutable, JsonProperty(Order = 24)]
		public string SheetName { get; set; } = string.Empty;

		[ContainerField(28), LayoutImmutable, JsonProperty(Order = 28)]
		public string StringIdColumn { get; set; } = string.Empty;

		[ContainerField(32), LayoutImmutable, JsonProperty(Order = 32)]
		public string FileNameColumn { get; set; } = string.Empty;

		[ContainerField(36), LayoutImmutable, JsonProperty(Order = 36)]
		public string PathColumn { get; set; } = string.Empty;

		[ContainerField(40), LayoutImmutable, JsonProperty(Order = 40)]
		public string WaveAssetStatusColumn { get; set; } = string.Empty;

		[ContainerField(44), LayoutImmutable, JsonProperty(Order = 44)]
		public string CharacterColumn { get; set; } = string.Empty;

		[ContainerField(48), LayoutImmutable, JsonProperty(Order = 48)]
		public string VoiceColumn { get; set; } = string.Empty;

		[ContainerField(52), LayoutImmutable, JsonProperty(Order = 52)]
		public string StringIdPrefix { get; set; } = string.Empty;

		[ContainerField(56), JsonProperty(Order = 56)]
		public List<VoiceOverManuscriptLanguageColumns> LanguageColumns { get; set; } = new();

		[ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		public int FirstContentRow { get; set; }

		[ContainerField(64), LayoutImmutable, JsonProperty(Order = 64)]
		public string OutputPath { get; set; } = string.Empty;

		[ContainerField(68), JsonProperty(Order = 68)]
		public CtrRef<StreamPoolAsset> StreamPool { get; set; } = new();

		[ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		public bool KeepPath { get; set; }

		[ContainerField(73), LayoutImmutable, Blittable, JsonProperty(Order = 73)]
		public bool StringIdUpperCase { get; set; }

		[ContainerField(74), LayoutImmutable, Blittable, JsonProperty(Order = 74)]
		public bool AllowDelete { get; set; }

	}
}
