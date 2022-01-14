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
	public class AIAimingConstraintsData : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public float MinYaw { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public float MaxYaw { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public float MinPitch { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public float MaxPitch { get; set; }

	}
}
