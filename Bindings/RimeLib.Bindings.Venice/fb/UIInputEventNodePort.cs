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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(28), ContainerClass]
	public class UIInputEventNodePort : 
		UINodePort
	{
		protected UIInputAction m_InputEventType = new UIInputAction();
		[ContainerField(24), MemberInfoFlag(137), ContainerFieldNameHash(559387975)]
		public UIInputAction InputEventType { get { return m_InputEventType; } set { if (OnPropertyChanging("UIInputEventNodePort." + nameof(InputEventType), this, m_InputEventType, value)) m_InputEventType = value; } } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 559387975:
					InputEventType = (UIInputAction) Enum.ToObject(typeof(UIInputAction), p_Value);
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
				case 559387975:
					return InputEventType;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 559387975:
					return typeof(UIInputEventNodePort).GetProperty(nameof(InputEventType));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
