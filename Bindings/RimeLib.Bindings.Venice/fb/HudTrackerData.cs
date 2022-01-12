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
	[ContainerType(4, 44)]
	public class HudTrackerData : 
		UIPartData
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float MaxDistance { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable]
		public float StartFadeDistance { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public float SecondFadeDistance { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float FadeMinAlpha { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float IconSize { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public float TrackerHudRadiusX { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public float TrackerHudRadiusY { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public float DistanceTextOffsetY { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public bool ShowDistance { get; set; }

		[ContainerField(41), LayoutImmutable, Blittable]
		public bool DisplayExtraInfo { get; set; }

	}
}
