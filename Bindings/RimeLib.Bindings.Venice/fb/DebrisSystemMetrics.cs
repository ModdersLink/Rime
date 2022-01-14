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
	[ContainerType(4, 8)]
	public class DebrisSystemMetrics
	{
		[ContainerField(0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		public int HavokParticleCount { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable, JsonProperty(Order = 4)]
		public int HavokParticlePartCount { get; set; }
		
	}
}
