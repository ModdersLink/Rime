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
	[ContainerType(16, 128)]
	public class ClientEffectMaskVolumeEntityData : 
		GameEntityData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 ApplyEffectCurve { get; set; } = new();

		[ContainerField(112), LayoutImmutable, Blittable]
		public float LifeTimeInSeconds { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable]
		public float UpdatePeriodInSeconds { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable]
		public float Radius { get; set; }

	}
}
