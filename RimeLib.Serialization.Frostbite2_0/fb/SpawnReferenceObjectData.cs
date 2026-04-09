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
using RimeLib.Serialization.Frostbite2_0.Ebx;
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(16, 384)]
	public partial class SpawnReferenceObjectData :
		ReferenceObjectData
	{
		[ObservableProperty]
		[property: ContainerField(96), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private LinearTransform _AirdropTransform = new();

		[ObservableProperty]
		[property: ContainerField(160), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		private LinearTransform _ControllableInput = new();

		[ObservableProperty]
		[property: ContainerField(224), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 224)]
		private LinearTransform _ControllableTransform = new();

		[ObservableProperty]
		[property: ContainerField(288), LayoutImmutable, JsonProperty(Order = 288)]
		private string _LocationNameSid = string.Empty;

		[ObservableProperty]
		[property: ContainerField(292), LayoutImmutable, JsonProperty(Order = 292)]
		private string _LocationTextSid = string.Empty;

		[ObservableProperty]
		[property: ContainerField(296), JsonProperty(Order = 296)]
		private TeamId _Team = new();

		[ObservableProperty]
		[property: ContainerField(300), LayoutImmutable, Blittable, JsonProperty(Order = 300)]
		private uint _SpawnProtectionFriendlyKilledCount;

		[ObservableProperty]
		[property: ContainerField(304), LayoutImmutable, Blittable, JsonProperty(Order = 304)]
		private float _SpawnProtectionFriendlyKilledTime;

		[ObservableProperty]
		[property: ContainerField(308), LayoutImmutable, Blittable, JsonProperty(Order = 308)]
		private float _RotationRoll;

		[ObservableProperty]
		[property: ContainerField(312), LayoutImmutable, Blittable, JsonProperty(Order = 312)]
		private float _Throttle;

		[ObservableProperty]
		[property: ContainerField(316), LayoutImmutable, Blittable, JsonProperty(Order = 316)]
		private float _InitialSpawnDelay;

		[ObservableProperty]
		[property: ContainerField(320), LayoutImmutable, Blittable, JsonProperty(Order = 320)]
		private float _SpawnDelay;

		[ObservableProperty]
		[property: ContainerField(324), LayoutImmutable, Blittable, JsonProperty(Order = 324)]
		private int _MaxCount;

		[ObservableProperty]
		[property: ContainerField(328), LayoutImmutable, Blittable, JsonProperty(Order = 328)]
		private int _MaxCountSimultaneously;

		[ObservableProperty]
		[property: ContainerField(332), LayoutImmutable, Blittable, JsonProperty(Order = 332)]
		private int _TotalCountSimultaneouslyOfType;

		[ObservableProperty]
		[property: ContainerField(336), LayoutImmutable, Blittable, JsonProperty(Order = 336)]
		private float _SpawnAreaRadius;

		[ObservableProperty]
		[property: ContainerField(340), LayoutImmutable, Blittable, JsonProperty(Order = 340)]
		private float _SpawnProtectionRadius;

		[ObservableProperty]
		[property: ContainerField(344), LayoutImmutable, Blittable, JsonProperty(Order = 344)]
		private float _RotationYaw;

		[ObservableProperty]
		[property: ContainerField(348), LayoutImmutable, Blittable, JsonProperty(Order = 348)]
		private float _RotationPitch;

		[ObservableProperty]
		[property: ContainerField(352), LayoutImmutable, Blittable, JsonProperty(Order = 352)]
		private float _InitialVelocity;

		[ObservableProperty]
		[property: ContainerField(356), LayoutImmutable, Blittable, JsonProperty(Order = 356)]
		private int _TakeControlEntryIndex;

		[ObservableProperty]
		[property: ContainerField(360), LayoutImmutable, Blittable, JsonProperty(Order = 360)]
		private bool _SpawnProtectionCheckAllTeams;

		[ObservableProperty]
		[property: ContainerField(361), LayoutImmutable, Blittable, JsonProperty(Order = 361)]
		private bool _ClearBangersOnSpawn;

		[ObservableProperty]
		[property: ContainerField(362), LayoutImmutable, Blittable, JsonProperty(Order = 362)]
		private bool _TryToSpawnOutOfSight;

		[ObservableProperty]
		[property: ContainerField(363), LayoutImmutable, Blittable, JsonProperty(Order = 363)]
		private bool _SendWeaponEvents;

		[ObservableProperty]
		[property: ContainerField(364), LayoutImmutable, Blittable, JsonProperty(Order = 364)]
		private bool _TakeControlOnTransformChange;

		[ObservableProperty]
		[property: ContainerField(365), LayoutImmutable, Blittable, JsonProperty(Order = 365)]
		private bool _ReturnControlOnIdle;

		[ObservableProperty]
		[property: ContainerField(366), LayoutImmutable, Blittable, JsonProperty(Order = 366)]
		private bool _AutoSpawn;

		[ObservableProperty]
		[property: ContainerField(367), LayoutImmutable, Blittable, JsonProperty(Order = 367)]
		private bool _UseAsSpawnPoint;

		[ObservableProperty]
		[property: ContainerField(368), LayoutImmutable, Blittable, JsonProperty(Order = 368)]
		private bool _LockedTeam;

		[ObservableProperty]
		[property: ContainerField(369), LayoutImmutable, Blittable, JsonProperty(Order = 369)]
		private bool _InitialAutoSpawn;

		[ObservableProperty]
		[property: ContainerField(370), LayoutImmutable, Blittable, JsonProperty(Order = 370)]
		private bool _OverwriteThrottle;

		[ObservableProperty]
		[property: ContainerField(371), LayoutImmutable, Blittable, JsonProperty(Order = 371)]
		private bool _OnlySendEventForHumanPlayers;

		[ObservableProperty]
		[property: ContainerField(372), LayoutImmutable, Blittable, JsonProperty(Order = 372)]
		private bool _Enabled;

		[ObservableProperty]
		[property: ContainerField(373), LayoutImmutable, Blittable, JsonProperty(Order = 373)]
		private bool _IsDynamicSpawn;

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
