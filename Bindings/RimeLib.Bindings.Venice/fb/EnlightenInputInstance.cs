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
	[ContainerType(16, 80)]
	public class EnlightenInputInstance
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		public LinearTransform Transform { get; set; } = new();
		
		[ContainerField(64), LayoutImmutable, JsonProperty(Order = 64)]
		public string Asset { get; set; } = string.Empty;
		
		[ContainerField(68), LayoutImmutable, JsonProperty(Order = 68)]
		public string ObjectVariation { get; set; } = string.Empty;
		
		[ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		public int SystemId { get; set; }
		
	}
}
