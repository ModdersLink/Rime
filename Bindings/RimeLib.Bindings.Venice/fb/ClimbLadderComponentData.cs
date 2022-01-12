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
	[ContainerType(16, 144)]
	public class ClimbLadderComponentData : 
		ComponentData
	{
		[ContainerField(96), LayoutImmutable, Blittable]
		public int ClimbPhase { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable]
		public int ConnectPhase { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable]
		public float ConnectJointDisplacement { get; set; }

		[ContainerField(108)]
		public ClimbLadderBinding Binding { get; set; } = new();

	}
}
