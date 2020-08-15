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
	[ContainerType(4)]
	public class PatrolOrderEntityData : 
		BFOrderEntityData
	{
		protected RouteType m_TypeOfRoute = new RouteType();
		[ContainerField(40), ContainerFieldNameHash(2152665933)]
		public RouteType TypeOfRoute { get { return m_TypeOfRoute; } set { if (OnPropertyChanging("PatrolOrderEntityData." + nameof(TypeOfRoute), this, m_TypeOfRoute, value)) m_TypeOfRoute = value; } } // 0x28 (40)
		
		protected CombatPatrolMode m_CombatMode = new CombatPatrolMode();
		[ContainerField(44), ContainerFieldNameHash(3144829264)]
		public CombatPatrolMode CombatMode { get { return m_CombatMode; } set { if (OnPropertyChanging("PatrolOrderEntityData." + nameof(CombatMode), this, m_CombatMode, value)) m_CombatMode = value; } } // 0x2C (44)
		
		protected CtrRef<WaypointData> m_StartingWaypoint = new CtrRef<WaypointData>();
		[ContainerField(48), ContainerFieldNameHash(3942738150)]
		public CtrRef<WaypointData> StartingWaypoint { get { return m_StartingWaypoint; } set { if (OnPropertyChanging("PatrolOrderEntityData." + nameof(StartingWaypoint), this, m_StartingWaypoint, value)) m_StartingWaypoint = value; } } // 0x30 (48)
		
		protected bool m_StartAtGeometricallyClosestWaypoint = new bool();
		[ContainerField(52), LayoutImmutable, Blittable, ContainerFieldNameHash(4268018707)]
		public bool StartAtGeometricallyClosestWaypoint { get { return m_StartAtGeometricallyClosestWaypoint; } set { if (OnPropertyChanging("PatrolOrderEntityData." + nameof(StartAtGeometricallyClosestWaypoint), this, m_StartAtGeometricallyClosestWaypoint, value)) m_StartAtGeometricallyClosestWaypoint = value; } } // 0x34 (52)
		
		protected bool m_UsePathFinding = new bool();
		[ContainerField(53), LayoutImmutable, Blittable, ContainerFieldNameHash(2941510446)]
		public bool UsePathFinding { get { return m_UsePathFinding; } set { if (OnPropertyChanging("PatrolOrderEntityData." + nameof(UsePathFinding), this, m_UsePathFinding, value)) m_UsePathFinding = value; } } // 0x35 (53)
		
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
