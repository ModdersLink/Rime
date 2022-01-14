///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 48)]
	public class LaserDesignatorData : 
		LockingWeaponData
	{
		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public float PostLockTime { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public float BomberTime { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public float BombWarnTime { get; set; }

		[ContainerField(44), JsonProperty(Order = 44)]
		public CtrRef<SoundAsset> BomberSound { get; set; } = new();

	}
}
