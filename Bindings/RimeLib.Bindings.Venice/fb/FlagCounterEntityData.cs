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
	public class FlagCounterEntityData : 
		GameEntityData
	{
		protected TeamId m_TeamId = new TeamId();
		[ContainerField(Name: "TeamId", Offset: 96, NameHash: 3220374101, Flags: 137)]
		public TeamId TeamId { get { return m_TeamId; } set { if (OnPropertyChanging("FlagCounterEntityData." + nameof(TeamId), this, m_TeamId, value)) m_TeamId = value; } } // 0x60 (96)
		
		protected float m_EnemyFlagProgress = new float();
		[ContainerField(Name: "EnemyFlagProgress", Offset: 100, NameHash: 1874843822, Flags: 49469), LayoutImmutable, Blittable]
		public float EnemyFlagProgress { get { return m_EnemyFlagProgress; } set { if (OnPropertyChanging("FlagCounterEntityData." + nameof(EnemyFlagProgress), this, m_EnemyFlagProgress, value)) m_EnemyFlagProgress = value; } } // 0x64 (100)
		
		protected float m_RoundTime = new float();
		[ContainerField(Name: "RoundTime", Offset: 104, NameHash: 4171794130, Flags: 49469), LayoutImmutable, Blittable]
		public float RoundTime { get { return m_RoundTime; } set { if (OnPropertyChanging("FlagCounterEntityData." + nameof(RoundTime), this, m_RoundTime, value)) m_RoundTime = value; } } // 0x68 (104)
		
		protected int m_ObjectiveFlagCount = new int();
		[ContainerField(Name: "ObjectiveFlagCount", Offset: 108, NameHash: 952118181, Flags: 49405), LayoutImmutable, Blittable]
		public int ObjectiveFlagCount { get { return m_ObjectiveFlagCount; } set { if (OnPropertyChanging("FlagCounterEntityData." + nameof(ObjectiveFlagCount), this, m_ObjectiveFlagCount, value)) m_ObjectiveFlagCount = value; } } // 0x6C (108)
		
		protected bool m_VisibleInMinimap = new bool();
		[ContainerField(Name: "VisibleInMinimap", Offset: 112, NameHash: 2256980243, Flags: 49325), LayoutImmutable, Blittable]
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
