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
	public class EventCompareGateEntityData : 
		EntityData
	{
		protected int m_Value = new int();
		[ContainerField(Name: "Value", Offset: 12, NameHash: 225375086, Flags: 49405), LayoutImmutable, Blittable]
		public int Value { get { return m_Value; } set { if (OnPropertyChanging("EventCompareGateEntityData." + nameof(Value), this, m_Value, value)) m_Value = value; } } // 0xC (12)
		
		protected EventCompareGateType m_CompareType = new EventCompareGateType();
		[ContainerField(Name: "CompareType", Offset: 16, NameHash: 1481809914, Flags: 137)]
		public EventCompareGateType CompareType { get { return m_CompareType; } set { if (OnPropertyChanging("EventCompareGateEntityData." + nameof(CompareType), this, m_CompareType, value)) m_CompareType = value; } } // 0x10 (16)
		
		protected Realm m_Realm = new Realm();
		[ContainerField(Name: "Realm", Offset: 20, NameHash: 229961746, Flags: 137)]
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
