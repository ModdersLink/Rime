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
	[ContainerType(4, 28)]
	public class GameModeSize
	{
		[ContainerField(0), LayoutImmutable]
		public string Name { get; set; } = string.Empty;
		
		[ContainerField(4), LayoutImmutable]
		public string ShortName { get; set; } = string.Empty;
		
		[ContainerField(8), LayoutImmutable]
		public string MetaIdentifier { get; set; } = string.Empty;
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public uint PlayerCount { get; set; }
		
		[ContainerField(16)]
		public List<GameModeTeamSize> Teams { get; set; } = new();
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public uint RoundsPerMap { get; set; }
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public bool ForceSquad { get; set; }
		
	}
}
