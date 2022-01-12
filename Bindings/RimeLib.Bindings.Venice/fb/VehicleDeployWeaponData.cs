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
	public class VehicleDeployWeaponData : 
		WeaponData
	{
		[ContainerField(16), LayoutImmutable, Blittable]
		public float DeployAreaRadius { get; set; }

		[ContainerField(20)]
		public CtrRef<ObjectBlueprint> PreviewObject { get; set; } = new();

		[ContainerField(24), LayoutImmutable, Blittable]
		public float DeployAreaGroundRayLength { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public float DeployAreaGroundFlatness { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public bool UsePreview { get; set; }

		[ContainerField(33), LayoutImmutable, Blittable]
		public bool CheckClearSky { get; set; }

		[ContainerField(34), LayoutImmutable, Blittable]
		public bool CanRemoteEnterVehicle { get; set; }

	}
}
