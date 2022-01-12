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
	[ContainerType(4, 36)]
	public class ConditionGroup : 
		AudioGraphNodePortGroup
	{
		[ContainerField(8)]
		public AudioGraphNodePort X { get; set; } = new();

		[ContainerField(16)]
		public AudioGraphNodePort Y { get; set; } = new();

		[ContainerField(24)]
		public AudioGraphNodePort True { get; set; } = new();

		[ContainerField(32)]
		public ConditionType Condition { get; set; } = new();

	}
}
