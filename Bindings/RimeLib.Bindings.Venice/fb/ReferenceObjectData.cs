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
	public class ReferenceObjectData : 
		GameObjectData
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public LinearTransform BlueprintTransform { get; set; } = new();

		[ContainerField(80), JsonProperty(Order = 80)]
		public CtrRef<Blueprint> Blueprint { get; set; } = new();

		[ContainerField(84), JsonProperty(Order = 84)]
		public CtrRef<ObjectVariation> ObjectVariation { get; set; } = new();

		[ContainerField(88), JsonProperty(Order = 88)]
		public StreamRealm StreamRealm { get; set; } = new();

		[ContainerField(92), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
		public bool CastSunShadowEnable { get; set; }

		[ContainerField(93), LayoutImmutable, Blittable, JsonProperty(Order = 93)]
		public bool Excluded { get; set; }

	}
}
