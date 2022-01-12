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
	public class AILocoVaultTaskData
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 StartPoint { get; set; } = new();
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float DistanceBeforeVault { get; set; }
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float HeightBeforeVault { get; set; }
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float HeightAfterVault { get; set; }
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float LengthOfVaultableObject { get; set; }
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float WorldAngle { get; set; }
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float DistanceAfterVault { get; set; }
		
		[ContainerField(40)]
		public WaypointVaultType VaultType { get; set; } = new();
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public bool UseClientPosition { get; set; }
		
	}
}
