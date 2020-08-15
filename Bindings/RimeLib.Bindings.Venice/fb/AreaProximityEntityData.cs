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
	[ContainerType(4)]
	public class AreaProximityEntityData : 
		EntityData
	{
		protected Realm m_Realm = new Realm();
		[ContainerField(12), ContainerFieldNameHash(229961746)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("AreaProximityEntityData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0xC (12)
		
		protected float m_ProximityDistance = new float();
		[ContainerField(16), LayoutImmutable, Blittable, ContainerFieldNameHash(3313540371)]
		public float ProximityDistance { get { return m_ProximityDistance; } set { if (OnPropertyChanging("AreaProximityEntityData." + nameof(ProximityDistance), this, m_ProximityDistance, value)) m_ProximityDistance = value; } } // 0x10 (16)
		
		protected UpdatePass m_UpdatePass = new UpdatePass();
		[ContainerField(20), ContainerFieldNameHash(2270785669)]
		public UpdatePass UpdatePass { get { return m_UpdatePass; } set { if (OnPropertyChanging("AreaProximityEntityData." + nameof(UpdatePass), this, m_UpdatePass, value)) m_UpdatePass = value; } } // 0x14 (20)
		
		protected bool m_AutoStart = new bool();
		[ContainerField(24), LayoutImmutable, Blittable, ContainerFieldNameHash(792615882)]
		public bool AutoStart { get { return m_AutoStart; } set { if (OnPropertyChanging("AreaProximityEntityData." + nameof(AutoStart), this, m_AutoStart, value)) m_AutoStart = value; } } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 3313540371:
					ProximityDistance = (float) p_Value;
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

				case 3313540371:
					return ProximityDistance;

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
					return typeof(AreaProximityEntityData).GetProperty(nameof(Realm));

				case 3313540371:
					return typeof(AreaProximityEntityData).GetProperty(nameof(ProximityDistance));

				case 2270785669:
					return typeof(AreaProximityEntityData).GetProperty(nameof(UpdatePass));

				case 792615882:
					return typeof(AreaProximityEntityData).GetProperty(nameof(AutoStart));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
