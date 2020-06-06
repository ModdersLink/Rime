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
	public class UINumberDataBinding : 
		UIDataBinding
	{
		[ContainerField(8)]
		public UIDataSourceInfo Value { get; set; } = new UIDataSourceInfo(); // 0x8 (8)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public int NumValue { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public bool Refresh { get; set; } // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 225375086:
					Value = (UIDataSourceInfo) p_Value;
					break;

				case 768702008:
					NumValue = (int) p_Value;
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
				case 225375086:
					return Value;

				case 768702008:
					return NumValue;

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
				case 225375086:
					return typeof(UINumberDataBinding).GetProperty(nameof(Value));

				case 768702008:
					return typeof(UINumberDataBinding).GetProperty(nameof(NumValue));

				case 1327541432:
					return typeof(UINumberDataBinding).GetProperty(nameof(Refresh));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
