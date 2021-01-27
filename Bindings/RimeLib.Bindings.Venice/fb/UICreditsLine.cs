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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 8)]
	public class UICreditsLine : FrostbiteContainer
	{
		[ContainerField(Name: "TextType", Offset: 0, NameHash: 2028258240, Flags: 137)]
		public UICreditsTextType TextType { get; set; } = new UICreditsTextType(); // 0x0 (0)
		
		[ContainerField(Name: "Text", Offset: 4, NameHash: 2089309304, Flags: 16509), LayoutImmutable]
		public string Text { get; set; } // 0x4 (4)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2028258240:
						TextType = (UICreditsTextType) Enum.ToObject(typeof(UICreditsTextType), p_Value);
					break;

				case 2089309304:
					Text = (string) p_Value;
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
				case 2028258240:
					return TextType;

				case 2089309304:
					return Text;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2028258240:
					return typeof(UICreditsLine).GetProperty(nameof(TextType));

				case 2089309304:
					return typeof(UICreditsLine).GetProperty(nameof(Text));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
