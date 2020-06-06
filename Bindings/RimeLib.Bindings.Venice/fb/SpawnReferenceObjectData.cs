///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class SpawnReferenceObjectData : 
		ReferenceObjectData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform AirdropTransform { get; set; } = new LinearTransform(); // 0x60 (96)
		
		[ContainerField(160), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform ControllableInput { get; set; } = new LinearTransform(); // 0xA0 (160)
		
		[ContainerField(224), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform ControllableTransform { get; set; } = new LinearTransform(); // 0xE0 (224)
		
		[ContainerField(288), LayoutImmutable]
		public string LocationNameSid { get; set; } // 0x120 (288)
		
		[ContainerField(292), LayoutImmutable]
		public string LocationTextSid { get; set; } // 0x124 (292)
		
		[ContainerField(296)]
		public TeamId Team { get; set; } = new TeamId(); // 0x128 (296)
		
		[ContainerField(300), LayoutImmutable, Blittable]
		public uint SpawnProtectionFriendlyKilledCount { get; set; } // 0x12C (300)
		
		[ContainerField(304), LayoutImmutable, Blittable]
		public float SpawnProtectionFriendlyKilledTime { get; set; } // 0x130 (304)
		
		[ContainerField(308), LayoutImmutable, Blittable]
		public float RotationRoll { get; set; } // 0x134 (308)
		
		[ContainerField(312), LayoutImmutable, Blittable]
		public float Throttle { get; set; } // 0x138 (312)
		
		[ContainerField(316), LayoutImmutable, Blittable]
		public float InitialSpawnDelay { get; set; } // 0x13C (316)
		
		[ContainerField(320), LayoutImmutable, Blittable]
		public float SpawnDelay { get; set; } // 0x140 (320)
		
		[ContainerField(324), LayoutImmutable, Blittable]
		public int MaxCount { get; set; } // 0x144 (324)
		
		[ContainerField(328), LayoutImmutable, Blittable]
		public int MaxCountSimultaneously { get; set; } // 0x148 (328)
		
		[ContainerField(332), LayoutImmutable, Blittable]
		public int TotalCountSimultaneouslyOfType { get; set; } // 0x14C (332)
		
		[ContainerField(336), LayoutImmutable, Blittable]
		public float SpawnAreaRadius { get; set; } // 0x150 (336)
		
		[ContainerField(340), LayoutImmutable, Blittable]
		public float SpawnProtectionRadius { get; set; } // 0x154 (340)
		
		[ContainerField(344), LayoutImmutable, Blittable]
		public float RotationYaw { get; set; } // 0x158 (344)
		
		[ContainerField(348), LayoutImmutable, Blittable]
		public float RotationPitch { get; set; } // 0x15C (348)
		
		[ContainerField(352), LayoutImmutable, Blittable]
		public float InitialVelocity { get; set; } // 0x160 (352)
		
		[ContainerField(356), LayoutImmutable, Blittable]
		public int TakeControlEntryIndex { get; set; } // 0x164 (356)
		
		[ContainerField(360), LayoutImmutable, Blittable]
		public bool SpawnProtectionCheckAllTeams { get; set; } // 0x168 (360)
		
		[ContainerField(361), LayoutImmutable, Blittable]
		public bool ClearBangersOnSpawn { get; set; } // 0x169 (361)
		
		[ContainerField(362), LayoutImmutable, Blittable]
		public bool TryToSpawnOutOfSight { get; set; } // 0x16A (362)
		
		[ContainerField(363), LayoutImmutable, Blittable]
		public bool SendWeaponEvents { get; set; } // 0x16B (363)
		
		[ContainerField(364), LayoutImmutable, Blittable]
		public bool TakeControlOnTransformChange { get; set; } // 0x16C (364)
		
		[ContainerField(365), LayoutImmutable, Blittable]
		public bool ReturnControlOnIdle { get; set; } // 0x16D (365)
		
		[ContainerField(366), LayoutImmutable, Blittable]
		public bool AutoSpawn { get; set; } // 0x16E (366)
		
		[ContainerField(367), LayoutImmutable, Blittable]
		public bool UseAsSpawnPoint { get; set; } // 0x16F (367)
		
		[ContainerField(368), LayoutImmutable, Blittable]
		public bool LockedTeam { get; set; } // 0x170 (368)
		
		[ContainerField(369), LayoutImmutable, Blittable]
		public bool InitialAutoSpawn { get; set; } // 0x171 (369)
		
		[ContainerField(370), LayoutImmutable, Blittable]
		public bool OverwriteThrottle { get; set; } // 0x172 (370)
		
		[ContainerField(371), LayoutImmutable, Blittable]
		public bool OnlySendEventForHumanPlayers { get; set; } // 0x173 (371)
		
		[ContainerField(372), LayoutImmutable, Blittable]
		public bool Enabled { get; set; } // 0x174 (372)
		
		[ContainerField(373), LayoutImmutable, Blittable]
		public bool IsDynamicSpawn { get; set; } // 0x175 (373)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2655656634:
					AirdropTransform = (LinearTransform) p_Value;
					break;

				case 2033256658:
					ControllableInput = (LinearTransform) p_Value;
					break;

				case 2085022312:
					ControllableTransform = (LinearTransform) p_Value;
					break;

				case 1490142753:
					LocationNameSid = (string) p_Value;
					break;

				case 2025703195:
					LocationTextSid = (string) p_Value;
					break;

				case 2089309528:
					Team = (TeamId) Enum.ToObject(typeof(TeamId), p_Value);
					break;

				case 2532884410:
					SpawnProtectionFriendlyKilledCount = (uint) p_Value;
					break;

				case 466526060:
					SpawnProtectionFriendlyKilledTime = (float) p_Value;
					break;

				case 3148161004:
					RotationRoll = (float) p_Value;
					break;

				case 2709773613:
					Throttle = (float) p_Value;
					break;

				case 2240280789:
					InitialSpawnDelay = (float) p_Value;
					break;

				case 3473198411:
					SpawnDelay = (float) p_Value;
					break;

				case 415061138:
					MaxCount = (int) p_Value;
					break;

				case 2090824542:
					MaxCountSimultaneously = (int) p_Value;
					break;

				case 3044908761:
					TotalCountSimultaneouslyOfType = (int) p_Value;
					break;

				case 3063192433:
					SpawnAreaRadius = (float) p_Value;
					break;

				case 2354991365:
					SpawnProtectionRadius = (float) p_Value;
					break;

				case 1136606110:
					RotationYaw = (float) p_Value;
					break;

				case 803224183:
					RotationPitch = (float) p_Value;
					break;

				case 3508499596:
					InitialVelocity = (float) p_Value;
					break;

				case 1823842163:
					TakeControlEntryIndex = (int) p_Value;
					break;

				case 2964373364:
					SpawnProtectionCheckAllTeams = (bool) p_Value;
					break;

				case 2093968904:
					ClearBangersOnSpawn = (bool) p_Value;
					break;

				case 2673481532:
					TryToSpawnOutOfSight = (bool) p_Value;
					break;

				case 3343414756:
					SendWeaponEvents = (bool) p_Value;
					break;

				case 1281873042:
					TakeControlOnTransformChange = (bool) p_Value;
					break;

				case 4289379661:
					ReturnControlOnIdle = (bool) p_Value;
					break;

				case 792472241:
					AutoSpawn = (bool) p_Value;
					break;

				case 3790673059:
					UseAsSpawnPoint = (bool) p_Value;
					break;

				case 3253636210:
					LockedTeam = (bool) p_Value;
					break;

				case 3746373231:
					InitialAutoSpawn = (bool) p_Value;
					break;

				case 2218986590:
					OverwriteThrottle = (bool) p_Value;
					break;

				case 1401029797:
					OnlySendEventForHumanPlayers = (bool) p_Value;
					break;

				case 2662400:
					Enabled = (bool) p_Value;
					break;

				case 299070641:
					IsDynamicSpawn = (bool) p_Value;
					break;

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2655656634:
					return AirdropTransform;

				case 2033256658:
					return ControllableInput;

				case 2085022312:
					return ControllableTransform;

				case 1490142753:
					return LocationNameSid;

				case 2025703195:
					return LocationTextSid;

				case 2089309528:
					return Team;

				case 2532884410:
					return SpawnProtectionFriendlyKilledCount;

				case 466526060:
					return SpawnProtectionFriendlyKilledTime;

				case 3148161004:
					return RotationRoll;

				case 2709773613:
					return Throttle;

				case 2240280789:
					return InitialSpawnDelay;

				case 3473198411:
					return SpawnDelay;

				case 415061138:
					return MaxCount;

				case 2090824542:
					return MaxCountSimultaneously;

				case 3044908761:
					return TotalCountSimultaneouslyOfType;

				case 3063192433:
					return SpawnAreaRadius;

				case 2354991365:
					return SpawnProtectionRadius;

				case 1136606110:
					return RotationYaw;

				case 803224183:
					return RotationPitch;

				case 3508499596:
					return InitialVelocity;

				case 1823842163:
					return TakeControlEntryIndex;

				case 2964373364:
					return SpawnProtectionCheckAllTeams;

				case 2093968904:
					return ClearBangersOnSpawn;

				case 2673481532:
					return TryToSpawnOutOfSight;

				case 3343414756:
					return SendWeaponEvents;

				case 1281873042:
					return TakeControlOnTransformChange;

				case 4289379661:
					return ReturnControlOnIdle;

				case 792472241:
					return AutoSpawn;

				case 3790673059:
					return UseAsSpawnPoint;

				case 3253636210:
					return LockedTeam;

				case 3746373231:
					return InitialAutoSpawn;

				case 2218986590:
					return OverwriteThrottle;

				case 1401029797:
					return OnlySendEventForHumanPlayers;

				case 2662400:
					return Enabled;

				case 299070641:
					return IsDynamicSpawn;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2655656634:
					return typeof(SpawnReferenceObjectData).GetProperty(nameof(AirdropTransform));

				case 2033256658:
					return typeof(SpawnReferenceObjectData).GetProperty(nameof(ControllableInput));

				case 2085022312:
					return typeof(SpawnReferenceObjectData).GetProperty(nameof(ControllableTransform));

				case 1490142753:
					return typeof(SpawnReferenceObjectData).GetProperty(nameof(LocationNameSid));

				case 2025703195:
					return typeof(SpawnReferenceObjectData).GetProperty(nameof(LocationTextSid));

				case 2089309528:
					return typeof(SpawnReferenceObjectData).GetProperty(nameof(Team));

				case 2532884410:
					return typeof(SpawnReferenceObjectData).GetProperty(nameof(SpawnProtectionFriendlyKilledCount));

				case 466526060:
					return typeof(SpawnReferenceObjectData).GetProperty(nameof(SpawnProtectionFriendlyKilledTime));

				case 3148161004:
					return typeof(SpawnReferenceObjectData).GetProperty(nameof(RotationRoll));

				case 2709773613:
					return typeof(SpawnReferenceObjectData).GetProperty(nameof(Throttle));

				case 2240280789:
					return typeof(SpawnReferenceObjectData).GetProperty(nameof(InitialSpawnDelay));

				case 3473198411:
					return typeof(SpawnReferenceObjectData).GetProperty(nameof(SpawnDelay));

				case 415061138:
					return typeof(SpawnReferenceObjectData).GetProperty(nameof(MaxCount));

				case 2090824542:
					return typeof(SpawnReferenceObjectData).GetProperty(nameof(MaxCountSimultaneously));

				case 3044908761:
					return typeof(SpawnReferenceObjectData).GetProperty(nameof(TotalCountSimultaneouslyOfType));

				case 3063192433:
					return typeof(SpawnReferenceObjectData).GetProperty(nameof(SpawnAreaRadius));

				case 2354991365:
					return typeof(SpawnReferenceObjectData).GetProperty(nameof(SpawnProtectionRadius));

				case 1136606110:
					return typeof(SpawnReferenceObjectData).GetProperty(nameof(RotationYaw));

				case 803224183:
					return typeof(SpawnReferenceObjectData).GetProperty(nameof(RotationPitch));

				case 3508499596:
					return typeof(SpawnReferenceObjectData).GetProperty(nameof(InitialVelocity));

				case 1823842163:
					return typeof(SpawnReferenceObjectData).GetProperty(nameof(TakeControlEntryIndex));

				case 2964373364:
					return typeof(SpawnReferenceObjectData).GetProperty(nameof(SpawnProtectionCheckAllTeams));

				case 2093968904:
					return typeof(SpawnReferenceObjectData).GetProperty(nameof(ClearBangersOnSpawn));

				case 2673481532:
					return typeof(SpawnReferenceObjectData).GetProperty(nameof(TryToSpawnOutOfSight));

				case 3343414756:
					return typeof(SpawnReferenceObjectData).GetProperty(nameof(SendWeaponEvents));

				case 1281873042:
					return typeof(SpawnReferenceObjectData).GetProperty(nameof(TakeControlOnTransformChange));

				case 4289379661:
					return typeof(SpawnReferenceObjectData).GetProperty(nameof(ReturnControlOnIdle));

				case 792472241:
					return typeof(SpawnReferenceObjectData).GetProperty(nameof(AutoSpawn));

				case 3790673059:
					return typeof(SpawnReferenceObjectData).GetProperty(nameof(UseAsSpawnPoint));

				case 3253636210:
					return typeof(SpawnReferenceObjectData).GetProperty(nameof(LockedTeam));

				case 3746373231:
					return typeof(SpawnReferenceObjectData).GetProperty(nameof(InitialAutoSpawn));

				case 2218986590:
					return typeof(SpawnReferenceObjectData).GetProperty(nameof(OverwriteThrottle));

				case 1401029797:
					return typeof(SpawnReferenceObjectData).GetProperty(nameof(OnlySendEventForHumanPlayers));

				case 2662400:
					return typeof(SpawnReferenceObjectData).GetProperty(nameof(Enabled));

				case 299070641:
					return typeof(SpawnReferenceObjectData).GetProperty(nameof(IsDynamicSpawn));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
