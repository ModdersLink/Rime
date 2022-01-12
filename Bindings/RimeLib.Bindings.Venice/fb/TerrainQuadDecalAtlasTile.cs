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
	[ContainerType(4, 20)]
	public class TerrainQuadDecalAtlasTile
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public uint TileIndexX { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public uint TileIndexY { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public uint TileCountX { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public uint TileCountY { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public bool FlipX { get; set; }
		
		[ContainerField(17), LayoutImmutable, Blittable]
		public bool FlipY { get; set; }
		
	}
}
