///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 56)]
	public class PatrolOrderEntityData :
		BFOrderEntityData
	{
		[ContainerField(40), JsonProperty(Order = 40)]
		public RouteType TypeOfRoute { get; set; } = new();

		[ContainerField(44), JsonProperty(Order = 44)]
		public CombatPatrolMode CombatMode { get; set; } = new();

		[ContainerField(48), JsonProperty(Order = 48)]
		public CtrRef<WaypointData> StartingWaypoint { get; set; } = new();

		[ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		public bool StartAtGeometricallyClosestWaypoint { get; set; }

		[ContainerField(53), LayoutImmutable, Blittable, JsonProperty(Order = 53)]
		public bool UsePathFinding { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) TypeOfRoute);
			p_Writer.Write((int) CombatMode);
			p_Writer.Write(p_EbxWriter.WriteImport(StartingWaypoint));
			p_Writer.Write(StartAtGeometricallyClosestWaypoint);
			p_Writer.Write(UsePathFinding);
			p_Writer.WriteNullBytes(2);
		}
	}
}
