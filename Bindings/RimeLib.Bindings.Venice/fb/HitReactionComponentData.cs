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
	[ContainerType(16, 144)]
	public class HitReactionComponentData : 
		ComponentData
	{
		[ContainerField(96), JsonProperty(Order = 96)]
		public HitReactionComponentBinding HitReactionBinding { get; set; } = new();

		[ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		public bool Enabled { get; set; }

	}
}
