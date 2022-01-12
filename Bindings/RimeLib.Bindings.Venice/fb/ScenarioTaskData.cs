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
	[ContainerType(16, 80)]
	public class ScenarioTaskData
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 EndPointWorldOffset { get; set; } = new();
		
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 StartPoint { get; set; } = new();
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public int ScenarioId { get; set; }
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public int ActorId { get; set; }
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public int PartId { get; set; }
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public int LevelId { get; set; }
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public float WorldAngle { get; set; }
		
		[ContainerField(52)]
		public List<LinearTransform> ConnectTransforms { get; set; } = new();
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public float StartTurnDistance { get; set; }
		
		[ContainerField(60), LayoutImmutable, Blittable]
		public float StartTimerDistance { get; set; }
		
		[ContainerField(64), LayoutImmutable, Blittable]
		public float TriggerScenarioDelay { get; set; }
		
		[ContainerField(68), LayoutImmutable, Blittable]
		public bool TriggerScenario { get; set; }
		
		[ContainerField(69), LayoutImmutable, Blittable]
		public bool UseClientPosition { get; set; }
		
	}
}
