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
	public class PadInputActionData : 
		AxesInputActionData
	{
		[ContainerField(20)]
		public InputDevicePadButtons Button { get; set; } = new InputDevicePadButtons(); // 0x14 (20)
		
		[ContainerField(24)]
		public InputDevicePOVs Pov { get; set; } = new InputDevicePOVs(); // 0x18 (24)
		
		[ContainerField(28)]
		public InputDevicePadButtons PS3AlternativeButton { get; set; } = new InputDevicePadButtons(); // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public bool UseSquareInput { get; set; } // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2686182099:
					Button = (InputDevicePadButtons) Enum.ToObject(typeof(InputDevicePadButtons), p_Value);
					break;

				case 193467468:
					Pov = (InputDevicePOVs) Enum.ToObject(typeof(InputDevicePOVs), p_Value);
					break;

				case 1772338028:
					PS3AlternativeButton = (InputDevicePadButtons) Enum.ToObject(typeof(InputDevicePadButtons), p_Value);
					break;

				case 3247391921:
					UseSquareInput = (bool) p_Value;
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
				case 2686182099:
					return Button;

				case 193467468:
					return Pov;

				case 1772338028:
					return PS3AlternativeButton;

				case 3247391921:
					return UseSquareInput;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2686182099:
					return typeof(PadInputActionData).GetProperty(nameof(Button));

				case 193467468:
					return typeof(PadInputActionData).GetProperty(nameof(Pov));

				case 1772338028:
					return typeof(PadInputActionData).GetProperty(nameof(PS3AlternativeButton));

				case 3247391921:
					return typeof(PadInputActionData).GetProperty(nameof(UseSquareInput));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
