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
	[ContainerType(4, 28)]
	public class FadeEntityData : 
		EntityData
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float FadeTime { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public float MaxWaitFadedWhileStreamingTime { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public bool FadeScreen { get; set; }

		[ContainerField(21), LayoutImmutable, Blittable]
		public bool FadeUI { get; set; }

		[ContainerField(22), LayoutImmutable, Blittable]
		public bool FadeRumble { get; set; }

		[ContainerField(23), LayoutImmutable, Blittable]
		public bool FadeAudio { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public bool FadeMovie { get; set; }

		[ContainerField(25), LayoutImmutable, Blittable]
		public bool StartFaded { get; set; }

	}
}
