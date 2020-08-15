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
	[ContainerType(16)]
	public class FlagCounterEntityData : 
		GameEntityData
	{
		protected TeamId m_TeamId = new TeamId();
		[ContainerField(96), ContainerFieldNameHash(3220374101)]
		public TeamId TeamId { get { return m_TeamId; } set { if (OnPropertyChanging("FlagCounterEntityData." + nameof(TeamId), this, m_TeamId, value)) m_TeamId = value; } } // 0x60 (96)
		
		protected float m_EnemyFlagProgress = new float();
		[ContainerField(100), LayoutImmutable, Blittable, ContainerFieldNameHash(1874843822)]
		public float EnemyFlagProgress { get { return m_EnemyFlagProgress; } set { if (OnPropertyChanging("FlagCounterEntityData." + nameof(EnemyFlagProgress), this, m_EnemyFlagProgress, value)) m_EnemyFlagProgress = value; } } // 0x64 (100)
		
		protected float m_RoundTime = new float();
		[ContainerField(104), LayoutImmutable, Blittable, ContainerFieldNameHash(4171794130)]
		public float RoundTime { get { return m_RoundTime; } set { if (OnPropertyChanging("FlagCounterEntityData." + nameof(RoundTime), this, m_RoundTime, value)) m_RoundTime = value; } } // 0x68 (104)
		
		protected int m_ObjectiveFlagCount = new int();
		[ContainerField(108), LayoutImmutable, Blittable, ContainerFieldNameHash(952118181)]
		public int ObjectiveFlagCount { get { return m_ObjectiveFlagCount; } set { if (OnPropertyChanging("FlagCounterEntityData." + nameof(ObjectiveFlagCount), this, m_ObjectiveFlagCount, value)) m_ObjectiveFlagCount = value; } } // 0x6C (108)
		
		protected bool m_VisibleInMinimap = new bool();
		[ContainerField(112), LayoutImmutable, Blittable, ContainerFieldNameHash(2256980243)]
		public bool VisibleInMinimap { get { return m_VisibleInMinimap; } set { if (OnPropertyChanging("FlagCounterEntityData." + nameof(VisibleInMinimap), this, m_VisibleInMinimap, value)) m_VisibleInMinimap = value; } } // 0x70 (112)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3220374101:
					TeamId = (TeamId) Enum.ToObject(typeof(TeamId), p_Value);
					break;

				case 1874843822:
					EnemyFlagProgress = (float) p_Value;
					break;

				case 4171794130:
					RoundTime = (float) p_Value;
					break;

				case 952118181:
					ObjectiveFlagCount = (int) p_Value;
					break;

				case 2256980243:
					VisibleInMinimap = (bool) p_Value;
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
				case 3220374101:
					return TeamId;

				case 1874843822:
					return EnemyFlagProgress;

				case 4171794130:
					return RoundTime;

				case 952118181:
					return ObjectiveFlagCount;

				case 2256980243:
					return VisibleInMinimap;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3220374101:
					return typeof(FlagCounterEntityData).GetProperty(nameof(TeamId));

				case 1874843822:
					return typeof(FlagCounterEntityData).GetProperty(nameof(EnemyFlagProgress));

				case 4171794130:
					return typeof(FlagCounterEntityData).GetProperty(nameof(RoundTime));

				case 952118181:
					return typeof(FlagCounterEntityData).GetProperty(nameof(ObjectiveFlagCount));

				case 2256980243:
					return typeof(FlagCounterEntityData).GetProperty(nameof(VisibleInMinimap));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
