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
	public class KeyboardInputActionData : 
		InputActionData
	{
		protected InputDeviceKeys m_Key = new InputDeviceKeys();
		[ContainerField(12), MemberInfoFlag(137), ContainerFieldNameHash(193457490)]
		public InputDeviceKeys Key { get { return m_Key; } set { if (OnPropertyChanging("KeyboardInputActionData." + nameof(Key), this, m_Key, value)) m_Key = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 193457490:
					Key = (InputDeviceKeys) Enum.ToObject(typeof(InputDeviceKeys), p_Value);
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
				case 193457490:
					return Key;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 193457490:
					return typeof(KeyboardInputActionData).GetProperty(nameof(Key));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
