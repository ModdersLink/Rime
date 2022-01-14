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
	[ContainerType(16, 48)]
	public class BotPriorityConfigData : 
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public Vec3 DebugColor { get; set; } = new();

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public float Distance { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public int Period { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public float AngleOffset { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public bool AppliesToExecution { get; set; }

		[ContainerField(45), LayoutImmutable, Blittable, JsonProperty(Order = 45)]
		public bool AppliesToDecisions { get; set; }

	}
}
