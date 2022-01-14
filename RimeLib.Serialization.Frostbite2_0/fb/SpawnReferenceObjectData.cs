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
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(16, 384)]
	public class SpawnReferenceObjectData :
		ReferenceObjectData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public LinearTransform AirdropTransform { get; set; } = new();

		[ContainerField(160), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		public LinearTransform ControllableInput { get; set; } = new();

		[ContainerField(224), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 224)]
		public LinearTransform ControllableTransform { get; set; } = new();

		[ContainerField(288), LayoutImmutable, JsonProperty(Order = 288)]
		public string LocationNameSid { get; set; } = string.Empty;

		[ContainerField(292), LayoutImmutable, JsonProperty(Order = 292)]
		public string LocationTextSid { get; set; } = string.Empty;

		[ContainerField(296), JsonProperty(Order = 296)]
		public TeamId Team { get; set; } = new();

		[ContainerField(300), LayoutImmutable, Blittable, JsonProperty(Order = 300)]
		public uint SpawnProtectionFriendlyKilledCount { get; set; }

		[ContainerField(304), LayoutImmutable, Blittable, JsonProperty(Order = 304)]
		public float SpawnProtectionFriendlyKilledTime { get; set; }

		[ContainerField(308), LayoutImmutable, Blittable, JsonProperty(Order = 308)]
		public float RotationRoll { get; set; }

		[ContainerField(312), LayoutImmutable, Blittable, JsonProperty(Order = 312)]
		public float Throttle { get; set; }

		[ContainerField(316), LayoutImmutable, Blittable, JsonProperty(Order = 316)]
		public float InitialSpawnDelay { get; set; }

		[ContainerField(320), LayoutImmutable, Blittable, JsonProperty(Order = 320)]
		public float SpawnDelay { get; set; }

		[ContainerField(324), LayoutImmutable, Blittable, JsonProperty(Order = 324)]
		public int MaxCount { get; set; }

		[ContainerField(328), LayoutImmutable, Blittable, JsonProperty(Order = 328)]
		public int MaxCountSimultaneously { get; set; }

		[ContainerField(332), LayoutImmutable, Blittable, JsonProperty(Order = 332)]
		public int TotalCountSimultaneouslyOfType { get; set; }

		[ContainerField(336), LayoutImmutable, Blittable, JsonProperty(Order = 336)]
		public float SpawnAreaRadius { get; set; }

		[ContainerField(340), LayoutImmutable, Blittable, JsonProperty(Order = 340)]
		public float SpawnProtectionRadius { get; set; }

		[ContainerField(344), LayoutImmutable, Blittable, JsonProperty(Order = 344)]
		public float RotationYaw { get; set; }

		[ContainerField(348), LayoutImmutable, Blittable, JsonProperty(Order = 348)]
		public float RotationPitch { get; set; }

		[ContainerField(352), LayoutImmutable, Blittable, JsonProperty(Order = 352)]
		public float InitialVelocity { get; set; }

		[ContainerField(356), LayoutImmutable, Blittable, JsonProperty(Order = 356)]
		public int TakeControlEntryIndex { get; set; }

		[ContainerField(360), LayoutImmutable, Blittable, JsonProperty(Order = 360)]
		public bool SpawnProtectionCheckAllTeams { get; set; }

		[ContainerField(361), LayoutImmutable, Blittable, JsonProperty(Order = 361)]
		public bool ClearBangersOnSpawn { get; set; }

		[ContainerField(362), LayoutImmutable, Blittable, JsonProperty(Order = 362)]
		public bool TryToSpawnOutOfSight { get; set; }

		[ContainerField(363), LayoutImmutable, Blittable, JsonProperty(Order = 363)]
		public bool SendWeaponEvents { get; set; }

		[ContainerField(364), LayoutImmutable, Blittable, JsonProperty(Order = 364)]
		public bool TakeControlOnTransformChange { get; set; }

		[ContainerField(365), LayoutImmutable, Blittable, JsonProperty(Order = 365)]
		public bool ReturnControlOnIdle { get; set; }

		[ContainerField(366), LayoutImmutable, Blittable, JsonProperty(Order = 366)]
		public bool AutoSpawn { get; set; }

		[ContainerField(367), LayoutImmutable, Blittable, JsonProperty(Order = 367)]
		public bool UseAsSpawnPoint { get; set; }

		[ContainerField(368), LayoutImmutable, Blittable, JsonProperty(Order = 368)]
		public bool LockedTeam { get; set; }

		[ContainerField(369), LayoutImmutable, Blittable, JsonProperty(Order = 369)]
		public bool InitialAutoSpawn { get; set; }

		[ContainerField(370), LayoutImmutable, Blittable, JsonProperty(Order = 370)]
		public bool OverwriteThrottle { get; set; }

		[ContainerField(371), LayoutImmutable, Blittable, JsonProperty(Order = 371)]
		public bool OnlySendEventForHumanPlayers { get; set; }

		[ContainerField(372), LayoutImmutable, Blittable, JsonProperty(Order = 372)]
		public bool Enabled { get; set; }

		[ContainerField(373), LayoutImmutable, Blittable, JsonProperty(Order = 373)]
		public bool IsDynamicSpawn { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			AirdropTransform.Serialize(p_Writer, p_EbxWriter);
			ControllableInput.Serialize(p_Writer, p_EbxWriter);
			ControllableTransform.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(LocationNameSid));
			p_Writer.Write(p_EbxWriter.WriteString(LocationTextSid));
			p_Writer.Write((int) Team);
			p_Writer.Write(SpawnProtectionFriendlyKilledCount);
			p_Writer.Write(SpawnProtectionFriendlyKilledTime);
			p_Writer.Write(RotationRoll);
			p_Writer.Write(Throttle);
			p_Writer.Write(InitialSpawnDelay);
			p_Writer.Write(SpawnDelay);
			p_Writer.Write(MaxCount);
			p_Writer.Write(MaxCountSimultaneously);
			p_Writer.Write(TotalCountSimultaneouslyOfType);
			p_Writer.Write(SpawnAreaRadius);
			p_Writer.Write(SpawnProtectionRadius);
			p_Writer.Write(RotationYaw);
			p_Writer.Write(RotationPitch);
			p_Writer.Write(InitialVelocity);
			p_Writer.Write(TakeControlEntryIndex);
			p_Writer.Write(SpawnProtectionCheckAllTeams);
			p_Writer.Write(ClearBangersOnSpawn);
			p_Writer.Write(TryToSpawnOutOfSight);
			p_Writer.Write(SendWeaponEvents);
			p_Writer.Write(TakeControlOnTransformChange);
			p_Writer.Write(ReturnControlOnIdle);
			p_Writer.Write(AutoSpawn);
			p_Writer.Write(UseAsSpawnPoint);
			p_Writer.Write(LockedTeam);
			p_Writer.Write(InitialAutoSpawn);
			p_Writer.Write(OverwriteThrottle);
			p_Writer.Write(OnlySendEventForHumanPlayers);
			p_Writer.Write(Enabled);
			p_Writer.Write(IsDynamicSpawn);
			p_Writer.WriteNullBytes(10);
		}
	}
}
