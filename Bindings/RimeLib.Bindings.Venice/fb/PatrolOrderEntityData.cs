///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 56)]
	public class PatrolOrderEntityData : 
		BFOrderEntityData
	{
		[ContainerField(40)]
		public RouteType TypeOfRoute { get; set; } = new();

		[ContainerField(44)]
		public CombatPatrolMode CombatMode { get; set; } = new();

		[ContainerField(48)]
		public CtrRef<WaypointData> StartingWaypoint { get; set; } = new();

		[ContainerField(52), LayoutImmutable, Blittable]
		public bool StartAtGeometricallyClosestWaypoint { get; set; }

		[ContainerField(53), LayoutImmutable, Blittable]
		public bool UsePathFinding { get; set; }

	}
}
