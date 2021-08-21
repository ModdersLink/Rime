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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 24)]
	public class SoldierWeaponSwitchingData : 
		Asset
	{
		protected List<WeaponSwitchingMapData> m_SwitchMap = new List<WeaponSwitchingMapData>();
		[ContainerField(Name: "SwitchMap", Offset: 12, NameHash: 958053643, Flags: 65)]
		public List<WeaponSwitchingMapData> SwitchMap { get { return m_SwitchMap; } set { if (OnPropertyChanging("SoldierWeaponSwitchingData." + nameof(SwitchMap), this, m_SwitchMap, value)) m_SwitchMap = value; } } // 0xC (12)
		
		protected List<DirectWeaponSwitchingMapData> m_DirectSwitchMap = new List<DirectWeaponSwitchingMapData>();
		[ContainerField(Name: "DirectSwitchMap", Offset: 16, NameHash: 2207082534, Flags: 65)]
		public List<DirectWeaponSwitchingMapData> DirectSwitchMap { get { return m_DirectSwitchMap; } set { if (OnPropertyChanging("SoldierWeaponSwitchingData." + nameof(DirectSwitchMap), this, m_DirectSwitchMap, value)) m_DirectSwitchMap = value; } } // 0x10 (16)
		
		protected float m_SwitchToGadgetCooldownTime = new float();
		[ContainerField(Name: "SwitchToGadgetCooldownTime", Offset: 20, NameHash: 2738447440, Flags: 49469), LayoutImmutable, Blittable]
		public float SwitchToGadgetCooldownTime { get { return m_SwitchToGadgetCooldownTime; } set { if (OnPropertyChanging("SoldierWeaponSwitchingData." + nameof(SwitchToGadgetCooldownTime), this, m_SwitchToGadgetCooldownTime, value)) m_SwitchToGadgetCooldownTime = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 958053643:
					SwitchMap = (List<WeaponSwitchingMapData>) p_Value;
					break;

				case 2207082534:
					DirectSwitchMap = (List<DirectWeaponSwitchingMapData>) p_Value;
					break;

				case 2738447440:
					SwitchToGadgetCooldownTime = (float) p_Value;
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
				case 958053643:
					return SwitchMap;

				case 2207082534:
					return DirectSwitchMap;

				case 2738447440:
					return SwitchToGadgetCooldownTime;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 958053643:
					return typeof(SoldierWeaponSwitchingData).GetProperty(nameof(SwitchMap));

				case 2207082534:
					return typeof(SoldierWeaponSwitchingData).GetProperty(nameof(DirectSwitchMap));

				case 2738447440:
					return typeof(SoldierWeaponSwitchingData).GetProperty(nameof(SwitchToGadgetCooldownTime));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
