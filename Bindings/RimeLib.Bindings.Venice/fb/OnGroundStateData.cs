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
	public class OnGroundStateData : 
		CharacterStateData
	{
		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public float JumpDelay { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public float JumpStaminaPenalty { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public float AllowedDistanceFromGround { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public bool GroundHugging { get; set; }

		[ContainerField(25), LayoutImmutable, Blittable, JsonProperty(Order = 25)]
		public bool LimitDownwardVelocity { get; set; }

	}
}
