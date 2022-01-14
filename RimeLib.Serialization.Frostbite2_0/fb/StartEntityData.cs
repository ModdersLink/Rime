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
	[ContainerType(4, 24)]
	public class StartEntityData : 
		EntityData
	{
		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public float SortIndex { get; set; }

		[ContainerField(16), LayoutImmutable, JsonProperty(Order = 16)]
		public string StartName { get; set; } = string.Empty;

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public bool IsDefault { get; set; }

	}
}
