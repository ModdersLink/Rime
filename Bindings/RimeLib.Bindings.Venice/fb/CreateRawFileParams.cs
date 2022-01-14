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
	[ContainerType(4, 20)]
	public class CreateRawFileParams : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, JsonProperty(Order = 8)]
		public string AssetName { get; set; } = string.Empty;

		[ContainerField(12), LayoutImmutable, JsonProperty(Order = 12)]
		public string SourceFile { get; set; } = string.Empty;

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public bool CreateResource { get; set; }

	}
}
