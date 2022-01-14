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
	[ContainerType(16, 96)]
	public class CoverEntityData : 
		SpatialEntityData
	{
		[ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		public float Width { get; set; }

		[ContainerField(84), JsonProperty(Order = 84)]
		public CoverType CoverType { get; set; } = new();

		[ContainerField(88), JsonProperty(Order = 88)]
		public List<CoverSlot> Slots { get; set; } = new();

		[ContainerField(92), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
		public bool RightEdgeBlocked { get; set; }

		[ContainerField(93), LayoutImmutable, Blittable, JsonProperty(Order = 93)]
		public bool TopBlocked { get; set; }

		[ContainerField(94), LayoutImmutable, Blittable, JsonProperty(Order = 94)]
		public bool LeftEdgeBlocked { get; set; }

	}
}
