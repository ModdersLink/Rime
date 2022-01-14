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
	[ContainerType(4, 28)]
	public class CharacterMeleeCommonBinding
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public AntRef MeleeDistance { get; set; } = new();
		
		[ContainerField(4), JsonProperty(Order = 4)]
		public AntRef MeleeAngle { get; set; } = new();
		
		[ContainerField(8), JsonProperty(Order = 8)]
		public AntRef MeleeDefenceTime { get; set; } = new();
		
		[ContainerField(12), JsonProperty(Order = 12)]
		public AntRef MeleeSequenceTime { get; set; } = new();
		
		[ContainerField(16), JsonProperty(Order = 16)]
		public AntRef MeleeAborted { get; set; } = new();
		
		[ContainerField(20), JsonProperty(Order = 20)]
		public AntRef CloseToTarget { get; set; } = new();
		
		[ContainerField(24), JsonProperty(Order = 24)]
		public AntRef MeleeType { get; set; } = new();
		
	}
}
