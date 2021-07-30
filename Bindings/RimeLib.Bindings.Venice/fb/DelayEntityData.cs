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
	public class DelayEntityData : 
		EntityData
	{
		protected float m_Delay = new float();
		[ContainerField(Name: "Delay", Offset: 12, NameHash: 208768368, Flags: 49469), LayoutImmutable, Blittable]
		public float Delay { get { return m_Delay; } set { if (OnPropertyChanging("DelayEntityData." + nameof(Delay), this, m_Delay, value)) m_Delay = value; } } // 0xC (12)
		
		protected Realm m_Realm = new Realm();
		[ContainerField(Name: "Realm", Offset: 16, NameHash: 229961746, Flags: 137)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("DelayEntityData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0x10 (16)
		
		protected bool m_AutoStart = new bool();
		[ContainerField(Name: "AutoStart", Offset: 20, NameHash: 792615882, Flags: 49325), LayoutImmutable, Blittable]
		public bool AutoStart { get { return m_AutoStart; } set { if (OnPropertyChanging("DelayEntityData." + nameof(AutoStart), this, m_AutoStart, value)) m_AutoStart = value; } } // 0x14 (20)
		
		protected bool m_RunOnce = new bool();
		[ContainerField(Name: "RunOnce", Offset: 21, NameHash: 709901739, Flags: 49325), LayoutImmutable, Blittable]
		public bool RunOnce { get { return m_RunOnce; } set { if (OnPropertyChanging("DelayEntityData." + nameof(RunOnce), this, m_RunOnce, value)) m_RunOnce = value; } } // 0x15 (21)
		
		protected bool m_RemoveDuplicateEvents = new bool();
		[ContainerField(Name: "RemoveDuplicateEvents", Offset: 22, NameHash: 2871488843, Flags: 49325), LayoutImmutable, Blittable]
		public bool RemoveDuplicateEvents { get { return m_RemoveDuplicateEvents; } set { if (OnPropertyChanging("DelayEntityData." + nameof(RemoveDuplicateEvents), this, m_RemoveDuplicateEvents, value)) m_RemoveDuplicateEvents = value; } } // 0x16 (22)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 208768368:
					Delay = (float) p_Value;
					break;

				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 792615882:
					AutoStart = (bool) p_Value;
					break;

				case 709901739:
					RunOnce = (bool) p_Value;
					break;

				case 2871488843:
					RemoveDuplicateEvents = (bool) p_Value;
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
				case 208768368:
					return Delay;

				case 229961746:
					return Realm;

				case 792615882:
					return AutoStart;

				case 709901739:
					return RunOnce;

				case 2871488843:
					return RemoveDuplicateEvents;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 208768368:
					return typeof(DelayEntityData).GetProperty(nameof(Delay));

				case 229961746:
					return typeof(DelayEntityData).GetProperty(nameof(Realm));

				case 792615882:
					return typeof(DelayEntityData).GetProperty(nameof(AutoStart));

				case 709901739:
					return typeof(DelayEntityData).GetProperty(nameof(RunOnce));

				case 2871488843:
					return typeof(DelayEntityData).GetProperty(nameof(RemoveDuplicateEvents));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
