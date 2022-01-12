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
	[ContainerType(4, 16)]
	public class LevelDescription
	{
		[ContainerField(0), LayoutImmutable]
		public string Name { get; set; } = string.Empty;
		
		[ContainerField(4), LayoutImmutable]
		public string Description { get; set; } = string.Empty;
		
		[ContainerField(8)]
		public RefArray<LevelDescriptionComponent> Components { get; set; } = new();
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public bool IsCoop { get; set; }
		
		[ContainerField(13), LayoutImmutable, Blittable]
		public bool IsMenu { get; set; }
		
		[ContainerField(14), LayoutImmutable, Blittable]
		public bool IsMultiplayer { get; set; }
		
	}
}
