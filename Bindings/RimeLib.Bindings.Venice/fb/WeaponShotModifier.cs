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
	[ContainerType(16, 48)]
	public class WeaponShotModifier : 
		WeaponModifierBase
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 InitialSpeed { get; set; } = new();

		[ContainerField(32), LayoutImmutable, Blittable]
		public int NumberOfBulletsPerShell { get; set; }

	}
}
