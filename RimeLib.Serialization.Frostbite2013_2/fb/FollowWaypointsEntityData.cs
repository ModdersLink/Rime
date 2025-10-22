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

using fb.Core;
using fb.GameShared;
using fb.Entity;

namespace fb.PathfindingShared;

[ContainerType(8, 32)]
public class FollowWaypointsEntityData
	: fb.Entity.EntityData
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public RouteType TypeOfRoute { get; set; } = RouteType.RouteStop;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public bool UsePathFinding { get; set; } = false;
	
	[ContainerField(0x1d), LayoutImmutable, Blittable, JsonProperty(Order = 29)]
	public bool StartAtGeometricallyClosestWaypoint { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) TypeOfRoute);
		p_Writer.Write(UsePathFinding);
		p_Writer.Write(StartAtGeometricallyClosestWaypoint);
		p_Writer.WriteNullBytes(2);
	}
}

