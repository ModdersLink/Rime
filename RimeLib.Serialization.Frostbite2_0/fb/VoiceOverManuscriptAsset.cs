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
using RimeLib.Serialization.Frostbite2_0.Ebx;

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

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(MasterLanguage));
			(RimeWriter Writer, uint ArrayIndex) s_Languages = p_EbxWriter.GetArrayWriter(Languages.GetType(), Languages.Count);
			p_Writer.Write(s_Languages.ArrayIndex);
			foreach (var s_Entry in Languages)
			{
				s_Languages.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write((int) NameTranslation);
			p_Writer.Write(p_EbxWriter.WriteString(SheetName));
			p_Writer.Write(p_EbxWriter.WriteString(StringIdColumn));
			p_Writer.Write(p_EbxWriter.WriteString(FileNameColumn));
			p_Writer.Write(p_EbxWriter.WriteString(PathColumn));
			p_Writer.Write(p_EbxWriter.WriteString(WaveAssetStatusColumn));
			p_Writer.Write(p_EbxWriter.WriteString(CharacterColumn));
			p_Writer.Write(p_EbxWriter.WriteString(VoiceColumn));
			p_Writer.Write(p_EbxWriter.WriteString(StringIdPrefix));
			(RimeWriter Writer, uint ArrayIndex) s_LanguageColumns = p_EbxWriter.GetArrayWriter(LanguageColumns.GetType(), LanguageColumns.Count);
			p_Writer.Write(s_LanguageColumns.ArrayIndex);
			foreach (var s_Entry in LanguageColumns)
			{
				s_Entry.Serialize(s_LanguageColumns.Writer, p_EbxWriter);
			}
			p_Writer.Write(FirstContentRow);
			p_Writer.Write(p_EbxWriter.WriteString(OutputPath));
			p_Writer.Write(p_EbxWriter.WriteImport(StreamPool));
			p_Writer.Write(KeepPath);
			p_Writer.Write(StringIdUpperCase);
			p_Writer.Write(AllowDelete);
			p_Writer.WriteNullBytes(1);
		}
	}
}
