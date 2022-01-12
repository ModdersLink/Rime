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
	[ContainerType(16, 112)]
	public class PathFollowingComponentData : 
		ComponentData
	{
		[ContainerField(96), LayoutImmutable, Blittable]
		public float UpdatePathAtDistancePercent { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable]
		public uint PreferredPathfindingIndex { get; set; }

		[ContainerField(104)]
		public List<uint> AlternatePathfindingIndices { get; set; } = new();

		[ContainerField(108), LayoutImmutable, Blittable]
		public float MovementCorridorRadius { get; set; }

	}
}
