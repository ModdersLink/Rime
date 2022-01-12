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
	[ContainerType(4, 48)]
	public class SpecialMovesBinding
	{
		[ContainerField(0)]
		public AntRef TriggerHighVault { get; set; } = new();
		
		[ContainerField(4)]
		public AntRef TriggerUpVault { get; set; } = new();
		
		[ContainerField(8)]
		public AntRef TriggerLowVault { get; set; } = new();
		
		[ContainerField(12)]
		public AntRef TriggerSlideIntoProne { get; set; } = new();
		
		[ContainerField(16)]
		public AntRef TriggerSpecialAnimation { get; set; } = new();
		
		[ContainerField(20)]
		public AntRef SpecialAnimationIndex { get; set; } = new();
		
		[ContainerField(24)]
		public AntRef ObjectHeight { get; set; } = new();
		
		[ContainerField(28)]
		public AntRef ObjectDistance { get; set; } = new();
		
		[ContainerField(32)]
		public AntRef StartObjectDistanceTimer { get; set; } = new();
		
		[ContainerField(36)]
		public AntRef VaultObjectPositionX { get; set; } = new();
		
		[ContainerField(40)]
		public AntRef VaultObjectPositionZ { get; set; } = new();
		
		[ContainerField(44)]
		public AntRef CancelAnimation { get; set; } = new();
		
	}
}
