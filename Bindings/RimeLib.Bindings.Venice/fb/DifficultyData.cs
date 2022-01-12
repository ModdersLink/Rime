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
	[ContainerType(16, 128)]
	public class DifficultyData : 
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 StickyBoxModifier { get; set; } = new();

		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 SnapBoxModifier { get; set; } = new();

		[ContainerField(48), LayoutImmutable, Blittable]
		public float HumanHealthModifier { get; set; }

		[ContainerField(52)]
		public PersistenceGameType GameType { get; set; } = new();

		[ContainerField(56), LayoutImmutable, Blittable]
		public float FriendsHealthModifier { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable]
		public float FriendlyDamageModifier { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable]
		public float VehicleDamageModifier { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable]
		public float HumanInCriticalHealth { get; set; }

		[ContainerField(72), LayoutImmutable, Blittable]
		public float EnemiesHealthModifier { get; set; }

		[ContainerField(76), LayoutImmutable, Blittable]
		public float HumanRegenerationRateModifier { get; set; }

		[ContainerField(80), LayoutImmutable, Blittable]
		public float HumanInCriticalHealthDamageModifier { get; set; }

		[ContainerField(84), LayoutImmutable, Blittable]
		public float InteractiveManDownDamageModifier { get; set; }

		[ContainerField(88), LayoutImmutable, Blittable]
		public float InteractiveManDownTimeMultiplier { get; set; }

		[ContainerField(92), LayoutImmutable, Blittable]
		public float InteractiveManDownReviveTime { get; set; }

		[ContainerField(96), LayoutImmutable, Blittable]
		public int AdrenalineKillLimit { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable]
		public float CriticalHealthJesusModeTimeModifier { get; set; }

		[ContainerField(104)]
		public Difficulty Difficulty { get; set; } = new();

		[ContainerField(108), LayoutImmutable, Blittable]
		public float CriticalFakeImmortalModifier { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable]
		public float SuckZoomModifier { get; set; }

		[ContainerField(116)]
		public CtrRef<GameAIDifficultyData> AIData { get; set; } = new();

		[ContainerField(120), LayoutImmutable, Blittable]
		public float AiBulletDamageHumanCooldown { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable]
		public bool UsePitchZoomSnap { get; set; }

	}
}
