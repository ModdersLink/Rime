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
    [ContainerType(4)]
	public class PatrolOrderEntityData : 
		BFOrderEntityData
	{
		[ContainerField(40)]
		public RouteType TypeOfRoute { get; set; } = new RouteType(); // 0x28 (40)
		
		[ContainerField(44)]
		public CombatPatrolMode CombatMode { get; set; } = new CombatPatrolMode(); // 0x2C (44)
		
		[ContainerField(48)]
		public CtrRef<WaypointData> StartingWaypoint { get; set; } = new CtrRef<WaypointData>(); // 0x30 (48)
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public bool StartAtGeometricallyClosestWaypoint { get; set; } // 0x34 (52)
		
		[ContainerField(53), LayoutImmutable, Blittable]
		public bool UsePathFinding { get; set; } // 0x35 (53)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2152665933:
					TypeOfRoute = (RouteType) Enum.ToObject(typeof(RouteType), p_Value);
					break;

				case 3144829264:
					CombatMode = (CombatPatrolMode) Enum.ToObject(typeof(CombatPatrolMode), p_Value);
					break;

				case 3942738150:
					StartingWaypoint = (CtrRef<WaypointData>) p_Value;
					break;

				case 4268018707:
					StartAtGeometricallyClosestWaypoint = (bool) p_Value;
					break;

				case 2941510446:
					UsePathFinding = (bool) p_Value;
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
				case 2152665933:
					return TypeOfRoute;

				case 3144829264:
					return CombatMode;

				case 3942738150:
					return StartingWaypoint;

				case 4268018707:
					return StartAtGeometricallyClosestWaypoint;

				case 2941510446:
					return UsePathFinding;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2152665933:
					return typeof(PatrolOrderEntityData).GetProperty(nameof(TypeOfRoute));

				case 3144829264:
					return typeof(PatrolOrderEntityData).GetProperty(nameof(CombatMode));

				case 3942738150:
					return typeof(PatrolOrderEntityData).GetProperty(nameof(StartingWaypoint));

				case 4268018707:
					return typeof(PatrolOrderEntityData).GetProperty(nameof(StartAtGeometricallyClosestWaypoint));

				case 2941510446:
					return typeof(PatrolOrderEntityData).GetProperty(nameof(UsePathFinding));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
