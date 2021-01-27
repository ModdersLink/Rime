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
	public class PropertyCastEntityData : 
		EntityData
	{
		protected Realm m_Realm = new Realm();
		[ContainerField(Name: "Realm", Offset: 12, NameHash: 229961746, Flags: 137)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("PropertyCastEntityData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0xC (12)
		
		protected int m_IntValue = new int();
		[ContainerField(Name: "IntValue", Offset: 16, NameHash: 5685821, Flags: 49405), LayoutImmutable, Blittable]
		public int IntValue { get { return m_IntValue; } set { if (OnPropertyChanging("PropertyCastEntityData." + nameof(IntValue), this, m_IntValue, value)) m_IntValue = value; } } // 0x10 (16)
		
		protected float m_FloatValue = new float();
		[ContainerField(Name: "FloatValue", Offset: 20, NameHash: 3123792190, Flags: 49469), LayoutImmutable, Blittable]
		public float FloatValue { get { return m_FloatValue; } set { if (OnPropertyChanging("PropertyCastEntityData." + nameof(FloatValue), this, m_FloatValue, value)) m_FloatValue = value; } } // 0x14 (20)
		
		protected bool m_BoolValue = new bool();
		[ContainerField(Name: "BoolValue", Offset: 24, NameHash: 176040160, Flags: 49325), LayoutImmutable, Blittable]
		public bool BoolValue { get { return m_BoolValue; } set { if (OnPropertyChanging("PropertyCastEntityData." + nameof(BoolValue), this, m_BoolValue, value)) m_BoolValue = value; } } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 5685821:
					IntValue = (int) p_Value;
					break;

				case 3123792190:
					FloatValue = (float) p_Value;
					break;

				case 176040160:
					BoolValue = (bool) p_Value;
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

				case 5685821:
					return IntValue;

				case 3123792190:
					return FloatValue;

				case 176040160:
					return BoolValue;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 229961746:
					return typeof(PropertyCastEntityData).GetProperty(nameof(Realm));

				case 5685821:
					return typeof(PropertyCastEntityData).GetProperty(nameof(IntValue));

				case 3123792190:
					return typeof(PropertyCastEntityData).GetProperty(nameof(FloatValue));

				case 176040160:
					return typeof(PropertyCastEntityData).GetProperty(nameof(BoolValue));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
