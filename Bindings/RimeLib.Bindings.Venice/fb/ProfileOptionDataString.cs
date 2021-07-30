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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 28)]
	public class ProfileOptionDataString : 
		ProfileOptionData
	{
		protected int m_MaxLength = new int();
		[ContainerField(Name: "MaxLength", Offset: 20, NameHash: 1300353773, Flags: 49405), LayoutImmutable, Blittable]
		public int MaxLength { get { return m_MaxLength; } set { if (OnPropertyChanging("ProfileOptionDataString." + nameof(MaxLength), this, m_MaxLength, value)) m_MaxLength = value; } } // 0x14 (20)
		
		protected string m_Value = string.Empty;
		[ContainerField(Name: "Value", Offset: 24, NameHash: 225375086, Flags: 16509), LayoutImmutable]
		public string Value { get { return m_Value; } set { if (OnPropertyChanging("ProfileOptionDataString." + nameof(Value), this, m_Value, value)) m_Value = value; } } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1300353773:
					MaxLength = (int) p_Value;
					break;

				case 225375086:
					Value = (string) p_Value;
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
				case 1300353773:
					return MaxLength;

				case 225375086:
					return Value;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1300353773:
					return typeof(ProfileOptionDataString).GetProperty(nameof(MaxLength));

				case 225375086:
					return typeof(ProfileOptionDataString).GetProperty(nameof(Value));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
