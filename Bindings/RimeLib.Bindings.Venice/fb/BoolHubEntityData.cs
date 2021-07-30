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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 24)]
	public class BoolHubEntityData : 
		EntityData
	{
		protected Realm m_Realm = new Realm();
		[ContainerField(Name: "Realm", Offset: 12, NameHash: 229961746, Flags: 137)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("BoolHubEntityData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0xC (12)
		
		protected int m_InputCount = new int();
		[ContainerField(Name: "InputCount", Offset: 16, NameHash: 1607263120, Flags: 49405), LayoutImmutable, Blittable]
		public int InputCount { get { return m_InputCount; } set { if (OnPropertyChanging("BoolHubEntityData." + nameof(InputCount), this, m_InputCount, value)) m_InputCount = value; } } // 0x10 (16)
		
		protected int m_InputSelect = new int();
		[ContainerField(Name: "InputSelect", Offset: 20, NameHash: 858290427, Flags: 49405), LayoutImmutable, Blittable]
		public int InputSelect { get { return m_InputSelect; } set { if (OnPropertyChanging("BoolHubEntityData." + nameof(InputSelect), this, m_InputSelect, value)) m_InputSelect = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 1607263120:
					InputCount = (int) p_Value;
					break;

				case 858290427:
					InputSelect = (int) p_Value;
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
				case 229961746:
					return Realm;

				case 1607263120:
					return InputCount;

				case 858290427:
					return InputSelect;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 229961746:
					return typeof(BoolHubEntityData).GetProperty(nameof(Realm));

				case 1607263120:
					return typeof(BoolHubEntityData).GetProperty(nameof(InputCount));

				case 858290427:
					return typeof(BoolHubEntityData).GetProperty(nameof(InputSelect));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
