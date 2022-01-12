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
	public class ShootAtFromCoverData : 
		EntityData
	{
		[ContainerField(12)]
		public StrengthType StrengthType { get; set; } = new();

		[ContainerField(16)]
		public ShootType ShootType { get; set; } = new();

		[ContainerField(20), LayoutImmutable, Blittable]
		public bool CycleTargets { get; set; }

		[ContainerField(21), LayoutImmutable, Blittable]
		public bool RandomTargetOrder { get; set; }

		[ContainerField(22), LayoutImmutable, Blittable]
		public bool PreferAlternativeWeapon { get; set; }

	}
}
