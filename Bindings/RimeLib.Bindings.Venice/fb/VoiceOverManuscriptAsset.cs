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
	[ContainerType(4, 76)]
	public class VoiceOverManuscriptAsset : 
		Asset
	{
		[ContainerField(12)]
		public CtrRef<AudioLanguage> MasterLanguage { get; set; } = new();

		[ContainerField(16)]
		public RefArray<VoiceOverLanguageRoot> Languages { get; set; } = new();

		[ContainerField(20)]
		public VoiceOverWaveNameTranslation NameTranslation { get; set; } = new();

		[ContainerField(24), LayoutImmutable]
		public string SheetName { get; set; } = string.Empty;

		[ContainerField(28), LayoutImmutable]
		public string StringIdColumn { get; set; } = string.Empty;

		[ContainerField(32), LayoutImmutable]
		public string FileNameColumn { get; set; } = string.Empty;

		[ContainerField(36), LayoutImmutable]
		public string PathColumn { get; set; } = string.Empty;

		[ContainerField(40), LayoutImmutable]
		public string WaveAssetStatusColumn { get; set; } = string.Empty;

		[ContainerField(44), LayoutImmutable]
		public string CharacterColumn { get; set; } = string.Empty;

		[ContainerField(48), LayoutImmutable]
		public string VoiceColumn { get; set; } = string.Empty;

		[ContainerField(52), LayoutImmutable]
		public string StringIdPrefix { get; set; } = string.Empty;

		[ContainerField(56)]
		public List<VoiceOverManuscriptLanguageColumns> LanguageColumns { get; set; } = new();

		[ContainerField(60), LayoutImmutable, Blittable]
		public int FirstContentRow { get; set; }

		[ContainerField(64), LayoutImmutable]
		public string OutputPath { get; set; } = string.Empty;

		[ContainerField(68)]
		public CtrRef<StreamPoolAsset> StreamPool { get; set; } = new();

		[ContainerField(72), LayoutImmutable, Blittable]
		public bool KeepPath { get; set; }

		[ContainerField(73), LayoutImmutable, Blittable]
		public bool StringIdUpperCase { get; set; }

		[ContainerField(74), LayoutImmutable, Blittable]
		public bool AllowDelete { get; set; }

	}
}
