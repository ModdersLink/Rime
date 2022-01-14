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
	[ContainerType(4, 28)]
	public class FadeEntityData : 
		EntityData
	{
		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public float FadeTime { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public float MaxWaitFadedWhileStreamingTime { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public bool FadeScreen { get; set; }

		[ContainerField(21), LayoutImmutable, Blittable, JsonProperty(Order = 21)]
		public bool FadeUI { get; set; }

		[ContainerField(22), LayoutImmutable, Blittable, JsonProperty(Order = 22)]
		public bool FadeRumble { get; set; }

		[ContainerField(23), LayoutImmutable, Blittable, JsonProperty(Order = 23)]
		public bool FadeAudio { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public bool FadeMovie { get; set; }

		[ContainerField(25), LayoutImmutable, Blittable, JsonProperty(Order = 25)]
		public bool StartFaded { get; set; }

	}
}
