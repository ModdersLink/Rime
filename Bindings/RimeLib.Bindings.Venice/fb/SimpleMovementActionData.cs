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
	public class SimpleMovementActionData : 
		SimpleMovementActionBaseData
	{
		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public float Level { get; set; }

		[ContainerField(28), JsonProperty(Order = 28)]
		public EntryInputActionEnum Action { get; set; } = new();

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public int SpecialAnimationIndex { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public bool Respawn { get; set; }

		[ContainerField(37), LayoutImmutable, Blittable, JsonProperty(Order = 37)]
		public bool Teleport { get; set; }

	}
}
