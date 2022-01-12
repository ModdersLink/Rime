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
	[ContainerType(4, 12)]
	public class LicenseInfo
	{
		[ContainerField(0), LayoutImmutable]
		public string Name { get; set; } = string.Empty;
		
		[ContainerField(4)]
		public GamePlatform StagingPlatform { get; set; } = new();
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public bool AllowStaging { get; set; }
		
		[ContainerField(9), LayoutImmutable, Blittable]
		public bool ClientOnly { get; set; }
		
	}
}
