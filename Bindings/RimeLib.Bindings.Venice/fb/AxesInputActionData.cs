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
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class AxesInputActionData : 
		InputActionData
	{
		protected InputDeviceAxes m_Axis = new InputDeviceAxes();
		[ContainerField(12), MemberInfoFlag(137), ContainerFieldNameHash(2088662246)]
		public InputDeviceAxes Axis { get { return m_Axis; } set { if (OnPropertyChanging("AxesInputActionData." + nameof(Axis), this, m_Axis, value)) m_Axis = value; } } // 0xC (12)
		
		protected bool m_NormalizeInput = new bool();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(4067559830)]
		public bool NormalizeInput { get { return m_NormalizeInput; } set { if (OnPropertyChanging("AxesInputActionData." + nameof(NormalizeInput), this, m_NormalizeInput, value)) m_NormalizeInput = value; } } // 0x10 (16)
		
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
