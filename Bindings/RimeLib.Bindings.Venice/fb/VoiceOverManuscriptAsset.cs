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
		public List<CtrRef<VoiceOverLanguageRoot>> Languages { get; set; } = new();

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

		public static void Deserialize(VoiceOverManuscriptAsset p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.MasterLanguage.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Languages.Clear();
			(RimeReader Reader, uint Count) s_Languages = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Languages.Count; ++i)
			{
				var s_CtrRef = new CtrRef<VoiceOverLanguageRoot>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Languages.Reader.ReadUInt32()));
				p_Instance.Languages.Add(s_CtrRef);
			}
			
			s_Languages.Reader.Dispose();
			p_Instance.NameTranslation = (VoiceOverWaveNameTranslation) p_Reader.ReadInt32();
			p_Instance.SheetName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.StringIdColumn = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.FileNameColumn = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.PathColumn = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.WaveAssetStatusColumn = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.CharacterColumn = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.VoiceColumn = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.StringIdPrefix = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.LanguageColumns.Clear();
			(RimeReader Reader, uint Count) s_LanguageColumns = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_LanguageColumns.Count; ++i)
			{
				var s_Value = new VoiceOverManuscriptLanguageColumns();
				fb.VoiceOverManuscriptLanguageColumns.Deserialize(s_Value, s_LanguageColumns.Reader, p_Parser);
				p_Instance.LanguageColumns.Add(s_Value);
			}
			
			s_LanguageColumns.Reader.Dispose();
			p_Instance.FirstContentRow = p_Reader.ReadInt32();
			p_Instance.OutputPath = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.StreamPool.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.KeepPath = p_Reader.ReadBool();
			p_Instance.StringIdUpperCase = p_Reader.ReadBool();
			p_Instance.AllowDelete = p_Reader.ReadBool();
			p_Reader.Seek(1, SeekOrigin.Current);
		}

	}
}
