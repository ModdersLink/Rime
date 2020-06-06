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
	public class KillCounterEntityData : 
		GameEntityData
	{
		[ContainerField(96)]
		public KillWeight TeamKillWeight { get; set; } = new KillWeight(); // 0x60 (96)
		
		[ContainerField(108)]
		public TeamId TeamId { get; set; } = new TeamId(); // 0x6C (108)
		
		[ContainerField(112)]
		public KillWeight NeutralTeamWeight { get; set; } = new KillWeight(); // 0x70 (112)
		
		[ContainerField(124), LayoutImmutable, Blittable]
		public float EnemyWeight { get; set; } // 0x7C (124)
		
		[ContainerField(128), LayoutImmutable, Blittable]
		public uint MaxKillCount { get; set; } // 0x80 (128)
		
		[ContainerField(132), LayoutImmutable, Blittable]
		public bool IgnoreAI { get; set; } // 0x84 (132)
		
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
