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
	[ContainerType(4, 32)]
	public class WeaponUnlockPickupData
	{
		[ContainerField(0)]
		public UnlockWeaponAndSlot UnlockWeaponAndSlot { get; set; } = new();
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public int AltWeaponSlot { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public int LinkedToWeaponSlot { get; set; }
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public uint MinAmmo { get; set; }
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public uint MaxAmmo { get; set; }
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public bool DefaultToFullAmmo { get; set; }
		
	}
}
