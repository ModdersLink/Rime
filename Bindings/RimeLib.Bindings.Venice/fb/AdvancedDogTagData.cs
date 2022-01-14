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
	[ContainerType(4, 80)]
	public class AdvancedDogTagData : 
		DogTagData
	{
		[ContainerField(68), LayoutImmutable, JsonProperty(Order = 68)]
		public string StatCode { get; set; } = string.Empty;

		[ContainerField(72), LayoutImmutable, JsonProperty(Order = 72)]
		public string StatSID { get; set; } = string.Empty;

		[ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		public bool IsStatMeasuredInTime { get; set; }

	}
}
