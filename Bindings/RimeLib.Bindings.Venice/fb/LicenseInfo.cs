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
	[ContainerType(4, 12)]
	public class LicenseInfo
	{
		[ContainerField(0), LayoutImmutable, JsonProperty(Order = 0)]
		public string Name { get; set; } = string.Empty;
		
		[ContainerField(4), JsonProperty(Order = 4)]
		public GamePlatform StagingPlatform { get; set; } = new();
		
		[ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public bool AllowStaging { get; set; }
		
		[ContainerField(9), LayoutImmutable, Blittable, JsonProperty(Order = 9)]
		public bool ClientOnly { get; set; }
		
	}
}
