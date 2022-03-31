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
	[ContainerType(16, 240)]
	public class AILocoComponentData : 
		ComponentData
	{
		[ContainerField(96), JsonProperty(Order = 96)]
		public AILocoBinding Binding { get; set; } = new();

		[ContainerField(132), JsonProperty(Order = 132)]
		public AILocoVaultBinding VaultBinding { get; set; } = new();

		[ContainerField(160), JsonProperty(Order = 160)]
		public AILocoCoverBinding CoverBinding { get; set; } = new();

		[ContainerField(232), LayoutImmutable, Blittable, JsonProperty(Order = 232)]
		public float WantedYaw { get; set; }

		[ContainerField(236), LayoutImmutable, Blittable, JsonProperty(Order = 236)]
		public int AnimationEntitySpacePriority { get; set; }

	}
}
