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
	public class RecoilData
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float MaxRecoilAngleX { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float MinRecoilAngleX { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public float MaxRecoilAngleY { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float MinRecoilAngleY { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float MaxRecoilAngleZ { get; set; }
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float MinRecoilAngleZ { get; set; }
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float MaxRecoilFov { get; set; }
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float MinRecoilFov { get; set; }
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public bool RecoilFollowsDispersion { get; set; }
		
	}
}
