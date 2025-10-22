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

[ContainerType(16, 96)]
public class AILocoCoverTaskData
	: EbxSerializable
{
	[ContainerField(0x0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 0)]
	public Vec3 WantedPos { get; set; } = new()
	{
		z = -44444.000f,
		y = -44444.000f,
		x = -44444.000f,
	};
	
	[ContainerField(0x10), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public Vec3 ThreatPosition { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public AntCoverEnum CoverType { get; set; } = AntCoverEnum.AntCoverEnum_RightCover;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public AntPoseEnum CoverPose { get; set; } = AntPoseEnum.AntPoseEnum_Stand;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public float WaitTime { get; set; } = -1.000f;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public float WorldAngle { get; set; } = 0.000f;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public CoverPeekType PeekOut { get; set; } = CoverPeekType.CoverPeekType_None;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public CoverIdleType IdleBehavior { get; set; } = CoverIdleType.CoverIdleType_Calm;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public AntPoseEnum ExitPose { get; set; } = AntPoseEnum.AntPoseEnum_NoChange;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public float OffsetLength { get; set; } = 2.000f;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public CoverEnterStrategy EnterStrategy { get; set; } = CoverEnterStrategy.CoverEnterStrategy_EnterNormally;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public float ExitAngle { get; set; } = -44.000f;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public float DistanceToNextWaypoint { get; set; } = 0.000f;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public float AlignOffsetAlong { get; set; } = 0.500f;
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public float AlignOffsetPerpendicular { get; set; } = 0.300f;
	
	[ContainerField(0x54), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
	public CoverExitStyle ExitStyle { get; set; } = CoverExitStyle.CoverExitStyle_ExitCover;
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public CoverFireType PrepareFireType { get; set; } = CoverFireType.CoverFireType_NoFire;
	
	[ContainerField(0x5c), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
	public bool ForceExitCover { get; set; } = false;
	
	[ContainerField(0x5d), LayoutImmutable, Blittable, JsonProperty(Order = 93)]
	public bool UseClientPosition { get; set; } = false;
	
}

