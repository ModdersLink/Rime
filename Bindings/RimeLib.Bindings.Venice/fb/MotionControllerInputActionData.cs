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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 24)]
	public class MotionControllerInputActionData : 
		AxesInputActionData
	{
		protected InputDeviceMotionControllerButtons m_Button = new InputDeviceMotionControllerButtons();
		[ContainerField(Name: "Button", Offset: 20, NameHash: 2686182099, Flags: 137)]
		public InputDeviceMotionControllerButtons Button { get { return m_Button; } set { if (OnPropertyChanging("MotionControllerInputActionData." + nameof(Button), this, m_Button, value)) m_Button = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2686182099:
					Button = (InputDeviceMotionControllerButtons) Enum.ToObject(typeof(InputDeviceMotionControllerButtons), p_Value);
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

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2686182099:
					return typeof(MotionControllerInputActionData).GetProperty(nameof(Button));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
