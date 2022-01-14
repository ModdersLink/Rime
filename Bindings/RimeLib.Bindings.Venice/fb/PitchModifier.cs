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
	[ContainerType(16, 32)]
	public class PitchModifier
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		public Vec3 Offset { get; set; } = new();
		
		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public float PitchVal { get; set; }
		
		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public float PitchAngle { get; set; }
		
	}
}
