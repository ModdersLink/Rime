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
	[ContainerType(4, 32)]
	public class AILocoBaseTaskData
	{
		[ContainerField(0)]
		public AntPoseEnum PoseChangeMovingTowards { get; set; } = new();
		
		[ContainerField(4)]
		public AntAttentionStateEnum AttentionChangeMovingTowards { get; set; } = new();
		
		[ContainerField(8)]
		public AntSpeedLevel SpeedChangeMovingTowards { get; set; } = new();
		
		[ContainerField(12)]
		public AntPoseEnum PoseChange { get; set; } = new();
		
		[ContainerField(16)]
		public AntAttentionStateEnum AttentionStateChange { get; set; } = new();
		
		[ContainerField(20)]
		public AntSpeedLevel SpeedLevelChange { get; set; } = new();
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float Radius { get; set; }
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public bool IsScripted { get; set; }
		
	}
}
