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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(28), ContainerClass]
	public class UIFontCollection : 
		Asset
	{
		protected LanguageFormat m_Language = new LanguageFormat();
		[ContainerField(12), MemberInfoFlag(137), ContainerFieldNameHash(3872303031)]
		public LanguageFormat Language { get { return m_Language; } set { if (OnPropertyChanging("UIFontCollection." + nameof(Language), this, m_Language, value)) m_Language = value; } } // 0xC (12)
		
		protected CtrRef<UITextDatabase> m_TextDatabase = new CtrRef<UITextDatabase>();
		[ContainerField(16), MemberInfoFlag(53), ContainerFieldNameHash(1951250813), ContainerCtrRef]
		public CtrRef<UITextDatabase> TextDatabase { get { return m_TextDatabase; } set { if (OnPropertyChanging("UIFontCollection." + nameof(TextDatabase), this, m_TextDatabase, value)) m_TextDatabase = value; } } // 0x10 (16)
		
		protected RefArray<UIFontAsset> m_Fonts = new RefArray<UIFontAsset>();
		[ContainerField(20), MemberInfoFlag(65), ContainerFieldNameHash(206880581), ContainerRefArray]
		public RefArray<UIFontAsset> Fonts { get { return m_Fonts; } set { if (OnPropertyChanging("UIFontCollection." + nameof(Fonts), this, m_Fonts, value)) m_Fonts = value; } } // 0x14 (20)
		
		protected ResourceBundleKind m_BundleKind = new ResourceBundleKind();
		[ContainerField(24), MemberInfoFlag(137), ContainerFieldNameHash(461036985)]
		public ResourceBundleKind BundleKind { get { return m_BundleKind; } set { if (OnPropertyChanging("UIFontCollection." + nameof(BundleKind), this, m_BundleKind, value)) m_BundleKind = value; } } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3872303031:
					Language = (LanguageFormat) Enum.ToObject(typeof(LanguageFormat), p_Value);
					break;

				case 1951250813:
					TextDatabase = (CtrRef<UITextDatabase>) p_Value;
					break;

				case 206880581:
					Fonts = (RefArray<UIFontAsset>) p_Value;
					break;

				case 461036985:
					BundleKind = (ResourceBundleKind) Enum.ToObject(typeof(ResourceBundleKind), p_Value);
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
				case 3872303031:
					return Language;

				case 1951250813:
					return TextDatabase;

				case 206880581:
					return Fonts;

				case 461036985:
					return BundleKind;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3872303031:
					return typeof(UIFontCollection).GetProperty(nameof(Language));

				case 1951250813:
					return typeof(UIFontCollection).GetProperty(nameof(TextDatabase));

				case 206880581:
					return typeof(UIFontCollection).GetProperty(nameof(Fonts));

				case 461036985:
					return typeof(UIFontCollection).GetProperty(nameof(BundleKind));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
