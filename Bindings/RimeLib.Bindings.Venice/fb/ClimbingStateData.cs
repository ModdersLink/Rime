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
	[ContainerType(4, 52)]
	public class ClimbingStateData : 
		CharacterStateData
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float LateralInputScale { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public float DownAngleLimit { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float DropOffAngle { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float AttractionVelocity { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public float PushAwayVelocity { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public float ClimbHeightOffset { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public float ClimbOffVerticalDistance { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public float ClimbOffVerticalTime { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public float ClimbOffHorizontalDistance { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public float ClimbOffHorizontalTime { get; set; }

	}
}
