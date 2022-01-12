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
	[ContainerType(16, 208)]
	public class AreaTriggerEntityData : 
		TriggerEntityData
	{
		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform GeometryTransform { get; set; } = new();

		[ContainerField(176)]
		public AreaTriggerInclude Include { get; set; } = new();

		[ContainerField(180), LayoutImmutable, Blittable]
		public float InsideAreaEventRepeatTime { get; set; }

		[ContainerField(184), LayoutImmutable, Blittable]
		public float Radius { get; set; }

		[ContainerField(188), LayoutImmutable, Blittable]
		public bool UseCharacterEntity { get; set; }

		[ContainerField(189), LayoutImmutable, Blittable]
		public bool OneInsideAreaEventPerSoldier { get; set; }

		[ContainerField(190), LayoutImmutable, Blittable]
		public bool TriggerOnlyOnLeave { get; set; }

		[ContainerField(191), LayoutImmutable, Blittable]
		public bool ResetOnEnable { get; set; }

		[ContainerField(192), LayoutImmutable, Blittable]
		public bool TriggerOnLeaveOnDeath { get; set; }

		[ContainerField(193), LayoutImmutable, Blittable]
		public bool TriggerOnLeaveOnDisable { get; set; }

	}
}
