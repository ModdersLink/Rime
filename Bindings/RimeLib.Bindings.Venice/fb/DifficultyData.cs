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
	public class DifficultyData : 
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 StickyBoxModifier { get; set; } = new Vec3(); // 0x10 (16)
		
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 SnapBoxModifier { get; set; } = new Vec3(); // 0x20 (32)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public float HumanHealthModifier { get; set; } // 0x30 (48)
		
		[ContainerField(52)]
		public PersistenceGameType GameType { get; set; } = new PersistenceGameType(); // 0x34 (52)
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public float FriendsHealthModifier { get; set; } // 0x38 (56)
		
		[ContainerField(60), LayoutImmutable, Blittable]
		public float FriendlyDamageModifier { get; set; } // 0x3C (60)
		
		[ContainerField(64), LayoutImmutable, Blittable]
		public float VehicleDamageModifier { get; set; } // 0x40 (64)
		
		[ContainerField(68), LayoutImmutable, Blittable]
		public float HumanInCriticalHealth { get; set; } // 0x44 (68)
		
		[ContainerField(72), LayoutImmutable, Blittable]
		public float EnemiesHealthModifier { get; set; } // 0x48 (72)
		
		[ContainerField(76), LayoutImmutable, Blittable]
		public float HumanRegenerationRateModifier { get; set; } // 0x4C (76)
		
		[ContainerField(80), LayoutImmutable, Blittable]
		public float HumanInCriticalHealthDamageModifier { get; set; } // 0x50 (80)
		
		[ContainerField(84), LayoutImmutable, Blittable]
		public float InteractiveManDownDamageModifier { get; set; } // 0x54 (84)
		
		[ContainerField(88), LayoutImmutable, Blittable]
		public float InteractiveManDownTimeMultiplier { get; set; } // 0x58 (88)
		
		[ContainerField(92), LayoutImmutable, Blittable]
		public float InteractiveManDownReviveTime { get; set; } // 0x5C (92)
		
		[ContainerField(96), LayoutImmutable, Blittable]
		public int AdrenalineKillLimit { get; set; } // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public float CriticalHealthJesusModeTimeModifier { get; set; } // 0x64 (100)
		
		[ContainerField(104)]
		public Difficulty Difficulty { get; set; } = new Difficulty(); // 0x68 (104)
		
		[ContainerField(108), LayoutImmutable, Blittable]
		public float CriticalFakeImmortalModifier { get; set; } // 0x6C (108)
		
		[ContainerField(112), LayoutImmutable, Blittable]
		public float SuckZoomModifier { get; set; } // 0x70 (112)
		
		[ContainerField(116)]
		public CtrRef<GameAIDifficultyData> AIData { get; set; } = new CtrRef<GameAIDifficultyData>(); // 0x74 (116)
		
		[ContainerField(120), LayoutImmutable, Blittable]
		public float AiBulletDamageHumanCooldown { get; set; } // 0x78 (120)
		
		[ContainerField(124), LayoutImmutable, Blittable]
		public bool UsePitchZoomSnap { get; set; } // 0x7C (124)
		
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
