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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(76), ContainerClass]
	public class VoiceOverManuscriptAsset : 
		Asset
	{
		protected CtrRef<AudioLanguage> m_MasterLanguage = new CtrRef<AudioLanguage>();
		[ContainerField(12), MemberInfoFlag(53), ContainerFieldNameHash(1351373419), ContainerCtrRef]
		public CtrRef<AudioLanguage> MasterLanguage { get { return m_MasterLanguage; } set { if (OnPropertyChanging("VoiceOverManuscriptAsset." + nameof(MasterLanguage), this, m_MasterLanguage, value)) m_MasterLanguage = value; } } // 0xC (12)
		
		protected RefArray<VoiceOverLanguageRoot> m_Languages = new RefArray<VoiceOverLanguageRoot>();
		[ContainerField(16), MemberInfoFlag(65), ContainerFieldNameHash(3231948516), ContainerRefArray]
		public RefArray<VoiceOverLanguageRoot> Languages { get { return m_Languages; } set { if (OnPropertyChanging("VoiceOverManuscriptAsset." + nameof(Languages), this, m_Languages, value)) m_Languages = value; } } // 0x10 (16)
		
		protected VoiceOverWaveNameTranslation m_NameTranslation = new VoiceOverWaveNameTranslation();
		[ContainerField(20), MemberInfoFlag(137), ContainerFieldNameHash(3008262953)]
		public VoiceOverWaveNameTranslation NameTranslation { get { return m_NameTranslation; } set { if (OnPropertyChanging("VoiceOverManuscriptAsset." + nameof(NameTranslation), this, m_NameTranslation, value)) m_NameTranslation = value; } } // 0x14 (20)
		
		protected string m_SheetName = string.Empty;
		[ContainerField(24), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(1655714573)]
		public string SheetName { get { return m_SheetName; } set { if (OnPropertyChanging("VoiceOverManuscriptAsset." + nameof(SheetName), this, m_SheetName, value)) m_SheetName = value; } } // 0x18 (24)
		
		protected string m_StringIdColumn = string.Empty;
		[ContainerField(28), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(2316948715)]
		public string StringIdColumn { get { return m_StringIdColumn; } set { if (OnPropertyChanging("VoiceOverManuscriptAsset." + nameof(StringIdColumn), this, m_StringIdColumn, value)) m_StringIdColumn = value; } } // 0x1C (28)
		
		protected string m_FileNameColumn = string.Empty;
		[ContainerField(32), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(30584978)]
		public string FileNameColumn { get { return m_FileNameColumn; } set { if (OnPropertyChanging("VoiceOverManuscriptAsset." + nameof(FileNameColumn), this, m_FileNameColumn, value)) m_FileNameColumn = value; } } // 0x20 (32)
		
		protected string m_PathColumn = string.Empty;
		[ContainerField(36), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(1657585950)]
		public string PathColumn { get { return m_PathColumn; } set { if (OnPropertyChanging("VoiceOverManuscriptAsset." + nameof(PathColumn), this, m_PathColumn, value)) m_PathColumn = value; } } // 0x24 (36)
		
		protected string m_WaveAssetStatusColumn = string.Empty;
		[ContainerField(40), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(355976178)]
		public string WaveAssetStatusColumn { get { return m_WaveAssetStatusColumn; } set { if (OnPropertyChanging("VoiceOverManuscriptAsset." + nameof(WaveAssetStatusColumn), this, m_WaveAssetStatusColumn, value)) m_WaveAssetStatusColumn = value; } } // 0x28 (40)
		
		protected string m_CharacterColumn = string.Empty;
		[ContainerField(44), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(2622712842)]
		public string CharacterColumn { get { return m_CharacterColumn; } set { if (OnPropertyChanging("VoiceOverManuscriptAsset." + nameof(CharacterColumn), this, m_CharacterColumn, value)) m_CharacterColumn = value; } } // 0x2C (44)
		
		protected string m_VoiceColumn = string.Empty;
		[ContainerField(48), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(3950839045)]
		public string VoiceColumn { get { return m_VoiceColumn; } set { if (OnPropertyChanging("VoiceOverManuscriptAsset." + nameof(VoiceColumn), this, m_VoiceColumn, value)) m_VoiceColumn = value; } } // 0x30 (48)
		
		protected string m_StringIdPrefix = string.Empty;
		[ContainerField(52), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(1766158509)]
		public string StringIdPrefix { get { return m_StringIdPrefix; } set { if (OnPropertyChanging("VoiceOverManuscriptAsset." + nameof(StringIdPrefix), this, m_StringIdPrefix, value)) m_StringIdPrefix = value; } } // 0x34 (52)
		
		protected List<VoiceOverManuscriptLanguageColumns> m_LanguageColumns = new List<VoiceOverManuscriptLanguageColumns>();
		[ContainerField(56), MemberInfoFlag(65), ContainerFieldNameHash(1806550354), ContainerArray]
		public List<VoiceOverManuscriptLanguageColumns> LanguageColumns { get { return m_LanguageColumns; } set { if (OnPropertyChanging("VoiceOverManuscriptAsset." + nameof(LanguageColumns), this, m_LanguageColumns, value)) m_LanguageColumns = value; } } // 0x38 (56)
		
		protected int m_FirstContentRow = new int();
		[ContainerField(60), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(1758802268)]
		public int FirstContentRow { get { return m_FirstContentRow; } set { if (OnPropertyChanging("VoiceOverManuscriptAsset." + nameof(FirstContentRow), this, m_FirstContentRow, value)) m_FirstContentRow = value; } } // 0x3C (60)
		
		protected string m_OutputPath = string.Empty;
		[ContainerField(64), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(542834903)]
		public string OutputPath { get { return m_OutputPath; } set { if (OnPropertyChanging("VoiceOverManuscriptAsset." + nameof(OutputPath), this, m_OutputPath, value)) m_OutputPath = value; } } // 0x40 (64)
		
		protected CtrRef<StreamPoolAsset> m_StreamPool = new CtrRef<StreamPoolAsset>();
		[ContainerField(68), MemberInfoFlag(53), ContainerFieldNameHash(1617753829), ContainerCtrRef]
		public CtrRef<StreamPoolAsset> StreamPool { get { return m_StreamPool; } set { if (OnPropertyChanging("VoiceOverManuscriptAsset." + nameof(StreamPool), this, m_StreamPool, value)) m_StreamPool = value; } } // 0x44 (68)
		
		protected bool m_KeepPath = new bool();
		[ContainerField(72), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3967552211)]
		public bool KeepPath { get { return m_KeepPath; } set { if (OnPropertyChanging("VoiceOverManuscriptAsset." + nameof(KeepPath), this, m_KeepPath, value)) m_KeepPath = value; } } // 0x48 (72)
		
		protected bool m_StringIdUpperCase = new bool();
		[ContainerField(73), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(113383467)]
		public bool StringIdUpperCase { get { return m_StringIdUpperCase; } set { if (OnPropertyChanging("VoiceOverManuscriptAsset." + nameof(StringIdUpperCase), this, m_StringIdUpperCase, value)) m_StringIdUpperCase = value; } } // 0x49 (73)
		
		protected bool m_AllowDelete = new bool();
		[ContainerField(74), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3422513957)]
		public bool AllowDelete { get { return m_AllowDelete; } set { if (OnPropertyChanging("VoiceOverManuscriptAsset." + nameof(AllowDelete), this, m_AllowDelete, value)) m_AllowDelete = value; } } // 0x4A (74)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1351373419:
					MasterLanguage = (CtrRef<AudioLanguage>) p_Value;
					break;

				case 3231948516:
					Languages = (RefArray<VoiceOverLanguageRoot>) p_Value;
					break;

				case 3008262953:
					NameTranslation = (VoiceOverWaveNameTranslation) Enum.ToObject(typeof(VoiceOverWaveNameTranslation), p_Value);
					break;

				case 1655714573:
					SheetName = (string) p_Value;
					break;

				case 2316948715:
					StringIdColumn = (string) p_Value;
					break;

				case 30584978:
					FileNameColumn = (string) p_Value;
					break;

				case 1657585950:
					PathColumn = (string) p_Value;
					break;

				case 355976178:
					WaveAssetStatusColumn = (string) p_Value;
					break;

				case 2622712842:
					CharacterColumn = (string) p_Value;
					break;

				case 3950839045:
					VoiceColumn = (string) p_Value;
					break;

				case 1766158509:
					StringIdPrefix = (string) p_Value;
					break;

				case 1806550354:
					LanguageColumns = (List<VoiceOverManuscriptLanguageColumns>) p_Value;
					break;

				case 1758802268:
					FirstContentRow = (int) p_Value;
					break;

				case 542834903:
					OutputPath = (string) p_Value;
					break;

				case 1617753829:
					StreamPool = (CtrRef<StreamPoolAsset>) p_Value;
					break;

				case 3967552211:
					KeepPath = (bool) p_Value;
					break;

				case 113383467:
					StringIdUpperCase = (bool) p_Value;
					break;

				case 3422513957:
					AllowDelete = (bool) p_Value;
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
				case 1351373419:
					return MasterLanguage;

				case 3231948516:
					return Languages;

				case 3008262953:
					return NameTranslation;

				case 1655714573:
					return SheetName;

				case 2316948715:
					return StringIdColumn;

				case 30584978:
					return FileNameColumn;

				case 1657585950:
					return PathColumn;

				case 355976178:
					return WaveAssetStatusColumn;

				case 2622712842:
					return CharacterColumn;

				case 3950839045:
					return VoiceColumn;

				case 1766158509:
					return StringIdPrefix;

				case 1806550354:
					return LanguageColumns;

				case 1758802268:
					return FirstContentRow;

				case 542834903:
					return OutputPath;

				case 1617753829:
					return StreamPool;

				case 3967552211:
					return KeepPath;

				case 113383467:
					return StringIdUpperCase;

				case 3422513957:
					return AllowDelete;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1351373419:
					return typeof(VoiceOverManuscriptAsset).GetProperty(nameof(MasterLanguage));

				case 3231948516:
					return typeof(VoiceOverManuscriptAsset).GetProperty(nameof(Languages));

				case 3008262953:
					return typeof(VoiceOverManuscriptAsset).GetProperty(nameof(NameTranslation));

				case 1655714573:
					return typeof(VoiceOverManuscriptAsset).GetProperty(nameof(SheetName));

				case 2316948715:
					return typeof(VoiceOverManuscriptAsset).GetProperty(nameof(StringIdColumn));

				case 30584978:
					return typeof(VoiceOverManuscriptAsset).GetProperty(nameof(FileNameColumn));

				case 1657585950:
					return typeof(VoiceOverManuscriptAsset).GetProperty(nameof(PathColumn));

				case 355976178:
					return typeof(VoiceOverManuscriptAsset).GetProperty(nameof(WaveAssetStatusColumn));

				case 2622712842:
					return typeof(VoiceOverManuscriptAsset).GetProperty(nameof(CharacterColumn));

				case 3950839045:
					return typeof(VoiceOverManuscriptAsset).GetProperty(nameof(VoiceColumn));

				case 1766158509:
					return typeof(VoiceOverManuscriptAsset).GetProperty(nameof(StringIdPrefix));

				case 1806550354:
					return typeof(VoiceOverManuscriptAsset).GetProperty(nameof(LanguageColumns));

				case 1758802268:
					return typeof(VoiceOverManuscriptAsset).GetProperty(nameof(FirstContentRow));

				case 542834903:
					return typeof(VoiceOverManuscriptAsset).GetProperty(nameof(OutputPath));

				case 1617753829:
					return typeof(VoiceOverManuscriptAsset).GetProperty(nameof(StreamPool));

				case 3967552211:
					return typeof(VoiceOverManuscriptAsset).GetProperty(nameof(KeepPath));

				case 113383467:
					return typeof(VoiceOverManuscriptAsset).GetProperty(nameof(StringIdUpperCase));

				case 3422513957:
					return typeof(VoiceOverManuscriptAsset).GetProperty(nameof(AllowDelete));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
