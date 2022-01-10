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

		public static void Deserialize(PatrolOrderEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.TypeOfRoute = (RouteType) p_Reader.ReadInt32();
			p_Instance.CombatMode = (CombatPatrolMode) p_Reader.ReadInt32();
			p_Instance.StartingWaypoint.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.StartAtGeometricallyClosestWaypoint = p_Reader.ReadBool();
			p_Instance.UsePathFinding = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
		}

	}
}
