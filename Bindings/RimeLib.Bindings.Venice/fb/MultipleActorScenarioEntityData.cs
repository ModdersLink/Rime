///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
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
		[ContainerField(80), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform WorldSpaceConnectTransform { get; set; } = new();

		[ContainerField(144), LayoutImmutable, Blittable]
		public int Actor5Part { get; set; }

		[ContainerField(148)]
		public AntRef ScenarioAntRef { get; set; } = new();

		[ContainerField(152), LayoutImmutable, Blittable]
		public int LevelChoice { get; set; }

		[ContainerField(156), LayoutImmutable, Blittable]
		public int ScenarioChoice { get; set; }

		[ContainerField(160)]
		public Realm Realm { get; set; } = new();

		[ContainerField(164), LayoutImmutable, Blittable]
		public int Actor6Part { get; set; }

		[ContainerField(168), LayoutImmutable, Blittable]
		public int Actor1 { get; set; }

		[ContainerField(172), LayoutImmutable, Blittable]
		public int Actor1Part { get; set; }

		[ContainerField(176), LayoutImmutable, Blittable]
		public int Actor1SecondPart { get; set; }

		[ContainerField(180), LayoutImmutable, Blittable]
		public int Actor2 { get; set; }

		[ContainerField(184), LayoutImmutable, Blittable]
		public int Actor2Part { get; set; }

		[ContainerField(188), LayoutImmutable, Blittable]
		public int Actor2SecondPart { get; set; }

		[ContainerField(192), LayoutImmutable, Blittable]
		public int Actor3 { get; set; }

		[ContainerField(196), LayoutImmutable, Blittable]
		public int Actor3Part { get; set; }

		[ContainerField(200), LayoutImmutable, Blittable]
		public int Actor3SecondPart { get; set; }

		[ContainerField(204), LayoutImmutable, Blittable]
		public int Actor4 { get; set; }

		[ContainerField(208), LayoutImmutable, Blittable]
		public int Actor4Part { get; set; }

		[ContainerField(212), LayoutImmutable, Blittable]
		public int Actor4SecondPart { get; set; }

		[ContainerField(216), LayoutImmutable, Blittable]
		public int Actor5 { get; set; }

		[ContainerField(220), LayoutImmutable, Blittable]
		public int Actor5SecondPart { get; set; }

		[ContainerField(224), LayoutImmutable, Blittable]
		public int Actor6SecondPart { get; set; }

		[ContainerField(228), LayoutImmutable, Blittable]
		public int Actor6 { get; set; }

		[ContainerField(232), LayoutImmutable, Blittable]
		public float ExternalTime { get; set; }

		[ContainerField(236), LayoutImmutable, Blittable]
		public bool AligningEnabled { get; set; }

		[ContainerField(237), LayoutImmutable, Blittable]
		public bool ScenarioActive { get; set; }

		[ContainerField(238), LayoutImmutable, Blittable]
		public bool Actor1Prepared { get; set; }

		[ContainerField(239), LayoutImmutable, Blittable]
		public bool Actor2Prepared { get; set; }

		[ContainerField(240), LayoutImmutable, Blittable]
		public bool Actor3Prepared { get; set; }

		[ContainerField(241), LayoutImmutable, Blittable]
		public bool Actor4Prepared { get; set; }

		[ContainerField(242), LayoutImmutable, Blittable]
		public bool Actor5Prepared { get; set; }

		[ContainerField(243), LayoutImmutable, Blittable]
		public bool Actor6Prepared { get; set; }

		[ContainerField(244), LayoutImmutable, Blittable]
		public bool CheckActor1Finished { get; set; }

		[ContainerField(245), LayoutImmutable, Blittable]
		public bool CheckActor2Finished { get; set; }

		[ContainerField(246), LayoutImmutable, Blittable]
		public bool CheckActor3Finished { get; set; }

		[ContainerField(247), LayoutImmutable, Blittable]
		public bool CheckActor4Finished { get; set; }

		[ContainerField(248), LayoutImmutable, Blittable]
		public bool CheckActor5Finished { get; set; }

		[ContainerField(249), LayoutImmutable, Blittable]
		public bool CheckActor6Finished { get; set; }

		[ContainerField(250), LayoutImmutable, Blittable]
		public bool UseInputEventPlayerAsPlayer1 { get; set; }

		[ContainerField(251), LayoutImmutable, Blittable]
		public bool UseExternalTime { get; set; }

		[ContainerField(252), LayoutImmutable, Blittable]
		public bool WorldSpace { get; set; }

	}
}
