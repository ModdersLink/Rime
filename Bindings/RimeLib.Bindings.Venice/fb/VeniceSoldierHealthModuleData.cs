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
	[ContainerType(4, 164)]
	public class VeniceSoldierHealthModuleData : 
		SoldierHealthModuleData
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float TimeForCorpse { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable]
		public float PostReviveResponseTime { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public float InteractiveManDownThreshold { get; set; }

		[ContainerField(20)]
		public PoseConstraintsData InteractiveManDownPoseConstraints { get; set; } = new();

		[ContainerField(24), LayoutImmutable, Blittable]
		public float ManDownStateTime { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public float ManDownStateHealthPoints { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public float ImmortalTimeAfterSpawn { get; set; }

		[ContainerField(36)]
		public List<EntryInputActionEnum> AbortSpawnImmortalityInputs { get; set; } = new();

		[ContainerField(40), LayoutImmutable, Blittable]
		public float PostReviveHealth { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public float CriticalFakeImmortalTime { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public float RegenerationDelay { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable]
		public float RegenerationRate { get; set; }

		[ContainerField(56)]
		public SoldierHealthModuleBinding Binding { get; set; } = new();

		[ContainerField(148), LayoutImmutable, Blittable]
		public float SprintDisabledWhenDamagedTime { get; set; }

		[ContainerField(152), LayoutImmutable, Blittable]
		public float SprintDisabledDamageThreshold { get; set; }

		[ContainerField(156)]
		public RotateToHitData ManDownRotate { get; set; } = new();

		[ContainerField(160), LayoutImmutable, Blittable]
		public bool InteractiveManDown { get; set; }

	}
}
