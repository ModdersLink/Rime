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

namespace fb.VeniceShared;

[ContainerType(4, 32)]
public class AILocoBaseTaskData
	: EbxSerializable
{
	[ContainerField(0x0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
	public AntPoseEnum PoseChangeMovingTowards { get; set; } = AntPoseEnum.AntPoseEnum_NoChange;
	
	[ContainerField(0x4), LayoutImmutable, Blittable, JsonProperty(Order = 4)]
	public AntAttentionStateEnum AttentionChangeMovingTowards { get; set; } = AntAttentionStateEnum.AntAttentionStateEnum_NoChange;
	
	[ContainerField(0x8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
	public AntSpeedLevel SpeedChangeMovingTowards { get; set; } = AntSpeedLevel.AntSpeedLevel_NoChange;
	
	[ContainerField(0xc), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
	public AntPoseEnum PoseChange { get; set; } = AntPoseEnum.AntPoseEnum_NoChange;
	
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public AntAttentionStateEnum AttentionStateChange { get; set; } = AntAttentionStateEnum.AntAttentionStateEnum_NoChange;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public AntSpeedLevel SpeedLevelChange { get; set; } = AntSpeedLevel.AntSpeedLevel_NoChange;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public float Radius { get; set; } = 1.000f;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public bool IsScripted { get; set; } = false;
	
}

