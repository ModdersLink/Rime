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
	[ContainerType(16, 256)]
	public class ExplosionPackEntityData : 
		MeshProjectileEntityData
	{
		[ContainerField(192), LayoutImmutable, Blittable]
		public float TimeToLiveOnPlayerDeath { get; set; }

		[ContainerField(196)]
		public SoldierDetonationData SoldierDetonationData { get; set; } = new();

		[ContainerField(216), LayoutImmutable, Blittable]
		public float VehicleDetonationActivationDelay { get; set; }

		[ContainerField(220), LayoutImmutable, Blittable]
		public float VehicleDetonationRadius { get; set; }

		[ContainerField(224)]
		public UIHudIcon Icon { get; set; } = new();

		[ContainerField(228), LayoutImmutable, Blittable]
		public float SpottedTime { get; set; }

		[ContainerField(232), LayoutImmutable, Blittable]
		public float DefuseRadius { get; set; }

		[ContainerField(236), LayoutImmutable, Blittable]
		public float Health { get; set; }

		[ContainerField(240), LayoutImmutable, Blittable]
		public bool HasRemoteDetonator { get; set; }

		[ContainerField(241), LayoutImmutable, Blittable]
		public bool IsDestructible { get; set; }

		[ContainerField(242), LayoutImmutable, Blittable]
		public bool HasVehicleDetonation { get; set; }

		[ContainerField(243), LayoutImmutable, Blittable]
		public bool ReceivesExplosionDamage { get; set; }

	}
}
