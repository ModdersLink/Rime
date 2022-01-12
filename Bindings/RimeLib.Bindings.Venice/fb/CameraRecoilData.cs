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
	[ContainerType(4, 20)]
	public class CameraRecoilData : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float SpringConstant { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable]
		public float SpringDamping { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public float SpringMinThresholdAngle { get; set; }

	}
}
