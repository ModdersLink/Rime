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
	[ContainerType(16, 48)]
	public class BotPriorityConfigData : 
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 DebugColor { get; set; } = new();

		[ContainerField(32), LayoutImmutable, Blittable]
		public float Distance { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public int Period { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public float AngleOffset { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public bool AppliesToExecution { get; set; }

		[ContainerField(45), LayoutImmutable, Blittable]
		public bool AppliesToDecisions { get; set; }

	}
}
