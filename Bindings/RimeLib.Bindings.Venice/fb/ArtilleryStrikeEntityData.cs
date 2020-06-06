///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class ArtilleryStrikeEntityData : 
		GameEntityData
	{
		[ContainerField(96)]
		public CtrRef<MissileEntityData> MissileData { get; set; } = new CtrRef<MissileEntityData>(); // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public float MissileSpawnRadius { get; set; } // 0x64 (100)
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public float DurationOfArtilleryStrike { get; set; } // 0x68 (104)
		
		[ContainerField(108), LayoutImmutable, Blittable]
		public float MaxDelayBetweenProjectiles { get; set; } // 0x6C (108)
		
		[ContainerField(112), LayoutImmutable, Blittable]
		public float MinDelayBetweenProjectiles { get; set; } // 0x70 (112)
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public float MaxDelayBetweenStrikes { get; set; } // 0x74 (116)
		
		[ContainerField(120), LayoutImmutable, Blittable]
		public float MinDelayBetweenStrikes { get; set; } // 0x78 (120)
		
		[ContainerField(124), LayoutImmutable, Blittable]
		public float MinRadiusToSoldier { get; set; } // 0x7C (124)
		
		[ContainerField(128), LayoutImmutable, Blittable]
		public float RadiusWhenFollowingSoldier { get; set; } // 0x80 (128)
		
		[ContainerField(132), LayoutImmutable, Blittable]
		public float HeightOffsetWhenFollowingSoldier { get; set; } // 0x84 (132)
		
		[ContainerField(136), LayoutImmutable, Blittable]
		public uint NumberOfStrikes { get; set; } // 0x88 (136)
		
		[ContainerField(140), LayoutImmutable, Blittable]
		public uint MaxProjectilesPerStrike { get; set; } // 0x8C (140)
		
		[ContainerField(144), LayoutImmutable, Blittable]
		public uint MinProjectilesPerStrike { get; set; } // 0x90 (144)
		
		[ContainerField(148), LayoutImmutable, Blittable]
		public bool FollowSoldier { get; set; } // 0x94 (148)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2091932305:
					MissileData = (CtrRef<MissileEntityData>) p_Value;
					break;

				case 332972706:
					MissileSpawnRadius = (float) p_Value;
					break;

				case 2959930496:
					DurationOfArtilleryStrike = (float) p_Value;
					break;

				case 523843432:
					MaxDelayBetweenProjectiles = (float) p_Value;
					break;

				case 3958890294:
					MinDelayBetweenProjectiles = (float) p_Value;
					break;

				case 2099842575:
					MaxDelayBetweenStrikes = (float) p_Value;
					break;

				case 3998184017:
					MinDelayBetweenStrikes = (float) p_Value;
					break;

				case 1839985574:
					MinRadiusToSoldier = (float) p_Value;
					break;

				case 244255762:
					RadiusWhenFollowingSoldier = (float) p_Value;
					break;

				case 1202047928:
					HeightOffsetWhenFollowingSoldier = (float) p_Value;
					break;

				case 3316180366:
					NumberOfStrikes = (uint) p_Value;
					break;

				case 2950424034:
					MaxProjectilesPerStrike = (uint) p_Value;
					break;

				case 1850427516:
					MinProjectilesPerStrike = (uint) p_Value;
					break;

				case 197288222:
					FollowSoldier = (bool) p_Value;
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
				case 2091932305:
					return MissileData;

				case 332972706:
					return MissileSpawnRadius;

				case 2959930496:
					return DurationOfArtilleryStrike;

				case 523843432:
					return MaxDelayBetweenProjectiles;

				case 3958890294:
					return MinDelayBetweenProjectiles;

				case 2099842575:
					return MaxDelayBetweenStrikes;

				case 3998184017:
					return MinDelayBetweenStrikes;

				case 1839985574:
					return MinRadiusToSoldier;

				case 244255762:
					return RadiusWhenFollowingSoldier;

				case 1202047928:
					return HeightOffsetWhenFollowingSoldier;

				case 3316180366:
					return NumberOfStrikes;

				case 2950424034:
					return MaxProjectilesPerStrike;

				case 1850427516:
					return MinProjectilesPerStrike;

				case 197288222:
					return FollowSoldier;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2091932305:
					return typeof(ArtilleryStrikeEntityData).GetProperty(nameof(MissileData));

				case 332972706:
					return typeof(ArtilleryStrikeEntityData).GetProperty(nameof(MissileSpawnRadius));

				case 2959930496:
					return typeof(ArtilleryStrikeEntityData).GetProperty(nameof(DurationOfArtilleryStrike));

				case 523843432:
					return typeof(ArtilleryStrikeEntityData).GetProperty(nameof(MaxDelayBetweenProjectiles));

				case 3958890294:
					return typeof(ArtilleryStrikeEntityData).GetProperty(nameof(MinDelayBetweenProjectiles));

				case 2099842575:
					return typeof(ArtilleryStrikeEntityData).GetProperty(nameof(MaxDelayBetweenStrikes));

				case 3998184017:
					return typeof(ArtilleryStrikeEntityData).GetProperty(nameof(MinDelayBetweenStrikes));

				case 1839985574:
					return typeof(ArtilleryStrikeEntityData).GetProperty(nameof(MinRadiusToSoldier));

				case 244255762:
					return typeof(ArtilleryStrikeEntityData).GetProperty(nameof(RadiusWhenFollowingSoldier));

				case 1202047928:
					return typeof(ArtilleryStrikeEntityData).GetProperty(nameof(HeightOffsetWhenFollowingSoldier));

				case 3316180366:
					return typeof(ArtilleryStrikeEntityData).GetProperty(nameof(NumberOfStrikes));

				case 2950424034:
					return typeof(ArtilleryStrikeEntityData).GetProperty(nameof(MaxProjectilesPerStrike));

				case 1850427516:
					return typeof(ArtilleryStrikeEntityData).GetProperty(nameof(MinProjectilesPerStrike));

				case 197288222:
					return typeof(ArtilleryStrikeEntityData).GetProperty(nameof(FollowSoldier));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
