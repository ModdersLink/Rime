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
	[ContainerType(4, 24)]
	public class SubsystemTimingConfigData
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float Sensing { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float Evaluation { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public float GoalUpdates { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float IntentUpdates { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float BehaviourSelection { get; set; }
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float BehaviourExecution { get; set; }
		
	}
}
