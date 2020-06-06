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
	public class AxesInputActionData : 
		InputActionData
	{
		[ContainerField(12)]
		public InputDeviceAxes Axis { get; set; } = new InputDeviceAxes(); // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public bool NormalizeInput { get; set; } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088662246:
					Axis = (InputDeviceAxes) Enum.ToObject(typeof(InputDeviceAxes), p_Value);
					break;

				case 4067559830:
					NormalizeInput = (bool) p_Value;
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
				case 2088662246:
					return Axis;

				case 4067559830:
					return NormalizeInput;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088662246:
					return typeof(AxesInputActionData).GetProperty(nameof(Axis));

				case 4067559830:
					return typeof(AxesInputActionData).GetProperty(nameof(NormalizeInput));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
