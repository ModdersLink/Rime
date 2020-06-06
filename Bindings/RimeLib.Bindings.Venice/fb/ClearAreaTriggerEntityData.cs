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
	public class ClearAreaTriggerEntityData : 
		TriggerEntityData
	{
		[ContainerField(112)]
		public TeamId TeamOfImmortalSoldiers { get; set; } = new TeamId(); // 0x70 (112)
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public bool RemoveBangers { get; set; } // 0x74 (116)
		
		[ContainerField(117), LayoutImmutable, Blittable]
		public bool RemoveVehicles { get; set; } // 0x75 (117)
		
		[ContainerField(118), LayoutImmutable, Blittable]
		public bool RemoveEffects { get; set; } // 0x76 (118)
		
		[ContainerField(119), LayoutImmutable, Blittable]
		public bool RemoveStaticModels { get; set; } // 0x77 (119)
		
		[ContainerField(120), LayoutImmutable, Blittable]
		public bool RemoveDebrisClusters { get; set; } // 0x78 (120)
		
		[ContainerField(121), LayoutImmutable, Blittable]
		public bool ExcludeImmortalSoldiersInTeam { get; set; } // 0x79 (121)
		
		[ContainerField(122), LayoutImmutable, Blittable]
		public bool RemoveMeshProxies { get; set; } // 0x7A (122)
		
		[ContainerField(123), LayoutImmutable, Blittable]
		public bool RemoveSoldiers { get; set; } // 0x7B (123)
		
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
