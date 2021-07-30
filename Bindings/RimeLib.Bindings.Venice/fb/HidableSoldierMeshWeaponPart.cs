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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 16)]
	public class HidableSoldierMeshWeaponPart : FrostbiteContainer
	{
		[ContainerField(Name: "WeaponMesh", Offset: 0, NameHash: 932694772, Flags: 53)]
		public CtrRef<SkinnedMeshAsset> WeaponMesh { get; set; } = new CtrRef<SkinnedMeshAsset>(); // 0x0 (0)
		
		[ContainerField(Name: "WeaponMeshBlueprint", Offset: 4, NameHash: 2920048859, Flags: 53)]
		public CtrRef<ObjectBlueprint> WeaponMeshBlueprint { get; set; } = new CtrRef<ObjectBlueprint>(); // 0x4 (4)
		
		[ContainerField(Name: "BoneName", Offset: 8, NameHash: 1590647844, Flags: 16509), LayoutImmutable]
		public string BoneName { get; set; } // 0x8 (8)
		
		[ContainerField(Name: "HideAlways", Offset: 12, NameHash: 2500652980, Flags: 49325), LayoutImmutable, Blittable]
		public bool HideAlways { get; set; } // 0xC (12)
		
		[ContainerField(Name: "HideInVehicleEntries", Offset: 13, NameHash: 3302625928, Flags: 49325), LayoutImmutable, Blittable]
		public bool HideInVehicleEntries { get; set; } // 0xD (13)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 932694772:
					WeaponMesh = (CtrRef<SkinnedMeshAsset>) p_Value;
					break;

				case 2920048859:
					WeaponMeshBlueprint = (CtrRef<ObjectBlueprint>) p_Value;
					break;

				case 1590647844:
					BoneName = (string) p_Value;
					break;

				case 2500652980:
					HideAlways = (bool) p_Value;
					break;

				case 3302625928:
					HideInVehicleEntries = (bool) p_Value;
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
				case 932694772:
					return WeaponMesh;

				case 2920048859:
					return WeaponMeshBlueprint;

				case 1590647844:
					return BoneName;

				case 2500652980:
					return HideAlways;

				case 3302625928:
					return HideInVehicleEntries;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 932694772:
					return typeof(HidableSoldierMeshWeaponPart).GetProperty(nameof(WeaponMesh));

				case 2920048859:
					return typeof(HidableSoldierMeshWeaponPart).GetProperty(nameof(WeaponMeshBlueprint));

				case 1590647844:
					return typeof(HidableSoldierMeshWeaponPart).GetProperty(nameof(BoneName));

				case 2500652980:
					return typeof(HidableSoldierMeshWeaponPart).GetProperty(nameof(HideAlways));

				case 3302625928:
					return typeof(HidableSoldierMeshWeaponPart).GetProperty(nameof(HideInVehicleEntries));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
