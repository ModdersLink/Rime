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
	[ContainerType(4, 64)]
	public class RoadData : 
		RibbonData
	{
		[ContainerField(48)]
		public CtrRef<SurfaceShaderBaseAsset> Shader2d { get; set; } = new();

		[ContainerField(52)]
		public CtrRef<SurfaceShaderBaseAsset> Shader3dZOnly { get; set; } = new();

		[ContainerField(56), LayoutImmutable, Blittable]
		public float UvTileFactor { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable]
		public bool StickToTerrain { get; set; }

	}
}
