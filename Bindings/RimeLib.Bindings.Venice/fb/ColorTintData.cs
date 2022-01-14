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
	[ContainerType(16, 64)]
	public class ColorTintData
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		public Vec3 Contrast { get; set; } = new();
		
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public Vec3 Brightness { get; set; } = new();
		
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public Vec3 Saturation { get; set; } = new();
		
		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public float Hue { get; set; }
		
	}
}
