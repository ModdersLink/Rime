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
	[ContainerType(1, 3)]
	public class SoundGraphPluginRef
	{
		[ContainerField(0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		public bool IsValid { get; set; }
		
		[ContainerField(1), LayoutImmutable, Blittable, JsonProperty(Order = 1)]
		public sbyte VoiceIndex { get; set; }
		
		[ContainerField(2), LayoutImmutable, Blittable, JsonProperty(Order = 2)]
		public sbyte PluginIndex { get; set; }
		
	}
}
