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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 20)]
	public class XorEntityData : 
		EntityData
	{
		protected Realm m_Realm = new Realm();
		[ContainerField(Name: "Realm", Offset: 12, NameHash: 229961746, Flags: 137)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("XorEntityData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0xC (12)
		
		protected bool m_In1 = new bool();
		[ContainerField(Name: "In1", Offset: 16, NameHash: 193450867, Flags: 49325), LayoutImmutable, Blittable]
		public bool In1 { get { return m_In1; } set { if (OnPropertyChanging("XorEntityData." + nameof(In1), this, m_In1, value)) m_In1 = value; } } // 0x10 (16)
		
		protected bool m_In2 = new bool();
		[ContainerField(Name: "In2", Offset: 17, NameHash: 193450864, Flags: 49325), LayoutImmutable, Blittable]
		public bool In2 { get { return m_In2; } set { if (OnPropertyChanging("XorEntityData." + nameof(In2), this, m_In2, value)) m_In2 = value; } } // 0x11 (17)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 193450867:
					In1 = (bool) p_Value;
					break;

				case 193450864:
					In2 = (bool) p_Value;
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

				case 193450867:
					return In1;

				case 193450864:
					return In2;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 229961746:
					return typeof(XorEntityData).GetProperty(nameof(Realm));

				case 193450867:
					return typeof(XorEntityData).GetProperty(nameof(In1));

				case 193450864:
					return typeof(XorEntityData).GetProperty(nameof(In2));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
