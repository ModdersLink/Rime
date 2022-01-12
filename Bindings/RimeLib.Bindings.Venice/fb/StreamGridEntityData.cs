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
	public class StreamGridEntityData : 
		SpatialEntityData
	{
		[ContainerField(80), LayoutImmutable, Blittable]
		public float CellSize { get; set; }

		[ContainerField(84), LayoutImmutable, Blittable]
		public float ViewDistance { get; set; }

		[ContainerField(88), LayoutImmutable, Blittable]
		public int MaxStreamInCountPerFrame { get; set; }

		[ContainerField(92), LayoutImmutable, Blittable]
		public int MaxStreamOutCountPerFrame { get; set; }

		[ContainerField(96)]
		public List<StreamGridCell> Cells { get; set; } = new();

	}
}
