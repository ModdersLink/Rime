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
	public class EventCompareGateEntityData : 
		EntityData
	{
		protected int m_Value = new int();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(225375086)]
		public int Value { get { return m_Value; } set { if (OnPropertyChanging("EventCompareGateEntityData." + nameof(Value), this, m_Value, value)) m_Value = value; } } // 0xC (12)
		
		protected EventCompareGateType m_CompareType = new EventCompareGateType();
		[ContainerField(16), MemberInfoFlag(137), ContainerFieldNameHash(1481809914)]
		public EventCompareGateType CompareType { get { return m_CompareType; } set { if (OnPropertyChanging("EventCompareGateEntityData." + nameof(CompareType), this, m_CompareType, value)) m_CompareType = value; } } // 0x10 (16)
		
		protected Realm m_Realm = new Realm();
		[ContainerField(20), MemberInfoFlag(137), ContainerFieldNameHash(229961746)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("EventCompareGateEntityData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 225375086:
					Value = (int) p_Value;
					break;

				case 1481809914:
					CompareType = (EventCompareGateType) Enum.ToObject(typeof(EventCompareGateType), p_Value);
					break;

				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
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
				case 225375086:
					return Value;

				case 1481809914:
					return CompareType;

				case 229961746:
					return Realm;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 225375086:
					return typeof(EventCompareGateEntityData).GetProperty(nameof(Value));

				case 1481809914:
					return typeof(EventCompareGateEntityData).GetProperty(nameof(CompareType));

				case 229961746:
					return typeof(EventCompareGateEntityData).GetProperty(nameof(Realm));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
