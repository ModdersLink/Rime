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
	public class UIButtonDataBinding : 
		UIDataBinding
	{
		[ContainerField(8)]
		public UIDataSourceInfo ButtonsDatasource { get; set; } = new UIDataSourceInfo(); // 0x8 (8)
		
		[ContainerField(24)]
		public UIButtonSet DefaultButtonSet { get; set; } = new UIButtonSet(); // 0x18 (24)
		
		[ContainerField(28)]
		public UIDataSourceInfo Visibility { get; set; } = new UIDataSourceInfo(); // 0x1C (28)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public bool InvertVisible { get; set; } // 0x2C (44)
		
		[ContainerField(45), LayoutImmutable, Blittable]
		public bool Visible { get; set; } // 0x2D (45)
		
		[ContainerField(46), LayoutImmutable, Blittable]
		public bool InputOnRelease { get; set; } // 0x2E (46)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3642323661:
					ButtonsDatasource = (UIDataSourceInfo) p_Value;
					break;

				case 1682159194:
					DefaultButtonSet = (UIButtonSet) p_Value;
					break;

				case 1708270083:
					Visibility = (UIDataSourceInfo) p_Value;
					break;

				case 301381369:
					InvertVisible = (bool) p_Value;
					break;

				case 901540267:
					Visible = (bool) p_Value;
					break;

				case 1481400763:
					InputOnRelease = (bool) p_Value;
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
				case 3642323661:
					return ButtonsDatasource;

				case 1682159194:
					return DefaultButtonSet;

				case 1708270083:
					return Visibility;

				case 301381369:
					return InvertVisible;

				case 901540267:
					return Visible;

				case 1481400763:
					return InputOnRelease;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3642323661:
					return typeof(UIButtonDataBinding).GetProperty(nameof(ButtonsDatasource));

				case 1682159194:
					return typeof(UIButtonDataBinding).GetProperty(nameof(DefaultButtonSet));

				case 1708270083:
					return typeof(UIButtonDataBinding).GetProperty(nameof(Visibility));

				case 301381369:
					return typeof(UIButtonDataBinding).GetProperty(nameof(InvertVisible));

				case 901540267:
					return typeof(UIButtonDataBinding).GetProperty(nameof(Visible));

				case 1481400763:
					return typeof(UIButtonDataBinding).GetProperty(nameof(InputOnRelease));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
