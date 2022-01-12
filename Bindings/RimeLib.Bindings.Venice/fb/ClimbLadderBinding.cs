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
	[ContainerType(4, 24)]
	public class ClimbLadderBinding
	{
		[ContainerField(0)]
		public AntRef ClimbLadderPhase { get; set; } = new();
		
		[ContainerField(4)]
		public AntRef ClimbLadderConnectPhase { get; set; } = new();
		
		[ContainerField(8)]
		public AntRef ClimbLadderTransitionPhase { get; set; } = new();
		
		[ContainerField(12)]
		public AntRef OnLadder { get; set; } = new();
		
		[ContainerField(16)]
		public AntRef LadderTopTransition { get; set; } = new();
		
		[ContainerField(20)]
		public AntRef FallHigh { get; set; } = new();
		
	}
}
