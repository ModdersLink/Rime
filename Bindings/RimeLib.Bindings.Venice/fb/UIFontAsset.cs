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
	public class UIFontAsset : 
		Asset
	{
		protected string m_SourceFile = string.Empty;
		[ContainerField(12), LayoutImmutable, ContainerFieldNameHash(1522844286)]
		public string SourceFile { get { return m_SourceFile; } set { if (OnPropertyChanging("UIFontAsset." + nameof(SourceFile), this, m_SourceFile, value)) m_SourceFile = value; } } // 0xC (12)
		
		protected CtrRef<UITextDatabase> m_TextDatabase = new CtrRef<UITextDatabase>();
		[ContainerField(16), ContainerFieldNameHash(1951250813)]
		public CtrRef<UITextDatabase> TextDatabase { get { return m_TextDatabase; } set { if (OnPropertyChanging("UIFontAsset." + nameof(TextDatabase), this, m_TextDatabase, value)) m_TextDatabase = value; } } // 0x10 (16)
		
		protected List<string> m_ScaleformFontName = new List<string>();
		[ContainerField(20), ContainerFieldNameHash(842040767)]
		public List<string> ScaleformFontName { get { return m_ScaleformFontName; } set { if (OnPropertyChanging("UIFontAsset." + nameof(ScaleformFontName), this, m_ScaleformFontName, value)) m_ScaleformFontName = value; } } // 0x14 (20)
		
		protected bool m_NumericsOnly = new bool();
		[ContainerField(24), LayoutImmutable, Blittable, ContainerFieldNameHash(1142577577)]
		public bool NumericsOnly { get { return m_NumericsOnly; } set { if (OnPropertyChanging("UIFontAsset." + nameof(NumericsOnly), this, m_NumericsOnly, value)) m_NumericsOnly = value; } } // 0x18 (24)
		
		protected bool m_CompleteKorean = new bool();
		[ContainerField(25), LayoutImmutable, Blittable, ContainerFieldNameHash(3382158800)]
		public bool CompleteKorean { get { return m_CompleteKorean; } set { if (OnPropertyChanging("UIFontAsset." + nameof(CompleteKorean), this, m_CompleteKorean, value)) m_CompleteKorean = value; } } // 0x19 (25)
		
		protected bool m_CompleteJapanese = new bool();
		[ContainerField(26), LayoutImmutable, Blittable, ContainerFieldNameHash(3695683243)]
		public bool CompleteJapanese { get { return m_CompleteJapanese; } set { if (OnPropertyChanging("UIFontAsset." + nameof(CompleteJapanese), this, m_CompleteJapanese, value)) m_CompleteJapanese = value; } } // 0x1A (26)
		
		protected bool m_CompleteTraditionalChinese = new bool();
		[ContainerField(27), LayoutImmutable, Blittable, ContainerFieldNameHash(1924875432)]
		public bool CompleteTraditionalChinese { get { return m_CompleteTraditionalChinese; } set { if (OnPropertyChanging("UIFontAsset." + nameof(CompleteTraditionalChinese), this, m_CompleteTraditionalChinese, value)) m_CompleteTraditionalChinese = value; } } // 0x1B (27)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1522844286:
					SourceFile = (string) p_Value;
					break;

				case 1951250813:
					TextDatabase = (CtrRef<UITextDatabase>) p_Value;
					break;

				case 842040767:
					ScaleformFontName = (List<string>) p_Value;
					break;

				case 1142577577:
					NumericsOnly = (bool) p_Value;
					break;

				case 3382158800:
					CompleteKorean = (bool) p_Value;
					break;

				case 3695683243:
					CompleteJapanese = (bool) p_Value;
					break;

				case 1924875432:
					CompleteTraditionalChinese = (bool) p_Value;
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
				case 1522844286:
					return SourceFile;

				case 1951250813:
					return TextDatabase;

				case 842040767:
					return ScaleformFontName;

				case 1142577577:
					return NumericsOnly;

				case 3382158800:
					return CompleteKorean;

				case 3695683243:
					return CompleteJapanese;

				case 1924875432:
					return CompleteTraditionalChinese;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1522844286:
					return typeof(UIFontAsset).GetProperty(nameof(SourceFile));

				case 1951250813:
					return typeof(UIFontAsset).GetProperty(nameof(TextDatabase));

				case 842040767:
					return typeof(UIFontAsset).GetProperty(nameof(ScaleformFontName));

				case 1142577577:
					return typeof(UIFontAsset).GetProperty(nameof(NumericsOnly));

				case 3382158800:
					return typeof(UIFontAsset).GetProperty(nameof(CompleteKorean));

				case 3695683243:
					return typeof(UIFontAsset).GetProperty(nameof(CompleteJapanese));

				case 1924875432:
					return typeof(UIFontAsset).GetProperty(nameof(CompleteTraditionalChinese));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
