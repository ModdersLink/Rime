///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 24)]
	public class WeaponPickupData
	{
		[ContainerField(0)]
		public CtrRef<SoldierWeaponBlueprint> Weapon { get; set; } = new();
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public uint WeaponSlot { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public int AltWeaponSlot { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public int LinkedToWeaponSlot { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public uint MinAmmo { get; set; }
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public uint MaxAmmo { get; set; }
		
	}
}
