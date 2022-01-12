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
	public class AmmoCrateEntityData : 
		GameEntityData
	{
		[ContainerField(96)]
		public CtrRef<MapMarkerEntityData> Marker { get; set; } = new();

		[ContainerField(100)]
		public CtrRef<StaticModelEntityData> Model { get; set; } = new();

		[ContainerField(104), LayoutImmutable, Blittable]
		public float RefillDelay { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable]
		public float Radius { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable]
		public bool EnableReplenish { get; set; }

	}
}
