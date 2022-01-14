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
	public class SoundTestTransformTask : 
		SoundTestTaskSpec
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public Vec3 InitialPosition { get; set; } = new();

		[ContainerField(32), JsonProperty(Order = 32)]
		public SoundTestTransformBehavior Behavior { get; set; } = new();

		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public bool RelativeListener { get; set; }

	}
}
