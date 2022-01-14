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
	[ContainerType(4, 24)]
	public class MaterialRelationEffectData : 
		PhysicsMaterialRelationPropertyData
	{
		[ContainerField(8), JsonProperty(Order = 8)]
		public RefArray<EffectBlueprint> ImpactEffects { get; set; } = new();

		[ContainerField(12), JsonProperty(Order = 12)]
		public RefArray<ObjectBlueprint> ImpactDebris { get; set; } = new();

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public float ImpactEffectMaxSpreadAngle { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public bool MirrorImpactDirection { get; set; }

	}
}
