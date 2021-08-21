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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 112)]
	public class CharacterWeaponComponentData : 
		ComponentData
	{
		protected CtrRef<SoldierWeaponBlueprint> m_DefaultWeaponBlueprint = new CtrRef<SoldierWeaponBlueprint>();
		[ContainerField(Name: "DefaultWeaponBlueprint", Offset: 96, NameHash: 594340867, Flags: 53)]
		public CtrRef<SoldierWeaponBlueprint> DefaultWeaponBlueprint { get { return m_DefaultWeaponBlueprint; } set { if (OnPropertyChanging("CharacterWeaponComponentData." + nameof(DefaultWeaponBlueprint), this, m_DefaultWeaponBlueprint, value)) m_DefaultWeaponBlueprint = value; } } // 0x60 (96)
		
		protected string m_AimBoneName = string.Empty;
		[ContainerField(Name: "AimBoneName", Offset: 100, NameHash: 529553697, Flags: 16509), LayoutImmutable]
		public string AimBoneName { get { return m_AimBoneName; } set { if (OnPropertyChanging("CharacterWeaponComponentData." + nameof(AimBoneName), this, m_AimBoneName, value)) m_AimBoneName = value; } } // 0x64 (100)
		
		protected CtrRef<SkeletonAsset> m_WeaponSkeleton = new CtrRef<SkeletonAsset>();
		[ContainerField(Name: "WeaponSkeleton", Offset: 104, NameHash: 170547750, Flags: 53)]
		public CtrRef<SkeletonAsset> WeaponSkeleton { get { return m_WeaponSkeleton; } set { if (OnPropertyChanging("CharacterWeaponComponentData." + nameof(WeaponSkeleton), this, m_WeaponSkeleton, value)) m_WeaponSkeleton = value; } } // 0x68 (104)
		
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
