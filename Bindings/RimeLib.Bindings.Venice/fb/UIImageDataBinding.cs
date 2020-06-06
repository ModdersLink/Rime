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
	public class UIImageDataBinding : 
		UIDataBinding
	{
		[ContainerField(8), LayoutImmutable]
		public string StaticImageUrl { get; set; } // 0x8 (8)
		
		[ContainerField(12)]
		public UIDataSourceInfo ImageData { get; set; } = new UIDataSourceInfo(); // 0xC (12)
		
		[ContainerField(28)]
		public UIDataSourceInfo Visibility { get; set; } = new UIDataSourceInfo(); // 0x1C (28)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public bool Visible { get; set; } // 0x2C (44)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1907338737:
					StaticImageUrl = (string) p_Value;
					break;

				case 2678906194:
					ImageData = (UIDataSourceInfo) p_Value;
					break;

				case 1708270083:
					Visibility = (UIDataSourceInfo) p_Value;
					break;

				case 901540267:
					Visible = (bool) p_Value;
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
				case 1907338737:
					return StaticImageUrl;

				case 2678906194:
					return ImageData;

				case 1708270083:
					return Visibility;

				case 901540267:
					return Visible;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1907338737:
					return typeof(UIImageDataBinding).GetProperty(nameof(StaticImageUrl));

				case 2678906194:
					return typeof(UIImageDataBinding).GetProperty(nameof(ImageData));

				case 1708270083:
					return typeof(UIImageDataBinding).GetProperty(nameof(Visibility));

				case 901540267:
					return typeof(UIImageDataBinding).GetProperty(nameof(Visible));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
