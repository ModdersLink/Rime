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
	public class CameraEnterAreaTriggerEntityData : 
		EntityData
	{
		protected Realm m_Realm = new Realm();
		[ContainerField(Name: "Realm", Offset: 12, NameHash: 229961746, Flags: 137)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("CameraEnterAreaTriggerEntityData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0xC (12)
		
		protected float m_TimeTreshold = new float();
		[ContainerField(Name: "TimeTreshold", Offset: 16, NameHash: 2862696783, Flags: 49469), LayoutImmutable, Blittable]
		public float TimeTreshold { get { return m_TimeTreshold; } set { if (OnPropertyChanging("CameraEnterAreaTriggerEntityData." + nameof(TimeTreshold), this, m_TimeTreshold, value)) m_TimeTreshold = value; } } // 0x10 (16)
		
		protected UpdatePass m_UpdatePass = new UpdatePass();
		[ContainerField(Name: "UpdatePass", Offset: 20, NameHash: 2270785669, Flags: 137)]
		public UpdatePass UpdatePass { get { return m_UpdatePass; } set { if (OnPropertyChanging("CameraEnterAreaTriggerEntityData." + nameof(UpdatePass), this, m_UpdatePass, value)) m_UpdatePass = value; } } // 0x14 (20)
		
		protected bool m_AutoStart = new bool();
		[ContainerField(Name: "AutoStart", Offset: 24, NameHash: 792615882, Flags: 49325), LayoutImmutable, Blittable]
		public bool AutoStart { get { return m_AutoStart; } set { if (OnPropertyChanging("CameraEnterAreaTriggerEntityData." + nameof(AutoStart), this, m_AutoStart, value)) m_AutoStart = value; } } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 2862696783:
					TimeTreshold = (float) p_Value;
					break;

				case 2270785669:
					UpdatePass = (UpdatePass) Enum.ToObject(typeof(UpdatePass), p_Value);
					break;

				case 792615882:
					AutoStart = (bool) p_Value;
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

				case 2862696783:
					return TimeTreshold;

				case 2270785669:
					return UpdatePass;

				case 792615882:
					return AutoStart;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 229961746:
					return typeof(CameraEnterAreaTriggerEntityData).GetProperty(nameof(Realm));

				case 2862696783:
					return typeof(CameraEnterAreaTriggerEntityData).GetProperty(nameof(TimeTreshold));

				case 2270785669:
					return typeof(CameraEnterAreaTriggerEntityData).GetProperty(nameof(UpdatePass));

				case 792615882:
					return typeof(CameraEnterAreaTriggerEntityData).GetProperty(nameof(AutoStart));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
