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
	public class IntUnlockValuePair : 
		UnlockValuePair
	{
		protected int m_DefaultValue = new int();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(2066049125)]
		public int DefaultValue { get { return m_DefaultValue; } set { if (OnPropertyChanging("IntUnlockValuePair." + nameof(DefaultValue), this, m_DefaultValue, value)) m_DefaultValue = value; } } // 0xC (12)
		
		protected int m_UnlockedValue = new int();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(2493912799)]
		public int UnlockedValue { get { return m_UnlockedValue; } set { if (OnPropertyChanging("IntUnlockValuePair." + nameof(UnlockedValue), this, m_UnlockedValue, value)) m_UnlockedValue = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2066049125:
					DefaultValue = (int) p_Value;
					break;

				case 2493912799:
					UnlockedValue = (int) p_Value;
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
					return typeof(IntUnlockValuePair).GetProperty(nameof(DefaultValue));

				case 2493912799:
					return typeof(IntUnlockValuePair).GetProperty(nameof(UnlockedValue));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
