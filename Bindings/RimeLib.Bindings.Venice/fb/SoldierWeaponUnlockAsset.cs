///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class SoldierWeaponUnlockAsset : 
		UnlockAssetBase
	{
		[ContainerField(40)]
		public CtrRef<SoldierWeaponBlueprint> Weapon { get; set; } = new CtrRef<SoldierWeaponBlueprint>(); // 0x28 (40)
		
		[ContainerField(44)]
		public CtrRef<UnlockAssetBase> Extra { get; set; } = new CtrRef<UnlockAssetBase>(); // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public uint WeaponIdentifier { get; set; } // 0x30 (48)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3190562823:
					Weapon = (CtrRef<SoldierWeaponBlueprint>) p_Value;
					break;

				case 201622975:
					Extra = (CtrRef<UnlockAssetBase>) p_Value;
					break;

				case 222597316:
					WeaponIdentifier = (uint) p_Value;
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

				case 201622975:
					return Extra;

				case 222597316:
					return WeaponIdentifier;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3190562823:
					return typeof(SoldierWeaponUnlockAsset).GetProperty(nameof(Weapon));

				case 201622975:
					return typeof(SoldierWeaponUnlockAsset).GetProperty(nameof(Extra));

				case 222597316:
					return typeof(SoldierWeaponUnlockAsset).GetProperty(nameof(WeaponIdentifier));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
