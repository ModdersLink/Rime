///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(16), MemberInfoFlag(53), ContainerClass]
	public class SpawnReferenceObjectData : 
		ReferenceObjectData
	{
		protected LinearTransform m_AirdropTransform = new LinearTransform();
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(2655656634)]
		public LinearTransform AirdropTransform { get { return m_AirdropTransform; } set { if (OnPropertyChanging("SpawnReferenceObjectData." + nameof(AirdropTransform), this, m_AirdropTransform, value)) m_AirdropTransform = value; } } // 0x60 (96)
		
		protected LinearTransform m_ControllableInput = new LinearTransform();
		[ContainerField(160), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(2033256658)]
		public LinearTransform ControllableInput { get { return m_ControllableInput; } set { if (OnPropertyChanging("SpawnReferenceObjectData." + nameof(ControllableInput), this, m_ControllableInput, value)) m_ControllableInput = value; } } // 0xA0 (160)
		
		protected LinearTransform m_ControllableTransform = new LinearTransform();
		[ContainerField(224), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(2085022312)]
		public LinearTransform ControllableTransform { get { return m_ControllableTransform; } set { if (OnPropertyChanging("SpawnReferenceObjectData." + nameof(ControllableTransform), this, m_ControllableTransform, value)) m_ControllableTransform = value; } } // 0xE0 (224)
		
		protected string m_LocationNameSid = string.Empty;
		[ContainerField(288), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(1490142753)]
		public string LocationNameSid { get { return m_LocationNameSid; } set { if (OnPropertyChanging("SpawnReferenceObjectData." + nameof(LocationNameSid), this, m_LocationNameSid, value)) m_LocationNameSid = value; } } // 0x120 (288)
		
		protected string m_LocationTextSid = string.Empty;
		[ContainerField(292), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(2025703195)]
		public string LocationTextSid { get { return m_LocationTextSid; } set { if (OnPropertyChanging("SpawnReferenceObjectData." + nameof(LocationTextSid), this, m_LocationTextSid, value)) m_LocationTextSid = value; } } // 0x124 (292)
		
		protected TeamId m_Team = new TeamId();
		[ContainerField(296), MemberInfoFlag(137), ContainerFieldNameHash(2089309528)]
		public TeamId Team { get { return m_Team; } set { if (OnPropertyChanging("SpawnReferenceObjectData." + nameof(Team), this, m_Team, value)) m_Team = value; } } // 0x128 (296)
		
		protected uint m_SpawnProtectionFriendlyKilledCount = new uint();
		[ContainerField(300), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(2532884410)]
		public uint SpawnProtectionFriendlyKilledCount { get { return m_SpawnProtectionFriendlyKilledCount; } set { if (OnPropertyChanging("SpawnReferenceObjectData." + nameof(SpawnProtectionFriendlyKilledCount), this, m_SpawnProtectionFriendlyKilledCount, value)) m_SpawnProtectionFriendlyKilledCount = value; } } // 0x12C (300)
		
		protected float m_SpawnProtectionFriendlyKilledTime = new float();
		[ContainerField(304), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(466526060)]
		public float SpawnProtectionFriendlyKilledTime { get { return m_SpawnProtectionFriendlyKilledTime; } set { if (OnPropertyChanging("SpawnReferenceObjectData." + nameof(SpawnProtectionFriendlyKilledTime), this, m_SpawnProtectionFriendlyKilledTime, value)) m_SpawnProtectionFriendlyKilledTime = value; } } // 0x130 (304)
		
		protected float m_RotationRoll = new float();
		[ContainerField(308), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3148161004)]
		public float RotationRoll { get { return m_RotationRoll; } set { if (OnPropertyChanging("SpawnReferenceObjectData." + nameof(RotationRoll), this, m_RotationRoll, value)) m_RotationRoll = value; } } // 0x134 (308)
		
		protected float m_Throttle = new float();
		[ContainerField(312), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2709773613)]
		public float Throttle { get { return m_Throttle; } set { if (OnPropertyChanging("SpawnReferenceObjectData." + nameof(Throttle), this, m_Throttle, value)) m_Throttle = value; } } // 0x138 (312)
		
		protected float m_InitialSpawnDelay = new float();
		[ContainerField(316), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2240280789)]
		public float InitialSpawnDelay { get { return m_InitialSpawnDelay; } set { if (OnPropertyChanging("SpawnReferenceObjectData." + nameof(InitialSpawnDelay), this, m_InitialSpawnDelay, value)) m_InitialSpawnDelay = value; } } // 0x13C (316)
		
		protected float m_SpawnDelay = new float();
		[ContainerField(320), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3473198411)]
		public float SpawnDelay { get { return m_SpawnDelay; } set { if (OnPropertyChanging("SpawnReferenceObjectData." + nameof(SpawnDelay), this, m_SpawnDelay, value)) m_SpawnDelay = value; } } // 0x140 (320)
		
		protected int m_MaxCount = new int();
		[ContainerField(324), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(415061138)]
		public int MaxCount { get { return m_MaxCount; } set { if (OnPropertyChanging("SpawnReferenceObjectData." + nameof(MaxCount), this, m_MaxCount, value)) m_MaxCount = value; } } // 0x144 (324)
		
		protected int m_MaxCountSimultaneously = new int();
		[ContainerField(328), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(2090824542)]
		public int MaxCountSimultaneously { get { return m_MaxCountSimultaneously; } set { if (OnPropertyChanging("SpawnReferenceObjectData." + nameof(MaxCountSimultaneously), this, m_MaxCountSimultaneously, value)) m_MaxCountSimultaneously = value; } } // 0x148 (328)
		
		protected int m_TotalCountSimultaneouslyOfType = new int();
		[ContainerField(332), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(3044908761)]
		public int TotalCountSimultaneouslyOfType { get { return m_TotalCountSimultaneouslyOfType; } set { if (OnPropertyChanging("SpawnReferenceObjectData." + nameof(TotalCountSimultaneouslyOfType), this, m_TotalCountSimultaneouslyOfType, value)) m_TotalCountSimultaneouslyOfType = value; } } // 0x14C (332)
		
		protected float m_SpawnAreaRadius = new float();
		[ContainerField(336), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3063192433)]
		public float SpawnAreaRadius { get { return m_SpawnAreaRadius; } set { if (OnPropertyChanging("SpawnReferenceObjectData." + nameof(SpawnAreaRadius), this, m_SpawnAreaRadius, value)) m_SpawnAreaRadius = value; } } // 0x150 (336)
		
		protected float m_SpawnProtectionRadius = new float();
		[ContainerField(340), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2354991365)]
		public float SpawnProtectionRadius { get { return m_SpawnProtectionRadius; } set { if (OnPropertyChanging("SpawnReferenceObjectData." + nameof(SpawnProtectionRadius), this, m_SpawnProtectionRadius, value)) m_SpawnProtectionRadius = value; } } // 0x154 (340)
		
		protected float m_RotationYaw = new float();
		[ContainerField(344), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1136606110)]
		public float RotationYaw { get { return m_RotationYaw; } set { if (OnPropertyChanging("SpawnReferenceObjectData." + nameof(RotationYaw), this, m_RotationYaw, value)) m_RotationYaw = value; } } // 0x158 (344)
		
		protected float m_RotationPitch = new float();
		[ContainerField(348), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(803224183)]
		public float RotationPitch { get { return m_RotationPitch; } set { if (OnPropertyChanging("SpawnReferenceObjectData." + nameof(RotationPitch), this, m_RotationPitch, value)) m_RotationPitch = value; } } // 0x15C (348)
		
		protected float m_InitialVelocity = new float();
		[ContainerField(352), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3508499596)]
		public float InitialVelocity { get { return m_InitialVelocity; } set { if (OnPropertyChanging("SpawnReferenceObjectData." + nameof(InitialVelocity), this, m_InitialVelocity, value)) m_InitialVelocity = value; } } // 0x160 (352)
		
		protected int m_TakeControlEntryIndex = new int();
		[ContainerField(356), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(1823842163)]
		public int TakeControlEntryIndex { get { return m_TakeControlEntryIndex; } set { if (OnPropertyChanging("SpawnReferenceObjectData." + nameof(TakeControlEntryIndex), this, m_TakeControlEntryIndex, value)) m_TakeControlEntryIndex = value; } } // 0x164 (356)
		
		protected bool m_SpawnProtectionCheckAllTeams = new bool();
		[ContainerField(360), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2964373364)]
		public bool SpawnProtectionCheckAllTeams { get { return m_SpawnProtectionCheckAllTeams; } set { if (OnPropertyChanging("SpawnReferenceObjectData." + nameof(SpawnProtectionCheckAllTeams), this, m_SpawnProtectionCheckAllTeams, value)) m_SpawnProtectionCheckAllTeams = value; } } // 0x168 (360)
		
		protected bool m_ClearBangersOnSpawn = new bool();
		[ContainerField(361), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2093968904)]
		public bool ClearBangersOnSpawn { get { return m_ClearBangersOnSpawn; } set { if (OnPropertyChanging("SpawnReferenceObjectData." + nameof(ClearBangersOnSpawn), this, m_ClearBangersOnSpawn, value)) m_ClearBangersOnSpawn = value; } } // 0x169 (361)
		
		protected bool m_TryToSpawnOutOfSight = new bool();
		[ContainerField(362), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2673481532)]
		public bool TryToSpawnOutOfSight { get { return m_TryToSpawnOutOfSight; } set { if (OnPropertyChanging("SpawnReferenceObjectData." + nameof(TryToSpawnOutOfSight), this, m_TryToSpawnOutOfSight, value)) m_TryToSpawnOutOfSight = value; } } // 0x16A (362)
		
		protected bool m_SendWeaponEvents = new bool();
		[ContainerField(363), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3343414756)]
		public bool SendWeaponEvents { get { return m_SendWeaponEvents; } set { if (OnPropertyChanging("SpawnReferenceObjectData." + nameof(SendWeaponEvents), this, m_SendWeaponEvents, value)) m_SendWeaponEvents = value; } } // 0x16B (363)
		
		protected bool m_TakeControlOnTransformChange = new bool();
		[ContainerField(364), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1281873042)]
		public bool TakeControlOnTransformChange { get { return m_TakeControlOnTransformChange; } set { if (OnPropertyChanging("SpawnReferenceObjectData." + nameof(TakeControlOnTransformChange), this, m_TakeControlOnTransformChange, value)) m_TakeControlOnTransformChange = value; } } // 0x16C (364)
		
		protected bool m_ReturnControlOnIdle = new bool();
		[ContainerField(365), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(4289379661)]
		public bool ReturnControlOnIdle { get { return m_ReturnControlOnIdle; } set { if (OnPropertyChanging("SpawnReferenceObjectData." + nameof(ReturnControlOnIdle), this, m_ReturnControlOnIdle, value)) m_ReturnControlOnIdle = value; } } // 0x16D (365)
		
		protected bool m_AutoSpawn = new bool();
		[ContainerField(366), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(792472241)]
		public bool AutoSpawn { get { return m_AutoSpawn; } set { if (OnPropertyChanging("SpawnReferenceObjectData." + nameof(AutoSpawn), this, m_AutoSpawn, value)) m_AutoSpawn = value; } } // 0x16E (366)
		
		protected bool m_UseAsSpawnPoint = new bool();
		[ContainerField(367), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3790673059)]
		public bool UseAsSpawnPoint { get { return m_UseAsSpawnPoint; } set { if (OnPropertyChanging("SpawnReferenceObjectData." + nameof(UseAsSpawnPoint), this, m_UseAsSpawnPoint, value)) m_UseAsSpawnPoint = value; } } // 0x16F (367)
		
		protected bool m_LockedTeam = new bool();
		[ContainerField(368), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3253636210)]
		public bool LockedTeam { get { return m_LockedTeam; } set { if (OnPropertyChanging("SpawnReferenceObjectData." + nameof(LockedTeam), this, m_LockedTeam, value)) m_LockedTeam = value; } } // 0x170 (368)
		
		protected bool m_InitialAutoSpawn = new bool();
		[ContainerField(369), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3746373231)]
		public bool InitialAutoSpawn { get { return m_InitialAutoSpawn; } set { if (OnPropertyChanging("SpawnReferenceObjectData." + nameof(InitialAutoSpawn), this, m_InitialAutoSpawn, value)) m_InitialAutoSpawn = value; } } // 0x171 (369)
		
		protected bool m_OverwriteThrottle = new bool();
		[ContainerField(370), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2218986590)]
		public bool OverwriteThrottle { get { return m_OverwriteThrottle; } set { if (OnPropertyChanging("SpawnReferenceObjectData." + nameof(OverwriteThrottle), this, m_OverwriteThrottle, value)) m_OverwriteThrottle = value; } } // 0x172 (370)
		
		protected bool m_OnlySendEventForHumanPlayers = new bool();
		[ContainerField(371), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1401029797)]
		public bool OnlySendEventForHumanPlayers { get { return m_OnlySendEventForHumanPlayers; } set { if (OnPropertyChanging("SpawnReferenceObjectData." + nameof(OnlySendEventForHumanPlayers), this, m_OnlySendEventForHumanPlayers, value)) m_OnlySendEventForHumanPlayers = value; } } // 0x173 (371)
		
		protected bool m_Enabled = new bool();
		[ContainerField(372), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2662400)]
		public bool Enabled { get { return m_Enabled; } set { if (OnPropertyChanging("SpawnReferenceObjectData." + nameof(Enabled), this, m_Enabled, value)) m_Enabled = value; } } // 0x174 (372)
		
		protected bool m_IsDynamicSpawn = new bool();
		[ContainerField(373), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(299070641)]
		public bool IsDynamicSpawn { get { return m_IsDynamicSpawn; } set { if (OnPropertyChanging("SpawnReferenceObjectData." + nameof(IsDynamicSpawn), this, m_IsDynamicSpawn, value)) m_IsDynamicSpawn = value; } } // 0x175 (373)
		
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
