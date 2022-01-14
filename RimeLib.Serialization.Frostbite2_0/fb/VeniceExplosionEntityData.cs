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
	[ContainerType(16, 192)]
	public class VeniceExplosionEntityData : 
		ExplosionEntityData
	{
		[ContainerField(176), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		public float UnspottableTime { get; set; }

		[ContainerField(180), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
		public bool UnspotsOnExplode { get; set; }

		[ContainerField(181), LayoutImmutable, Blittable, JsonProperty(Order = 181)]
		public bool SpotsOnExplode { get; set; }

		[ContainerField(182), LayoutImmutable, Blittable, JsonProperty(Order = 182)]
		public bool IsCausingSuppression { get; set; }

	}
}
