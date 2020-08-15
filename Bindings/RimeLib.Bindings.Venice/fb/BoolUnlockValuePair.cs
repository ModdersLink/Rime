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
	public class BoolUnlockValuePair : 
		UnlockValuePair
	{
		protected bool m_DefaultValue = new bool();
		[ContainerField(12), LayoutImmutable, Blittable, ContainerFieldNameHash(2066049125)]
		public bool DefaultValue { get { return m_DefaultValue; } set { if (OnPropertyChanging("BoolUnlockValuePair." + nameof(DefaultValue), this, m_DefaultValue, value)) m_DefaultValue = value; } } // 0xC (12)
		
		protected bool m_UnlockedValue = new bool();
		[ContainerField(13), LayoutImmutable, Blittable, ContainerFieldNameHash(2493912799)]
		public bool UnlockedValue { get { return m_UnlockedValue; } set { if (OnPropertyChanging("BoolUnlockValuePair." + nameof(UnlockedValue), this, m_UnlockedValue, value)) m_UnlockedValue = value; } } // 0xD (13)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2066049125:
					DefaultValue = (bool) p_Value;
					break;

				case 2493912799:
					UnlockedValue = (bool) p_Value;
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
				case 2066049125:
					return DefaultValue;

				case 2493912799:
					return UnlockedValue;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2066049125:
					return typeof(BoolUnlockValuePair).GetProperty(nameof(DefaultValue));

				case 2493912799:
					return typeof(BoolUnlockValuePair).GetProperty(nameof(UnlockedValue));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
