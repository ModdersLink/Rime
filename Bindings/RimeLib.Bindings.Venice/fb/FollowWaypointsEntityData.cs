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
	public class FollowWaypointsEntityData : 
		EntityData
	{
		[ContainerField(12)]
		public RouteType TypeOfRoute { get; set; } = new RouteType(); // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public bool UsePathFinding { get; set; } // 0x10 (16)
		
		[ContainerField(17), LayoutImmutable, Blittable]
		public bool StartAtGeometricallyClosestWaypoint { get; set; } // 0x11 (17)
		
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
