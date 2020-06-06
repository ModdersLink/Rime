///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class CharacterWeaponComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public CtrRef<SoldierWeaponBlueprint> DefaultWeaponBlueprint { get; set; } = new CtrRef<SoldierWeaponBlueprint>(); // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable]
		public string AimBoneName { get; set; } // 0x64 (100)
		
		[ContainerField(104)]
		public CtrRef<SkeletonAsset> WeaponSkeleton { get; set; } = new CtrRef<SkeletonAsset>(); // 0x68 (104)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 594340867:
					DefaultWeaponBlueprint = (CtrRef<SoldierWeaponBlueprint>) p_Value;
					break;

				case 529553697:
					AimBoneName = (string) p_Value;
					break;

				case 170547750:
					WeaponSkeleton = (CtrRef<SkeletonAsset>) p_Value;
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
				case 594340867:
					return DefaultWeaponBlueprint;

				case 529553697:
					return AimBoneName;

				case 170547750:
					return WeaponSkeleton;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 594340867:
					return typeof(CharacterWeaponComponentData).GetProperty(nameof(DefaultWeaponBlueprint));

				case 529553697:
					return typeof(CharacterWeaponComponentData).GetProperty(nameof(AimBoneName));

				case 170547750:
					return typeof(CharacterWeaponComponentData).GetProperty(nameof(WeaponSkeleton));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
