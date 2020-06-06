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
	public class UIFontMappingCollection : 
		Asset
	{
		[ContainerField(12)]
		public List<UIFontMapping> Fonts { get; set; } = new List<UIFontMapping>(); // 0xC (12)
		
		[ContainerField(16)]
		public RefArray<UITextDatabase> TextDatabase { get; set; } = new RefArray<UITextDatabase>(); // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 206880581:
					Fonts = (List<UIFontMapping>) p_Value;
					break;

				case 1951250813:
					TextDatabase = (RefArray<UITextDatabase>) p_Value;
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
				case 206880581:
					return Fonts;

				case 1951250813:
					return TextDatabase;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 206880581:
					return typeof(UIFontMappingCollection).GetProperty(nameof(Fonts));

				case 1951250813:
					return typeof(UIFontMappingCollection).GetProperty(nameof(TextDatabase));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
