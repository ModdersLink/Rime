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
	public class ArtilleryStrikeEntityData : 
		GameEntityData
	{
		protected CtrRef<MissileEntityData> m_MissileData = new CtrRef<MissileEntityData>();
		[ContainerField(96), MemberInfoFlag(53), ContainerFieldNameHash(2091932305), ContainerCtrRef]
		public CtrRef<MissileEntityData> MissileData { get { return m_MissileData; } set { if (OnPropertyChanging("ArtilleryStrikeEntityData." + nameof(MissileData), this, m_MissileData, value)) m_MissileData = value; } } // 0x60 (96)
		
		protected float m_MissileSpawnRadius = new float();
		[ContainerField(100), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(332972706)]
		public float MissileSpawnRadius { get { return m_MissileSpawnRadius; } set { if (OnPropertyChanging("ArtilleryStrikeEntityData." + nameof(MissileSpawnRadius), this, m_MissileSpawnRadius, value)) m_MissileSpawnRadius = value; } } // 0x64 (100)
		
		protected float m_DurationOfArtilleryStrike = new float();
		[ContainerField(104), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2959930496)]
		public float DurationOfArtilleryStrike { get { return m_DurationOfArtilleryStrike; } set { if (OnPropertyChanging("ArtilleryStrikeEntityData." + nameof(DurationOfArtilleryStrike), this, m_DurationOfArtilleryStrike, value)) m_DurationOfArtilleryStrike = value; } } // 0x68 (104)
		
		protected float m_MaxDelayBetweenProjectiles = new float();
		[ContainerField(108), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(523843432)]
		public float MaxDelayBetweenProjectiles { get { return m_MaxDelayBetweenProjectiles; } set { if (OnPropertyChanging("ArtilleryStrikeEntityData." + nameof(MaxDelayBetweenProjectiles), this, m_MaxDelayBetweenProjectiles, value)) m_MaxDelayBetweenProjectiles = value; } } // 0x6C (108)
		
		protected float m_MinDelayBetweenProjectiles = new float();
		[ContainerField(112), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3958890294)]
		public float MinDelayBetweenProjectiles { get { return m_MinDelayBetweenProjectiles; } set { if (OnPropertyChanging("ArtilleryStrikeEntityData." + nameof(MinDelayBetweenProjectiles), this, m_MinDelayBetweenProjectiles, value)) m_MinDelayBetweenProjectiles = value; } } // 0x70 (112)
		
		protected float m_MaxDelayBetweenStrikes = new float();
		[ContainerField(116), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2099842575)]
		public float MaxDelayBetweenStrikes { get { return m_MaxDelayBetweenStrikes; } set { if (OnPropertyChanging("ArtilleryStrikeEntityData." + nameof(MaxDelayBetweenStrikes), this, m_MaxDelayBetweenStrikes, value)) m_MaxDelayBetweenStrikes = value; } } // 0x74 (116)
		
		protected float m_MinDelayBetweenStrikes = new float();
		[ContainerField(120), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3998184017)]
		public float MinDelayBetweenStrikes { get { return m_MinDelayBetweenStrikes; } set { if (OnPropertyChanging("ArtilleryStrikeEntityData." + nameof(MinDelayBetweenStrikes), this, m_MinDelayBetweenStrikes, value)) m_MinDelayBetweenStrikes = value; } } // 0x78 (120)
		
		protected float m_MinRadiusToSoldier = new float();
		[ContainerField(124), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1839985574)]
		public float MinRadiusToSoldier { get { return m_MinRadiusToSoldier; } set { if (OnPropertyChanging("ArtilleryStrikeEntityData." + nameof(MinRadiusToSoldier), this, m_MinRadiusToSoldier, value)) m_MinRadiusToSoldier = value; } } // 0x7C (124)
		
		protected float m_RadiusWhenFollowingSoldier = new float();
		[ContainerField(128), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(244255762)]
		public float RadiusWhenFollowingSoldier { get { return m_RadiusWhenFollowingSoldier; } set { if (OnPropertyChanging("ArtilleryStrikeEntityData." + nameof(RadiusWhenFollowingSoldier), this, m_RadiusWhenFollowingSoldier, value)) m_RadiusWhenFollowingSoldier = value; } } // 0x80 (128)
		
		protected float m_HeightOffsetWhenFollowingSoldier = new float();
		[ContainerField(132), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1202047928)]
		public float HeightOffsetWhenFollowingSoldier { get { return m_HeightOffsetWhenFollowingSoldier; } set { if (OnPropertyChanging("ArtilleryStrikeEntityData." + nameof(HeightOffsetWhenFollowingSoldier), this, m_HeightOffsetWhenFollowingSoldier, value)) m_HeightOffsetWhenFollowingSoldier = value; } } // 0x84 (132)
		
		protected uint m_NumberOfStrikes = new uint();
		[ContainerField(136), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(3316180366)]
		public uint NumberOfStrikes { get { return m_NumberOfStrikes; } set { if (OnPropertyChanging("ArtilleryStrikeEntityData." + nameof(NumberOfStrikes), this, m_NumberOfStrikes, value)) m_NumberOfStrikes = value; } } // 0x88 (136)
		
		protected uint m_MaxProjectilesPerStrike = new uint();
		[ContainerField(140), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(2950424034)]
		public uint MaxProjectilesPerStrike { get { return m_MaxProjectilesPerStrike; } set { if (OnPropertyChanging("ArtilleryStrikeEntityData." + nameof(MaxProjectilesPerStrike), this, m_MaxProjectilesPerStrike, value)) m_MaxProjectilesPerStrike = value; } } // 0x8C (140)
		
		protected uint m_MinProjectilesPerStrike = new uint();
		[ContainerField(144), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(1850427516)]
		public uint MinProjectilesPerStrike { get { return m_MinProjectilesPerStrike; } set { if (OnPropertyChanging("ArtilleryStrikeEntityData." + nameof(MinProjectilesPerStrike), this, m_MinProjectilesPerStrike, value)) m_MinProjectilesPerStrike = value; } } // 0x90 (144)
		
		protected bool m_FollowSoldier = new bool();
		[ContainerField(148), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(197288222)]
		public bool FollowSoldier { get { return m_FollowSoldier; } set { if (OnPropertyChanging("ArtilleryStrikeEntityData." + nameof(FollowSoldier), this, m_FollowSoldier, value)) m_FollowSoldier = value; } } // 0x94 (148)
		
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
