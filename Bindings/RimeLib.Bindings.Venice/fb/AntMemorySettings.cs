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
	[ContainerType(4, 40)]
	public class AntMemorySettings : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public int RTPoolLayersControllers { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable]
		public int RTPoolStateflowControllers { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public int RTPoolStateflowNodeControllers { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public int RTPoolTransitionControllers { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public int RTPoolClipControllers { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public int RTPoolChooserControllers { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public int RTPoolLoopingControllers { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public int RTPoolTransparentControllers { get; set; }

	}
}
