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
	public class KillCounterEntityData : 
		GameEntityData
	{
		protected KillWeight m_TeamKillWeight = new KillWeight();
		[ContainerField(96), MemberInfoFlag(41), ContainerFieldNameHash(998126394)]
		public KillWeight TeamKillWeight { get { return m_TeamKillWeight; } set { if (OnPropertyChanging("KillCounterEntityData." + nameof(TeamKillWeight), this, m_TeamKillWeight, value)) m_TeamKillWeight = value; } } // 0x60 (96)
		
		protected TeamId m_TeamId = new TeamId();
		[ContainerField(108), MemberInfoFlag(137), ContainerFieldNameHash(3220374101)]
		public TeamId TeamId { get { return m_TeamId; } set { if (OnPropertyChanging("KillCounterEntityData." + nameof(TeamId), this, m_TeamId, value)) m_TeamId = value; } } // 0x6C (108)
		
		protected KillWeight m_NeutralTeamWeight = new KillWeight();
		[ContainerField(112), MemberInfoFlag(41), ContainerFieldNameHash(358454093)]
		public KillWeight NeutralTeamWeight { get { return m_NeutralTeamWeight; } set { if (OnPropertyChanging("KillCounterEntityData." + nameof(NeutralTeamWeight), this, m_NeutralTeamWeight, value)) m_NeutralTeamWeight = value; } } // 0x70 (112)
		
		protected float m_EnemyWeight = new float();
		[ContainerField(124), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3888167615)]
		public float EnemyWeight { get { return m_EnemyWeight; } set { if (OnPropertyChanging("KillCounterEntityData." + nameof(EnemyWeight), this, m_EnemyWeight, value)) m_EnemyWeight = value; } } // 0x7C (124)
		
		protected uint m_MaxKillCount = new uint();
		[ContainerField(128), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(4105122832)]
		public uint MaxKillCount { get { return m_MaxKillCount; } set { if (OnPropertyChanging("KillCounterEntityData." + nameof(MaxKillCount), this, m_MaxKillCount, value)) m_MaxKillCount = value; } } // 0x80 (128)
		
		protected bool m_IgnoreAI = new bool();
		[ContainerField(132), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3960373301)]
		public bool IgnoreAI { get { return m_IgnoreAI; } set { if (OnPropertyChanging("KillCounterEntityData." + nameof(IgnoreAI), this, m_IgnoreAI, value)) m_IgnoreAI = value; } } // 0x84 (132)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 998126394:
					TeamKillWeight = (KillWeight) p_Value;
					break;

				case 3220374101:
					TeamId = (TeamId) Enum.ToObject(typeof(TeamId), p_Value);
					break;

				case 358454093:
					NeutralTeamWeight = (KillWeight) p_Value;
					break;

				case 3888167615:
					EnemyWeight = (float) p_Value;
					break;

				case 4105122832:
					MaxKillCount = (uint) p_Value;
					break;

				case 3960373301:
					IgnoreAI = (bool) p_Value;
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
				case 998126394:
					return TeamKillWeight;

				case 3220374101:
					return TeamId;

				case 358454093:
					return NeutralTeamWeight;

				case 3888167615:
					return EnemyWeight;

				case 4105122832:
					return MaxKillCount;

				case 3960373301:
					return IgnoreAI;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 998126394:
					return typeof(KillCounterEntityData).GetProperty(nameof(TeamKillWeight));

				case 3220374101:
					return typeof(KillCounterEntityData).GetProperty(nameof(TeamId));

				case 358454093:
					return typeof(KillCounterEntityData).GetProperty(nameof(NeutralTeamWeight));

				case 3888167615:
					return typeof(KillCounterEntityData).GetProperty(nameof(EnemyWeight));

				case 4105122832:
					return typeof(KillCounterEntityData).GetProperty(nameof(MaxKillCount));

				case 3960373301:
					return typeof(KillCounterEntityData).GetProperty(nameof(IgnoreAI));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
