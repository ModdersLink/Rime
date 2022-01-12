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
	public class MatchmakingSizeConfiguration
	{
		[ContainerField(0)]
		public MatchmakingPlatform Platform { get; set; } = new();
		
		[ContainerField(4)]
		public List<string> Settings { get; set; } = new();
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public uint DesiredPlayerCount { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public uint MinPlayerCount { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public uint MaxPlayerCapacity { get; set; }
		
		[ContainerField(20), LayoutImmutable]
		public string MinFitThreshold { get; set; } = string.Empty;
		
	}
}
