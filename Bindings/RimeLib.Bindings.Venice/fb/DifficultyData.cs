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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 128)]
	public class DifficultyData : 
		DataContainer
	{
		protected Vec3 m_StickyBoxModifier = new Vec3();
		[ContainerField(Name: "StickyBoxModifier", Offset: 16, NameHash: 1564331544, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 StickyBoxModifier { get { return m_StickyBoxModifier; } set { if (OnPropertyChanging("DifficultyData." + nameof(StickyBoxModifier), this, m_StickyBoxModifier, value)) m_StickyBoxModifier = value; } } // 0x10 (16)
		
		protected Vec3 m_SnapBoxModifier = new Vec3();
		[ContainerField(Name: "SnapBoxModifier", Offset: 32, NameHash: 723092811, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 SnapBoxModifier { get { return m_SnapBoxModifier; } set { if (OnPropertyChanging("DifficultyData." + nameof(SnapBoxModifier), this, m_SnapBoxModifier, value)) m_SnapBoxModifier = value; } } // 0x20 (32)
		
		protected float m_HumanHealthModifier = new float();
		[ContainerField(Name: "HumanHealthModifier", Offset: 48, NameHash: 306426001, Flags: 49469), LayoutImmutable, Blittable]
		public float HumanHealthModifier { get { return m_HumanHealthModifier; } set { if (OnPropertyChanging("DifficultyData." + nameof(HumanHealthModifier), this, m_HumanHealthModifier, value)) m_HumanHealthModifier = value; } } // 0x30 (48)
		
		protected PersistenceGameType m_GameType = new PersistenceGameType();
		[ContainerField(Name: "GameType", Offset: 52, NameHash: 510356627, Flags: 137)]
		public PersistenceGameType GameType { get { return m_GameType; } set { if (OnPropertyChanging("DifficultyData." + nameof(GameType), this, m_GameType, value)) m_GameType = value; } } // 0x34 (52)
		
		protected float m_FriendsHealthModifier = new float();
		[ContainerField(Name: "FriendsHealthModifier", Offset: 56, NameHash: 1859236591, Flags: 49469), LayoutImmutable, Blittable]
		public float FriendsHealthModifier { get { return m_FriendsHealthModifier; } set { if (OnPropertyChanging("DifficultyData." + nameof(FriendsHealthModifier), this, m_FriendsHealthModifier, value)) m_FriendsHealthModifier = value; } } // 0x38 (56)
		
		protected float m_FriendlyDamageModifier = new float();
		[ContainerField(Name: "FriendlyDamageModifier", Offset: 60, NameHash: 1576644830, Flags: 49469), LayoutImmutable, Blittable]
		public float FriendlyDamageModifier { get { return m_FriendlyDamageModifier; } set { if (OnPropertyChanging("DifficultyData." + nameof(FriendlyDamageModifier), this, m_FriendlyDamageModifier, value)) m_FriendlyDamageModifier = value; } } // 0x3C (60)
		
		protected float m_VehicleDamageModifier = new float();
		[ContainerField(Name: "VehicleDamageModifier", Offset: 64, NameHash: 3810411169, Flags: 49469), LayoutImmutable, Blittable]
		public float VehicleDamageModifier { get { return m_VehicleDamageModifier; } set { if (OnPropertyChanging("DifficultyData." + nameof(VehicleDamageModifier), this, m_VehicleDamageModifier, value)) m_VehicleDamageModifier = value; } } // 0x40 (64)
		
		protected float m_HumanInCriticalHealth = new float();
		[ContainerField(Name: "HumanInCriticalHealth", Offset: 68, NameHash: 1275764554, Flags: 49469), LayoutImmutable, Blittable]
		public float HumanInCriticalHealth { get { return m_HumanInCriticalHealth; } set { if (OnPropertyChanging("DifficultyData." + nameof(HumanInCriticalHealth), this, m_HumanInCriticalHealth, value)) m_HumanInCriticalHealth = value; } } // 0x44 (68)
		
		protected float m_EnemiesHealthModifier = new float();
		[ContainerField(Name: "EnemiesHealthModifier", Offset: 72, NameHash: 2553763986, Flags: 49469), LayoutImmutable, Blittable]
		public float EnemiesHealthModifier { get { return m_EnemiesHealthModifier; } set { if (OnPropertyChanging("DifficultyData." + nameof(EnemiesHealthModifier), this, m_EnemiesHealthModifier, value)) m_EnemiesHealthModifier = value; } } // 0x48 (72)
		
		protected float m_HumanRegenerationRateModifier = new float();
		[ContainerField(Name: "HumanRegenerationRateModifier", Offset: 76, NameHash: 1058415390, Flags: 49469), LayoutImmutable, Blittable]
		public float HumanRegenerationRateModifier { get { return m_HumanRegenerationRateModifier; } set { if (OnPropertyChanging("DifficultyData." + nameof(HumanRegenerationRateModifier), this, m_HumanRegenerationRateModifier, value)) m_HumanRegenerationRateModifier = value; } } // 0x4C (76)
		
		protected float m_HumanInCriticalHealthDamageModifier = new float();
		[ContainerField(Name: "HumanInCriticalHealthDamageModifier", Offset: 80, NameHash: 2030418966, Flags: 49469), LayoutImmutable, Blittable]
		public float HumanInCriticalHealthDamageModifier { get { return m_HumanInCriticalHealthDamageModifier; } set { if (OnPropertyChanging("DifficultyData." + nameof(HumanInCriticalHealthDamageModifier), this, m_HumanInCriticalHealthDamageModifier, value)) m_HumanInCriticalHealthDamageModifier = value; } } // 0x50 (80)
		
		protected float m_InteractiveManDownDamageModifier = new float();
		[ContainerField(Name: "InteractiveManDownDamageModifier", Offset: 84, NameHash: 1661744161, Flags: 49469), LayoutImmutable, Blittable]
		public float InteractiveManDownDamageModifier { get { return m_InteractiveManDownDamageModifier; } set { if (OnPropertyChanging("DifficultyData." + nameof(InteractiveManDownDamageModifier), this, m_InteractiveManDownDamageModifier, value)) m_InteractiveManDownDamageModifier = value; } } // 0x54 (84)
		
		protected float m_InteractiveManDownTimeMultiplier = new float();
		[ContainerField(Name: "InteractiveManDownTimeMultiplier", Offset: 88, NameHash: 849153507, Flags: 49469), LayoutImmutable, Blittable]
		public float InteractiveManDownTimeMultiplier { get { return m_InteractiveManDownTimeMultiplier; } set { if (OnPropertyChanging("DifficultyData." + nameof(InteractiveManDownTimeMultiplier), this, m_InteractiveManDownTimeMultiplier, value)) m_InteractiveManDownTimeMultiplier = value; } } // 0x58 (88)
		
		protected float m_InteractiveManDownReviveTime = new float();
		[ContainerField(Name: "InteractiveManDownReviveTime", Offset: 92, NameHash: 2327289747, Flags: 49469), LayoutImmutable, Blittable]
		public float InteractiveManDownReviveTime { get { return m_InteractiveManDownReviveTime; } set { if (OnPropertyChanging("DifficultyData." + nameof(InteractiveManDownReviveTime), this, m_InteractiveManDownReviveTime, value)) m_InteractiveManDownReviveTime = value; } } // 0x5C (92)
		
		protected int m_AdrenalineKillLimit = new int();
		[ContainerField(Name: "AdrenalineKillLimit", Offset: 96, NameHash: 2568704897, Flags: 49405), LayoutImmutable, Blittable]
		public int AdrenalineKillLimit { get { return m_AdrenalineKillLimit; } set { if (OnPropertyChanging("DifficultyData." + nameof(AdrenalineKillLimit), this, m_AdrenalineKillLimit, value)) m_AdrenalineKillLimit = value; } } // 0x60 (96)
		
		protected float m_CriticalHealthJesusModeTimeModifier = new float();
		[ContainerField(Name: "CriticalHealthJesusModeTimeModifier", Offset: 100, NameHash: 265284809, Flags: 49469), LayoutImmutable, Blittable]
		public float CriticalHealthJesusModeTimeModifier { get { return m_CriticalHealthJesusModeTimeModifier; } set { if (OnPropertyChanging("DifficultyData." + nameof(CriticalHealthJesusModeTimeModifier), this, m_CriticalHealthJesusModeTimeModifier, value)) m_CriticalHealthJesusModeTimeModifier = value; } } // 0x64 (100)
		
		protected Difficulty m_Difficulty = new Difficulty();
		[ContainerField(Name: "Difficulty", Offset: 104, NameHash: 3179608694, Flags: 137)]
		public Difficulty Difficulty { get { return m_Difficulty; } set { if (OnPropertyChanging("DifficultyData." + nameof(Difficulty), this, m_Difficulty, value)) m_Difficulty = value; } } // 0x68 (104)
		
		protected float m_CriticalFakeImmortalModifier = new float();
		[ContainerField(Name: "CriticalFakeImmortalModifier", Offset: 108, NameHash: 2802952093, Flags: 49469), LayoutImmutable, Blittable]
		public float CriticalFakeImmortalModifier { get { return m_CriticalFakeImmortalModifier; } set { if (OnPropertyChanging("DifficultyData." + nameof(CriticalFakeImmortalModifier), this, m_CriticalFakeImmortalModifier, value)) m_CriticalFakeImmortalModifier = value; } } // 0x6C (108)
		
		protected float m_SuckZoomModifier = new float();
		[ContainerField(Name: "SuckZoomModifier", Offset: 112, NameHash: 4057650955, Flags: 49469), LayoutImmutable, Blittable]
		public float SuckZoomModifier { get { return m_SuckZoomModifier; } set { if (OnPropertyChanging("DifficultyData." + nameof(SuckZoomModifier), this, m_SuckZoomModifier, value)) m_SuckZoomModifier = value; } } // 0x70 (112)
		
		protected CtrRef<GameAIDifficultyData> m_AIData = new CtrRef<GameAIDifficultyData>();
		[ContainerField(Name: "AIData", Offset: 116, NameHash: 2529950045, Flags: 53)]
		public CtrRef<GameAIDifficultyData> AIData { get { return m_AIData; } set { if (OnPropertyChanging("DifficultyData." + nameof(AIData), this, m_AIData, value)) m_AIData = value; } } // 0x74 (116)
		
		protected float m_AiBulletDamageHumanCooldown = new float();
		[ContainerField(Name: "AiBulletDamageHumanCooldown", Offset: 120, NameHash: 3336443042, Flags: 49469), LayoutImmutable, Blittable]
		public float AiBulletDamageHumanCooldown { get { return m_AiBulletDamageHumanCooldown; } set { if (OnPropertyChanging("DifficultyData." + nameof(AiBulletDamageHumanCooldown), this, m_AiBulletDamageHumanCooldown, value)) m_AiBulletDamageHumanCooldown = value; } } // 0x78 (120)
		
		protected bool m_UsePitchZoomSnap = new bool();
		[ContainerField(Name: "UsePitchZoomSnap", Offset: 124, NameHash: 2073450427, Flags: 49325), LayoutImmutable, Blittable]
		public bool UsePitchZoomSnap { get { return m_UsePitchZoomSnap; } set { if (OnPropertyChanging("DifficultyData." + nameof(UsePitchZoomSnap), this, m_UsePitchZoomSnap, value)) m_UsePitchZoomSnap = value; } } // 0x7C (124)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1564331544:
					StickyBoxModifier = (Vec3) p_Value;
					break;

				case 723092811:
					SnapBoxModifier = (Vec3) p_Value;
					break;

				case 306426001:
					HumanHealthModifier = (float) p_Value;
					break;

				case 510356627:
					GameType = (PersistenceGameType) Enum.ToObject(typeof(PersistenceGameType), p_Value);
					break;

				case 1859236591:
					FriendsHealthModifier = (float) p_Value;
					break;

				case 1576644830:
					FriendlyDamageModifier = (float) p_Value;
					break;

				case 3810411169:
					VehicleDamageModifier = (float) p_Value;
					break;

				case 1275764554:
					HumanInCriticalHealth = (float) p_Value;
					break;

				case 2553763986:
					EnemiesHealthModifier = (float) p_Value;
					break;

				case 1058415390:
					HumanRegenerationRateModifier = (float) p_Value;
					break;

				case 2030418966:
					HumanInCriticalHealthDamageModifier = (float) p_Value;
					break;

				case 1661744161:
					InteractiveManDownDamageModifier = (float) p_Value;
					break;

				case 849153507:
					InteractiveManDownTimeMultiplier = (float) p_Value;
					break;

				case 2327289747:
					InteractiveManDownReviveTime = (float) p_Value;
					break;

				case 2568704897:
					AdrenalineKillLimit = (int) p_Value;
					break;

				case 265284809:
					CriticalHealthJesusModeTimeModifier = (float) p_Value;
					break;

				case 3179608694:
					Difficulty = (Difficulty) Enum.ToObject(typeof(Difficulty), p_Value);
					break;

				case 2802952093:
					CriticalFakeImmortalModifier = (float) p_Value;
					break;

				case 4057650955:
					SuckZoomModifier = (float) p_Value;
					break;

				case 2529950045:
					AIData = (CtrRef<GameAIDifficultyData>) p_Value;
					break;

				case 3336443042:
					AiBulletDamageHumanCooldown = (float) p_Value;
					break;

				case 2073450427:
					UsePitchZoomSnap = (bool) p_Value;
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
				case 1564331544:
					return StickyBoxModifier;

				case 723092811:
					return SnapBoxModifier;

				case 306426001:
					return HumanHealthModifier;

				case 510356627:
					return GameType;

				case 1859236591:
					return FriendsHealthModifier;

				case 1576644830:
					return FriendlyDamageModifier;

				case 3810411169:
					return VehicleDamageModifier;

				case 1275764554:
					return HumanInCriticalHealth;

				case 2553763986:
					return EnemiesHealthModifier;

				case 1058415390:
					return HumanRegenerationRateModifier;

				case 2030418966:
					return HumanInCriticalHealthDamageModifier;

				case 1661744161:
					return InteractiveManDownDamageModifier;

				case 849153507:
					return InteractiveManDownTimeMultiplier;

				case 2327289747:
					return InteractiveManDownReviveTime;

				case 2568704897:
					return AdrenalineKillLimit;

				case 265284809:
					return CriticalHealthJesusModeTimeModifier;

				case 3179608694:
					return Difficulty;

				case 2802952093:
					return CriticalFakeImmortalModifier;

				case 4057650955:
					return SuckZoomModifier;

				case 2529950045:
					return AIData;

				case 3336443042:
					return AiBulletDamageHumanCooldown;

				case 2073450427:
					return UsePitchZoomSnap;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1564331544:
					return typeof(DifficultyData).GetProperty(nameof(StickyBoxModifier));

				case 723092811:
					return typeof(DifficultyData).GetProperty(nameof(SnapBoxModifier));

				case 306426001:
					return typeof(DifficultyData).GetProperty(nameof(HumanHealthModifier));

				case 510356627:
					return typeof(DifficultyData).GetProperty(nameof(GameType));

				case 1859236591:
					return typeof(DifficultyData).GetProperty(nameof(FriendsHealthModifier));

				case 1576644830:
					return typeof(DifficultyData).GetProperty(nameof(FriendlyDamageModifier));

				case 3810411169:
					return typeof(DifficultyData).GetProperty(nameof(VehicleDamageModifier));

				case 1275764554:
					return typeof(DifficultyData).GetProperty(nameof(HumanInCriticalHealth));

				case 2553763986:
					return typeof(DifficultyData).GetProperty(nameof(EnemiesHealthModifier));

				case 1058415390:
					return typeof(DifficultyData).GetProperty(nameof(HumanRegenerationRateModifier));

				case 2030418966:
					return typeof(DifficultyData).GetProperty(nameof(HumanInCriticalHealthDamageModifier));

				case 1661744161:
					return typeof(DifficultyData).GetProperty(nameof(InteractiveManDownDamageModifier));

				case 849153507:
					return typeof(DifficultyData).GetProperty(nameof(InteractiveManDownTimeMultiplier));

				case 2327289747:
					return typeof(DifficultyData).GetProperty(nameof(InteractiveManDownReviveTime));

				case 2568704897:
					return typeof(DifficultyData).GetProperty(nameof(AdrenalineKillLimit));

				case 265284809:
					return typeof(DifficultyData).GetProperty(nameof(CriticalHealthJesusModeTimeModifier));

				case 3179608694:
					return typeof(DifficultyData).GetProperty(nameof(Difficulty));

				case 2802952093:
					return typeof(DifficultyData).GetProperty(nameof(CriticalFakeImmortalModifier));

				case 4057650955:
					return typeof(DifficultyData).GetProperty(nameof(SuckZoomModifier));

				case 2529950045:
					return typeof(DifficultyData).GetProperty(nameof(AIData));

				case 3336443042:
					return typeof(DifficultyData).GetProperty(nameof(AiBulletDamageHumanCooldown));

				case 2073450427:
					return typeof(DifficultyData).GetProperty(nameof(UsePitchZoomSnap));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
