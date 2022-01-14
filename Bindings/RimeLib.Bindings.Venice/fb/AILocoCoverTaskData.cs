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

namespace fb
{
	[ContainerType(16, 96)]
	public class AILocoCoverTaskData
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		public Vec3 WantedPos { get; set; } = new();
		
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public Vec3 ThreatPosition { get; set; } = new();
		
		[ContainerField(32), JsonProperty(Order = 32)]
		public AntPoseEnum CoverPose { get; set; } = new();
		
		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public float WaitTime { get; set; }
		
		[ContainerField(40), JsonProperty(Order = 40)]
		public CoverPeekType PeekOut { get; set; } = new();
		
		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public float WorldAngle { get; set; }
		
		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public float OffsetLength { get; set; }
		
		[ContainerField(52), JsonProperty(Order = 52)]
		public AntPoseEnum ExitPose { get; set; } = new();
		
		[ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		public float ExitAngle { get; set; }
		
		[ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		public float DistanceToNextWaypoint { get; set; }
		
		[ContainerField(64), JsonProperty(Order = 64)]
		public AntCoverEnum CoverType { get; set; } = new();
		
		[ContainerField(68), JsonProperty(Order = 68)]
		public CoverEnterStrategy EnterStrategy { get; set; } = new();
		
		[ContainerField(72), JsonProperty(Order = 72)]
		public CoverExitStyle ExitStyle { get; set; } = new();
		
		[ContainerField(76), JsonProperty(Order = 76)]
		public CoverFireType PrepareFireType { get; set; } = new();
		
		[ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		public bool ForceExitCover { get; set; }
		
		[ContainerField(81), LayoutImmutable, Blittable, JsonProperty(Order = 81)]
		public bool UseClientPosition { get; set; }
		
	}
}
