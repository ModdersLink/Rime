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
	public class ClearAreaTriggerEntityData : 
		TriggerEntityData
	{
		protected TeamId m_TeamOfImmortalSoldiers = new TeamId();
		[ContainerField(112), MemberInfoFlag(137), ContainerFieldNameHash(3105392997)]
		public TeamId TeamOfImmortalSoldiers { get { return m_TeamOfImmortalSoldiers; } set { if (OnPropertyChanging("ClearAreaTriggerEntityData." + nameof(TeamOfImmortalSoldiers), this, m_TeamOfImmortalSoldiers, value)) m_TeamOfImmortalSoldiers = value; } } // 0x70 (112)
		
		protected bool m_RemoveBangers = new bool();
		[ContainerField(116), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(708015725)]
		public bool RemoveBangers { get { return m_RemoveBangers; } set { if (OnPropertyChanging("ClearAreaTriggerEntityData." + nameof(RemoveBangers), this, m_RemoveBangers, value)) m_RemoveBangers = value; } } // 0x74 (116)
		
		protected bool m_RemoveVehicles = new bool();
		[ContainerField(117), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2903248424)]
		public bool RemoveVehicles { get { return m_RemoveVehicles; } set { if (OnPropertyChanging("ClearAreaTriggerEntityData." + nameof(RemoveVehicles), this, m_RemoveVehicles, value)) m_RemoveVehicles = value; } } // 0x75 (117)
		
		protected bool m_RemoveEffects = new bool();
		[ContainerField(118), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(234155399)]
		public bool RemoveEffects { get { return m_RemoveEffects; } set { if (OnPropertyChanging("ClearAreaTriggerEntityData." + nameof(RemoveEffects), this, m_RemoveEffects, value)) m_RemoveEffects = value; } } // 0x76 (118)
		
		protected bool m_RemoveStaticModels = new bool();
		[ContainerField(119), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(521881607)]
		public bool RemoveStaticModels { get { return m_RemoveStaticModels; } set { if (OnPropertyChanging("ClearAreaTriggerEntityData." + nameof(RemoveStaticModels), this, m_RemoveStaticModels, value)) m_RemoveStaticModels = value; } } // 0x77 (119)
		
		protected bool m_RemoveDebrisClusters = new bool();
		[ContainerField(120), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2304161393)]
		public bool RemoveDebrisClusters { get { return m_RemoveDebrisClusters; } set { if (OnPropertyChanging("ClearAreaTriggerEntityData." + nameof(RemoveDebrisClusters), this, m_RemoveDebrisClusters, value)) m_RemoveDebrisClusters = value; } } // 0x78 (120)
		
		protected bool m_ExcludeImmortalSoldiersInTeam = new bool();
		[ContainerField(121), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1181765645)]
		public bool ExcludeImmortalSoldiersInTeam { get { return m_ExcludeImmortalSoldiersInTeam; } set { if (OnPropertyChanging("ClearAreaTriggerEntityData." + nameof(ExcludeImmortalSoldiersInTeam), this, m_ExcludeImmortalSoldiersInTeam, value)) m_ExcludeImmortalSoldiersInTeam = value; } } // 0x79 (121)
		
		protected bool m_RemoveMeshProxies = new bool();
		[ContainerField(122), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(539264666)]
		public bool RemoveMeshProxies { get { return m_RemoveMeshProxies; } set { if (OnPropertyChanging("ClearAreaTriggerEntityData." + nameof(RemoveMeshProxies), this, m_RemoveMeshProxies, value)) m_RemoveMeshProxies = value; } } // 0x7A (122)
		
		protected bool m_RemoveSoldiers = new bool();
		[ContainerField(123), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(466109562)]
		public bool RemoveSoldiers { get { return m_RemoveSoldiers; } set { if (OnPropertyChanging("ClearAreaTriggerEntityData." + nameof(RemoveSoldiers), this, m_RemoveSoldiers, value)) m_RemoveSoldiers = value; } } // 0x7B (123)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3105392997:
					TeamOfImmortalSoldiers = (TeamId) Enum.ToObject(typeof(TeamId), p_Value);
					break;

				case 708015725:
					RemoveBangers = (bool) p_Value;
					break;

				case 2903248424:
					RemoveVehicles = (bool) p_Value;
					break;

				case 234155399:
					RemoveEffects = (bool) p_Value;
					break;

				case 521881607:
					RemoveStaticModels = (bool) p_Value;
					break;

				case 2304161393:
					RemoveDebrisClusters = (bool) p_Value;
					break;

				case 1181765645:
					ExcludeImmortalSoldiersInTeam = (bool) p_Value;
					break;

				case 539264666:
					RemoveMeshProxies = (bool) p_Value;
					break;

				case 466109562:
					RemoveSoldiers = (bool) p_Value;
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
				case 3105392997:
					return TeamOfImmortalSoldiers;

				case 708015725:
					return RemoveBangers;

				case 2903248424:
					return RemoveVehicles;

				case 234155399:
					return RemoveEffects;

				case 521881607:
					return RemoveStaticModels;

				case 2304161393:
					return RemoveDebrisClusters;

				case 1181765645:
					return ExcludeImmortalSoldiersInTeam;

				case 539264666:
					return RemoveMeshProxies;

				case 466109562:
					return RemoveSoldiers;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3105392997:
					return typeof(ClearAreaTriggerEntityData).GetProperty(nameof(TeamOfImmortalSoldiers));

				case 708015725:
					return typeof(ClearAreaTriggerEntityData).GetProperty(nameof(RemoveBangers));

				case 2903248424:
					return typeof(ClearAreaTriggerEntityData).GetProperty(nameof(RemoveVehicles));

				case 234155399:
					return typeof(ClearAreaTriggerEntityData).GetProperty(nameof(RemoveEffects));

				case 521881607:
					return typeof(ClearAreaTriggerEntityData).GetProperty(nameof(RemoveStaticModels));

				case 2304161393:
					return typeof(ClearAreaTriggerEntityData).GetProperty(nameof(RemoveDebrisClusters));

				case 1181765645:
					return typeof(ClearAreaTriggerEntityData).GetProperty(nameof(ExcludeImmortalSoldiersInTeam));

				case 539264666:
					return typeof(ClearAreaTriggerEntityData).GetProperty(nameof(RemoveMeshProxies));

				case 466109562:
					return typeof(ClearAreaTriggerEntityData).GetProperty(nameof(RemoveSoldiers));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
