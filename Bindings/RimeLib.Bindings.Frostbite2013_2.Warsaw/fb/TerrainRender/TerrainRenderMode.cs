///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;


namespace fb.TerrainRender;

[ContainerType(1, 4)]
public enum TerrainRenderMode : int
{
	TerrainRenderMode_Default = 0,
	TerrainRenderMode_DrawPassCount2d = 1,
	TerrainRenderMode_LayerCount2d = 2,
	TerrainRenderMode_LayerCount3d = 3,
	TerrainRenderMode_MaskedLayerCount2d = 4,
	TerrainRenderMode_MaskedLayerCount3d = 5,
	TerrainRenderMode_DensityMap = 6,
}

