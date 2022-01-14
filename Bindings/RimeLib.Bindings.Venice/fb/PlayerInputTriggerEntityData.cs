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
	public class PlayerInputTriggerEntityData : 
		EntityData
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public Realm Realm { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public EntryInputActionEnum EntryInputActions { get; set; } = new();

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public float ValueModifier { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public float TrailingValueAtStart { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public float AccumulatedValueAtStart { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public bool SendTriggerEvents { get; set; }

		[ContainerField(33), LayoutImmutable, Blittable, JsonProperty(Order = 33)]
		public bool EnabledFromStart { get; set; }

	}
}
