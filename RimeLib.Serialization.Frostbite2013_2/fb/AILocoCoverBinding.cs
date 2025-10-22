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

using fb.Ant;

namespace fb.VeniceShared;

[ContainerType(4, 520)]
public class AILocoCoverBinding
	: EbxSerializable
{
	[ContainerField(0x0), JsonProperty(Order = 0)]
	public AntRef PrepareFire { get; set; } = new();
	
	[ContainerField(0x14), JsonProperty(Order = 20)]
	public AntRef PrepareChangedToTrue { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public AntRef ThrowGrenade { get; set; } = new();
	
	[ContainerField(0x3c), JsonProperty(Order = 60)]
	public AntRef PeekOut { get; set; } = new();
	
	[ContainerField(0x50), JsonProperty(Order = 80)]
	public AntRef IdleBehindCover { get; set; } = new();
	
	[ContainerField(0x64), JsonProperty(Order = 100)]
	public AntRef PeekType { get; set; } = new();
	
	[ContainerField(0x78), JsonProperty(Order = 120)]
	public AntRef IdleTypePrevious { get; set; } = new();
	
	[ContainerField(0x8c), JsonProperty(Order = 140)]
	public AntRef IdleType { get; set; } = new();
	
	[ContainerField(0xa0), JsonProperty(Order = 160)]
	public AntRef IdleTypeChanged { get; set; } = new();
	
	[ContainerField(0xb4), JsonProperty(Order = 180)]
	public AntRef CoverTypeEnum { get; set; } = new();
	
	[ContainerField(0xc8), JsonProperty(Order = 200)]
	public AntRef CoverFireStyle { get; set; } = new();
	
	[ContainerField(0xdc), JsonProperty(Order = 220)]
	public AntRef EnterCover { get; set; } = new();
	
	[ContainerField(0xf0), JsonProperty(Order = 240)]
	public AntRef ExitCover { get; set; } = new();
	
	[ContainerField(0x104), JsonProperty(Order = 260)]
	public AntRef CoverDistanceSmall { get; set; } = new();
	
	[ContainerField(0x118), JsonProperty(Order = 280)]
	public AntRef CoverDistanceMedium { get; set; } = new();
	
	[ContainerField(0x12c), JsonProperty(Order = 300)]
	public AntRef DistanceScale { get; set; } = new();
	
	[ContainerField(0x140), JsonProperty(Order = 320)]
	public AntRef AbsoluteDistance { get; set; } = new();
	
	[ContainerField(0x154), JsonProperty(Order = 340)]
	public AntRef AngleToNormal { get; set; } = new();
	
	[ContainerField(0x168), JsonProperty(Order = 360)]
	public AntRef DirectionToCoverVsAITrajectory { get; set; } = new();
	
	[ContainerField(0x17c), JsonProperty(Order = 380)]
	public AntRef CoverNormalVsAITrajectory { get; set; } = new();
	
	[ContainerField(0x190), JsonProperty(Order = 400)]
	public AntRef OutAngle { get; set; } = new();
	
	[ContainerField(0x1a4), JsonProperty(Order = 420)]
	public AntRef ExitCoverDistance { get; set; } = new();
	
	[ContainerField(0x1b8), JsonProperty(Order = 440)]
	public AntRef ThreatAngle { get; set; } = new();
	
	[ContainerField(0x1cc), JsonProperty(Order = 460)]
	public AntRef StopExitCoverOutAround { get; set; } = new();
	
	[ContainerField(0x1e0), JsonProperty(Order = 480)]
	public AntRef EnterStrategy { get; set; } = new();
	
	[ContainerField(0x1f4), JsonProperty(Order = 500)]
	public AntRef ExitStyle { get; set; } = new();
	
}

