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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 12)]
	public class UnlockWeaponAndSlot : FrostbiteContainer
	{
		[ContainerField(Name: "Weapon", Offset: 0, NameHash: 3190562823, Flags: 53)]
		public CtrRef<SoldierWeaponUnlockAsset> Weapon { get; set; } = new CtrRef<SoldierWeaponUnlockAsset>(); // 0x0 (0)
		
		[ContainerField(Name: "Slot", Offset: 4, NameHash: 2089426785, Flags: 137)]
		public WeaponSlot Slot { get; set; } = new WeaponSlot(); // 0x4 (4)
		
		[ContainerField(Name: "UnlockAssets", Offset: 8, NameHash: 3332539414, Flags: 65)]
		public RefArray<UnlockAssetBase> UnlockAssets { get; set; } = new RefArray<UnlockAssetBase>(); // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3190562823:
					Weapon = (CtrRef<SoldierWeaponUnlockAsset>) p_Value;
					break;

				case 2089426785:
						Slot = (WeaponSlot) Enum.ToObject(typeof(WeaponSlot), p_Value);
					break;

				case 3332539414:
					UnlockAssets = (RefArray<UnlockAssetBase>) p_Value;
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
				case 3190562823:
					return Weapon;

				case 2089426785:
					return Slot;

				case 3332539414:
					return UnlockAssets;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3190562823:
					return typeof(UnlockWeaponAndSlot).GetProperty(nameof(Weapon));

				case 2089426785:
					return typeof(UnlockWeaponAndSlot).GetProperty(nameof(Slot));

				case 3332539414:
					return typeof(UnlockWeaponAndSlot).GetProperty(nameof(UnlockAssets));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
