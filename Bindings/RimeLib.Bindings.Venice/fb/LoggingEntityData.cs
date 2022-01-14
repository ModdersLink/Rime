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
	[ContainerType(16, 144)]
	public class LoggingEntityData : 
		EntityData
	{
		[ContainerField(12), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public Vec2 Vec2Value { get; set; } = new();

		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public Vec3 Vec3Value { get; set; } = new();

		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public LinearTransform TransformValue { get; set; } = new();

		[ContainerField(112), JsonProperty(Order = 112)]
		public Realm Realm { get; set; } = new();

		[ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		public float FloatValue { get; set; }

		[ContainerField(120), JsonProperty(Order = 120)]
		public List<string> Strings { get; set; } = new();

		[ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		public int IntValue { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		public bool BoolValue { get; set; }

	}
}
