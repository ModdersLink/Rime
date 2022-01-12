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
	[ContainerType(16, 112)]
	public class AnimationTurretRotationComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public List<TurretRotationInfo> Rotations { get; set; } = new();

		[ContainerField(100), LayoutImmutable, Blittable]
		public int SoldierBaseIndex { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable]
		public bool UseVehicleWorldTransform { get; set; }

		[ContainerField(105), LayoutImmutable, Blittable]
		public bool OutputWorldTransform { get; set; }

	}
}
