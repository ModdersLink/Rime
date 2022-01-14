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
	[ContainerType(4, 32)]
	public class LockingWeaponData : 
		WeaponData
	{
		[ContainerField(16), JsonProperty(Order = 16)]
		public CtrRef<LockingControllerData> LockingController { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public CtrRef<LockingControllerData> SecondaryLockingController { get; set; } = new();

		[ContainerField(24), JsonProperty(Order = 24)]
		public WarnTarget WarnLock { get; set; } = new();

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public bool IsHoming { get; set; }

		[ContainerField(29), LayoutImmutable, Blittable, JsonProperty(Order = 29)]
		public bool IsGuidedWhenZoomed { get; set; }

		[ContainerField(30), LayoutImmutable, Blittable, JsonProperty(Order = 30)]
		public bool FireOnlyWhenLockedOn { get; set; }

		[ContainerField(31), LayoutImmutable, Blittable, JsonProperty(Order = 31)]
		public bool IsGuided { get; set; }

	}
}
