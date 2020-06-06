///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class UIFontCollection : 
		Asset
	{
		[ContainerField(12)]
		public LanguageFormat Language { get; set; } = new LanguageFormat(); // 0xC (12)
		
		[ContainerField(16)]
		public CtrRef<UITextDatabase> TextDatabase { get; set; } = new CtrRef<UITextDatabase>(); // 0x10 (16)
		
		[ContainerField(20)]
		public RefArray<UIFontAsset> Fonts { get; set; } = new RefArray<UIFontAsset>(); // 0x14 (20)
		
		[ContainerField(24)]
		public ResourceBundleKind BundleKind { get; set; } = new ResourceBundleKind(); // 0x18 (24)
		
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
