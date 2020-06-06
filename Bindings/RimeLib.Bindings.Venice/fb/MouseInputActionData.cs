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
	public class MouseInputActionData : 
		AxesInputActionData
	{
		[ContainerField(20)]
		public InputDeviceMouseButtons Button { get; set; } = new InputDeviceMouseButtons(); // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public bool SimulateJoystickAxis { get; set; } // 0x18 (24)
		
		[ContainerField(25), LayoutImmutable, Blittable]
		public bool RememberExcessInput { get; set; } // 0x19 (25)
		
		[ContainerField(26), LayoutImmutable, Blittable]
		public bool ScaleScrollWheelAxisInput { get; set; } // 0x1A (26)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2686182099:
					Button = (InputDeviceMouseButtons) Enum.ToObject(typeof(InputDeviceMouseButtons), p_Value);
					break;

				case 3307710434:
					SimulateJoystickAxis = (bool) p_Value;
					break;

				case 1274294351:
					RememberExcessInput = (bool) p_Value;
					break;

				case 809122294:
					ScaleScrollWheelAxisInput = (bool) p_Value;
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

				case 3307710434:
					return SimulateJoystickAxis;

				case 1274294351:
					return RememberExcessInput;

				case 809122294:
					return ScaleScrollWheelAxisInput;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2686182099:
					return typeof(MouseInputActionData).GetProperty(nameof(Button));

				case 3307710434:
					return typeof(MouseInputActionData).GetProperty(nameof(SimulateJoystickAxis));

				case 1274294351:
					return typeof(MouseInputActionData).GetProperty(nameof(RememberExcessInput));

				case 809122294:
					return typeof(MouseInputActionData).GetProperty(nameof(ScaleScrollWheelAxisInput));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
