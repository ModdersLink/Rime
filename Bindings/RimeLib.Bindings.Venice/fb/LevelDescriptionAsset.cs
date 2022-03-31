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
	[ContainerType(4, 40)]
	public class LevelDescriptionAsset : 
		Asset
	{
		[ContainerField(12), LayoutImmutable, JsonProperty(Order = 12)]
		public string LevelName { get; set; } = string.Empty;

		[ContainerField(16), JsonProperty(Order = 16)]
		public List<LevelDescriptionInclusionCategory> Categories { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public LevelDescription Description { get; set; } = new();

		[ContainerField(36), JsonProperty(Order = 36)]
		public List<string> StartPoints { get; set; } = new();

	}
}
