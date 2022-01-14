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
	[ContainerType(4, 36)]
	public class GeographicalData : 
		DataContainer
	{
		[ContainerField(8), JsonProperty(Order = 8)]
		public UIGeoLatitude Latitude { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public UIGeoLongitude Longitude { get; set; } = new();

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public float SeaLevelOffset { get; set; }

	}
}
