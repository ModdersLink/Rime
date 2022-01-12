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
	[ContainerType(4, 24)]
	public class WeaponDeployTimeModifier : 
		WeaponModifierBase
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float DeployTime { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable]
		public float DisableZoomOnDeployTime { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public float AltDeployTime { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public int AltDeployId { get; set; }

	}
}
