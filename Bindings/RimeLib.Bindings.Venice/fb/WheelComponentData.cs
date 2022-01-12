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
	public class WheelComponentData : 
		PartComponentData
	{
		[ContainerField(112)]
		public CtrRef<WheelConfigData> Config { get; set; } = new();

		[ContainerField(116)]
		public WheelPhysicsType PhysicsType { get; set; } = new();

		[ContainerField(120), LayoutImmutable, Blittable]
		public float EffectClampVelocity { get; set; }

	}
}
