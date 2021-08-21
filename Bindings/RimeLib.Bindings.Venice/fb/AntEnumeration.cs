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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 16)]
	public class AntEnumeration : 
		DataContainer
	{
		protected AntRef m_AntAsset = new AntRef();
		[ContainerField(Name: "AntAsset", Offset: 8, NameHash: 1873036974, Flags: 41)]
		public AntRef AntAsset { get { return m_AntAsset; } set { if (OnPropertyChanging("AntEnumeration." + nameof(AntAsset), this, m_AntAsset, value)) m_AntAsset = value; } } // 0x8 (8)
		
		protected int m_Value = new int();
		[ContainerField(Name: "Value", Offset: 12, NameHash: 225375086, Flags: 49405), LayoutImmutable, Blittable]
		public int Value { get { return m_Value; } set { if (OnPropertyChanging("AntEnumeration." + nameof(Value), this, m_Value, value)) m_Value = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1873036974:
					AntAsset = (AntRef) p_Value;
					break;

				case 225375086:
					Value = (int) p_Value;
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
				case 1873036974:
					return AntAsset;

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
				case 1873036974:
					return typeof(AntEnumeration).GetProperty(nameof(AntAsset));

				case 225375086:
					return typeof(AntEnumeration).GetProperty(nameof(Value));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
