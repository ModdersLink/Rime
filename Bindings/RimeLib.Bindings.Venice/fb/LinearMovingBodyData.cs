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
	[ContainerType(16, 80)]
	public class LinearMovingBodyData : 
		MovingBodyData
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Axis { get; set; } = new();

		[ContainerField(32)]
		public EndPointData Start { get; set; } = new();

		[ContainerField(52)]
		public EndPointData End { get; set; } = new();

	}
}
