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
	[ContainerType(16), MemberInfoFlag(53), ContainerSize(128), ContainerClass]
	public class CombatAreaTriggerEntityData : 
		GameEntityData
	{
		protected float m_MaxRandomSpawnHeight = new float();
		[ContainerField(96), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2881356526)]
		public float MaxRandomSpawnHeight { get { return m_MaxRandomSpawnHeight; } set { if (OnPropertyChanging("CombatAreaTriggerEntityData." + nameof(MaxRandomSpawnHeight), this, m_MaxRandomSpawnHeight, value)) m_MaxRandomSpawnHeight = value; } } // 0x60 (96)
		
		protected float m_SpawnHeight = new float();
		[ContainerField(100), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2780846849)]
		public float SpawnHeight { get { return m_SpawnHeight; } set { if (OnPropertyChanging("CombatAreaTriggerEntityData." + nameof(SpawnHeight), this, m_SpawnHeight, value)) m_SpawnHeight = value; } } // 0x64 (100)
		
		protected uint m_TimeToReturn = new uint();
		[ContainerField(104), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(2769825281)]
		public uint TimeToReturn { get { return m_TimeToReturn; } set { if (OnPropertyChanging("CombatAreaTriggerEntityData." + nameof(TimeToReturn), this, m_TimeToReturn, value)) m_TimeToReturn = value; } } // 0x68 (104)
		
		protected CtrRef<BulletEntityData> m_DeserterProjectile = new CtrRef<BulletEntityData>();
		[ContainerField(108), MemberInfoFlag(53), ContainerFieldNameHash(1751079062), ContainerCtrRef]
		public CtrRef<BulletEntityData> DeserterProjectile { get { return m_DeserterProjectile; } set { if (OnPropertyChanging("CombatAreaTriggerEntityData." + nameof(DeserterProjectile), this, m_DeserterProjectile, value)) m_DeserterProjectile = value; } } // 0x6C (108)
		
		protected TeamId m_Team = new TeamId();
		[ContainerField(112), MemberInfoFlag(137), ContainerFieldNameHash(2089309528)]
		public TeamId Team { get { return m_Team; } set { if (OnPropertyChanging("CombatAreaTriggerEntityData." + nameof(Team), this, m_Team, value)) m_Team = value; } } // 0x70 (112)
		
		protected float m_StrikeRadius = new float();
		[ContainerField(116), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(4030357871)]
		public float StrikeRadius { get { return m_StrikeRadius; } set { if (OnPropertyChanging("CombatAreaTriggerEntityData." + nameof(StrikeRadius), this, m_StrikeRadius, value)) m_StrikeRadius = value; } } // 0x74 (116)
		
		protected float m_InitalSpeed = new float();
		[ContainerField(120), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3835059573)]
		public float InitalSpeed { get { return m_InitalSpeed; } set { if (OnPropertyChanging("CombatAreaTriggerEntityData." + nameof(InitalSpeed), this, m_InitalSpeed, value)) m_InitalSpeed = value; } } // 0x78 (120)
		
		protected bool m_IsAiAllowedOutside = new bool();
		[ContainerField(124), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(4144947226)]
		public bool IsAiAllowedOutside { get { return m_IsAiAllowedOutside; } set { if (OnPropertyChanging("CombatAreaTriggerEntityData." + nameof(IsAiAllowedOutside), this, m_IsAiAllowedOutside, value)) m_IsAiAllowedOutside = value; } } // 0x7C (124)
		
		protected bool m_IsTeamSpecific = new bool();
		[ContainerField(125), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3554635554)]
		public bool IsTeamSpecific { get { return m_IsTeamSpecific; } set { if (OnPropertyChanging("CombatAreaTriggerEntityData." + nameof(IsTeamSpecific), this, m_IsTeamSpecific, value)) m_IsTeamSpecific = value; } } // 0x7D (125)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2881356526:
					MaxRandomSpawnHeight = (float) p_Value;
					break;

				case 2780846849:
					SpawnHeight = (float) p_Value;
					break;

				case 2769825281:
					TimeToReturn = (uint) p_Value;
					break;

				case 1751079062:
					DeserterProjectile = (CtrRef<BulletEntityData>) p_Value;
					break;

				case 2089309528:
					Team = (TeamId) Enum.ToObject(typeof(TeamId), p_Value);
					break;

				case 4030357871:
					StrikeRadius = (float) p_Value;
					break;

				case 3835059573:
					InitalSpeed = (float) p_Value;
					break;

				case 4144947226:
					IsAiAllowedOutside = (bool) p_Value;
					break;

				case 3554635554:
					IsTeamSpecific = (bool) p_Value;
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
				case 2881356526:
					return MaxRandomSpawnHeight;

				case 2780846849:
					return SpawnHeight;

				case 2769825281:
					return TimeToReturn;

				case 1751079062:
					return DeserterProjectile;

				case 2089309528:
					return Team;

				case 4030357871:
					return StrikeRadius;

				case 3835059573:
					return InitalSpeed;

				case 4144947226:
					return IsAiAllowedOutside;

				case 3554635554:
					return IsTeamSpecific;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2881356526:
					return typeof(CombatAreaTriggerEntityData).GetProperty(nameof(MaxRandomSpawnHeight));

				case 2780846849:
					return typeof(CombatAreaTriggerEntityData).GetProperty(nameof(SpawnHeight));

				case 2769825281:
					return typeof(CombatAreaTriggerEntityData).GetProperty(nameof(TimeToReturn));

				case 1751079062:
					return typeof(CombatAreaTriggerEntityData).GetProperty(nameof(DeserterProjectile));

				case 2089309528:
					return typeof(CombatAreaTriggerEntityData).GetProperty(nameof(Team));

				case 4030357871:
					return typeof(CombatAreaTriggerEntityData).GetProperty(nameof(StrikeRadius));

				case 3835059573:
					return typeof(CombatAreaTriggerEntityData).GetProperty(nameof(InitalSpeed));

				case 4144947226:
					return typeof(CombatAreaTriggerEntityData).GetProperty(nameof(IsAiAllowedOutside));

				case 3554635554:
					return typeof(CombatAreaTriggerEntityData).GetProperty(nameof(IsTeamSpecific));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
