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
	public class HitReactionComponentBinding
	{
		[ContainerField(0)]
		public AntRef Hit { get; set; } = new();
		
		[ContainerField(4)]
		public AntRef AllowKillFromAnimation { get; set; } = new();
		
		[ContainerField(8)]
		public AntRef Direction { get; set; } = new();
		
		[ContainerField(12)]
		public AntRef FiringDistance { get; set; } = new();
		
		[ContainerField(16)]
		public AntRef BoneType { get; set; } = new();
		
		[ContainerField(20)]
		public AntRef ImpactType { get; set; } = new();
		
		[ContainerField(24)]
		public AntRef Immortal { get; set; } = new();
		
		[ContainerField(28)]
		public AntRef RandomAnimationIndex { get; set; } = new();
		
	}
}
