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
	[ContainerType(16, 96)]
	public class GameEntityData : 
		SpatialEntityData
	{
		[ContainerField(80)]
		public RefArray<GameObjectData> Components { get; set; } = new();

		[ContainerField(84), LayoutImmutable, Blittable]
		public bool Enabled { get; set; }

		[ContainerField(85), LayoutImmutable, Blittable]
		public sbyte RuntimeComponentCount { get; set; }

	}
}
