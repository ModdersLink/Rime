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
	[ContainerType(4, 32)]
	public class UIGraphEntityData : 
		EntityData
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public List<EventSpec> Events { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public CtrRef<UIGraphAsset> GraphAsset { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public UIGraphPriority GraphPriority { get; set; } = new();

		[ContainerField(24), JsonProperty(Order = 24)]
		public UIState State { get; set; } = new();

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public bool PopPreviousGraph { get; set; }

	}
}
