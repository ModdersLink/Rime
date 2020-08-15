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
	public class DamageAreaTriggerEntityData : 
		TriggerEntityData
	{
		protected float m_DamagePerSecond = new float();
		[ContainerField(112), LayoutImmutable, Blittable, ContainerFieldNameHash(1464141113)]
		public float DamagePerSecond { get { return m_DamagePerSecond; } set { if (OnPropertyChanging("DamageAreaTriggerEntityData." + nameof(DamagePerSecond), this, m_DamagePerSecond, value)) m_DamagePerSecond = value; } } // 0x70 (112)
		
		protected TeamId m_TeamOfImmortalCharacters = new TeamId();
		[ContainerField(116), ContainerFieldNameHash(1833832214)]
		public TeamId TeamOfImmortalCharacters { get { return m_TeamOfImmortalCharacters; } set { if (OnPropertyChanging("DamageAreaTriggerEntityData." + nameof(TeamOfImmortalCharacters), this, m_TeamOfImmortalCharacters, value)) m_TeamOfImmortalCharacters = value; } } // 0x74 (116)
		
		protected float m_DamageTime = new float();
		[ContainerField(120), LayoutImmutable, Blittable, ContainerFieldNameHash(3581575931)]
		public float DamageTime { get { return m_DamageTime; } set { if (OnPropertyChanging("DamageAreaTriggerEntityData." + nameof(DamageTime), this, m_DamageTime, value)) m_DamageTime = value; } } // 0x78 (120)
		
		protected bool m_DamageVehicles = new bool();
		[ContainerField(124), LayoutImmutable, Blittable, ContainerFieldNameHash(1372095173)]
		public bool DamageVehicles { get { return m_DamageVehicles; } set { if (OnPropertyChanging("DamageAreaTriggerEntityData." + nameof(DamageVehicles), this, m_DamageVehicles, value)) m_DamageVehicles = value; } } // 0x7C (124)
		
		protected bool m_DamageBangers = new bool();
		[ContainerField(125), LayoutImmutable, Blittable, ContainerFieldNameHash(2480211808)]
		public bool DamageBangers { get { return m_DamageBangers; } set { if (OnPropertyChanging("DamageAreaTriggerEntityData." + nameof(DamageBangers), this, m_DamageBangers, value)) m_DamageBangers = value; } } // 0x7D (125)
		
		protected bool m_ExcludeImmortalCharactersInTeam = new bool();
		[ContainerField(126), LayoutImmutable, Blittable, ContainerFieldNameHash(2802150974)]
		public bool ExcludeImmortalCharactersInTeam { get { return m_ExcludeImmortalCharactersInTeam; } set { if (OnPropertyChanging("DamageAreaTriggerEntityData." + nameof(ExcludeImmortalCharactersInTeam), this, m_ExcludeImmortalCharactersInTeam, value)) m_ExcludeImmortalCharactersInTeam = value; } } // 0x7E (126)
		
		protected bool m_DamageCharacters = new bool();
		[ContainerField(127), LayoutImmutable, Blittable, ContainerFieldNameHash(3682715684)]
		public bool DamageCharacters { get { return m_DamageCharacters; } set { if (OnPropertyChanging("DamageAreaTriggerEntityData." + nameof(DamageCharacters), this, m_DamageCharacters, value)) m_DamageCharacters = value; } } // 0x7F (127)
		
		protected bool m_ExcludeShieldedSoldiers = new bool();
		[ContainerField(128), LayoutImmutable, Blittable, ContainerFieldNameHash(3210013316)]
		public bool ExcludeShieldedSoldiers { get { return m_ExcludeShieldedSoldiers; } set { if (OnPropertyChanging("DamageAreaTriggerEntityData." + nameof(ExcludeShieldedSoldiers), this, m_ExcludeShieldedSoldiers, value)) m_ExcludeShieldedSoldiers = value; } } // 0x80 (128)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1464141113:
					DamagePerSecond = (float) p_Value;
					break;

				case 1833832214:
					TeamOfImmortalCharacters = (TeamId) Enum.ToObject(typeof(TeamId), p_Value);
					break;

				case 3581575931:
					DamageTime = (float) p_Value;
					break;

				case 1372095173:
					DamageVehicles = (bool) p_Value;
					break;

				case 2480211808:
					DamageBangers = (bool) p_Value;
					break;

				case 2802150974:
					ExcludeImmortalCharactersInTeam = (bool) p_Value;
					break;

				case 3682715684:
					DamageCharacters = (bool) p_Value;
					break;

				case 3210013316:
					ExcludeShieldedSoldiers = (bool) p_Value;
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
				case 1464141113:
					return DamagePerSecond;

				case 1833832214:
					return TeamOfImmortalCharacters;

				case 3581575931:
					return DamageTime;

				case 1372095173:
					return DamageVehicles;

				case 2480211808:
					return DamageBangers;

				case 2802150974:
					return ExcludeImmortalCharactersInTeam;

				case 3682715684:
					return DamageCharacters;

				case 3210013316:
					return ExcludeShieldedSoldiers;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1464141113:
					return typeof(DamageAreaTriggerEntityData).GetProperty(nameof(DamagePerSecond));

				case 1833832214:
					return typeof(DamageAreaTriggerEntityData).GetProperty(nameof(TeamOfImmortalCharacters));

				case 3581575931:
					return typeof(DamageAreaTriggerEntityData).GetProperty(nameof(DamageTime));

				case 1372095173:
					return typeof(DamageAreaTriggerEntityData).GetProperty(nameof(DamageVehicles));

				case 2480211808:
					return typeof(DamageAreaTriggerEntityData).GetProperty(nameof(DamageBangers));

				case 2802150974:
					return typeof(DamageAreaTriggerEntityData).GetProperty(nameof(ExcludeImmortalCharactersInTeam));

				case 3682715684:
					return typeof(DamageAreaTriggerEntityData).GetProperty(nameof(DamageCharacters));

				case 3210013316:
					return typeof(DamageAreaTriggerEntityData).GetProperty(nameof(ExcludeShieldedSoldiers));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
