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
	public class ShaderParameterVector
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		public Vec4 Value { get; set; } = new();
		
		[ContainerField(16), LayoutImmutable, JsonProperty(Order = 16)]
		public string ParameterName { get; set; } = string.Empty;
		
	}
}
