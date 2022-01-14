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
	[ContainerType(16, 256)]
	public class MultipleActorScenarioEntityData : 
		SpatialEntityData
	{
		[ContainerField(80), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		public LinearTransform WorldSpaceConnectTransform { get; set; } = new();

		[ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		public int Actor5Part { get; set; }

		[ContainerField(148), JsonProperty(Order = 148)]
		public AntRef ScenarioAntRef { get; set; } = new();

		[ContainerField(152), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		public int LevelChoice { get; set; }

		[ContainerField(156), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
		public int ScenarioChoice { get; set; }

		[ContainerField(160), JsonProperty(Order = 160)]
		public Realm Realm { get; set; } = new();

		[ContainerField(164), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
		public int Actor6Part { get; set; }

		[ContainerField(168), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
		public int Actor1 { get; set; }

		[ContainerField(172), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
		public int Actor1Part { get; set; }

		[ContainerField(176), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		public int Actor1SecondPart { get; set; }

		[ContainerField(180), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
		public int Actor2 { get; set; }

		[ContainerField(184), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
		public int Actor2Part { get; set; }

		[ContainerField(188), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
		public int Actor2SecondPart { get; set; }

		[ContainerField(192), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
		public int Actor3 { get; set; }

		[ContainerField(196), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
		public int Actor3Part { get; set; }

		[ContainerField(200), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
		public int Actor3SecondPart { get; set; }

		[ContainerField(204), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
		public int Actor4 { get; set; }

		[ContainerField(208), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
		public int Actor4Part { get; set; }

		[ContainerField(212), LayoutImmutable, Blittable, JsonProperty(Order = 212)]
		public int Actor4SecondPart { get; set; }

		[ContainerField(216), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
		public int Actor5 { get; set; }

		[ContainerField(220), LayoutImmutable, Blittable, JsonProperty(Order = 220)]
		public int Actor5SecondPart { get; set; }

		[ContainerField(224), LayoutImmutable, Blittable, JsonProperty(Order = 224)]
		public int Actor6SecondPart { get; set; }

		[ContainerField(228), LayoutImmutable, Blittable, JsonProperty(Order = 228)]
		public int Actor6 { get; set; }

		[ContainerField(232), LayoutImmutable, Blittable, JsonProperty(Order = 232)]
		public float ExternalTime { get; set; }

		[ContainerField(236), LayoutImmutable, Blittable, JsonProperty(Order = 236)]
		public bool AligningEnabled { get; set; }

		[ContainerField(237), LayoutImmutable, Blittable, JsonProperty(Order = 237)]
		public bool ScenarioActive { get; set; }

		[ContainerField(238), LayoutImmutable, Blittable, JsonProperty(Order = 238)]
		public bool Actor1Prepared { get; set; }

		[ContainerField(239), LayoutImmutable, Blittable, JsonProperty(Order = 239)]
		public bool Actor2Prepared { get; set; }

		[ContainerField(240), LayoutImmutable, Blittable, JsonProperty(Order = 240)]
		public bool Actor3Prepared { get; set; }

		[ContainerField(241), LayoutImmutable, Blittable, JsonProperty(Order = 241)]
		public bool Actor4Prepared { get; set; }

		[ContainerField(242), LayoutImmutable, Blittable, JsonProperty(Order = 242)]
		public bool Actor5Prepared { get; set; }

		[ContainerField(243), LayoutImmutable, Blittable, JsonProperty(Order = 243)]
		public bool Actor6Prepared { get; set; }

		[ContainerField(244), LayoutImmutable, Blittable, JsonProperty(Order = 244)]
		public bool CheckActor1Finished { get; set; }

		[ContainerField(245), LayoutImmutable, Blittable, JsonProperty(Order = 245)]
		public bool CheckActor2Finished { get; set; }

		[ContainerField(246), LayoutImmutable, Blittable, JsonProperty(Order = 246)]
		public bool CheckActor3Finished { get; set; }

		[ContainerField(247), LayoutImmutable, Blittable, JsonProperty(Order = 247)]
		public bool CheckActor4Finished { get; set; }

		[ContainerField(248), LayoutImmutable, Blittable, JsonProperty(Order = 248)]
		public bool CheckActor5Finished { get; set; }

		[ContainerField(249), LayoutImmutable, Blittable, JsonProperty(Order = 249)]
		public bool CheckActor6Finished { get; set; }

		[ContainerField(250), LayoutImmutable, Blittable, JsonProperty(Order = 250)]
		public bool UseInputEventPlayerAsPlayer1 { get; set; }

		[ContainerField(251), LayoutImmutable, Blittable, JsonProperty(Order = 251)]
		public bool UseExternalTime { get; set; }

		[ContainerField(252), LayoutImmutable, Blittable, JsonProperty(Order = 252)]
		public bool WorldSpace { get; set; }

	}
}
