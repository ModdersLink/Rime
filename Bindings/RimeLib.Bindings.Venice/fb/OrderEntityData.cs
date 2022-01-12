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
	[ContainerType(4, 36)]
	public class OrderEntityData : 
		EntityData
	{
		[ContainerField(12), LayoutImmutable]
		public string DebugName { get; set; } = string.Empty;

		[ContainerField(16), LayoutImmutable, Blittable]
		public float IssueOrderDelay { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float OnCompleteTimeOut { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float OnFailedTimeOut { get; set; }

		[ContainerField(28)]
		public ReadinessLevel ReadinessOnStart { get; set; } = new();

		[ContainerField(32), LayoutImmutable, Blittable]
		public bool Enabled { get; set; }

	}
}
