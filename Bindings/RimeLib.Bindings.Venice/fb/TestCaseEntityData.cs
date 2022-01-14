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
	public class TestCaseEntityData : 
		EntityData
	{
		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public float TimeOut { get; set; }

		[ContainerField(16), LayoutImmutable, JsonProperty(Order = 16)]
		public string TestGroup { get; set; } = string.Empty;

		[ContainerField(20), LayoutImmutable, JsonProperty(Order = 20)]
		public string TestCaseName { get; set; } = string.Empty;

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public bool Stable { get; set; }

		[ContainerField(25), LayoutImmutable, Blittable, JsonProperty(Order = 25)]
		public bool Enabled { get; set; }

	}
}
