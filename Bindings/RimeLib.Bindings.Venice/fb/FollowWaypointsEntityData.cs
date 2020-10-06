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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(20), ContainerClass]
	public class FollowWaypointsEntityData : 
		EntityData
	{
		protected RouteType m_TypeOfRoute = new RouteType();
		[ContainerField(12), MemberInfoFlag(137), ContainerFieldNameHash(2152665933)]
		public RouteType TypeOfRoute { get { return m_TypeOfRoute; } set { if (OnPropertyChanging("FollowWaypointsEntityData." + nameof(TypeOfRoute), this, m_TypeOfRoute, value)) m_TypeOfRoute = value; } } // 0xC (12)
		
		protected bool m_UsePathFinding = new bool();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2941510446)]
		public bool UsePathFinding { get { return m_UsePathFinding; } set { if (OnPropertyChanging("FollowWaypointsEntityData." + nameof(UsePathFinding), this, m_UsePathFinding, value)) m_UsePathFinding = value; } } // 0x10 (16)
		
		protected bool m_StartAtGeometricallyClosestWaypoint = new bool();
		[ContainerField(17), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(4268018707)]
		public bool StartAtGeometricallyClosestWaypoint { get { return m_StartAtGeometricallyClosestWaypoint; } set { if (OnPropertyChanging("FollowWaypointsEntityData." + nameof(StartAtGeometricallyClosestWaypoint), this, m_StartAtGeometricallyClosestWaypoint, value)) m_StartAtGeometricallyClosestWaypoint = value; } } // 0x11 (17)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2152665933:
					TypeOfRoute = (RouteType) Enum.ToObject(typeof(RouteType), p_Value);
					break;

				case 2941510446:
					UsePathFinding = (bool) p_Value;
					break;

				case 4268018707:
					StartAtGeometricallyClosestWaypoint = (bool) p_Value;
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

				case 2941510446:
					return UsePathFinding;

				case 4268018707:
					return StartAtGeometricallyClosestWaypoint;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2152665933:
					return typeof(FollowWaypointsEntityData).GetProperty(nameof(TypeOfRoute));

				case 2941510446:
					return typeof(FollowWaypointsEntityData).GetProperty(nameof(UsePathFinding));

				case 4268018707:
					return typeof(FollowWaypointsEntityData).GetProperty(nameof(StartAtGeometricallyClosestWaypoint));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
