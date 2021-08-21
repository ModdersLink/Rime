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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 28)]
	public class MouseInputActionData : 
		AxesInputActionData
	{
		protected InputDeviceMouseButtons m_Button = new InputDeviceMouseButtons();
		[ContainerField(Name: "Button", Offset: 20, NameHash: 2686182099, Flags: 137)]
		public InputDeviceMouseButtons Button { get { return m_Button; } set { if (OnPropertyChanging("MouseInputActionData." + nameof(Button), this, m_Button, value)) m_Button = value; } } // 0x14 (20)
		
		protected bool m_SimulateJoystickAxis = new bool();
		[ContainerField(Name: "SimulateJoystickAxis", Offset: 24, NameHash: 3307710434, Flags: 49325), LayoutImmutable, Blittable]
		public bool SimulateJoystickAxis { get { return m_SimulateJoystickAxis; } set { if (OnPropertyChanging("MouseInputActionData." + nameof(SimulateJoystickAxis), this, m_SimulateJoystickAxis, value)) m_SimulateJoystickAxis = value; } } // 0x18 (24)
		
		protected bool m_RememberExcessInput = new bool();
		[ContainerField(Name: "RememberExcessInput", Offset: 25, NameHash: 1274294351, Flags: 49325), LayoutImmutable, Blittable]
		public bool RememberExcessInput { get { return m_RememberExcessInput; } set { if (OnPropertyChanging("MouseInputActionData." + nameof(RememberExcessInput), this, m_RememberExcessInput, value)) m_RememberExcessInput = value; } } // 0x19 (25)
		
		protected bool m_ScaleScrollWheelAxisInput = new bool();
		[ContainerField(Name: "ScaleScrollWheelAxisInput", Offset: 26, NameHash: 809122294, Flags: 49325), LayoutImmutable, Blittable]
		public bool ScaleScrollWheelAxisInput { get { return m_ScaleScrollWheelAxisInput; } set { if (OnPropertyChanging("MouseInputActionData." + nameof(ScaleScrollWheelAxisInput), this, m_ScaleScrollWheelAxisInput, value)) m_ScaleScrollWheelAxisInput = value; } } // 0x1A (26)
		
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
