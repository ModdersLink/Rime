///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class UIFontAsset : 
		Asset
	{
		[ContainerField(12), LayoutImmutable]
		public string SourceFile { get; set; } // 0xC (12)
		
		[ContainerField(16)]
		public CtrRef<UITextDatabase> TextDatabase { get; set; } = new CtrRef<UITextDatabase>(); // 0x10 (16)
		
		[ContainerField(20)]
		public List<string> ScaleformFontName { get; set; } = new List<string>(); // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public bool NumericsOnly { get; set; } // 0x18 (24)
		
		[ContainerField(25), LayoutImmutable, Blittable]
		public bool CompleteKorean { get; set; } // 0x19 (25)
		
		[ContainerField(26), LayoutImmutable, Blittable]
		public bool CompleteJapanese { get; set; } // 0x1A (26)
		
		[ContainerField(27), LayoutImmutable, Blittable]
		public bool CompleteTraditionalChinese { get; set; } // 0x1B (27)
		
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
