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
	[ContainerType(1, 3)]
	public class PoseConstraintsData
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public bool StandPose { get; set; }
		
		[ContainerField(1), LayoutImmutable, Blittable]
		public bool CrouchPose { get; set; }
		
		[ContainerField(2), LayoutImmutable, Blittable]
		public bool PronePose { get; set; }
		
	}
}
