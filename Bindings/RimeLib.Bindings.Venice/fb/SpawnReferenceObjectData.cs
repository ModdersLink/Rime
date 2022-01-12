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
	[ContainerType(16, 384)]
	public class SpawnReferenceObjectData : 
		ReferenceObjectData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform AirdropTransform { get; set; } = new();

		[ContainerField(160), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform ControllableInput { get; set; } = new();

		[ContainerField(224), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform ControllableTransform { get; set; } = new();

		[ContainerField(288), LayoutImmutable]
		public string LocationNameSid { get; set; } = string.Empty;

		[ContainerField(292), LayoutImmutable]
		public string LocationTextSid { get; set; } = string.Empty;

		[ContainerField(296)]
		public TeamId Team { get; set; } = new();

		[ContainerField(300), LayoutImmutable, Blittable]
		public uint SpawnProtectionFriendlyKilledCount { get; set; }

		[ContainerField(304), LayoutImmutable, Blittable]
		public float SpawnProtectionFriendlyKilledTime { get; set; }

		[ContainerField(308), LayoutImmutable, Blittable]
		public float RotationRoll { get; set; }

		[ContainerField(312), LayoutImmutable, Blittable]
		public float Throttle { get; set; }

		[ContainerField(316), LayoutImmutable, Blittable]
		public float InitialSpawnDelay { get; set; }

		[ContainerField(320), LayoutImmutable, Blittable]
		public float SpawnDelay { get; set; }

		[ContainerField(324), LayoutImmutable, Blittable]
		public int MaxCount { get; set; }

		[ContainerField(328), LayoutImmutable, Blittable]
		public int MaxCountSimultaneously { get; set; }

		[ContainerField(332), LayoutImmutable, Blittable]
		public int TotalCountSimultaneouslyOfType { get; set; }

		[ContainerField(336), LayoutImmutable, Blittable]
		public float SpawnAreaRadius { get; set; }

		[ContainerField(340), LayoutImmutable, Blittable]
		public float SpawnProtectionRadius { get; set; }

		[ContainerField(344), LayoutImmutable, Blittable]
		public float RotationYaw { get; set; }

		[ContainerField(348), LayoutImmutable, Blittable]
		public float RotationPitch { get; set; }

		[ContainerField(352), LayoutImmutable, Blittable]
		public float InitialVelocity { get; set; }

		[ContainerField(356), LayoutImmutable, Blittable]
		public int TakeControlEntryIndex { get; set; }

		[ContainerField(360), LayoutImmutable, Blittable]
		public bool SpawnProtectionCheckAllTeams { get; set; }

		[ContainerField(361), LayoutImmutable, Blittable]
		public bool ClearBangersOnSpawn { get; set; }

		[ContainerField(362), LayoutImmutable, Blittable]
		public bool TryToSpawnOutOfSight { get; set; }

		[ContainerField(363), LayoutImmutable, Blittable]
		public bool SendWeaponEvents { get; set; }

		[ContainerField(364), LayoutImmutable, Blittable]
		public bool TakeControlOnTransformChange { get; set; }

		[ContainerField(365), LayoutImmutable, Blittable]
		public bool ReturnControlOnIdle { get; set; }

		[ContainerField(366), LayoutImmutable, Blittable]
		public bool AutoSpawn { get; set; }

		[ContainerField(367), LayoutImmutable, Blittable]
		public bool UseAsSpawnPoint { get; set; }

		[ContainerField(368), LayoutImmutable, Blittable]
		public bool LockedTeam { get; set; }

		[ContainerField(369), LayoutImmutable, Blittable]
		public bool InitialAutoSpawn { get; set; }

		[ContainerField(370), LayoutImmutable, Blittable]
		public bool OverwriteThrottle { get; set; }

		[ContainerField(371), LayoutImmutable, Blittable]
		public bool OnlySendEventForHumanPlayers { get; set; }

		[ContainerField(372), LayoutImmutable, Blittable]
		public bool Enabled { get; set; }

		[ContainerField(373), LayoutImmutable, Blittable]
		public bool IsDynamicSpawn { get; set; }

	}
}
