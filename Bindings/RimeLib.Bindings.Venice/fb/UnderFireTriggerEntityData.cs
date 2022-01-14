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
	[ContainerType(16, 144)]
	public class UnderFireTriggerEntityData : 
		TriggerEntityData
	{
		[ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		public float Radius { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		public float CoolDownTime { get; set; }

		[ContainerField(120), JsonProperty(Order = 120)]
		public CtrRef<MaterialContainerPair> TriggerOnMaterialOnly { get; set; } = new();

		[ContainerField(124), JsonProperty(Order = 124)]
		public AreaTriggerInclude TriggeredBy { get; set; } = new();

		[ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		public bool DisableIfTrackEntityIsLost { get; set; }

		[ContainerField(129), LayoutImmutable, Blittable, JsonProperty(Order = 129)]
		public bool RandomYaw { get; set; }

		[ContainerField(130), LayoutImmutable, Blittable, JsonProperty(Order = 130)]
		public bool IndicateHit { get; set; }

	}
}
