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
	public class LevelSetup
	{
		[ContainerField(0), LayoutImmutable]
		public string Name { get; set; } = string.Empty;
		
		[ContainerField(4)]
		public List<LevelSetupOption> InclusionOptions { get; set; } = new();
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public uint DifficultyIndex { get; set; }
		
		[ContainerField(12)]
		public List<string> SubLevelNames { get; set; } = new();
		
		[ContainerField(16)]
		public List<int> SubLevelStates { get; set; } = new();
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public bool IsSaveGame { get; set; }
		
		[ContainerField(21), LayoutImmutable, Blittable]
		public bool ForceReloadResources { get; set; }
		
	}
}
