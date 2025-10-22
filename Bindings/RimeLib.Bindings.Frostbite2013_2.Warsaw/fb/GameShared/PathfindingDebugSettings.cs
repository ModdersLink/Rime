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

namespace fb.GameShared;

[ContainerType(8, 64)]
public class PathfindingDebugSettings
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public int TypesToDrawMask { get; set; } = 0;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public float DrawDistance { get; set; } = 10000.000f;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public int TextStartX { get; set; } = 300;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public int TextStartY { get; set; } = 20;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public int TextOffsetY { get; set; } = 16;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public PathfindingReplayMode ReplayMode { get; set; } = PathfindingReplayMode.PathfindingReplayMode_Disabled;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public bool DrawPolygonOutline { get; set; } = true;
	
	[ContainerField(0x29), LayoutImmutable, Blittable, JsonProperty(Order = 41)]
	public bool DrawFilledPolygons { get; set; } = true;
	
	[ContainerField(0x2a), LayoutImmutable, Blittable, JsonProperty(Order = 42)]
	public bool DrawConnections { get; set; } = false;
	
	[ContainerField(0x2b), LayoutImmutable, Blittable, JsonProperty(Order = 43)]
	public bool DrawObstacles { get; set; } = true;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public bool DrawMoverCylinders { get; set; } = true;
	
	[ContainerField(0x2d), LayoutImmutable, Blittable, JsonProperty(Order = 45)]
	public bool DrawMoverGoals { get; set; } = true;
	
	[ContainerField(0x2e), LayoutImmutable, Blittable, JsonProperty(Order = 46)]
	public bool DrawMoverGoalsReached { get; set; } = true;
	
	[ContainerField(0x2f), LayoutImmutable, Blittable, JsonProperty(Order = 47)]
	public bool DrawMoverState { get; set; } = true;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public bool DrawMoverAttractions { get; set; } = true;
	
	[ContainerField(0x31), LayoutImmutable, Blittable, JsonProperty(Order = 49)]
	public bool DrawRepulsors { get; set; } = true;
	
	[ContainerField(0x32), LayoutImmutable, Blittable, JsonProperty(Order = 50)]
	public bool DrawClientMotion { get; set; } = true;
	
	[ContainerField(0x33), LayoutImmutable, Blittable, JsonProperty(Order = 51)]
	public bool DrawCurPathSection { get; set; } = true;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public bool DepthTest { get; set; } = true;
	
	[ContainerField(0x35), LayoutImmutable, Blittable, JsonProperty(Order = 53)]
	public bool DrawStats { get; set; } = false;
	
	[ContainerField(0x36), LayoutImmutable, Blittable, JsonProperty(Order = 54)]
	public bool DrawMemory { get; set; } = false;
	
	[ContainerField(0x37), LayoutImmutable, Blittable, JsonProperty(Order = 55)]
	public bool DrawTimings { get; set; } = false;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public bool OriginalPaths { get; set; } = false;
	
	[ContainerField(0x39), LayoutImmutable, Blittable, JsonProperty(Order = 57)]
	public bool RandomPositions { get; set; } = false;
	
	[ContainerField(0x3a), LayoutImmutable, Blittable, JsonProperty(Order = 58)]
	public bool PotentialObstacles { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(TypesToDrawMask);
		p_Writer.Write(DrawDistance);
		p_Writer.Write(TextStartX);
		p_Writer.Write(TextStartY);
		p_Writer.Write(TextOffsetY);
		p_Writer.Write((int) ReplayMode);
		p_Writer.Write(DrawPolygonOutline);
		p_Writer.Write(DrawFilledPolygons);
		p_Writer.Write(DrawConnections);
		p_Writer.Write(DrawObstacles);
		p_Writer.Write(DrawMoverCylinders);
		p_Writer.Write(DrawMoverGoals);
		p_Writer.Write(DrawMoverGoalsReached);
		p_Writer.Write(DrawMoverState);
		p_Writer.Write(DrawMoverAttractions);
		p_Writer.Write(DrawRepulsors);
		p_Writer.Write(DrawClientMotion);
		p_Writer.Write(DrawCurPathSection);
		p_Writer.Write(DepthTest);
		p_Writer.Write(DrawStats);
		p_Writer.Write(DrawMemory);
		p_Writer.Write(DrawTimings);
		p_Writer.Write(OriginalPaths);
		p_Writer.Write(RandomPositions);
		p_Writer.Write(PotentialObstacles);
		p_Writer.WriteNullBytes(5);
	}
}

