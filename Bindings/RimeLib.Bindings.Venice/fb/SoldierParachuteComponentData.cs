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
	[ContainerType(16, 144)]
	public class SoldierParachuteComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public SoldierParachuteBinding Binding { get; set; } = new();

		[ContainerField(116)]
		public AimingConstraintsData AimingConstraints { get; set; } = new();

		[ContainerField(132), LayoutImmutable, Blittable]
		public float UndeployTime { get; set; }

	}
}
