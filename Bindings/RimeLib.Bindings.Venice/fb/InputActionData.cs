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
	public class InputActionData : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public bool IsAnalog { get; set; } // 0x8 (8)
		
		[ContainerField(9), LayoutImmutable, Blittable]
		public bool NegateValue { get; set; } // 0x9 (9)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 998391125:
					IsAnalog = (bool) p_Value;
					break;

				case 928334002:
					NegateValue = (bool) p_Value;
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
				case 998391125:
					return IsAnalog;

				case 928334002:
					return NegateValue;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 998391125:
					return typeof(InputActionData).GetProperty(nameof(IsAnalog));

				case 928334002:
					return typeof(InputActionData).GetProperty(nameof(NegateValue));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
