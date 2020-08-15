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
	[ContainerType(4)]
	public class InputActionData : 
		DataContainer
	{
		protected bool m_IsAnalog = new bool();
		[ContainerField(8), LayoutImmutable, Blittable, ContainerFieldNameHash(998391125)]
		public bool IsAnalog { get { return m_IsAnalog; } set { if (OnPropertyChanging("InputActionData." + nameof(IsAnalog), this, m_IsAnalog, value)) m_IsAnalog = value; } } // 0x8 (8)
		
		protected bool m_NegateValue = new bool();
		[ContainerField(9), LayoutImmutable, Blittable, ContainerFieldNameHash(928334002)]
		public bool NegateValue { get { return m_NegateValue; } set { if (OnPropertyChanging("InputActionData." + nameof(NegateValue), this, m_NegateValue, value)) m_NegateValue = value; } } // 0x9 (9)
		
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
