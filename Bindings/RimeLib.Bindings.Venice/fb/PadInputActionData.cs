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
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 36)]
	public class PadInputActionData : 
		AxesInputActionData
	{
		protected InputDevicePadButtons m_Button = new InputDevicePadButtons();
		[ContainerField(Name: "Button", Offset: 20, NameHash: 2686182099, Flags: 137)]
		public InputDevicePadButtons Button { get { return m_Button; } set { if (OnPropertyChanging("PadInputActionData." + nameof(Button), this, m_Button, value)) m_Button = value; } } // 0x14 (20)
		
		protected InputDevicePOVs m_Pov = new InputDevicePOVs();
		[ContainerField(Name: "Pov", Offset: 24, NameHash: 193467468, Flags: 137)]
		public InputDevicePOVs Pov { get { return m_Pov; } set { if (OnPropertyChanging("PadInputActionData." + nameof(Pov), this, m_Pov, value)) m_Pov = value; } } // 0x18 (24)
		
		protected InputDevicePadButtons m_PS3AlternativeButton = new InputDevicePadButtons();
		[ContainerField(Name: "PS3AlternativeButton", Offset: 28, NameHash: 1772338028, Flags: 137)]
		public InputDevicePadButtons PS3AlternativeButton { get { return m_PS3AlternativeButton; } set { if (OnPropertyChanging("PadInputActionData." + nameof(PS3AlternativeButton), this, m_PS3AlternativeButton, value)) m_PS3AlternativeButton = value; } } // 0x1C (28)
		
		protected bool m_UseSquareInput = new bool();
		[ContainerField(Name: "UseSquareInput", Offset: 32, NameHash: 3247391921, Flags: 49325), LayoutImmutable, Blittable]
		public bool UseSquareInput { get { return m_UseSquareInput; } set { if (OnPropertyChanging("PadInputActionData." + nameof(UseSquareInput), this, m_UseSquareInput, value)) m_UseSquareInput = value; } } // 0x20 (32)
		
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
