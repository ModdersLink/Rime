///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[MemberInfoFlag(137), ContainerEnum]
	public enum TerrainRenderMode : int
	{
		TerrainRenderMode_Default = 0,
		TerrainRenderMode_DrawPassCount2d = 1,
		TerrainRenderMode_LayerCount2d = 2,
		TerrainRenderMode_LayerCount3d = 3,
		TerrainRenderMode_MaskedLayerCount2d = 4,
		TerrainRenderMode_MaskedLayerCount3d = 5
	}

}
