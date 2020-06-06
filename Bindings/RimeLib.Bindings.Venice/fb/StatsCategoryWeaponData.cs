///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class StatsCategoryWeaponData : 
		StatsCategoryGuidData
	{
		[ContainerField(24), LayoutImmutable, Blittable]
		public uint SoldierWeaponId { get; set; } // 0x18 (24)
		
		[ContainerField(28)]
		public CtrRef<CriteriaGateList> AccessoryUnlockGates { get; set; } = new CtrRef<CriteriaGateList>(); // 0x1C (28)
		
		[ContainerField(32)]
		public List<BasicUnlockInfo> UnlocksInfo { get; set; } = new List<BasicUnlockInfo>(); // 0x20 (32)
		
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
