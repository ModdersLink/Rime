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

using fb.PathfindingShared;
using fb.Core;
using fb.GameShared;
using fb.Entity;

namespace fb.BFAI2Data;

[ContainerType(8, 56)]
public class BFUseWaypointsEntityData
	: fb.BFAI2Data.BFParameterEntityData
{
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public RouteType TypeOfRoute { get; set; } = RouteType.RouteStop;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public PathfindingChoice PathFinding { get; set; } = PathfindingChoice.PathfindingChoice_Off;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public ExecutionPriority Priority { get; set; } = ExecutionPriority.ExecutionPriority_Idle;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public TacticsEnumeration TacticCondition { get; set; } = TacticsEnumeration.TacticsEnumeration_None;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public bool StartAtGeometricallyClosestWaypoint { get; set; } = false;
	
	[ContainerField(0x31), LayoutImmutable, Blittable, JsonProperty(Order = 49)]
	public bool AllowAIControlAfterDestinationReached { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) TypeOfRoute);
		p_Writer.Write((int) PathFinding);
		p_Writer.Write((int) Priority);
		p_Writer.Write((int) TacticCondition);
		p_Writer.Write(StartAtGeometricallyClosestWaypoint);
		p_Writer.Write(AllowAIControlAfterDestinationReached);
		p_Writer.WriteNullBytes(6);
	}
}

