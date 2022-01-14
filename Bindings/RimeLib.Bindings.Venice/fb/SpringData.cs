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
	public class SpringData
	{
		[ContainerField(0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		public float Length { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable, JsonProperty(Order = 4)]
		public float Stiffness { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public float Damping { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public float MaxSpringForce { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public float ProgressiveStartRatio { get; set; }
		
		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public float ProgressiveExponent { get; set; }
		
		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public float VisualClipOffset { get; set; }
		
		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public float AttachOffsetY { get; set; }
		
		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public float DisabledStrenghModifier { get; set; }
		
	}
}
