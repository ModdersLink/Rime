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
	[ContainerType(4, 60)]
	public class CannedScenarioEntityData : 
		EntityData
	{
		[ContainerField(12)]
		public CannedAnimationBinding CannedAnimBinding { get; set; } = new();

		[ContainerField(52), LayoutImmutable, Blittable]
		public int AnimationEntitySpacePriority { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable]
		public bool AlwaysClearEntitySpaceWhenInScenario { get; set; }

	}
}
