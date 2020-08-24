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
	public class BoolToEventEntityData : 
		EntityData
	{
		protected Realm m_Realm = new Realm();
		[ContainerField(12), MemberInfoFlag(137), ContainerFieldNameHash(229961746)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("BoolToEventEntityData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0xC (12)
		
		protected bool m_Value = new bool();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(225375086)]
		public bool Value { get { return m_Value; } set { if (OnPropertyChanging("BoolToEventEntityData." + nameof(Value), this, m_Value, value)) m_Value = value; } } // 0x10 (16)
		
		protected bool m_InitalEvent = new bool();
		[ContainerField(17), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3855319582)]
		public bool InitalEvent { get { return m_InitalEvent; } set { if (OnPropertyChanging("BoolToEventEntityData." + nameof(InitalEvent), this, m_InitalEvent, value)) m_InitalEvent = value; } } // 0x11 (17)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 225375086:
					Value = (bool) p_Value;
					break;

				case 3855319582:
					InitalEvent = (bool) p_Value;
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

				case 225375086:
					return Value;

				case 3855319582:
					return InitalEvent;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 229961746:
					return typeof(BoolToEventEntityData).GetProperty(nameof(Realm));

				case 225375086:
					return typeof(BoolToEventEntityData).GetProperty(nameof(Value));

				case 3855319582:
					return typeof(BoolToEventEntityData).GetProperty(nameof(InitalEvent));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
