///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class UITextDataBinding : 
		UIDataBinding
	{
		[ContainerField(8), LayoutImmutable]
		public string StaticText { get; set; } // 0x8 (8)
		
		[ContainerField(12)]
		public UIDataSourceInfo TextData { get; set; } = new UIDataSourceInfo(); // 0xC (12)
		
		[ContainerField(28)]
		public UIDataSourceInfo Visibility { get; set; } = new UIDataSourceInfo(); // 0x1C (28)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public bool Refresh { get; set; } // 0x2C (44)
		
		[ContainerField(45), LayoutImmutable, Blittable]
		public bool OverrideDirectAccess { get; set; } // 0x2D (45)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3461853472:
					StaticText = (string) p_Value;
					break;

				case 2028824392:
					TextData = (UIDataSourceInfo) p_Value;
					break;

				case 1708270083:
					Visibility = (UIDataSourceInfo) p_Value;
					break;

				case 1327541432:
					Refresh = (bool) p_Value;
					break;

				case 1955548088:
					OverrideDirectAccess = (bool) p_Value;
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
				case 3461853472:
					return StaticText;

				case 2028824392:
					return TextData;

				case 1708270083:
					return Visibility;

				case 1327541432:
					return Refresh;

				case 1955548088:
					return OverrideDirectAccess;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3461853472:
					return typeof(UITextDataBinding).GetProperty(nameof(StaticText));

				case 2028824392:
					return typeof(UITextDataBinding).GetProperty(nameof(TextData));

				case 1708270083:
					return typeof(UITextDataBinding).GetProperty(nameof(Visibility));

				case 1327541432:
					return typeof(UITextDataBinding).GetProperty(nameof(Refresh));

				case 1955548088:
					return typeof(UITextDataBinding).GetProperty(nameof(OverrideDirectAccess));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
