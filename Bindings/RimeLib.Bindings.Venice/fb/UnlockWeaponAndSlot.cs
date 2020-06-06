///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class UnlockWeaponAndSlot : FrostbiteContainer
	{
		[ContainerField(0)]
		public CtrRef<SoldierWeaponUnlockAsset> Weapon { get; set; } = new CtrRef<SoldierWeaponUnlockAsset>(); // 0x0 (0)
		
		[ContainerField(4)]
		public WeaponSlot Slot { get; set; } = new WeaponSlot(); // 0x4 (4)
		
		[ContainerField(8)]
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
