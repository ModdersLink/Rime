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
	[ContainerType(16, 112)]
	public class SensingComponentData : 
		ComponentData
	{
		[ContainerField(96), JsonProperty(Order = 96)]
		public CtrRef<SensingTemplateData> Template { get; set; } = new();

		[ContainerField(100), JsonProperty(Order = 100)]
		public CtrRef<SensingSettings> Settings { get; set; } = new();

		[ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		public bool Enabled { get; set; }

		[ContainerField(105), LayoutImmutable, Blittable, JsonProperty(Order = 105)]
		public bool SharedPlayerMemory { get; set; }

		[ContainerField(106), LayoutImmutable, Blittable, JsonProperty(Order = 106)]
		public bool UseWeaponTransform { get; set; }

	}
}
