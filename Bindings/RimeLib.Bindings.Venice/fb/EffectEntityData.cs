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
	[ContainerType(16, 112)]
	public class EffectEntityData : 
		SpatialEntityData
	{
		[ContainerField(80), JsonProperty(Order = 80)]
		public RefArray<GameObjectData> Components { get; set; } = new();

		[ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		public uint MaxInstanceCount { get; set; }

		[ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		public float CullDistance { get; set; }

		[ContainerField(92), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
		public float StartDelay { get; set; }

		[ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public bool HighEndPc { get; set; }

		[ContainerField(97), LayoutImmutable, Blittable, JsonProperty(Order = 97)]
		public bool MediumPc { get; set; }

		[ContainerField(98), LayoutImmutable, Blittable, JsonProperty(Order = 98)]
		public bool LowEndPc { get; set; }

		[ContainerField(99), LayoutImmutable, Blittable, JsonProperty(Order = 99)]
		public bool ResetInstanceWhenStarted { get; set; }

	}
}
