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
	public class UIBarDataBinding : 
		UIDataBinding
	{
		[ContainerField(8)]
		public UIDataSourceInfo Visibility { get; set; } = new UIDataSourceInfo(); // 0x8 (8)
		
		[ContainerField(24)]
		public UIDataSourceInfo Value { get; set; } = new UIDataSourceInfo(); // 0x18 (24)
		
		[ContainerField(40)]
		public UIDataSourceInfo Color { get; set; } = new UIDataSourceInfo(); // 0x28 (40)
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public bool Refresh { get; set; } // 0x38 (56)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1708270083:
					Visibility = (UIDataSourceInfo) p_Value;
					break;

				case 225375086:
					Value = (UIDataSourceInfo) p_Value;
					break;

				case 212387320:
					Color = (UIDataSourceInfo) p_Value;
					break;

				case 1327541432:
					Refresh = (bool) p_Value;
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
				case 1708270083:
					return Visibility;

				case 225375086:
					return Value;

				case 212387320:
					return Color;

				case 1327541432:
					return Refresh;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1708270083:
					return typeof(UIBarDataBinding).GetProperty(nameof(Visibility));

				case 225375086:
					return typeof(UIBarDataBinding).GetProperty(nameof(Value));

				case 212387320:
					return typeof(UIBarDataBinding).GetProperty(nameof(Color));

				case 1327541432:
					return typeof(UIBarDataBinding).GetProperty(nameof(Refresh));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
