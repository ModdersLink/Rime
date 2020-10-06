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
	[ContainerType(16), MemberInfoFlag(53), ContainerSize(192), ContainerClass]
	public class KitPickupEntityData : 
		PickupEntityData
	{
		protected bool m_KeepAdditionalWeapons = new bool();
		[ContainerField(176), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2585816246)]
		public bool KeepAdditionalWeapons { get { return m_KeepAdditionalWeapons; } set { if (OnPropertyChanging("KitPickupEntityData." + nameof(KeepAdditionalWeapons), this, m_KeepAdditionalWeapons, value)) m_KeepAdditionalWeapons = value; } } // 0xB0 (176)
		
		protected bool m_KeepAmmoState = new bool();
		[ContainerField(177), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2997013959)]
		public bool KeepAmmoState { get { return m_KeepAmmoState; } set { if (OnPropertyChanging("KitPickupEntityData." + nameof(KeepAmmoState), this, m_KeepAmmoState, value)) m_KeepAmmoState = value; } } // 0xB1 (177)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2585816246:
					KeepAdditionalWeapons = (bool) p_Value;
					break;

				case 2997013959:
					KeepAmmoState = (bool) p_Value;
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
				case 2585816246:
					return KeepAdditionalWeapons;

				case 2997013959:
					return KeepAmmoState;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2585816246:
					return typeof(KitPickupEntityData).GetProperty(nameof(KeepAdditionalWeapons));

				case 2997013959:
					return typeof(KitPickupEntityData).GetProperty(nameof(KeepAmmoState));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
