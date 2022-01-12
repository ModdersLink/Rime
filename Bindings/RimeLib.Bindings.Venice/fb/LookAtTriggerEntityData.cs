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
	[ContainerType(16, 144)]
	public class LookAtTriggerEntityData : 
		TriggerEventEntityData
	{
		[ContainerField(112), LayoutImmutable, Blittable]
		public float FOV { get; set; }

		[ContainerField(116)]
		public CtrRef<SoldierWeaponBlueprint> Weapon { get; set; } = new();

		[ContainerField(120), LayoutImmutable, Blittable]
		public uint ZoomLevel { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable]
		public float MinDistanceToObject { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable]
		public float MaxDistanceToObject { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable]
		public bool StartTriggerLookingAt { get; set; }

		[ContainerField(133), LayoutImmutable, Blittable]
		public bool CheckOcclusion { get; set; }

	}
}
