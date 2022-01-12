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
	public class TerrainQuadDecalData : 
		VisualVectorShapeData
	{
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 UserMasks { get; set; } = new();

		[ContainerField(64)]
		public CtrRef<SurfaceShaderBaseAsset> Shader3dZOnly { get; set; } = new();

		[ContainerField(68)]
		public CtrRef<SurfaceShaderBaseAsset> Shader2d { get; set; } = new();

		[ContainerField(72)]
		public CtrRef<TerrainQuadDecalAtlasTileTemplateData> AtlasTileTemplate { get; set; } = new();

		[ContainerField(76)]
		public TerrainQuadDecalAtlasTile AtlasTile { get; set; } = new();

	}
}
