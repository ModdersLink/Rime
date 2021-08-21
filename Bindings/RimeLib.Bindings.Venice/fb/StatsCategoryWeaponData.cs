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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 36)]
	public class StatsCategoryWeaponData : 
		StatsCategoryGuidData
	{
		protected uint m_SoldierWeaponId = new uint();
		[ContainerField(Name: "SoldierWeaponId", Offset: 24, NameHash: 3007685600, Flags: 49421), LayoutImmutable, Blittable]
		public uint SoldierWeaponId { get { return m_SoldierWeaponId; } set { if (OnPropertyChanging("StatsCategoryWeaponData." + nameof(SoldierWeaponId), this, m_SoldierWeaponId, value)) m_SoldierWeaponId = value; } } // 0x18 (24)
		
		protected CtrRef<CriteriaGateList> m_AccessoryUnlockGates = new CtrRef<CriteriaGateList>();
		[ContainerField(Name: "AccessoryUnlockGates", Offset: 28, NameHash: 3719366417, Flags: 53)]
		public CtrRef<CriteriaGateList> AccessoryUnlockGates { get { return m_AccessoryUnlockGates; } set { if (OnPropertyChanging("StatsCategoryWeaponData." + nameof(AccessoryUnlockGates), this, m_AccessoryUnlockGates, value)) m_AccessoryUnlockGates = value; } } // 0x1C (28)
		
		protected List<BasicUnlockInfo> m_UnlocksInfo = new List<BasicUnlockInfo>();
		[ContainerField(Name: "UnlocksInfo", Offset: 32, NameHash: 4161073128, Flags: 65)]
		public List<BasicUnlockInfo> UnlocksInfo { get { return m_UnlocksInfo; } set { if (OnPropertyChanging("StatsCategoryWeaponData." + nameof(UnlocksInfo), this, m_UnlocksInfo, value)) m_UnlocksInfo = value; } } // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3007685600:
					SoldierWeaponId = (uint) p_Value;
					break;

				case 3719366417:
					AccessoryUnlockGates = (CtrRef<CriteriaGateList>) p_Value;
					break;

				case 4161073128:
					UnlocksInfo = (List<BasicUnlockInfo>) p_Value;
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
				case 3007685600:
					return SoldierWeaponId;

				case 3719366417:
					return AccessoryUnlockGates;

				case 4161073128:
					return UnlocksInfo;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3007685600:
					return typeof(StatsCategoryWeaponData).GetProperty(nameof(SoldierWeaponId));

				case 3719366417:
					return typeof(StatsCategoryWeaponData).GetProperty(nameof(AccessoryUnlockGates));

				case 4161073128:
					return typeof(StatsCategoryWeaponData).GetProperty(nameof(UnlocksInfo));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
