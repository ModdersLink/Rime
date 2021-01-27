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
	public class CompareBoolEntityData : 
		EntityData
	{
		protected Realm m_Realm = new Realm();
		[ContainerField(Name: "Realm", Offset: 12, NameHash: 229961746, Flags: 137)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("CompareBoolEntityData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0xC (12)
		
		protected bool m_Bool = new bool();
		[ContainerField(Name: "Bool", Offset: 16, NameHash: 2088812747, Flags: 49325), LayoutImmutable, Blittable]
		public bool Bool { get { return m_Bool; } set { if (OnPropertyChanging("CompareBoolEntityData." + nameof(Bool), this, m_Bool, value)) m_Bool = value; } } // 0x10 (16)
		
		protected bool m_TriggerOnPropertyChange = new bool();
		[ContainerField(Name: "TriggerOnPropertyChange", Offset: 17, NameHash: 3134109917, Flags: 49325), LayoutImmutable, Blittable]
		public bool TriggerOnPropertyChange { get { return m_TriggerOnPropertyChange; } set { if (OnPropertyChanging("CompareBoolEntityData." + nameof(TriggerOnPropertyChange), this, m_TriggerOnPropertyChange, value)) m_TriggerOnPropertyChange = value; } } // 0x11 (17)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 2088812747:
					Bool = (bool) p_Value;
					break;

				case 3134109917:
					TriggerOnPropertyChange = (bool) p_Value;
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

				case 2088812747:
					return Bool;

				case 3134109917:
					return TriggerOnPropertyChange;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 229961746:
					return typeof(CompareBoolEntityData).GetProperty(nameof(Realm));

				case 2088812747:
					return typeof(CompareBoolEntityData).GetProperty(nameof(Bool));

				case 3134109917:
					return typeof(CompareBoolEntityData).GetProperty(nameof(TriggerOnPropertyChange));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
