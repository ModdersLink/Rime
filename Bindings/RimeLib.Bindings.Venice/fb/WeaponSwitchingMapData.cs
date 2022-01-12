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
	[ContainerType(4, 16)]
	public class WeaponSwitchingMapData
	{
		[ContainerField(0)]
		public WeaponSwitchingEnum FromWeapon { get; set; } = new();
		
		[ContainerField(4)]
		public EntryInputActionEnum Action { get; set; } = new();
		
		[ContainerField(8)]
		public List<WeaponSwitchingEnum> ToWeapon { get; set; } = new();
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public bool FireAndSwitchBackToPrev { get; set; }
		
	}
}
