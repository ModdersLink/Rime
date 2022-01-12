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
	public class SyncedGameSettings : 
		SystemSettings
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float MaxAllowedLatency { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public float ManDownTimeModifier { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float BulletDamageModifier { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public uint DifficultyIndex { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public bool DisableRegenerateHealth { get; set; }

		[ContainerField(29), LayoutImmutable, Blittable]
		public bool EnableFriendlyFire { get; set; }

		[ContainerField(30), LayoutImmutable, Blittable]
		public bool AllowClientSideDamageArbitration { get; set; }

		[ContainerField(31), LayoutImmutable, Blittable]
		public bool DisableToggleEntryCamera { get; set; }

	}
}
