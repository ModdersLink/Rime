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
	[ContainerType(4, 16)]
	public class PhysicsDebugSettings : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public uint TimingRecursionDepth { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable]
		public bool UsePhysicsCpuTimers { get; set; }

		[ContainerField(13), LayoutImmutable, Blittable]
		public bool DebugHingeConstraints { get; set; }

	}
}
