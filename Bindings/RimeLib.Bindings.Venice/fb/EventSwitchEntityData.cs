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
	public class EventSwitchEntityData : 
		EntityData
	{
		protected Realm m_Realm = new Realm();
		[ContainerField(Name: "Realm", Offset: 12, NameHash: 229961746, Flags: 137)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("EventSwitchEntityData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0xC (12)
		
		protected uint m_OutEvents = new uint();
		[ContainerField(Name: "OutEvents", Offset: 16, NameHash: 2083855540, Flags: 49421), LayoutImmutable, Blittable]
		public uint OutEvents { get { return m_OutEvents; } set { if (OnPropertyChanging("EventSwitchEntityData." + nameof(OutEvents), this, m_OutEvents, value)) m_OutEvents = value; } } // 0x10 (16)
		
		protected bool m_AutoIncrement = new bool();
		[ContainerField(Name: "AutoIncrement", Offset: 20, NameHash: 1262167147, Flags: 49325), LayoutImmutable, Blittable]
		public bool AutoIncrement { get { return m_AutoIncrement; } set { if (OnPropertyChanging("EventSwitchEntityData." + nameof(AutoIncrement), this, m_AutoIncrement, value)) m_AutoIncrement = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 2083855540:
					OutEvents = (uint) p_Value;
					break;

				case 1262167147:
					AutoIncrement = (bool) p_Value;
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

				case 2083855540:
					return OutEvents;

				case 1262167147:
					return AutoIncrement;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 229961746:
					return typeof(EventSwitchEntityData).GetProperty(nameof(Realm));

				case 2083855540:
					return typeof(EventSwitchEntityData).GetProperty(nameof(OutEvents));

				case 1262167147:
					return typeof(EventSwitchEntityData).GetProperty(nameof(AutoIncrement));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
