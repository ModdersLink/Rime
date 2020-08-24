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
	[ContainerType(4), MemberInfoFlag(41), ContainerStruct]
	public class WeaponUnlockPickupData : FrostbiteContainer
	{
		[ContainerField(0), MemberInfoFlag(41)]
		public UnlockWeaponAndSlot UnlockWeaponAndSlot { get; set; } = new UnlockWeaponAndSlot(); // 0x0 (0)
		
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49405)]
		public int AltWeaponSlot { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49405)]
		public int LinkedToWeaponSlot { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49421)]
		public uint MinAmmo { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49421)]
		public uint MaxAmmo { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
		public bool DefaultToFullAmmo { get; set; } // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2966548408:
					UnlockWeaponAndSlot = (UnlockWeaponAndSlot) p_Value;
					break;

				case 2588912794:
					AltWeaponSlot = (int) p_Value;
					break;

				case 3974693081:
					LinkedToWeaponSlot = (int) p_Value;
					break;

				case 1012759905:
					MinAmmo = (uint) p_Value;
					break;

				case 1314148735:
					MaxAmmo = (uint) p_Value;
					break;

				case 471486984:
					DefaultToFullAmmo = (bool) p_Value;
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
				case 2966548408:
					return UnlockWeaponAndSlot;

				case 2588912794:
					return AltWeaponSlot;

				case 3974693081:
					return LinkedToWeaponSlot;

				case 1012759905:
					return MinAmmo;

				case 1314148735:
					return MaxAmmo;

				case 471486984:
					return DefaultToFullAmmo;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2966548408:
					return typeof(WeaponUnlockPickupData).GetProperty(nameof(UnlockWeaponAndSlot));

				case 2588912794:
					return typeof(WeaponUnlockPickupData).GetProperty(nameof(AltWeaponSlot));

				case 3974693081:
					return typeof(WeaponUnlockPickupData).GetProperty(nameof(LinkedToWeaponSlot));

				case 1012759905:
					return typeof(WeaponUnlockPickupData).GetProperty(nameof(MinAmmo));

				case 1314148735:
					return typeof(WeaponUnlockPickupData).GetProperty(nameof(MaxAmmo));

				case 471486984:
					return typeof(WeaponUnlockPickupData).GetProperty(nameof(DefaultToFullAmmo));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
